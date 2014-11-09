using System.Windows.Forms;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
namespace JHEMR.EMRHisCustom
{
    partial class frmHisCustomCrb
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
            this.tbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbSave = new System.Windows.Forms.ToolStripButton();
            this.tbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsLab = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbQuery = new System.Windows.Forms.ToolStripButton();
            this.tbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbNext = new System.Windows.Forms.ToolStripButton();
            this.tbBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbDelete = new System.Windows.Forms.ToolStripButton();
            this.tbRead = new System.Windows.Forms.ToolStripButton();
            this.tbHistory = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.spbtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.dtpReport_Date_Time = new System.Windows.Forms.DateTimePicker();
            this.spbtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.dtpDisease_Date = new System.Windows.Forms.DateTimePicker();
            this.cmbContagion_Type = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRevise_Disease_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblReport_Doct = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCard_No = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCard_Type = new System.Windows.Forms.ComboBox();
            this.lblID_NO = new System.Windows.Forms.Label();
            this.lblPhone_Number_Business = new System.Windows.Forms.Label();
            this.lblService_Agency = new System.Windows.Forms.Label();
            this.lblMailing_Address = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbPatient_Source = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtParent_Name = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbDisease_Class = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbDisease_Type = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDiag_Date = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpDead_Date = new System.Windows.Forms.DateTimePicker();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbContagion_Type_Name = new System.Windows.Forms.ComboBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtBack_Card_Reason = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblReport_Unit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID_NO = new System.Windows.Forms.TextBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.spbtnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbClose
            // 
            this.tbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbClose.Name = "tbClose";
            this.tbClose.Size = new System.Drawing.Size(33, 22);
            this.tbClose.Text = "退出";
            this.tbClose.Click += new System.EventHandler(this.tbClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbSave
            // 
            this.tbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(33, 22);
            this.tbSave.Text = "保存";
            this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
            // 
            // tbAdd
            // 
            this.tbAdd.Enabled = false;
            this.tbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(33, 22);
            this.tbAdd.Text = "新增";
            this.tbAdd.Click += new System.EventHandler(this.tbAdd_Click);
            // 
            // tsLab
            // 
            this.tsLab.ForeColor = System.Drawing.Color.Blue;
            this.tsLab.Name = "tsLab";
            this.tsLab.Size = new System.Drawing.Size(35, 17);
            this.tsLab.Text = "Ready";
            // 
            // tbQuery
            // 
            this.tbQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Size = new System.Drawing.Size(33, 22);
            this.tbQuery.Text = "查询";
            this.tbQuery.Click += new System.EventHandler(this.tbQuery_Click);
            // 
            // tbPrint
            // 
            this.tbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbPrint.Name = "tbPrint";
            this.tbPrint.Size = new System.Drawing.Size(33, 22);
            this.tbPrint.Text = "打印";
            this.tbPrint.Click += new System.EventHandler(this.tbPrint_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tbNext
            // 
            this.tbNext.Enabled = false;
            this.tbNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbNext.Name = "tbNext";
            this.tbNext.Size = new System.Drawing.Size(33, 22);
            this.tbNext.Text = "下次";
            this.tbNext.Click += new System.EventHandler(this.tbNext_Click);
            // 
            // tbBack
            // 
            this.tbBack.Enabled = false;
            this.tbBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbBack.Name = "tbBack";
            this.tbBack.Size = new System.Drawing.Size(33, 22);
            this.tbBack.Text = "上次";
            this.tbBack.Click += new System.EventHandler(this.tbBack_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbAdd,
            this.tbDelete,
            this.tbSave,
            this.toolStripSeparator1,
            this.tbQuery,
            this.tbPrint,
            this.toolStripSeparator2,
            this.tbBack,
            this.tbNext,
            this.toolStripSeparator3,
            this.tbRead,
            this.tbHistory,
            this.toolStripSeparator4,
            this.tbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(712, 25);
            this.toolStrip1.TabIndex = 588;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbDelete
            // 
            this.tbDelete.Enabled = false;
            this.tbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(33, 22);
            this.tbDelete.Text = "删除";
            this.tbDelete.Click += new System.EventHandler(this.tbDelete_Click);
            // 
            // tbRead
            // 
            this.tbRead.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbRead.Name = "tbRead";
            this.tbRead.Size = new System.Drawing.Size(57, 22);
            this.tbRead.Text = "填卡说明";
            this.tbRead.Click += new System.EventHandler(this.tbRead_Click);
            // 
            // tbHistory
            // 
            this.tbHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbHistory.Name = "tbHistory";
            this.tbHistory.Size = new System.Drawing.Size(105, 22);
            this.tbHistory.Text = "病人历史上报记录";
            this.tbHistory.Click += new System.EventHandler(this.tbHistory_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLab});
            this.statusStrip1.Location = new System.Drawing.Point(0, 493);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(712, 22);
            this.statusStrip1.TabIndex = 587;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // spbtnClose
            // 
            this.spbtnClose.Location = new System.Drawing.Point(580, 420);
            this.spbtnClose.Name = "spbtnClose";
            this.spbtnClose.Size = new System.Drawing.Size(75, 23);
            this.spbtnClose.TabIndex = 583;
            this.spbtnClose.Text = "关闭(&X)";
            this.spbtnClose.Click += new System.EventHandler(this.spbtnClose_Click);
            // 
            // spbtnQuery
            // 
            this.spbtnQuery.Location = new System.Drawing.Point(373, 420);
            this.spbtnQuery.Name = "spbtnQuery";
            this.spbtnQuery.Size = new System.Drawing.Size(112, 23);
            this.spbtnQuery.TabIndex = 584;
            this.spbtnQuery.Text = "科室上报查询(&Q)";
            this.spbtnQuery.Click += new System.EventHandler(this.spbtnQuery_Click);
            // 
            // spbtnPrint
            // 
            this.spbtnPrint.Location = new System.Drawing.Point(290, 420);
            this.spbtnPrint.Name = "spbtnPrint";
            this.spbtnPrint.Size = new System.Drawing.Size(75, 23);
            this.spbtnPrint.TabIndex = 586;
            this.spbtnPrint.Text = "打印(&P)";
            this.spbtnPrint.Click += new System.EventHandler(this.spbtnPrint_Click);
            // 
            // dtpReport_Date_Time
            // 
            this.dtpReport_Date_Time.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpReport_Date_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReport_Date_Time.Location = new System.Drawing.Point(454, 342);
            this.dtpReport_Date_Time.Name = "dtpReport_Date_Time";
            this.dtpReport_Date_Time.Size = new System.Drawing.Size(146, 21);
            this.dtpReport_Date_Time.TabIndex = 14;
            // 
            // spbtnSave
            // 
            this.spbtnSave.Location = new System.Drawing.Point(205, 420);
            this.spbtnSave.Name = "spbtnSave";
            this.spbtnSave.Size = new System.Drawing.Size(75, 23);
            this.spbtnSave.TabIndex = 585;
            this.spbtnSave.Text = "保存(&S)";
            this.spbtnSave.Click += new System.EventHandler(this.spbtnSave_Click);
            // 
            // dtpDisease_Date
            // 
            this.dtpDisease_Date.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpDisease_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDisease_Date.Location = new System.Drawing.Point(102, 197);
            this.dtpDisease_Date.Name = "dtpDisease_Date";
            this.dtpDisease_Date.Size = new System.Drawing.Size(103, 21);
            this.dtpDisease_Date.TabIndex = 6;
            // 
            // cmbContagion_Type
            // 
            this.cmbContagion_Type.FormattingEnabled = true;
            this.cmbContagion_Type.Items.AddRange(new object[] {
            "甲类",
            "乙类",
            "丙类",
            "其他"});
            this.cmbContagion_Type.Location = new System.Drawing.Point(105, 238);
            this.cmbContagion_Type.Name = "cmbContagion_Type";
            this.cmbContagion_Type.Size = new System.Drawing.Size(100, 20);
            this.cmbContagion_Type.TabIndex = 9;
            this.cmbContagion_Type.SelectedIndexChanged += new System.EventHandler(this.cmbContagion_Type_SelectedIndexChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(13, 58);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(660, 1);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 577;
            this.pictureBox6.TabStop = false;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.ForeColor = System.Drawing.Color.Blue;
            this.lblBirthDate.Location = new System.Drawing.Point(276, 74);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(67, 14);
            this.lblBirthDate.TabIndex = 565;
            this.lblBirthDate.Text = "出生日期：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.ForeColor = System.Drawing.Color.Blue;
            this.lblSex.Location = new System.Drawing.Point(156, 74);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(43, 14);
            this.lblSex.TabIndex = 574;
            this.lblSex.Text = "性别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 562;
            this.label3.Text = "发病日期：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 564;
            this.label4.Text = "订正病名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 571;
            this.label2.Text = "传染病类型：";
            // 
            // txtRevise_Disease_Name
            // 
            this.txtRevise_Disease_Name.Location = new System.Drawing.Point(105, 280);
            this.txtRevise_Disease_Name.MaxLength = 80;
            this.txtRevise_Disease_Name.Name = "txtRevise_Disease_Name";
            this.txtRevise_Disease_Name.Size = new System.Drawing.Size(224, 21);
            this.txtRevise_Disease_Name.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(384, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 14);
            this.label7.TabIndex = 573;
            this.label7.Text = "填卡日期：";
            // 
            // lblReport_Doct
            // 
            this.lblReport_Doct.AutoSize = true;
            this.lblReport_Doct.ForeColor = System.Drawing.Color.Blue;
            this.lblReport_Doct.Location = new System.Drawing.Point(32, 342);
            this.lblReport_Doct.Name = "lblReport_Doct";
            this.lblReport_Doct.Size = new System.Drawing.Size(67, 14);
            this.lblReport_Doct.TabIndex = 568;
            this.lblReport_Doct.Text = "报告医生：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Blue;
            this.lblName.Location = new System.Drawing.Point(32, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 14);
            this.lblName.TabIndex = 569;
            this.lblName.Text = "姓名：";
            // 
            // lblCard_No
            // 
            this.lblCard_No.AutoSize = true;
            this.lblCard_No.ForeColor = System.Drawing.Color.Blue;
            this.lblCard_No.Location = new System.Drawing.Point(32, 36);
            this.lblCard_No.Name = "lblCard_No";
            this.lblCard_No.Size = new System.Drawing.Size(43, 14);
            this.lblCard_No.TabIndex = 566;
            this.lblCard_No.Text = "编号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(469, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 14);
            this.label6.TabIndex = 566;
            this.label6.Text = "报卡类别：";
            // 
            // cmbCard_Type
            // 
            this.cmbCard_Type.FormattingEnabled = true;
            this.cmbCard_Type.Items.AddRange(new object[] {
            "初次报告",
            "订正报告"});
            this.cmbCard_Type.Location = new System.Drawing.Point(540, 33);
            this.cmbCard_Type.Name = "cmbCard_Type";
            this.cmbCard_Type.Size = new System.Drawing.Size(112, 20);
            this.cmbCard_Type.TabIndex = 0;
            // 
            // lblID_NO
            // 
            this.lblID_NO.AutoSize = true;
            this.lblID_NO.ForeColor = System.Drawing.Color.Blue;
            this.lblID_NO.Location = new System.Drawing.Point(469, 74);
            this.lblID_NO.Name = "lblID_NO";
            this.lblID_NO.Size = new System.Drawing.Size(67, 14);
            this.lblID_NO.TabIndex = 565;
            this.lblID_NO.Text = "身份证号：";
            // 
            // lblPhone_Number_Business
            // 
            this.lblPhone_Number_Business.AutoSize = true;
            this.lblPhone_Number_Business.ForeColor = System.Drawing.Color.Blue;
            this.lblPhone_Number_Business.Location = new System.Drawing.Point(469, 102);
            this.lblPhone_Number_Business.Name = "lblPhone_Number_Business";
            this.lblPhone_Number_Business.Size = new System.Drawing.Size(67, 14);
            this.lblPhone_Number_Business.TabIndex = 569;
            this.lblPhone_Number_Business.Text = "联系电话：";
            // 
            // lblService_Agency
            // 
            this.lblService_Agency.AutoSize = true;
            this.lblService_Agency.ForeColor = System.Drawing.Color.Blue;
            this.lblService_Agency.Location = new System.Drawing.Point(156, 102);
            this.lblService_Agency.Name = "lblService_Agency";
            this.lblService_Agency.Size = new System.Drawing.Size(67, 14);
            this.lblService_Agency.TabIndex = 569;
            this.lblService_Agency.Text = "工作单位：";
            // 
            // lblMailing_Address
            // 
            this.lblMailing_Address.AutoSize = true;
            this.lblMailing_Address.ForeColor = System.Drawing.Color.Blue;
            this.lblMailing_Address.Location = new System.Drawing.Point(32, 130);
            this.lblMailing_Address.Name = "lblMailing_Address";
            this.lblMailing_Address.Size = new System.Drawing.Size(55, 14);
            this.lblMailing_Address.TabIndex = 569;
            this.lblMailing_Address.Text = "现住址：";
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.ForeColor = System.Drawing.Color.Blue;
            this.lblOccupation.Location = new System.Drawing.Point(32, 102);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(43, 14);
            this.lblOccupation.TabIndex = 574;
            this.lblOccupation.Text = "职业：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(469, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 14);
            this.label13.TabIndex = 572;
            this.label13.Text = "病人属于：";
            // 
            // cmbPatient_Source
            // 
            this.cmbPatient_Source.FormattingEnabled = true;
            this.cmbPatient_Source.Items.AddRange(new object[] {
            "本县区",
            "本市其他县区",
            "本省其他城市",
            "外省",
            "港澳台",
            "外籍"});
            this.cmbPatient_Source.Location = new System.Drawing.Point(540, 125);
            this.cmbPatient_Source.Name = "cmbPatient_Source";
            this.cmbPatient_Source.Size = new System.Drawing.Size(112, 20);
            this.cmbPatient_Source.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(276, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 14);
            this.label14.TabIndex = 572;
            this.label14.Text = "患儿家长姓名：";
            // 
            // txtParent_Name
            // 
            this.txtParent_Name.Location = new System.Drawing.Point(368, 125);
            this.txtParent_Name.MaxLength = 40;
            this.txtParent_Name.Name = "txtParent_Name";
            this.txtParent_Name.Size = new System.Drawing.Size(82, 21);
            this.txtParent_Name.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(32, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 14);
            this.label15.TabIndex = 572;
            this.label15.Text = "病例分类(1)：";
            // 
            // cmbDisease_Class
            // 
            this.cmbDisease_Class.FormattingEnabled = true;
            this.cmbDisease_Class.Items.AddRange(new object[] {
            "疑似病例",
            "临床诊断病例",
            "实验室确诊病例",
            "病原携带者",
            "阳性检测结果(献血员)"});
            this.cmbDisease_Class.Location = new System.Drawing.Point(119, 161);
            this.cmbDisease_Class.Name = "cmbDisease_Class";
            this.cmbDisease_Class.Size = new System.Drawing.Size(129, 20);
            this.cmbDisease_Class.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(276, 164);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 14);
            this.label16.TabIndex = 572;
            this.label16.Text = "病例分类(2)：";
            // 
            // cmbDisease_Type
            // 
            this.cmbDisease_Type.FormattingEnabled = true;
            this.cmbDisease_Type.Items.AddRange(new object[] {
            "急性",
            "慢性(乙型肝炎)"});
            this.cmbDisease_Type.Location = new System.Drawing.Point(366, 161);
            this.cmbDisease_Type.Name = "cmbDisease_Type";
            this.cmbDisease_Type.Size = new System.Drawing.Size(129, 20);
            this.cmbDisease_Type.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(12, 151);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(660, 1);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 577;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(12, 187);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(660, 1);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 577;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(276, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 562;
            this.label1.Text = "诊断日期：";
            // 
            // dtpDiag_Date
            // 
            this.dtpDiag_Date.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpDiag_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDiag_Date.Location = new System.Drawing.Point(346, 197);
            this.dtpDiag_Date.Name = "dtpDiag_Date";
            this.dtpDiag_Date.Size = new System.Drawing.Size(103, 21);
            this.dtpDiag_Date.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(476, 200);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 14);
            this.label17.TabIndex = 562;
            this.label17.Text = "死亡日期：";
            // 
            // dtpDead_Date
            // 
            this.dtpDead_Date.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpDead_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDead_Date.Location = new System.Drawing.Point(549, 197);
            this.dtpDead_Date.Name = "dtpDead_Date";
            this.dtpDead_Date.Size = new System.Drawing.Size(103, 21);
            this.dtpDead_Date.TabIndex = 8;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(13, 224);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(660, 1);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 577;
            this.pictureBox5.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(281, 241);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 14);
            this.label18.TabIndex = 571;
            this.label18.Text = "传染病名称：";
            // 
            // cmbContagion_Type_Name
            // 
            this.cmbContagion_Type_Name.FormattingEnabled = true;
            this.cmbContagion_Type_Name.Items.AddRange(new object[] {
            "鼠疫",
            "霍乱"});
            this.cmbContagion_Type_Name.Location = new System.Drawing.Point(356, 238);
            this.cmbContagion_Type_Name.Name = "cmbContagion_Type_Name";
            this.cmbContagion_Type_Name.Size = new System.Drawing.Size(296, 20);
            this.cmbContagion_Type_Name.TabIndex = 10;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Location = new System.Drawing.Point(13, 265);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(660, 1);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 577;
            this.pictureBox7.TabStop = false;
            // 
            // txtBack_Card_Reason
            // 
            this.txtBack_Card_Reason.Location = new System.Drawing.Point(454, 280);
            this.txtBack_Card_Reason.MaxLength = 80;
            this.txtBack_Card_Reason.Name = "txtBack_Card_Reason";
            this.txtBack_Card_Reason.Size = new System.Drawing.Size(201, 21);
            this.txtBack_Card_Reason.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(383, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 564;
            this.label5.Text = "退卡原因：";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(454, 311);
            this.txtTelephone.MaxLength = 80;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(201, 21);
            this.txtTelephone.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(383, 313);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 14);
            this.label20.TabIndex = 564;
            this.label20.Text = "联系电话：";
            // 
            // lblReport_Unit
            // 
            this.lblReport_Unit.AutoSize = true;
            this.lblReport_Unit.ForeColor = System.Drawing.Color.Blue;
            this.lblReport_Unit.Location = new System.Drawing.Point(32, 313);
            this.lblReport_Unit.Name = "lblReport_Unit";
            this.lblReport_Unit.Size = new System.Drawing.Size(67, 14);
            this.lblReport_Unit.TabIndex = 568;
            this.lblReport_Unit.Text = "报告单位：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 369);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 1);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 577;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(13, 406);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(660, 1);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 577;
            this.pictureBox2.TabStop = false;
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(105, 379);
            this.txtMemo.MaxLength = 80;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(550, 21);
            this.txtMemo.TabIndex = 15;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(15, 456);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(660, 14);
            this.label19.TabIndex = 564;
            this.label19.Text = "注意：1.患者年龄小于14岁需填写家长姓名   2.传染病类型为其他时，传染病名称需要自己填写  3.死亡时间显示1800- 1- 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(52, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(621, 14);
            this.label8.TabIndex = 564;
            this.label8.Text = "表明该人没有死亡  4.一类传染病填写一张报告卡，多个请新建增加上报卡  5.如有不明确请点击填卡说明查看详细。";
            // 
            // txtID_NO
            // 
            this.txtID_NO.Location = new System.Drawing.Point(540, 71);
            this.txtID_NO.MaxLength = 40;
            this.txtID_NO.Name = "txtID_NO";
            this.txtID_NO.Size = new System.Drawing.Size(115, 21);
            this.txtID_NO.TabIndex = 1;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.ForeColor = System.Drawing.Color.Blue;
            this.lblDept.Location = new System.Drawing.Point(247, 39);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(43, 14);
            this.lblDept.TabIndex = 569;
            this.lblDept.Text = "科室：";
            this.lblDept.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(32, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 14);
            this.label9.TabIndex = 573;
            this.label9.Text = "备   注：";
            // 
            // spbtnConfirm
            // 
            this.spbtnConfirm.Location = new System.Drawing.Point(491, 420);
            this.spbtnConfirm.Name = "spbtnConfirm";
            this.spbtnConfirm.Size = new System.Drawing.Size(75, 23);
            this.spbtnConfirm.TabIndex = 583;
            this.spbtnConfirm.Text = "审核(&S)";
            this.spbtnConfirm.Visible = false;
            this.spbtnConfirm.Click += new System.EventHandler(this.spbtnConfirm_Click);
            // 
            // frmHisCustomCrb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 515);
            this.Controls.Add(this.cmbDisease_Type);
            this.Controls.Add(this.cmbDisease_Class);
            this.Controls.Add(this.cmbPatient_Source);
            this.Controls.Add(this.cmbCard_Type);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.spbtnConfirm);
            this.Controls.Add(this.spbtnClose);
            this.Controls.Add(this.spbtnQuery);
            this.Controls.Add(this.spbtnPrint);
            this.Controls.Add(this.dtpReport_Date_Time);
            this.Controls.Add(this.spbtnSave);
            this.Controls.Add(this.dtpDead_Date);
            this.Controls.Add(this.dtpDiag_Date);
            this.Controls.Add(this.dtpDisease_Date);
            this.Controls.Add(this.cmbContagion_Type_Name);
            this.Controls.Add(this.cmbContagion_Type);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblID_NO);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblOccupation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtBack_Card_Reason);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.txtRevise_Disease_Name);
            this.Controls.Add(this.txtID_NO);
            this.Controls.Add(this.txtParent_Name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblReport_Unit);
            this.Controls.Add(this.lblReport_Doct);
            this.Controls.Add(this.lblMailing_Address);
            this.Controls.Add(this.lblService_Agency);
            this.Controls.Add(this.lblPhone_Number_Business);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCard_No);
            this.Name = "frmHisCustomCrb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "传染病报告卡";
            this.Shown += new System.EventHandler(this.frmHisCustomCrb_Shown);
            this.Load += new System.EventHandler(this.frmHisCustomCrb_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStripButton tbClose;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tbSave;
        private ToolStripButton tbAdd;
        private ToolStripStatusLabel tsLab;
        private ToolStripButton tbQuery;
        private ToolStripButton tbPrint;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tbNext;
        private ToolStripButton tbBack;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private SimpleButton spbtnClose;
        private SimpleButton spbtnQuery;
        private SimpleButton spbtnPrint;
        private DateTimePicker dtpReport_Date_Time;
        private SimpleButton spbtnSave;
        private DateTimePicker dtpDisease_Date;
        private System.Windows.Forms.ComboBox cmbContagion_Type;
        private PictureBox pictureBox6;
        private Label lblBirthDate;
        private Label lblSex;
        private Label label3;
        private Label label4;
        private Label label2;
        private TextBox txtRevise_Disease_Name;
        private Label label7;
        private Label lblReport_Doct;
        private Label lblName;
        private Label lblCard_No;
        private Label label6;
        private System.Windows.Forms.ComboBox cmbCard_Type;
        private Label lblID_NO;
        private Label lblPhone_Number_Business;
        private Label lblService_Agency;
        private Label lblMailing_Address;
        private Label lblOccupation;
        private Label label13;
        private System.Windows.Forms.ComboBox cmbPatient_Source;
        private Label label14;
        private TextBox txtParent_Name;
        private Label label15;
        private System.Windows.Forms.ComboBox cmbDisease_Class;
        private Label label16;
        private System.Windows.Forms.ComboBox cmbDisease_Type;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private DateTimePicker dtpDiag_Date;
        private Label label17;
        private DateTimePicker dtpDead_Date;
        private PictureBox pictureBox5;
        private Label label18;
        private System.Windows.Forms.ComboBox cmbContagion_Type_Name;
        private PictureBox pictureBox7;
        private TextBox txtBack_Card_Reason;
        private Label label5;
        private TextBox txtTelephone;
        private Label label20;
        private Label lblReport_Unit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtMemo;
        private Label label19;
        private ToolStripButton tbRead;
        private Label label8;
        private TextBox txtID_NO;
        private Label lblDept;
        private Label label9;
        private ToolStripButton tbDelete;
        public SimpleButton spbtnConfirm;
        private ToolStripButton tbHistory;
        private ToolStripSeparator toolStripSeparator4;
    }
}