namespace JHEMR.EMREdit
{
    partial class UCLabResult
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
            this.gcLabApply = new DevExpress.XtraGrid.GridControl();
            this.gvLabApply = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ApplyNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REPORT_DATE_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReqDeptName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SampleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcReportt = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ResultValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CharRefer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ranges = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcLabApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLabApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcReportt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcLabApply
            // 
            this.gcLabApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLabApply.EmbeddedNavigator.Name = "";
            this.gcLabApply.Location = new System.Drawing.Point(2, 21);
            this.gcLabApply.MainView = this.gvLabApply;
            this.gcLabApply.Name = "gcLabApply";
            this.gcLabApply.Size = new System.Drawing.Size(793, 177);
            this.gcLabApply.TabIndex = 0;
            this.gcLabApply.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLabApply});
            this.gcLabApply.Load += new System.EventHandler(this.gcLabApply_Load);
            this.gcLabApply.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gvLabApply
            // 
            this.gvLabApply.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ApplyNo,
            this.REPORT_DATE_TIME,
            this.ReqDeptName,
            this.SampleName});
            this.gvLabApply.GridControl = this.gcLabApply;
            this.gvLabApply.GroupPanelText = "用鼠标拖住一列标头放在此处按该列进行分组";
            this.gvLabApply.Name = "gvLabApply";
            this.gvLabApply.OptionsBehavior.Editable = false;
            this.gvLabApply.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvLabApply_FocusedRowChanged);
            // 
            // ApplyNo
            // 
            this.ApplyNo.Caption = "申请单号";
            this.ApplyNo.FieldName = "ApplyNo";
            this.ApplyNo.Name = "ApplyNo";
            this.ApplyNo.Visible = true;
            this.ApplyNo.VisibleIndex = 0;
            // 
            // REPORT_DATE_TIME
            // 
            this.REPORT_DATE_TIME.Caption = "执行时间";
            this.REPORT_DATE_TIME.FieldName = "REPORT_DATE_TIME";
            this.REPORT_DATE_TIME.Name = "REPORT_DATE_TIME";
            this.REPORT_DATE_TIME.Visible = true;
            this.REPORT_DATE_TIME.VisibleIndex = 1;
            // 
            // ReqDeptName
            // 
            this.ReqDeptName.Caption = "申请科室";
            this.ReqDeptName.FieldName = "ReqDeptName";
            this.ReqDeptName.Name = "ReqDeptName";
            this.ReqDeptName.Visible = true;
            this.ReqDeptName.VisibleIndex = 2;
            // 
            // SampleName
            // 
            this.SampleName.Caption = "样本";
            this.SampleName.FieldName = "SampleName";
            this.SampleName.Name = "SampleName";
            this.SampleName.Visible = true;
            this.SampleName.VisibleIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcReportt);
            this.groupControl1.Location = new System.Drawing.Point(3, 209);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(794, 332);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "检验报告";
            // 
            // gcReportt
            // 
            this.gcReportt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcReportt.EmbeddedNavigator.Name = "";
            this.gcReportt.Location = new System.Drawing.Point(2, 21);
            this.gcReportt.MainView = this.gridView2;
            this.gcReportt.Name = "gcReportt";
            this.gcReportt.Size = new System.Drawing.Size(790, 309);
            this.gcReportt.TabIndex = 0;
            this.gcReportt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ItemName,
            this.ItemCode,
            this.ResultValue,
            this.Unit,
            this.CharRefer,
            this.Ranges});
            this.gridView2.GridControl = this.gcReportt;
            this.gridView2.GroupPanelText = "用鼠标拖住一列标头放在此处按该列进行分组";
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            // 
            // ItemName
            // 
            this.ItemName.Caption = "项目名称";
            this.ItemName.FieldName = "ItemName";
            this.ItemName.Name = "ItemName";
            this.ItemName.Visible = true;
            this.ItemName.VisibleIndex = 0;
            // 
            // ItemCode
            // 
            this.ItemCode.Caption = "项目代码";
            this.ItemCode.FieldName = "ItemCode";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Visible = true;
            this.ItemCode.VisibleIndex = 1;
            // 
            // ResultValue
            // 
            this.ResultValue.Caption = "结果";
            this.ResultValue.FieldName = "ResultValue";
            this.ResultValue.Name = "ResultValue";
            this.ResultValue.Visible = true;
            this.ResultValue.VisibleIndex = 2;
            // 
            // Unit
            // 
            this.Unit.Caption = "单位";
            this.Unit.FieldName = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.Visible = true;
            this.Unit.VisibleIndex = 3;
            // 
            // CharRefer
            // 
            this.CharRefer.Caption = "提示";
            this.CharRefer.FieldName = "CharRefer";
            this.CharRefer.Name = "CharRefer";
            this.CharRefer.Visible = true;
            this.CharRefer.VisibleIndex = 5;
            // 
            // Ranges
            // 
            this.Ranges.Caption = "参考范围";
            this.Ranges.FieldName = "Ranges";
            this.Ranges.Name = "Ranges";
            this.Ranges.Visible = true;
            this.Ranges.VisibleIndex = 4;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gcLabApply);
            this.groupControl2.Location = new System.Drawing.Point(0, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(797, 200);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "检验申请单";
            // 
            // UCLabResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "UCLabResult";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.gcLabApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLabApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcReportt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcLabApply;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLabApply;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcReportt;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn ApplyNo;
        private DevExpress.XtraGrid.Columns.GridColumn REPORT_DATE_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn ReqDeptName;
        private DevExpress.XtraGrid.Columns.GridColumn SampleName;
        private DevExpress.XtraGrid.Columns.GridColumn ItemName;
        private DevExpress.XtraGrid.Columns.GridColumn ItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn ResultValue;
        private DevExpress.XtraGrid.Columns.GridColumn Unit;
        private DevExpress.XtraGrid.Columns.GridColumn CharRefer;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Columns.GridColumn Ranges;
    }
}
