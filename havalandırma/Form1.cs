using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace havalandırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbx_port.DataSource=SerialPort.GetPortNames();
            btn_baglan.Enabled = true;
            btn_baglan_kes.Enabled = false;
            btn_h_ac.Enabled = false;   
            btn_h_kapat.Enabled = false;
        }

        private void btn_baglan_Click(object sender, EventArgs e)
        {
          
            serialPort1.PortName= cbx_port.Text;
            serialPort1.BaudRate = 9600;
            serialPort1.Open(); 
            timer1.Start();
            btn_baglan.Enabled=false;
            btn_baglan_kes.Enabled = true;
            btn_h_ac.Enabled = true;
            btn_h_kapat.Enabled=true;
        }

        private void btn_baglan_kes_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            btn_baglan.Enabled = true;
            btn_baglan_kes.Enabled = false;
            btn_h_ac.Enabled = false;
            btn_h_kapat.Enabled = false;
            serialPort1.DiscardOutBuffer(); 
        }

        private void btn_h_ac_Click(object sender, EventArgs e)
        {
            serialPort1.Write(Convert.ToString("1"));
        }

        private void btn_h_kapat_Click(object sender, EventArgs e)
        {
            serialPort1.Write(Convert.ToString("2"));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string data;
                string[] splitted_data;
                data = serialPort1.ReadExisting();
                splitted_data = data.Split('*');


                txt_sıcaklık.Text = splitted_data[0];
                txt_nem.Text = splitted_data[1];
                txt_hava.Text = splitted_data[2];

                StreamWriter SW = File.AppendText(Application.StartupPath + "\\degerler.txt");
                string satır = "Sıcaklık=";
                SW.Write(satır);
                SW.WriteLine(txt_sıcaklık.Text);
                SW.Close();

            }
            catch (Exception)
            {
                timer1.Stop();
            } 
        }

        private void txt_sıcaklık_TextChanged(object sender, EventArgs e)
        {
            serialPort1.Write("0");
        }

        private void txt_nem_TextChanged(object sender, EventArgs e)
        {
            serialPort1.Write("1");
        }

        private void txt_hava_TextChanged(object sender, EventArgs e)
        {
            serialPort1.Write("2");
        }
    }
}
