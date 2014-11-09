using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using System.ComponentModel;
using System;
using System.Drawing;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;
namespace JHEMR.EMRHisCustom
{
    partial class UCBloodApply
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPatInfo = new GroupBox();
            this.cmbRH = new System.Windows.Forms.ComboBox();
            this.cmbPAT_SOURCE = new System.Windows.Forms.ComboBox();
            this.cmbBLOOD_PURPOSE = new System.Windows.Forms.ComboBox();
            this.cmbBLOOD_HISTORY = new System.Windows.Forms.ComboBox();
            this.cmbBLOOD_INUSE = new System.Windows.Forms.ComboBox();
            this.cmbPAT_BLOOD_GROUP = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new LabelControl();
            this.labelControl3 = new LabelControl();
            this.labelControl2 = new LabelControl();
            this.labelControl1 = new LabelControl();
            this.dtpAPPLY_DATE = new DateTimePicker();
            this.dtpGATHER_DATE = new DateTimePicker();
            this.txtDOCTOR = new TextBox();
            this.txtPHYSICIAN = new TextBox();
            this.txtDIRECTOR = new TextBox();
            this.txtDEPT_CODE = new TextBox();
            this.txtBIRTHDAY = new TextBox();
            this.txtHCT = new TextBox();
            this.label31 = new Label();
            this.txtCHARGE_TYPE = new TextBox();
            this.label24 = new Label();
            this.txtPAT_SEX = new TextBox();
            this.label14 = new Label();
            this.label10 = new Label();
            this.txtElse = new TextBox();
            this.txtBlood_Gestation = new TextBox();
            this.txtPLATELET = new TextBox();
            this.txtINP_NO = new TextBox();
            this.txtBLOOD_DIAGNOSE = new TextBox();
            this.txtBLOOD_TABOO = new TextBox();
            this.label23 = new Label();
            this.txtPAT_NAME = new TextBox();
            this.label22 = new Label();
            this.label13 = new Label();
            this.label20 = new Label();
            this.label6 = new Label();
            this.label9 = new Label();
            this.txtHEMATIN = new TextBox();
            this.txtPATIENT_ID = new TextBox();
            this.label12 = new Label();
            this.label19 = new Label();
            this.label5 = new Label();
            this.label8 = new Label();
            this.label15 = new Label();
            this.label16 = new Label();
            this.txtAPPLY_NUM = new TextBox();
            this.label11 = new Label();
            this.label30 = new Label();
            this.label25 = new Label();
            this.label21 = new Label();
            this.label18 = new Label();
            this.label4 = new Label();
            this.label7 = new Label();
            this.label17 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label1 = new Label();
            this.gbApllyInfo = new GroupBox();
            this.gcBLOODCAPACITY = new GridControl();
            this.gvBLOODCAPACITY = new GridView();
            this.MATCH_SUB_NUM = new GridColumn();
            this.FAST_SLOW = new GridColumn();
            this.repositoryItemLookUpEdit2 = new RepositoryItemLookUpEdit();
            this.TRANS_DATE = new GridColumn();
            this.repositoryItemDateEdit1 = new RepositoryItemDateEdit();
            this.BLOOD_TYPE = new GridColumn();
            this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
            this.TRANS_CAPACITY = new GridColumn();
            this.UNIT = new GridColumn();
            this.repositoryItemLookUpEdit3 = new RepositoryItemLookUpEdit();
            this.APPLY_NUM = new GridColumn();
            this.repositoryItemRadioGroup1 = new RepositoryItemRadioGroup();
            this.repositoryItemComboBox1 = new RepositoryItemComboBox();
            this.sbtnDel = new SimpleButton();
            this.sbtnSave = new SimpleButton();
            this.sbtnPrint = new SimpleButton();
            this.sbtnAdd = new SimpleButton();
            this.spbtnBefore = new SimpleButton();
            this.spbtnNewApply = new SimpleButton();
            this.statusStrip1 = new StatusStrip();
            this.tssl = new ToolStripStatusLabel();
            this.sptnConfirm = new SimpleButton();
            this.gbPatInfo.SuspendLayout();
            this.gbApllyInfo.SuspendLayout();
            ((ISupportInitialize)this.gcBLOODCAPACITY).BeginInit();
            ((ISupportInitialize)this.gvBLOODCAPACITY).BeginInit();
            ((ISupportInitialize)this.repositoryItemLookUpEdit2).BeginInit();
            ((ISupportInitialize)this.repositoryItemDateEdit1).BeginInit();
            ((ISupportInitialize)this.repositoryItemDateEdit1.VistaTimeProperties).BeginInit();
            ((ISupportInitialize)this.repositoryItemLookUpEdit1).BeginInit();
            ((ISupportInitialize)this.repositoryItemLookUpEdit3).BeginInit();
            ((ISupportInitialize)this.repositoryItemRadioGroup1).BeginInit();
            ((ISupportInitialize)this.repositoryItemComboBox1).BeginInit();
            this.statusStrip1.SuspendLayout();
            base.SuspendLayout();
            this.gbPatInfo.Controls.Add(this.cmbRH);
            this.gbPatInfo.Controls.Add(this.cmbPAT_SOURCE);
            this.gbPatInfo.Controls.Add(this.cmbBLOOD_PURPOSE);
            this.gbPatInfo.Controls.Add(this.cmbBLOOD_HISTORY);
            this.gbPatInfo.Controls.Add(this.cmbBLOOD_INUSE);
            this.gbPatInfo.Controls.Add(this.cmbPAT_BLOOD_GROUP);
            this.gbPatInfo.Controls.Add(this.labelControl4);
            this.gbPatInfo.Controls.Add(this.labelControl3);
            this.gbPatInfo.Controls.Add(this.labelControl2);
            this.gbPatInfo.Controls.Add(this.labelControl1);
            this.gbPatInfo.Controls.Add(this.dtpAPPLY_DATE);
            this.gbPatInfo.Controls.Add(this.dtpGATHER_DATE);
            this.gbPatInfo.Controls.Add(this.txtDOCTOR);
            this.gbPatInfo.Controls.Add(this.txtPHYSICIAN);
            this.gbPatInfo.Controls.Add(this.txtDIRECTOR);
            this.gbPatInfo.Controls.Add(this.txtDEPT_CODE);
            this.gbPatInfo.Controls.Add(this.txtBIRTHDAY);
            this.gbPatInfo.Controls.Add(this.txtHCT);
            this.gbPatInfo.Controls.Add(this.label31);
            this.gbPatInfo.Controls.Add(this.txtCHARGE_TYPE);
            this.gbPatInfo.Controls.Add(this.label24);
            this.gbPatInfo.Controls.Add(this.txtPAT_SEX);
            this.gbPatInfo.Controls.Add(this.label14);
            this.gbPatInfo.Controls.Add(this.label10);
            this.gbPatInfo.Controls.Add(this.txtElse);
            this.gbPatInfo.Controls.Add(this.txtBlood_Gestation);
            this.gbPatInfo.Controls.Add(this.txtPLATELET);
            this.gbPatInfo.Controls.Add(this.txtINP_NO);
            this.gbPatInfo.Controls.Add(this.txtBLOOD_DIAGNOSE);
            this.gbPatInfo.Controls.Add(this.txtBLOOD_TABOO);
            this.gbPatInfo.Controls.Add(this.label23);
            this.gbPatInfo.Controls.Add(this.txtPAT_NAME);
            this.gbPatInfo.Controls.Add(this.label22);
            this.gbPatInfo.Controls.Add(this.label13);
            this.gbPatInfo.Controls.Add(this.label20);
            this.gbPatInfo.Controls.Add(this.label6);
            this.gbPatInfo.Controls.Add(this.label9);
            this.gbPatInfo.Controls.Add(this.txtHEMATIN);
            this.gbPatInfo.Controls.Add(this.txtPATIENT_ID);
            this.gbPatInfo.Controls.Add(this.label12);
            this.gbPatInfo.Controls.Add(this.label19);
            this.gbPatInfo.Controls.Add(this.label5);
            this.gbPatInfo.Controls.Add(this.label8);
            this.gbPatInfo.Controls.Add(this.label15);
            this.gbPatInfo.Controls.Add(this.label16);
            this.gbPatInfo.Controls.Add(this.txtAPPLY_NUM);
            this.gbPatInfo.Controls.Add(this.label11);
            this.gbPatInfo.Controls.Add(this.label30);
            this.gbPatInfo.Controls.Add(this.label25);
            this.gbPatInfo.Controls.Add(this.label21);
            this.gbPatInfo.Controls.Add(this.label18);
            this.gbPatInfo.Controls.Add(this.label4);
            this.gbPatInfo.Controls.Add(this.label7);
            this.gbPatInfo.Controls.Add(this.label17);
            this.gbPatInfo.Controls.Add(this.label2);
            this.gbPatInfo.Controls.Add(this.label3);
            this.gbPatInfo.Controls.Add(this.label1);
            this.gbPatInfo.Location = new Point(28, 12);
            this.gbPatInfo.Name = "gbPatInfo";
            //this.gbPatInfo.RightToLeft = RightToLeft.No;
            this.gbPatInfo.Size = new Size(673, 318);
            this.gbPatInfo.TabIndex = 0;
            this.gbPatInfo.TabStop = false;
            this.gbPatInfo.Text = "受血者信息";
            this.cmbRH.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbRH.FormattingEnabled = true;
            this.cmbRH.Items.AddRange(new object[]
			{
				"+",
				"-"
			});
            this.cmbRH.Location = new Point(152, 128);
            this.cmbRH.Name = "cmbRH";
            this.cmbRH.Size = new Size(38, 20);
            this.cmbRH.TabIndex = 6;
            this.cmbPAT_SOURCE.FormattingEnabled = true;
            this.cmbPAT_SOURCE.Items.AddRange(new object[]
			{
				"市区",
				"郊县",
				"外省市",
				"港澳台",
				"外国人"
			});
            this.cmbPAT_SOURCE.Location = new Point(508, 92);
            this.cmbPAT_SOURCE.Name = "cmbPAT_SOURCE";
            this.cmbPAT_SOURCE.Size = new Size(146, 20);
            this.cmbPAT_SOURCE.TabIndex = 6;
            this.cmbBLOOD_PURPOSE.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBLOOD_PURPOSE.FormattingEnabled = true;
            this.cmbBLOOD_PURPOSE.Items.AddRange(new object[]
			{
				"急救",
				"手术",
				"纠正贫血",
				"补充凝血因子"
			});
            this.cmbBLOOD_PURPOSE.Location = new Point(72, 254);
            this.cmbBLOOD_PURPOSE.MaxLength = 4;
            this.cmbBLOOD_PURPOSE.Name = "cmbBLOOD_PURPOSE";
            this.cmbBLOOD_PURPOSE.Size = new Size(110, 20);
            this.cmbBLOOD_PURPOSE.TabIndex = 6;
            this.cmbBLOOD_HISTORY.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBLOOD_HISTORY.FormattingEnabled = true;
            this.cmbBLOOD_HISTORY.Items.AddRange(new object[]
			{
				"有",
				"无"
			});
            this.cmbBLOOD_HISTORY.Location = new Point(357, 128);
            this.cmbBLOOD_HISTORY.Name = "cmbBLOOD_HISTORY";
            this.cmbBLOOD_HISTORY.Size = new Size(64, 20);
            this.cmbBLOOD_HISTORY.TabIndex = 6;
            this.cmbBLOOD_HISTORY.SelectedIndexChanged += new EventHandler(this.cmbBLOOD_HISTORY_SelectedIndexChanged);
            this.cmbBLOOD_INUSE.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBLOOD_INUSE.FormattingEnabled = true;
            this.cmbBLOOD_INUSE.Items.AddRange(new object[]
			{
				"血库",
				"自体",
				"互助"
			});
            this.cmbBLOOD_INUSE.Location = new Point(227, 128);
            this.cmbBLOOD_INUSE.Name = "cmbBLOOD_INUSE";
            this.cmbBLOOD_INUSE.Size = new Size(64, 20);
            this.cmbBLOOD_INUSE.TabIndex = 6;
            this.cmbPAT_BLOOD_GROUP.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbPAT_BLOOD_GROUP.FormattingEnabled = true;
            this.cmbPAT_BLOOD_GROUP.Items.AddRange(new object[]
			{
				"A",
				"B",
				"AB",
				"O",
				""
			});
            this.cmbPAT_BLOOD_GROUP.Location = new Point(46, 128);
            this.cmbPAT_BLOOD_GROUP.Name = "cmbPAT_BLOOD_GROUP";
            this.cmbPAT_BLOOD_GROUP.Size = new Size(72, 20);
            this.cmbPAT_BLOOD_GROUP.TabIndex = 6;
            this.labelControl4.Location = new Point(342, 214);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new Size(7, 14);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "9";
            this.labelControl3.Location = new Point(328, 220);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new Size(33, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "10  /L";
            this.labelControl2.Location = new Point(219, 215);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new Size(7, 14);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "9";
            this.labelControl1.Location = new Point(205, 221);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new Size(33, 14);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "10  /L";
            this.dtpAPPLY_DATE.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpAPPLY_DATE.Format = DateTimePickerFormat.Custom;
            this.dtpAPPLY_DATE.Location = new Point(508, 128);
            this.dtpAPPLY_DATE.Name = "dtpAPPLY_DATE";
            this.dtpAPPLY_DATE.Size = new Size(147, 21);
            this.dtpAPPLY_DATE.TabIndex = 2;
            this.dtpGATHER_DATE.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpGATHER_DATE.Format = DateTimePickerFormat.Custom;
            this.dtpGATHER_DATE.Location = new Point(351, 24);
            this.dtpGATHER_DATE.Name = "dtpGATHER_DATE";
            this.dtpGATHER_DATE.Size = new Size(147, 21);
            this.dtpGATHER_DATE.TabIndex = 2;
            this.dtpGATHER_DATE.Visible = false;
            this.txtDOCTOR.BackColor = Color.FromArgb(224, 224, 224);
            this.txtDOCTOR.Location = new Point(593, 215);
            this.txtDOCTOR.MaxLength = 8;
            this.txtDOCTOR.Name = "txtDOCTOR";
            this.txtDOCTOR.ReadOnly = true;
            this.txtDOCTOR.Size = new Size(65, 21);
            this.txtDOCTOR.TabIndex = 1;
            this.txtDOCTOR.TextChanged += new EventHandler(this.txtDOCTOR_TextChanged);
            this.txtPHYSICIAN.BackColor = Color.FromArgb(224, 224, 224);
            this.txtPHYSICIAN.Location = new Point(504, 215);
            this.txtPHYSICIAN.MaxLength = 8;
            this.txtPHYSICIAN.Name = "txtPHYSICIAN";
            this.txtPHYSICIAN.ReadOnly = true;
            this.txtPHYSICIAN.Size = new Size(58, 21);
            this.txtPHYSICIAN.TabIndex = 1;
            this.txtPHYSICIAN.Enter += new EventHandler(this.txtDIRECTOR_Enter);
            this.txtPHYSICIAN.Leave += new EventHandler(this.txtDIRECTOR_Leave);
            this.txtPHYSICIAN.KeyPress += new KeyPressEventHandler(this.txtDIRECTOR_KeyPress);
            this.txtPHYSICIAN.KeyDown += new KeyEventHandler(this.txtDIRECTOR_KeyDown);
            this.txtDIRECTOR.Location = new Point(414, 215);
            this.txtDIRECTOR.MaxLength = 8;
            this.txtDIRECTOR.Name = "txtDIRECTOR";
            this.txtDIRECTOR.Size = new Size(59, 21);
            this.txtDIRECTOR.TabIndex = 1;
            this.txtDIRECTOR.Enter += new EventHandler(this.txtDIRECTOR_Enter);
            this.txtDIRECTOR.Leave += new EventHandler(this.txtDIRECTOR_Leave);
            this.txtDIRECTOR.KeyPress += new KeyPressEventHandler(this.txtDIRECTOR_KeyPress);
            this.txtDIRECTOR.KeyDown += new KeyEventHandler(this.txtDIRECTOR_KeyDown);
            this.txtDEPT_CODE.BackColor = Color.FromArgb(224, 224, 224);
            this.txtDEPT_CODE.Location = new Point(508, 59);
            this.txtDEPT_CODE.Name = "txtDEPT_CODE";
            this.txtDEPT_CODE.ReadOnly = true;
            this.txtDEPT_CODE.Size = new Size(147, 21);
            this.txtDEPT_CODE.TabIndex = 1;
            this.txtBIRTHDAY.BackColor = Color.FromArgb(224, 224, 224);
            this.txtBIRTHDAY.Location = new Point(227, 92);
            this.txtBIRTHDAY.Name = "txtBIRTHDAY";
            this.txtBIRTHDAY.ReadOnly = true;
            this.txtBIRTHDAY.Size = new Size(161, 21);
            this.txtBIRTHDAY.TabIndex = 1;
            this.txtHCT.Location = new Point(285, 215);
            this.txtHCT.MaxLength = 10;
            this.txtHCT.Name = "txtHCT";
            this.txtHCT.Size = new Size(39, 21);
            this.txtHCT.TabIndex = 1;
            this.txtHCT.KeyPress += new KeyPressEventHandler(this.txtHCT_KeyPress);
            this.label31.AutoSize = true;
            this.label31.Location = new Point(13, 258);
            this.label31.Name = "label31";
            this.label31.Size = new Size(53, 12);
            this.label31.TabIndex = 0;
            this.label31.Text = "用血目的";
            this.txtCHARGE_TYPE.BackColor = Color.FromArgb(224, 224, 224);
            this.txtCHARGE_TYPE.Location = new Point(331, 59);
            this.txtCHARGE_TYPE.Name = "txtCHARGE_TYPE";
            this.txtCHARGE_TYPE.ReadOnly = true;
            this.txtCHARGE_TYPE.Size = new Size(58, 21);
            this.txtCHARGE_TYPE.TabIndex = 1;
            this.label24.AutoSize = true;
            this.label24.Location = new Point(303, 131);
            this.label24.Name = "label24";
            this.label24.Size = new Size(41, 12);
            this.label24.TabIndex = 0;
            this.label24.Text = "输血史";
            this.txtPAT_SEX.BackColor = Color.FromArgb(224, 224, 224);
            this.txtPAT_SEX.Location = new Point(155, 92);
            this.txtPAT_SEX.Name = "txtPAT_SEX";
            this.txtPAT_SEX.ReadOnly = true;
            this.txtPAT_SEX.Size = new Size(35, 21);
            this.txtPAT_SEX.TabIndex = 1;
            this.label14.AutoSize = true;
            this.label14.Location = new Point(193, 131);
            this.label14.Name = "label14";
            this.label14.Size = new Size(29, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "血源";
            this.label10.AutoSize = true;
            this.label10.Location = new Point(462, 95);
            this.label10.Name = "label10";
            this.label10.Size = new Size(29, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "属地";
            this.txtElse.Location = new Point(263, 253);
            this.txtElse.MaxLength = 40;
            this.txtElse.Name = "txtElse";
            this.txtElse.Size = new Size(392, 21);
            this.txtElse.TabIndex = 1;
            this.txtBlood_Gestation.Location = new Point(246, 158);
            this.txtBlood_Gestation.MaxLength = 80;
            this.txtBlood_Gestation.Multiline = true;
            this.txtBlood_Gestation.Name = "txtBlood_Gestation";
            this.txtBlood_Gestation.Size = new Size(152, 51);
            this.txtBlood_Gestation.TabIndex = 1;
            this.txtPLATELET.Location = new Point(170, 216);
            this.txtPLATELET.MaxLength = 10;
            this.txtPLATELET.Name = "txtPLATELET";
            this.txtPLATELET.Size = new Size(31, 21);
            this.txtPLATELET.TabIndex = 1;
            this.txtPLATELET.KeyPress += new KeyPressEventHandler(this.txtPLATELET_KeyPress);
            this.txtINP_NO.BackColor = Color.FromArgb(224, 224, 224);
            this.txtINP_NO.Location = new Point(204, 59);
            this.txtINP_NO.Name = "txtINP_NO";
            this.txtINP_NO.ReadOnly = true;
            this.txtINP_NO.Size = new Size(76, 21);
            this.txtINP_NO.TabIndex = 1;
            this.txtBLOOD_DIAGNOSE.Location = new Point(46, 158);
            this.txtBLOOD_DIAGNOSE.MaxLength = 40;
            this.txtBLOOD_DIAGNOSE.Multiline = true;
            this.txtBLOOD_DIAGNOSE.Name = "txtBLOOD_DIAGNOSE";
            this.txtBLOOD_DIAGNOSE.Size = new Size(143, 44);
            this.txtBLOOD_DIAGNOSE.TabIndex = 1;
            this.txtBLOOD_TABOO.Location = new Point(508, 158);
            this.txtBLOOD_TABOO.MaxLength = 40;
            this.txtBLOOD_TABOO.Multiline = true;
            this.txtBLOOD_TABOO.Name = "txtBLOOD_TABOO";
            this.txtBLOOD_TABOO.Size = new Size(147, 46);
            this.txtBLOOD_TABOO.TabIndex = 1;
            this.label23.AutoSize = true;
            this.label23.Location = new Point(565, 219);
            this.label23.Name = "label23";
            this.label23.Size = new Size(29, 12);
            this.label23.TabIndex = 0;
            this.label23.Text = "医师";
            this.txtPAT_NAME.BackColor = Color.FromArgb(224, 224, 224);
            this.txtPAT_NAME.Location = new Point(46, 92);
            this.txtPAT_NAME.Name = "txtPAT_NAME";
            this.txtPAT_NAME.ReadOnly = true;
            this.txtPAT_NAME.Size = new Size(75, 21);
            this.txtPAT_NAME.TabIndex = 1;
            this.label22.AutoSize = true;
            this.label22.Location = new Point(476, 219);
            this.label22.Name = "label22";
            this.label22.Size = new Size(29, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "主治\r\n";
            this.label13.AutoSize = true;
            this.label13.Location = new Point(449, 131);
            this.label13.Name = "label13";
            this.label13.Size = new Size(53, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "申请时间";
            this.label20.AutoSize = true;
            this.label20.Location = new Point(379, 220);
            this.label20.Name = "label20";
            this.label20.Size = new Size(29, 12);
            this.label20.TabIndex = 0;
            this.label20.Text = "主任\r\n";
            this.label6.AutoSize = true;
            this.label6.Location = new Point(447, 62);
            this.label6.Name = "label6";
            this.label6.Size = new Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "申请科室\r\n";
            this.label9.AutoSize = true;
            this.label9.Location = new Point(194, 95);
            this.label9.Name = "label9";
            this.label9.Size = new Size(29, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "出生";
            this.txtHEMATIN.Location = new Point(64, 217);
            this.txtHEMATIN.MaxLength = 10;
            this.txtHEMATIN.Name = "txtHEMATIN";
            this.txtHEMATIN.Size = new Size(35, 21);
            this.txtHEMATIN.TabIndex = 1;
            this.txtHEMATIN.KeyPress += new KeyPressEventHandler(this.txtHEMATIN_KeyPress);
            this.txtPATIENT_ID.BackColor = Color.FromArgb(224, 224, 224);
            this.txtPATIENT_ID.Location = new Point(46, 59);
            this.txtPATIENT_ID.Name = "txtPATIENT_ID";
            this.txtPATIENT_ID.ReadOnly = true;
            this.txtPATIENT_ID.Size = new Size(100, 21);
            this.txtPATIENT_ID.TabIndex = 1;
            this.label12.AutoSize = true;
            this.label12.Location = new Point(124, 131);
            this.label12.Name = "label12";
            this.label12.Size = new Size(17, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "RH";
            this.label19.AutoSize = true;
            this.label19.Location = new Point(244, 222);
            this.label19.Name = "label19";
            this.label19.Size = new Size(41, 12);
            this.label19.TabIndex = 0;
            this.label19.Text = "白细胞";
            this.label5.AutoSize = true;
            this.label5.Location = new Point(295, 62);
            this.label5.Name = "label5";
            this.label5.Size = new Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "费别";
            this.label8.AutoSize = true;
            this.label8.Location = new Point(124, 95);
            this.label8.Name = "label8";
            this.label8.Size = new Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "性别";
            this.label15.AutoSize = true;
            this.label15.Location = new Point(12, 161);
            this.label15.Name = "label15";
            this.label15.Size = new Size(29, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "诊断";
            this.label16.AutoSize = true;
            this.label16.Location = new Point(404, 161);
            this.label16.Name = "label16";
            this.label16.Size = new Size(101, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "输血反应及禁忌症";
            this.txtAPPLY_NUM.BackColor = Color.FromArgb(224, 224, 224);
            this.txtAPPLY_NUM.ForeColor = Color.Red;
            this.txtAPPLY_NUM.Location = new Point(100, 26);
            this.txtAPPLY_NUM.Name = "txtAPPLY_NUM";
            this.txtAPPLY_NUM.ReadOnly = true;
            this.txtAPPLY_NUM.Size = new Size(100, 21);
            this.txtAPPLY_NUM.TabIndex = 1;
            this.label11.AutoSize = true;
            this.label11.Location = new Point(12, 131);
            this.label11.Name = "label11";
            this.label11.Size = new Size(29, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "血型";
            this.label30.AutoSize = true;
            this.label30.Location = new Point(202, 256);
            this.label30.Name = "label30";
            this.label30.Size = new Size(53, 12);
            this.label30.TabIndex = 0;
            this.label30.Text = "其它指标";
            this.label25.AutoSize = true;
            this.label25.Location = new Point(199, 161);
            this.label25.Name = "label25";
            this.label25.Size = new Size(41, 12);
            this.label25.TabIndex = 0;
            this.label25.Text = "妊娠史";
            this.label21.AutoSize = true;
            this.label21.Location = new Point(101, 220);
            this.label21.Name = "label21";
            this.label21.Size = new Size(23, 12);
            this.label21.TabIndex = 0;
            this.label21.Text = "g/L";
            this.label18.AutoSize = true;
            this.label18.Location = new Point(127, 221);
            this.label18.Name = "label18";
            this.label18.Size = new Size(41, 12);
            this.label18.TabIndex = 0;
            this.label18.Text = "血小板";
            this.label4.AutoSize = true;
            this.label4.Location = new Point(159, 62);
            this.label4.Name = "label4";
            this.label4.Size = new Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "住院号";
            this.label7.AutoSize = true;
            this.label7.Location = new Point(12, 95);
            this.label7.Name = "label7";
            this.label7.Size = new Size(29, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "姓名";
            this.label17.AutoSize = true;
            this.label17.Location = new Point(11, 220);
            this.label17.Name = "label17";
            this.label17.Size = new Size(53, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "血红蛋白";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(261, 28);
            this.label2.Name = "label2";
            this.label2.Size = new Size(83, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "计划输血日期:";
            this.label2.Visible = false;
            this.label3.AutoSize = true;
            this.label3.Location = new Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID号";
            this.label1.AutoSize = true;
            this.label1.Location = new Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用血申请单号:";
            this.gbApllyInfo.Controls.Add(this.gcBLOODCAPACITY);
            this.gbApllyInfo.Location = new Point(31, 350);
            this.gbApllyInfo.Name = "gbApllyInfo";
            this.gbApllyInfo.Size = new Size(559, 178);
            this.gbApllyInfo.TabIndex = 0;
            this.gbApllyInfo.TabStop = false;
            this.gbApllyInfo.Text = "申请血液信息";
            this.gcBLOODCAPACITY.EmbeddedNavigator.Name = "";
            this.gcBLOODCAPACITY.Location = new Point(3, 17);
            this.gcBLOODCAPACITY.MainView = this.gvBLOODCAPACITY;
            this.gcBLOODCAPACITY.Name = "gcBLOODCAPACITY";
            this.gcBLOODCAPACITY.RepositoryItems.AddRange(new RepositoryItem[]
			{
				this.repositoryItemRadioGroup1,
				this.repositoryItemComboBox1,
				this.repositoryItemDateEdit1,
				this.repositoryItemLookUpEdit1,
				this.repositoryItemLookUpEdit2,
				this.repositoryItemLookUpEdit3
			});
            this.gcBLOODCAPACITY.Size = new Size(553, 158);
            this.gcBLOODCAPACITY.TabIndex = 0;
            this.gcBLOODCAPACITY.ViewCollection.AddRange(new BaseView[]
			{
				this.gvBLOODCAPACITY
			});
            this.gvBLOODCAPACITY.Columns.AddRange(new GridColumn[]
			{
				this.MATCH_SUB_NUM,
				this.FAST_SLOW,
				this.TRANS_DATE,
				this.BLOOD_TYPE,
				this.TRANS_CAPACITY,
				this.UNIT,
				this.APPLY_NUM
			});
            this.gvBLOODCAPACITY.GridControl = this.gcBLOODCAPACITY;
            this.gvBLOODCAPACITY.Name = "gvBLOODCAPACITY";
            this.gvBLOODCAPACITY.OptionsView.ColumnAutoWidth = false;
            this.gvBLOODCAPACITY.OptionsView.ShowGroupPanel = false;
            this.gvBLOODCAPACITY.CellValueChanged += new CellValueChangedEventHandler(this.gvBLOODCAPACITY_CellValueChanged);
            this.MATCH_SUB_NUM.Caption = "序号";
            this.MATCH_SUB_NUM.FieldName = "NUM";
            this.MATCH_SUB_NUM.Name = "MATCH_SUB_NUM";
            this.MATCH_SUB_NUM.Width = 52;
            this.FAST_SLOW.Caption = "用血方式";
            this.FAST_SLOW.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.FAST_SLOW.FieldName = "FAST_SLOW";
            this.FAST_SLOW.Name = "FAST_SLOW";
            this.FAST_SLOW.Visible = true;
            this.FAST_SLOW.VisibleIndex = 0;
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton(ButtonPredefines.Combo)
			});
            this.repositoryItemLookUpEdit2.DisplayMember = "名称";
            this.repositoryItemLookUpEdit2.DropDownRows = 5;
            this.repositoryItemLookUpEdit2.MaxLength = 12;
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.ShowDropDown = ShowDropDown.Never;
            this.repositoryItemLookUpEdit2.ValueMember = "代码";
            this.TRANS_DATE.Caption = "申请用血时间";
            this.TRANS_DATE.ColumnEdit = this.repositoryItemDateEdit1;
            this.TRANS_DATE.FieldName = "TRANS_DATE";
            this.TRANS_DATE.Name = "TRANS_DATE";
            this.TRANS_DATE.Visible = true;
            this.TRANS_DATE.VisibleIndex = 1;
            this.TRANS_DATE.Width = 130;
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton(ButtonPredefines.Combo)
			});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "g";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "g";
            this.repositoryItemDateEdit1.EditFormat.FormatType = FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "g";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton()
			});
            this.BLOOD_TYPE.Caption = "血液要求";
            this.BLOOD_TYPE.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.BLOOD_TYPE.FieldName = "BLOOD_TYPE";
            this.BLOOD_TYPE.Name = "BLOOD_TYPE";
            this.BLOOD_TYPE.Visible = true;
            this.BLOOD_TYPE.VisibleIndex = 2;
            this.BLOOD_TYPE.Width = 103;
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton(ButtonPredefines.Combo)
			});
            this.repositoryItemLookUpEdit1.DisplayMember = "名称";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ShowDropDown = ShowDropDown.Never;
            this.repositoryItemLookUpEdit1.ValueMember = "代码";
            this.TRANS_CAPACITY.Caption = "血量";
            this.TRANS_CAPACITY.FieldName = "TRANS_CAPACITY";
            this.TRANS_CAPACITY.Name = "TRANS_CAPACITY";
            this.TRANS_CAPACITY.Visible = true;
            this.TRANS_CAPACITY.VisibleIndex = 3;
            this.TRANS_CAPACITY.Width = 78;
            this.UNIT.Caption = "单位";
            this.UNIT.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.UNIT.FieldName = "UNIT";
            this.UNIT.Name = "UNIT";
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton(ButtonPredefines.Combo)
			});
            this.repositoryItemLookUpEdit3.DisplayMember = "单位";
            this.repositoryItemLookUpEdit3.DropDownRows = 5;
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.NullText = "";
            this.repositoryItemLookUpEdit3.PopupWidth = 100;
            this.repositoryItemLookUpEdit3.ShowDropDown = ShowDropDown.Never;
            this.repositoryItemLookUpEdit3.ValueMember = "单位";
            this.APPLY_NUM.Caption = "申请单号";
            this.APPLY_NUM.FieldName = "APPLY_NUM";
            this.APPLY_NUM.Name = "APPLY_NUM";
            this.repositoryItemRadioGroup1.Items.AddRange(new RadioGroupItem[]
			{
				new RadioGroupItem(null, "紧急"),
				new RadioGroupItem(null, "计划"),
				new RadioGroupItem(null, "备血")
			});
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton(ButtonPredefines.Combo)
			});
            this.repositoryItemComboBox1.Items.AddRange(new object[]
			{
				"急诊",
				"计划",
				"备血"
			});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.sbtnDel.Location = new Point(614, 399);
            this.sbtnDel.Name = "sbtnDel";
            this.sbtnDel.Size = new Size(75, 23);
            this.sbtnDel.TabIndex = 1;
            this.sbtnDel.Text = "删除(&D)";
            this.sbtnDel.Click += new EventHandler(this.sbtnDel_Click);
            this.sbtnSave.Location = new Point(528, 543);
            this.sbtnSave.Name = "sbtnSave";
            this.sbtnSave.Size = new Size(75, 23);
            this.sbtnSave.TabIndex = 1;
            this.sbtnSave.Text = "保存(&S)";
            this.sbtnSave.Click += new EventHandler(this.sbtnSave_Click);
            this.sbtnPrint.Enabled = false;
            this.sbtnPrint.Location = new Point(621, 543);
            this.sbtnPrint.Name = "sbtnPrint";
            this.sbtnPrint.Size = new Size(75, 23);
            this.sbtnPrint.TabIndex = 1;
            this.sbtnPrint.Text = "打印(&P)";
            this.sbtnPrint.Visible = false;
            this.sbtnPrint.Click += new EventHandler(this.sbtnPrint_Click);
            this.sbtnAdd.Location = new Point(614, 360);
            this.sbtnAdd.Name = "sbtnAdd";
            this.sbtnAdd.Size = new Size(75, 23);
            this.sbtnAdd.TabIndex = 1;
            this.sbtnAdd.Text = "新增(&N)";
            this.sbtnAdd.Click += new EventHandler(this.sbtnAdd_Click);
            this.spbtnBefore.Location = new Point(388, 543);
            this.spbtnBefore.Name = "spbtnBefore";
            this.spbtnBefore.Size = new Size(131, 23);
            this.spbtnBefore.TabIndex = 1;
            this.spbtnBefore.Text = "既往申请查看(&L)";
            this.spbtnBefore.Click += new EventHandler(this.spbtnBefore_Click);
            this.spbtnNewApply.Location = new Point(258, 543);
            this.spbtnNewApply.Name = "spbtnNewApply";
            this.spbtnNewApply.Size = new Size(113, 23);
            this.spbtnNewApply.TabIndex = 1;
            this.spbtnNewApply.Text = "新建输血申请(&N)";
            this.spbtnNewApply.Click += new EventHandler(this.spbtnNewApply_Click);
            this.statusStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.tssl
			});
            this.statusStrip1.Location = new Point(0, 585);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new Size(728, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.tssl.ForeColor = Color.Red;
            this.tssl.Name = "tssl";
            this.tssl.Size = new Size(35, 17);
            this.tssl.Text = "提示:";
            this.sptnConfirm.Enabled = false;
            this.sptnConfirm.Location = new Point(144, 543);
            this.sptnConfirm.Name = "sptnConfirm";
            this.sptnConfirm.Size = new Size(100, 23);
            this.sptnConfirm.TabIndex = 1;
            this.sptnConfirm.Text = "主治审批(&A)";
            this.sptnConfirm.Click += new EventHandler(this.sptnConfirm_Click);
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            //base.AutoScaleMode = AutoScaleMode.Font;
            base.Controls.Add(this.gbPatInfo);
            base.Controls.Add(this.statusStrip1);
            base.Controls.Add(this.sbtnPrint);
            base.Controls.Add(this.sptnConfirm);
            base.Controls.Add(this.spbtnNewApply);
            base.Controls.Add(this.spbtnBefore);
            base.Controls.Add(this.sbtnSave);
            base.Controls.Add(this.sbtnAdd);
            base.Controls.Add(this.sbtnDel);
            base.Controls.Add(this.gbApllyInfo);
            base.Name = "UCBloodApply";
            base.Size = new Size(728, 607);
            base.Load += new EventHandler(this.UCBloodApply_Load);
            this.gbPatInfo.ResumeLayout(false);
            this.gbPatInfo.PerformLayout();
            this.gbApllyInfo.ResumeLayout(false);
            ((ISupportInitialize)this.gcBLOODCAPACITY).EndInit();
            ((ISupportInitialize)this.gvBLOODCAPACITY).EndInit();
            ((ISupportInitialize)this.repositoryItemLookUpEdit2).EndInit();
            ((ISupportInitialize)this.repositoryItemDateEdit1.VistaTimeProperties).EndInit();
            ((ISupportInitialize)this.repositoryItemDateEdit1).EndInit();
            ((ISupportInitialize)this.repositoryItemLookUpEdit1).EndInit();
            ((ISupportInitialize)this.repositoryItemLookUpEdit3).EndInit();
            ((ISupportInitialize)this.repositoryItemRadioGroup1).EndInit();
            ((ISupportInitialize)this.repositoryItemComboBox1).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion

        private GroupBox gbPatInfo;
        private GroupBox gbApllyInfo;
        private SimpleButton sbtnDel;
        private SimpleButton sbtnSave;
        private SimpleButton sbtnPrint;
        private SimpleButton sbtnAdd;
        private Label label1;
        private DateTimePicker dtpGATHER_DATE;
        private Label label2;
        private TextBox txtPATIENT_ID;
        private Label label3;
        private TextBox txtDEPT_CODE;
        private TextBox txtCHARGE_TYPE;
        private TextBox txtINP_NO;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtBIRTHDAY;
        private TextBox txtPAT_SEX;
        private Label label10;
        private TextBox txtPAT_NAME;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private DateTimePicker dtpAPPLY_DATE;
        private TextBox txtBLOOD_DIAGNOSE;
        private TextBox txtBLOOD_TABOO;
        private Label label15;
        private Label label16;
        private TextBox txtDIRECTOR;
        private TextBox txtPLATELET;
        private Label label20;
        private TextBox txtHEMATIN;
        private Label label19;
        private Label label21;
        private Label label18;
        private Label label17;
        private LabelControl labelControl4;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private TextBox txtHCT;
        private TextBox txtDOCTOR;
        private TextBox txtPHYSICIAN;
        private Label label23;
        private Label label22;
        private System.Windows.Forms.ComboBox cmbRH;
        private System.Windows.Forms.ComboBox cmbPAT_BLOOD_GROUP;
        private GridControl gcBLOODCAPACITY;
        private GridView gvBLOODCAPACITY;
        private GridColumn MATCH_SUB_NUM;
        private GridColumn FAST_SLOW;
        private GridColumn TRANS_DATE;
        private GridColumn TRANS_CAPACITY;
        private GridColumn BLOOD_TYPE;
        private RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private System.Windows.Forms.ComboBox cmbPAT_SOURCE;
        private System.Windows.Forms.ComboBox cmbBLOOD_INUSE;
        private GridColumn APPLY_NUM;
        private GridColumn UNIT;
        private RepositoryItemComboBox repositoryItemComboBox1;
        private RepositoryItemDateEdit repositoryItemDateEdit1;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private SimpleButton spbtnBefore;
        private System.Windows.Forms.ComboBox cmbBLOOD_HISTORY;
        private Label label24;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private SimpleButton spbtnNewApply;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tssl;
        private SimpleButton sptnConfirm;
        private System.Windows.Forms.ComboBox cmbBLOOD_PURPOSE;
        private Label label31;
        private TextBox txtElse;
        private Label label30;
        private TextBox txtBlood_Gestation;
        private Label label25;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        public TextBox txtAPPLY_NUM;
    }
}
