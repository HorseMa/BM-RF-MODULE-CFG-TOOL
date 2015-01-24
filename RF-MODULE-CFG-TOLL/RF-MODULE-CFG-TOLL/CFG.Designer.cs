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
            this.comport = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.opendevice = new System.Windows.Forms.Button();
            this.cfg = new System.Windows.Forms.GroupBox();
            this.baudrate = new System.Windows.Forms.ComboBox();
            this.paritybit = new System.Windows.Forms.ComboBox();
            this.stopbit = new System.Windows.Forms.ComboBox();
            this.databit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.writecfg = new System.Windows.Forms.Button();
            this.readcfg = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.GroupBox();
            this.mode = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.hostteststart = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.slaveteststart = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.comport.SuspendLayout();
            this.cfg.SuspendLayout();
            this.test.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comport
            // 
            this.comport.Controls.Add(this.textBox2);
            this.comport.Controls.Add(this.textBox3);
            this.comport.Controls.Add(this.label9);
            this.comport.Controls.Add(this.opendevice);
            this.comport.Controls.Add(this.comboBox1);
            this.comport.Location = new System.Drawing.Point(12, 12);
            this.comport.Name = "comport";
            this.comport.Size = new System.Drawing.Size(168, 136);
            this.comport.TabIndex = 0;
            this.comport.TabStop = false;
            this.comport.Text = "端口";
            this.comport.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(73, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // opendevice
            // 
            this.opendevice.Location = new System.Drawing.Point(87, 12);
            this.opendevice.Name = "opendevice";
            this.opendevice.Size = new System.Drawing.Size(73, 26);
            this.opendevice.TabIndex = 1;
            this.opendevice.Text = "打开端口";
            this.opendevice.UseVisualStyleBackColor = true;
            // 
            // cfg
            // 
            this.cfg.Controls.Add(this.readcfg);
            this.cfg.Controls.Add(this.writecfg);
            this.cfg.Controls.Add(this.comboBox4);
            this.cfg.Controls.Add(this.label10);
            this.cfg.Controls.Add(this.comboBox3);
            this.cfg.Controls.Add(this.label6);
            this.cfg.Controls.Add(this.comboBox2);
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
            // baudrate
            // 
            this.baudrate.FormattingEnabled = true;
            this.baudrate.Location = new System.Drawing.Point(77, 17);
            this.baudrate.Name = "baudrate";
            this.baudrate.Size = new System.Drawing.Size(83, 20);
            this.baudrate.TabIndex = 0;
            // 
            // paritybit
            // 
            this.paritybit.FormattingEnabled = true;
            this.paritybit.Location = new System.Drawing.Point(77, 43);
            this.paritybit.Name = "paritybit";
            this.paritybit.Size = new System.Drawing.Size(83, 20);
            this.paritybit.TabIndex = 1;
            // 
            // stopbit
            // 
            this.stopbit.FormattingEnabled = true;
            this.stopbit.Location = new System.Drawing.Point(77, 95);
            this.stopbit.Name = "stopbit";
            this.stopbit.Size = new System.Drawing.Size(83, 20);
            this.stopbit.TabIndex = 2;
            // 
            // databit
            // 
            this.databit.FormattingEnabled = true;
            this.databit.Location = new System.Drawing.Point(77, 69);
            this.databit.Name = "databit";
            this.databit.Size = new System.Drawing.Size(83, 20);
            this.databit.TabIndex = 3;
            this.databit.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "串口校验位";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "串口停止位";
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(77, 121);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(83, 20);
            this.comboBox2.TabIndex = 9;
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
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(77, 145);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(83, 20);
            this.comboBox3.TabIndex = 11;
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
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(87, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 21);
            this.textBox2.TabIndex = 5;
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
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(87, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(73, 21);
            this.textBox3.TabIndex = 3;
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
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(77, 171);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(83, 20);
            this.comboBox4.TabIndex = 13;
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
            // readcfg
            // 
            this.readcfg.Location = new System.Drawing.Point(87, 210);
            this.readcfg.Name = "readcfg";
            this.readcfg.Size = new System.Drawing.Size(73, 23);
            this.readcfg.TabIndex = 14;
            this.readcfg.Text = "读配置";
            this.readcfg.UseVisualStyleBackColor = true;
            // 
            // test
            // 
            this.test.Controls.Add(this.groupBox2);
            this.test.Controls.Add(this.groupBox1);
            this.test.Controls.Add(this.mode);
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
            this.mode.Location = new System.Drawing.Point(6, 20);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(71, 16);
            this.mode.TabIndex = 0;
            this.mode.TabStop = true;
            this.mode.Text = "主从选择";
            this.mode.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.hostteststart);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(6, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "主机";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox15);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.textBox13);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.slaveteststart);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(6, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 132);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "从机";
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "数据长度";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(65, 25);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(47, 21);
            this.textBox4.TabIndex = 2;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(176, 25);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(52, 21);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(65, 52);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(47, 21);
            this.textBox6.TabIndex = 5;
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(118, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 7;
            this.label15.Text = "丢包概率";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(65, 78);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(47, 21);
            this.textBox7.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 9;
            this.label16.Text = "从机场强";
            this.label16.Click += new System.EventHandler(this.label16_Click);
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
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(65, 104);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(47, 21);
            this.textBox8.TabIndex = 11;
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(176, 78);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(52, 21);
            this.textBox9.TabIndex = 12;
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(176, 104);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(52, 21);
            this.textBox10.TabIndex = 13;
            // 
            // hostteststart
            // 
            this.hostteststart.Location = new System.Drawing.Point(8, 130);
            this.hostteststart.Name = "hostteststart";
            this.hostteststart.Size = new System.Drawing.Size(220, 38);
            this.hostteststart.TabIndex = 14;
            this.hostteststart.Text = "开始测试";
            this.hostteststart.UseVisualStyleBackColor = true;
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
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 1;
            this.label19.Text = "主机场强";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(118, 53);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 2;
            this.label20.Text = "接收包数";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // slaveteststart
            // 
            this.slaveteststart.Location = new System.Drawing.Point(8, 87);
            this.slaveteststart.Name = "slaveteststart";
            this.slaveteststart.Size = new System.Drawing.Size(220, 39);
            this.slaveteststart.TabIndex = 3;
            this.slaveteststart.Text = "开始测试";
            this.slaveteststart.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(65, 23);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(47, 21);
            this.textBox11.TabIndex = 4;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(176, 23);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(52, 21);
            this.textBox12.TabIndex = 5;
            // 
            // textBox13
            // 
            this.textBox13.Enabled = false;
            this.textBox13.Location = new System.Drawing.Point(65, 49);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(47, 21);
            this.textBox13.TabIndex = 6;
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
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(176, 52);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(52, 21);
            this.textBox14.TabIndex = 16;
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
            // textBox15
            // 
            this.textBox15.Enabled = false;
            this.textBox15.Location = new System.Drawing.Point(176, 49);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(52, 21);
            this.textBox15.TabIndex = 8;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox comport;
        private System.Windows.Forms.Button opendevice;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox cfg;
        private System.Windows.Forms.ComboBox baudrate;
        private System.Windows.Forms.ComboBox databit;
        private System.Windows.Forms.ComboBox stopbit;
        private System.Windows.Forms.ComboBox paritybit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button writecfg;
        private System.Windows.Forms.Button readcfg;
        private System.Windows.Forms.GroupBox test;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton mode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button slaveteststart;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button hostteststart;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label22;
    }
}

