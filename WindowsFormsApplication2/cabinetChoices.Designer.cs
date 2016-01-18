namespace WindowsFormsApplication2
{
    partial class SkapDetaljer
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
            this.textBoxProjectNo = new System.Windows.Forms.TextBox();
            this.textBoxQuoteNo = new System.Windows.Forms.TextBox();
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.optionLeakSafety = new System.Windows.Forms.CheckBox();
            this.optionWaterFlowMeter = new System.Windows.Forms.CheckBox();
            this.optionEnergyMeter = new System.Windows.Forms.CheckBox();
            this.optionElectrical = new System.Windows.Forms.CheckBox();
            this.optionWireless = new System.Windows.Forms.CheckBox();
            this.makeQuote = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.comboBoxSelectCustomer = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label20 = new System.Windows.Forms.Label();
            this.addCabinet = new System.Windows.Forms.Button();
            this.cabNo = new System.Windows.Forms.TextBox();
            this.cabQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tapX = new System.Windows.Forms.CheckBox();
            this.tapL = new System.Windows.Forms.CheckBox();
            this.tapM = new System.Windows.Forms.CheckBox();
            this.tapV = new System.Windows.Forms.TextBox();
            this.tapK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.heatX = new System.Windows.Forms.CheckBox();
            this.heatS = new System.Windows.Forms.CheckBox();
            this.heatTm = new System.Windows.Forms.CheckBox();
            this.heatT = new System.Windows.Forms.CheckBox();
            this.heatShare = new System.Windows.Forms.CheckBox();
            this.heatM = new System.Windows.Forms.CheckBox();
            this.heatG = new System.Windows.Forms.TextBox();
            this.heatR = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cabSizeD = new System.Windows.Forms.TextBox();
            this.cabSizeH = new System.Windows.Forms.TextBox();
            this.cabSizeW = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.roomId = new System.Windows.Forms.TextBox();
            this.roomType = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.adminHours = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxProjectNo
            // 
            this.textBoxProjectNo.Location = new System.Drawing.Point(285, 58);
            this.textBoxProjectNo.Name = "textBoxProjectNo";
            this.textBoxProjectNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxProjectNo.TabIndex = 0;
            this.textBoxProjectNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxQuoteNo
            // 
            this.textBoxQuoteNo.Location = new System.Drawing.Point(285, 94);
            this.textBoxQuoteNo.Name = "textBoxQuoteNo";
            this.textBoxQuoteNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuoteNo.TabIndex = 0;
            this.textBoxQuoteNo.Text = "TO";
            this.textBoxQuoteNo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.Location = new System.Drawing.Point(285, 130);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.Size = new System.Drawing.Size(100, 20);
            this.textBoxProjectName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project no.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quote no.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Project name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Options";
            // 
            // optionLeakSafety
            // 
            this.optionLeakSafety.AutoSize = true;
            this.optionLeakSafety.Location = new System.Drawing.Point(465, 73);
            this.optionLeakSafety.Name = "optionLeakSafety";
            this.optionLeakSafety.Size = new System.Drawing.Size(81, 17);
            this.optionLeakSafety.TabIndex = 2;
            this.optionLeakSafety.Text = "Leak safety";
            this.optionLeakSafety.UseVisualStyleBackColor = true;
            // 
            // optionWaterFlowMeter
            // 
            this.optionWaterFlowMeter.AutoSize = true;
            this.optionWaterFlowMeter.Location = new System.Drawing.Point(465, 96);
            this.optionWaterFlowMeter.Name = "optionWaterFlowMeter";
            this.optionWaterFlowMeter.Size = new System.Drawing.Size(152, 17);
            this.optionWaterFlowMeter.TabIndex = 2;
            this.optionWaterFlowMeter.Text = "Prepare for waterflowmeter";
            this.optionWaterFlowMeter.UseVisualStyleBackColor = true;
            // 
            // optionEnergyMeter
            // 
            this.optionEnergyMeter.AutoSize = true;
            this.optionEnergyMeter.Location = new System.Drawing.Point(465, 120);
            this.optionEnergyMeter.Name = "optionEnergyMeter";
            this.optionEnergyMeter.Size = new System.Drawing.Size(136, 17);
            this.optionEnergyMeter.TabIndex = 2;
            this.optionEnergyMeter.Text = "Prepare for energimeter";
            this.optionEnergyMeter.UseVisualStyleBackColor = true;
            // 
            // optionElectrical
            // 
            this.optionElectrical.AutoSize = true;
            this.optionElectrical.Location = new System.Drawing.Point(465, 143);
            this.optionElectrical.Name = "optionElectrical";
            this.optionElectrical.Size = new System.Drawing.Size(127, 17);
            this.optionElectrical.TabIndex = 2;
            this.optionElectrical.Text = "Electrical equipment?";
            this.optionElectrical.UseVisualStyleBackColor = true;
            // 
            // optionWireless
            // 
            this.optionWireless.AutoSize = true;
            this.optionWireless.Location = new System.Drawing.Point(465, 166);
            this.optionWireless.Name = "optionWireless";
            this.optionWireless.Size = new System.Drawing.Size(118, 17);
            this.optionWireless.TabIndex = 2;
            this.optionWireless.Text = "Wireless equipment";
            this.optionWireless.UseVisualStyleBackColor = true;
            // 
            // makeQuote
            // 
            this.makeQuote.Location = new System.Drawing.Point(635, 582);
            this.makeQuote.Name = "makeQuote";
            this.makeQuote.Size = new System.Drawing.Size(112, 23);
            this.makeQuote.TabIndex = 3;
            this.makeQuote.Text = "make quote";
            this.makeQuote.UseVisualStyleBackColor = true;
            this.makeQuote.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(286, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Please fill all textboxes";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(878, 137);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 11;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(906, 118);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(58, 13);
            this.label31.TabIndex = 12;
            this.label31.Text = "Total SUM";
            // 
            // comboBoxSelectCustomer
            // 
            this.comboBoxSelectCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectCustomer.FormattingEnabled = true;
            this.comboBoxSelectCustomer.Location = new System.Drawing.Point(285, 20);
            this.comboBoxSelectCustomer.Name = "comboBoxSelectCustomer";
            this.comboBoxSelectCustomer.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSelectCustomer.TabIndex = 13;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(93, 23);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(84, 13);
            this.label32.TabIndex = 1;
            this.label32.Text = "Select Customer";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm});
            this.dataGridView1.Location = new System.Drawing.Point(124, 455);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // clm
            // 
            this.clm.HeaderText = "cabinet no";
            this.clm.Name = "clm";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(46, 455);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "Cabinet no";
            // 
            // addCabinet
            // 
            this.addCabinet.Location = new System.Drawing.Point(21, 398);
            this.addCabinet.Name = "addCabinet";
            this.addCabinet.Size = new System.Drawing.Size(92, 23);
            this.addCabinet.TabIndex = 20;
            this.addCabinet.Text = "Add More >>";
            this.addCabinet.UseVisualStyleBackColor = true;
            // 
            // cabNo
            // 
            this.cabNo.Enabled = false;
            this.cabNo.Location = new System.Drawing.Point(44, 350);
            this.cabNo.Name = "cabNo";
            this.cabNo.Size = new System.Drawing.Size(34, 20);
            this.cabNo.TabIndex = 16;
            this.cabNo.Text = "1";
            // 
            // cabQuantity
            // 
            this.cabQuantity.Location = new System.Drawing.Point(132, 350);
            this.cabQuantity.Name = "cabQuantity";
            this.cabQuantity.Size = new System.Drawing.Size(34, 20);
            this.cabQuantity.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cabinet no";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(107, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Quantity";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tapX
            // 
            this.tapX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tapX.AutoSize = true;
            this.tapX.Location = new System.Drawing.Point(341, 357);
            this.tapX.Name = "tapX";
            this.tapX.Size = new System.Drawing.Size(15, 14);
            this.tapX.TabIndex = 30;
            this.tapX.UseVisualStyleBackColor = true;
            // 
            // tapL
            // 
            this.tapL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tapL.AutoSize = true;
            this.tapL.Location = new System.Drawing.Point(193, 357);
            this.tapL.Name = "tapL";
            this.tapL.Size = new System.Drawing.Size(29, 17);
            this.tapL.TabIndex = 27;
            this.tapL.Text = " ";
            this.tapL.UseVisualStyleBackColor = true;
            // 
            // tapM
            // 
            this.tapM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tapM.AutoSize = true;
            this.tapM.Location = new System.Drawing.Point(233, 357);
            this.tapM.Name = "tapM";
            this.tapM.Size = new System.Drawing.Size(15, 14);
            this.tapM.TabIndex = 31;
            this.tapM.UseVisualStyleBackColor = true;
            // 
            // tapV
            // 
            this.tapV.Location = new System.Drawing.Point(304, 354);
            this.tapV.Name = "tapV";
            this.tapV.Size = new System.Drawing.Size(27, 20);
            this.tapV.TabIndex = 28;
            // 
            // tapK
            // 
            this.tapK.Location = new System.Drawing.Point(266, 354);
            this.tapK.Name = "tapK";
            this.tapK.Size = new System.Drawing.Size(27, 20);
            this.tapK.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(190, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tap water circuitry";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(301, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "V";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(338, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(230, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "M";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(194, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "L";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(263, 306);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "K";
            // 
            // heatX
            // 
            this.heatX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heatX.AutoSize = true;
            this.heatX.Location = new System.Drawing.Point(632, 357);
            this.heatX.Name = "heatX";
            this.heatX.Size = new System.Drawing.Size(15, 14);
            this.heatX.TabIndex = 48;
            this.heatX.UseVisualStyleBackColor = true;
            // 
            // heatS
            // 
            this.heatS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heatS.AutoSize = true;
            this.heatS.Location = new System.Drawing.Point(606, 357);
            this.heatS.Name = "heatS";
            this.heatS.Size = new System.Drawing.Size(15, 14);
            this.heatS.TabIndex = 47;
            this.heatS.UseVisualStyleBackColor = true;
            // 
            // heatTm
            // 
            this.heatTm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heatTm.AutoSize = true;
            this.heatTm.Location = new System.Drawing.Point(570, 357);
            this.heatTm.Name = "heatTm";
            this.heatTm.Size = new System.Drawing.Size(15, 14);
            this.heatTm.TabIndex = 46;
            this.heatTm.UseVisualStyleBackColor = true;
            // 
            // heatT
            // 
            this.heatT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heatT.AutoSize = true;
            this.heatT.Location = new System.Drawing.Point(539, 357);
            this.heatT.Name = "heatT";
            this.heatT.Size = new System.Drawing.Size(15, 14);
            this.heatT.TabIndex = 45;
            this.heatT.UseVisualStyleBackColor = true;
            // 
            // heatShare
            // 
            this.heatShare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heatShare.AutoSize = true;
            this.heatShare.Location = new System.Drawing.Point(462, 357);
            this.heatShare.Name = "heatShare";
            this.heatShare.Size = new System.Drawing.Size(15, 14);
            this.heatShare.TabIndex = 44;
            this.heatShare.UseVisualStyleBackColor = true;
            // 
            // heatM
            // 
            this.heatM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heatM.AutoSize = true;
            this.heatM.Location = new System.Drawing.Point(398, 357);
            this.heatM.Name = "heatM";
            this.heatM.Size = new System.Drawing.Size(15, 14);
            this.heatM.TabIndex = 43;
            this.heatM.UseVisualStyleBackColor = true;
            // 
            // heatG
            // 
            this.heatG.Location = new System.Drawing.Point(498, 354);
            this.heatG.Name = "heatG";
            this.heatG.Size = new System.Drawing.Size(27, 20);
            this.heatG.TabIndex = 41;
            // 
            // heatR
            // 
            this.heatR.Location = new System.Drawing.Point(429, 354);
            this.heatR.Name = "heatR";
            this.heatR.Size = new System.Drawing.Size(27, 20);
            this.heatR.TabIndex = 42;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(426, 306);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 13);
            this.label21.TabIndex = 32;
            this.label21.Text = "R";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(395, 271);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(254, 18);
            this.label22.TabIndex = 38;
            this.label22.Text = "Heating circuitry";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(603, 306);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(15, 13);
            this.label24.TabIndex = 37;
            this.label24.Text = "S";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(629, 306);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "X";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(448, 306);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 13);
            this.label26.TabIndex = 35;
            this.label26.Text = "<-Dele->";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(509, 306);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(16, 13);
            this.label27.TabIndex = 34;
            this.label27.Text = "G";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(395, 306);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(17, 13);
            this.label28.TabIndex = 33;
            this.label28.Text = "M";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(567, 306);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(24, 13);
            this.label29.TabIndex = 39;
            this.label29.Text = "Tm";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(536, 306);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(15, 13);
            this.label30.TabIndex = 40;
            this.label30.Text = "T";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(671, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 18);
            this.label14.TabIndex = 49;
            this.label14.Text = "Cabinet size";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(668, 307);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(165, 13);
            this.label16.TabIndex = 50;
            this.label16.Text = "W  x  H  x  D (cm)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cabSizeD
            // 
            this.cabSizeD.Location = new System.Drawing.Point(767, 352);
            this.cabSizeD.Name = "cabSizeD";
            this.cabSizeD.Size = new System.Drawing.Size(20, 20);
            this.cabSizeD.TabIndex = 51;
            // 
            // cabSizeH
            // 
            this.cabSizeH.Location = new System.Drawing.Point(732, 352);
            this.cabSizeH.Name = "cabSizeH";
            this.cabSizeH.Size = new System.Drawing.Size(20, 20);
            this.cabSizeH.TabIndex = 52;
            // 
            // cabSizeW
            // 
            this.cabSizeW.Location = new System.Drawing.Point(697, 352);
            this.cabSizeW.Name = "cabSizeW";
            this.cabSizeW.Size = new System.Drawing.Size(20, 20);
            this.cabSizeW.TabIndex = 53;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(839, 271);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(156, 18);
            this.label18.TabIndex = 54;
            this.label18.Text = "Room";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(934, 307);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 55;
            this.label17.Text = "Id no";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roomId
            // 
            this.roomId.AccessibleDescription = "Adskilt med komma";
            this.roomId.Location = new System.Drawing.Point(937, 352);
            this.roomId.Name = "roomId";
            this.roomId.Size = new System.Drawing.Size(55, 20);
            this.roomId.TabIndex = 57;
            // 
            // roomType
            // 
            this.roomType.Location = new System.Drawing.Point(842, 352);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(55, 20);
            this.roomType.TabIndex = 58;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(839, 307);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 56;
            this.label19.Text = "Type";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1032, 270);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(156, 18);
            this.label23.TabIndex = 59;
            this.label23.Text = "Cost";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminHours
            // 
            this.adminHours.Location = new System.Drawing.Point(1035, 351);
            this.adminHours.Name = "adminHours";
            this.adminHours.Size = new System.Drawing.Size(55, 20);
            this.adminHours.TabIndex = 61;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(1032, 306);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(133, 13);
            this.label25.TabIndex = 60;
            this.label25.Text = "Administration hours";
            // 
            // SkapDetaljer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 611);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.adminHours);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.roomId);
            this.Controls.Add(this.roomType);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cabSizeD);
            this.Controls.Add(this.cabSizeH);
            this.Controls.Add(this.cabSizeW);
            this.Controls.Add(this.heatX);
            this.Controls.Add(this.heatS);
            this.Controls.Add(this.heatTm);
            this.Controls.Add(this.heatT);
            this.Controls.Add(this.heatShare);
            this.Controls.Add(this.heatM);
            this.Controls.Add(this.heatG);
            this.Controls.Add(this.heatR);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.tapX);
            this.Controls.Add(this.tapL);
            this.Controls.Add(this.tapM);
            this.Controls.Add(this.tapV);
            this.Controls.Add(this.tapK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.addCabinet);
            this.Controls.Add(this.cabNo);
            this.Controls.Add(this.cabQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxSelectCustomer);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.makeQuote);
            this.Controls.Add(this.optionWireless);
            this.Controls.Add(this.optionElectrical);
            this.Controls.Add(this.optionEnergyMeter);
            this.Controls.Add(this.optionWaterFlowMeter);
            this.Controls.Add(this.optionLeakSafety);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProjectName);
            this.Controls.Add(this.textBoxQuoteNo);
            this.Controls.Add(this.textBoxProjectNo);
            this.Name = "SkapDetaljer";
            this.Text = "Cabinet Choices";
            this.Load += new System.EventHandler(this.SkapDetaljer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProjectNo;
        private System.Windows.Forms.TextBox textBoxQuoteNo;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox optionLeakSafety;
        private System.Windows.Forms.CheckBox optionWaterFlowMeter;
        private System.Windows.Forms.CheckBox optionEnergyMeter;
        private System.Windows.Forms.CheckBox optionElectrical;
        private System.Windows.Forms.CheckBox optionWireless;
        private System.Windows.Forms.Button makeQuote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox comboBoxSelectCustomer;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm;
        private System.Windows.Forms.Button addCabinet;
        private System.Windows.Forms.TextBox cabNo;
        private System.Windows.Forms.TextBox cabQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox tapX;
        private System.Windows.Forms.CheckBox tapL;
        private System.Windows.Forms.CheckBox tapM;
        private System.Windows.Forms.TextBox tapV;
        private System.Windows.Forms.TextBox tapK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox heatX;
        private System.Windows.Forms.CheckBox heatS;
        private System.Windows.Forms.CheckBox heatTm;
        private System.Windows.Forms.CheckBox heatT;
        private System.Windows.Forms.CheckBox heatShare;
        private System.Windows.Forms.CheckBox heatM;
        private System.Windows.Forms.TextBox heatG;
        private System.Windows.Forms.TextBox heatR;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox cabSizeD;
        private System.Windows.Forms.TextBox cabSizeH;
        private System.Windows.Forms.TextBox cabSizeW;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox roomId;
        private System.Windows.Forms.TextBox roomType;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox adminHours;
        private System.Windows.Forms.Label label25;
    }
}