using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using System;
using System.ComponentModel;
using DevExpress.XtraGrid.Views.Base;
using System.Drawing;
using DevExpress.XtraEditors;
namespace JHEMR.EMRHisCustom
{
    partial class frmHisCustomInOut
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存为EXCEL文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gcPat = new DevExpress.XtraGrid.GridControl();
            this.gvPat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PATIENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.INP_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VISIT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ADMISSION_DATE_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BIRTH_PLACE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEPT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OCCUPATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DISCHARGE_DATE_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.INHOSDAYS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DISCHARGE_CONDITIONS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIAGNOSIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DISCHARGE_DIAGNOSIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CLINIC_DIAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAILING_ADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DOCTOR_IN_CHARGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONSULTING_DOCTOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NEXT_OF_SKIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RELATION_SHIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NEXT_OF_KIN_PHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SFCRCFZD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.save_frm = new System.Windows.Forms.Button();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.sbtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.帮助HToolStripMenuItem,
            this.退出XToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存为EXCEL文件ToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            this.文件FToolStripMenuItem.Visible = false;
            // 
            // 保存为EXCEL文件ToolStripMenuItem
            // 
            this.保存为EXCEL文件ToolStripMenuItem.Name = "保存为EXCEL文件ToolStripMenuItem";
            this.保存为EXCEL文件ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.保存为EXCEL文件ToolStripMenuItem.Text = "保存为EXCEL文件(&S)";
            this.保存为EXCEL文件ToolStripMenuItem.Click += new System.EventHandler(this.保存为EXCEL文件ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            this.帮助HToolStripMenuItem.Visible = false;
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            this.退出XToolStripMenuItem.Visible = false;
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
            // 
            // gcPat
            // 
            this.gcPat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcPat.EmbeddedNavigator.Name = "";
            this.gcPat.Location = new System.Drawing.Point(6, 69);
            this.gcPat.MainView = this.gvPat;
            this.gcPat.Name = "gcPat";
            this.gcPat.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gcPat.Size = new System.Drawing.Size(845, 378);
            this.gcPat.TabIndex = 4;
            this.gcPat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPat});
            // 
            // gvPat
            // 
            this.gvPat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PATIENT_ID,
            this.INP_NO,
            this.VISIT_ID,
            this.ADMISSION_DATE_TIME,
            this.NAME,
            this.SEX,
            this.AGE,
            this.BIRTH_PLACE,
            this.DEPT_NAME,
            this.OCCUPATION,
            this.DISCHARGE_DATE_TIME,
            this.INHOSDAYS,
            this.DISCHARGE_CONDITIONS,
            this.DIAGNOSIS,
            this.DISCHARGE_DIAGNOSIS,
            this.CLINIC_DIAG,
            this.MAILING_ADDRESS,
            this.DOCTOR_IN_CHARGE,
            this.CONSULTING_DOCTOR,
            this.NEXT_OF_SKIN,
            this.RELATION_SHIP,
            this.NEXT_OF_KIN_PHONE,
            this.SFCRCFZD});
            this.gvPat.GridControl = this.gcPat;
            this.gvPat.Name = "gvPat";
            this.gvPat.OptionsView.ColumnAutoWidth = false;
            this.gvPat.OptionsView.ShowGroupPanel = false;
            // 
            // PATIENT_ID
            // 
            this.PATIENT_ID.Caption = "门诊号";
            this.PATIENT_ID.FieldName = "PATIENT_ID";
            this.PATIENT_ID.Name = "PATIENT_ID";
            this.PATIENT_ID.Visible = true;
            this.PATIENT_ID.VisibleIndex = 0;
            this.PATIENT_ID.Width = 68;
            // 
            // INP_NO
            // 
            this.INP_NO.Caption = "住院号";
            this.INP_NO.FieldName = "INP_NO";
            this.INP_NO.Name = "INP_NO";
            this.INP_NO.Visible = true;
            this.INP_NO.VisibleIndex = 1;
            this.INP_NO.Width = 52;
            // 
            // VISIT_ID
            // 
            this.VISIT_ID.Caption = "住院次";
            this.VISIT_ID.FieldName = "VISIT_ID";
            this.VISIT_ID.Name = "VISIT_ID";
            this.VISIT_ID.Visible = true;
            this.VISIT_ID.VisibleIndex = 2;
            this.VISIT_ID.Width = 64;
            // 
            // ADMISSION_DATE_TIME
            // 
            this.ADMISSION_DATE_TIME.Caption = "入院日期";
            this.ADMISSION_DATE_TIME.FieldName = "ADMISSION_DATE_TIME";
            this.ADMISSION_DATE_TIME.Name = "ADMISSION_DATE_TIME";
            this.ADMISSION_DATE_TIME.Visible = true;
            this.ADMISSION_DATE_TIME.VisibleIndex = 3;
            this.ADMISSION_DATE_TIME.Width = 59;
            // 
            // NAME
            // 
            this.NAME.Caption = "姓名";
            this.NAME.FieldName = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.Visible = true;
            this.NAME.VisibleIndex = 4;
            this.NAME.Width = 55;
            // 
            // SEX
            // 
            this.SEX.Caption = "性别";
            this.SEX.FieldName = "SEX";
            this.SEX.Name = "SEX";
            this.SEX.Visible = true;
            this.SEX.VisibleIndex = 5;
            this.SEX.Width = 69;
            // 
            // AGE
            // 
            this.AGE.Caption = "年龄";
            this.AGE.FieldName = "AGE";
            this.AGE.Name = "AGE";
            this.AGE.Visible = true;
            this.AGE.VisibleIndex = 6;
            // 
            // BIRTH_PLACE
            // 
            this.BIRTH_PLACE.Caption = "籍贯";
            this.BIRTH_PLACE.FieldName = "BIRTH_PLACE";
            this.BIRTH_PLACE.Name = "BIRTH_PLACE";
            this.BIRTH_PLACE.Visible = true;
            this.BIRTH_PLACE.VisibleIndex = 7;
            this.BIRTH_PLACE.Width = 57;
            // 
            // DEPT_NAME
            // 
            this.DEPT_NAME.Caption = "部别";
            this.DEPT_NAME.FieldName = "DEPT_NAME";
            this.DEPT_NAME.Name = "DEPT_NAME";
            this.DEPT_NAME.Visible = true;
            this.DEPT_NAME.VisibleIndex = 8;
            this.DEPT_NAME.Width = 60;
            // 
            // OCCUPATION
            // 
            this.OCCUPATION.Caption = "职别";
            this.OCCUPATION.FieldName = "OCCUPATION";
            this.OCCUPATION.Name = "OCCUPATION";
            this.OCCUPATION.Visible = true;
            this.OCCUPATION.VisibleIndex = 9;
            this.OCCUPATION.Width = 68;
            // 
            // DISCHARGE_DATE_TIME
            // 
            this.DISCHARGE_DATE_TIME.Caption = "出院日期";
            this.DISCHARGE_DATE_TIME.FieldName = "DISCHARGE_DATE_TIME";
            this.DISCHARGE_DATE_TIME.Name = "DISCHARGE_DATE_TIME";
            this.DISCHARGE_DATE_TIME.Visible = true;
            this.DISCHARGE_DATE_TIME.VisibleIndex = 10;
            this.DISCHARGE_DATE_TIME.Width = 72;
            // 
            // INHOSDAYS
            // 
            this.INHOSDAYS.Caption = "住院日数";
            this.INHOSDAYS.FieldName = "INHOSDAYS";
            this.INHOSDAYS.Name = "INHOSDAYS";
            this.INHOSDAYS.Visible = true;
            this.INHOSDAYS.VisibleIndex = 11;
            this.INHOSDAYS.Width = 64;
            // 
            // DISCHARGE_CONDITIONS
            // 
            this.DISCHARGE_CONDITIONS.Caption = "出院情况";
            this.DISCHARGE_CONDITIONS.FieldName = "DISCHARGE_CONDITIONS";
            this.DISCHARGE_CONDITIONS.Name = "DISCHARGE_CONDITIONS";
            this.DISCHARGE_CONDITIONS.Visible = true;
            this.DISCHARGE_CONDITIONS.VisibleIndex = 14;
            // 
            // DIAGNOSIS
            // 
            this.DIAGNOSIS.Caption = "入院诊断时治疗经过或施行手术";
            this.DIAGNOSIS.FieldName = "DIAGNOSIS";
            this.DIAGNOSIS.Name = "DIAGNOSIS";
            this.DIAGNOSIS.Visible = true;
            this.DIAGNOSIS.VisibleIndex = 12;
            this.DIAGNOSIS.Width = 110;
            // 
            // DISCHARGE_DIAGNOSIS
            // 
            this.DISCHARGE_DIAGNOSIS.Caption = "出院时诊断";
            this.DISCHARGE_DIAGNOSIS.FieldName = "DISCHARGE_DIAGNOSIS";
            this.DISCHARGE_DIAGNOSIS.Name = "DISCHARGE_DIAGNOSIS";
            this.DISCHARGE_DIAGNOSIS.Visible = true;
            this.DISCHARGE_DIAGNOSIS.VisibleIndex = 13;
            this.DISCHARGE_DIAGNOSIS.Width = 106;
            // 
            // CLINIC_DIAG
            // 
            this.CLINIC_DIAG.Caption = "并发症";
            this.CLINIC_DIAG.FieldName = "CLINIC_DIAG";
            this.CLINIC_DIAG.Name = "CLINIC_DIAG";
            this.CLINIC_DIAG.Visible = true;
            this.CLINIC_DIAG.VisibleIndex = 15;
            this.CLINIC_DIAG.Width = 65;
            // 
            // MAILING_ADDRESS
            // 
            this.MAILING_ADDRESS.Caption = "住址";
            this.MAILING_ADDRESS.FieldName = "MAILING_ADDRESS";
            this.MAILING_ADDRESS.Name = "MAILING_ADDRESS";
            this.MAILING_ADDRESS.Visible = true;
            this.MAILING_ADDRESS.VisibleIndex = 16;
            this.MAILING_ADDRESS.Width = 69;
            // 
            // DOCTOR_IN_CHARGE
            // 
            this.DOCTOR_IN_CHARGE.Caption = "负责医生";
            this.DOCTOR_IN_CHARGE.FieldName = "DOCTOR_IN_CHARGE";
            this.DOCTOR_IN_CHARGE.Name = "DOCTOR_IN_CHARGE";
            this.DOCTOR_IN_CHARGE.Visible = true;
            this.DOCTOR_IN_CHARGE.VisibleIndex = 17;
            // 
            // CONSULTING_DOCTOR
            // 
            this.CONSULTING_DOCTOR.Caption = "门诊医生";
            this.CONSULTING_DOCTOR.FieldName = "CONSULTING_DOCTOR";
            this.CONSULTING_DOCTOR.Name = "CONSULTING_DOCTOR";
            this.CONSULTING_DOCTOR.Visible = true;
            this.CONSULTING_DOCTOR.VisibleIndex = 18;
            // 
            // NEXT_OF_SKIN
            // 
            this.NEXT_OF_SKIN.Caption = "联系人";
            this.NEXT_OF_SKIN.FieldName = "NEXT_OF_KIN";
            this.NEXT_OF_SKIN.Name = "NEXT_OF_SKIN";
            this.NEXT_OF_SKIN.Visible = true;
            this.NEXT_OF_SKIN.VisibleIndex = 19;
            // 
            // RELATION_SHIP
            // 
            this.RELATION_SHIP.Caption = "关系";
            this.RELATION_SHIP.FieldName = "RELATIONSHIP";
            this.RELATION_SHIP.Name = "RELATION_SHIP";
            this.RELATION_SHIP.Visible = true;
            this.RELATION_SHIP.VisibleIndex = 20;
            // 
            // NEXT_OF_KIN_PHONE
            // 
            this.NEXT_OF_KIN_PHONE.Caption = "联系电话";
            this.NEXT_OF_KIN_PHONE.FieldName = "NEXT_OF_KIN_PHONE";
            this.NEXT_OF_KIN_PHONE.Name = "NEXT_OF_KIN_PHONE";
            this.NEXT_OF_KIN_PHONE.Visible = true;
            this.NEXT_OF_KIN_PHONE.VisibleIndex = 21;
            // 
            // SFCRCFZD
            // 
            this.SFCRCFZD.Caption = "是否有传染病，初或复诊";
            this.SFCRCFZD.FieldName = "SFCRCFZD";
            this.SFCRCFZD.Name = "SFCRCFZD";
            this.SFCRCFZD.Visible = true;
            this.SFCRCFZD.VisibleIndex = 22;
            this.SFCRCFZD.Width = 100;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.save_frm);
            this.groupBox1.Controls.Add(this.cmbDept);
            this.groupBox1.Controls.Add(this.sbtnUpdate);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 48);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条件";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(781, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "导出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // save_frm
            // 
            this.save_frm.Location = new System.Drawing.Point(620, 15);
            this.save_frm.Name = "save_frm";
            this.save_frm.Size = new System.Drawing.Size(65, 23);
            this.save_frm.TabIndex = 4;
            this.save_frm.Text = "保存";
            this.save_frm.UseVisualStyleBackColor = true;
            this.save_frm.Click += new System.EventHandler(this.save_frm_Click);
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
            this.sbtnUpdate.Location = new System.Drawing.Point(539, 15);
            this.sbtnUpdate.Name = "sbtnUpdate";
            this.sbtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.sbtnUpdate.TabIndex = 3;
            this.sbtnUpdate.Text = "刷  新";
            this.sbtnUpdate.Click += new System.EventHandler(this.sbtnUpdate_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(434, 17);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(99, 21);
            this.dtpEnd.TabIndex = 2;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(287, 17);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(103, 21);
            this.dtpStart.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "～～";
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
            this.label1.Text = "入院日期：";
            // 
            // frmHisCustomInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcPat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHisCustomInOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "科室入出院登记表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHisCustomInOut_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件FToolStripMenuItem;
        private ToolStripMenuItem 帮助HToolStripMenuItem;
        private GridControl gcPat;
        private GridView gvPat;
        private GridColumn PATIENT_ID;
        private GridColumn VISIT_ID;
        private GridColumn NAME;
        private GridColumn SEX;
        private GridColumn AGE;
        private GridColumn BIRTH_PLACE;
        private GridColumn INP_NO;
        private GridColumn DEPT_NAME;
        private GridColumn OCCUPATION;
        private GridColumn DISCHARGE_DATE_TIME;
        private GridColumn INHOSDAYS;
        private GridColumn DIAGNOSIS;
        private GridColumn DISCHARGE_DIAGNOSIS;
        private GridColumn CLINIC_DIAG;
        private GridColumn MAILING_ADDRESS;
        private GridColumn DOCTOR_IN_CHARGE;
        private GridColumn CONSULTING_DOCTOR;
        private GridColumn NEXT_OF_SKIN;
        private GridColumn RELATION_SHIP;
        private GridColumn NEXT_OF_KIN_PHONE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDept;
        private SimpleButton sbtnUpdate;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private ToolStripMenuItem 退出XToolStripMenuItem;
        private ToolStripMenuItem 保存为EXCEL文件ToolStripMenuItem;
        private GridColumn ADMISSION_DATE_TIME;
        private GridColumn SFCRCFZD;
        private System.Windows.Forms.Button save_frm;
        private RepositoryItemTextEdit repositoryItemTextEdit1;
        private GridColumn DISCHARGE_CONDITIONS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}