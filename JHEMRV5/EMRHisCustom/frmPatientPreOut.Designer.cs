using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Base;
namespace JHEMR.EMRHisCustom
{
    partial class frmPatientPreOut
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
            this.panel1 = new Panel();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.label1 = new Label();
            this.lblPyItemName = new Label();
            this.gcOUT = new GridControl();
            this.gvOUT = new GridView();
            this.BED_LABEL = new GridColumn();
            this.DISCHARGE_DATE_EXPCTED = new GridColumn();
            this.repositoryItemDateEdit2 = new RepositoryItemDateEdit();
            this.NAME = new GridColumn();
            this.SEX = new GridColumn();
            this.PATIENT_ID = new GridColumn();
            this.DIAGNOSIS = new GridColumn();
            this.ADMISSION_DATE_TIME = new GridColumn();
            this.repositoryItemTimeEdit1 = new RepositoryItemTimeEdit();
            this.repositoryItemCalcEdit1 = new RepositoryItemCalcEdit();
            this.repositoryItemDateEdit1 = new RepositoryItemDateEdit();
            this.sbtnAdd = new SimpleButton();
            this.sbtnDel = new SimpleButton();
            this.sbtnSave = new SimpleButton();
            this.sbtnClose = new SimpleButton();
            this.sbtnHelp = new SimpleButton();
            this.panel1.SuspendLayout();
            ((ISupportInitialize)this.gcOUT).BeginInit();
            ((ISupportInitialize)this.gvOUT).BeginInit();
            ((ISupportInitialize)this.repositoryItemDateEdit2).BeginInit();
            ((ISupportInitialize)this.repositoryItemDateEdit2.VistaTimeProperties).BeginInit();
            ((ISupportInitialize)this.repositoryItemTimeEdit1).BeginInit();
            ((ISupportInitialize)this.repositoryItemCalcEdit1).BeginInit();
            ((ISupportInitialize)this.repositoryItemDateEdit1).BeginInit();
            ((ISupportInitialize)this.repositoryItemDateEdit1.VistaTimeProperties).BeginInit();
            base.SuspendLayout();
            this.panel1.Controls.Add(this.cmbDept);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblPyItemName);
            this.panel1.Dock = DockStyle.Top;
            this.panel1.Location = new Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(618, 29);
            this.panel1.TabIndex = 2;
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new Point(48, 6);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new Size(170, 20);
            this.cmbDept.TabIndex = 1;
            this.cmbDept.SelectedIndexChanged += new EventHandler(this.cmbDept_SelectedIndexChanged);
            this.label1.AutoSize = true;
            this.label1.Location = new Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(31, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "科室";
            this.lblPyItemName.AutoSize = true;
            this.lblPyItemName.Location = new Point(243, 9);
            this.lblPyItemName.Name = "lblPyItemName";
            this.lblPyItemName.Size = new Size(0, 14);
            this.lblPyItemName.TabIndex = 0;
            this.lblPyItemName.Visible = false;
            this.gcOUT.EmbeddedNavigator.Name = "";
            this.gcOUT.Location = new Point(12, 35);
            this.gcOUT.MainView = this.gvOUT;
            this.gcOUT.Name = "gcOUT";
            this.gcOUT.RepositoryItems.AddRange(new RepositoryItem[]
			{
				this.repositoryItemTimeEdit1,
				this.repositoryItemCalcEdit1,
				this.repositoryItemDateEdit1,
				this.repositoryItemDateEdit2
			});
            this.gcOUT.Size = new Size(594, 323);
            this.gcOUT.TabIndex = 3;
            this.gcOUT.ViewCollection.AddRange(new BaseView[]
			{
				this.gvOUT
			});
            this.gvOUT.Columns.AddRange(new GridColumn[]
			{
				this.BED_LABEL,
				this.DISCHARGE_DATE_EXPCTED,
				this.NAME,
				this.SEX,
				this.PATIENT_ID,
				this.DIAGNOSIS,
				this.ADMISSION_DATE_TIME
			});
            this.gvOUT.GridControl = this.gcOUT;
            this.gvOUT.Name = "gvOUT";
            this.gvOUT.OptionsView.ColumnAutoWidth = false;
            this.gvOUT.OptionsView.ShowGroupPanel = false;
            this.gvOUT.OptionsView.ShowIndicator = false;
            this.gvOUT.CellValueChanged += new CellValueChangedEventHandler(this.gvOUT_CellValueChanged);
            this.gvOUT.KeyDown += new KeyEventHandler(this.gvOUT_KeyDown);
            this.gvOUT.CustomDrawCell += new RowCellCustomDrawEventHandler(this.gvOUT_CustomDrawCell);
            this.gvOUT.ShownEditor += new EventHandler(this.gvOUT_ShownEditor);
            this.gvOUT.HiddenEditor += new EventHandler(this.gvOUT_HiddenEditor);
            this.BED_LABEL.Caption = "床号";
            this.BED_LABEL.FieldName = "BED_LABEL";
            this.BED_LABEL.Name = "BED_LABEL";
            this.BED_LABEL.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.BED_LABEL.Visible = true;
            this.BED_LABEL.VisibleIndex = 0;
            this.BED_LABEL.Width = 50;
            this.DISCHARGE_DATE_EXPCTED.Caption = "预计出院日期";
            this.DISCHARGE_DATE_EXPCTED.ColumnEdit = this.repositoryItemDateEdit2;
            this.DISCHARGE_DATE_EXPCTED.FieldName = "DISCHARGE_DATE_EXPCTED";
            this.DISCHARGE_DATE_EXPCTED.Name = "DISCHARGE_DATE_EXPCTED";
            this.DISCHARGE_DATE_EXPCTED.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.DISCHARGE_DATE_EXPCTED.Visible = true;
            this.DISCHARGE_DATE_EXPCTED.VisibleIndex = 1;
            this.DISCHARGE_DATE_EXPCTED.Width = 110;
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton(ButtonPredefines.Combo, "", -1, true, false, false, HorzAlignment.Center, null)
			});
            this.repositoryItemDateEdit2.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.repositoryItemDateEdit2.DisplayFormat.FormatType = FormatType.Custom;
            this.repositoryItemDateEdit2.EditFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.repositoryItemDateEdit2.EditFormat.FormatType = FormatType.Custom;
            this.repositoryItemDateEdit2.Mask.EditMask = "g";
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            this.repositoryItemDateEdit2.VistaTimeProperties.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton()
			});
            this.NAME.Caption = "姓名";
            this.NAME.FieldName = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.OptionsColumn.AllowEdit = false;
            this.NAME.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.NAME.OptionsColumn.ReadOnly = true;
            this.NAME.Visible = true;
            this.NAME.VisibleIndex = 2;
            this.SEX.Caption = "性别";
            this.SEX.FieldName = "SEX";
            this.SEX.Name = "SEX";
            this.SEX.OptionsColumn.AllowEdit = false;
            this.SEX.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.SEX.OptionsColumn.ReadOnly = true;
            this.SEX.Visible = true;
            this.SEX.VisibleIndex = 3;
            this.SEX.Width = 46;
            this.PATIENT_ID.Caption = "病人ID";
            this.PATIENT_ID.FieldName = "PATIENT_ID";
            this.PATIENT_ID.Name = "PATIENT_ID";
            this.PATIENT_ID.OptionsColumn.AllowEdit = false;
            this.PATIENT_ID.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.PATIENT_ID.OptionsColumn.ReadOnly = true;
            this.PATIENT_ID.Visible = true;
            this.PATIENT_ID.VisibleIndex = 4;
            this.PATIENT_ID.Width = 57;
            this.DIAGNOSIS.Caption = "诊断";
            this.DIAGNOSIS.FieldName = "DIAGNOSIS";
            this.DIAGNOSIS.Name = "DIAGNOSIS";
            this.DIAGNOSIS.OptionsColumn.AllowEdit = false;
            this.DIAGNOSIS.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.DIAGNOSIS.OptionsColumn.ReadOnly = true;
            this.DIAGNOSIS.Visible = true;
            this.DIAGNOSIS.VisibleIndex = 5;
            this.DIAGNOSIS.Width = 122;
            this.ADMISSION_DATE_TIME.Caption = "入院日期";
            this.ADMISSION_DATE_TIME.ColumnEdit = this.repositoryItemDateEdit2;
            this.ADMISSION_DATE_TIME.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.ADMISSION_DATE_TIME.FieldName = "ADMISSION_DATE_TIME";
            this.ADMISSION_DATE_TIME.Name = "ADMISSION_DATE_TIME";
            this.ADMISSION_DATE_TIME.OptionsColumn.AllowEdit = false;
            this.ADMISSION_DATE_TIME.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.ADMISSION_DATE_TIME.OptionsColumn.ReadOnly = true;
            this.ADMISSION_DATE_TIME.Visible = true;
            this.ADMISSION_DATE_TIME.VisibleIndex = 6;
            this.ADMISSION_DATE_TIME.Width = 105;
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton()
			});
            this.repositoryItemTimeEdit1.EditFormat.FormatString = "yyyy-MM-dd HH:ss";
            this.repositoryItemTimeEdit1.EditFormat.FormatType = FormatType.Custom;
            this.repositoryItemTimeEdit1.Mask.EditMask = "DT";
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton(ButtonPredefines.Combo)
			});
            this.repositoryItemCalcEdit1.EditFormat.FormatString = "yyyy-MM-dd HH:ss";
            this.repositoryItemCalcEdit1.EditFormat.FormatType = FormatType.Custom;
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton(ButtonPredefines.Combo, "", -1, true, false, false, HorzAlignment.Center, null)
			});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton()
			});
            this.sbtnAdd.Location = new Point(118, 375);
            this.sbtnAdd.Name = "sbtnAdd";
            this.sbtnAdd.Size = new Size(75, 23);
            this.sbtnAdd.TabIndex = 4;
            this.sbtnAdd.Text = "新增(&A)";
            this.sbtnAdd.Click += new EventHandler(this.sbtnAdd_Click);
            this.sbtnDel.Location = new Point(216, 375);
            this.sbtnDel.Name = "sbtnDel";
            this.sbtnDel.Size = new Size(75, 23);
            this.sbtnDel.TabIndex = 4;
            this.sbtnDel.Text = "删除(&D)";
            this.sbtnDel.Click += new EventHandler(this.sbtnDel_Click);
            this.sbtnSave.Location = new Point(314, 375);
            this.sbtnSave.Name = "sbtnSave";
            this.sbtnSave.Size = new Size(75, 23);
            this.sbtnSave.TabIndex = 4;
            this.sbtnSave.Text = "保存(&S)";
            this.sbtnSave.Click += new EventHandler(this.sbtnSave_Click);
            this.sbtnClose.Location = new Point(412, 375);
            this.sbtnClose.Name = "sbtnClose";
            this.sbtnClose.Size = new Size(75, 23);
            this.sbtnClose.TabIndex = 4;
            this.sbtnClose.Text = "关闭(&C)";
            this.sbtnClose.Click += new EventHandler(this.sbtnClose_Click);
            this.sbtnHelp.Location = new Point(510, 377);
            this.sbtnHelp.Name = "sbtnHelp";
            this.sbtnHelp.Size = new Size(75, 23);
            this.sbtnHelp.TabIndex = 4;
            this.sbtnHelp.Text = "帮助(&H)";
            this.sbtnHelp.Visible = false;
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.ClientSize = new Size(618, 412);
            base.Controls.Add(this.sbtnHelp);
            base.Controls.Add(this.sbtnClose);
            base.Controls.Add(this.sbtnSave);
            base.Controls.Add(this.sbtnDel);
            base.Controls.Add(this.sbtnAdd);
            base.Controls.Add(this.gcOUT);
            base.Controls.Add(this.panel1);
            base.Name = "frmPatientPreOut";
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "预 计 出 院 病 人";
            base.Load += new EventHandler(this.frmPatientPreOut_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((ISupportInitialize)this.gcOUT).EndInit();
            ((ISupportInitialize)this.gvOUT).EndInit();
            ((ISupportInitialize)this.repositoryItemDateEdit2.VistaTimeProperties).EndInit();
            ((ISupportInitialize)this.repositoryItemDateEdit2).EndInit();
            ((ISupportInitialize)this.repositoryItemTimeEdit1).EndInit();
            ((ISupportInitialize)this.repositoryItemCalcEdit1).EndInit();
            ((ISupportInitialize)this.repositoryItemDateEdit1.VistaTimeProperties).EndInit();
            ((ISupportInitialize)this.repositoryItemDateEdit1).EndInit();
            base.ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private System.Windows.Forms.ComboBox cmbDept;
        private Label label1;
        private Label lblPyItemName;
        private GridControl gcOUT;
        private GridView gvOUT;
        private GridColumn BED_LABEL;
        private GridColumn DISCHARGE_DATE_EXPCTED;
        private GridColumn NAME;
        private GridColumn SEX;
        private GridColumn PATIENT_ID;
        private GridColumn DIAGNOSIS;
        private GridColumn ADMISSION_DATE_TIME;
        private RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private SimpleButton sbtnAdd;
        private SimpleButton sbtnDel;
        private SimpleButton sbtnSave;
        private SimpleButton sbtnClose;
        private SimpleButton sbtnHelp;
        private RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private RepositoryItemDateEdit repositoryItemDateEdit1;
        private RepositoryItemDateEdit repositoryItemDateEdit2;
    }
}