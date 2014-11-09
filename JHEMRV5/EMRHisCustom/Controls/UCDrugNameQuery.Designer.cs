using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using DevExpress.XtraGrid.Views.Base;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;
using DevExpress.LookAndFeel;
namespace JHEMR.EMRHisCustom
{
    partial class UCDrugNameQuery
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
            this.tabDrug = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDrug = new System.Windows.Forms.TextBox();
            this.rgPhamNameType = new DevExpress.XtraEditors.RadioGroup();
            this.panelDrug = new System.Windows.Forms.Panel();
            this.gcCode = new DevExpress.XtraGrid.GridControl();
            this.gvCode = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.INPUT_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DRUG_NAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DRUG_CODE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPYM = new System.Windows.Forms.TextBox();
            this.gcDrug = new DevExpress.XtraGrid.GridControl();
            this.gvDrug = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DRUG_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITEM_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UNITS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lblInput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.spbtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.gcNewDrug = new DevExpress.XtraGrid.GridControl();
            this.gvNewDrug = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NEW_DRUG_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NEW_DRUG_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NEW_DRUG_TRADE_PRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NEW_DRUG_RETAIL_PRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NEW_DRUG_FORM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NEW_DRUG_UNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NEW_DRUG_ENTER_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NEW_DRUG_STD_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gcMHData = new DevExpress.XtraGrid.GridControl();
            this.gvMHData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DRUG_NAME2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DRUG_E_NAME2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClearMHData = new System.Windows.Forms.Button();
            this.btnMHSearch = new System.Windows.Forms.Button();
            this.cbBoxFiled2 = new System.Windows.Forms.ComboBox();
            this.cbBoxFiled1 = new System.Windows.Forms.ComboBox();
            this.comboBoxLogic = new System.Windows.Forms.ComboBox();
            this.txtBoxCondition2 = new System.Windows.Forms.TextBox();
            this.txtBoxCondition1 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.trvDrug = new System.Windows.Forms.TreeView();
            this.splitContainerControl4 = new DevExpress.XtraEditors.SplitContainerControl();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panelControlDrugInfo = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gcStorage = new DevExpress.XtraGrid.GridControl();
            this.gridViewStorage = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainerControl5 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl6 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl7 = new DevExpress.XtraEditors.SplitContainerControl();
            this.tabDrug.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgPhamNameType.Properties)).BeginInit();
            this.panelDrug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDrug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDrug)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            this.splitContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNewDrug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNewDrug)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMHData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMHData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl4)).BeginInit();
            this.splitContainerControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlDrugInfo)).BeginInit();
            this.panelControlDrugInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl5)).BeginInit();
            this.splitContainerControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl6)).BeginInit();
            this.splitContainerControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl7)).BeginInit();
            this.splitContainerControl7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDrug
            // 
            this.tabDrug.Controls.Add(this.tabPage1);
            this.tabDrug.Controls.Add(this.tabPage2);
            this.tabDrug.Controls.Add(this.tabPage3);
            this.tabDrug.Controls.Add(this.tabPage4);
            this.tabDrug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDrug.Location = new System.Drawing.Point(0, 0);
            this.tabDrug.Name = "tabDrug";
            this.tabDrug.SelectedIndex = 0;
            this.tabDrug.Size = new System.Drawing.Size(431, 339);
            this.tabDrug.TabIndex = 0;
            this.tabDrug.SelectedIndexChanged += new System.EventHandler(this.tabDrug_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainerControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(423, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "药品查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(3, 3);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtDrug);
            this.splitContainerControl1.Panel1.Controls.Add(this.rgPhamNameType);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.panelDrug);
            this.splitContainerControl1.Panel2.Controls.Add(this.gcDrug);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(417, 308);
            this.splitContainerControl1.SplitterPosition = 33;
            this.splitContainerControl1.TabIndex = 16;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Location = new System.Drawing.Point(268, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(145, 24);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "←光标在此输入框闪烁时，请按F9查询药品名称！";
            // 
            // txtDrug
            // 
            this.txtDrug.BackColor = System.Drawing.Color.OldLace;
            this.txtDrug.Location = new System.Drawing.Point(78, 3);
            this.txtDrug.MaxLength = 80;
            this.txtDrug.Name = "txtDrug";
            this.txtDrug.ReadOnly = true;
            this.txtDrug.Size = new System.Drawing.Size(175, 21);
            this.txtDrug.TabIndex = 8;
            this.txtDrug.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDrug_MouseClick_1);
            this.txtDrug.Leave += new System.EventHandler(this.txtDrug_Leave);
            this.txtDrug.TextChanged += new System.EventHandler(this.txtDrug_TextChanged);
            this.txtDrug.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDrug_KeyDown);
            // 
            // rgPhamNameType
            // 
            this.rgPhamNameType.Location = new System.Drawing.Point(1, -6);
            this.rgPhamNameType.Name = "rgPhamNameType";
            this.rgPhamNameType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "商品名称"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "通用名称")});
            this.rgPhamNameType.Size = new System.Drawing.Size(75, 40);
            this.rgPhamNameType.TabIndex = 15;
            this.rgPhamNameType.SelectedIndexChanged += new System.EventHandler(this.rgPhamNameType_SelectedIndexChanged);
            // 
            // panelDrug
            // 
            this.panelDrug.Controls.Add(this.gcCode);
            this.panelDrug.Controls.Add(this.lblName);
            this.panelDrug.Controls.Add(this.txtPYM);
            this.panelDrug.Location = new System.Drawing.Point(73, 0);
            this.panelDrug.Name = "panelDrug";
            this.panelDrug.Size = new System.Drawing.Size(289, 214);
            this.panelDrug.TabIndex = 12;
            this.panelDrug.Visible = false;
            // 
            // gcCode
            // 
            this.gcCode.EmbeddedNavigator.Name = "";
            this.gcCode.Location = new System.Drawing.Point(6, 31);
            this.gcCode.MainView = this.gvCode;
            this.gcCode.Name = "gcCode";
            this.gcCode.Size = new System.Drawing.Size(279, 180);
            this.gcCode.TabIndex = 3;
            this.gcCode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCode});
            // 
            // gvCode
            // 
            this.gvCode.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.INPUT_CODE,
            this.DRUG_NAME1,
            this.DRUG_CODE1});
            this.gvCode.GridControl = this.gcCode;
            this.gvCode.Name = "gvCode";
            this.gvCode.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvCode.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gvCode.OptionsView.ColumnAutoWidth = false;
            this.gvCode.OptionsView.ShowColumnHeaders = false;
            this.gvCode.OptionsView.ShowGroupPanel = false;
            this.gvCode.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvCode_FocusedRowChanged);
            this.gvCode.DoubleClick += new System.EventHandler(this.gvCode_DoubleClick);
            // 
            // INPUT_CODE
            // 
            this.INPUT_CODE.Caption = "拼音码";
            this.INPUT_CODE.FieldName = "INPUT_CODE";
            this.INPUT_CODE.Name = "INPUT_CODE";
            this.INPUT_CODE.OptionsColumn.AllowEdit = false;
            this.INPUT_CODE.OptionsColumn.ReadOnly = true;
            this.INPUT_CODE.Visible = true;
            this.INPUT_CODE.VisibleIndex = 0;
            this.INPUT_CODE.Width = 80;
            // 
            // DRUG_NAME1
            // 
            this.DRUG_NAME1.Caption = "药品名";
            this.DRUG_NAME1.FieldName = "DRUG_NAME";
            this.DRUG_NAME1.Name = "DRUG_NAME1";
            this.DRUG_NAME1.OptionsColumn.AllowEdit = false;
            this.DRUG_NAME1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.DRUG_NAME1.OptionsColumn.ReadOnly = true;
            this.DRUG_NAME1.Visible = true;
            this.DRUG_NAME1.VisibleIndex = 1;
            this.DRUG_NAME1.Width = 160;
            // 
            // DRUG_CODE1
            // 
            this.DRUG_CODE1.Caption = "编码";
            this.DRUG_CODE1.FieldName = "DRUG_CODE";
            this.DRUG_CODE1.Name = "DRUG_CODE1";
            this.DRUG_CODE1.OptionsColumn.AllowEdit = false;
            this.DRUG_CODE1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.DRUG_CODE1.OptionsColumn.ReadOnly = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(149, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "              ";
            // 
            // txtPYM
            // 
            this.txtPYM.Location = new System.Drawing.Point(4, 4);
            this.txtPYM.Name = "txtPYM";
            this.txtPYM.Size = new System.Drawing.Size(139, 21);
            this.txtPYM.TabIndex = 0;
            this.txtPYM.TextChanged += new System.EventHandler(this.txtPYM_TextChanged);
            this.txtPYM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPYM_KeyDown);
            // 
            // gcDrug
            // 
            this.gcDrug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDrug.EmbeddedNavigator.Name = "";
            this.gcDrug.Location = new System.Drawing.Point(0, 0);
            this.gcDrug.MainView = this.gvDrug;
            this.gcDrug.Name = "gcDrug";
            this.gcDrug.Size = new System.Drawing.Size(413, 265);
            this.gcDrug.TabIndex = 10;
            this.gcDrug.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDrug});
            // 
            // gvDrug
            // 
            this.gvDrug.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DRUG_NAME,
            this.ITEM_SPEC,
            this.UNITS,
            this.PRICE});
            this.gvDrug.GridControl = this.gcDrug;
            this.gvDrug.Name = "gvDrug";
            this.gvDrug.OptionsView.ColumnAutoWidth = false;
            this.gvDrug.OptionsView.ShowGroupPanel = false;
            this.gvDrug.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDrug_FocusedRowChanged);
            // 
            // DRUG_NAME
            // 
            this.DRUG_NAME.Caption = "药品通用名称";
            this.DRUG_NAME.FieldName = "DRUG_NAME";
            this.DRUG_NAME.Name = "DRUG_NAME";
            this.DRUG_NAME.OptionsColumn.AllowEdit = false;
            this.DRUG_NAME.OptionsColumn.ReadOnly = true;
            this.DRUG_NAME.Visible = true;
            this.DRUG_NAME.VisibleIndex = 0;
            this.DRUG_NAME.Width = 200;
            // 
            // ITEM_SPEC
            // 
            this.ITEM_SPEC.Caption = "规格";
            this.ITEM_SPEC.FieldName = "ITEM_SPEC";
            this.ITEM_SPEC.Name = "ITEM_SPEC";
            this.ITEM_SPEC.OptionsColumn.AllowEdit = false;
            this.ITEM_SPEC.OptionsColumn.ReadOnly = true;
            this.ITEM_SPEC.Visible = true;
            this.ITEM_SPEC.VisibleIndex = 1;
            this.ITEM_SPEC.Width = 100;
            // 
            // UNITS
            // 
            this.UNITS.Caption = "单位";
            this.UNITS.FieldName = "UNITS";
            this.UNITS.Name = "UNITS";
            this.UNITS.OptionsColumn.AllowEdit = false;
            this.UNITS.OptionsColumn.ReadOnly = true;
            this.UNITS.Visible = true;
            this.UNITS.VisibleIndex = 2;
            this.UNITS.Width = 50;
            // 
            // PRICE
            // 
            this.PRICE.Caption = "价格";
            this.PRICE.FieldName = "PRICE";
            this.PRICE.Name = "PRICE";
            this.PRICE.OptionsColumn.AllowEdit = false;
            this.PRICE.OptionsColumn.ReadOnly = true;
            this.PRICE.Visible = true;
            this.PRICE.VisibleIndex = 3;
            this.PRICE.Width = 60;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainerControl3);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(423, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "新进药品查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Horizontal = false;
            this.splitContainerControl3.Location = new System.Drawing.Point(3, 3);
            this.splitContainerControl3.Name = "splitContainerControl3";
            this.splitContainerControl3.Panel1.Controls.Add(this.lblInput);
            this.splitContainerControl3.Panel1.Controls.Add(this.label2);
            this.splitContainerControl3.Panel1.Controls.Add(this.dtpEnd);
            this.splitContainerControl3.Panel1.Controls.Add(this.spbtnClear);
            this.splitContainerControl3.Panel1.Controls.Add(this.spbtnQuery);
            this.splitContainerControl3.Panel1.Controls.Add(this.dtpStart);
            this.splitContainerControl3.Panel1.Text = "Panel1";
            this.splitContainerControl3.Panel2.Controls.Add(this.gcNewDrug);
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(417, 308);
            this.splitContainerControl3.SplitterPosition = 32;
            this.splitContainerControl3.TabIndex = 5;
            this.splitContainerControl3.Text = "splitContainerControl3";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(0, 9);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(77, 12);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "检索时间段：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "～";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(184, 5);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(85, 21);
            this.dtpEnd.TabIndex = 1;
            // 
            // spbtnClear
            // 
            this.spbtnClear.Location = new System.Drawing.Point(347, 4);
            this.spbtnClear.Name = "spbtnClear";
            this.spbtnClear.Size = new System.Drawing.Size(64, 23);
            this.spbtnClear.TabIndex = 2;
            this.spbtnClear.Text = "清屏(&C)";
            this.spbtnClear.Click += new System.EventHandler(this.spbtnClose_Click);
            // 
            // spbtnQuery
            // 
            this.spbtnQuery.Location = new System.Drawing.Point(275, 4);
            this.spbtnQuery.Name = "spbtnQuery";
            this.spbtnQuery.Size = new System.Drawing.Size(65, 23);
            this.spbtnQuery.TabIndex = 2;
            this.spbtnQuery.Text = "检索(&Q)";
            this.spbtnQuery.Click += new System.EventHandler(this.spbtnQuery_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(76, 5);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(83, 21);
            this.dtpStart.TabIndex = 1;
            // 
            // gcNewDrug
            // 
            this.gcNewDrug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNewDrug.EmbeddedNavigator.Name = "";
            this.gcNewDrug.Location = new System.Drawing.Point(0, 0);
            this.gcNewDrug.MainView = this.gvNewDrug;
            this.gcNewDrug.Name = "gcNewDrug";
            this.gcNewDrug.Size = new System.Drawing.Size(413, 266);
            this.gcNewDrug.TabIndex = 3;
            this.gcNewDrug.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNewDrug});
            // 
            // gvNewDrug
            // 
            this.gvNewDrug.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NEW_DRUG_NAME,
            this.NEW_DRUG_SPEC,
            this.NEW_DRUG_TRADE_PRICE,
            this.NEW_DRUG_RETAIL_PRICE,
            this.NEW_DRUG_FORM,
            this.NEW_DRUG_UNIT,
            this.NEW_DRUG_ENTER_DATE,
            this.NEW_DRUG_STD_CODE});
            this.gvNewDrug.GridControl = this.gcNewDrug;
            this.gvNewDrug.GroupPanelText = "可以托数据网格中一列或多列对数据进行分组";
            this.gvNewDrug.Name = "gvNewDrug";
            this.gvNewDrug.OptionsView.ColumnAutoWidth = false;
            this.gvNewDrug.OptionsView.ShowGroupPanel = false;
            this.gvNewDrug.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvNewDrug_FocusedRowChanged);
            // 
            // NEW_DRUG_NAME
            // 
            this.NEW_DRUG_NAME.Caption = "药品名称";
            this.NEW_DRUG_NAME.FieldName = "DRUG_NAME";
            this.NEW_DRUG_NAME.Name = "NEW_DRUG_NAME";
            this.NEW_DRUG_NAME.OptionsColumn.ReadOnly = true;
            this.NEW_DRUG_NAME.Visible = true;
            this.NEW_DRUG_NAME.VisibleIndex = 0;
            this.NEW_DRUG_NAME.Width = 181;
            // 
            // NEW_DRUG_SPEC
            // 
            this.NEW_DRUG_SPEC.Caption = "药品规格";
            this.NEW_DRUG_SPEC.FieldName = "DRUG_SPEC";
            this.NEW_DRUG_SPEC.Name = "NEW_DRUG_SPEC";
            this.NEW_DRUG_SPEC.OptionsColumn.ReadOnly = true;
            this.NEW_DRUG_SPEC.Visible = true;
            this.NEW_DRUG_SPEC.VisibleIndex = 1;
            this.NEW_DRUG_SPEC.Width = 149;
            // 
            // NEW_DRUG_TRADE_PRICE
            // 
            this.NEW_DRUG_TRADE_PRICE.Caption = "批发价";
            this.NEW_DRUG_TRADE_PRICE.FieldName = "DRUG_TRADE_PRICE";
            this.NEW_DRUG_TRADE_PRICE.Name = "NEW_DRUG_TRADE_PRICE";
            this.NEW_DRUG_TRADE_PRICE.OptionsColumn.ReadOnly = true;
            this.NEW_DRUG_TRADE_PRICE.Visible = true;
            this.NEW_DRUG_TRADE_PRICE.VisibleIndex = 2;
            this.NEW_DRUG_TRADE_PRICE.Width = 60;
            // 
            // NEW_DRUG_RETAIL_PRICE
            // 
            this.NEW_DRUG_RETAIL_PRICE.Caption = "零售价";
            this.NEW_DRUG_RETAIL_PRICE.FieldName = "DRUG_RETAIL_PRICE";
            this.NEW_DRUG_RETAIL_PRICE.Name = "NEW_DRUG_RETAIL_PRICE";
            this.NEW_DRUG_RETAIL_PRICE.OptionsColumn.ReadOnly = true;
            this.NEW_DRUG_RETAIL_PRICE.Visible = true;
            this.NEW_DRUG_RETAIL_PRICE.VisibleIndex = 3;
            this.NEW_DRUG_RETAIL_PRICE.Width = 60;
            // 
            // NEW_DRUG_FORM
            // 
            this.NEW_DRUG_FORM.Caption = "剂型";
            this.NEW_DRUG_FORM.FieldName = "DRUG_FORM";
            this.NEW_DRUG_FORM.Name = "NEW_DRUG_FORM";
            this.NEW_DRUG_FORM.OptionsColumn.ReadOnly = true;
            this.NEW_DRUG_FORM.Visible = true;
            this.NEW_DRUG_FORM.VisibleIndex = 4;
            this.NEW_DRUG_FORM.Width = 40;
            // 
            // NEW_DRUG_UNIT
            // 
            this.NEW_DRUG_UNIT.Caption = "单位";
            this.NEW_DRUG_UNIT.FieldName = "DRUG_UNIT";
            this.NEW_DRUG_UNIT.Name = "NEW_DRUG_UNIT";
            this.NEW_DRUG_UNIT.OptionsColumn.ReadOnly = true;
            this.NEW_DRUG_UNIT.Visible = true;
            this.NEW_DRUG_UNIT.VisibleIndex = 5;
            this.NEW_DRUG_UNIT.Width = 40;
            // 
            // NEW_DRUG_ENTER_DATE
            // 
            this.NEW_DRUG_ENTER_DATE.Caption = "新药日期";
            this.NEW_DRUG_ENTER_DATE.FieldName = "DRUG_ENTER_DATE";
            this.NEW_DRUG_ENTER_DATE.Name = "NEW_DRUG_ENTER_DATE";
            this.NEW_DRUG_ENTER_DATE.OptionsColumn.ReadOnly = true;
            this.NEW_DRUG_ENTER_DATE.Visible = true;
            this.NEW_DRUG_ENTER_DATE.VisibleIndex = 6;
            this.NEW_DRUG_ENTER_DATE.Width = 60;
            // 
            // NEW_DRUG_STD_CODE
            // 
            this.NEW_DRUG_STD_CODE.Caption = "药品编码";
            this.NEW_DRUG_STD_CODE.FieldName = "DRUG_STD_CODE";
            this.NEW_DRUG_STD_CODE.Name = "NEW_DRUG_STD_CODE";
            this.NEW_DRUG_STD_CODE.OptionsColumn.ReadOnly = true;
            this.NEW_DRUG_STD_CODE.Visible = true;
            this.NEW_DRUG_STD_CODE.VisibleIndex = 7;
            this.NEW_DRUG_STD_CODE.Width = 60;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gcMHData);
            this.tabPage3.Controls.Add(this.groupControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(423, 314);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "模糊查询";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gcMHData
            // 
            this.gcMHData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMHData.EmbeddedNavigator.Name = "";
            this.gcMHData.Location = new System.Drawing.Point(3, 77);
            this.gcMHData.MainView = this.gvMHData;
            this.gcMHData.Name = "gcMHData";
            this.gcMHData.Size = new System.Drawing.Size(417, 234);
            this.gcMHData.TabIndex = 4;
            this.gcMHData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMHData});
            // 
            // gvMHData
            // 
            this.gvMHData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DRUG_NAME2,
            this.DRUG_E_NAME2});
            this.gvMHData.GridControl = this.gcMHData;
            this.gvMHData.Name = "gvMHData";
            this.gvMHData.OptionsView.ShowGroupPanel = false;
            this.gvMHData.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvMHData_FocusedRowChanged);
            // 
            // DRUG_NAME2
            // 
            this.DRUG_NAME2.Caption = "药物名称";
            this.DRUG_NAME2.FieldName = "DRUG_NAME";
            this.DRUG_NAME2.Name = "DRUG_NAME2";
            this.DRUG_NAME2.Visible = true;
            this.DRUG_NAME2.VisibleIndex = 1;
            // 
            // DRUG_E_NAME2
            // 
            this.DRUG_E_NAME2.Caption = "药物英文名";
            this.DRUG_E_NAME2.FieldName = "DRUG_E_NAME";
            this.DRUG_E_NAME2.Name = "DRUG_E_NAME2";
            this.DRUG_E_NAME2.Visible = true;
            this.DRUG_E_NAME2.VisibleIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClearMHData);
            this.groupControl1.Controls.Add(this.btnMHSearch);
            this.groupControl1.Controls.Add(this.cbBoxFiled2);
            this.groupControl1.Controls.Add(this.cbBoxFiled1);
            this.groupControl1.Controls.Add(this.comboBoxLogic);
            this.groupControl1.Controls.Add(this.txtBoxCondition2);
            this.groupControl1.Controls.Add(this.txtBoxCondition1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(50);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(417, 74);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "搜索内容";
            // 
            // btnClearMHData
            // 
            this.btnClearMHData.Location = new System.Drawing.Point(363, 47);
            this.btnClearMHData.Name = "btnClearMHData";
            this.btnClearMHData.Size = new System.Drawing.Size(52, 23);
            this.btnClearMHData.TabIndex = 6;
            this.btnClearMHData.Text = "清屏";
            this.btnClearMHData.UseVisualStyleBackColor = true;
            this.btnClearMHData.Click += new System.EventHandler(this.btnClearMHData_Click);
            // 
            // btnMHSearch
            // 
            this.btnMHSearch.Location = new System.Drawing.Point(308, 47);
            this.btnMHSearch.Name = "btnMHSearch";
            this.btnMHSearch.Size = new System.Drawing.Size(52, 23);
            this.btnMHSearch.TabIndex = 5;
            this.btnMHSearch.Text = "查询";
            this.btnMHSearch.UseVisualStyleBackColor = true;
            this.btnMHSearch.Click += new System.EventHandler(this.btnMHSearch_Click);
            // 
            // cbBoxFiled2
            // 
            this.cbBoxFiled2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxFiled2.FormattingEnabled = true;
            this.cbBoxFiled2.Items.AddRange(new object[] {
            "英文名",
            "适应症",
            "药物相互作用",
            "不良反应",
            "注意事项",
            "禁忌症",
            "药物名称"});
            this.cbBoxFiled2.Location = new System.Drawing.Point(3, 46);
            this.cbBoxFiled2.Name = "cbBoxFiled2";
            this.cbBoxFiled2.Size = new System.Drawing.Size(99, 20);
            this.cbBoxFiled2.TabIndex = 3;
            // 
            // cbBoxFiled1
            // 
            this.cbBoxFiled1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxFiled1.FormattingEnabled = true;
            this.cbBoxFiled1.Items.AddRange(new object[] {
            "英文名",
            "适应症",
            "药物相互作用",
            "不良反应",
            "注意事项",
            "禁忌症",
            "药物名称"});
            this.cbBoxFiled1.Location = new System.Drawing.Point(3, 24);
            this.cbBoxFiled1.Name = "cbBoxFiled1";
            this.cbBoxFiled1.Size = new System.Drawing.Size(99, 20);
            this.cbBoxFiled1.TabIndex = 0;
            // 
            // comboBoxLogic
            // 
            this.comboBoxLogic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLogic.FormattingEnabled = true;
            this.comboBoxLogic.Items.AddRange(new object[] {
            "和",
            "或"});
            this.comboBoxLogic.Location = new System.Drawing.Point(308, 24);
            this.comboBoxLogic.Name = "comboBoxLogic";
            this.comboBoxLogic.Size = new System.Drawing.Size(75, 20);
            this.comboBoxLogic.TabIndex = 2;
            // 
            // txtBoxCondition2
            // 
            this.txtBoxCondition2.Location = new System.Drawing.Point(106, 46);
            this.txtBoxCondition2.Name = "txtBoxCondition2";
            this.txtBoxCondition2.Size = new System.Drawing.Size(198, 21);
            this.txtBoxCondition2.TabIndex = 4;
            // 
            // txtBoxCondition1
            // 
            this.txtBoxCondition1.Location = new System.Drawing.Point(106, 23);
            this.txtBoxCondition1.Name = "txtBoxCondition1";
            this.txtBoxCondition1.Size = new System.Drawing.Size(198, 21);
            this.txtBoxCondition1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.trvDrug);
            this.tabPage4.Location = new System.Drawing.Point(4, 21);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(423, 314);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "类别查询";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // trvDrug
            // 
            this.trvDrug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvDrug.Location = new System.Drawing.Point(0, 0);
            this.trvDrug.Name = "trvDrug";
            this.trvDrug.Size = new System.Drawing.Size(423, 314);
            this.trvDrug.TabIndex = 0;
            this.trvDrug.DoubleClick += new System.EventHandler(this.trvDrug_DoubleClick);
            this.trvDrug.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvDrug_NodeMouseClick);
            // 
            // splitContainerControl4
            // 
            this.splitContainerControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl4.Horizontal = false;
            this.splitContainerControl4.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl4.Name = "splitContainerControl4";
            this.splitContainerControl4.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.splitContainerControl4.Panel1.Controls.Add(this.richTextBox3);
            this.splitContainerControl4.Panel1.Text = "Panel1";
            this.splitContainerControl4.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.splitContainerControl4.Panel2.Controls.Add(this.groupControl3);
            this.splitContainerControl4.Panel2.Text = "Panel2";
            this.splitContainerControl4.Size = new System.Drawing.Size(427, 339);
            this.splitContainerControl4.SplitterPosition = 72;
            this.splitContainerControl4.TabIndex = 14;
            this.splitContainerControl4.Text = "splitContainerControl4";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox3.ForeColor = System.Drawing.Color.DarkRed;
            this.richTextBox3.Location = new System.Drawing.Point(0, 0);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(427, 72);
            this.richTextBox3.TabIndex = 0;
            this.richTextBox3.Text = "";
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BorderColor = System.Drawing.Color.White;
            this.groupControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.groupControl3.Appearance.Options.UseBorderColor = true;
            this.groupControl3.Appearance.Options.UseFont = true;
            this.groupControl3.Appearance.Options.UseForeColor = true;
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl3.AutoSize = true;
            this.groupControl3.Controls.Add(this.richTextBox2);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(427, 261);
            this.groupControl3.TabIndex = 13;
            this.groupControl3.Text = "药品信息↓↓↓       特别注意↑↑↑       ";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox2.Location = new System.Drawing.Point(2, 22);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(423, 237);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // panelControlDrugInfo
            // 
            this.panelControlDrugInfo.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControlDrugInfo.Appearance.Options.UseBackColor = true;
            this.panelControlDrugInfo.Controls.Add(this.label1);
            this.panelControlDrugInfo.Controls.Add(this.textBox6);
            this.panelControlDrugInfo.Controls.Add(this.labelControl7);
            this.panelControlDrugInfo.Controls.Add(this.textBox5);
            this.panelControlDrugInfo.Controls.Add(this.textBox4);
            this.panelControlDrugInfo.Controls.Add(this.textBox3);
            this.panelControlDrugInfo.Controls.Add(this.textBox2);
            this.panelControlDrugInfo.Controls.Add(this.textBox1);
            this.panelControlDrugInfo.Controls.Add(this.labelControl6);
            this.panelControlDrugInfo.Controls.Add(this.labelControl5);
            this.panelControlDrugInfo.Controls.Add(this.labelControl4);
            this.panelControlDrugInfo.Controls.Add(this.labelControl3);
            this.panelControlDrugInfo.Controls.Add(this.labelControl2);
            this.panelControlDrugInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlDrugInfo.Location = new System.Drawing.Point(0, 0);
            this.panelControlDrugInfo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.panelControlDrugInfo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControlDrugInfo.Name = "panelControlDrugInfo";
            this.panelControlDrugInfo.Size = new System.Drawing.Size(432, 101);
            this.panelControlDrugInfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(36, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = " ";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(201, 50);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(177, 21);
            this.textBox6.TabIndex = 11;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(384, 53);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(12, 14);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "类";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(346, 27);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(50, 21);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(95, 75);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(301, 21);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(95, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(95, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 21);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(95, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 21);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(323, 30);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(17, 14);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "元/";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(32, 75);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(0, 21);
            this.labelControl5.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(32, 53);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "管理类别：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(32, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "零售价格：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(56, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "剂型：";
            // 
            // gcStorage
            // 
            this.gcStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcStorage.EmbeddedNavigator.Name = "";
            this.gcStorage.Location = new System.Drawing.Point(0, 0);
            this.gcStorage.MainView = this.gridViewStorage;
            this.gcStorage.Name = "gcStorage";
            this.gcStorage.Size = new System.Drawing.Size(426, 101);
            this.gcStorage.TabIndex = 0;
            this.gcStorage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStorage});
            // 
            // gridViewStorage
            // 
            this.gridViewStorage.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridViewStorage.GridControl = this.gcStorage;
            this.gridViewStorage.Name = "gridViewStorage";
            this.gridViewStorage.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "药房";
            this.gridColumn1.FieldName = "DEPT_NAME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "库存量";
            this.gridColumn2.FieldName = "QUANTITY";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // splitContainerControl5
            // 
            this.splitContainerControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl5.Horizontal = false;
            this.splitContainerControl5.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl5.Name = "splitContainerControl5";
            this.splitContainerControl5.Panel1.Controls.Add(this.splitContainerControl6);
            this.splitContainerControl5.Panel1.Text = "Panel1";
            this.splitContainerControl5.Panel2.Controls.Add(this.splitContainerControl7);
            this.splitContainerControl5.Panel2.Text = "Panel2";
            this.splitContainerControl5.Size = new System.Drawing.Size(868, 454);
            this.splitContainerControl5.SplitterPosition = 105;
            this.splitContainerControl5.TabIndex = 1;
            this.splitContainerControl5.Text = "splitContainerControl5";
            // 
            // splitContainerControl6
            // 
            this.splitContainerControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl6.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl6.Name = "splitContainerControl6";
            this.splitContainerControl6.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.splitContainerControl6.Panel1.Controls.Add(this.panelControlDrugInfo);
            this.splitContainerControl6.Panel1.Text = "Panel1";
            this.splitContainerControl6.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.splitContainerControl6.Panel2.Controls.Add(this.gcStorage);
            this.splitContainerControl6.Panel2.Text = "Panel2";
            this.splitContainerControl6.Size = new System.Drawing.Size(864, 101);
            this.splitContainerControl6.SplitterPosition = 432;
            this.splitContainerControl6.TabIndex = 0;
            this.splitContainerControl6.Text = "splitContainerControl6";
            // 
            // splitContainerControl7
            // 
            this.splitContainerControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl7.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl7.Name = "splitContainerControl7";
            this.splitContainerControl7.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.splitContainerControl7.Panel1.Controls.Add(this.tabDrug);
            this.splitContainerControl7.Panel1.Text = "Panel1";
            this.splitContainerControl7.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.splitContainerControl7.Panel2.Controls.Add(this.splitContainerControl4);
            this.splitContainerControl7.Panel2.Text = "Panel2";
            this.splitContainerControl7.Size = new System.Drawing.Size(864, 339);
            this.splitContainerControl7.SplitterPosition = 431;
            this.splitContainerControl7.TabIndex = 1;
            this.splitContainerControl7.Text = "splitContainerControl7";
            // 
            // UCDrugNameQuery
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.splitContainerControl5);
            this.Name = "UCDrugNameQuery";
            this.Size = new System.Drawing.Size(868, 454);
            this.Load += new System.EventHandler(this.UCDrugNameQuery_Load);
            this.tabDrug.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgPhamNameType.Properties)).EndInit();
            this.panelDrug.ResumeLayout(false);
            this.panelDrug.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDrug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDrug)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNewDrug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNewDrug)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMHData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMHData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl4)).EndInit();
            this.splitContainerControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlDrugInfo)).EndInit();
            this.panelControlDrugInfo.ResumeLayout(false);
            this.panelControlDrugInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl5)).EndInit();
            this.splitContainerControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl6)).EndInit();
            this.splitContainerControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl7)).EndInit();
            this.splitContainerControl7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl tabDrug;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panelDrug;
        private GridControl gcCode;
        private GridView gvCode;
        private GridColumn INPUT_CODE;
        private GridColumn DRUG_NAME1;
        private GridColumn DRUG_CODE1;
        private Label lblName;
        private TextBox txtPYM;
        private GridControl gcDrug;
        private GridView gvDrug;
        private GridColumn DRUG_NAME;
        private GridColumn ITEM_SPEC;
        private GridColumn UNITS;
        private GridColumn PRICE;
        private TextBox txtDrug;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private Label label2;
        private Label lblInput;
        private SimpleButton spbtnClear;
        private SimpleButton spbtnQuery;
        private GridControl gcNewDrug;
        private GridView gvNewDrug;
        private GridColumn NEW_DRUG_NAME;
        private GridColumn NEW_DRUG_SPEC;
        private GridColumn NEW_DRUG_TRADE_PRICE;
        private GridColumn NEW_DRUG_RETAIL_PRICE;
        private GridColumn NEW_DRUG_FORM;
        private GridColumn NEW_DRUG_UNIT;
        private GridColumn NEW_DRUG_ENTER_DATE;
        private GridColumn NEW_DRUG_STD_CODE;
        private TabPage tabPage3;
        private GroupControl groupControl1;
        private Button btnClearMHData;
        private Button btnMHSearch;
        private System.Windows.Forms.ComboBox comboBoxLogic;
        private TextBox txtBoxCondition2;
        private TextBox txtBoxCondition1;
        private System.Windows.Forms.ComboBox cbBoxFiled1;
        private System.Windows.Forms.ComboBox cbBoxFiled2;
        private GridControl gcMHData;
        private GroupControl groupControl3;
        private RichTextBox richTextBox2;
        private LabelControl labelControl1;
        private GridView gvMHData;
        private GridColumn DRUG_E_NAME2;
        private GridColumn DRUG_NAME2;
        private RadioGroup rgPhamNameType;
        private TabPage tabPage4;
        private TreeView trvDrug;
        private ImageList imageList1;
        private SplitContainerControl splitContainerControl4;
        private GridControl gcStorage;
        private GridView gridViewStorage;
        private PanelControl panelControlDrugInfo;
        private LabelControl labelControl5;
        private LabelControl labelControl4;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private LabelControl labelControl6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private LabelControl labelControl7;
        private TextBox textBox6;
        private GridColumn gridColumn1;
        private GridColumn gridColumn2;
        private SplitContainerControl splitContainerControl5;
        private SplitContainerControl splitContainerControl6;
        private RichTextBox richTextBox3;
        private SplitContainerControl splitContainerControl3;
        private SplitContainerControl splitContainerControl7;
        private SplitContainerControl splitContainerControl1;
        private Label label1;
    }
}
