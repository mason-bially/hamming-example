namespace WindowsFormsApp1
{
    partial class HammingExample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_0_string = new System.Windows.Forms.TextBox();
            this.label_0 = new System.Windows.Forms.Label();
            this.button_0_toBytes = new System.Windows.Forms.Button();
            this.button_0_fromBytes = new System.Windows.Forms.Button();
            this.label_1 = new System.Windows.Forms.Label();
            this.textBox_1_bytes = new System.Windows.Forms.TextBox();
            this.button_1_encode = new System.Windows.Forms.Button();
            this.label_2 = new System.Windows.Forms.Label();
            this.textBox_2_encoded = new System.Windows.Forms.TextBox();
            this.button_2_decode = new System.Windows.Forms.Button();
            this.textBox_3_decoded_bytes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_3_decoded_string = new System.Windows.Forms.TextBox();
            this.textBox_3_decoded_errors = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_1_encodeStriped = new System.Windows.Forms.Button();
            this.button_2_decodeStriped = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_0_string
            // 
            this.textBox_0_string.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_0_string.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_0_string.Location = new System.Drawing.Point(121, 12);
            this.textBox_0_string.Name = "textBox_0_string";
            this.textBox_0_string.Size = new System.Drawing.Size(461, 18);
            this.textBox_0_string.TabIndex = 0;
            // 
            // label_0
            // 
            this.label_0.AutoSize = true;
            this.label_0.Location = new System.Drawing.Point(12, 13);
            this.label_0.Name = "label_0";
            this.label_0.Size = new System.Drawing.Size(34, 13);
            this.label_0.TabIndex = 1;
            this.label_0.Text = "String";
            // 
            // button_0_toBytes
            // 
            this.button_0_toBytes.Location = new System.Drawing.Point(121, 38);
            this.button_0_toBytes.Name = "button_0_toBytes";
            this.button_0_toBytes.Size = new System.Drawing.Size(120, 23);
            this.button_0_toBytes.TabIndex = 2;
            this.button_0_toBytes.Text = "\\/  To Bytes  \\/";
            this.button_0_toBytes.UseVisualStyleBackColor = true;
            this.button_0_toBytes.Click += new System.EventHandler(this.button_0_toBytes_Click);
            // 
            // button_0_fromBytes
            // 
            this.button_0_fromBytes.Location = new System.Drawing.Point(247, 38);
            this.button_0_fromBytes.Name = "button_0_fromBytes";
            this.button_0_fromBytes.Size = new System.Drawing.Size(120, 23);
            this.button_0_fromBytes.TabIndex = 3;
            this.button_0_fromBytes.Text = "/\\  From Bytes  /\\";
            this.button_0_fromBytes.UseVisualStyleBackColor = true;
            this.button_0_fromBytes.Click += new System.EventHandler(this.button_0_fromBytes_Click);
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(12, 68);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(33, 13);
            this.label_1.TabIndex = 5;
            this.label_1.Text = "Bytes";
            // 
            // textBox_1_bytes
            // 
            this.textBox_1_bytes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_1_bytes.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_1_bytes.Location = new System.Drawing.Point(121, 67);
            this.textBox_1_bytes.Name = "textBox_1_bytes";
            this.textBox_1_bytes.Size = new System.Drawing.Size(461, 18);
            this.textBox_1_bytes.TabIndex = 4;
            // 
            // button_1_encode
            // 
            this.button_1_encode.Location = new System.Drawing.Point(121, 91);
            this.button_1_encode.Name = "button_1_encode";
            this.button_1_encode.Size = new System.Drawing.Size(120, 23);
            this.button_1_encode.TabIndex = 6;
            this.button_1_encode.Text = "\\/  Encode  \\/";
            this.button_1_encode.UseVisualStyleBackColor = true;
            this.button_1_encode.Click += new System.EventHandler(this.button_1_encode_Click);
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Location = new System.Drawing.Point(12, 121);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(50, 13);
            this.label_2.TabIndex = 8;
            this.label_2.Text = "Encoded";
            // 
            // textBox_2_encoded
            // 
            this.textBox_2_encoded.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_2_encoded.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_2_encoded.Location = new System.Drawing.Point(121, 120);
            this.textBox_2_encoded.Name = "textBox_2_encoded";
            this.textBox_2_encoded.Size = new System.Drawing.Size(461, 18);
            this.textBox_2_encoded.TabIndex = 7;
            // 
            // button_2_decode
            // 
            this.button_2_decode.Location = new System.Drawing.Point(121, 144);
            this.button_2_decode.Name = "button_2_decode";
            this.button_2_decode.Size = new System.Drawing.Size(120, 23);
            this.button_2_decode.TabIndex = 9;
            this.button_2_decode.Text = "\\/  Decode  \\/";
            this.button_2_decode.UseVisualStyleBackColor = true;
            this.button_2_decode.Click += new System.EventHandler(this.button_2_decode_Click);
            // 
            // textBox_3_decoded_bytes
            // 
            this.textBox_3_decoded_bytes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_3_decoded_bytes.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_3_decoded_bytes.Location = new System.Drawing.Point(121, 173);
            this.textBox_3_decoded_bytes.Name = "textBox_3_decoded_bytes";
            this.textBox_3_decoded_bytes.Size = new System.Drawing.Size(461, 18);
            this.textBox_3_decoded_bytes.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bytes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "String";
            // 
            // textBox_3_decoded_string
            // 
            this.textBox_3_decoded_string.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_3_decoded_string.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_3_decoded_string.Location = new System.Drawing.Point(121, 221);
            this.textBox_3_decoded_string.Name = "textBox_3_decoded_string";
            this.textBox_3_decoded_string.Size = new System.Drawing.Size(461, 18);
            this.textBox_3_decoded_string.TabIndex = 13;
            // 
            // textBox_3_decoded_errors
            // 
            this.textBox_3_decoded_errors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_3_decoded_errors.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_3_decoded_errors.Location = new System.Drawing.Point(121, 197);
            this.textBox_3_decoded_errors.Name = "textBox_3_decoded_errors";
            this.textBox_3_decoded_errors.Size = new System.Drawing.Size(461, 18);
            this.textBox_3_decoded_errors.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Errors";
            // 
            // button_1_encodeStriped
            // 
            this.button_1_encodeStriped.Location = new System.Drawing.Point(247, 91);
            this.button_1_encodeStriped.Name = "button_1_encodeStriped";
            this.button_1_encodeStriped.Size = new System.Drawing.Size(120, 23);
            this.button_1_encodeStriped.TabIndex = 16;
            this.button_1_encodeStriped.Text = "\\/  Stripe Encode  \\/";
            this.button_1_encodeStriped.UseVisualStyleBackColor = true;
            this.button_1_encodeStriped.Click += new System.EventHandler(this.button_1_encodeStriped_Click);
            // 
            // button_2_decodeStriped
            // 
            this.button_2_decodeStriped.Location = new System.Drawing.Point(247, 144);
            this.button_2_decodeStriped.Name = "button_2_decodeStriped";
            this.button_2_decodeStriped.Size = new System.Drawing.Size(120, 23);
            this.button_2_decodeStriped.TabIndex = 17;
            this.button_2_decodeStriped.Text = "\\/  Stripe Decode  \\/";
            this.button_2_decodeStriped.UseVisualStyleBackColor = true;
            this.button_2_decodeStriped.Click += new System.EventHandler(this.button_2_decodeStriped_Click);
            // 
            // HammingExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 266);
            this.Controls.Add(this.button_2_decodeStriped);
            this.Controls.Add(this.button_1_encodeStriped);
            this.Controls.Add(this.textBox_3_decoded_errors);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_3_decoded_string);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_3_decoded_bytes);
            this.Controls.Add(this.button_2_decode);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.textBox_2_encoded);
            this.Controls.Add(this.button_1_encode);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.textBox_1_bytes);
            this.Controls.Add(this.button_0_fromBytes);
            this.Controls.Add(this.button_0_toBytes);
            this.Controls.Add(this.label_0);
            this.Controls.Add(this.textBox_0_string);
            this.Name = "HammingExample";
            this.Text = "Hamming Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_0_string;
        private System.Windows.Forms.Label label_0;
        private System.Windows.Forms.Button button_0_toBytes;
        private System.Windows.Forms.Button button_0_fromBytes;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.TextBox textBox_1_bytes;
        private System.Windows.Forms.Button button_1_encode;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.TextBox textBox_2_encoded;
        private System.Windows.Forms.Button button_2_decode;
        private System.Windows.Forms.TextBox textBox_3_decoded_bytes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_3_decoded_string;
        private System.Windows.Forms.TextBox textBox_3_decoded_errors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_1_encodeStriped;
        private System.Windows.Forms.Button button_2_decodeStriped;
    }
}

