using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using System;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Base;
namespace JHEMR.EMRHisCustom
{
    partial class frmOperationQuery
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gcOperation = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SCHEDULED_DATE_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OPERATING_ROOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OPERATING_ROOM_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SEQUENCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BED_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIAG_BEFORE_OPERATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OPERATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SURGEON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FIRST_ASSISTANT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ANESTHESIA_METHOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ANESTHESIA_DOCTOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BLOOD_TRAN_DOCTOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOTES_ON_OPERATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACK_INDICATOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VISIT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GROUP_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "手术日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "～";
            // 
            // cmbDept
            // 
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(3, 9);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(121, 20);
            this.cmbDept.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmbDept, "查询结果将显示当前选中科室选定时间段内的手术记录");
            this.cmbDept.Visible = false;
            this.cmbDept.SelectedIndexChanged += new System.EventHandler(this.cmbDept_SelectedIndexChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(262, 9);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(131, 21);
            this.dtpStart.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dtpStart, "手术预约开始时间");
            this.dtpStart.Value = new System.DateTime(2008, 7, 15, 0, 0, 0, 0);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(432, 10);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(124, 21);
            this.dtpEnd.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dtpEnd, "手术预约结束时间");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDeptName);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.cmbDept);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 38);
            this.panel1.TabIndex = 0;
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(3, 10);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.ReadOnly = true;
            this.txtDeptName.Size = new System.Drawing.Size(121, 21);
            this.txtDeptName.TabIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(130, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(43, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "科室";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(574, 8);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.Controls.Add(this.gcOperation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 526);
            this.panel2.TabIndex = 1;
            // 
            // gcOperation
            // 
            this.gcOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcOperation.EmbeddedNavigator.Name = "";
            this.gcOperation.Location = new System.Drawing.Point(0, 0);
            this.gcOperation.MainView = this.gridView1;
            this.gcOperation.Name = "gcOperation";
            this.gcOperation.Size = new System.Drawing.Size(770, 457);
            this.gcOperation.TabIndex = 0;
            this.gcOperation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SCHEDULED_DATE_TIME,
            this.OPERATING_ROOM,
            this.OPERATING_ROOM_NO,
            this.SEQUENCE,
            this.NAME,
            this.SEX,
            this.BED_NO,
            this.DIAG_BEFORE_OPERATION,
            this.OPERATION,
            this.SURGEON,
            this.FIRST_ASSISTANT,
            this.ANESTHESIA_METHOD,
            this.ANESTHESIA_DOCTOR,
            this.BLOOD_TRAN_DOCTOR,
            this.NOTES_ON_OPERATION,
            this.ACK_INDICATOR,
            this.VISIT_ID,
            this.GROUP_NAME});
            this.gridView1.GridControl = this.gcOperation;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            // 
            // SCHEDULED_DATE_TIME
            // 
            this.SCHEDULED_DATE_TIME.Caption = "手术日期";
            this.SCHEDULED_DATE_TIME.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.SCHEDULED_DATE_TIME.FieldName = "SCHEDULED_DATE_TIME";
            this.SCHEDULED_DATE_TIME.Name = "SCHEDULED_DATE_TIME";
            this.SCHEDULED_DATE_TIME.OptionsColumn.AllowEdit = false;
            this.SCHEDULED_DATE_TIME.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.SCHEDULED_DATE_TIME.OptionsColumn.ReadOnly = true;
            this.SCHEDULED_DATE_TIME.Visible = true;
            this.SCHEDULED_DATE_TIME.VisibleIndex = 0;
            this.SCHEDULED_DATE_TIME.Width = 104;
            // 
            // OPERATING_ROOM
            // 
            this.OPERATING_ROOM.Caption = "手术室";
            this.OPERATING_ROOM.FieldName = "OPERATING_ROOM";
            this.OPERATING_ROOM.Name = "OPERATING_ROOM";
            this.OPERATING_ROOM.OptionsColumn.AllowEdit = false;
            this.OPERATING_ROOM.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.OPERATING_ROOM.OptionsColumn.ReadOnly = true;
            this.OPERATING_ROOM.Visible = true;
            this.OPERATING_ROOM.VisibleIndex = 1;
            this.OPERATING_ROOM.Width = 112;
            // 
            // OPERATING_ROOM_NO
            // 
            this.OPERATING_ROOM_NO.Caption = "手术间";
            this.OPERATING_ROOM_NO.FieldName = "OPERATING_ROOM_NO";
            this.OPERATING_ROOM_NO.Name = "OPERATING_ROOM_NO";
            this.OPERATING_ROOM_NO.OptionsColumn.AllowEdit = false;
            this.OPERATING_ROOM_NO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.OPERATING_ROOM_NO.OptionsColumn.ReadOnly = true;
            this.OPERATING_ROOM_NO.Visible = true;
            this.OPERATING_ROOM_NO.VisibleIndex = 2;
            this.OPERATING_ROOM_NO.Width = 59;
            // 
            // SEQUENCE
            // 
            this.SEQUENCE.Caption = "台次";
            this.SEQUENCE.FieldName = "SEQUENCE";
            this.SEQUENCE.Name = "SEQUENCE";
            this.SEQUENCE.OptionsColumn.AllowEdit = false;
            this.SEQUENCE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.SEQUENCE.OptionsColumn.ReadOnly = true;
            this.SEQUENCE.Visible = true;
            this.SEQUENCE.VisibleIndex = 3;
            this.SEQUENCE.Width = 47;
            // 
            // NAME
            // 
            this.NAME.Caption = "病人姓名";
            this.NAME.FieldName = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.OptionsColumn.AllowEdit = false;
            this.NAME.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.NAME.OptionsColumn.ReadOnly = true;
            this.NAME.Visible = true;
            this.NAME.VisibleIndex = 4;
            this.NAME.Width = 68;
            // 
            // SEX
            // 
            this.SEX.Caption = "性别";
            this.SEX.FieldName = "SEX";
            this.SEX.Name = "SEX";
            this.SEX.OptionsColumn.AllowEdit = false;
            this.SEX.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.SEX.OptionsColumn.ReadOnly = true;
            this.SEX.Visible = true;
            this.SEX.VisibleIndex = 5;
            this.SEX.Width = 47;
            // 
            // BED_NO
            // 
            this.BED_NO.Caption = "床号";
            this.BED_NO.FieldName = "BED_NO";
            this.BED_NO.Name = "BED_NO";
            this.BED_NO.OptionsColumn.AllowEdit = false;
            this.BED_NO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.BED_NO.OptionsColumn.ReadOnly = true;
            this.BED_NO.Visible = true;
            this.BED_NO.VisibleIndex = 6;
            this.BED_NO.Width = 45;
            // 
            // DIAG_BEFORE_OPERATION
            // 
            this.DIAG_BEFORE_OPERATION.Caption = "主要诊断";
            this.DIAG_BEFORE_OPERATION.FieldName = "DIAG_BEFORE_OPERATION";
            this.DIAG_BEFORE_OPERATION.Name = "DIAG_BEFORE_OPERATION";
            this.DIAG_BEFORE_OPERATION.OptionsColumn.AllowEdit = false;
            this.DIAG_BEFORE_OPERATION.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.DIAG_BEFORE_OPERATION.OptionsColumn.ReadOnly = true;
            this.DIAG_BEFORE_OPERATION.Visible = true;
            this.DIAG_BEFORE_OPERATION.VisibleIndex = 7;
            this.DIAG_BEFORE_OPERATION.Width = 122;
            // 
            // OPERATION
            // 
            this.OPERATION.Caption = "手术内容";
            this.OPERATION.FieldName = "OPERATION";
            this.OPERATION.Name = "OPERATION";
            this.OPERATION.OptionsColumn.AllowEdit = false;
            this.OPERATION.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.OPERATION.OptionsColumn.ReadOnly = true;
            this.OPERATION.Visible = true;
            this.OPERATION.VisibleIndex = 8;
            this.OPERATION.Width = 254;
            // 
            // SURGEON
            // 
            this.SURGEON.Caption = "手术者";
            this.SURGEON.FieldName = "SURGEON";
            this.SURGEON.Name = "SURGEON";
            this.SURGEON.OptionsColumn.AllowEdit = false;
            this.SURGEON.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.SURGEON.OptionsColumn.ReadOnly = true;
            this.SURGEON.Visible = true;
            this.SURGEON.VisibleIndex = 9;
            // 
            // FIRST_ASSISTANT
            // 
            this.FIRST_ASSISTANT.Caption = "助手";
            this.FIRST_ASSISTANT.FieldName = "FIRST_ASSISTANT";
            this.FIRST_ASSISTANT.Name = "FIRST_ASSISTANT";
            this.FIRST_ASSISTANT.OptionsColumn.AllowEdit = false;
            this.FIRST_ASSISTANT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.FIRST_ASSISTANT.OptionsColumn.ReadOnly = true;
            this.FIRST_ASSISTANT.Visible = true;
            this.FIRST_ASSISTANT.VisibleIndex = 10;
            // 
            // ANESTHESIA_METHOD
            // 
            this.ANESTHESIA_METHOD.Caption = "麻醉方法";
            this.ANESTHESIA_METHOD.FieldName = "ANESTHESIA_METHOD";
            this.ANESTHESIA_METHOD.Name = "ANESTHESIA_METHOD";
            this.ANESTHESIA_METHOD.OptionsColumn.AllowEdit = false;
            this.ANESTHESIA_METHOD.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.ANESTHESIA_METHOD.OptionsColumn.ReadOnly = true;
            this.ANESTHESIA_METHOD.Visible = true;
            this.ANESTHESIA_METHOD.VisibleIndex = 11;
            this.ANESTHESIA_METHOD.Width = 79;
            // 
            // ANESTHESIA_DOCTOR
            // 
            this.ANESTHESIA_DOCTOR.Caption = "麻醉医师";
            this.ANESTHESIA_DOCTOR.FieldName = "ANESTHESIA_DOCTOR";
            this.ANESTHESIA_DOCTOR.Name = "ANESTHESIA_DOCTOR";
            this.ANESTHESIA_DOCTOR.OptionsColumn.AllowEdit = false;
            this.ANESTHESIA_DOCTOR.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.ANESTHESIA_DOCTOR.OptionsColumn.ReadOnly = true;
            this.ANESTHESIA_DOCTOR.Visible = true;
            this.ANESTHESIA_DOCTOR.VisibleIndex = 12;
            // 
            // BLOOD_TRAN_DOCTOR
            // 
            this.BLOOD_TRAN_DOCTOR.Caption = "输血者";
            this.BLOOD_TRAN_DOCTOR.FieldName = "BLOOD_TRAN_DOCTOR";
            this.BLOOD_TRAN_DOCTOR.Name = "BLOOD_TRAN_DOCTOR";
            this.BLOOD_TRAN_DOCTOR.OptionsColumn.AllowEdit = false;
            this.BLOOD_TRAN_DOCTOR.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.BLOOD_TRAN_DOCTOR.OptionsColumn.ReadOnly = true;
            this.BLOOD_TRAN_DOCTOR.Visible = true;
            this.BLOOD_TRAN_DOCTOR.VisibleIndex = 13;
            this.BLOOD_TRAN_DOCTOR.Width = 64;
            // 
            // NOTES_ON_OPERATION
            // 
            this.NOTES_ON_OPERATION.Caption = "手术准备条件";
            this.NOTES_ON_OPERATION.FieldName = "NOTES_ON_OPERATION";
            this.NOTES_ON_OPERATION.Name = "NOTES_ON_OPERATION";
            this.NOTES_ON_OPERATION.OptionsColumn.AllowEdit = false;
            this.NOTES_ON_OPERATION.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.NOTES_ON_OPERATION.OptionsColumn.FixedWidth = true;
            this.NOTES_ON_OPERATION.OptionsColumn.ReadOnly = true;
            this.NOTES_ON_OPERATION.Visible = true;
            this.NOTES_ON_OPERATION.VisibleIndex = 14;
            this.NOTES_ON_OPERATION.Width = 90;
            // 
            // ACK_INDICATOR
            // 
            this.ACK_INDICATOR.Caption = "确认";
            this.ACK_INDICATOR.FieldName = "ACK_INDICATOR";
            this.ACK_INDICATOR.Name = "ACK_INDICATOR";
            this.ACK_INDICATOR.OptionsColumn.AllowEdit = false;
            this.ACK_INDICATOR.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.ACK_INDICATOR.OptionsColumn.ReadOnly = true;
            // 
            // VISIT_ID
            // 
            this.VISIT_ID.Caption = "住院次";
            this.VISIT_ID.FieldName = "VISIT_ID";
            this.VISIT_ID.Name = "VISIT_ID";
            this.VISIT_ID.OptionsColumn.AllowEdit = false;
            this.VISIT_ID.OptionsColumn.ReadOnly = true;
            // 
            // GROUP_NAME
            // 
            this.GROUP_NAME.Caption = "主诊组";
            this.GROUP_NAME.FieldName = "GROUP_NAME";
            this.GROUP_NAME.Name = "GROUP_NAME";
            this.GROUP_NAME.OptionsColumn.AllowEdit = false;
            this.GROUP_NAME.OptionsColumn.ReadOnly = true;
            this.GROUP_NAME.Visible = true;
            this.GROUP_NAME.VisibleIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.statusStrip1);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 493);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 71);
            this.panel3.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 45);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(771, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(353, 17);
            this.toolStripStatusLabel1.Text = "手术内容    红色――未确认    双击未确认手术可修改相关信息";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(692, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(605, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(505, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "删除(&D)";
            this.toolTip1.SetToolTip(this.btnDelete, "删除未确认的手术申请");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmOperationQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 564);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmOperationQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "手术查询";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOperationQuery_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label2;
        private Label label3;
        private System.Windows.Forms.ComboBox cmbDept;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnPrint;
        private Button btnDelete;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button btnClose;
        private GridControl gcOperation;
        private GridView gridView1;
        private GridColumn SCHEDULED_DATE_TIME;
        private GridColumn OPERATING_ROOM;
        private GridColumn OPERATING_ROOM_NO;
        private GridColumn SEQUENCE;
        private GridColumn NAME;
        private GridColumn SEX;
        private GridColumn BED_NO;
        private GridColumn DIAG_BEFORE_OPERATION;
        private GridColumn OPERATION;
        private GridColumn SURGEON;
        private GridColumn FIRST_ASSISTANT;
        private GridColumn ANESTHESIA_METHOD;
        private GridColumn ANESTHESIA_DOCTOR;
        private GridColumn BLOOD_TRAN_DOCTOR;
        private GridColumn NOTES_ON_OPERATION;
        private GridColumn ACK_INDICATOR;
        private GridColumn VISIT_ID;
        private Button btnQuery;
        private ToolTip toolTip1;
        private SimpleButton simpleButton1;
        private TextBox txtDeptName;
        private GridColumn GROUP_NAME;
    }
}