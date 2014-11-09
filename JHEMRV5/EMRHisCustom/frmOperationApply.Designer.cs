using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Base;
namespace JHEMR.EMRHisCustom
{
    partial class frmOperationApply
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
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ckbAll = new System.Windows.Forms.CheckBox();
            this.panelPYInput = new System.Windows.Forms.Panel();
            this.gridPYInput = new DevExpress.XtraGrid.GridControl();
            this.gridViewPYInput = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ITEM_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OPERATION_SCALE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtInPut = new System.Windows.Forms.TextBox();
            this.lblPyItemName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gcPat = new DevExpress.XtraGrid.GridControl();
            this.gvPat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BED_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusBottom = new System.Windows.Forms.StatusStrip();
            this.tlstatusBottom = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtINP_NO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBED_NO = new System.Windows.Forms.TextBox();
            this.lblBed = new System.Windows.Forms.Label();
            this.sbtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gcOperaion = new DevExpress.XtraGrid.GridControl();
            this.gvOperation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.OPERATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OPERATION_SCALE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbANTIBIOTIC = new System.Windows.Forms.ComboBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtoperating_room = new System.Windows.Forms.TextBox();
            this.txtfourth_assistant = new System.Windows.Forms.TextBox();
            this.txtthird_assistant = new System.Windows.Forms.TextBox();
            this.txtsecond_assistant = new System.Windows.Forms.TextBox();
            this.txtfirst_assistant = new System.Windows.Forms.TextBox();
            this.txtnotes_on_operation = new System.Windows.Forms.TextBox();
            this.txtdiag_before_operation = new System.Windows.Forms.TextBox();
            this.txtDOSAGE = new System.Windows.Forms.TextBox();
            this.txtpatient_condition = new System.Windows.Forms.TextBox();
            this.txtOPERATING_DEPT = new System.Windows.Forms.TextBox();
            this.txtanesthesia_assistant = new System.Windows.Forms.TextBox();
            this.txtanesthesia_doctor = new System.Windows.Forms.TextBox();
            this.dtpACK_TIME = new System.Windows.Forms.TextBox();
            this.dtpreq_date_time = new System.Windows.Forms.TextBox();
            this.txtsecond_supply_nurse = new System.Windows.Forms.TextBox();
            this.txtfirst_supply_nurse = new System.Windows.Forms.TextBox();
            this.txtsecond_operation_nurse = new System.Windows.Forms.TextBox();
            this.txtfirst_operation_nurse = new System.Windows.Forms.TextBox();
            this.txtblood_tran_doctor = new System.Windows.Forms.TextBox();
            this.txtsequence = new System.Windows.Forms.TextBox();
            this.txtentered_by = new System.Windows.Forms.TextBox();
            this.txtsurgeon = new System.Windows.Forms.TextBox();
            this.cmboperating_room_no = new System.Windows.Forms.ComboBox();
            this.cmboperation_scale = new System.Windows.Forms.ComboBox();
            this.cmbanesthesia_method = new System.Windows.Forms.ComboBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.cmbisolation_indicator = new System.Windows.Forms.ComboBox();
            this.cmboperating_room = new System.Windows.Forms.ComboBox();
            this.dtpscheduled_date_time = new System.Windows.Forms.DateTimePicker();
            this.label111 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelPYInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPYInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPYInput)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPat)).BeginInit();
            this.statusBottom.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcOperaion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOperation)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDept
            // 
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(417, 5);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(137, 20);
            this.cmbDept.TabIndex = 1;
            this.cmbDept.Visible = false;
            this.cmbDept.SelectedIndexChanged += new System.EventHandler(this.cmbDept_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDeptName);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.ckbAll);
            this.panel1.Controls.Add(this.cmbDept);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 29);
            this.panel1.TabIndex = 1;
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(12, 5);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.ReadOnly = true;
            this.txtDeptName.Size = new System.Drawing.Size(149, 21);
            this.txtDeptName.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(175, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(55, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "科室";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ckbAll
            // 
            this.ckbAll.AutoSize = true;
            this.ckbAll.Location = new System.Drawing.Point(359, 9);
            this.ckbAll.Name = "ckbAll";
            this.ckbAll.Size = new System.Drawing.Size(48, 16);
            this.ckbAll.TabIndex = 2;
            this.ckbAll.Text = "全院";
            this.ckbAll.UseVisualStyleBackColor = true;
            this.ckbAll.Visible = false;
            this.ckbAll.CheckedChanged += new System.EventHandler(this.ckbAll_CheckedChanged);
            // 
            // panelPYInput
            // 
            this.panelPYInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelPYInput.Controls.Add(this.gridPYInput);
            this.panelPYInput.Controls.Add(this.txtInPut);
            this.panelPYInput.Controls.Add(this.lblPyItemName);
            this.panelPYInput.Location = new System.Drawing.Point(161, 2);
            this.panelPYInput.Name = "panelPYInput";
            this.panelPYInput.Size = new System.Drawing.Size(221, 191);
            this.panelPYInput.TabIndex = 1;
            this.panelPYInput.Visible = false;
            // 
            // gridPYInput
            // 
            this.gridPYInput.EmbeddedNavigator.Name = "";
            this.gridPYInput.Location = new System.Drawing.Point(3, 30);
            this.gridPYInput.MainView = this.gridViewPYInput;
            this.gridPYInput.Name = "gridPYInput";
            this.gridPYInput.Size = new System.Drawing.Size(215, 153);
            this.gridPYInput.TabIndex = 5;
            this.gridPYInput.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPYInput});
            this.gridPYInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridPYInput_KeyDown);
            // 
            // gridViewPYInput
            // 
            this.gridViewPYInput.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ITEM_NAME,
            this.OPERATION_SCALE1});
            this.gridViewPYInput.GridControl = this.gridPYInput;
            this.gridViewPYInput.Name = "gridViewPYInput";
            this.gridViewPYInput.OptionsView.ColumnAutoWidth = false;
            this.gridViewPYInput.OptionsView.ShowColumnHeaders = false;
            this.gridViewPYInput.OptionsView.ShowGroupPanel = false;
            this.gridViewPYInput.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewPYInput_FocusedRowChanged);
            this.gridViewPYInput.DoubleClick += new System.EventHandler(this.gridViewPYInput_DoubleClick);
            // 
            // ITEM_NAME
            // 
            this.ITEM_NAME.Caption = "名称";
            this.ITEM_NAME.FieldName = "ITEM_NAME";
            this.ITEM_NAME.Name = "ITEM_NAME";
            this.ITEM_NAME.OptionsColumn.AllowEdit = false;
            this.ITEM_NAME.OptionsColumn.ReadOnly = true;
            this.ITEM_NAME.Visible = true;
            this.ITEM_NAME.VisibleIndex = 0;
            this.ITEM_NAME.Width = 160;
            // 
            // OPERATION_SCALE1
            // 
            this.OPERATION_SCALE1.Caption = "OPERATION_SCALE";
            this.OPERATION_SCALE1.FieldName = "OPERATION_SCALE";
            this.OPERATION_SCALE1.Name = "OPERATION_SCALE1";
            this.OPERATION_SCALE1.OptionsColumn.AllowEdit = false;
            this.OPERATION_SCALE1.OptionsColumn.ReadOnly = true;
            // 
            // txtInPut
            // 
            this.txtInPut.Location = new System.Drawing.Point(3, 3);
            this.txtInPut.Name = "txtInPut";
            this.txtInPut.Size = new System.Drawing.Size(83, 21);
            this.txtInPut.TabIndex = 4;
            this.txtInPut.TextChanged += new System.EventHandler(this.txtInPut_TextChanged);
            this.txtInPut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInPut_KeyDown);
            // 
            // lblPyItemName
            // 
            this.lblPyItemName.AutoSize = true;
            this.lblPyItemName.Location = new System.Drawing.Point(93, 7);
            this.lblPyItemName.Name = "lblPyItemName";
            this.lblPyItemName.Size = new System.Drawing.Size(11, 12);
            this.lblPyItemName.TabIndex = 0;
            this.lblPyItemName.Text = " ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gcPat);
            this.panel2.Location = new System.Drawing.Point(12, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 462);
            this.panel2.TabIndex = 2;
            // 
            // gcPat
            // 
            this.gcPat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPat.EmbeddedNavigator.Name = "";
            this.gcPat.Location = new System.Drawing.Point(0, 0);
            this.gcPat.MainView = this.gvPat;
            this.gcPat.Name = "gcPat";
            this.gcPat.Size = new System.Drawing.Size(149, 462);
            this.gcPat.TabIndex = 0;
            this.gcPat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPat});
            // 
            // gvPat
            // 
            this.gvPat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BED_NO,
            this.NAME});
            this.gvPat.GridControl = this.gcPat;
            this.gvPat.Name = "gvPat";
            this.gvPat.OptionsView.ColumnAutoWidth = false;
            this.gvPat.OptionsView.ShowGroupPanel = false;
            this.gvPat.OptionsView.ShowIndicator = false;
            this.gvPat.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvPat_FocusedRowChanged);
            // 
            // BED_NO
            // 
            this.BED_NO.Caption = "床号";
            this.BED_NO.FieldName = "BED_NO";
            this.BED_NO.Name = "BED_NO";
            this.BED_NO.OptionsColumn.AllowEdit = false;
            this.BED_NO.OptionsColumn.ReadOnly = true;
            this.BED_NO.Visible = true;
            this.BED_NO.VisibleIndex = 0;
            this.BED_NO.Width = 48;
            // 
            // NAME
            // 
            this.NAME.Caption = "姓名";
            this.NAME.FieldName = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.OptionsColumn.AllowEdit = false;
            this.NAME.OptionsColumn.ReadOnly = true;
            this.NAME.Visible = true;
            this.NAME.VisibleIndex = 1;
            this.NAME.Width = 73;
            // 
            // statusBottom
            // 
            this.statusBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstatusBottom});
            this.statusBottom.Location = new System.Drawing.Point(0, 517);
            this.statusBottom.Name = "statusBottom";
            this.statusBottom.Size = new System.Drawing.Size(832, 22);
            this.statusBottom.TabIndex = 3;
            this.statusBottom.Text = "Ready";
            // 
            // tlstatusBottom
            // 
            this.tlstatusBottom.ForeColor = System.Drawing.Color.Blue;
            this.tlstatusBottom.Name = "tlstatusBottom";
            this.tlstatusBottom.Size = new System.Drawing.Size(35, 17);
            this.tlstatusBottom.Text = "Ready";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtAge);
            this.panel3.Controls.Add(this.txtSex);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtINP_NO);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtPatID);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtBED_NO);
            this.panel3.Controls.Add(this.lblBed);
            this.panel3.Location = new System.Drawing.Point(179, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(641, 39);
            this.panel3.TabIndex = 2;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAge.Location = new System.Drawing.Point(585, 8);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(31, 21);
            this.txtAge.TabIndex = 1;
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSex.Location = new System.Drawing.Point(504, 9);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(31, 21);
            this.txtSex.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "年龄";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "性别";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.Location = new System.Drawing.Point(371, 9);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(74, 21);
            this.txtName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "姓名";
            // 
            // txtINP_NO
            // 
            this.txtINP_NO.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtINP_NO.Location = new System.Drawing.Point(261, 9);
            this.txtINP_NO.Name = "txtINP_NO";
            this.txtINP_NO.ReadOnly = true;
            this.txtINP_NO.Size = new System.Drawing.Size(55, 21);
            this.txtINP_NO.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "住院号";
            // 
            // txtPatID
            // 
            this.txtPatID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPatID.Location = new System.Drawing.Point(139, 9);
            this.txtPatID.Name = "txtPatID";
            this.txtPatID.ReadOnly = true;
            this.txtPatID.Size = new System.Drawing.Size(67, 21);
            this.txtPatID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "病人ID";
            // 
            // txtBED_NO
            // 
            this.txtBED_NO.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBED_NO.Location = new System.Drawing.Point(43, 9);
            this.txtBED_NO.Name = "txtBED_NO";
            this.txtBED_NO.ReadOnly = true;
            this.txtBED_NO.Size = new System.Drawing.Size(41, 21);
            this.txtBED_NO.TabIndex = 1;
            // 
            // lblBed
            // 
            this.lblBed.AutoSize = true;
            this.lblBed.Location = new System.Drawing.Point(13, 13);
            this.lblBed.Name = "lblBed";
            this.lblBed.Size = new System.Drawing.Size(29, 12);
            this.lblBed.TabIndex = 0;
            this.lblBed.Text = "床号";
            // 
            // sbtnDelete
            // 
            this.sbtnDelete.Location = new System.Drawing.Point(726, 134);
            this.sbtnDelete.Name = "sbtnDelete";
            this.sbtnDelete.Size = new System.Drawing.Size(75, 23);
            this.sbtnDelete.TabIndex = 5;
            this.sbtnDelete.Text = "删除(&D)";
            this.sbtnDelete.Click += new System.EventHandler(this.sbtnDelete_Click);
            // 
            // sbtnAdd
            // 
            this.sbtnAdd.Location = new System.Drawing.Point(726, 93);
            this.sbtnAdd.Name = "sbtnAdd";
            this.sbtnAdd.Size = new System.Drawing.Size(75, 23);
            this.sbtnAdd.TabIndex = 6;
            this.sbtnAdd.Text = "增加(&A)";
            this.sbtnAdd.Click += new System.EventHandler(this.sbtnAdd_Click);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.gcOperaion);
            this.panel4.Location = new System.Drawing.Point(177, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(526, 100);
            this.panel4.TabIndex = 4;
            // 
            // gcOperaion
            // 
            this.gcOperaion.EmbeddedNavigator.Name = "";
            this.gcOperaion.Location = new System.Drawing.Point(0, 0);
            this.gcOperaion.MainView = this.gvOperation;
            this.gcOperaion.Name = "gcOperaion";
            this.gcOperaion.Size = new System.Drawing.Size(523, 100);
            this.gcOperaion.TabIndex = 0;
            this.gcOperaion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOperation});
            this.gcOperaion.Leave += new System.EventHandler(this.gcOperaion_Leave);
            this.gcOperaion.Enter += new System.EventHandler(this.gcOperaion_Enter);
            // 
            // gvOperation
            // 
            this.gvOperation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.OPERATION,
            this.OPERATION_SCALE});
            this.gvOperation.GridControl = this.gcOperaion;
            this.gvOperation.Name = "gvOperation";
            this.gvOperation.OptionsView.ColumnAutoWidth = false;
            this.gvOperation.OptionsView.ShowGroupPanel = false;
            this.gvOperation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvOperation_KeyDown);
            this.gvOperation.DoubleClick += new System.EventHandler(this.gvOperation_DoubleClick);
            this.gvOperation.HiddenEditor += new System.EventHandler(this.gvOperation_HiddenEditor);
            this.gvOperation.ShownEditor += new System.EventHandler(this.gvOperation_ShownEditor);
            // 
            // OPERATION
            // 
            this.OPERATION.Caption = "拟实施手术名称";
            this.OPERATION.FieldName = "OPERATION";
            this.OPERATION.Name = "OPERATION";
            this.OPERATION.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.OPERATION.OptionsColumn.AllowMove = false;
            this.OPERATION.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.OPERATION.Visible = true;
            this.OPERATION.VisibleIndex = 0;
            this.OPERATION.Width = 379;
            // 
            // OPERATION_SCALE
            // 
            this.OPERATION_SCALE.Caption = "等级";
            this.OPERATION_SCALE.FieldName = "OPERATION_SCALE";
            this.OPERATION_SCALE.Name = "OPERATION_SCALE";
            this.OPERATION_SCALE.OptionsColumn.AllowEdit = false;
            this.OPERATION_SCALE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.OPERATION_SCALE.OptionsColumn.AllowMove = false;
            this.OPERATION_SCALE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.OPERATION_SCALE.OptionsColumn.ReadOnly = true;
            this.OPERATION_SCALE.Visible = true;
            this.OPERATION_SCALE.VisibleIndex = 1;
            this.OPERATION_SCALE.Width = 74;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panelPYInput);
            this.panel5.Controls.Add(this.cmbANTIBIOTIC);
            this.panel5.Controls.Add(this.simpleButton4);
            this.panel5.Controls.Add(this.sbtnSave);
            this.panel5.Controls.Add(this.txtoperating_room);
            this.panel5.Controls.Add(this.txtfourth_assistant);
            this.panel5.Controls.Add(this.txtthird_assistant);
            this.panel5.Controls.Add(this.txtsecond_assistant);
            this.panel5.Controls.Add(this.txtfirst_assistant);
            this.panel5.Controls.Add(this.txtnotes_on_operation);
            this.panel5.Controls.Add(this.txtdiag_before_operation);
            this.panel5.Controls.Add(this.txtDOSAGE);
            this.panel5.Controls.Add(this.txtpatient_condition);
            this.panel5.Controls.Add(this.txtOPERATING_DEPT);
            this.panel5.Controls.Add(this.txtanesthesia_assistant);
            this.panel5.Controls.Add(this.txtanesthesia_doctor);
            this.panel5.Controls.Add(this.dtpACK_TIME);
            this.panel5.Controls.Add(this.dtpreq_date_time);
            this.panel5.Controls.Add(this.txtsecond_supply_nurse);
            this.panel5.Controls.Add(this.txtfirst_supply_nurse);
            this.panel5.Controls.Add(this.txtsecond_operation_nurse);
            this.panel5.Controls.Add(this.txtfirst_operation_nurse);
            this.panel5.Controls.Add(this.txtblood_tran_doctor);
            this.panel5.Controls.Add(this.txtsequence);
            this.panel5.Controls.Add(this.txtentered_by);
            this.panel5.Controls.Add(this.txtsurgeon);
            this.panel5.Controls.Add(this.cmboperating_room_no);
            this.panel5.Controls.Add(this.cmboperation_scale);
            this.panel5.Controls.Add(this.cmbanesthesia_method);
            this.panel5.Controls.Add(this.cmbGroup);
            this.panel5.Controls.Add(this.cmbisolation_indicator);
            this.panel5.Controls.Add(this.cmboperating_room);
            this.panel5.Controls.Add(this.dtpscheduled_date_time);
            this.panel5.Controls.Add(this.label111);
            this.panel5.Controls.Add(this.label27);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label28);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Location = new System.Drawing.Point(176, 185);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(644, 309);
            this.panel5.TabIndex = 7;
            // 
            // cmbANTIBIOTIC
            // 
            this.cmbANTIBIOTIC.FormattingEnabled = true;
            this.cmbANTIBIOTIC.Location = new System.Drawing.Point(119, 219);
            this.cmbANTIBIOTIC.Name = "cmbANTIBIOTIC";
            this.cmbANTIBIOTIC.Size = new System.Drawing.Size(177, 20);
            this.cmbANTIBIOTIC.TabIndex = 1000;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(550, 280);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 19;
            this.simpleButton4.Text = "关闭(&C)";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // sbtnSave
            // 
            this.sbtnSave.Location = new System.Drawing.Point(441, 280);
            this.sbtnSave.Name = "sbtnSave";
            this.sbtnSave.Size = new System.Drawing.Size(75, 23);
            this.sbtnSave.TabIndex = 18;
            this.sbtnSave.Text = "保存(&S)";
            this.sbtnSave.Click += new System.EventHandler(this.sbtnSave_Click);
            // 
            // txtoperating_room
            // 
            this.txtoperating_room.BackColor = System.Drawing.Color.OldLace;
            this.txtoperating_room.Location = new System.Drawing.Point(413, 54);
            this.txtoperating_room.MaxLength = 50;
            this.txtoperating_room.Name = "txtoperating_room";
            this.txtoperating_room.Size = new System.Drawing.Size(103, 21);
            this.txtoperating_room.TabIndex = 7;
            this.txtoperating_room.Enter += new System.EventHandler(this.txtOPERATING_DEPT_Enter);
            this.txtoperating_room.Leave += new System.EventHandler(this.txtOPERATING_DEPT_Leave);
            this.txtoperating_room.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOPERATING_DEPT_KeyPress);
            this.txtoperating_room.TextChanged += new System.EventHandler(this.txtoperating_room_TextChanged);
            this.txtoperating_room.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOPERATING_DEPT_KeyDown);
            // 
            // txtfourth_assistant
            // 
            this.txtfourth_assistant.BackColor = System.Drawing.Color.OldLace;
            this.txtfourth_assistant.Location = new System.Drawing.Point(347, 116);
            this.txtfourth_assistant.MaxLength = 8;
            this.txtfourth_assistant.Name = "txtfourth_assistant";
            this.txtfourth_assistant.Size = new System.Drawing.Size(83, 21);
            this.txtfourth_assistant.TabIndex = 15;
            this.txtfourth_assistant.Enter += new System.EventHandler(this.txtsurgeon_Enter);
            this.txtfourth_assistant.Leave += new System.EventHandler(this.txtsurgeon_Leave);
            this.txtfourth_assistant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsurgeon_KeyPress);
            this.txtfourth_assistant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsurgeon_KeyDown);
            // 
            // txtthird_assistant
            // 
            this.txtthird_assistant.BackColor = System.Drawing.Color.OldLace;
            this.txtthird_assistant.Location = new System.Drawing.Point(254, 116);
            this.txtthird_assistant.MaxLength = 8;
            this.txtthird_assistant.Name = "txtthird_assistant";
            this.txtthird_assistant.Size = new System.Drawing.Size(87, 21);
            this.txtthird_assistant.TabIndex = 14;
            this.txtthird_assistant.Enter += new System.EventHandler(this.txtsurgeon_Enter);
            this.txtthird_assistant.Leave += new System.EventHandler(this.txtsurgeon_Leave);
            this.txtthird_assistant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsurgeon_KeyPress);
            this.txtthird_assistant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsurgeon_KeyDown);
            // 
            // txtsecond_assistant
            // 
            this.txtsecond_assistant.BackColor = System.Drawing.Color.OldLace;
            this.txtsecond_assistant.Location = new System.Drawing.Point(170, 116);
            this.txtsecond_assistant.MaxLength = 8;
            this.txtsecond_assistant.Name = "txtsecond_assistant";
            this.txtsecond_assistant.Size = new System.Drawing.Size(80, 21);
            this.txtsecond_assistant.TabIndex = 13;
            this.txtsecond_assistant.Enter += new System.EventHandler(this.txtsurgeon_Enter);
            this.txtsecond_assistant.Leave += new System.EventHandler(this.txtsurgeon_Leave);
            this.txtsecond_assistant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsurgeon_KeyPress);
            this.txtsecond_assistant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsurgeon_KeyDown);
            // 
            // txtfirst_assistant
            // 
            this.txtfirst_assistant.BackColor = System.Drawing.Color.OldLace;
            this.txtfirst_assistant.Location = new System.Drawing.Point(81, 116);
            this.txtfirst_assistant.MaxLength = 8;
            this.txtfirst_assistant.Name = "txtfirst_assistant";
            this.txtfirst_assistant.Size = new System.Drawing.Size(86, 21);
            this.txtfirst_assistant.TabIndex = 12;
            this.txtfirst_assistant.Enter += new System.EventHandler(this.txtsurgeon_Enter);
            this.txtfirst_assistant.Leave += new System.EventHandler(this.txtfirst_assistant_Leave);
            this.txtfirst_assistant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsurgeon1_KeyPress);
            this.txtfirst_assistant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsurgeon1_KeyDown);
            // 
            // txtnotes_on_operation
            // 
            this.txtnotes_on_operation.Location = new System.Drawing.Point(282, 185);
            this.txtnotes_on_operation.MaxLength = 20;
            this.txtnotes_on_operation.Name = "txtnotes_on_operation";
            this.txtnotes_on_operation.Size = new System.Drawing.Size(341, 21);
            this.txtnotes_on_operation.TabIndex = 17;
            // 
            // txtdiag_before_operation
            // 
            this.txtdiag_before_operation.BackColor = System.Drawing.Color.White;
            this.txtdiag_before_operation.Location = new System.Drawing.Point(71, 19);
            this.txtdiag_before_operation.MaxLength = 40;
            this.txtdiag_before_operation.Name = "txtdiag_before_operation";
            this.txtdiag_before_operation.Size = new System.Drawing.Size(328, 21);
            this.txtdiag_before_operation.TabIndex = 4;
            this.txtdiag_before_operation.Enter += new System.EventHandler(this.txtdiag_before_operation_Enter);
            this.txtdiag_before_operation.Leave += new System.EventHandler(this.txtdiag_before_operation_Leave);
            this.txtdiag_before_operation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdiag_before_operation_KeyDown);
            // 
            // txtDOSAGE
            // 
            this.txtDOSAGE.Location = new System.Drawing.Point(450, 218);
            this.txtDOSAGE.MaxLength = 20;
            this.txtDOSAGE.Name = "txtDOSAGE";
            this.txtDOSAGE.Size = new System.Drawing.Size(171, 21);
            this.txtDOSAGE.TabIndex = 5;
            // 
            // txtpatient_condition
            // 
            this.txtpatient_condition.Location = new System.Drawing.Point(452, 19);
            this.txtpatient_condition.MaxLength = 20;
            this.txtpatient_condition.Name = "txtpatient_condition";
            this.txtpatient_condition.Size = new System.Drawing.Size(171, 21);
            this.txtpatient_condition.TabIndex = 5;
            // 
            // txtOPERATING_DEPT
            // 
            this.txtOPERATING_DEPT.BackColor = System.Drawing.Color.OldLace;
            this.txtOPERATING_DEPT.Location = new System.Drawing.Point(199, 88);
            this.txtOPERATING_DEPT.MaxLength = 40;
            this.txtOPERATING_DEPT.Name = "txtOPERATING_DEPT";
            this.txtOPERATING_DEPT.Size = new System.Drawing.Size(118, 21);
            this.txtOPERATING_DEPT.TabIndex = 9;
            this.txtOPERATING_DEPT.Enter += new System.EventHandler(this.txtOPERATING_DEPT_Enter);
            this.txtOPERATING_DEPT.Leave += new System.EventHandler(this.txtOPERATING_DEPT_Leave);
            this.txtOPERATING_DEPT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOPERATING_DEPT_KeyPress);
            this.txtOPERATING_DEPT.TextChanged += new System.EventHandler(this.txtOPERATING_DEPT_TextChanged);
            this.txtOPERATING_DEPT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOPERATING_DEPT_KeyDown);
            // 
            // txtanesthesia_assistant
            // 
            this.txtanesthesia_assistant.BackColor = System.Drawing.SystemColors.Control;
            this.txtanesthesia_assistant.Enabled = false;
            this.txtanesthesia_assistant.Location = new System.Drawing.Point(158, 149);
            this.txtanesthesia_assistant.MaxLength = 8;
            this.txtanesthesia_assistant.Name = "txtanesthesia_assistant";
            this.txtanesthesia_assistant.Size = new System.Drawing.Size(67, 21);
            this.txtanesthesia_assistant.TabIndex = 999;
            // 
            // txtanesthesia_doctor
            // 
            this.txtanesthesia_doctor.BackColor = System.Drawing.SystemColors.Control;
            this.txtanesthesia_doctor.Enabled = false;
            this.txtanesthesia_doctor.Location = new System.Drawing.Point(80, 150);
            this.txtanesthesia_doctor.MaxLength = 8;
            this.txtanesthesia_doctor.Name = "txtanesthesia_doctor";
            this.txtanesthesia_doctor.Size = new System.Drawing.Size(75, 21);
            this.txtanesthesia_doctor.TabIndex = 999;
            // 
            // dtpACK_TIME
            // 
            this.dtpACK_TIME.BackColor = System.Drawing.SystemColors.Control;
            this.dtpACK_TIME.Enabled = false;
            this.dtpACK_TIME.ForeColor = System.Drawing.Color.Blue;
            this.dtpACK_TIME.Location = new System.Drawing.Point(80, 250);
            this.dtpACK_TIME.MaxLength = 8;
            this.dtpACK_TIME.Name = "dtpACK_TIME";
            this.dtpACK_TIME.Size = new System.Drawing.Size(129, 21);
            this.dtpACK_TIME.TabIndex = 999;
            this.dtpACK_TIME.Text = "0000-00-00 00:00";
            // 
            // dtpreq_date_time
            // 
            this.dtpreq_date_time.BackColor = System.Drawing.SystemColors.Control;
            this.dtpreq_date_time.Enabled = false;
            this.dtpreq_date_time.ForeColor = System.Drawing.Color.Red;
            this.dtpreq_date_time.Location = new System.Drawing.Point(298, 250);
            this.dtpreq_date_time.MaxLength = 8;
            this.dtpreq_date_time.Name = "dtpreq_date_time";
            this.dtpreq_date_time.Size = new System.Drawing.Size(124, 21);
            this.dtpreq_date_time.TabIndex = 999;
            this.dtpreq_date_time.Text = "0000-00-00 00:00";
            // 
            // txtsecond_supply_nurse
            // 
            this.txtsecond_supply_nurse.BackColor = System.Drawing.SystemColors.Control;
            this.txtsecond_supply_nurse.Enabled = false;
            this.txtsecond_supply_nurse.Location = new System.Drawing.Point(159, 185);
            this.txtsecond_supply_nurse.MaxLength = 8;
            this.txtsecond_supply_nurse.Name = "txtsecond_supply_nurse";
            this.txtsecond_supply_nurse.Size = new System.Drawing.Size(66, 21);
            this.txtsecond_supply_nurse.TabIndex = 999;
            // 
            // txtfirst_supply_nurse
            // 
            this.txtfirst_supply_nurse.BackColor = System.Drawing.SystemColors.Control;
            this.txtfirst_supply_nurse.Enabled = false;
            this.txtfirst_supply_nurse.Location = new System.Drawing.Point(80, 185);
            this.txtfirst_supply_nurse.MaxLength = 8;
            this.txtfirst_supply_nurse.Name = "txtfirst_supply_nurse";
            this.txtfirst_supply_nurse.Size = new System.Drawing.Size(73, 21);
            this.txtfirst_supply_nurse.TabIndex = 999;
            // 
            // txtsecond_operation_nurse
            // 
            this.txtsecond_operation_nurse.BackColor = System.Drawing.SystemColors.Control;
            this.txtsecond_operation_nurse.Enabled = false;
            this.txtsecond_operation_nurse.Location = new System.Drawing.Point(539, 149);
            this.txtsecond_operation_nurse.MaxLength = 8;
            this.txtsecond_operation_nurse.Name = "txtsecond_operation_nurse";
            this.txtsecond_operation_nurse.Size = new System.Drawing.Size(84, 21);
            this.txtsecond_operation_nurse.TabIndex = 999;
            // 
            // txtfirst_operation_nurse
            // 
            this.txtfirst_operation_nurse.BackColor = System.Drawing.SystemColors.Control;
            this.txtfirst_operation_nurse.Enabled = false;
            this.txtfirst_operation_nurse.Location = new System.Drawing.Point(459, 149);
            this.txtfirst_operation_nurse.MaxLength = 8;
            this.txtfirst_operation_nurse.Name = "txtfirst_operation_nurse";
            this.txtfirst_operation_nurse.Size = new System.Drawing.Size(76, 21);
            this.txtfirst_operation_nurse.TabIndex = 999;
            // 
            // txtblood_tran_doctor
            // 
            this.txtblood_tran_doctor.BackColor = System.Drawing.SystemColors.Control;
            this.txtblood_tran_doctor.Enabled = false;
            this.txtblood_tran_doctor.Location = new System.Drawing.Point(282, 149);
            this.txtblood_tran_doctor.MaxLength = 8;
            this.txtblood_tran_doctor.Name = "txtblood_tran_doctor";
            this.txtblood_tran_doctor.Size = new System.Drawing.Size(70, 21);
            this.txtblood_tran_doctor.TabIndex = 999;
            // 
            // txtsequence
            // 
            this.txtsequence.BackColor = System.Drawing.SystemColors.Control;
            this.txtsequence.Location = new System.Drawing.Point(239, 54);
            this.txtsequence.MaxLength = 2;
            this.txtsequence.Name = "txtsequence";
            this.txtsequence.ReadOnly = true;
            this.txtsequence.Size = new System.Drawing.Size(33, 21);
            this.txtsequence.TabIndex = 999;
            this.txtsequence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsequence_KeyPress);
            // 
            // txtentered_by
            // 
            this.txtentered_by.Location = new System.Drawing.Point(539, 250);
            this.txtentered_by.Name = "txtentered_by";
            this.txtentered_by.ReadOnly = true;
            this.txtentered_by.Size = new System.Drawing.Size(84, 21);
            this.txtentered_by.TabIndex = 999;
            // 
            // txtsurgeon
            // 
            this.txtsurgeon.BackColor = System.Drawing.Color.OldLace;
            this.txtsurgeon.Location = new System.Drawing.Point(539, 89);
            this.txtsurgeon.MaxLength = 8;
            this.txtsurgeon.Name = "txtsurgeon";
            this.txtsurgeon.Size = new System.Drawing.Size(84, 21);
            this.txtsurgeon.TabIndex = 11;
            this.txtsurgeon.Enter += new System.EventHandler(this.txtsurgeon_Enter);
            this.txtsurgeon.Leave += new System.EventHandler(this.txtsurgeon_Leave_1);
            this.txtsurgeon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsurgeon1_KeyPress);
            this.txtsurgeon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsurgeon1_KeyDown);
            // 
            // cmboperating_room_no
            // 
            this.cmboperating_room_no.BackColor = System.Drawing.SystemColors.Control;
            this.cmboperating_room_no.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboperating_room_no.Enabled = false;
            this.cmboperating_room_no.FormattingEnabled = true;
            this.cmboperating_room_no.Location = new System.Drawing.Point(575, 54);
            this.cmboperating_room_no.Name = "cmboperating_room_no";
            this.cmboperating_room_no.Size = new System.Drawing.Size(48, 20);
            this.cmboperating_room_no.TabIndex = 999;
            // 
            // cmboperation_scale
            // 
            this.cmboperation_scale.BackColor = System.Drawing.SystemColors.Control;
            this.cmboperation_scale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboperation_scale.Enabled = false;
            this.cmboperation_scale.FormattingEnabled = true;
            this.cmboperation_scale.Items.AddRange(new object[] {
            "特",
            "大",
            "中",
            "小"});
            this.cmboperation_scale.Location = new System.Drawing.Point(329, 54);
            this.cmboperation_scale.Name = "cmboperation_scale";
            this.cmboperation_scale.Size = new System.Drawing.Size(40, 20);
            this.cmboperation_scale.TabIndex = 999;
            // 
            // cmbanesthesia_method
            // 
            this.cmbanesthesia_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbanesthesia_method.FormattingEnabled = true;
            this.cmbanesthesia_method.Location = new System.Drawing.Point(490, 116);
            this.cmbanesthesia_method.Name = "cmbanesthesia_method";
            this.cmbanesthesia_method.Size = new System.Drawing.Size(133, 20);
            this.cmbanesthesia_method.TabIndex = 16;
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Items.AddRange(new object[] {
            "正常",
            "隔离",
            "放射"});
            this.cmbGroup.Location = new System.Drawing.Point(363, 88);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(93, 20);
            this.cmbGroup.TabIndex = 10;
            this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
            // 
            // cmbisolation_indicator
            // 
            this.cmbisolation_indicator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbisolation_indicator.FormattingEnabled = true;
            this.cmbisolation_indicator.Items.AddRange(new object[] {
            "正常",
            "隔离",
            "放射"});
            this.cmbisolation_indicator.Location = new System.Drawing.Point(79, 86);
            this.cmbisolation_indicator.Name = "cmbisolation_indicator";
            this.cmbisolation_indicator.Size = new System.Drawing.Size(50, 20);
            this.cmbisolation_indicator.TabIndex = 8;
            // 
            // cmboperating_room
            // 
            this.cmboperating_room.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboperating_room.FormattingEnabled = true;
            this.cmboperating_room.Location = new System.Drawing.Point(412, 54);
            this.cmboperating_room.Name = "cmboperating_room";
            this.cmboperating_room.Size = new System.Drawing.Size(121, 20);
            this.cmboperating_room.TabIndex = 100;
            this.cmboperating_room.SelectedIndexChanged += new System.EventHandler(this.cmboperating_room_SelectedIndexChanged);
            // 
            // dtpscheduled_date_time
            // 
            this.dtpscheduled_date_time.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpscheduled_date_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpscheduled_date_time.Location = new System.Drawing.Point(84, 54);
            this.dtpscheduled_date_time.Name = "dtpscheduled_date_time";
            this.dtpscheduled_date_time.Size = new System.Drawing.Size(125, 21);
            this.dtpscheduled_date_time.TabIndex = 6;
            this.dtpscheduled_date_time.ValueChanged += new System.EventHandler(this.dtpscheduled_date_time_ValueChanged);
            this.dtpscheduled_date_time.Leave += new System.EventHandler(this.dtpscheduled_date_time_Leave);
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Enabled = false;
            this.label111.Location = new System.Drawing.Point(25, 154);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(53, 12);
            this.label111.TabIndex = 0;
            this.label111.Text = "麻醉医生";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 222);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(101, 12);
            this.label27.TabIndex = 0;
            this.label27.Text = "诱导期抗生素名称";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Enabled = false;
            this.label25.Location = new System.Drawing.Point(21, 189);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 12);
            this.label25.TabIndex = 0;
            this.label25.Text = "供应护士";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(437, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "麻醉方法";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Enabled = false;
            this.label24.Location = new System.Drawing.Point(399, 152);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 12);
            this.label24.TabIndex = 0;
            this.label24.Text = "台上护士";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Location = new System.Drawing.Point(239, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "输血者";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "台次";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "助手";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(323, 91);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 12);
            this.label26.TabIndex = 0;
            this.label26.Text = "主诊组";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "手术等级";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(480, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "手术医师";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(474, 254);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "申请医师";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(535, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "手术间";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(138, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "手术科室";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "隔离标志";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(415, 221);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 12);
            this.label28.TabIndex = 0;
            this.label28.Text = "剂量";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 254);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 12);
            this.label23.TabIndex = 0;
            this.label23.Text = "手术确认时间";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(417, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "病情";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(219, 254);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 12);
            this.label18.TabIndex = 0;
            this.label18.Text = "申请预约时间";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(372, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 0;
            this.label19.Text = "手术室";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(-3, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 12);
            this.label20.TabIndex = 0;
            this.label20.Text = "手术日期及时间";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(239, 189);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 12);
            this.label21.TabIndex = 0;
            this.label21.Text = "备  注";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "术前诊断";
            // 
            // frmOperationApply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 539);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.sbtnDelete);
            this.Controls.Add(this.sbtnAdd);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.statusBottom);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOperationApply";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "手术申请";
            this.Load += new System.EventHandler(this.frmOperationApply_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPYInput.ResumeLayout(false);
            this.panelPYInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPYInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPYInput)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPat)).EndInit();
            this.statusBottom.ResumeLayout(false);
            this.statusBottom.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcOperaion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOperation)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbDept;
        private Panel panel1;
        private Panel panel2;
        private StatusStrip statusBottom;
        private Panel panel3;
        private TextBox txtSex;
        private Label label5;
        private TextBox txtName;
        private Label label4;
        private TextBox txtINP_NO;
        private Label label3;
        private TextBox txtPatID;
        private Label label2;
        private TextBox txtBED_NO;
        private Label lblBed;
        private TextBox txtAge;
        private Label label6;
        private GridControl gcPat;
        private GridView gvPat;
        private GridColumn BED_NO;
        private GridColumn NAME;
        private SimpleButton sbtnDelete;
        private SimpleButton sbtnAdd;
        private Panel panel4;
        private GridControl gcOperaion;
        private GridView gvOperation;
        private GridColumn OPERATION;
        private GridColumn OPERATION_SCALE;
        private Panel panel5;
        private TextBox txtfourth_assistant;
        private TextBox txtthird_assistant;
        private TextBox txtsecond_assistant;
        private TextBox txtfirst_assistant;
        private TextBox txtnotes_on_operation;
        private TextBox txtdiag_before_operation;
        private TextBox txtpatient_condition;
        private TextBox txtOPERATING_DEPT;
        private TextBox txtblood_tran_doctor;
        private TextBox txtsequence;
        private TextBox txtentered_by;
        private TextBox txtsurgeon;
        private System.Windows.Forms.ComboBox cmboperating_room_no;
        private System.Windows.Forms.ComboBox cmboperation_scale;
        private System.Windows.Forms.ComboBox cmbanesthesia_method;
        private System.Windows.Forms.ComboBox cmbisolation_indicator;
        private System.Windows.Forms.ComboBox cmboperating_room;
        private DateTimePicker dtpscheduled_date_time;
        private Label label13;
        private Label label12;
        private Label label7;
        private Label label11;
        private Label label8;
        private Label label10;
        private Label label16;
        private Label label9;
        private Label label14;
        private Label label15;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private TextBox txtInPut;
        private Panel panelPYInput;
        private GridControl gridPYInput;
        private GridView gridViewPYInput;
        private GridColumn ITEM_NAME;
        private Label lblPyItemName;
        private ToolStripStatusLabel tlstatusBottom;
        private TextBox txtoperating_room;
        private SimpleButton simpleButton4;
        private SimpleButton sbtnSave;
        private GridColumn OPERATION_SCALE1;
        private Label label23;
        private TextBox txtanesthesia_assistant;
        private TextBox txtanesthesia_doctor;
        private Label label111;
        private TextBox txtsecond_supply_nurse;
        private TextBox txtfirst_supply_nurse;
        private TextBox txtsecond_operation_nurse;
        private TextBox txtfirst_operation_nurse;
        private Label label25;
        private Label label24;
        private Label label26;
        private TextBox dtpACK_TIME;
        private TextBox dtpreq_date_time;
        private System.Windows.Forms.ComboBox cmbGroup;
        private Label label27;
        private System.Windows.Forms.ComboBox cmbANTIBIOTIC;
        private TextBox txtDOSAGE;
        private Label label28;
        private CheckBox ckbAll;
        private TextBox txtDeptName;
        private SimpleButton simpleButton1;
    }
}