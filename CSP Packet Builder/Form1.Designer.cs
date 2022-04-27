
namespace CSP_Packet_Builder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.prio = new System.Windows.Forms.ComboBox();
            this.src = new System.Windows.Forms.TextBox();
            this.dest = new System.Windows.Forms.TextBox();
            this.dest_port = new System.Windows.Forms.TextBox();
            this.src_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.header_hex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Binary4 = new System.Windows.Forms.TextBox();
            this.Binary5 = new System.Windows.Forms.TextBox();
            this.Binary6 = new System.Windows.Forms.TextBox();
            this.Binary7 = new System.Windows.Forms.TextBox();
            this.Binary0 = new System.Windows.Forms.TextBox();
            this.Binary1 = new System.Windows.Forms.TextBox();
            this.Binary2 = new System.Windows.Forms.TextBox();
            this.Binary3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox_HMAC = new System.Windows.Forms.CheckBox();
            this.checkBox_XTEA = new System.Windows.Forms.CheckBox();
            this.checkBox_RDP = new System.Windows.Forms.CheckBox();
            this.checkBox_CRC = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.header_BIN_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "CubeSat Space Protocol - CSP Packet Header";
            // 
            // prio
            // 
            this.prio.FormattingEnabled = true;
            this.prio.Items.AddRange(new object[] {
            "0-Critical",
            "1-High",
            "2-Normal",
            "3-Low"});
            this.prio.Location = new System.Drawing.Point(42, 122);
            this.prio.Name = "prio";
            this.prio.Size = new System.Drawing.Size(101, 38);
            this.prio.TabIndex = 1;
            // 
            // src
            // 
            this.src.Location = new System.Drawing.Point(148, 124);
            this.src.MaxLength = 2;
            this.src.Name = "src";
            this.src.Size = new System.Drawing.Size(72, 35);
            this.src.TabIndex = 2;
            this.src.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dest
            // 
            this.dest.Location = new System.Drawing.Point(225, 124);
            this.dest.MaxLength = 2;
            this.dest.Name = "dest";
            this.dest.Size = new System.Drawing.Size(72, 35);
            this.dest.TabIndex = 3;
            this.dest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dest_port
            // 
            this.dest_port.Location = new System.Drawing.Point(302, 124);
            this.dest_port.MaxLength = 2;
            this.dest_port.Name = "dest_port";
            this.dest_port.Size = new System.Drawing.Size(72, 35);
            this.dest_port.TabIndex = 4;
            this.dest_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // src_port
            // 
            this.src_port.Location = new System.Drawing.Point(379, 124);
            this.src_port.MaxLength = 2;
            this.src_port.Name = "src_port";
            this.src_port.Size = new System.Drawing.Size(72, 35);
            this.src_port.TabIndex = 5;
            this.src_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "0000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(919, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // header_hex
            // 
            this.header_hex.Location = new System.Drawing.Point(45, 256);
            this.header_hex.MaxLength = 8;
            this.header_hex.Name = "header_hex";
            this.header_hex.Size = new System.Drawing.Size(341, 35);
            this.header_hex.TabIndex = 11;
            this.header_hex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "Header in HEX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 30);
            this.label5.TabIndex = 22;
            this.label5.Text = "Header in Binary";
            // 
            // Binary4
            // 
            this.Binary4.Location = new System.Drawing.Point(279, 399);
            this.Binary4.MaxLength = 4;
            this.Binary4.Name = "Binary4";
            this.Binary4.Size = new System.Drawing.Size(72, 35);
            this.Binary4.TabIndex = 16;
            this.Binary4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Binary5
            // 
            this.Binary5.Location = new System.Drawing.Point(201, 399);
            this.Binary5.MaxLength = 4;
            this.Binary5.Name = "Binary5";
            this.Binary5.Size = new System.Drawing.Size(72, 35);
            this.Binary5.TabIndex = 15;
            this.Binary5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Binary6
            // 
            this.Binary6.Location = new System.Drawing.Point(123, 399);
            this.Binary6.MaxLength = 4;
            this.Binary6.Name = "Binary6";
            this.Binary6.Size = new System.Drawing.Size(72, 35);
            this.Binary6.TabIndex = 14;
            this.Binary6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Binary7
            // 
            this.Binary7.Location = new System.Drawing.Point(45, 399);
            this.Binary7.MaxLength = 4;
            this.Binary7.Name = "Binary7";
            this.Binary7.Size = new System.Drawing.Size(72, 35);
            this.Binary7.TabIndex = 13;
            this.Binary7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Binary0
            // 
            this.Binary0.Location = new System.Drawing.Point(611, 399);
            this.Binary0.MaxLength = 4;
            this.Binary0.Name = "Binary0";
            this.Binary0.Size = new System.Drawing.Size(72, 35);
            this.Binary0.TabIndex = 20;
            this.Binary0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Binary1
            // 
            this.Binary1.Location = new System.Drawing.Point(533, 399);
            this.Binary1.MaxLength = 4;
            this.Binary1.Name = "Binary1";
            this.Binary1.ReadOnly = true;
            this.Binary1.Size = new System.Drawing.Size(72, 35);
            this.Binary1.TabIndex = 19;
            this.Binary1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Binary2
            // 
            this.Binary2.Location = new System.Drawing.Point(455, 399);
            this.Binary2.MaxLength = 4;
            this.Binary2.Name = "Binary2";
            this.Binary2.Size = new System.Drawing.Size(72, 35);
            this.Binary2.TabIndex = 18;
            this.Binary2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Binary3
            // 
            this.Binary3.Location = new System.Drawing.Point(377, 399);
            this.Binary3.MaxLength = 4;
            this.Binary3.Name = "Binary3";
            this.Binary3.Size = new System.Drawing.Size(72, 35);
            this.Binary3.TabIndex = 17;
            this.Binary3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(919, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(919, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 40);
            this.button3.TabIndex = 21;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox_HMAC
            // 
            this.checkBox_HMAC.AutoSize = true;
            this.checkBox_HMAC.Location = new System.Drawing.Point(518, 124);
            this.checkBox_HMAC.Name = "checkBox_HMAC";
            this.checkBox_HMAC.Size = new System.Drawing.Size(100, 34);
            this.checkBox_HMAC.TabIndex = 6;
            this.checkBox_HMAC.Text = "HMAC";
            this.checkBox_HMAC.UseVisualStyleBackColor = true;
            // 
            // checkBox_XTEA
            // 
            this.checkBox_XTEA.AutoSize = true;
            this.checkBox_XTEA.Location = new System.Drawing.Point(623, 124);
            this.checkBox_XTEA.Name = "checkBox_XTEA";
            this.checkBox_XTEA.Size = new System.Drawing.Size(87, 34);
            this.checkBox_XTEA.TabIndex = 7;
            this.checkBox_XTEA.Text = "XTEA";
            this.checkBox_XTEA.UseVisualStyleBackColor = true;
            // 
            // checkBox_RDP
            // 
            this.checkBox_RDP.AutoSize = true;
            this.checkBox_RDP.Location = new System.Drawing.Point(715, 124);
            this.checkBox_RDP.Name = "checkBox_RDP";
            this.checkBox_RDP.Size = new System.Drawing.Size(79, 34);
            this.checkBox_RDP.TabIndex = 8;
            this.checkBox_RDP.Text = "RDP";
            this.checkBox_RDP.UseVisualStyleBackColor = true;
            // 
            // checkBox_CRC
            // 
            this.checkBox_CRC.AutoSize = true;
            this.checkBox_CRC.Checked = true;
            this.checkBox_CRC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_CRC.Location = new System.Drawing.Point(799, 124);
            this.checkBox_CRC.Name = "checkBox_CRC";
            this.checkBox_CRC.Size = new System.Drawing.Size(78, 34);
            this.checkBox_CRC.TabIndex = 9;
            this.checkBox_CRC.Text = "CRC";
            this.checkBox_CRC.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 30);
            this.label6.TabIndex = 34;
            this.label6.Text = "Priority";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 30);
            this.label7.TabIndex = 35;
            this.label7.Text = "Source";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 30);
            this.label8.TabIndex = 36;
            this.label8.Text = "Dest";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 30);
            this.label9.TabIndex = 37;
            this.label9.Text = "D Port";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(382, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 30);
            this.label10.TabIndex = 38;
            this.label10.Text = "S Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 30);
            this.label3.TabIndex = 38;
            this.label3.Text = "Rsrv\'d";
            // 
            // header_BIN_label
            // 
            this.header_BIN_label.AutoSize = true;
            this.header_BIN_label.Location = new System.Drawing.Point(225, 341);
            this.header_BIN_label.Name = "header_BIN_label";
            this.header_BIN_label.Size = new System.Drawing.Size(0, 30);
            this.header_BIN_label.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(533, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 30);
            this.label11.TabIndex = 40;
            this.label11.Text = "Rsrv\'d";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 523);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.header_BIN_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox_CRC);
            this.Controls.Add(this.checkBox_RDP);
            this.Controls.Add(this.checkBox_XTEA);
            this.Controls.Add(this.checkBox_HMAC);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Binary0);
            this.Controls.Add(this.Binary1);
            this.Controls.Add(this.Binary2);
            this.Controls.Add(this.Binary3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Binary4);
            this.Controls.Add(this.Binary5);
            this.Controls.Add(this.Binary6);
            this.Controls.Add(this.Binary7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.header_hex);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.src_port);
            this.Controls.Add(this.dest_port);
            this.Controls.Add(this.dest);
            this.Controls.Add(this.src);
            this.Controls.Add(this.prio);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CSP Packet Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox prio;
        private System.Windows.Forms.TextBox src;
        private System.Windows.Forms.TextBox dest;
        private System.Windows.Forms.TextBox dest_port;
        private System.Windows.Forms.TextBox src_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox header_hex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Binary4;
        private System.Windows.Forms.TextBox Binary5;
        private System.Windows.Forms.TextBox Binary6;
        private System.Windows.Forms.TextBox Binary7;
        private System.Windows.Forms.TextBox Binary0;
        private System.Windows.Forms.TextBox Binary1;
        private System.Windows.Forms.TextBox Binary2;
        private System.Windows.Forms.TextBox Binary3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox_HMAC;
        private System.Windows.Forms.CheckBox checkBox_XTEA;
        private System.Windows.Forms.CheckBox checkBox_RDP;
        private System.Windows.Forms.CheckBox checkBox_CRC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label header_BIN_label;
        private System.Windows.Forms.Label label11;
    }
}

