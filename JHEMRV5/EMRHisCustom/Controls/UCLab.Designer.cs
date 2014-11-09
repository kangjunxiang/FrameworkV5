using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using System.Drawing;
using DevExpress.Utils;
namespace JHEMR.EMRHisCustom
{
    partial class UCLab
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.lblBedNo = new System.Windows.Forms.Label();
            this.txtDoctorCharge = new System.Windows.Forms.TextBox();
            this.txtBed = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoctorApply = new System.Windows.Forms.TextBox();
            this.lblDoct = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.gcLabList = new DevExpress.XtraGrid.GridControl();
            this.gvLabList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cpbtnAll = new DevExpress.XtraEditors.SimpleButton();
            this.cpbtnNo = new DevExpress.XtraEditors.SimpleButton();
            this.cpbtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.chkCpBusy = new System.Windows.Forms.CheckBox();
            this.CPcmbSpecimen = new System.Windows.Forms.ComboBox();
            this.txtCPSpecimenMemo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCPSex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPDoctor = new System.Windows.Forms.TextBox();
            this.txtCPBedNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCPApplyDoctor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCPPatId = new System.Windows.Forms.TextBox();
            this.txtCPName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkBusy = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnAll = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnNo = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmbSpecimen = new System.Windows.Forms.ComboBox();
            this.txtSpecimenMemo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.trv1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.trv2 = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.trv3 = new System.Windows.Forms.TreeView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.trv4 = new System.Windows.Forms.TreeView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.trv5 = new System.Windows.Forms.TreeView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.trv6 = new System.Windows.Forms.TreeView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.trv7 = new System.Windows.Forms.TreeView();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.trv8 = new System.Windows.Forms.TreeView();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.trv9 = new System.Windows.Forms.TreeView();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.trv10 = new System.Windows.Forms.TreeView();
            this.txtMemo = new System.Windows.Forms.RichTextBox();
            this.gcDetail = new DevExpress.XtraGrid.GridControl();
            this.gvDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ITEM_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LAB_ITEM_NAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITEM_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CLINIC_MEMO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rItemBtnEditSheetDetailClinicMemo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcItems = new DevExpress.XtraGrid.GridControl();
            this.gvItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CHOOSE_FLAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.LAB_ITEM_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LAB_ITEM_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LAB_SPECIMEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LAB_ITEM_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CLINIC_MEMO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rItemBtnEditClinicMemo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLabList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLabList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rItemBtnEditSheetDetailClinicMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rItemBtnEditClinicMemo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtSex);
            this.groupBox1.Controls.Add(this.lblBedNo);
            this.groupBox1.Controls.Add(this.txtDoctorCharge);
            this.groupBox1.Controls.Add(this.txtBed);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDoctorApply);
            this.groupBox1.Controls.Add(this.lblDoct);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.txtPatientId);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblSex);
            this.groupBox1.Location = new System.Drawing.Point(3, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "病人信息";
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSex.ForeColor = System.Drawing.Color.Blue;
            this.txtSex.Location = new System.Drawing.Point(394, 18);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(31, 21);
            this.txtSex.TabIndex = 105;
            // 
            // lblBedNo
            // 
            this.lblBedNo.AutoSize = true;
            this.lblBedNo.ForeColor = System.Drawing.Color.Blue;
            this.lblBedNo.Location = new System.Drawing.Point(20, 22);
            this.lblBedNo.Name = "lblBedNo";
            this.lblBedNo.Size = new System.Drawing.Size(41, 12);
            this.lblBedNo.TabIndex = 101;
            this.lblBedNo.Text = "床号：";
            // 
            // txtDoctorCharge
            // 
            this.txtDoctorCharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtDoctorCharge.ForeColor = System.Drawing.Color.Blue;
            this.txtDoctorCharge.Location = new System.Drawing.Point(507, 18);
            this.txtDoctorCharge.Name = "txtDoctorCharge";
            this.txtDoctorCharge.ReadOnly = true;
            this.txtDoctorCharge.Size = new System.Drawing.Size(68, 21);
            this.txtDoctorCharge.TabIndex = 105;
            // 
            // txtBed
            // 
            this.txtBed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtBed.ForeColor = System.Drawing.Color.Blue;
            this.txtBed.Location = new System.Drawing.Point(61, 18);
            this.txtBed.Name = "txtBed";
            this.txtBed.ReadOnly = true;
            this.txtBed.Size = new System.Drawing.Size(45, 21);
            this.txtBed.TabIndex = 105;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Blue;
            this.lblName.Location = new System.Drawing.Point(236, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 100;
            this.lblName.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(596, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 103;
            this.label1.Text = "申请医生：";
            // 
            // txtDoctorApply
            // 
            this.txtDoctorApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtDoctorApply.ForeColor = System.Drawing.Color.Blue;
            this.txtDoctorApply.Location = new System.Drawing.Point(661, 18);
            this.txtDoctorApply.Name = "txtDoctorApply";
            this.txtDoctorApply.ReadOnly = true;
            this.txtDoctorApply.Size = new System.Drawing.Size(68, 21);
            this.txtDoctorApply.TabIndex = 105;
            // 
            // lblDoct
            // 
            this.lblDoct.AutoSize = true;
            this.lblDoct.ForeColor = System.Drawing.Color.Blue;
            this.lblDoct.Location = new System.Drawing.Point(442, 22);
            this.lblDoct.Name = "lblDoct";
            this.lblDoct.Size = new System.Drawing.Size(65, 12);
            this.lblDoct.TabIndex = 103;
            this.lblDoct.Text = "主管医生：";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.Blue;
            this.lblID.Location = new System.Drawing.Point(107, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(53, 12);
            this.lblID.TabIndex = 102;
            this.lblID.Text = "病人ID：";
            // 
            // txtPatientId
            // 
            this.txtPatientId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPatientId.ForeColor = System.Drawing.Color.Blue;
            this.txtPatientId.Location = new System.Drawing.Point(161, 18);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.ReadOnly = true;
            this.txtPatientId.Size = new System.Drawing.Size(68, 21);
            this.txtPatientId.TabIndex = 105;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtName.ForeColor = System.Drawing.Color.Blue;
            this.txtName.Location = new System.Drawing.Point(283, 19);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(68, 21);
            this.txtName.TabIndex = 105;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.ForeColor = System.Drawing.Color.Blue;
            this.lblSex.Location = new System.Drawing.Point(358, 22);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 12);
            this.lblSex.TabIndex = 104;
            this.lblSex.Text = "性别：";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButtonCancel);
            this.panelControl1.Controls.Add(this.gcLabList);
            this.panelControl1.Controls.Add(this.cpbtnAll);
            this.panelControl1.Controls.Add(this.cpbtnNo);
            this.panelControl1.Controls.Add(this.cpbtnSave);
            this.panelControl1.Controls.Add(this.chkCpBusy);
            this.panelControl1.Controls.Add(this.CPcmbSpecimen);
            this.panelControl1.Controls.Add(this.txtCPSpecimenMemo);
            this.panelControl1.Controls.Add(this.label10);
            this.panelControl1.Controls.Add(this.label11);
            this.panelControl1.Controls.Add(this.txtCPSex);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtCPDoctor);
            this.panelControl1.Controls.Add(this.txtCPBedNo);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.txtCPApplyDoctor);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.label8);
            this.panelControl1.Controls.Add(this.txtCPPatId);
            this.panelControl1.Controls.Add(this.txtCPName);
            this.panelControl1.Controls.Add(this.label9);
            this.panelControl1.Location = new System.Drawing.Point(19, 28);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(827, 159);
            this.panelControl1.TabIndex = 106;
            this.panelControl1.Visible = false;
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Location = new System.Drawing.Point(680, 47);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(142, 23);
            this.simpleButtonCancel.TabIndex = 127;
            this.simpleButtonCancel.Text = "取消(转到申请界面)(&C)";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // gcLabList
            // 
            this.gcLabList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcLabList.EmbeddedNavigator.Name = "";
            this.gcLabList.Location = new System.Drawing.Point(1, 76);
            this.gcLabList.MainView = this.gvLabList;
            this.gcLabList.Name = "gcLabList";
            this.gcLabList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2,
            this.repositoryItemButtonEdit1});
            this.gcLabList.Size = new System.Drawing.Size(822, 83);
            this.gcLabList.TabIndex = 126;
            this.gcLabList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLabList});
            // 
            // gvLabList
            // 
            this.gvLabList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gvLabList.GridControl = this.gcLabList;
            this.gvLabList.Name = "gvLabList";
            this.gvLabList.OptionsSelection.MultiSelect = true;
            this.gvLabList.OptionsView.ColumnAutoWidth = false;
            this.gvLabList.OptionsView.ShowGroupPanel = false;
            this.gvLabList.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gvLabList_ShowingEditor);
            this.gvLabList.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvLabList_CustomDrawCell);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "  ";
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEdit2;
            this.gridColumn1.FieldName = "CHOOSE_FLAG";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 31;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit2.ValueChecked = 1;
            this.repositoryItemCheckEdit2.ValueUnchecked = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "序号";
            this.gridColumn2.FieldName = "LAB_ITEM_NO";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 47;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "项目名称";
            this.gridColumn3.FieldName = "LAB_ITEM_NAME";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 153;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "样本";
            this.gridColumn4.FieldName = "LAB_SPECIMEN";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "项目编码";
            this.gridColumn5.FieldName = "LAB_ITEM_CODE";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn6.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn6.Caption = "临床意义";
            this.gridColumn6.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn6.FieldName = "CLINIC_MEMO";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridColumn6.Tag = "LAB_ITEM_CODE";
            this.gridColumn6.Width = 72;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "已选";
            this.gridColumn7.FieldName = "STATUS";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // cpbtnAll
            // 
            this.cpbtnAll.Location = new System.Drawing.Point(599, 47);
            this.cpbtnAll.Name = "cpbtnAll";
            this.cpbtnAll.Size = new System.Drawing.Size(75, 23);
            this.cpbtnAll.TabIndex = 125;
            this.cpbtnAll.Text = "全选";
            this.cpbtnAll.Click += new System.EventHandler(this.cpbtnAll_Click);
            // 
            // cpbtnNo
            // 
            this.cpbtnNo.Location = new System.Drawing.Point(518, 47);
            this.cpbtnNo.Name = "cpbtnNo";
            this.cpbtnNo.Size = new System.Drawing.Size(75, 23);
            this.cpbtnNo.TabIndex = 124;
            this.cpbtnNo.Text = "不选";
            this.cpbtnNo.Click += new System.EventHandler(this.cpbtnNo_Click);
            // 
            // cpbtnSave
            // 
            this.cpbtnSave.Location = new System.Drawing.Point(437, 47);
            this.cpbtnSave.Name = "cpbtnSave";
            this.cpbtnSave.Size = new System.Drawing.Size(75, 23);
            this.cpbtnSave.TabIndex = 123;
            this.cpbtnSave.Text = "保存";
            this.cpbtnSave.Click += new System.EventHandler(this.cpbtnSave_Click);
            // 
            // chkCpBusy
            // 
            this.chkCpBusy.AutoSize = true;
            this.chkCpBusy.Location = new System.Drawing.Point(361, 51);
            this.chkCpBusy.Name = "chkCpBusy";
            this.chkCpBusy.Size = new System.Drawing.Size(72, 16);
            this.chkCpBusy.TabIndex = 121;
            this.chkCpBusy.Text = "紧急样本";
            this.chkCpBusy.UseVisualStyleBackColor = true;
            // 
            // CPcmbSpecimen
            // 
            this.CPcmbSpecimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CPcmbSpecimen.FormattingEnabled = true;
            this.CPcmbSpecimen.Location = new System.Drawing.Point(61, 49);
            this.CPcmbSpecimen.Name = "CPcmbSpecimen";
            this.CPcmbSpecimen.Size = new System.Drawing.Size(121, 20);
            this.CPcmbSpecimen.TabIndex = 122;
            // 
            // txtCPSpecimenMemo
            // 
            this.txtCPSpecimenMemo.BackColor = System.Drawing.Color.White;
            this.txtCPSpecimenMemo.ForeColor = System.Drawing.Color.Blue;
            this.txtCPSpecimenMemo.Location = new System.Drawing.Point(252, 49);
            this.txtCPSpecimenMemo.MaxLength = 16;
            this.txtCPSpecimenMemo.Name = "txtCPSpecimenMemo";
            this.txtCPSpecimenMemo.Size = new System.Drawing.Size(90, 21);
            this.txtCPSpecimenMemo.TabIndex = 120;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(191, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 119;
            this.label10.Text = "样本说明：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(20, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 118;
            this.label11.Text = "样本：";
            // 
            // txtCPSex
            // 
            this.txtCPSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCPSex.ForeColor = System.Drawing.Color.Blue;
            this.txtCPSex.Location = new System.Drawing.Point(394, 15);
            this.txtCPSex.Name = "txtCPSex";
            this.txtCPSex.ReadOnly = true;
            this.txtCPSex.Size = new System.Drawing.Size(31, 21);
            this.txtCPSex.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 107;
            this.label2.Text = "床号：";
            // 
            // txtCPDoctor
            // 
            this.txtCPDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCPDoctor.ForeColor = System.Drawing.Color.Blue;
            this.txtCPDoctor.Location = new System.Drawing.Point(507, 15);
            this.txtCPDoctor.Name = "txtCPDoctor";
            this.txtCPDoctor.ReadOnly = true;
            this.txtCPDoctor.Size = new System.Drawing.Size(68, 21);
            this.txtCPDoctor.TabIndex = 117;
            // 
            // txtCPBedNo
            // 
            this.txtCPBedNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCPBedNo.ForeColor = System.Drawing.Color.Blue;
            this.txtCPBedNo.Location = new System.Drawing.Point(61, 15);
            this.txtCPBedNo.Name = "txtCPBedNo";
            this.txtCPBedNo.ReadOnly = true;
            this.txtCPBedNo.Size = new System.Drawing.Size(45, 21);
            this.txtCPBedNo.TabIndex = 116;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(236, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 106;
            this.label4.Text = "姓名：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(596, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 109;
            this.label6.Text = "申请医生：";
            // 
            // txtCPApplyDoctor
            // 
            this.txtCPApplyDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCPApplyDoctor.ForeColor = System.Drawing.Color.Blue;
            this.txtCPApplyDoctor.Location = new System.Drawing.Point(661, 15);
            this.txtCPApplyDoctor.Name = "txtCPApplyDoctor";
            this.txtCPApplyDoctor.ReadOnly = true;
            this.txtCPApplyDoctor.Size = new System.Drawing.Size(68, 21);
            this.txtCPApplyDoctor.TabIndex = 115;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(442, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 110;
            this.label7.Text = "主管医生：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(107, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 108;
            this.label8.Text = "病人ID：";
            // 
            // txtCPPatId
            // 
            this.txtCPPatId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCPPatId.ForeColor = System.Drawing.Color.Blue;
            this.txtCPPatId.Location = new System.Drawing.Point(161, 15);
            this.txtCPPatId.Name = "txtCPPatId";
            this.txtCPPatId.ReadOnly = true;
            this.txtCPPatId.Size = new System.Drawing.Size(68, 21);
            this.txtCPPatId.TabIndex = 112;
            // 
            // txtCPName
            // 
            this.txtCPName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCPName.ForeColor = System.Drawing.Color.Blue;
            this.txtCPName.Location = new System.Drawing.Point(283, 16);
            this.txtCPName.Name = "txtCPName";
            this.txtCPName.ReadOnly = true;
            this.txtCPName.Size = new System.Drawing.Size(68, 21);
            this.txtCPName.TabIndex = 113;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(358, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 111;
            this.label9.Text = "性别：";
            // 
            // chkBusy
            // 
            this.chkBusy.AutoSize = true;
            this.chkBusy.Location = new System.Drawing.Point(360, 23);
            this.chkBusy.Name = "chkBusy";
            this.chkBusy.Size = new System.Drawing.Size(72, 16);
            this.chkBusy.TabIndex = 106;
            this.chkBusy.Text = "紧急样本";
            this.chkBusy.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Controls.Add(this.spbtnAll);
            this.groupBox2.Controls.Add(this.spbtnNo);
            this.groupBox2.Controls.Add(this.spbtnSave);
            this.groupBox2.Controls.Add(this.chkBusy);
            this.groupBox2.Controls.Add(this.cmbSpecimen);
            this.groupBox2.Controls.Add(this.txtSpecimenMemo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(5, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(770, 20);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(71, 23);
            this.simpleButton1.TabIndex = 128;
            this.simpleButton1.Text = "临床路径";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // spbtnAll
            // 
            this.spbtnAll.Location = new System.Drawing.Point(689, 20);
            this.spbtnAll.Name = "spbtnAll";
            this.spbtnAll.Size = new System.Drawing.Size(75, 23);
            this.spbtnAll.TabIndex = 107;
            this.spbtnAll.Text = "全选(&A)";
            this.spbtnAll.Click += new System.EventHandler(this.spbtnAll_Click);
            // 
            // spbtnNo
            // 
            this.spbtnNo.Location = new System.Drawing.Point(608, 20);
            this.spbtnNo.Name = "spbtnNo";
            this.spbtnNo.Size = new System.Drawing.Size(75, 23);
            this.spbtnNo.TabIndex = 107;
            this.spbtnNo.Text = "不选(&N)";
            this.spbtnNo.Click += new System.EventHandler(this.spbtnNo_Click);
            // 
            // spbtnSave
            // 
            this.spbtnSave.Location = new System.Drawing.Point(527, 20);
            this.spbtnSave.Name = "spbtnSave";
            this.spbtnSave.Size = new System.Drawing.Size(75, 23);
            this.spbtnSave.TabIndex = 107;
            this.spbtnSave.Text = "保存(&S)";
            this.spbtnSave.Click += new System.EventHandler(this.spbtnSave_Click);
            // 
            // cmbSpecimen
            // 
            this.cmbSpecimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecimen.FormattingEnabled = true;
            this.cmbSpecimen.Location = new System.Drawing.Point(62, 21);
            this.cmbSpecimen.Name = "cmbSpecimen";
            this.cmbSpecimen.Size = new System.Drawing.Size(121, 20);
            this.cmbSpecimen.TabIndex = 106;
            // 
            // txtSpecimenMemo
            // 
            this.txtSpecimenMemo.BackColor = System.Drawing.Color.White;
            this.txtSpecimenMemo.ForeColor = System.Drawing.Color.Blue;
            this.txtSpecimenMemo.Location = new System.Drawing.Point(250, 21);
            this.txtSpecimenMemo.MaxLength = 16;
            this.txtSpecimenMemo.Name = "txtSpecimenMemo";
            this.txtSpecimenMemo.Size = new System.Drawing.Size(90, 21);
            this.txtSpecimenMemo.TabIndex = 105;
            this.txtSpecimenMemo.TextChanged += new System.EventHandler(this.txtSpecimenMemo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(189, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 102;
            this.label3.Text = "样本说明：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(18, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 101;
            this.label5.Text = "样本：";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(3, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 456);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtMemo);
            this.splitContainer1.Panel2.Controls.Add(this.gcDetail);
            this.splitContainer1.Panel2.Controls.Add(this.gcItems);
            this.splitContainer1.Size = new System.Drawing.Size(869, 456);
            this.splitContainer1.SplitterDistance = 449;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(449, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.trv1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(441, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "1";
            this.tabPage1.Text = "常用检验";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // trv1
            // 
            this.trv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv1.ImageIndex = 0;
            this.trv1.ImageList = this.imageList1;
            this.trv1.Location = new System.Drawing.Point(3, 3);
            this.trv1.Name = "trv1";
            this.trv1.SelectedImageIndex = 0;
            this.trv1.Size = new System.Drawing.Size(435, 425);
            this.trv1.TabIndex = 0;
            this.trv1.DoubleClick += new System.EventHandler(this.trv1_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.trv2);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(441, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "2";
            this.tabPage2.Text = "生化检验";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // trv2
            // 
            this.trv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv2.ImageIndex = 0;
            this.trv2.ImageList = this.imageList1;
            this.trv2.Location = new System.Drawing.Point(3, 3);
            this.trv2.Name = "trv2";
            this.trv2.SelectedImageIndex = 0;
            this.trv2.Size = new System.Drawing.Size(435, 425);
            this.trv2.TabIndex = 1;
            this.trv2.DoubleClick += new System.EventHandler(this.trv1_DoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.trv3);
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(441, 431);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Tag = "3";
            this.tabPage3.Text = "免疫检验";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // trv3
            // 
            this.trv3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv3.ImageIndex = 0;
            this.trv3.ImageList = this.imageList1;
            this.trv3.Location = new System.Drawing.Point(3, 3);
            this.trv3.Name = "trv3";
            this.trv3.SelectedImageIndex = 0;
            this.trv3.Size = new System.Drawing.Size(435, 425);
            this.trv3.TabIndex = 2;
            this.trv3.DoubleClick += new System.EventHandler(this.trv1_DoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.trv4);
            this.tabPage4.Location = new System.Drawing.Point(4, 21);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(441, 431);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Tag = "4";
            this.tabPage4.Text = "血液检验";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // trv4
            // 
            this.trv4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv4.ImageIndex = 0;
            this.trv4.ImageList = this.imageList1;
            this.trv4.Location = new System.Drawing.Point(3, 3);
            this.trv4.Name = "trv4";
            this.trv4.SelectedImageIndex = 0;
            this.trv4.Size = new System.Drawing.Size(435, 425);
            this.trv4.TabIndex = 2;
            this.trv4.DoubleClick += new System.EventHandler(this.trv1_DoubleClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.trv5);
            this.tabPage5.Location = new System.Drawing.Point(4, 21);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(441, 431);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Tag = "5";
            this.tabPage5.Text = "尿粪积液";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // trv5
            // 
            this.trv5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv5.ImageIndex = 0;
            this.trv5.ImageList = this.imageList1;
            this.trv5.Location = new System.Drawing.Point(3, 3);
            this.trv5.Name = "trv5";
            this.trv5.SelectedImageIndex = 0;
            this.trv5.Size = new System.Drawing.Size(435, 425);
            this.trv5.TabIndex = 2;
            this.trv5.DoubleClick += new System.EventHandler(this.trv1_DoubleClick);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.trv6);
            this.tabPage6.Location = new System.Drawing.Point(4, 21);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(441, 431);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Tag = "6";
            this.tabPage6.Text = " 微生物";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // trv6
            // 
            this.trv6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv6.ImageIndex = 0;
            this.trv6.ImageList = this.imageList1;
            this.trv6.Location = new System.Drawing.Point(3, 3);
            this.trv6.Name = "trv6";
            this.trv6.SelectedImageIndex = 0;
            this.trv6.Size = new System.Drawing.Size(435, 425);
            this.trv6.TabIndex = 2;
            this.trv6.DoubleClick += new System.EventHandler(this.trv1_DoubleClick);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.trv7);
            this.tabPage7.Location = new System.Drawing.Point(4, 21);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(441, 431);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Tag = "7";
            this.tabPage7.Text = "内分泌";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // trv7
            // 
            this.trv7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv7.ImageIndex = 0;
            this.trv7.ImageList = this.imageList1;
            this.trv7.Location = new System.Drawing.Point(3, 3);
            this.trv7.Name = "trv7";
            this.trv7.SelectedImageIndex = 0;
            this.trv7.Size = new System.Drawing.Size(435, 425);
            this.trv7.TabIndex = 2;
            this.trv7.DoubleClick += new System.EventHandler(this.trv1_DoubleClick);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.trv8);
            this.tabPage8.Location = new System.Drawing.Point(4, 21);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(441, 431);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Tag = "8";
            this.tabPage8.Text = "   ";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // trv8
            // 
            this.trv8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv8.ImageIndex = 0;
            this.trv8.ImageList = this.imageList1;
            this.trv8.Location = new System.Drawing.Point(3, 3);
            this.trv8.Name = "trv8";
            this.trv8.SelectedImageIndex = 0;
            this.trv8.Size = new System.Drawing.Size(435, 425);
            this.trv8.TabIndex = 3;
            this.trv8.DoubleClick += new System.EventHandler(this.trv1_DoubleClick);
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.trv9);
            this.tabPage9.Location = new System.Drawing.Point(4, 21);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(441, 431);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Tag = "9";
            this.tabPage9.Text = "    ";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // trv9
            // 
            this.trv9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv9.ImageIndex = 0;
            this.trv9.ImageList = this.imageList1;
            this.trv9.Location = new System.Drawing.Point(3, 3);
            this.trv9.Name = "trv9";
            this.trv9.SelectedImageIndex = 0;
            this.trv9.Size = new System.Drawing.Size(435, 425);
            this.trv9.TabIndex = 4;
            this.trv9.DoubleClick += new System.EventHandler(this.trv1_DoubleClick);
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.trv10);
            this.tabPage10.Location = new System.Drawing.Point(4, 21);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(441, 431);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Tag = "10";
            this.tabPage10.Text = "    ";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // trv10
            // 
            this.trv10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv10.ImageIndex = 0;
            this.trv10.ImageList = this.imageList1;
            this.trv10.Location = new System.Drawing.Point(3, 3);
            this.trv10.Name = "trv10";
            this.trv10.SelectedImageIndex = 0;
            this.trv10.Size = new System.Drawing.Size(435, 425);
            this.trv10.TabIndex = 4;
            this.trv10.DoubleClick += new System.EventHandler(this.trv1_DoubleClick);
            // 
            // txtMemo
            // 
            this.txtMemo.BackColor = System.Drawing.SystemColors.Window;
            this.txtMemo.Location = new System.Drawing.Point(3, 21);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.ReadOnly = true;
            this.txtMemo.Size = new System.Drawing.Size(265, 286);
            this.txtMemo.TabIndex = 3;
            this.txtMemo.Text = "检验单说明";
            // 
            // gcDetail
            // 
            this.gcDetail.EmbeddedNavigator.Name = "";
            this.gcDetail.Location = new System.Drawing.Point(103, 60);
            this.gcDetail.MainView = this.gvDetail;
            this.gcDetail.Name = "gcDetail";
            this.gcDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rItemBtnEditSheetDetailClinicMemo});
            this.gcDetail.Size = new System.Drawing.Size(311, 329);
            this.gcDetail.TabIndex = 2;
            this.gcDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetail});
            // 
            // gvDetail
            // 
            this.gvDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ITEM_CODE,
            this.LAB_ITEM_NAME1,
            this.ITEM_NAME,
            this.CLINIC_MEMO1});
            this.gvDetail.GridControl = this.gcDetail;
            this.gvDetail.Name = "gvDetail";
            this.gvDetail.OptionsView.ColumnAutoWidth = false;
            this.gvDetail.OptionsView.ShowGroupPanel = false;
            this.gvDetail.DoubleClick += new System.EventHandler(this.gvDetail_DoubleClick);
            // 
            // ITEM_CODE
            // 
            this.ITEM_CODE.Caption = "项目编码";
            this.ITEM_CODE.FieldName = "ITEM_CODE";
            this.ITEM_CODE.Name = "ITEM_CODE";
            this.ITEM_CODE.OptionsColumn.ReadOnly = true;
            // 
            // LAB_ITEM_NAME1
            // 
            this.LAB_ITEM_NAME1.Caption = "所属检验单";
            this.LAB_ITEM_NAME1.FieldName = "LAB_ITEM_NAME";
            this.LAB_ITEM_NAME1.Name = "LAB_ITEM_NAME1";
            this.LAB_ITEM_NAME1.OptionsColumn.ReadOnly = true;
            this.LAB_ITEM_NAME1.Visible = true;
            this.LAB_ITEM_NAME1.VisibleIndex = 0;
            this.LAB_ITEM_NAME1.Width = 84;
            // 
            // ITEM_NAME
            // 
            this.ITEM_NAME.Caption = "对应项目名称";
            this.ITEM_NAME.FieldName = "ITEM_NAME";
            this.ITEM_NAME.Name = "ITEM_NAME";
            this.ITEM_NAME.OptionsColumn.ReadOnly = true;
            this.ITEM_NAME.Visible = true;
            this.ITEM_NAME.VisibleIndex = 1;
            this.ITEM_NAME.Width = 156;
            // 
            // CLINIC_MEMO1
            // 
            this.CLINIC_MEMO1.AppearanceCell.BackColor = System.Drawing.Color.LightGray;
            this.CLINIC_MEMO1.AppearanceCell.Options.UseBackColor = true;
            this.CLINIC_MEMO1.Caption = "临床意义";
            this.CLINIC_MEMO1.ColumnEdit = this.rItemBtnEditSheetDetailClinicMemo;
            this.CLINIC_MEMO1.FieldName = "CLINIC_MEMO";
            this.CLINIC_MEMO1.Name = "CLINIC_MEMO1";
            this.CLINIC_MEMO1.OptionsColumn.AllowEdit = false;
            this.CLINIC_MEMO1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.CLINIC_MEMO1.OptionsColumn.ReadOnly = true;
            this.CLINIC_MEMO1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.CLINIC_MEMO1.Visible = true;
            this.CLINIC_MEMO1.VisibleIndex = 2;
            // 
            // rItemBtnEditSheetDetailClinicMemo
            // 
            this.rItemBtnEditSheetDetailClinicMemo.AutoHeight = false;
            this.rItemBtnEditSheetDetailClinicMemo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.rItemBtnEditSheetDetailClinicMemo.Name = "rItemBtnEditSheetDetailClinicMemo";
            this.rItemBtnEditSheetDetailClinicMemo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.rItemBtnEditSheetDetailClinicMemo_ButtonClick);
            // 
            // gcItems
            // 
            this.gcItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcItems.EmbeddedNavigator.Name = "";
            this.gcItems.Location = new System.Drawing.Point(0, 0);
            this.gcItems.MainView = this.gvItems;
            this.gcItems.Name = "gcItems";
            this.gcItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.rItemBtnEditClinicMemo});
            this.gcItems.Size = new System.Drawing.Size(416, 456);
            this.gcItems.TabIndex = 0;
            this.gcItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvItems});
            // 
            // gvItems
            // 
            this.gvItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CHOOSE_FLAG,
            this.LAB_ITEM_NO,
            this.LAB_ITEM_NAME,
            this.LAB_SPECIMEN,
            this.LAB_ITEM_CODE,
            this.CLINIC_MEMO});
            this.gvItems.GridControl = this.gcItems;
            this.gvItems.Name = "gvItems";
            this.gvItems.OptionsSelection.MultiSelect = true;
            this.gvItems.OptionsView.ColumnAutoWidth = false;
            this.gvItems.OptionsView.ShowGroupPanel = false;
            this.gvItems.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvItems_CellValueChanged);
            this.gvItems.DoubleClick += new System.EventHandler(this.gvItems_DoubleClick);
            // 
            // CHOOSE_FLAG
            // 
            this.CHOOSE_FLAG.Caption = "  ";
            this.CHOOSE_FLAG.ColumnEdit = this.repositoryItemCheckEdit1;
            this.CHOOSE_FLAG.FieldName = "CHOOSE_FLAG";
            this.CHOOSE_FLAG.Name = "CHOOSE_FLAG";
            this.CHOOSE_FLAG.Visible = true;
            this.CHOOSE_FLAG.VisibleIndex = 0;
            this.CHOOSE_FLAG.Width = 31;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // LAB_ITEM_NO
            // 
            this.LAB_ITEM_NO.Caption = "序号";
            this.LAB_ITEM_NO.FieldName = "LAB_ITEM_NO";
            this.LAB_ITEM_NO.Name = "LAB_ITEM_NO";
            this.LAB_ITEM_NO.OptionsColumn.AllowEdit = false;
            this.LAB_ITEM_NO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.LAB_ITEM_NO.OptionsColumn.ReadOnly = true;
            this.LAB_ITEM_NO.Visible = true;
            this.LAB_ITEM_NO.VisibleIndex = 1;
            this.LAB_ITEM_NO.Width = 47;
            // 
            // LAB_ITEM_NAME
            // 
            this.LAB_ITEM_NAME.Caption = "项目名称";
            this.LAB_ITEM_NAME.FieldName = "LAB_ITEM_NAME";
            this.LAB_ITEM_NAME.Name = "LAB_ITEM_NAME";
            this.LAB_ITEM_NAME.OptionsColumn.AllowEdit = false;
            this.LAB_ITEM_NAME.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.LAB_ITEM_NAME.OptionsColumn.ReadOnly = true;
            this.LAB_ITEM_NAME.Visible = true;
            this.LAB_ITEM_NAME.VisibleIndex = 2;
            this.LAB_ITEM_NAME.Width = 153;
            // 
            // LAB_SPECIMEN
            // 
            this.LAB_SPECIMEN.Caption = "样本";
            this.LAB_SPECIMEN.FieldName = "LAB_SPECIMEN";
            this.LAB_SPECIMEN.Name = "LAB_SPECIMEN";
            this.LAB_SPECIMEN.OptionsColumn.AllowEdit = false;
            this.LAB_SPECIMEN.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.LAB_SPECIMEN.OptionsColumn.ReadOnly = true;
            this.LAB_SPECIMEN.Visible = true;
            this.LAB_SPECIMEN.VisibleIndex = 3;
            // 
            // LAB_ITEM_CODE
            // 
            this.LAB_ITEM_CODE.Caption = "项目编码";
            this.LAB_ITEM_CODE.FieldName = "LAB_ITEM_CODE";
            this.LAB_ITEM_CODE.Name = "LAB_ITEM_CODE";
            this.LAB_ITEM_CODE.OptionsColumn.AllowEdit = false;
            this.LAB_ITEM_CODE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.LAB_ITEM_CODE.OptionsColumn.ReadOnly = true;
            // 
            // CLINIC_MEMO
            // 
            this.CLINIC_MEMO.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CLINIC_MEMO.AppearanceCell.Options.UseBackColor = true;
            this.CLINIC_MEMO.Caption = "临床意义";
            this.CLINIC_MEMO.ColumnEdit = this.rItemBtnEditClinicMemo;
            this.CLINIC_MEMO.FieldName = "CLINIC_MEMO";
            this.CLINIC_MEMO.Name = "CLINIC_MEMO";
            this.CLINIC_MEMO.OptionsColumn.AllowEdit = false;
            this.CLINIC_MEMO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.CLINIC_MEMO.OptionsColumn.ReadOnly = true;
            this.CLINIC_MEMO.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.CLINIC_MEMO.Tag = "LAB_ITEM_CODE";
            this.CLINIC_MEMO.Visible = true;
            this.CLINIC_MEMO.VisibleIndex = 4;
            this.CLINIC_MEMO.Width = 72;
            // 
            // rItemBtnEditClinicMemo
            // 
            this.rItemBtnEditClinicMemo.AutoHeight = false;
            this.rItemBtnEditClinicMemo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.rItemBtnEditClinicMemo.Name = "rItemBtnEditClinicMemo";
            this.rItemBtnEditClinicMemo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.rItemBtnEditClinicMemo_ButtonClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(878, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(215, 22);
            this.toolStripLabel1.Text = "注意： 做检验申请前，请关闭医嘱界面";
            // 
            // UCLab
            // 
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCLab";
            this.Size = new System.Drawing.Size(878, 617);
            this.Load += new System.EventHandler(this.UCLab_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLabList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLabList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rItemBtnEditSheetDetailClinicMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rItemBtnEditClinicMemo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblDoct;
        private Label lblSex;
        private Label lblID;
        private Label lblName;
        private Label lblBedNo;
        private TextBox txtSex;
        private TextBox txtDoctorCharge;
        private TextBox txtName;
        private TextBox txtBed;
        private CheckBox chkBusy;
        private System.Windows.Forms.ComboBox cmbSpecimen;
        private TextBox txtDoctorApply;
        private TextBox txtSpecimenMemo;
        private Label label1;
        private Label label3;
        private Label label5;
        private SimpleButton spbtnAll;
        private SimpleButton spbtnNo;
        private SimpleButton spbtnSave;
        private SplitContainer splitContainer1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TreeView trv1;
        private TabPage tabPage2;
        private TreeView trv2;
        private TabPage tabPage3;
        private TreeView trv3;
        private TabPage tabPage4;
        private TreeView trv4;
        private TabPage tabPage5;
        private TreeView trv5;
        private TabPage tabPage6;
        private TreeView trv6;
        private TabPage tabPage7;
        private TreeView trv7;
        private GridControl gcItems;
        private GridView gvItems;
        private GridColumn CHOOSE_FLAG;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private GridColumn LAB_ITEM_NO;
        private GridColumn LAB_ITEM_NAME;
        private GridColumn LAB_ITEM_CODE;
        private TabPage tabPage8;
        private TreeView trv8;
        private TabPage tabPage9;
        private TreeView trv9;
        private TabPage tabPage10;
        private TreeView trv10;
        private ImageList imageList1;
        private GridControl gcDetail;
        private GridView gvDetail;
        private GridColumn ITEM_NAME;
        private GridColumn ITEM_CODE;
        private GridColumn LAB_SPECIMEN;
        private GridColumn CLINIC_MEMO;
        private RichTextBox txtMemo;
        private RepositoryItemButtonEdit rItemBtnEditClinicMemo;
        private GridColumn CLINIC_MEMO1;
        private RepositoryItemButtonEdit rItemBtnEditSheetDetailClinicMemo;
        private GridColumn LAB_ITEM_NAME1;
        private ToolStripLabel toolStripLabel1;
        public ToolStrip toolStrip1;
        public GroupBox groupBox1;
        public GroupBox groupBox2;
        public Panel panel1;
        public TextBox txtPatientId;
        private PanelControl panelControl1;
        private GridControl gcLabList;
        private GridView gvLabList;
        private GridColumn gridColumn1;
        private RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private GridColumn gridColumn2;
        private GridColumn gridColumn3;
        private GridColumn gridColumn4;
        private GridColumn gridColumn5;
        private GridColumn gridColumn6;
        private RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private SimpleButton cpbtnAll;
        private SimpleButton cpbtnNo;
        private SimpleButton cpbtnSave;
        private CheckBox chkCpBusy;
        private System.Windows.Forms.ComboBox CPcmbSpecimen;
        private TextBox txtCPSpecimenMemo;
        private Label label10;
        private Label label11;
        private TextBox txtCPSex;
        private Label label2;
        private TextBox txtCPDoctor;
        private TextBox txtCPBedNo;
        private Label label4;
        private Label label6;
        private TextBox txtCPApplyDoctor;
        private Label label7;
        private Label label8;
        public TextBox txtCPPatId;
        private TextBox txtCPName;
        private Label label9;
        private SimpleButton simpleButtonCancel;
        private SimpleButton simpleButton1;
        private GridColumn gridColumn7;
    }
}
