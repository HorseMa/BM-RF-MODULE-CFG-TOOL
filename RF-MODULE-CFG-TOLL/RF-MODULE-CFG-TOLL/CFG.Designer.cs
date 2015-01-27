namespace RF_MODULE_CFG_TOLL
{
    partial class CFG_TOOL
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comport = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.opendevice = new System.Windows.Forms.Button();
            this.serialportlist = new System.Windows.Forms.ComboBox();
            this.cfg = new System.Windows.Forms.GroupBox();
            this.airpower = new System.Windows.Forms.TextBox();
            this.channel = new System.Windows.Forms.TextBox();
            this.airbaudrate = new System.Windows.Forms.TextBox();
            this.readcfg = new System.Windows.Forms.Button();
            this.writecfg = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.databit = new System.Windows.Forms.ComboBox();
            this.stopbit = new System.Windows.Forms.ComboBox();
            this.paritybit = new System.Windows.Forms.ComboBox();
            this.baudrate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.test = new System.Windows.Forms.GroupBox();
            this.mode = new System.Windows.Forms.CheckBox();
            this.gbtestslave = new System.Windows.Forms.GroupBox();
            this.tstslavepktrcvcnt = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tstslaverssi = new System.Windows.Forms.TextBox();
            this.tstslavebaudrate = new System.Windows.Forms.TextBox();
            this.tstslavechannel = new System.Windows.Forms.TextBox();
            this.slaveteststart = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.gbtesthost = new System.Windows.Forms.GroupBox();
            this.tsthostairpower = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.hostteststart = new System.Windows.Forms.Button();
            this.tsthosterr = new System.Windows.Forms.TextBox();
            this.tsthostpktrcvcnt = new System.Windows.Forms.TextBox();
            this.tsthostrssi = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tsthostpktsendcnt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tsthostdatalen = new System.Windows.Forms.TextBox();
            this.tsthostairbaudrate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tsthostchannel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.comport.SuspendLayout();
            this.cfg.SuspendLayout();
            this.test.SuspendLayout();
            this.gbtestslave.SuspendLayout();
            this.gbtesthost.SuspendLayout();
            this.SuspendLayout();
            // 
            // comport
            // 
            this.comport.Controls.Add(this.textBox2);
            this.comport.Controls.Add(this.textBox3);
            this.comport.Controls.Add(this.label9);
            this.comport.Controls.Add(this.opendevice);
            this.comport.Controls.Add(this.serialportlist);
            this.comport.Location = new System.Drawing.Point(12, 12);
            this.comport.Name = "comport";
            this.comport.Size = new System.Drawing.Size(168, 136);
            this.comport.TabIndex = 0;
            this.comport.TabStop = false;
            this.comport.Text = "端口";
            this.comport.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(87, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 21);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(87, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(73, 21);
            this.textBox3.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "模块出厂编号";
            // 
            // opendevice
            // 
            this.opendevice.Location = new System.Drawing.Point(87, 12);
            this.opendevice.Name = "opendevice";
            this.opendevice.Size = new System.Drawing.Size(73, 26);
            this.opendevice.TabIndex = 1;
            this.opendevice.Text = "打开端口";
            this.opendevice.UseVisualStyleBackColor = true;
            this.opendevice.Click += new System.EventHandler(this.opendevice_Click);
            // 
            // serialportlist
            // 
            this.serialportlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.serialportlist.FormattingEnabled = true;
            this.serialportlist.Location = new System.Drawing.Point(8, 12);
            this.serialportlist.Name = "serialportlist";
            this.serialportlist.Size = new System.Drawing.Size(73, 20);
            this.serialportlist.TabIndex = 0;
            this.serialportlist.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.serialportlist.SelectedValueChanged += new System.EventHandler(this.serialportlist_SelectedValueChanged);
            this.serialportlist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseDown);
            // 
            // cfg
            // 
            this.cfg.Controls.Add(this.airpower);
            this.cfg.Controls.Add(this.channel);
            this.cfg.Controls.Add(this.airbaudrate);
            this.cfg.Controls.Add(this.readcfg);
            this.cfg.Controls.Add(this.writecfg);
            this.cfg.Controls.Add(this.label10);
            this.cfg.Controls.Add(this.label6);
            this.cfg.Controls.Add(this.label5);
            this.cfg.Controls.Add(this.label4);
            this.cfg.Controls.Add(this.label3);
            this.cfg.Controls.Add(this.label2);
            this.cfg.Controls.Add(this.label1);
            this.cfg.Controls.Add(this.databit);
            this.cfg.Controls.Add(this.stopbit);
            this.cfg.Controls.Add(this.paritybit);
            this.cfg.Controls.Add(this.baudrate);
            this.cfg.Location = new System.Drawing.Point(12, 154);
            this.cfg.Name = "cfg";
            this.cfg.Size = new System.Drawing.Size(168, 239);
            this.cfg.TabIndex = 1;
            this.cfg.TabStop = false;
            this.cfg.Text = "配置";
            // 
            // airpower
            // 
            this.airpower.Location = new System.Drawing.Point(77, 171);
            this.airpower.Name = "airpower";
            this.airpower.Size = new System.Drawing.Size(83, 21);
            this.airpower.TabIndex = 17;
            this.airpower.Text = "127";
            this.airpower.Leave += new System.EventHandler(this.airpower_Leave);
            // 
            // channel
            // 
            this.channel.Location = new System.Drawing.Point(77, 144);
            this.channel.Name = "channel";
            this.channel.Size = new System.Drawing.Size(83, 21);
            this.channel.TabIndex = 16;
            this.channel.Text = "0";
            this.channel.Leave += new System.EventHandler(this.channel_Leave);
            // 
            // airbaudrate
            // 
            this.airbaudrate.Location = new System.Drawing.Point(77, 118);
            this.airbaudrate.Name = "airbaudrate";
            this.airbaudrate.Size = new System.Drawing.Size(83, 21);
            this.airbaudrate.TabIndex = 15;
            this.airbaudrate.Text = "10000";
            this.airbaudrate.Leave += new System.EventHandler(this.airbaudrate_Leave);
            // 
            // readcfg
            // 
            this.readcfg.Location = new System.Drawing.Point(87, 210);
            this.readcfg.Name = "readcfg";
            this.readcfg.Size = new System.Drawing.Size(73, 23);
            this.readcfg.TabIndex = 14;
            this.readcfg.Text = "读配置";
            this.readcfg.UseVisualStyleBackColor = true;
            this.readcfg.Click += new System.EventHandler(this.readcfg_Click);
            // 
            // writecfg
            // 
            this.writecfg.Location = new System.Drawing.Point(6, 210);
            this.writecfg.Name = "writecfg";
            this.writecfg.Size = new System.Drawing.Size(75, 23);
            this.writecfg.TabIndex = 5;
            this.writecfg.Text = "写配置";
            this.writecfg.UseVisualStyleBackColor = true;
            this.writecfg.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "无线功率";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "无线信道";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "无线速率";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "串口停止位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "串口数据位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "串口校验位";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "串口波特率";
            // 
            // databit
            // 
            this.databit.FormattingEnabled = true;
            this.databit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.databit.Location = new System.Drawing.Point(77, 69);
            this.databit.Name = "databit";
            this.databit.Size = new System.Drawing.Size(83, 20);
            this.databit.TabIndex = 3;
            this.databit.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // stopbit
            // 
            this.stopbit.FormattingEnabled = true;
            this.stopbit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopbit.Location = new System.Drawing.Point(77, 95);
            this.stopbit.Name = "stopbit";
            this.stopbit.Size = new System.Drawing.Size(83, 20);
            this.stopbit.TabIndex = 2;
            // 
            // paritybit
            // 
            this.paritybit.FormattingEnabled = true;
            this.paritybit.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.paritybit.Location = new System.Drawing.Point(77, 43);
            this.paritybit.Name = "paritybit";
            this.paritybit.Size = new System.Drawing.Size(83, 20);
            this.paritybit.TabIndex = 1;
            // 
            // baudrate
            // 
            this.baudrate.FormattingEnabled = true;
            this.baudrate.Items.AddRange(new object[] {
            "100",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.baudrate.Location = new System.Drawing.Point(77, 17);
            this.baudrate.Name = "baudrate";
            this.baudrate.Size = new System.Drawing.Size(83, 20);
            this.baudrate.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "模块硬件版本";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "模块软件版本";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(99, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 21);
            this.textBox1.TabIndex = 4;
            // 
            // test
            // 
            this.test.Controls.Add(this.mode);
            this.test.Controls.Add(this.gbtestslave);
            this.test.Controls.Add(this.gbtesthost);
            this.test.Location = new System.Drawing.Point(196, 12);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(246, 375);
            this.test.TabIndex = 5;
            this.test.TabStop = false;
            this.test.Text = "测试";
            // 
            // mode
            // 
            this.mode.AutoSize = true;
            this.mode.Location = new System.Drawing.Point(14, 22);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(72, 16);
            this.mode.TabIndex = 3;
            this.mode.Text = "主从选择";
            this.mode.UseVisualStyleBackColor = true;
            this.mode.CheckedChanged += new System.EventHandler(this.mode_CheckedChanged_1);
            // 
            // gbtestslave
            // 
            this.gbtestslave.Controls.Add(this.tstslavepktrcvcnt);
            this.gbtestslave.Controls.Add(this.label22);
            this.gbtestslave.Controls.Add(this.tstslaverssi);
            this.gbtestslave.Controls.Add(this.tstslavebaudrate);
            this.gbtestslave.Controls.Add(this.tstslavechannel);
            this.gbtestslave.Controls.Add(this.slaveteststart);
            this.gbtestslave.Controls.Add(this.label20);
            this.gbtestslave.Controls.Add(this.label19);
            this.gbtestslave.Controls.Add(this.label18);
            this.gbtestslave.Location = new System.Drawing.Point(6, 237);
            this.gbtestslave.Name = "gbtestslave";
            this.gbtestslave.Size = new System.Drawing.Size(234, 132);
            this.gbtestslave.TabIndex = 2;
            this.gbtestslave.TabStop = false;
            this.gbtestslave.Text = "从机";
            // 
            // tstslavepktrcvcnt
            // 
            this.tstslavepktrcvcnt.Enabled = false;
            this.tstslavepktrcvcnt.Location = new System.Drawing.Point(176, 49);
            this.tstslavepktrcvcnt.Name = "tstslavepktrcvcnt";
            this.tstslavepktrcvcnt.Size = new System.Drawing.Size(52, 21);
            this.tstslavepktrcvcnt.TabIndex = 8;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(118, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 7;
            this.label22.Text = "无线速率";
            // 
            // tstslaverssi
            // 
            this.tstslaverssi.Enabled = false;
            this.tstslaverssi.Location = new System.Drawing.Point(65, 49);
            this.tstslaverssi.Name = "tstslaverssi";
            this.tstslaverssi.Size = new System.Drawing.Size(47, 21);
            this.tstslaverssi.TabIndex = 6;
            // 
            // tstslavebaudrate
            // 
            this.tstslavebaudrate.Location = new System.Drawing.Point(176, 23);
            this.tstslavebaudrate.Name = "tstslavebaudrate";
            this.tstslavebaudrate.Size = new System.Drawing.Size(52, 21);
            this.tstslavebaudrate.TabIndex = 5;
            this.tstslavebaudrate.Text = "10000";
            this.tstslavebaudrate.Leave += new System.EventHandler(this.tstslavebaudrate_Leave);
            // 
            // tstslavechannel
            // 
            this.tstslavechannel.Location = new System.Drawing.Point(65, 23);
            this.tstslavechannel.Name = "tstslavechannel";
            this.tstslavechannel.Size = new System.Drawing.Size(47, 21);
            this.tstslavechannel.TabIndex = 4;
            this.tstslavechannel.Text = "0";
            this.tstslavechannel.Leave += new System.EventHandler(this.tstslavechannel_Leave);
            // 
            // slaveteststart
            // 
            this.slaveteststart.Location = new System.Drawing.Point(8, 87);
            this.slaveteststart.Name = "slaveteststart";
            this.slaveteststart.Size = new System.Drawing.Size(220, 39);
            this.slaveteststart.TabIndex = 3;
            this.slaveteststart.Text = "开始测试";
            this.slaveteststart.UseVisualStyleBackColor = true;
            this.slaveteststart.Click += new System.EventHandler(this.slaveteststart_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(118, 53);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 2;
            this.label20.Text = "接收包数";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 1;
            this.label19.Text = "主机场强";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 0;
            this.label18.Text = "工作信道";
            // 
            // gbtesthost
            // 
            this.gbtesthost.Controls.Add(this.tsthostairpower);
            this.gbtesthost.Controls.Add(this.label21);
            this.gbtesthost.Controls.Add(this.hostteststart);
            this.gbtesthost.Controls.Add(this.tsthosterr);
            this.gbtesthost.Controls.Add(this.tsthostpktrcvcnt);
            this.gbtesthost.Controls.Add(this.tsthostrssi);
            this.gbtesthost.Controls.Add(this.label17);
            this.gbtesthost.Controls.Add(this.label16);
            this.gbtesthost.Controls.Add(this.tsthostpktsendcnt);
            this.gbtesthost.Controls.Add(this.label15);
            this.gbtesthost.Controls.Add(this.label14);
            this.gbtesthost.Controls.Add(this.tsthostdatalen);
            this.gbtesthost.Controls.Add(this.tsthostairbaudrate);
            this.gbtesthost.Controls.Add(this.label13);
            this.gbtesthost.Controls.Add(this.tsthostchannel);
            this.gbtesthost.Controls.Add(this.label12);
            this.gbtesthost.Controls.Add(this.label11);
            this.gbtesthost.Location = new System.Drawing.Point(6, 52);
            this.gbtesthost.Name = "gbtesthost";
            this.gbtesthost.Size = new System.Drawing.Size(234, 174);
            this.gbtesthost.TabIndex = 1;
            this.gbtesthost.TabStop = false;
            this.gbtesthost.Text = "主机";
            // 
            // tsthostairpower
            // 
            this.tsthostairpower.Location = new System.Drawing.Point(176, 52);
            this.tsthostairpower.Name = "tsthostairpower";
            this.tsthostairpower.Size = new System.Drawing.Size(52, 21);
            this.tsthostairpower.TabIndex = 16;
            this.tsthostairpower.Text = "127";
            this.tsthostairpower.Leave += new System.EventHandler(this.tsthostairpower_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(118, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 12);
            this.label21.TabIndex = 15;
            this.label21.Text = "无线速率";
            // 
            // hostteststart
            // 
            this.hostteststart.Location = new System.Drawing.Point(8, 130);
            this.hostteststart.Name = "hostteststart";
            this.hostteststart.Size = new System.Drawing.Size(220, 38);
            this.hostteststart.TabIndex = 14;
            this.hostteststart.Text = "开始测试";
            this.hostteststart.UseVisualStyleBackColor = true;
            this.hostteststart.Click += new System.EventHandler(this.hostteststart_Click);
            // 
            // tsthosterr
            // 
            this.tsthosterr.Enabled = false;
            this.tsthosterr.Location = new System.Drawing.Point(176, 104);
            this.tsthosterr.Name = "tsthosterr";
            this.tsthosterr.Size = new System.Drawing.Size(52, 21);
            this.tsthosterr.TabIndex = 13;
            // 
            // tsthostpktrcvcnt
            // 
            this.tsthostpktrcvcnt.Enabled = false;
            this.tsthostpktrcvcnt.Location = new System.Drawing.Point(176, 78);
            this.tsthostpktrcvcnt.Name = "tsthostpktrcvcnt";
            this.tsthostpktrcvcnt.Size = new System.Drawing.Size(52, 21);
            this.tsthostpktrcvcnt.TabIndex = 12;
            // 
            // tsthostrssi
            // 
            this.tsthostrssi.Enabled = false;
            this.tsthostrssi.Location = new System.Drawing.Point(65, 104);
            this.tsthostrssi.Name = "tsthostrssi";
            this.tsthostrssi.Size = new System.Drawing.Size(47, 21);
            this.tsthostrssi.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(118, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 10;
            this.label17.Text = "接收包数";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 9;
            this.label16.Text = "从机场强";
            // 
            // tsthostpktsendcnt
            // 
            this.tsthostpktsendcnt.Enabled = false;
            this.tsthostpktsendcnt.Location = new System.Drawing.Point(65, 78);
            this.tsthostpktsendcnt.Name = "tsthostpktsendcnt";
            this.tsthostpktsendcnt.Size = new System.Drawing.Size(47, 21);
            this.tsthostpktsendcnt.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(118, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 7;
            this.label15.Text = "丢包概率";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 6;
            this.label14.Text = "发送包数";
            // 
            // tsthostdatalen
            // 
            this.tsthostdatalen.Location = new System.Drawing.Point(65, 52);
            this.tsthostdatalen.Name = "tsthostdatalen";
            this.tsthostdatalen.Size = new System.Drawing.Size(47, 21);
            this.tsthostdatalen.TabIndex = 5;
            this.tsthostdatalen.Text = "10";
            this.tsthostdatalen.Leave += new System.EventHandler(this.tsthostdatalen_Leave);
            // 
            // tsthostairbaudrate
            // 
            this.tsthostairbaudrate.Location = new System.Drawing.Point(176, 25);
            this.tsthostairbaudrate.Name = "tsthostairbaudrate";
            this.tsthostairbaudrate.Size = new System.Drawing.Size(52, 21);
            this.tsthostairbaudrate.TabIndex = 4;
            this.tsthostairbaudrate.Text = "10000";
            this.tsthostairbaudrate.Leave += new System.EventHandler(this.tsthostairbaudrate_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(118, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 3;
            this.label13.Text = "发射功率";
            // 
            // tsthostchannel
            // 
            this.tsthostchannel.Location = new System.Drawing.Point(65, 25);
            this.tsthostchannel.Name = "tsthostchannel";
            this.tsthostchannel.Size = new System.Drawing.Size(47, 21);
            this.tsthostchannel.TabIndex = 2;
            this.tsthostchannel.Text = "0";
            this.tsthostchannel.Leave += new System.EventHandler(this.tsthostchannel_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "数据长度";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "工作信道";
            // 
            // CFG_TOOL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 405);
            this.Controls.Add(this.test);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cfg);
            this.Controls.Add(this.comport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CFG_TOOL";
            this.Text = "模块配置工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.comport.ResumeLayout(false);
            this.comport.PerformLayout();
            this.cfg.ResumeLayout(false);
            this.cfg.PerformLayout();
            this.test.ResumeLayout(false);
            this.test.PerformLayout();
            this.gbtestslave.ResumeLayout(false);
            this.gbtestslave.PerformLayout();
            this.gbtesthost.ResumeLayout(false);
            this.gbtesthost.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox comport;
        private System.Windows.Forms.Button opendevice;
        private System.Windows.Forms.ComboBox serialportlist;
        private System.Windows.Forms.GroupBox cfg;
        private System.Windows.Forms.ComboBox baudrate;
        private System.Windows.Forms.ComboBox databit;
        private System.Windows.Forms.ComboBox stopbit;
        private System.Windows.Forms.ComboBox paritybit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button writecfg;
        private System.Windows.Forms.Button readcfg;
        private System.Windows.Forms.GroupBox test;
        private System.Windows.Forms.GroupBox gbtestslave;
        private System.Windows.Forms.GroupBox gbtesthost;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tsthostdatalen;
        private System.Windows.Forms.TextBox tsthostairbaudrate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tsthostchannel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tsthostpktsendcnt;
        private System.Windows.Forms.TextBox tsthostrssi;
        private System.Windows.Forms.TextBox tsthosterr;
        private System.Windows.Forms.TextBox tsthostpktrcvcnt;
        private System.Windows.Forms.Button slaveteststart;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button hostteststart;
        private System.Windows.Forms.TextBox tstslaverssi;
        private System.Windows.Forms.TextBox tstslavebaudrate;
        private System.Windows.Forms.TextBox tstslavechannel;
        private System.Windows.Forms.TextBox tsthostairpower;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tstslavepktrcvcnt;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox mode;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox airpower;
        private System.Windows.Forms.TextBox channel;
        private System.Windows.Forms.TextBox airbaudrate;
    }
}

