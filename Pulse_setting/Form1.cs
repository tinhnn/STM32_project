using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;
using System.Management;

namespace Pulse_setting
{
    public partial class Form1 : Form
    {
        private int _isClose = 0;
        private SerialPort _comPort;
        public Form1()
        {
            InitializeComponent();
            using (var searcher = new ManagementObjectSearcher
                ("SELECT * FROM WIN32_SerialPort"))
            {
                string[] portnames = SerialPort.GetPortNames();
                foreach (string port in portnames)
                {
                    comboBox1.Items.Add(port);
                }
                comboBox1.Text = "";
                var _ports = searcher.Get().Cast<ManagementBaseObject>().ToList();
                var tList = (from n in portnames
                             join p in _ports on n equals p["DeviceID"].ToString()
                             select n + " - " + p["Caption"]).ToList();
                int cnt = 0;
                foreach(var t in tList)
                {
                    if (t.Contains("STLink"))
                    {
                        comboBox1.Text = comboBox1.Items[cnt].ToString();
                        break;
                    }
                    cnt++;
                }
            }
            
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            btn_snd.Enabled = false;
        }

        private void btn_snd_Click(object sender, EventArgs e)
        {
            UInt32 frq = UInt32.Parse(textBox1.Text);
            byte[] data = new byte[4];
            data[0] = (byte)((frq >> 24) & 0xFF);
            data[1] = (byte)((frq >> 16) & 0xFF);
            data[2] = (byte)((frq >> 08) & 0xFF);
            data[3] = (byte)((frq >> 00) & 0xFF);
            _comPort.Write(data, 0, 4);
        }

        private void btn_com_Click(object sender, EventArgs e)
        {
            if(_isClose == 0)
            {
                // Open COM port
                _comPort = new SerialPort();
                _comPort.PortName = comboBox1.Text;
                _comPort.BaudRate = 115200;
                _comPort.DataBits = 8;
                _comPort.Parity = Parity.None;
                _comPort.Handshake = Handshake.None;
                _comPort.ReadTimeout = 500;
                _comPort.WriteTimeout = 500;

                _comPort.Open();
                _isClose = 1;
                btn_com.Text = "Close";
                btn_snd.Enabled = true;
            }
            else
            {
                // Close Port
                _comPort.Close();
                _isClose = 0;
                btn_com.Text = "Open";
                btn_snd.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
