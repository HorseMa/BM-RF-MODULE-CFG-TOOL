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
            baudrate.SelectedIndex = 6;
            paritybit.SelectedIndex = 0;
            databit.SelectedIndex = 3;
            stopbit.SelectedIndex = 0;

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
            if (serialPort.IsOpen == false)
            {
                MessageBox.Show("请连接模块");
                return;
            }
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
                opt[0] = (byte)'0';
            }else if(paritybit.Text == "Odd")
            {
                opt[0] = (byte)'1';
            }else if(paritybit.Text == "Even")
            {
                opt[0] = (byte)'2';
            }else if(paritybit.Text == "Mark")
            {
                opt[0] = (byte)'3';
            }else if(paritybit.Text == "Space")
            {
                opt[0] = (byte)'4';
            }else{
            }
            if (databit.Text == "5")
            {
                opt[1] = (byte)'0';
            } else if (databit.Text == "6")
            {
                opt[1] = (byte)'1';
            }else if (databit.Text == "7")
            {
                opt[1] = (byte)'2';
            }else if (databit.Text == "8")
            {
                opt[1] = (byte)'3';
            }else
            {

            }
            if (stopbit.Text == "1")
            {
                opt[2] = (byte)'0';
            }
            else if (stopbit.Text == "1.5")
            {
                opt[2] = (byte)'1';
            }
            else if (stopbit.Text == "2")
            {
                opt[2] = (byte)'2';
            }
            else
            {
 
            }
            cmd[0] = (byte)'w'; // cmd:write config
            cmd[1] = (byte)(uartbaudrate / 1000000 + 0x30);    // uartbaudrate
            cmd[2] = (byte)(uartbaudrate % 1000000 / 100000 + 0x30);
            cmd[3] = (byte)(uartbaudrate % 100000 / 10000 + 0x30);
            cmd[4] = (byte)(uartbaudrate % 10000 / 1000 + 0x30);
            cmd[5] = (byte)(uartbaudrate % 1000 / 100 + 0x30);
            cmd[6] = (byte)(uartbaudrate % 100 / 10 + 0x30);
            cmd[7] = (byte)(uartbaudrate % 10 + 0x30);
            cmd[8] = opt[0];
            cmd[9] = opt[1];
            cmd[10] = opt[2];
            cmd[11] = (byte)(wirelessbaudrate / 1000000 + 0x30);
            cmd[12] = (byte)(wirelessbaudrate % 1000000 / 100000 + 0x30);
            cmd[13] = (byte)(wirelessbaudrate % 100000 / 10000 + 0x30);
            cmd[14] = (byte)(wirelessbaudrate % 10000 / 1000 + 0x30);
            cmd[15] = (byte)(wirelessbaudrate % 1000 / 100 + 0x30);
            cmd[16] = (byte)(wirelessbaudrate % 100 / 10 + 0x30);
            cmd[17] = (byte)(wirelessbaudrate % 10 + 0x30);
            cmd[18] = (byte)(wirelesschannel % 1000 / 100 + 0x30);
            cmd[19] = (byte)(wirelesschannel % 100 / 10 + 0x30);
            cmd[20] = (byte)(wirelesschannel % 10 + 0x30);
            cmd[21] = (byte)(wirelesspower % 1000 / 100 + 0x30);
            cmd[22] = (byte)(wirelesspower % 100 / 10 + 0x30);
            cmd[23] = (byte)(wirelesspower % 10 + 0x30);
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
            if (serialPort.IsOpen == false)
            {
                MessageBox.Show("请连接模块");
                return;
            }
            if (hostteststart.Text == "开始测试")
            {
                byte[] cmd = new byte[40];
                cmd[0] = (byte)'t';
                cmd[1] = (byte)'h';

                int channel = Convert.ToInt32(tsthostchannel.Text);
                int speed = Convert.ToInt32(tsthostairbaudrate.Text);
                int len = Convert.ToInt32(tsthostdatalen.Text);
                int power = Convert.ToInt32(tsthostairpower.Text);

                cmd[2] = (byte)(channel / 100 + 0x30);
                cmd[3] = (byte)(channel % 100 / 10 + 0x30);
                cmd[4] = (byte)(channel % 10 + 0x30);

                cmd[5] = (byte)(speed / 1000000 + 0x30);
                cmd[6] = (byte)(speed % 1000000 / 100000 + 0x30);
                cmd[7] = (byte)(speed % 100000 / 10000 + 0x30);
                cmd[8] = (byte)(speed % 10000 / 1000 + 0x30);
                cmd[9] = (byte)(speed % 1000 / 100 + 0x30);
                cmd[10] = (byte)(speed % 100 / 10 + 0x30);
                cmd[11] = (byte)(speed % 10 + 0x30);

                cmd[12] = (byte)(len % 1000 / 100 + 0x30);
                cmd[13] = (byte)(len % 100 / 10 + 0x30);
                cmd[14] = (byte)(len % 10 + 0x30);

                cmd[15] = (byte)(power % 1000 / 100 + 0x30);
                cmd[16] = (byte)(power % 100 / 10 + 0x30);
                cmd[17] = (byte)(power % 10 + 0x30);

                string pcack = System.Text.Encoding.Default.GetString(cmd);
                serialPort.WriteLine(pcack);

                hostteststart.Text = "停止测试";
            }
            else
            {
                hostteststart.Text = "开始测试";
            }
        }

        private void slaveteststart_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == false)
            {
                MessageBox.Show("请连接模块");
                return;
            }
            if (slaveteststart.Text == "开始测试")
            {
                int channel = Convert.ToInt32(tstslavechannel.Text);
                int speed = Convert.ToInt32(tstslavebaudrate.Text);
                byte[] cmd = new byte[40];
                cmd[0] = (byte)'t';
                cmd[1] = (byte)'s';
                cmd[2] = (byte)(channel / 100 + 0x30);
                cmd[3] = (byte)(channel % 100 / 10 + 0x30);
                cmd[4] = (byte)(channel % 10 + 0x30);

                cmd[5] = (byte)(speed / 1000000 + 0x30);
                cmd[6] = (byte)(speed % 1000000 / 100000 + 0x30);
                cmd[7] = (byte)(speed % 100000 / 10000 + 0x30);
                cmd[8] = (byte)(speed % 10000 / 1000 + 0x30);
                cmd[9] = (byte)(speed % 1000 / 100 + 0x30);
                cmd[10] = (byte)(speed % 100 / 10 + 0x30);
                cmd[11] = (byte)(speed % 10 + 0x30);

                string pcack = System.Text.Encoding.Default.GetString(cmd);
                serialPort.WriteLine(pcack);

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
            if (serialPort.IsOpen == false)
            {
                MessageBox.Show("请连接模块");
                return;
            }
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
                airbaudrate.Text = "10000";
                MessageBox.Show("请正确输入数字");
            }
            if (tmp > 20000)
            {
                airbaudrate.Text = "10000";
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
                channel.Text = "0";
                MessageBox.Show("请正确输入数字");
            }
            if (tmp > 255)
            {
                channel.Text = "0";
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
                airpower.Text = "127";
                MessageBox.Show("请正确输入数字");
            }
            if (tmp > 0x7f)
            {
                airpower.Text = "127";
                MessageBox.Show("功率范围：0~127");
            }
        }

        private void tsthostchannel_Leave(object sender, EventArgs e)
        {
            if (tsthostchannel.Text == "")
                return;
            int tmp;
            if (!int.TryParse(tsthostchannel.Text, out tmp))
            {
                tsthostchannel.Text = "0";
                MessageBox.Show("请正确输入数字");
            }
            if (tmp > 255)
            {
                tsthostchannel.Text = "0";
                MessageBox.Show("信道范围：0~255");
            }
        }

        private void tsthostairbaudrate_Leave(object sender, EventArgs e)
        {
            if (tsthostairbaudrate.Text == "")
                return;
            int tmp;
            if (!int.TryParse(tsthostairbaudrate.Text, out tmp))
            {
                tsthostairbaudrate.Text = "10000";
                MessageBox.Show("请正确输入数字");
            }
            if (tmp > 20000)
            {
                tsthostairbaudrate.Text = "10000";
                MessageBox.Show("无线速率范围：0~20k");
            }
        }

        private void tsthostdatalen_Leave(object sender, EventArgs e)
        {
            if (tsthostdatalen.Text == "")
                return;
            int tmp;
            if (!int.TryParse(tsthostdatalen.Text, out tmp))
            {
                tsthostdatalen.Text = "10";
                MessageBox.Show("请正确输入数字");
            }
            if (tmp > 10)
            {
                tsthostdatalen.Text = "10";
                MessageBox.Show("数据长度：0~128byte");
            }
        }

        private void tsthostairpower_Leave(object sender, EventArgs e)
        {
            if (tsthostairpower.Text == "")
                return;
            int tmp;
            if (!int.TryParse(tsthostairpower.Text, out tmp))
            {
                tsthostairpower.Text = "127";
                MessageBox.Show("请正确输入数字");
            }
            if (tmp > 0x7f)
            {
                tsthostairpower.Text = "127";
                MessageBox.Show("功率范围：0~127");
            }
        }

        private void tstslavechannel_Leave(object sender, EventArgs e)
        {
            if (tstslavechannel.Text == "")
                return;
            int tmp;
            if (!int.TryParse(tstslavechannel.Text, out tmp))
            {
                tstslavechannel.Text = "0";
                MessageBox.Show("请正确输入数字");
            }
            if (tmp > 255)
            {
                tstslavechannel.Text = "0";
                MessageBox.Show("信道范围：0~255");
            }
        }

        private void tstslavebaudrate_Leave(object sender, EventArgs e)
        {
            if (tstslavebaudrate.Text == "")
                return;
            int tmp;
            if (!int.TryParse(tstslavebaudrate.Text, out tmp))
            {
                tstslavebaudrate.Text = "10000";
                MessageBox.Show("请正确输入数字");
            }
            if (tmp > 20000)
            {
                tstslavebaudrate.Text = "10000";
                MessageBox.Show("无线速率范围：0~20k");
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string strcmd;
            byte[] cmd = new byte[100];

            byte[] temp = new byte [10];
            try
            {
                strcmd = serialPort.ReadLine();
                cmd = System.Text.Encoding.ASCII.GetBytes(strcmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            switch (cmd[0])
            {
                case (byte)'c':// cfg info
                    Array.Copy(cmd, 1, temp, 0, 4);
                    hardwareversion.Text = Encoding.ASCII.GetString(temp);  // 硬件版本
                    temp = new byte[10];
                    Array.Copy(cmd, 5, temp, 0, 4);
                    softwareversion.Text = Encoding.ASCII.GetString(temp);  // 软件版本
                    temp = new byte[10];
                    Array.Copy(cmd, 9, temp, 0, 8);
                    moduleid.Text = Encoding.ASCII.GetString(temp);    // 出厂编号
                    temp = new byte[10];
                    Array.Copy(cmd, 17, temp, 0, 3);
                    channel.Text = Encoding.ASCII.GetString(temp);      // 收发信道
                    temp = new byte[10];
                    Array.Copy(cmd, 20, temp, 0, 6);
                    airbaudrate.Text = Encoding.ASCII.GetString(temp);    // 空中速率
                    temp = new byte[10];
                    Array.Copy(cmd, 26, temp, 0, 6);
                    baudrate.Text = Encoding.ASCII.GetString(temp);   // 串口速率
                    temp = new byte[10];
                    Array.Copy(cmd,32,temp,0,3);
                    airpower.Text = Encoding.ASCII.GetString(temp);    // 发射功率
                    temp = new byte[10];
                    Array.Copy(cmd,35,temp,0,1);
                    paritybit.Text = Encoding.ASCII.GetString(temp);    // 串口校验位
                    temp = new byte[10];
                    Array.Copy(cmd,36,temp,0,1);
                    databit.Text = Encoding.ASCII.GetString(temp);    // 串口数据位
                    temp = new byte[10];
                    Array.Copy(cmd,37,temp,0,1);
                    stopbit.Text = Encoding.ASCII.GetString(temp);    // 串口停止位
                    string pcack = "ack";
                    serialPort.WriteLine(pcack);
                    /*temp = new byte[10];
                    Array.Copy(cmd, 32, temp, 0, 4);
                    nextpointaddr.Text = Encoding.ASCII.GetString(temp);    // 下一跳地址
                    temp = new byte[10];
                    Array.Copy(cmd, 36, temp, 0, 4);
                    prepointaddr.Text = Encoding.ASCII.GetString(temp);     // 上一跳地址
                    temp = new byte[4];*/
                    break;
                case (byte)'h':// host test info
                    temp = new byte[10];
                    Array.Copy(cmd, 1, temp, 0, 5);
                    tsthostpktsendcnt.Text = Encoding.ASCII.GetString(temp);  // 主机发送包数
                    temp = new byte[10];
                    Array.Copy(cmd, 6, temp, 0, 5);
                    tsthostpktrcvcnt.Text = Encoding.ASCII.GetString(temp);  // 主机接收
                    temp = new byte[10];
                    Array.Copy(cmd, 11, temp, 0, 2);
                    tsthostrssi.Text = Encoding.ASCII.GetString(temp);  // 从机场强
                    temp = new byte[10];
                    Array.Copy(cmd, 13, temp, 0, 2);
                    tsthosterr.Text = Encoding.ASCII.GetString(temp);  // 丢包概率
                    tsthosterr.Text += '%';
                    break;
                case (byte)'s':// slave test info
                    temp = new byte[10];
                    Array.Copy(cmd, 1, temp, 0, 2);
                    tsthostrssi.Text = Encoding.ASCII.GetString(temp);  // 主机场强
                    temp = new byte[10];
                    Array.Copy(cmd, 3, temp, 0, 5);
                    tstslavepktrcvcnt.Text = Encoding.ASCII.GetString(temp);  // 接收包数
                    break;
                default:
                    break;
            }
        }

    }
}
