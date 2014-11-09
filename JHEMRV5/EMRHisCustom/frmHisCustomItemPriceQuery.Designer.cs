using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils;
namespace JHEMR.EMRHisCustom
{
    partial class frmHisCustomItemPriceQuery
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
            this.INSURANCE_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REIMBURSE_LIMIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewYB = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ITEM_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITEM_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CLASSIFY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ORIGIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PROPORTION_NUMERATOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlYB = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.sbtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.cmbYblb = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gcjdmf = new DevExpress.XtraGrid.GridControl();
            this.gvjdmf = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcjb = new DevExpress.XtraGrid.GridControl();
            this.gvjb = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ITEM_NAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITEM_SPEC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UNITS1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PRICE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sbtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.rdgItem = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewYB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlYB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcjdmf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvjdmf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcjb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvjb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgItem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // INSURANCE_TYPE
            // 
            this.INSURANCE_TYPE.Caption = "医保类别";
            this.INSURANCE_TYPE.FieldName = "INSURANCE_TYPE";
            this.INSURANCE_TYPE.Name = "INSURANCE_TYPE";
            this.INSURANCE_TYPE.OptionsColumn.AllowEdit = false;
            this.INSURANCE_TYPE.OptionsColumn.ReadOnly = true;
            this.INSURANCE_TYPE.Visible = true;
            this.INSURANCE_TYPE.VisibleIndex = 0;
            this.INSURANCE_TYPE.Width = 78;
            // 
            // REIMBURSE_LIMIT
            // 
            this.REIMBURSE_LIMIT.Caption = "最高限额";
            this.REIMBURSE_LIMIT.FieldName = "REIMBURSE_LIMIT";
            this.REIMBURSE_LIMIT.Name = "REIMBURSE_LIMIT";
            this.REIMBURSE_LIMIT.OptionsColumn.AllowEdit = false;
            this.REIMBURSE_LIMIT.OptionsColumn.ReadOnly = true;
            this.REIMBURSE_LIMIT.Visible = true;
            this.REIMBURSE_LIMIT.VisibleIndex = 7;
            this.REIMBURSE_LIMIT.Width = 77;
            // 
            // gridViewYB
            // 
            this.gridViewYB.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.INSURANCE_TYPE,
            this.ITEM_NAME,
            this.ITEM_SPEC,
            this.CLASSIFY,
            this.ORIGIN,
            this.REMARK,
            this.PROPORTION_NUMERATOR,
            this.REIMBURSE_LIMIT});
            this.gridViewYB.GridControl = this.gridControlYB;
            this.gridViewYB.Name = "gridViewYB";
            this.gridViewYB.OptionsView.ColumnAutoWidth = false;
            this.gridViewYB.OptionsView.ShowGroupPanel = false;
            // 
            // ITEM_NAME
            // 
            this.ITEM_NAME.Caption = "项目名称";
            this.ITEM_NAME.FieldName = "ITEM_NAME";
            this.ITEM_NAME.Name = "ITEM_NAME";
            this.ITEM_NAME.OptionsColumn.AllowEdit = false;
            this.ITEM_NAME.OptionsColumn.ReadOnly = true;
            this.ITEM_NAME.Visible = true;
            this.ITEM_NAME.VisibleIndex = 1;
            this.ITEM_NAME.Width = 175;
            // 
            // ITEM_SPEC
            // 
            this.ITEM_SPEC.Caption = "规格";
            this.ITEM_SPEC.FieldName = "ITEM_SPEC";
            this.ITEM_SPEC.Name = "ITEM_SPEC";
            this.ITEM_SPEC.OptionsColumn.AllowEdit = false;
            this.ITEM_SPEC.OptionsColumn.ReadOnly = true;
            this.ITEM_SPEC.Visible = true;
            this.ITEM_SPEC.VisibleIndex = 2;
            this.ITEM_SPEC.Width = 83;
            // 
            // CLASSIFY
            // 
            this.CLASSIFY.Caption = "分类";
            this.CLASSIFY.FieldName = "CLASSIFY";
            this.CLASSIFY.Name = "CLASSIFY";
            this.CLASSIFY.OptionsColumn.AllowEdit = false;
            this.CLASSIFY.OptionsColumn.ReadOnly = true;
            this.CLASSIFY.Visible = true;
            this.CLASSIFY.VisibleIndex = 3;
            // 
            // ORIGIN
            // 
            this.ORIGIN.Caption = "来源";
            this.ORIGIN.FieldName = "ORIGIN";
            this.ORIGIN.Name = "ORIGIN";
            this.ORIGIN.OptionsColumn.AllowEdit = false;
            this.ORIGIN.OptionsColumn.ReadOnly = true;
            this.ORIGIN.Visible = true;
            this.ORIGIN.VisibleIndex = 4;
            this.ORIGIN.Width = 60;
            // 
            // REMARK
            // 
            this.REMARK.Caption = "是否限用";
            this.REMARK.FieldName = "REMARK";
            this.REMARK.Name = "REMARK";
            this.REMARK.OptionsColumn.AllowEdit = false;
            this.REMARK.OptionsColumn.ReadOnly = true;
            this.REMARK.Visible = true;
            this.REMARK.VisibleIndex = 5;
            this.REMARK.Width = 72;
            // 
            // PROPORTION_NUMERATOR
            // 
            this.PROPORTION_NUMERATOR.Caption = "自费比例(%)";
            this.PROPORTION_NUMERATOR.DisplayFormat.FormatString = "00.00";
            this.PROPORTION_NUMERATOR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PROPORTION_NUMERATOR.FieldName = "PROPORTION_NUMERATOR";
            this.PROPORTION_NUMERATOR.Name = "PROPORTION_NUMERATOR";
            this.PROPORTION_NUMERATOR.OptionsColumn.AllowEdit = false;
            this.PROPORTION_NUMERATOR.OptionsColumn.ReadOnly = true;
            this.PROPORTION_NUMERATOR.Visible = true;
            this.PROPORTION_NUMERATOR.VisibleIndex = 6;
            this.PROPORTION_NUMERATOR.Width = 98;
            // 
            // gridControlYB
            // 
            this.gridControlYB.EmbeddedNavigator.Name = "";
            this.gridControlYB.Location = new System.Drawing.Point(12, 172);
            this.gridControlYB.MainView = this.gridViewYB;
            this.gridControlYB.Name = "gridControlYB";
            this.gridControlYB.Size = new System.Drawing.Size(684, 347);
            this.gridControlYB.TabIndex = 11;
            this.gridControlYB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewYB,
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlYB;
            this.gridView2.Name = "gridView2";
            // 
            // tsStatusLabel
            // 
            this.tsStatusLabel.ForeColor = System.Drawing.Color.Blue;
            this.tsStatusLabel.Name = "tsStatusLabel";
            this.tsStatusLabel.Size = new System.Drawing.Size(407, 17);
            this.tsStatusLabel.Text = "注释：凡药品规格去最右边一位的‘1’，如0.25g*241 实际规格为0.25g*24";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 522);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(708, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(95, 105);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(262, 21);
            this.txtItem.TabIndex = 3;
            this.txtItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItem_KeyDown);
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(95, 56);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(165, 20);
            this.cmbClass.TabIndex = 2;
            // 
            // sbtnClose
            // 
            this.sbtnClose.Location = new System.Drawing.Point(577, 121);
            this.sbtnClose.Name = "sbtnClose";
            this.sbtnClose.Size = new System.Drawing.Size(84, 24);
            this.sbtnClose.TabIndex = 6;
            this.sbtnClose.Text = "退出";
            this.sbtnClose.Click += new System.EventHandler(this.sbtnClose_Click);
            // 
            // cmbYblb
            // 
            this.cmbYblb.FormattingEnabled = true;
            this.cmbYblb.Location = new System.Drawing.Point(95, 15);
            this.cmbYblb.Name = "cmbYblb";
            this.cmbYblb.Size = new System.Drawing.Size(165, 20);
            this.cmbYblb.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtItem);
            this.panel1.Controls.Add(this.cmbClass);
            this.panel1.Controls.Add(this.cmbYblb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(155, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 143);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "项目名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "项目分类：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "医保类别：";
            // 
            // gcjdmf
            // 
            this.gcjdmf.EmbeddedNavigator.Name = "";
            this.gcjdmf.Location = new System.Drawing.Point(12, 172);
            this.gcjdmf.MainView = this.gvjdmf;
            this.gcjdmf.Name = "gcjdmf";
            this.gcjdmf.Size = new System.Drawing.Size(684, 347);
            this.gcjdmf.TabIndex = 11;
            this.gcjdmf.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvjdmf,
            this.gridView3});
            this.gcjdmf.Visible = false;
            // 
            // gvjdmf
            // 
            this.gvjdmf.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvjdmf.GridControl = this.gcjdmf;
            this.gvjdmf.Name = "gvjdmf";
            this.gvjdmf.OptionsView.ColumnAutoWidth = false;
            this.gvjdmf.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "项目名称";
            this.gridColumn1.FieldName = "ITEM_NAME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 186;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "规格";
            this.gridColumn2.FieldName = "ITEM_SPEC";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 106;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "单位";
            this.gridColumn3.FieldName = "UNITS";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "单价";
            this.gridColumn4.FieldName = "PRICE";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 69;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "自费比例(%)";
            this.gridColumn5.DisplayFormat.FormatString = "00.00";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "PROPORTION_NUMERATOR";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 98;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "最高限额";
            this.gridColumn6.FieldName = "REIMBURSE_LIMIT";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 77;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gcjdmf;
            this.gridView3.Name = "gridView3";
            // 
            // gcjb
            // 
            this.gcjb.EmbeddedNavigator.Name = "";
            this.gcjb.Location = new System.Drawing.Point(12, 172);
            this.gcjb.MainView = this.gvjb;
            this.gcjb.Name = "gcjb";
            this.gcjb.Size = new System.Drawing.Size(684, 347);
            this.gcjb.TabIndex = 11;
            this.gcjb.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvjb,
            this.gridView4});
            this.gcjb.Visible = false;
            // 
            // gvjb
            // 
            this.gvjb.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ITEM_NAME1,
            this.ITEM_SPEC1,
            this.UNITS1,
            this.PRICE1});
            this.gvjb.GridControl = this.gcjb;
            this.gvjb.Name = "gvjb";
            this.gvjb.OptionsView.ColumnAutoWidth = false;
            this.gvjb.OptionsView.ShowGroupPanel = false;
            // 
            // ITEM_NAME1
            // 
            this.ITEM_NAME1.Caption = "项目名称";
            this.ITEM_NAME1.FieldName = "ITEM_NAME";
            this.ITEM_NAME1.Name = "ITEM_NAME1";
            this.ITEM_NAME1.OptionsColumn.AllowEdit = false;
            this.ITEM_NAME1.OptionsColumn.ReadOnly = true;
            this.ITEM_NAME1.Visible = true;
            this.ITEM_NAME1.VisibleIndex = 0;
            this.ITEM_NAME1.Width = 235;
            // 
            // ITEM_SPEC1
            // 
            this.ITEM_SPEC1.Caption = "规格";
            this.ITEM_SPEC1.FieldName = "ITEM_SPEC";
            this.ITEM_SPEC1.Name = "ITEM_SPEC1";
            this.ITEM_SPEC1.OptionsColumn.AllowEdit = false;
            this.ITEM_SPEC1.OptionsColumn.ReadOnly = true;
            this.ITEM_SPEC1.Visible = true;
            this.ITEM_SPEC1.VisibleIndex = 1;
            this.ITEM_SPEC1.Width = 121;
            // 
            // UNITS1
            // 
            this.UNITS1.Caption = "单位";
            this.UNITS1.FieldName = "UNITS";
            this.UNITS1.Name = "UNITS1";
            this.UNITS1.OptionsColumn.AllowEdit = false;
            this.UNITS1.OptionsColumn.ReadOnly = true;
            this.UNITS1.Visible = true;
            this.UNITS1.VisibleIndex = 2;
            // 
            // PRICE1
            // 
            this.PRICE1.Caption = "单价";
            this.PRICE1.FieldName = "PRICE";
            this.PRICE1.Name = "PRICE1";
            this.PRICE1.OptionsColumn.AllowEdit = false;
            this.PRICE1.OptionsColumn.ReadOnly = true;
            this.PRICE1.Visible = true;
            this.PRICE1.VisibleIndex = 3;
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gcjb;
            this.gridView4.Name = "gridView4";
            // 
            // sbtnClear
            // 
            this.sbtnClear.Location = new System.Drawing.Point(577, 74);
            this.sbtnClear.Name = "sbtnClear";
            this.sbtnClear.Size = new System.Drawing.Size(84, 24);
            this.sbtnClear.TabIndex = 5;
            this.sbtnClear.Text = "清屏";
            this.sbtnClear.Click += new System.EventHandler(this.sbtnClear_Click);
            // 
            // sbtnQuery
            // 
            this.sbtnQuery.Location = new System.Drawing.Point(577, 30);
            this.sbtnQuery.Name = "sbtnQuery";
            this.sbtnQuery.Size = new System.Drawing.Size(84, 24);
            this.sbtnQuery.TabIndex = 4;
            this.sbtnQuery.Text = "查询";
            this.sbtnQuery.Click += new System.EventHandler(this.sbtnQuery_Click);
            // 
            // rdgItem
            // 
            this.rdgItem.EditValue = 1;
            this.rdgItem.Location = new System.Drawing.Point(12, 12);
            this.rdgItem.Name = "rdgItem";
            this.rdgItem.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "医疗保险"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "免费医疗"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "价表项目")});
            this.rdgItem.Size = new System.Drawing.Size(112, 143);
            this.rdgItem.TabIndex = 5;
            this.rdgItem.SelectedIndexChanged += new System.EventHandler(this.rdgItem_SelectedIndexChanged);
            // 
            // frmHisCustomItemPriceQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 544);
            this.Controls.Add(this.gcjb);
            this.Controls.Add(this.gcjdmf);
            this.Controls.Add(this.gridControlYB);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.sbtnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sbtnClear);
            this.Controls.Add(this.sbtnQuery);
            this.Controls.Add(this.rdgItem);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHisCustomItemPriceQuery";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "项目价格查询";
            this.Load += new System.EventHandler(this.frmHisCustomItemPriceQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewYB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlYB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcjdmf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvjdmf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcjb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvjb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgItem.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GridColumn INSURANCE_TYPE;
        private GridColumn REIMBURSE_LIMIT;
        private GridView gridViewYB;
        private GridColumn ITEM_NAME;
        private GridColumn ITEM_SPEC;
        private GridColumn CLASSIFY;
        private GridColumn ORIGIN;
        private GridColumn REMARK;
        private GridColumn PROPORTION_NUMERATOR;
        private GridControl gridControlYB;
        private GridView gridView2;
        private ToolStripStatusLabel tsStatusLabel;
        private StatusStrip statusStrip1;
        private TextBox txtItem;
        private System.Windows.Forms.ComboBox cmbClass;
        private SimpleButton sbtnClose;
        private System.Windows.Forms.ComboBox cmbYblb;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private SimpleButton sbtnClear;
        private SimpleButton sbtnQuery;
        private RadioGroup rdgItem;
        private GridControl gcjdmf;
        private GridView gvjdmf;
        private GridColumn gridColumn1;
        private GridColumn gridColumn2;
        private GridColumn gridColumn3;
        private GridColumn gridColumn4;
        private GridColumn gridColumn5;
        private GridColumn gridColumn6;
        private GridView gridView3;
        private GridControl gcjb;
        private GridView gvjb;
        private GridColumn ITEM_NAME1;
        private GridColumn ITEM_SPEC1;
        private GridColumn UNITS1;
        private GridColumn PRICE1;
        private GridView gridView4;
    }
}