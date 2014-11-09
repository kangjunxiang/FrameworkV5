
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
namespace JHEMR.EMRHisCustom
{
    partial class frmHisCustomInfect
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
            this.lblCard_No = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtClin_Diag = new System.Windows.Forms.TextBox();
            this.lblBed_No = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbInfection_Part = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpInfection_Date_Time = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInfection_Symp_Lab = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblReport_Doct = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpReport_Date_Time = new System.Windows.Forms.DateTimePicker();
            this.spbtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsLab = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDisAdd = new System.Windows.Forms.ToolStripButton();
            this.tbDelete = new System.Windows.Forms.ToolStripButton();
            this.tbSave = new System.Windows.Forms.ToolStripButton();
            this.tbQuery = new System.Windows.Forms.ToolStripButton();
            this.tbPrint = new System.Windows.Forms.ToolStripButton();
            this.tbBack = new System.Windows.Forms.ToolStripButton();
            this.tbNext = new System.Windows.Forms.ToolStripButton();
            this.tbHistory = new System.Windows.Forms.ToolStripButton();
            this.tbClose = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbInfection_Part_Parent = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbInfection_Part_Class = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.spbtnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbBYXSJ_FLAG = new System.Windows.Forms.ComboBox();
            this.lbPatientID = new System.Windows.Forms.Label();
            this.lbInpNO = new System.Windows.Forms.Label();
            this.tbAdd = new System.Windows.Forms.ToolStripButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCard_No
            // 
            this.lblCard_No.AutoSize = true;
            this.lblCard_No.ForeColor = System.Drawing.Color.Blue;
            this.lblCard_No.Location = new System.Drawing.Point(412, 45);
            this.lblCard_No.Name = "lblCard_No";
            this.lblCard_No.Size = new System.Drawing.Size(43, 14);
            this.lblCard_No.TabIndex = 99;
            this.lblCard_No.Text = "编号：";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.ForeColor = System.Drawing.Color.Blue;
            this.lblDept.Location = new System.Drawing.Point(33, 45);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(43, 14);
            this.lblDept.TabIndex = 99;
            this.lblDept.Text = "科室：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Blue;
            this.lblName.Location = new System.Drawing.Point(33, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 14);
            this.lblName.TabIndex = 99;
            this.lblName.Text = "姓名：";
            // 
            // txtClin_Diag
            // 
            this.txtClin_Diag.Location = new System.Drawing.Point(101, 111);
            this.txtClin_Diag.MaxLength = 40;
            this.txtClin_Diag.Name = "txtClin_Diag";
            this.txtClin_Diag.Size = new System.Drawing.Size(423, 21);
            this.txtClin_Diag.TabIndex = 0;
            this.txtClin_Diag.Enter += new System.EventHandler(this.txtClin_Diag_Enter);
            this.txtClin_Diag.Leave += new System.EventHandler(this.txtClin_Diag_Leave);
            this.txtClin_Diag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClin_Diag_KeyDown);
            // 
            // lblBed_No
            // 
            this.lblBed_No.AutoSize = true;
            this.lblBed_No.ForeColor = System.Drawing.Color.Blue;
            this.lblBed_No.Location = new System.Drawing.Point(149, 85);
            this.lblBed_No.Name = "lblBed_No";
            this.lblBed_No.Size = new System.Drawing.Size(43, 14);
            this.lblBed_No.TabIndex = 99;
            this.lblBed_No.Text = "床号：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.ForeColor = System.Drawing.Color.Blue;
            this.lblSex.Location = new System.Drawing.Point(269, 85);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(43, 14);
            this.lblSex.TabIndex = 99;
            this.lblSex.Text = "性别：";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.ForeColor = System.Drawing.Color.Blue;
            this.lblAge.Location = new System.Drawing.Point(392, 85);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(43, 14);
            this.lblAge.TabIndex = 99;
            this.lblAge.Text = "年龄：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 99;
            this.label1.Text = "原发诊断：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 99;
            this.label2.Text = "感染部位：";
            // 
            // cmbInfection_Part
            // 
            this.cmbInfection_Part.FormattingEnabled = true;
            this.cmbInfection_Part.Location = new System.Drawing.Point(103, 215);
            this.cmbInfection_Part.Name = "cmbInfection_Part";
            this.cmbInfection_Part.Size = new System.Drawing.Size(154, 20);
            this.cmbInfection_Part.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(308, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 99;
            this.label3.Text = "感染时间：";
            // 
            // dtpInfection_Date_Time
            // 
            this.dtpInfection_Date_Time.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpInfection_Date_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInfection_Date_Time.Location = new System.Drawing.Point(378, 215);
            this.dtpInfection_Date_Time.Name = "dtpInfection_Date_Time";
            this.dtpInfection_Date_Time.Size = new System.Drawing.Size(146, 21);
            this.dtpInfection_Date_Time.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(35, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 14);
            this.label4.TabIndex = 99;
            this.label4.Text = "感染迹象：(症";
            // 
            // txtInfection_Symp_Lab
            // 
            this.txtInfection_Symp_Lab.Location = new System.Drawing.Point(125, 256);
            this.txtInfection_Symp_Lab.MaxLength = 80;
            this.txtInfection_Symp_Lab.Multiline = true;
            this.txtInfection_Symp_Lab.Name = "txtInfection_Symp_Lab";
            this.txtInfection_Symp_Lab.Size = new System.Drawing.Size(399, 38);
            this.txtInfection_Symp_Lab.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(35, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "状及化验结果)";
            // 
            // lblReport_Doct
            // 
            this.lblReport_Doct.AutoSize = true;
            this.lblReport_Doct.ForeColor = System.Drawing.Color.Blue;
            this.lblReport_Doct.Location = new System.Drawing.Point(35, 328);
            this.lblReport_Doct.Name = "lblReport_Doct";
            this.lblReport_Doct.Size = new System.Drawing.Size(55, 14);
            this.lblReport_Doct.TabIndex = 99;
            this.lblReport_Doct.Text = "上报人：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(308, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 14);
            this.label7.TabIndex = 99;
            this.label7.Text = "上报时间：";
            // 
            // dtpReport_Date_Time
            // 
            this.dtpReport_Date_Time.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpReport_Date_Time.Enabled = false;
            this.dtpReport_Date_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReport_Date_Time.Location = new System.Drawing.Point(378, 325);
            this.dtpReport_Date_Time.Name = "dtpReport_Date_Time";
            this.dtpReport_Date_Time.Size = new System.Drawing.Size(146, 21);
            this.dtpReport_Date_Time.TabIndex = 6;
            // 
            // spbtnSave
            // 
            this.spbtnSave.Location = new System.Drawing.Point(90, 371);
            this.spbtnSave.Name = "spbtnSave";
            this.spbtnSave.Size = new System.Drawing.Size(75, 23);
            this.spbtnSave.TabIndex = 7;
            this.spbtnSave.Text = "保存(&S)";
            this.spbtnSave.Click += new System.EventHandler(this.spbtnSave_Click);
            // 
            // spbtnPrint
            // 
            this.spbtnPrint.Location = new System.Drawing.Point(171, 371);
            this.spbtnPrint.Name = "spbtnPrint";
            this.spbtnPrint.Size = new System.Drawing.Size(75, 23);
            this.spbtnPrint.TabIndex = 8;
            this.spbtnPrint.Text = "打印(&P)";
            this.spbtnPrint.Click += new System.EventHandler(this.spbtnPrint_Click);
            // 
            // spbtnClose
            // 
            this.spbtnClose.Location = new System.Drawing.Point(439, 371);
            this.spbtnClose.Name = "spbtnClose";
            this.spbtnClose.Size = new System.Drawing.Size(75, 23);
            this.spbtnClose.TabIndex = 10;
            this.spbtnClose.Text = "关闭(&X)";
            this.spbtnClose.Click += new System.EventHandler(this.spbtnClose_Click);
            // 
            // spbtnQuery
            // 
            this.spbtnQuery.Location = new System.Drawing.Point(259, 371);
            this.spbtnQuery.Name = "spbtnQuery";
            this.spbtnQuery.Size = new System.Drawing.Size(92, 23);
            this.spbtnQuery.TabIndex = 9;
            this.spbtnQuery.Text = "上报查询(&Q)";
            this.spbtnQuery.Click += new System.EventHandler(this.spbtnQuery_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLab,
            this.ts2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(563, 22);
            this.statusStrip1.TabIndex = 560;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsLab
            // 
            this.tsLab.Name = "tsLab";
            this.tsLab.Size = new System.Drawing.Size(35, 17);
            this.tsLab.Text = "Ready";
            // 
            // ts2
            // 
            this.ts2.Name = "ts2";
            this.ts2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbAdd,
            this.btnDisAdd,
            this.tbDelete,
            this.tbSave,
            this.tbQuery,
            this.tbPrint,
            this.tbBack,
            this.tbNext,
            this.tbHistory,
            this.tbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(563, 25);
            this.toolStrip1.TabIndex = 561;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDisAdd
            // 
            this.btnDisAdd.Enabled = false;
            this.btnDisAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDisAdd.Name = "btnDisAdd";
            this.btnDisAdd.Size = new System.Drawing.Size(57, 22);
            this.btnDisAdd.Text = "出院新增";
            this.btnDisAdd.Click += new System.EventHandler(this.btnDisAdd_Click);
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
            // tbSave
            // 
            this.tbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(33, 22);
            this.tbSave.Text = "保存";
            this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
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
            // tbBack
            // 
            this.tbBack.Enabled = false;
            this.tbBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbBack.Name = "tbBack";
            this.tbBack.Size = new System.Drawing.Size(33, 22);
            this.tbBack.Text = "上次";
            this.tbBack.Click += new System.EventHandler(this.tbBack_Click);
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
            // tbHistory
            // 
            this.tbHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbHistory.Name = "tbHistory";
            this.tbHistory.Size = new System.Drawing.Size(57, 22);
            this.tbHistory.Text = "历史记录";
            this.tbHistory.Click += new System.EventHandler(this.tbHistory_Click);
            // 
            // tbClose
            // 
            this.tbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbClose.Name = "tbClose";
            this.tbClose.Size = new System.Drawing.Size(33, 22);
            this.tbClose.Text = "退出";
            this.tbClose.Click += new System.EventHandler(this.tbClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(283, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 14);
            this.label6.TabIndex = 99;
            this.label6.Text = "感染部位子分类：";
            // 
            // cmbInfection_Part_Parent
            // 
            this.cmbInfection_Part_Parent.FormattingEnabled = true;
            this.cmbInfection_Part_Parent.Location = new System.Drawing.Point(378, 177);
            this.cmbInfection_Part_Parent.Name = "cmbInfection_Part_Parent";
            this.cmbInfection_Part_Parent.Size = new System.Drawing.Size(146, 20);
            this.cmbInfection_Part_Parent.TabIndex = 2;
            this.cmbInfection_Part_Parent.SelectedIndexChanged += new System.EventHandler(this.cmbInfection_Part_Parent_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(35, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "感染部位分类：";
            // 
            // cmbInfection_Part_Class
            // 
            this.cmbInfection_Part_Class.FormattingEnabled = true;
            this.cmbInfection_Part_Class.Location = new System.Drawing.Point(121, 177);
            this.cmbInfection_Part_Class.Name = "cmbInfection_Part_Class";
            this.cmbInfection_Part_Class.Size = new System.Drawing.Size(136, 20);
            this.cmbInfection_Part_Class.TabIndex = 1;
            this.cmbInfection_Part_Class.SelectedIndexChanged += new System.EventHandler(this.cmbInfection_Part_Class_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(30, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(475, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "感染部位填写请先选择感染部位分类以及子分类，如果子分类下没有感染部位分类，则感";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(35, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "染部位子分类与感染部位名称相同。";
            // 
            // spbtnConfirm
            // 
            this.spbtnConfirm.Location = new System.Drawing.Point(358, 371);
            this.spbtnConfirm.Name = "spbtnConfirm";
            this.spbtnConfirm.Size = new System.Drawing.Size(75, 23);
            this.spbtnConfirm.TabIndex = 584;
            this.spbtnConfirm.Text = "审核(&S)";
            this.spbtnConfirm.Visible = false;
            this.spbtnConfirm.Click += new System.EventHandler(this.spbtnConfirm_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(35, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 14);
            this.label11.TabIndex = 0;
            this.label11.Text = "病原学送检标记：";
            // 
            // cmbBYXSJ_FLAG
            // 
            this.cmbBYXSJ_FLAG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBYXSJ_FLAG.FormattingEnabled = true;
            this.cmbBYXSJ_FLAG.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cmbBYXSJ_FLAG.Location = new System.Drawing.Point(144, 148);
            this.cmbBYXSJ_FLAG.Name = "cmbBYXSJ_FLAG";
            this.cmbBYXSJ_FLAG.Size = new System.Drawing.Size(113, 20);
            this.cmbBYXSJ_FLAG.TabIndex = 1;
            // 
            // lbPatientID
            // 
            this.lbPatientID.AutoSize = true;
            this.lbPatientID.ForeColor = System.Drawing.Color.Blue;
            this.lbPatientID.Location = new System.Drawing.Point(191, 45);
            this.lbPatientID.Name = "lbPatientID";
            this.lbPatientID.Size = new System.Drawing.Size(31, 14);
            this.lbPatientID.TabIndex = 99;
            this.lbPatientID.Text = "ID：";
            // 
            // lbInpNO
            // 
            this.lbInpNO.AutoSize = true;
            this.lbInpNO.ForeColor = System.Drawing.Color.Blue;
            this.lbInpNO.Location = new System.Drawing.Point(296, 45);
            this.lbInpNO.Name = "lbInpNO";
            this.lbInpNO.Size = new System.Drawing.Size(55, 14);
            this.lbInpNO.TabIndex = 99;
            this.lbInpNO.Text = "住院号：";
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(14, 361);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(530, 1);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 556;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(15, 311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 1);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 556;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(12, 69);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(530, 1);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 556;
            this.pictureBox6.TabStop = false;
            // 
            // frmHisCustomInfect
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(563, 491);
            this.Controls.Add(this.spbtnConfirm);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.spbtnClose);
            this.Controls.Add(this.spbtnQuery);
            this.Controls.Add(this.spbtnPrint);
            this.Controls.Add(this.spbtnSave);
            this.Controls.Add(this.dtpReport_Date_Time);
            this.Controls.Add(this.dtpInfection_Date_Time);
            this.Controls.Add(this.cmbBYXSJ_FLAG);
            this.Controls.Add(this.cmbInfection_Part_Class);
            this.Controls.Add(this.cmbInfection_Part_Parent);
            this.Controls.Add(this.cmbInfection_Part);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblBed_No);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInfection_Symp_Lab);
            this.Controls.Add(this.txtClin_Diag);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblReport_Doct);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lbInpNO);
            this.Controls.Add(this.lbPatientID);
            this.Controls.Add(this.lblCard_No);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHisCustomInfect";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "医院感染病历上报";
            this.Shown += new System.EventHandler(this.frmHisCustomInfect_Shown);
            this.Load += new System.EventHandler(this.frmHisCustomInfect_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblCard_No;
        private Label lblDept;
        private Label lblName;
        private TextBox txtClin_Diag;
        private Label lblBed_No;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private Label lblSex;
        private Label lblAge;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.ComboBox cmbInfection_Part;
        private Label label3;
        private DateTimePicker dtpInfection_Date_Time;
        private Label label4;
        private TextBox txtInfection_Symp_Lab;
        private Label label5;
        private Label lblReport_Doct;
        private Label label7;
        private DateTimePicker dtpReport_Date_Time;
        private SimpleButton spbtnSave;
        private SimpleButton spbtnPrint;
        private SimpleButton spbtnClose;
        private PictureBox pictureBox2;
        private SimpleButton spbtnQuery;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsLab;
        private ToolStrip toolStrip1;
        private ToolStripButton tbAdd;
        private ToolStripButton tbBack;
        private ToolStripButton tbNext;
        private ToolStripButton tbSave;
        private ToolStripButton tbPrint;
        private ToolStripButton tbQuery;
        private ToolStripButton tbClose;
        private Label label6;
        private System.Windows.Forms.ComboBox cmbInfection_Part_Parent;
        private Label label8;
        private System.Windows.Forms.ComboBox cmbInfection_Part_Class;
        private ToolStripStatusLabel ts2;
        private Label label9;
        private Label label10;
        private ToolStripButton tbDelete;
        public SimpleButton spbtnConfirm;
        private ToolStripButton tbHistory;
        private Label label11;
        private System.Windows.Forms.ComboBox cmbBYXSJ_FLAG;
        private Label lbPatientID;
        private Label lbInpNO;
        private ToolStripButton btnDisAdd;
    }
}