namespace RegisTruck
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pic_LoadedQr = new System.Windows.Forms.PictureBox();
            this.btn_LoadQrFromFile = new System.Windows.Forms.Button();
            this.btn_ReadQr = new System.Windows.Forms.Button();
            this.group_JsonOutput = new System.Windows.Forms.GroupBox();
            this.tBox_JsonOutput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBox_PackageDestination = new System.Windows.Forms.TextBox();
            this.tBox_PackageDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBox_PackageId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBox_PackageWeight = new System.Windows.Forms.TextBox();
            this.tBox_PackageType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBox_PackageDeadline = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pic_QrGenerated = new System.Windows.Forms.PictureBox();
            this.btn_SaveQr = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBox_JsonInput = new System.Windows.Forms.TextBox();
            this.btn_GenerateQr = new System.Windows.Forms.Button();
            this.split_Main = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_ServerStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tBox_TruckType = new System.Windows.Forms.TextBox();
            this.tBox_TruckSerialNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tBox_TruckCapacity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tBox_TruckOperator = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tBox_TruckRepairState = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LoadedQr)).BeginInit();
            this.group_JsonOutput.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_QrGenerated)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_Main)).BeginInit();
            this.split_Main.Panel1.SuspendLayout();
            this.split_Main.Panel2.SuspendLayout();
            this.split_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(926, 417);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(918, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RegisTruck UI";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.group_JsonOutput);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(918, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "QR Reader";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pic_LoadedQr);
            this.groupBox4.Controls.Add(this.btn_LoadQrFromFile);
            this.groupBox4.Controls.Add(this.btn_ReadQr);
            this.groupBox4.Location = new System.Drawing.Point(8, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 354);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "QR code";
            // 
            // pic_LoadedQr
            // 
            this.pic_LoadedQr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_LoadedQr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_LoadedQr.Image = ((System.Drawing.Image)(resources.GetObject("pic_LoadedQr.Image")));
            this.pic_LoadedQr.Location = new System.Drawing.Point(16, 34);
            this.pic_LoadedQr.Name = "pic_LoadedQr";
            this.pic_LoadedQr.Size = new System.Drawing.Size(200, 200);
            this.pic_LoadedQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_LoadedQr.TabIndex = 26;
            this.pic_LoadedQr.TabStop = false;
            // 
            // btn_LoadQrFromFile
            // 
            this.btn_LoadQrFromFile.Location = new System.Drawing.Point(16, 282);
            this.btn_LoadQrFromFile.Name = "btn_LoadQrFromFile";
            this.btn_LoadQrFromFile.Size = new System.Drawing.Size(75, 55);
            this.btn_LoadQrFromFile.TabIndex = 27;
            this.btn_LoadQrFromFile.Text = "Load QR";
            this.btn_LoadQrFromFile.UseVisualStyleBackColor = true;
            this.btn_LoadQrFromFile.Click += new System.EventHandler(this.btn_LoadQrFromFile_Click);
            // 
            // btn_ReadQr
            // 
            this.btn_ReadQr.Location = new System.Drawing.Point(141, 282);
            this.btn_ReadQr.Name = "btn_ReadQr";
            this.btn_ReadQr.Size = new System.Drawing.Size(75, 55);
            this.btn_ReadQr.TabIndex = 25;
            this.btn_ReadQr.Text = "Read QR";
            this.btn_ReadQr.UseVisualStyleBackColor = true;
            this.btn_ReadQr.Click += new System.EventHandler(this.btn_ReadQr_Click);
            // 
            // group_JsonOutput
            // 
            this.group_JsonOutput.Controls.Add(this.tBox_JsonOutput);
            this.group_JsonOutput.Location = new System.Drawing.Point(525, 15);
            this.group_JsonOutput.Name = "group_JsonOutput";
            this.group_JsonOutput.Size = new System.Drawing.Size(384, 354);
            this.group_JsonOutput.TabIndex = 28;
            this.group_JsonOutput.TabStop = false;
            this.group_JsonOutput.Text = "JSON Output";
            // 
            // tBox_JsonOutput
            // 
            this.tBox_JsonOutput.Location = new System.Drawing.Point(14, 31);
            this.tBox_JsonOutput.Multiline = true;
            this.tBox_JsonOutput.Name = "tBox_JsonOutput";
            this.tBox_JsonOutput.Size = new System.Drawing.Size(364, 311);
            this.tBox_JsonOutput.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBox_PackageDestination);
            this.groupBox1.Controls.Add(this.tBox_PackageDescription);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tBox_PackageId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tBox_PackageWeight);
            this.groupBox1.Controls.Add(this.tBox_PackageType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tBox_PackageDeadline);
            this.groupBox1.Location = new System.Drawing.Point(262, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 354);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package Data";
            // 
            // tBox_PackageDestination
            // 
            this.tBox_PackageDestination.Location = new System.Drawing.Point(87, 76);
            this.tBox_PackageDestination.Name = "tBox_PackageDestination";
            this.tBox_PackageDestination.Size = new System.Drawing.Size(152, 20);
            this.tBox_PackageDestination.TabIndex = 2;
            // 
            // tBox_PackageDescription
            // 
            this.tBox_PackageDescription.Location = new System.Drawing.Point(87, 243);
            this.tBox_PackageDescription.Multiline = true;
            this.tBox_PackageDescription.Name = "tBox_PackageDescription";
            this.tBox_PackageDescription.Size = new System.Drawing.Size(152, 99);
            this.tBox_PackageDescription.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Destination:";
            // 
            // tBox_PackageId
            // 
            this.tBox_PackageId.Location = new System.Drawing.Point(87, 36);
            this.tBox_PackageId.Name = "tBox_PackageId";
            this.tBox_PackageId.Size = new System.Drawing.Size(152, 20);
            this.tBox_PackageId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Weight:";
            // 
            // tBox_PackageWeight
            // 
            this.tBox_PackageWeight.Location = new System.Drawing.Point(87, 116);
            this.tBox_PackageWeight.Name = "tBox_PackageWeight";
            this.tBox_PackageWeight.Size = new System.Drawing.Size(152, 20);
            this.tBox_PackageWeight.TabIndex = 3;
            // 
            // tBox_PackageType
            // 
            this.tBox_PackageType.Location = new System.Drawing.Point(87, 200);
            this.tBox_PackageType.Name = "tBox_PackageType";
            this.tBox_PackageType.Size = new System.Drawing.Size(152, 20);
            this.tBox_PackageType.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Deadline:";
            // 
            // tBox_PackageDeadline
            // 
            this.tBox_PackageDeadline.Location = new System.Drawing.Point(87, 159);
            this.tBox_PackageDeadline.Name = "tBox_PackageDeadline";
            this.tBox_PackageDeadline.Size = new System.Drawing.Size(152, 20);
            this.tBox_PackageDeadline.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(918, 391);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "QR Generator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pic_QrGenerated);
            this.groupBox3.Controls.Add(this.btn_SaveQr);
            this.groupBox3.Location = new System.Drawing.Point(580, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 346);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "QR code";
            // 
            // pic_QrGenerated
            // 
            this.pic_QrGenerated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_QrGenerated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_QrGenerated.Image = ((System.Drawing.Image)(resources.GetObject("pic_QrGenerated.Image")));
            this.pic_QrGenerated.Location = new System.Drawing.Point(42, 61);
            this.pic_QrGenerated.Name = "pic_QrGenerated";
            this.pic_QrGenerated.Size = new System.Drawing.Size(200, 200);
            this.pic_QrGenerated.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_QrGenerated.TabIndex = 26;
            this.pic_QrGenerated.TabStop = false;
            // 
            // btn_SaveQr
            // 
            this.btn_SaveQr.Location = new System.Drawing.Point(105, 284);
            this.btn_SaveQr.Name = "btn_SaveQr";
            this.btn_SaveQr.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveQr.TabIndex = 27;
            this.btn_SaveQr.Text = "Save";
            this.btn_SaveQr.UseVisualStyleBackColor = true;
            this.btn_SaveQr.Click += new System.EventHandler(this.btn_SaveQr_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tBox_JsonInput);
            this.groupBox2.Controls.Add(this.btn_GenerateQr);
            this.groupBox2.Location = new System.Drawing.Point(34, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 346);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "JSON Input:";
            // 
            // tBox_JsonInput
            // 
            this.tBox_JsonInput.Location = new System.Drawing.Point(17, 24);
            this.tBox_JsonInput.Multiline = true;
            this.tBox_JsonInput.Name = "tBox_JsonInput";
            this.tBox_JsonInput.Size = new System.Drawing.Size(365, 237);
            this.tBox_JsonInput.TabIndex = 19;
            this.tBox_JsonInput.Text = "{\r\n  \"Id\": 50,\r\n  \"DestinationStationId\": 130,\r\n  \"Weight\": 10,\r\n  \"Deadline\": \"2" +
    "019.11.11\",\r\n  \"Type\": 2,\r\n  \"Description\": \"Valami leírás\"\r\n}";
            // 
            // btn_GenerateQr
            // 
            this.btn_GenerateQr.Location = new System.Drawing.Point(307, 285);
            this.btn_GenerateQr.Name = "btn_GenerateQr";
            this.btn_GenerateQr.Size = new System.Drawing.Size(75, 55);
            this.btn_GenerateQr.TabIndex = 18;
            this.btn_GenerateQr.Text = "Generate QR code";
            this.btn_GenerateQr.UseVisualStyleBackColor = true;
            this.btn_GenerateQr.Click += new System.EventHandler(this.btn_GenerateQr_Click);
            // 
            // split_Main
            // 
            this.split_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_Main.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.split_Main.Location = new System.Drawing.Point(0, 0);
            this.split_Main.Name = "split_Main";
            this.split_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split_Main.Panel1
            // 
            this.split_Main.Panel1.Controls.Add(this.tabControl1);
            // 
            // split_Main.Panel2
            // 
            this.split_Main.Panel2.Controls.Add(this.label16);
            this.split_Main.Panel2.Controls.Add(this.progressBar1);
            this.split_Main.Panel2.Controls.Add(this.label_ServerStatus);
            this.split_Main.Panel2.Controls.Add(this.label10);
            this.split_Main.Panel2.Controls.Add(this.label9);
            this.split_Main.Panel2.Controls.Add(this.label8);
            this.split_Main.Panel2.Controls.Add(this.label7);
            this.split_Main.Size = new System.Drawing.Size(926, 450);
            this.split_Main.SplitterDistance = 417;
            this.split_Main.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Truck Battery:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Next Station:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "1596";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(815, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Server:";
            // 
            // label_ServerStatus
            // 
            this.label_ServerStatus.AutoSize = true;
            this.label_ServerStatus.Location = new System.Drawing.Point(862, 7);
            this.label_ServerStatus.Name = "label_ServerStatus";
            this.label_ServerStatus.Size = new System.Drawing.Size(51, 13);
            this.label_ServerStatus.TabIndex = 4;
            this.label_ServerStatus.Text = "OFFLINE";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(90, 1);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Value = 80;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(679, 385);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Warehouse Map";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox4);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.textBox2);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.tBox_TruckRepairState);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.tBox_TruckOperator);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.tBox_TruckCapacity);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.tBox_TruckSerialNumber);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.tBox_TruckType);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(229, 385);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Truck Information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Type:";
            // 
            // tBox_TruckType
            // 
            this.tBox_TruckType.Location = new System.Drawing.Point(46, 44);
            this.tBox_TruckType.Name = "tBox_TruckType";
            this.tBox_TruckType.Size = new System.Drawing.Size(175, 20);
            this.tBox_TruckType.TabIndex = 1;
            this.tBox_TruckType.Text = "Jungheinrich - EFG 316";
            // 
            // tBox_TruckSerialNumber
            // 
            this.tBox_TruckSerialNumber.Location = new System.Drawing.Point(126, 80);
            this.tBox_TruckSerialNumber.Name = "tBox_TruckSerialNumber";
            this.tBox_TruckSerialNumber.Size = new System.Drawing.Size(95, 20);
            this.tBox_TruckSerialNumber.TabIndex = 3;
            this.tBox_TruckSerialNumber.Text = "SN-222-11-RT5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Serial Number:";
            // 
            // tBox_TruckCapacity
            // 
            this.tBox_TruckCapacity.Location = new System.Drawing.Point(126, 151);
            this.tBox_TruckCapacity.Name = "tBox_TruckCapacity";
            this.tBox_TruckCapacity.Size = new System.Drawing.Size(95, 20);
            this.tBox_TruckCapacity.TabIndex = 5;
            this.tBox_TruckCapacity.Text = "1200 kg";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Capacity:";
            // 
            // tBox_TruckOperator
            // 
            this.tBox_TruckOperator.Location = new System.Drawing.Point(126, 222);
            this.tBox_TruckOperator.Name = "tBox_TruckOperator";
            this.tBox_TruckOperator.Size = new System.Drawing.Size(95, 20);
            this.tBox_TruckOperator.TabIndex = 7;
            this.tBox_TruckOperator.Text = "Mr Operator";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Operator:";
            // 
            // tBox_TruckRepairState
            // 
            this.tBox_TruckRepairState.Location = new System.Drawing.Point(126, 257);
            this.tBox_TruckRepairState.Name = "tBox_TruckRepairState";
            this.tBox_TruckRepairState.Size = new System.Drawing.Size(95, 20);
            this.tBox_TruckRepairState.TabIndex = 9;
            this.tBox_TruckRepairState.Text = "75%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Repair State:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(613, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "2019.11.10 - 16:34";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 295);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Packages onboard:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(95, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "2600 kg";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(62, 118);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Weight:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 327);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(95, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "50 kg";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 330);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "Payload Weight:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(126, 187);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(95, 20);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "1.5 m";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(48, 190);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "Lift Height:";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(918, 391);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Payload";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer1.Size = new System.Drawing.Size(912, 385);
            this.splitContainer1.SplitterDistance = 679;
            this.splitContainer1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.split_Main);
            this.Name = "Form1";
            this.Text = "RegisTruck";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_LoadedQr)).EndInit();
            this.group_JsonOutput.ResumeLayout(false);
            this.group_JsonOutput.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_QrGenerated)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.split_Main.Panel1.ResumeLayout(false);
            this.split_Main.Panel2.ResumeLayout(false);
            this.split_Main.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_Main)).EndInit();
            this.split_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer split_Main;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox group_JsonOutput;
        private System.Windows.Forms.TextBox tBox_JsonOutput;
        private System.Windows.Forms.Button btn_LoadQrFromFile;
        private System.Windows.Forms.PictureBox pic_LoadedQr;
        private System.Windows.Forms.Button btn_ReadQr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBox_PackageDestination;
        private System.Windows.Forms.TextBox tBox_PackageDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBox_PackageId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBox_PackageWeight;
        private System.Windows.Forms.TextBox tBox_PackageType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBox_PackageDeadline;
        private System.Windows.Forms.Button btn_SaveQr;
        private System.Windows.Forms.PictureBox pic_QrGenerated;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tBox_JsonInput;
        private System.Windows.Forms.Button btn_GenerateQr;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_ServerStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tBox_TruckRepairState;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tBox_TruckOperator;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tBox_TruckCapacity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tBox_TruckSerialNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tBox_TruckType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

