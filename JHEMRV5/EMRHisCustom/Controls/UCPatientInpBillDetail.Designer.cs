using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraTab;
using System.Windows.Forms;
using System;
using System.ComponentModel;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.Data;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
namespace JHEMR.EMRHisCustom
{
    partial class UCPatientInpBillDetail
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
            this.gridInpBillDetail = new DevExpress.XtraGrid.GridControl();
            this.gridViewInpBillDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpOrderClass = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UNITS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrepayments = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridOrderClassBill = new DevExpress.XtraGrid.GridControl();
            this.gridViewOrderClassBill = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridInpBillDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInpBillDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpOrderClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderClassBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderClassBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridInpBillDetail
            // 
            this.gridInpBillDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridInpBillDetail.EmbeddedNavigator.Name = "";
            this.gridInpBillDetail.Location = new System.Drawing.Point(0, 0);
            this.gridInpBillDetail.MainView = this.gridViewInpBillDetail;
            this.gridInpBillDetail.Name = "gridInpBillDetail";
            this.gridInpBillDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpOrderClass});
            this.gridInpBillDetail.Size = new System.Drawing.Size(634, 359);
            this.gridInpBillDetail.TabIndex = 0;
            this.gridInpBillDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInpBillDetail});
            // 
            // gridViewInpBillDetail
            // 
            this.gridViewInpBillDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.UNITS,
            this.AMOUNT,
            this.gridColumn4,
            this.gridColumn5});
            this.gridViewInpBillDetail.CustomizationFormBounds = new System.Drawing.Rectangle(802, 471, 208, 177);
            this.gridViewInpBillDetail.GridControl = this.gridInpBillDetail;
            this.gridViewInpBillDetail.GroupCount = 1;
            this.gridViewInpBillDetail.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CHARGES", null, "\"{0:#.##}元\""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "CHARGES", null, "\"{0:#0}条\"")});
            this.gridViewInpBillDetail.Name = "gridViewInpBillDetail";
            this.gridViewInpBillDetail.OptionsView.AllowCellMerge = true;
            this.gridViewInpBillDetail.OptionsView.ColumnAutoWidth = false;
            this.gridViewInpBillDetail.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Standard;
            this.gridViewInpBillDetail.OptionsView.ShowFooter = true;
            this.gridViewInpBillDetail.OptionsView.ShowGroupPanel = false;
            this.gridViewInpBillDetail.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "类别";
            this.gridColumn1.ColumnEdit = this.repositoryItemLookUpOrderClass;
            this.gridColumn1.FieldName = "ITEM_CLASS";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.gridColumn1.Width = 40;
            // 
            // repositoryItemLookUpOrderClass
            // 
            this.repositoryItemLookUpOrderClass.AutoHeight = false;
            this.repositoryItemLookUpOrderClass.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.repositoryItemLookUpOrderClass.DisplayMember = "ORDER_CLASS_NAME";
            this.repositoryItemLookUpOrderClass.Name = "repositoryItemLookUpOrderClass";
            this.repositoryItemLookUpOrderClass.ReadOnly = true;
            this.repositoryItemLookUpOrderClass.ValueMember = "ORDER_CLASS";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "项目名称";
            this.gridColumn2.FieldName = "ITEM_NAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 177;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "规格";
            this.gridColumn3.FieldName = "ITEM_SPEC";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 118;
            // 
            // UNITS
            // 
            this.UNITS.Caption = "单位";
            this.UNITS.FieldName = "UNITS";
            this.UNITS.Name = "UNITS";
            this.UNITS.Visible = true;
            this.UNITS.VisibleIndex = 4;
            // 
            // AMOUNT
            // 
            this.AMOUNT.Caption = "数量";
            this.AMOUNT.FieldName = "AMOUNT";
            this.AMOUNT.Name = "AMOUNT";
            this.AMOUNT.Visible = true;
            this.AMOUNT.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "计价(元)";
            this.gridColumn4.FieldName = "COSTS";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn4.OptionsFilter.AllowFilter = false;
            this.gridColumn4.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.gridColumn4.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 81;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "应收(元)";
            this.gridColumn5.FieldName = "CHARGES";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn5.OptionsFilter.AllowFilter = false;
            this.gridColumn5.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.gridColumn5.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 81;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 400);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "预交金余额(元)：";
            // 
            // txtPrepayments
            // 
            this.txtPrepayments.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.txtPrepayments.Appearance.Options.UseForeColor = true;
            this.txtPrepayments.Location = new System.Drawing.Point(122, 400);
            this.txtPrepayments.Name = "txtPrepayments";
            this.txtPrepayments.Size = new System.Drawing.Size(25, 14);
            this.txtPrepayments.TabIndex = 2;
            this.txtPrepayments.Text = "0.00";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 3);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(643, 391);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.Text = "xtraTabControl1";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridOrderClassBill);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(634, 359);
            this.xtraTabPage1.Text = "费用分类总计";
            // 
            // gridOrderClassBill
            // 
            this.gridOrderClassBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOrderClassBill.EmbeddedNavigator.Name = "";
            this.gridOrderClassBill.Location = new System.Drawing.Point(0, 0);
            this.gridOrderClassBill.MainView = this.gridViewOrderClassBill;
            this.gridOrderClassBill.Name = "gridOrderClassBill";
            this.gridOrderClassBill.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridOrderClassBill.Size = new System.Drawing.Size(634, 359);
            this.gridOrderClassBill.TabIndex = 0;
            this.gridOrderClassBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrderClassBill});
            // 
            // gridViewOrderClassBill
            // 
            this.gridViewOrderClassBill.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gridViewOrderClassBill.CustomizationFormBounds = new System.Drawing.Rectangle(537, 351, 208, 177);
            this.gridViewOrderClassBill.GridControl = this.gridOrderClassBill;
            this.gridViewOrderClassBill.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "CHARGE", null, "\"{0:#.##}元\"")});
            this.gridViewOrderClassBill.Name = "gridViewOrderClassBill";
            this.gridViewOrderClassBill.OptionsView.ColumnAutoWidth = false;
            this.gridViewOrderClassBill.OptionsView.ShowFooter = true;
            this.gridViewOrderClassBill.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "费别";
            this.gridColumn6.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.gridColumn6.FieldName = "ITEM_CLASS";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn6.OptionsFilter.AllowFilter = false;
            this.gridColumn6.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 100;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "ORDER_CLASS_NAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ORDER_CLASS";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "计价(元)";
            this.gridColumn7.DisplayFormat.FormatString = "###,##0.00";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.FieldName = "SUM_COSTS";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn7.OptionsFilter.AllowFilter = false;
            this.gridColumn7.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.gridColumn7.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 120;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "应收(元)";
            this.gridColumn8.DisplayFormat.FormatString = "###,##0.00";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn8.FieldName = "SUM_CHARGES";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn8.OptionsFilter.AllowFilter = false;
            this.gridColumn8.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.gridColumn8.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 124;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "费用比例(%)";
            this.gridColumn9.DisplayFormat.FormatString = "##0.0";
            this.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn9.FieldName = "FEE_PERCENT";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            this.gridColumn9.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn9.OptionsFilter.AllowFilter = false;
            this.gridColumn9.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            this.gridColumn9.Width = 96;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridInpBillDetail);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(634, 359);
            this.xtraTabPage2.Text = "费用明细";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(414, 400);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 14);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "0.00";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(341, 400);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "余额(元)：";
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(522, 397);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(124, 23);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "实报实销费用打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // UCPatientInpBillDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.txtPrepayments);
            this.Controls.Add(this.labelControl1);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "UCPatientInpBillDetail";
            this.Size = new System.Drawing.Size(669, 427);
            this.Load += new System.EventHandler(this.UCPatientInpBillDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridInpBillDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInpBillDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpOrderClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderClassBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderClassBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LabelControl labelControl1;
        private LabelControl txtPrepayments;
        private RepositoryItemLookUpEdit repositoryItemLookUpOrderClass;
        private GridControl gridInpBillDetail;
        private GridView gridViewInpBillDetail;
        private GridColumn gridColumn1;
        private GridColumn gridColumn2;
        private GridColumn gridColumn3;
        private GridColumn gridColumn4;
        private GridColumn gridColumn5;
        private XtraTabControl xtraTabControl1;
        private XtraTabPage xtraTabPage1;
        private XtraTabPage xtraTabPage2;
        private GridControl gridOrderClassBill;
        private GridView gridViewOrderClassBill;
        private GridColumn gridColumn6;
        private GridColumn gridColumn7;
        private GridColumn gridColumn8;
        private GridColumn gridColumn9;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private LabelControl labelControl2;
        private LabelControl labelControl3;
        private GridColumn UNITS;
        private GridColumn AMOUNT;
        private Button btnPrint;
    }
}
