using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSP_Packet_Builder
{
    public partial class Form1 : Form
    {
        int csp_header;
        int prio_val;
        int source_val;
        int source_port_val;
        int dest_val;
        int dest_port_val;

        int hmac;
        int xtea;
        int rdp;
        int crc;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prio.SelectedIndex = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (src.Text == "")
                    src.Text = "0";
                if (src_port.Text == "")
                    src_port.Text = "0";
                if (dest.Text == "")
                    dest.Text = "0";
                if (dest_port.Text == "")
                    dest_port.Text = "0";

                prio_val = prio.SelectedIndex;
                source_val = int.Parse(src.Text);
                source_port_val = int.Parse(src_port.Text);
                dest_val = int.Parse(dest.Text);
                dest_port_val = int.Parse(dest_port.Text);

                hmac = checkBox_HMAC.Checked ? 1 : 0;
                xtea = checkBox_XTEA.Checked ? 1 : 0;
                rdp = checkBox_RDP.Checked ? 1 : 0;
                crc = checkBox_CRC.Checked ? 1 : 0;

                csp_header = 0;

                csp_header = prio_val << 30;
                csp_header += source_val << 25;
                csp_header += dest_val << 20;
                csp_header += dest_port_val << 14;
                csp_header += source_port_val << 8;

                csp_header += hmac << 3;
                csp_header += xtea << 2;
                csp_header += rdp << 1;
                csp_header += crc;

                header_hex.Text = csp_header.ToString("X8");

                header_BIN_label.Text = Convert.ToString(csp_header, 2);
                Binary7.Text = Convert.ToString((csp_header >> 28) & 0xF, 2);
                Binary6.Text = Convert.ToString((csp_header >> 24) & 0xF, 2);
                Binary5.Text = Convert.ToString((csp_header >> 20) & 0xF, 2);
                Binary4.Text = Convert.ToString((csp_header >> 16) & 0xF, 2);
                Binary3.Text = Convert.ToString((csp_header >> 12) & 0xF, 2);
                Binary2.Text = Convert.ToString((csp_header >> 8) & 0xF, 2);
                Binary1.Text = Convert.ToString((csp_header >> 4) & 0xF, 2);
                Binary0.Text = Convert.ToString((csp_header) & 0xF, 2);
            }
            catch
            {
                MessageBox.Show("CSP header incorrect!", "CSP Builder");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (header_hex.Text == "")
                    header_hex.Text = "0";

                csp_header = Convert.ToInt32(header_hex.Text, 16);

                header_BIN_label.Text = Convert.ToString(csp_header, 2);
                Binary7.Text = Convert.ToString((csp_header >> 28) & 0xF, 2);
                Binary6.Text = Convert.ToString((csp_header >> 24) & 0xF, 2);
                Binary5.Text = Convert.ToString((csp_header >> 20) & 0xF, 2);
                Binary4.Text = Convert.ToString((csp_header >> 16) & 0xF, 2);
                Binary3.Text = Convert.ToString((csp_header >> 12) & 0xF, 2);
                Binary2.Text = Convert.ToString((csp_header >> 8) & 0xF, 2);
                Binary1.Text = Convert.ToString((csp_header >> 4) & 0xF, 2);
                Binary0.Text = Convert.ToString((csp_header) & 0xF, 2);

                prio.SelectedIndex = (csp_header >> 30) & 0x3;
                src.Text = Convert.ToString((csp_header >> 25) & 0x1F, 10);
                dest.Text = Convert.ToString((csp_header >> 20) & 0x1F, 10);
                dest_port.Text = Convert.ToString((csp_header >> 14) & 0x1F, 10);
                src_port.Text = Convert.ToString((csp_header >> 8) & 0x3F, 10);

                checkBox_HMAC.Checked = (((csp_header >> 3) & 0x1) == 1) ? true : false;
                checkBox_XTEA.Checked = (((csp_header >> 2) & 0x1) == 1) ? true : false;
                checkBox_RDP.Checked = (((csp_header >> 1) & 0x1) == 1) ? true : false;
                checkBox_CRC.Checked = (((csp_header) & 0x1) == 1) ? true : false;
            }
            catch
            {
                MessageBox.Show("CSP header incorrect!", "CSP Builder");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Binary7.Text == "")
                    Binary7.Text = "0";
                if (Binary6.Text == "")
                    Binary6.Text = "0";
                if (Binary5.Text == "")
                    Binary5.Text = "0";
                if (Binary4.Text == "")
                    Binary4.Text = "0";
                if (Binary3.Text == "")
                    Binary3.Text = "0";
                if (Binary2.Text == "")
                    Binary2.Text = "0";
                if (Binary1.Text == "")
                    Binary1.Text = "0";
                if (Binary0.Text == "")
                    Binary0.Text = "0";

                csp_header = Convert.ToInt32(Binary7.Text, 2) << 28;
                csp_header += Convert.ToInt32(Binary6.Text, 2) << 24;
                csp_header += Convert.ToInt32(Binary5.Text, 2) << 20;
                csp_header += Convert.ToInt32(Binary4.Text, 2) << 16;
                csp_header += Convert.ToInt32(Binary3.Text, 2) << 12;
                csp_header += Convert.ToInt32(Binary2.Text, 2) << 8;
                csp_header += Convert.ToInt32(Binary1.Text, 2) << 4;
                csp_header += Convert.ToInt32(Binary0.Text, 2);
                header_BIN_label.Text = Convert.ToString(csp_header, 2);

                prio.SelectedIndex = (csp_header >> 30) & 0x3;
                src.Text = Convert.ToString((csp_header >> 25) & 0x1F, 10);
                dest.Text = Convert.ToString((csp_header >> 20) & 0x1F, 10);
                dest_port.Text = Convert.ToString((csp_header >> 14) & 0x1F, 10);
                src_port.Text = Convert.ToString((csp_header >> 8) & 0x3F, 10);

                checkBox_HMAC.Checked = (((csp_header >> 3) & 0x1) == 1) ? true : false;
                checkBox_XTEA.Checked = (((csp_header >> 2) & 0x1) == 1) ? true : false;
                checkBox_RDP.Checked = (((csp_header >> 1) & 0x1) == 1) ? true : false;
                checkBox_CRC.Checked = (((csp_header) & 0x1) == 1) ? true : false;

                header_hex.Text = csp_header.ToString("X8");
            }
            catch
            {
                MessageBox.Show("CSP header incorrect!", "CSP Builder");
            }            
        }
    }
}
