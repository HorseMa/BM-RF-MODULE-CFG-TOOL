using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace RF_MODULE_CFG_TOLL
{
    public partial class CFG_TOOL : Form
    {
        public CFG_TOOL()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SerialPort com = new SerialPort("COM1");

            string[] portlist = SerialPort.GetPortNames();
            for (int i = 0; i < portlist.Length; i++)
            {
                if (-1 == serialportlist.FindString(portlist[i]))
                {
                    serialportlist.Items.Add(portlist[i]);
                }
                if (i == 0)
                {
                    serialportlist.Text = portlist[i];
                }
            }

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            serialportlist.Show();

            mode.Checked = true ;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void mode_CheckedChanged(object sender, EventArgs e)
        {
            if (mode.Checked == true)
            {
                gbtestslave.Enabled = false;
                gbtesthost.Enabled = true;
            }
            else
            {
                gbtestslave.Enabled = true;
                gbtesthost.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseDown(object sender, MouseEventArgs e)
        {
            SerialPort com = new SerialPort("COM1");

            string[] portlist = SerialPort.GetPortNames();
            for (int i = 0; i < portlist.Length; i++)
            {
                if (-1 == serialportlist.FindString(portlist[i]))
                {
                    serialportlist.Items.Add(portlist[i]);
                }
                if (i == 0)
                {
                    serialportlist.Text = portlist[i];
                }
            }

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            serialportlist.Show();
        }

        private void opendevice_Click(object sender, EventArgs e)
        {
            if (serialportlist.SelectedItem == null)
                return;
            if (opendevice.Text == "打开端口")
            {
                serialPort.PortName = serialportlist.SelectedItem.ToString();
                serialPort.BaudRate = 9600;
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;
                serialPort.Parity = Parity.None;
                serialPort.NewLine = "\r\n";
                try
                {
                    serialPort.Open();
                    if (serialPort.IsOpen)
                    {
                        serialPort.WriteLine("fdsa");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                opendevice.Text = "关闭端口";
            }
            else
            {
                serialPort.Close();
                opendevice.Text = "打开端口";
            }
        }

        private void serialportlist_SelectedValueChanged(object sender, EventArgs e)
        {
            serialPort.Close();
        }

        private void hostteststart_Click(object sender, EventArgs e)
        {
            if (hostteststart.Text == "开始测试")
            {
                hostteststart.Text = "停止测试";
            }
            else
            {
                hostteststart.Text = "开始测试";
            }
        }

        private void slaveteststart_Click(object sender, EventArgs e)
        {
            if (slaveteststart.Text == "开始测试")
            {
                slaveteststart.Text = "停止测试";
            }
            else
            {
                slaveteststart.Text = "开始测试";
            }
        }

        private void mode_CheckedChanged_1(object sender, EventArgs e)
        {
            if (mode.Checked == true)
            {
                tstslavebaudrate.Enabled = false;
                tstslavechannel.Enabled = false;
                tstslavepktrcvcnt.Enabled = false;
                tstslaverssi.Enabled = false;
                slaveteststart.Enabled = false;

                tsthostairbaudrate.Enabled = true;
                tsthostairpower.Enabled = true;
                tsthostchannel.Enabled = true;
                tsthostdatalen.Enabled = true;
                hostteststart.Enabled = true;
            }
            else
            {
                tstslavebaudrate.Enabled = true ;
                tstslavechannel.Enabled = true ;
                tstslavepktrcvcnt.Enabled = false;
                tstslaverssi.Enabled = false;
                slaveteststart.Enabled = true ;

                hostteststart.Enabled = false ;
                tsthostairbaudrate.Enabled = false ;
                tsthostairpower.Enabled = false ;
                tsthostchannel.Enabled = false ;
                tsthostdatalen.Enabled = false ;
            }
        }

        private void readcfg_Click(object sender, EventArgs e)
        {

        }
    }
}
