namespace JHEMR.EMREdit
{
    partial class UCEMROrders
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.outlookGrid1 = new JHEMR.EmrSysUserCtl.OutlookGrid();
            this.gcOrder = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.REPEAT_INDICATOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fzxh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ORDER_CLASS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.START_DATE_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ORDER_TEXT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DOSAGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DOSAGE_UNITS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STOP_DATE_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.outlookGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // outlookGrid1
            // 
            this.outlookGrid1.AllowUserToAddRows = false;
            this.outlookGrid1.AllowUserToDeleteRows = false;
            this.outlookGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(75)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.outlookGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.outlookGrid1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outlookGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outlookGrid1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.outlookGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.outlookGrid1.CollapseIcon = null;
            this.outlookGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(75)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.outlookGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.outlookGrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.outlookGrid1.ExpandIcon = null;
            this.outlookGrid1.Font = new System.Drawing.Font("宋体", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outlookGrid1.GridColor = System.Drawing.SystemColors.Control;
            this.outlookGrid1.grpFont = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outlookGrid1.Location = new System.Drawing.Point(213, 58);
            this.outlookGrid1.lsDirection = 1;
            this.outlookGrid1.Name = "outlookGrid1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.outlookGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.outlookGrid1.RowHeadersVisible = false;
            this.outlookGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.outlookGrid1.Size = new System.Drawing.Size(449, 0);
            this.outlookGrid1.SortListArray = -1;
            this.outlookGrid1.TabIndex = 0;
            this.outlookGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.outlookGrid1_CellClick);
            // 
            // gcOrder
            // 
            this.gcOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcOrder.EmbeddedNavigator.Name = "";
            this.gcOrder.Location = new System.Drawing.Point(1, -9);
            this.gcOrder.MainView = this.gridView1;
            this.gcOrder.Name = "gcOrder";
            this.gcOrder.Size = new System.Drawing.Size(877, 420);
            this.gcOrder.TabIndex = 1;
            this.gcOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcOrder.Load += new System.EventHandler(this.gcOrder_Load);
            this.gcOrder.Click += new System.EventHandler(this.gcOrder_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.REPEAT_INDICATOR,
            this.fzxh,
            this.ORDER_CLASS,
            this.START_DATE_TIME,
            this.ORDER_TEXT,
            this.DOSAGE,
            this.DOSAGE_UNITS,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.STOP_DATE_TIME,
            this.gridColumn5});
            this.gridView1.GridControl = this.gcOrder;
            this.gridView1.GroupPanelText = "用鼠标拖住一列标头放在此处按该列进行分组";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            // 
            // REPEAT_INDICATOR
            // 
            this.REPEAT_INDICATOR.Caption = "长期";
            this.REPEAT_INDICATOR.FieldName = "REPEAT_INDICATOR";
            this.REPEAT_INDICATOR.Name = "REPEAT_INDICATOR";
            this.REPEAT_INDICATOR.OptionsColumn.AllowEdit = false;
            this.REPEAT_INDICATOR.OptionsColumn.ReadOnly = true;
            this.REPEAT_INDICATOR.OptionsFilter.AllowAutoFilter = false;
            this.REPEAT_INDICATOR.OptionsFilter.AllowFilter = false;
            this.REPEAT_INDICATOR.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.REPEAT_INDICATOR.Visible = true;
            this.REPEAT_INDICATOR.VisibleIndex = 0;
            this.REPEAT_INDICATOR.Width = 46;
            // 
            // fzxh
            // 
            this.fzxh.Caption = "序号";
            this.fzxh.FieldName = "fzxh";
            this.fzxh.Name = "fzxh";
            // 
            // ORDER_CLASS
            // 
            this.ORDER_CLASS.Caption = "类别";
            this.ORDER_CLASS.FieldName = "ORDER_CLASS";
            this.ORDER_CLASS.Name = "ORDER_CLASS";
            this.ORDER_CLASS.OptionsColumn.AllowEdit = false;
            this.ORDER_CLASS.OptionsColumn.ReadOnly = true;
            this.ORDER_CLASS.OptionsFilter.AllowAutoFilter = false;
            this.ORDER_CLASS.OptionsFilter.AllowFilter = false;
            this.ORDER_CLASS.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.ORDER_CLASS.Visible = true;
            this.ORDER_CLASS.VisibleIndex = 1;
            this.ORDER_CLASS.Width = 46;
            // 
            // START_DATE_TIME
            // 
            this.START_DATE_TIME.Caption = "下达时间";
            this.START_DATE_TIME.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.START_DATE_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.START_DATE_TIME.FieldName = "START_DATE_TIME";
            this.START_DATE_TIME.Name = "START_DATE_TIME";
            this.START_DATE_TIME.OptionsColumn.AllowEdit = false;
            this.START_DATE_TIME.OptionsColumn.ReadOnly = true;
            this.START_DATE_TIME.OptionsFilter.AllowAutoFilter = false;
            this.START_DATE_TIME.OptionsFilter.AllowFilter = false;
            this.START_DATE_TIME.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.START_DATE_TIME.Visible = true;
            this.START_DATE_TIME.VisibleIndex = 2;
            this.START_DATE_TIME.Width = 125;
            // 
            // ORDER_TEXT
            // 
            this.ORDER_TEXT.Caption = "医嘱内容";
            this.ORDER_TEXT.FieldName = "ORDER_TEXT";
            this.ORDER_TEXT.Name = "ORDER_TEXT";
            this.ORDER_TEXT.OptionsColumn.AllowEdit = false;
            this.ORDER_TEXT.OptionsColumn.ReadOnly = true;
            this.ORDER_TEXT.OptionsFilter.AllowAutoFilter = false;
            this.ORDER_TEXT.OptionsFilter.AllowFilter = false;
            this.ORDER_TEXT.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.ORDER_TEXT.Visible = true;
            this.ORDER_TEXT.VisibleIndex = 3;
            this.ORDER_TEXT.Width = 177;
            // 
            // DOSAGE
            // 
            this.DOSAGE.Caption = "剂量";
            this.DOSAGE.FieldName = "DOSAGE";
            this.DOSAGE.Name = "DOSAGE";
            this.DOSAGE.OptionsColumn.AllowEdit = false;
            this.DOSAGE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.DOSAGE.OptionsColumn.ReadOnly = true;
            this.DOSAGE.OptionsFilter.AllowAutoFilter = false;
            this.DOSAGE.OptionsFilter.AllowFilter = false;
            this.DOSAGE.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.DOSAGE.Visible = true;
            this.DOSAGE.VisibleIndex = 4;
            this.DOSAGE.Width = 44;
            // 
            // DOSAGE_UNITS
            // 
            this.DOSAGE_UNITS.Caption = "单位";
            this.DOSAGE_UNITS.FieldName = "DOSAGE_UNITS";
            this.DOSAGE_UNITS.Name = "DOSAGE_UNITS";
            this.DOSAGE_UNITS.OptionsColumn.AllowEdit = false;
            this.DOSAGE_UNITS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.DOSAGE_UNITS.OptionsColumn.ReadOnly = true;
            this.DOSAGE_UNITS.OptionsFilter.AllowAutoFilter = false;
            this.DOSAGE_UNITS.OptionsFilter.AllowFilter = false;
            this.DOSAGE_UNITS.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.DOSAGE_UNITS.Visible = true;
            this.DOSAGE_UNITS.VisibleIndex = 5;
            this.DOSAGE_UNITS.Width = 47;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "给药途径";
            this.gridColumn1.FieldName = "ADMINISTRATION";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 78;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "频次";
            this.gridColumn2.FieldName = "FREQUENCY";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            this.gridColumn2.Width = 60;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "下达医生";
            this.gridColumn4.FieldName = "DOCTOR";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn4.OptionsFilter.AllowFilter = false;
            this.gridColumn4.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 8;
            this.gridColumn4.Width = 59;
            // 
            // STOP_DATE_TIME
            // 
            this.STOP_DATE_TIME.Caption = "停止时间";
            this.STOP_DATE_TIME.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.STOP_DATE_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.STOP_DATE_TIME.FieldName = "STOP_DATE_TIME";
            this.STOP_DATE_TIME.Name = "STOP_DATE_TIME";
            this.STOP_DATE_TIME.OptionsColumn.AllowEdit = false;
            this.STOP_DATE_TIME.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.STOP_DATE_TIME.OptionsColumn.ReadOnly = true;
            this.STOP_DATE_TIME.OptionsFilter.AllowAutoFilter = false;
            this.STOP_DATE_TIME.OptionsFilter.AllowFilter = false;
            this.STOP_DATE_TIME.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.STOP_DATE_TIME.Visible = true;
            this.STOP_DATE_TIME.VisibleIndex = 9;
            this.STOP_DATE_TIME.Width = 99;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "停止医生";
            this.gridColumn5.FieldName = "STOP_DOCTOR";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn5.OptionsFilter.AllowFilter = false;
            this.gridColumn5.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 10;
            this.gridColumn5.Width = 59;
            // 
            // UCEMROrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gcOrder);
            this.Controls.Add(this.outlookGrid1);
            this.Name = "UCEMROrders";
            this.Size = new System.Drawing.Size(878, 429);
            this.Load += new System.EventHandler(this.UCEMROrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outlookGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private JHEMR.EmrSysUserCtl.OutlookGrid outlookGrid1;
        private DevExpress.XtraGrid.GridControl gcOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn REPEAT_INDICATOR;
        private DevExpress.XtraGrid.Columns.GridColumn ORDER_CLASS;
        private DevExpress.XtraGrid.Columns.GridColumn START_DATE_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn ORDER_TEXT;
        private DevExpress.XtraGrid.Columns.GridColumn DOSAGE;
        private DevExpress.XtraGrid.Columns.GridColumn DOSAGE_UNITS;
        private DevExpress.XtraGrid.Columns.GridColumn STOP_DATE_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn fzxh;
    }
}
