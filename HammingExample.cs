using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class HammingExample : Form
    {
        public HammingExample()
        {
            InitializeComponent();
        }

        int[] _errors;

        byte[] _hamming_8_4_encode =
        {
            0b0000_0000,
            0b1000_0111,
            0b1001_1001,
            0b0001_1110,

            0b1010_1010,
            0b0010_1101,
            0b0011_0011,
            0b1011_0100,

            0b0100_1011,
            0b1100_1100,
            0b1101_0010,
            0b0101_0101,

            0b1110_0001,
            0b0110_0110,
            0b0111_1000,
            0b1111_1111,
        };

        private byte _hamming_8_4_decode(byte b, out int err)
        {
            // Compute syndrome 
            err = 0;
            for (int i = 1; i < 8; i++)
                if (b.GetBit(i - 1)) // is 1
                    err ^= i;

            // Correct error
            if (err != 0)
                b = b.ToggleBit(err - 1);

            // Extract values:
            b = (byte)(
                  ((b & 0b00000100) >> 2)
                + ((b & 0b01110000) >> 3));

            return b;
        }

        private byte[] HammingEncodeBytes(byte[] in_)
        {
            byte[] out_ = new byte[in_.Length * 2];

            // copy data to output buffer
            for (var i = 0; i < out_.Length; i += 2)
            {
                out_[i] = in_[i / 2];
                out_[i + 1] = in_[i / 2];
            }

            // update in place
            for (var i = 0; i < out_.Length; i += 2)
            {
                out_[i] = _hamming_8_4_encode[out_[i] & 0b0000_1111];
                out_[i + 1] = _hamming_8_4_encode[(out_[i + 1] & 0b1111_0000) >> 4];
            }

            return out_;
        }

        private byte[] HammingDecodeAndCorrectBytes(byte[] in_)
        {
            byte[] out_ = new byte[in_.Length / 2];
            _errors = new int[in_.Length];

            for (var i = 0; i < out_.Length; i++)
            {
                out_[i] = 0;
                out_[i] += (byte)(_hamming_8_4_decode(in_[i * 2 + 0], out _errors[i * 2 + 0]) << 0);
                out_[i] += (byte)(_hamming_8_4_decode(in_[i * 2 + 1], out _errors[i * 2 + 1]) << 4);
            }

            return out_;
        }

        private byte[] HammingStripedEncodeBytes(byte[] in_)
        {
            // Have to pad it:
            if (in_.Length % 4 != 0)
            {
                var new_in = new byte[in_.Length + (4 - (in_.Length % 4))];
                Buffer.BlockCopy(in_, 0, new_in, 0, in_.Length);
                for (int i = in_.Length; i < new_in.Length; i++) new_in[i] = 0;
                in_ = new_in;
            }

            byte[] out_ = HammingEncodeBytes(in_);

            // Now we stripe it:
            byte[] temp = new byte[8];
            for (var i = 0; i < out_.Length; i += 8)
            {
                // Copy to temp memory
                Buffer.BlockCopy(out_, i, temp, 0, 8);
                
                // Stripe
                for (var j = 0; j < 8; j++)
                {
                    out_[i + j] = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        out_[i + j] += (byte)((temp[k].GetBit(j) ? 1 : 0) << k);
                    }
                }
            }

            return out_;
        }

        private byte[] HammingStripedDecodeAndCorrectBytes(byte[] in_)
        {
            // First we unstripe it
            byte[] temp = new byte[8];
            for (var i = 0; i < in_.Length; i += 8)
            {
                // Copy to temp memory
                Buffer.BlockCopy(in_, i, temp, 0, 8);

                // De-stripe
                for (var j = 0; j < 8; j++)
                {
                    in_[i + j] = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        in_[i + j] += (byte)((temp[k].GetBit(j) ? 1 : 0) << k);
                    }
                }
            }

            byte[] out_ = HammingDecodeAndCorrectBytes(in_);

            return out_;
        }

        private void _display_errors()
        {
            textBox_3_decoded_errors.Text = string.Join(" ",
                _errors.Select((e, i) => new { i, e })
                .GroupBy(x => x.i / 2)
                .Select(g => string.Join("", g.Select(x => x.e.ToString()))));
        }

        private void button_0_toBytes_Click(object sender, EventArgs e)
        {
            string in_text = textBox_0_string.Text;

            byte[] out_bytes = Encoding.ASCII.GetBytes(in_text);

            textBox_1_bytes.Text = out_bytes.ToByteString();
        }

        private void button_0_fromBytes_Click(object sender, EventArgs e)
        {
            byte[] in_bytes = textBox_1_bytes.Text.FromByteString();

            string out_text = Encoding.ASCII.GetString(in_bytes);

            textBox_1_bytes.Text = out_text;
        }

        private void button_1_encode_Click(object sender, EventArgs e)
        {
            byte[] in_bytes = textBox_1_bytes.Text.FromByteString();

            byte[] out_bytes = HammingEncodeBytes(in_bytes);

            textBox_2_encoded.Text = out_bytes.ToByteString();
        }

        private void button_1_encodeStriped_Click(object sender, EventArgs e)
        {
            byte[] in_bytes = textBox_1_bytes.Text.FromByteString();

            byte[] out_bytes = HammingStripedEncodeBytes(in_bytes);

            textBox_2_encoded.Text = out_bytes.ToByteString();
        }

        private void button_2_decode_Click(object sender, EventArgs e)
        {
            byte[] in_bytes = textBox_2_encoded.Text.FromByteString();

            byte[] out_bytes = HammingDecodeAndCorrectBytes(in_bytes);

            textBox_3_decoded_bytes.Text = out_bytes.ToByteString();
            textBox_3_decoded_string.Text = Encoding.ASCII.GetString(out_bytes);
            _display_errors();
        }

        private void button_2_decodeStriped_Click(object sender, EventArgs e)
        {
            byte[] in_bytes = textBox_2_encoded.Text.FromByteString();

            byte[] out_bytes = HammingStripedDecodeAndCorrectBytes(in_bytes);

            textBox_3_decoded_bytes.Text = out_bytes.ToByteString();
            textBox_3_decoded_string.Text = Encoding.ASCII.GetString(out_bytes);
            _display_errors();
        }
    }

    public static class Extension
    {
        public static string ToByteString(this byte[] bytes)
        {
            return string.Join(" ", bytes.Select(b => b.ToString("X2")));
        }
        public static byte[] FromByteString(this string str)
        {
            return str.Split(' ').Select(s => Convert.ToByte(s, 16)).ToArray();
        }

        public static bool GetBit(this byte b, int bitNumber)
        {
            return (b & (1 << bitNumber)) != 0;
        }

        public static byte ToggleBit(this byte b, int bitNumber)
        {
            return (byte)(b ^ (1 << bitNumber));
        }
    }

}
