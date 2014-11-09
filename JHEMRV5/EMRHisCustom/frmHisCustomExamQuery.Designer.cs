using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using System;
using System.ComponentModel;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Base;
namespace JHEMR.EMRHisCustom
{
    partial class frmHisCustomExamQuery
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sbtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gcExamApply = new DevExpress.XtraGrid.GridControl();
            this.gvApplyExam = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PATIENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EXAM_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REQ_DATE_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SCHEDULED_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EXAM_CLASS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EXAM_ITEM_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EXAM_ITEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COSTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EXAM_SUB_CLASS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DATE_OF_BIRTH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CHARGE_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAILING_ADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ZIP_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PHONE_NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CLIN_DIAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CLIN_SYMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PHYS_SIGN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RELEVANT_LAB_TEST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RELEVANT_DIAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REQ_PHYSICIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REQ_DEPT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EXAM_REASON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sbtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcExamApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvApplyExam)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sbtnUpdate);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "显示时间范围";
            // 
            // sbtnUpdate
            // 
            this.sbtnUpdate.Location = new System.Drawing.Point(449, 17);
            this.sbtnUpdate.Name = "sbtnUpdate";
            this.sbtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.sbtnUpdate.TabIndex = 2;
            this.sbtnUpdate.Text = "刷  新";
            this.sbtnUpdate.Click += new System.EventHandler(this.sbtnUpdate_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(287, 19);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(125, 21);
            this.dtpEnd.TabIndex = 1;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(89, 19);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(126, 21);
            this.dtpStart.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "结束时间：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "开始时间：";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gcExamApply);
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 436);
            this.panel1.TabIndex = 1;
            // 
            // gcExamApply
            // 
            this.gcExamApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcExamApply.EmbeddedNavigator.Name = "";
            this.gcExamApply.Location = new System.Drawing.Point(0, 0);
            this.gcExamApply.MainView = this.gvApplyExam;
            this.gcExamApply.Name = "gcExamApply";
            this.gcExamApply.Size = new System.Drawing.Size(772, 436);
            this.gcExamApply.TabIndex = 3;
            this.gcExamApply.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvApplyExam});
            // 
            // gvApplyExam
            // 
            this.gvApplyExam.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PATIENT_ID,
            this.NAME,
            this.EXAM_NO,
            this.REQ_DATE_TIME,
            this.SCHEDULED_DATE,
            this.EXAM_CLASS,
            this.EXAM_ITEM_NO,
            this.EXAM_ITEM,
            this.COSTS,
            this.EXAM_SUB_CLASS,
            this.SEX,
            this.DATE_OF_BIRTH,
            this.CHARGE_TYPE,
            this.MAILING_ADDRESS,
            this.ZIP_CODE,
            this.PHONE_NUMBER,
            this.CLIN_DIAG,
            this.CLIN_SYMP,
            this.PHYS_SIGN,
            this.RELEVANT_LAB_TEST,
            this.RELEVANT_DIAG,
            this.REQ_PHYSICIAN,
            this.REQ_DEPT,
            this.EXAM_REASON});
            this.gvApplyExam.GridControl = this.gcExamApply;
            this.gvApplyExam.Name = "gvApplyExam";
            this.gvApplyExam.OptionsLayout.Columns.AddNewColumns = false;
            this.gvApplyExam.OptionsView.ColumnAutoWidth = false;
            this.gvApplyExam.OptionsView.ShowGroupPanel = false;
            this.gvApplyExam.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvApplyExam_CustomDrawCell);
            // 
            // PATIENT_ID
            // 
            this.PATIENT_ID.Caption = "ID号";
            this.PATIENT_ID.FieldName = "PATIENT_ID";
            this.PATIENT_ID.Name = "PATIENT_ID";
            this.PATIENT_ID.OptionsColumn.AllowEdit = false;
            this.PATIENT_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.PATIENT_ID.OptionsColumn.FixedWidth = true;
            this.PATIENT_ID.Visible = true;
            this.PATIENT_ID.VisibleIndex = 0;
            this.PATIENT_ID.Width = 66;
            // 
            // NAME
            // 
            this.NAME.Caption = "病人姓名";
            this.NAME.FieldName = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.OptionsColumn.AllowEdit = false;
            this.NAME.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.NAME.OptionsColumn.FixedWidth = true;
            this.NAME.Visible = true;
            this.NAME.VisibleIndex = 1;
            this.NAME.Width = 69;
            // 
            // EXAM_NO
            // 
            this.EXAM_NO.Caption = "检查单号";
            this.EXAM_NO.FieldName = "EXAM_NO";
            this.EXAM_NO.Name = "EXAM_NO";
            this.EXAM_NO.OptionsColumn.AllowEdit = false;
            this.EXAM_NO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.EXAM_NO.OptionsColumn.FixedWidth = true;
            this.EXAM_NO.Visible = true;
            this.EXAM_NO.VisibleIndex = 2;
            this.EXAM_NO.Width = 85;
            // 
            // REQ_DATE_TIME
            // 
            this.REQ_DATE_TIME.Caption = "申请时间";
            this.REQ_DATE_TIME.FieldName = "REQ_DATE_TIME";
            this.REQ_DATE_TIME.Name = "REQ_DATE_TIME";
            this.REQ_DATE_TIME.OptionsColumn.AllowEdit = false;
            this.REQ_DATE_TIME.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.REQ_DATE_TIME.OptionsColumn.FixedWidth = true;
            this.REQ_DATE_TIME.Visible = true;
            this.REQ_DATE_TIME.VisibleIndex = 3;
            this.REQ_DATE_TIME.Width = 78;
            // 
            // SCHEDULED_DATE
            // 
            this.SCHEDULED_DATE.Caption = "预约时间";
            this.SCHEDULED_DATE.FieldName = "SCHEDULED_DATE";
            this.SCHEDULED_DATE.Name = "SCHEDULED_DATE";
            this.SCHEDULED_DATE.OptionsColumn.AllowEdit = false;
            this.SCHEDULED_DATE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.SCHEDULED_DATE.OptionsColumn.FixedWidth = true;
            this.SCHEDULED_DATE.Visible = true;
            this.SCHEDULED_DATE.VisibleIndex = 4;
            this.SCHEDULED_DATE.Width = 81;
            // 
            // EXAM_CLASS
            // 
            this.EXAM_CLASS.Caption = "类别";
            this.EXAM_CLASS.FieldName = "EXAM_CLASS";
            this.EXAM_CLASS.Name = "EXAM_CLASS";
            this.EXAM_CLASS.OptionsColumn.AllowEdit = false;
            this.EXAM_CLASS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.EXAM_CLASS.OptionsColumn.FixedWidth = true;
            this.EXAM_CLASS.Visible = true;
            this.EXAM_CLASS.VisibleIndex = 5;
            this.EXAM_CLASS.Width = 91;
            // 
            // EXAM_ITEM_NO
            // 
            this.EXAM_ITEM_NO.Caption = "序号";
            this.EXAM_ITEM_NO.FieldName = "EXAM_ITEM_NO";
            this.EXAM_ITEM_NO.Name = "EXAM_ITEM_NO";
            this.EXAM_ITEM_NO.OptionsColumn.AllowEdit = false;
            this.EXAM_ITEM_NO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.EXAM_ITEM_NO.OptionsColumn.FixedWidth = true;
            this.EXAM_ITEM_NO.Visible = true;
            this.EXAM_ITEM_NO.VisibleIndex = 6;
            this.EXAM_ITEM_NO.Width = 45;
            // 
            // EXAM_ITEM
            // 
            this.EXAM_ITEM.Caption = "项目名称";
            this.EXAM_ITEM.FieldName = "EXAM_ITEM";
            this.EXAM_ITEM.Name = "EXAM_ITEM";
            this.EXAM_ITEM.OptionsColumn.AllowEdit = false;
            this.EXAM_ITEM.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.EXAM_ITEM.OptionsColumn.FixedWidth = true;
            this.EXAM_ITEM.Visible = true;
            this.EXAM_ITEM.VisibleIndex = 7;
            this.EXAM_ITEM.Width = 91;
            // 
            // COSTS
            // 
            this.COSTS.Caption = "价格";
            this.COSTS.FieldName = "COSTS";
            this.COSTS.Name = "COSTS";
            this.COSTS.OptionsColumn.AllowEdit = false;
            this.COSTS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.COSTS.OptionsColumn.FixedWidth = true;
            this.COSTS.Visible = true;
            this.COSTS.VisibleIndex = 8;
            this.COSTS.Width = 72;
            // 
            // EXAM_SUB_CLASS
            // 
            this.EXAM_SUB_CLASS.Caption = "类别";
            this.EXAM_SUB_CLASS.FieldName = "EXAM_SUB_CLASS";
            this.EXAM_SUB_CLASS.Name = "EXAM_SUB_CLASS";
            this.EXAM_SUB_CLASS.OptionsColumn.AllowEdit = false;
            this.EXAM_SUB_CLASS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.EXAM_SUB_CLASS.OptionsColumn.ReadOnly = true;
            this.EXAM_SUB_CLASS.Visible = true;
            this.EXAM_SUB_CLASS.VisibleIndex = 9;
            this.EXAM_SUB_CLASS.Width = 68;
            // 
            // SEX
            // 
            this.SEX.Caption = "性别";
            this.SEX.FieldName = "SEX";
            this.SEX.Name = "SEX";
            // 
            // DATE_OF_BIRTH
            // 
            this.DATE_OF_BIRTH.Caption = "出生日期";
            this.DATE_OF_BIRTH.FieldName = "DATE_OF_BIRTH";
            this.DATE_OF_BIRTH.Name = "DATE_OF_BIRTH";
            // 
            // CHARGE_TYPE
            // 
            this.CHARGE_TYPE.Caption = "费别";
            this.CHARGE_TYPE.FieldName = "CHARGE_TYPE";
            this.CHARGE_TYPE.Name = "CHARGE_TYPE";
            // 
            // MAILING_ADDRESS
            // 
            this.MAILING_ADDRESS.Caption = "地址";
            this.MAILING_ADDRESS.FieldName = "MAILING_ADDRESS";
            this.MAILING_ADDRESS.Name = "MAILING_ADDRESS";
            // 
            // ZIP_CODE
            // 
            this.ZIP_CODE.Caption = "邮编";
            this.ZIP_CODE.FieldName = "ZIP_CODE";
            this.ZIP_CODE.Name = "ZIP_CODE";
            // 
            // PHONE_NUMBER
            // 
            this.PHONE_NUMBER.Caption = "电话";
            this.PHONE_NUMBER.FieldName = "PHONE_NUMBER";
            this.PHONE_NUMBER.Name = "PHONE_NUMBER";
            // 
            // CLIN_DIAG
            // 
            this.CLIN_DIAG.Caption = "诊断";
            this.CLIN_DIAG.FieldName = "CLIN_DIAG";
            this.CLIN_DIAG.Name = "CLIN_DIAG";
            // 
            // CLIN_SYMP
            // 
            this.CLIN_SYMP.Caption = "症状";
            this.CLIN_SYMP.FieldName = "CLIN_SYMP";
            this.CLIN_SYMP.Name = "CLIN_SYMP";
            // 
            // PHYS_SIGN
            // 
            this.PHYS_SIGN.Caption = "体征";
            this.PHYS_SIGN.FieldName = "PHYS_SIGN";
            this.PHYS_SIGN.Name = "PHYS_SIGN";
            // 
            // RELEVANT_LAB_TEST
            // 
            this.RELEVANT_LAB_TEST.Caption = "化验";
            this.RELEVANT_LAB_TEST.FieldName = "RELEVANT_LAB_TEST";
            this.RELEVANT_LAB_TEST.Name = "RELEVANT_LAB_TEST";
            // 
            // RELEVANT_DIAG
            // 
            this.RELEVANT_DIAG.Caption = "检查";
            this.RELEVANT_DIAG.FieldName = "RELEVANT_DIAG";
            this.RELEVANT_DIAG.Name = "RELEVANT_DIAG";
            // 
            // REQ_PHYSICIAN
            // 
            this.REQ_PHYSICIAN.Caption = "申请医师";
            this.REQ_PHYSICIAN.FieldName = "REQ_PHYSICIAN";
            this.REQ_PHYSICIAN.Name = "REQ_PHYSICIAN";
            // 
            // REQ_DEPT
            // 
            this.REQ_DEPT.Caption = "申请科室";
            this.REQ_DEPT.FieldName = "REQ_DEPT";
            this.REQ_DEPT.Name = "REQ_DEPT";
            // 
            // EXAM_REASON
            // 
            this.EXAM_REASON.Caption = "检查目的";
            this.EXAM_REASON.FieldName = "EXAM_REASON";
            this.EXAM_REASON.Name = "EXAM_REASON";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sbtnClose);
            this.panel2.Controls.Add(this.sbtnCancel);
            this.panel2.Controls.Add(this.sbtnPrint);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 47);
            this.panel2.TabIndex = 1;
            // 
            // sbtnClose
            // 
            this.sbtnClose.Location = new System.Drawing.Point(677, 12);
            this.sbtnClose.Name = "sbtnClose";
            this.sbtnClose.Size = new System.Drawing.Size(83, 23);
            this.sbtnClose.TabIndex = 3;
            this.sbtnClose.Text = "关闭 (&C)";
            this.sbtnClose.Click += new System.EventHandler(this.sbtnClose_Click);
            // 
            // sbtnCancel
            // 
            this.sbtnCancel.Location = new System.Drawing.Point(519, 12);
            this.sbtnCancel.Name = "sbtnCancel";
            this.sbtnCancel.Size = new System.Drawing.Size(86, 23);
            this.sbtnCancel.TabIndex = 3;
            this.sbtnCancel.Text = "撤销 (&U)";
            this.sbtnCancel.Click += new System.EventHandler(this.sbtnCancel_Click);
            // 
            // sbtnPrint
            // 
            this.sbtnPrint.Location = new System.Drawing.Point(365, 12);
            this.sbtnPrint.Name = "sbtnPrint";
            this.sbtnPrint.Size = new System.Drawing.Size(88, 23);
            this.sbtnPrint.TabIndex = 3;
            this.sbtnPrint.Text = "打印 (&P)";
            this.sbtnPrint.Click += new System.EventHandler(this.sbtnPrint_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "注意：预约时间填入以后，申请单不能撤销";
            // 
            // frmHisCustomExamQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHisCustomExamQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "检查单状态查看";
            this.Load += new System.EventHandler(this.frmHisCustomExamQuery_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcExamApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvApplyExam)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private Label label2;
        private Label label1;
        private SimpleButton sbtnUpdate;
        private Panel panel1;
        private Panel panel2;
        private GridControl gcExamApply;
        private GridView gvApplyExam;
        private Label label3;
        private SimpleButton sbtnClose;
        private SimpleButton sbtnCancel;
        private SimpleButton sbtnPrint;
        private GridColumn PATIENT_ID;
        private GridColumn NAME;
        private GridColumn EXAM_NO;
        private GridColumn REQ_DATE_TIME;
        private GridColumn SCHEDULED_DATE;
        private GridColumn EXAM_CLASS;
        private GridColumn EXAM_ITEM_NO;
        private GridColumn EXAM_ITEM;
        private GridColumn COSTS;
        private GridColumn EXAM_SUB_CLASS;
        private GridColumn SEX;
        private GridColumn DATE_OF_BIRTH;
        private GridColumn CHARGE_TYPE;
        private GridColumn MAILING_ADDRESS;
        private GridColumn ZIP_CODE;
        private GridColumn PHONE_NUMBER;
        private GridColumn CLIN_DIAG;
        private GridColumn CLIN_SYMP;
        private GridColumn PHYS_SIGN;
        private GridColumn RELEVANT_LAB_TEST;
        private GridColumn RELEVANT_DIAG;
        private GridColumn REQ_PHYSICIAN;
        private GridColumn REQ_DEPT;
        private GridColumn EXAM_REASON;
    }
}