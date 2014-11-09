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
    partial class frmHisCustomCrbQuery
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.sbtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gcInfection = new DevExpress.XtraGrid.GridControl();
            this.gvInfection = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PATIENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VISIT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARD_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARD_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DATE_OF_BIRTH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ADMISSION_DATE_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEPT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEPT_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONTAGION_TYPE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PATIENT_SOURCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DISEASE_CLASS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REVISE_DISEASE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REPORT_DOCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REPORT_DATE_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DISEASE_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIAG_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEAD_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BYXSJ_FLAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.spbtnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInfection)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDept);
            this.groupBox1.Controls.Add(this.sbtnUpdate);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条件";
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(44, 17);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(164, 20);
            this.cmbDept.TabIndex = 0;
            this.cmbDept.SelectedIndexChanged += new System.EventHandler(this.cmbDept_SelectedIndexChanged);
            // 
            // sbtnUpdate
            // 
            this.sbtnUpdate.Location = new System.Drawing.Point(625, 16);
            this.sbtnUpdate.Name = "sbtnUpdate";
            this.sbtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.sbtnUpdate.TabIndex = 3;
            this.sbtnUpdate.Text = "刷  新";
            this.sbtnUpdate.Click += new System.EventHandler(this.sbtnUpdate_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(486, 17);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(122, 21);
            this.dtpEnd.TabIndex = 2;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(287, 17);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(120, 21);
            this.dtpStart.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "结束时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "科室：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 20);
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
            this.panel1.Controls.Add(this.gcInfection);
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 412);
            this.panel1.TabIndex = 3;
            // 
            // gcInfection
            // 
            this.gcInfection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInfection.EmbeddedNavigator.Name = "";
            this.gcInfection.Location = new System.Drawing.Point(0, 0);
            this.gcInfection.MainView = this.gvInfection;
            this.gcInfection.Name = "gcInfection";
            this.gcInfection.Size = new System.Drawing.Size(842, 412);
            this.gcInfection.TabIndex = 4;
            this.gcInfection.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInfection});
            // 
            // gvInfection
            // 
            this.gvInfection.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PATIENT_ID,
            this.VISIT_ID,
            this.CARD_NO,
            this.CARD_TYPE,
            this.NAME,
            this.SEX,
            this.DATE_OF_BIRTH,
            this.AGE,
            this.ADMISSION_DATE_TIME,
            this.DEPT_NAME,
            this.DEPT_CODE,
            this.CONTAGION_TYPE_NAME,
            this.PATIENT_SOURCE,
            this.DISEASE_CLASS,
            this.REVISE_DISEASE_NAME,
            this.REPORT_DOCT,
            this.REPORT_DATE_TIME,
            this.NUM,
            this.DISEASE_DATE,
            this.DIAG_DATE,
            this.DEAD_DATE,
            this.BYXSJ_FLAG});
            this.gvInfection.GridControl = this.gcInfection;
            this.gvInfection.Name = "gvInfection";
            this.gvInfection.OptionsView.ColumnAutoWidth = false;
            this.gvInfection.OptionsView.ShowGroupPanel = false;
            this.gvInfection.DoubleClick += new System.EventHandler(this.gvInfection_DoubleClick);
            // 
            // PATIENT_ID
            // 
            this.PATIENT_ID.Caption = "病人ID";
            this.PATIENT_ID.FieldName = "PATIENT_ID";
            this.PATIENT_ID.Name = "PATIENT_ID";
            this.PATIENT_ID.OptionsColumn.AllowEdit = false;
            this.PATIENT_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.PATIENT_ID.OptionsColumn.ReadOnly = true;
            this.PATIENT_ID.Visible = true;
            this.PATIENT_ID.VisibleIndex = 0;
            this.PATIENT_ID.Width = 69;
            // 
            // VISIT_ID
            // 
            this.VISIT_ID.Caption = "住院次";
            this.VISIT_ID.FieldName = "VISIT_ID";
            this.VISIT_ID.Name = "VISIT_ID";
            this.VISIT_ID.OptionsColumn.AllowEdit = false;
            this.VISIT_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.VISIT_ID.OptionsColumn.ReadOnly = true;
            this.VISIT_ID.Visible = true;
            this.VISIT_ID.VisibleIndex = 1;
            this.VISIT_ID.Width = 57;
            // 
            // CARD_NO
            // 
            this.CARD_NO.Caption = "卡号";
            this.CARD_NO.FieldName = "CARD_NO";
            this.CARD_NO.Name = "CARD_NO";
            this.CARD_NO.OptionsColumn.AllowEdit = false;
            this.CARD_NO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.CARD_NO.OptionsColumn.ReadOnly = true;
            this.CARD_NO.Visible = true;
            this.CARD_NO.VisibleIndex = 2;
            this.CARD_NO.Width = 48;
            // 
            // CARD_TYPE
            // 
            this.CARD_TYPE.Caption = "报卡类别";
            this.CARD_TYPE.FieldName = "CARD_TYPE";
            this.CARD_TYPE.Name = "CARD_TYPE";
            this.CARD_TYPE.OptionsColumn.AllowEdit = false;
            this.CARD_TYPE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.CARD_TYPE.OptionsColumn.ReadOnly = true;
            this.CARD_TYPE.Visible = true;
            this.CARD_TYPE.VisibleIndex = 3;
            this.CARD_TYPE.Width = 66;
            // 
            // NAME
            // 
            this.NAME.Caption = "姓名";
            this.NAME.FieldName = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.OptionsColumn.AllowEdit = false;
            this.NAME.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.NAME.OptionsColumn.ReadOnly = true;
            this.NAME.Visible = true;
            this.NAME.VisibleIndex = 4;
            this.NAME.Width = 62;
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
            this.SEX.Width = 40;
            // 
            // DATE_OF_BIRTH
            // 
            this.DATE_OF_BIRTH.Caption = "出生日期";
            this.DATE_OF_BIRTH.FieldName = "DATE_OF_BIRTH";
            this.DATE_OF_BIRTH.Name = "DATE_OF_BIRTH";
            this.DATE_OF_BIRTH.OptionsColumn.AllowEdit = false;
            this.DATE_OF_BIRTH.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.DATE_OF_BIRTH.OptionsColumn.ReadOnly = true;
            // 
            // AGE
            // 
            this.AGE.Caption = "年龄";
            this.AGE.FieldName = "AGE";
            this.AGE.Name = "AGE";
            this.AGE.OptionsColumn.AllowEdit = false;
            this.AGE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.AGE.OptionsColumn.ReadOnly = true;
            this.AGE.Visible = true;
            this.AGE.VisibleIndex = 6;
            this.AGE.Width = 45;
            // 
            // ADMISSION_DATE_TIME
            // 
            this.ADMISSION_DATE_TIME.Caption = "入院日期";
            this.ADMISSION_DATE_TIME.FieldName = "ADMISSION_DATE_TIME";
            this.ADMISSION_DATE_TIME.Name = "ADMISSION_DATE_TIME";
            this.ADMISSION_DATE_TIME.OptionsColumn.AllowEdit = false;
            this.ADMISSION_DATE_TIME.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.ADMISSION_DATE_TIME.OptionsColumn.ReadOnly = true;
            this.ADMISSION_DATE_TIME.Visible = true;
            this.ADMISSION_DATE_TIME.VisibleIndex = 7;
            this.ADMISSION_DATE_TIME.Width = 86;
            // 
            // DEPT_NAME
            // 
            this.DEPT_NAME.Caption = "上报科室";
            this.DEPT_NAME.FieldName = "DEPT_NAME";
            this.DEPT_NAME.Name = "DEPT_NAME";
            this.DEPT_NAME.OptionsColumn.AllowEdit = false;
            this.DEPT_NAME.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.DEPT_NAME.OptionsColumn.ReadOnly = true;
            this.DEPT_NAME.Visible = true;
            this.DEPT_NAME.VisibleIndex = 8;
            this.DEPT_NAME.Width = 105;
            // 
            // DEPT_CODE
            // 
            this.DEPT_CODE.Caption = "科室";
            this.DEPT_CODE.FieldName = "DEPT_CODE";
            this.DEPT_CODE.Name = "DEPT_CODE";
            this.DEPT_CODE.OptionsColumn.AllowEdit = false;
            this.DEPT_CODE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.DEPT_CODE.OptionsColumn.ReadOnly = true;
            // 
            // CONTAGION_TYPE_NAME
            // 
            this.CONTAGION_TYPE_NAME.Caption = "传染病名称";
            this.CONTAGION_TYPE_NAME.FieldName = "CONTAGION_TYPE_NAME";
            this.CONTAGION_TYPE_NAME.Name = "CONTAGION_TYPE_NAME";
            this.CONTAGION_TYPE_NAME.OptionsColumn.AllowEdit = false;
            this.CONTAGION_TYPE_NAME.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.CONTAGION_TYPE_NAME.OptionsColumn.ReadOnly = true;
            this.CONTAGION_TYPE_NAME.Visible = true;
            this.CONTAGION_TYPE_NAME.VisibleIndex = 9;
            this.CONTAGION_TYPE_NAME.Width = 125;
            // 
            // PATIENT_SOURCE
            // 
            this.PATIENT_SOURCE.Caption = "病人属于";
            this.PATIENT_SOURCE.FieldName = "PATIENT_SOURCE";
            this.PATIENT_SOURCE.Name = "PATIENT_SOURCE";
            this.PATIENT_SOURCE.OptionsColumn.AllowEdit = false;
            this.PATIENT_SOURCE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.PATIENT_SOURCE.OptionsColumn.ReadOnly = true;
            this.PATIENT_SOURCE.Visible = true;
            this.PATIENT_SOURCE.VisibleIndex = 10;
            this.PATIENT_SOURCE.Width = 95;
            // 
            // DISEASE_CLASS
            // 
            this.DISEASE_CLASS.Caption = "病例分类";
            this.DISEASE_CLASS.FieldName = "DISEASE_CLASS";
            this.DISEASE_CLASS.Name = "DISEASE_CLASS";
            this.DISEASE_CLASS.OptionsColumn.AllowEdit = false;
            this.DISEASE_CLASS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.DISEASE_CLASS.OptionsColumn.ReadOnly = true;
            this.DISEASE_CLASS.Visible = true;
            this.DISEASE_CLASS.VisibleIndex = 11;
            this.DISEASE_CLASS.Width = 83;
            // 
            // REVISE_DISEASE_NAME
            // 
            this.REVISE_DISEASE_NAME.Caption = "订正病名";
            this.REVISE_DISEASE_NAME.FieldName = "REVISE_DISEASE_NAME";
            this.REVISE_DISEASE_NAME.Name = "REVISE_DISEASE_NAME";
            this.REVISE_DISEASE_NAME.OptionsColumn.AllowEdit = false;
            this.REVISE_DISEASE_NAME.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.REVISE_DISEASE_NAME.OptionsColumn.ReadOnly = true;
            this.REVISE_DISEASE_NAME.Visible = true;
            this.REVISE_DISEASE_NAME.VisibleIndex = 12;
            this.REVISE_DISEASE_NAME.Width = 130;
            // 
            // REPORT_DOCT
            // 
            this.REPORT_DOCT.Caption = "上报医生";
            this.REPORT_DOCT.FieldName = "REPORT_DOCT";
            this.REPORT_DOCT.Name = "REPORT_DOCT";
            this.REPORT_DOCT.OptionsColumn.AllowEdit = false;
            this.REPORT_DOCT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.REPORT_DOCT.OptionsColumn.ReadOnly = true;
            this.REPORT_DOCT.Visible = true;
            this.REPORT_DOCT.VisibleIndex = 13;
            this.REPORT_DOCT.Width = 60;
            // 
            // REPORT_DATE_TIME
            // 
            this.REPORT_DATE_TIME.Caption = "填卡日期";
            this.REPORT_DATE_TIME.FieldName = "REPORT_DATE_TIME";
            this.REPORT_DATE_TIME.Name = "REPORT_DATE_TIME";
            this.REPORT_DATE_TIME.OptionsColumn.AllowEdit = false;
            this.REPORT_DATE_TIME.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.REPORT_DATE_TIME.OptionsColumn.ReadOnly = true;
            this.REPORT_DATE_TIME.Visible = true;
            this.REPORT_DATE_TIME.VisibleIndex = 14;
            // 
            // NUM
            // 
            this.NUM.Caption = "次数";
            this.NUM.FieldName = "NUM";
            this.NUM.Name = "NUM";
            this.NUM.OptionsColumn.AllowEdit = false;
            this.NUM.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.NUM.OptionsColumn.ReadOnly = true;
            this.NUM.Visible = true;
            this.NUM.VisibleIndex = 15;
            // 
            // DISEASE_DATE
            // 
            this.DISEASE_DATE.Caption = "发病日期";
            this.DISEASE_DATE.FieldName = "DISEASE_DATE";
            this.DISEASE_DATE.Name = "DISEASE_DATE";
            this.DISEASE_DATE.Visible = true;
            this.DISEASE_DATE.VisibleIndex = 16;
            // 
            // DIAG_DATE
            // 
            this.DIAG_DATE.Caption = "诊断日期";
            this.DIAG_DATE.FieldName = "DIAG_DATE";
            this.DIAG_DATE.Name = "DIAG_DATE";
            this.DIAG_DATE.Visible = true;
            this.DIAG_DATE.VisibleIndex = 17;
            // 
            // DEAD_DATE
            // 
            this.DEAD_DATE.Caption = "死亡日期";
            this.DEAD_DATE.FieldName = "DEAD_DATE";
            this.DEAD_DATE.Name = "DEAD_DATE";
            this.DEAD_DATE.Visible = true;
            this.DEAD_DATE.VisibleIndex = 18;
            // 
            // BYXSJ_FLAG
            // 
            this.BYXSJ_FLAG.Caption = "病源学送检";
            this.BYXSJ_FLAG.FieldName = "BYXSJ_FLAG";
            this.BYXSJ_FLAG.Name = "BYXSJ_FLAG";
            this.BYXSJ_FLAG.OptionsColumn.AllowEdit = false;
            this.BYXSJ_FLAG.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.BYXSJ_FLAG.OptionsColumn.ReadOnly = true;
            this.BYXSJ_FLAG.Visible = true;
            this.BYXSJ_FLAG.VisibleIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.spbtnPrint);
            this.panel2.Controls.Add(this.spbtnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 38);
            this.panel2.TabIndex = 4;
            // 
            // spbtnPrint
            // 
            this.spbtnPrint.Location = new System.Drawing.Point(585, 9);
            this.spbtnPrint.Name = "spbtnPrint";
            this.spbtnPrint.Size = new System.Drawing.Size(75, 23);
            this.spbtnPrint.TabIndex = 0;
            this.spbtnPrint.Text = "打印(&P)";
            this.spbtnPrint.Visible = false;
            this.spbtnPrint.Click += new System.EventHandler(this.spbtnPrint_Click);
            // 
            // spbtnClose
            // 
            this.spbtnClose.Location = new System.Drawing.Point(711, 9);
            this.spbtnClose.Name = "spbtnClose";
            this.spbtnClose.Size = new System.Drawing.Size(75, 23);
            this.spbtnClose.TabIndex = 0;
            this.spbtnClose.Text = "关闭(&X)";
            this.spbtnClose.Click += new System.EventHandler(this.spbtnClose_Click);
            // 
            // frmHisCustomCrbQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHisCustomCrbQuery";
            this.Text = "传染病上报统计查询";
            this.Load += new System.EventHandler(this.frmHisCustomCrbQuery_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcInfection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInfection)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDept;
        private SimpleButton sbtnUpdate;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private Label label2;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private GridControl gcInfection;
        private GridView gvInfection;
        private GridColumn PATIENT_ID;
        private GridColumn VISIT_ID;
        private GridColumn CARD_NO;
        private GridColumn CARD_TYPE;
        private GridColumn NAME;
        private GridColumn SEX;
        private GridColumn DATE_OF_BIRTH;
        private GridColumn AGE;
        private GridColumn ADMISSION_DATE_TIME;
        private GridColumn DEPT_NAME;
        private GridColumn DEPT_CODE;
        private GridColumn CONTAGION_TYPE_NAME;
        private GridColumn PATIENT_SOURCE;
        private GridColumn DISEASE_CLASS;
        private GridColumn REVISE_DISEASE_NAME;
        private GridColumn REPORT_DOCT;
        private GridColumn REPORT_DATE_TIME;
        private GridColumn NUM;
        private Panel panel2;
        private SimpleButton spbtnPrint;
        private SimpleButton spbtnClose;
        private GridColumn DISEASE_DATE;
        private GridColumn DIAG_DATE;
        private GridColumn DEAD_DATE;
        private GridColumn BYXSJ_FLAG;
    }
}