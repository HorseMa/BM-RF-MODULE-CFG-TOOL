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
            byte[] cmd = new byte[40];
            int uartbaudrate = Convert.ToInt32(baudrate.Text);
            int wirelessbaudrate = Convert.ToInt32(airbaudrate.Text);
            int wirelesschannel = Convert.ToInt32(channel.Text);
            int wirelesspower = Convert.ToInt32(airpower.Text);
            byte[] opt = new byte[3];
            /*None Odd Even Mark Space
             bit0-2     0-4
             5/6/7/8
             bit3-4     5-8
             1/1.5/2
             bit5-6     0-2
             */
            if(paritybit.Text == "None")
            {
                opt[0] = 0;
            }else if(paritybit.Text == "Odd")
            {
                opt[0] = 1;
            }else if(paritybit.Text == "Even")
            {
                opt[0] = 2;
            }else if(paritybit.Text == "Mark")
            {
                opt[0] = 3;
            }else if(paritybit.Text == "Space")
            {
                opt[0] = 4;
            }else{
            }
            if (databit.Text == "5")
            {
                opt[1] = 0;
            } else if (databit.Text == "6")
            {
                opt[1] = 1;
            }else if (databit.Text == "7")
            {
                opt[1] = 2;
            }else if (databit.Text == "8")
            {
                opt[1] = 3;
            }else
            {

            }
            if (stopbit.Text == "1")
            {
                opt[2] = 0;
            }
            else if (stopbit.Text == "1.5")
            {
                opt[2] = 1;
            }
            else if (stopbit.Text == "2")
            {
                opt[2] = 2;
            }
            else
            {
 
            }
            cmd[0] = (byte)'w';
            cmd[1] = (byte)(uartbaudrate / 1000000);
            cmd[2] = (byte)(uartbaudrate % 1000000 / 100000);
            cmd[3] = (byte)(uartbaudrate % 100000 / 10000);
            cmd[4] = (byte)(uartbaudrate % 10000 / 1000);
            cmd[5] = (byte)(uartbaudrate % 1000 / 100);
            cmd[6] = (byte)(uartbaudrate % 100 / 10);
            cmd[7] = (byte)(uartbaudrate % 10);
            cmd[8] = opt[0];
            cmd[9] = opt[1];
            cmd[10] = opt[2];

            string pcack = System.Text.Encoding.Default.GetString(cmd);
            serialPort.WriteLine(pcack);

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
            byte[] cmd = new byte[40];
            cmd[0] = (byte)'r';
            string pcack = System.Text.Encoding.Default.GetString(cmd);
            serialPort.WriteLine(pcack);

        }

        private void airbaudrate_Leave(object sender, EventArgs e)
        {
            if (airbaudrate.Text == "")
                return;
            int tmp;
            if (!int.TryParse(airbaudrate.Text, out tmp))
            {
                airbaudrate.Text = "";
                MessageBox.Show("请正确输入数字");
            }
            if (tmp > 20000)
            {
                airbaudrate.Text = "";
                MessageBox.Show("无线速率范围：0~20k");
            }
        }

        private void channel_Leave(object sender, EventArgs e)
        {
            if (channel.Text == "")
                return;
            int tmp;
            if (!int.TryParse(channel.Text, out tmp))
            {
                channel.Text = "";
                MessageBox.Show("请正确输入数字");
            }
            if (tmp > 255)
            {
                channel.Text = "";
                MessageBox.Show("信道范围：0~255");
            }
        }

        private void airpower_Leave(object sender, EventArgs e)
        {
            if (airpower.Text == "")
                return;
            int tmp;
            if (!int.TryParse(airpower.Text, out tmp))
            {
                airpower.Text = "";
                MessageBox.Show("请正确输入数字");
            }
            if (tmp > 0x7f)
            {
                airpower.Text = "";
                MessageBox.Show("功率范围：0~127");
            }
        }
    }
}
