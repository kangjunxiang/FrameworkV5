using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Base;
namespace JHEMR.EMRHisCustom
{
    partial class frmHisCustomKsfy
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
            this.gcKsfy = new DevExpress.XtraGrid.GridControl();
            this.gvKsfy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BED_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PATIENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.INP_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YJJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JJFY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SJFY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YPFY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YPBL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FLAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbtnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcKsfy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKsfy)).BeginInit();
            this.SuspendLayout();
            // 
            // gcKsfy
            // 
            this.gcKsfy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcKsfy.EmbeddedNavigator.Name = "";
            this.gcKsfy.Location = new System.Drawing.Point(12, 12);
            this.gcKsfy.MainView = this.gvKsfy;
            this.gcKsfy.Name = "gcKsfy";
            this.gcKsfy.Size = new System.Drawing.Size(772, 464);
            this.gcKsfy.TabIndex = 0;
            this.gcKsfy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKsfy});
            // 
            // gvKsfy
            // 
            this.gvKsfy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BED_NO,
            this.PATIENT_ID,
            this.INP_NO,
            this.NAME,
            this.SEX,
            this.YJJ,
            this.JJFY,
            this.SJFY,
            this.YPFY,
            this.YPBL,
            this.FLAG});
            this.gvKsfy.GridControl = this.gcKsfy;
            this.gvKsfy.Name = "gvKsfy";
            this.gvKsfy.OptionsView.ColumnAutoWidth = false;
            this.gvKsfy.OptionsView.ShowGroupPanel = false;
            this.gvKsfy.OptionsView.ShowIndicator = false;
            this.gvKsfy.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvKsfy_CustomDrawCell);
            // 
            // BED_NO
            // 
            this.BED_NO.Caption = "床号";
            this.BED_NO.FieldName = "BED_NO";
            this.BED_NO.Name = "BED_NO";
            this.BED_NO.OptionsColumn.AllowEdit = false;
            this.BED_NO.OptionsColumn.AllowMove = false;
            this.BED_NO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.BED_NO.OptionsColumn.ReadOnly = true;
            this.BED_NO.OptionsFilter.AllowAutoFilter = false;
            this.BED_NO.OptionsFilter.AllowFilter = false;
            this.BED_NO.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.BED_NO.Visible = true;
            this.BED_NO.VisibleIndex = 0;
            this.BED_NO.Width = 45;
            // 
            // PATIENT_ID
            // 
            this.PATIENT_ID.Caption = "ID号";
            this.PATIENT_ID.FieldName = "PATIENT_ID";
            this.PATIENT_ID.Name = "PATIENT_ID";
            this.PATIENT_ID.OptionsColumn.AllowEdit = false;
            this.PATIENT_ID.OptionsColumn.AllowMove = false;
            this.PATIENT_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.PATIENT_ID.OptionsColumn.ReadOnly = true;
            this.PATIENT_ID.OptionsFilter.AllowAutoFilter = false;
            this.PATIENT_ID.OptionsFilter.AllowFilter = false;
            this.PATIENT_ID.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.PATIENT_ID.Visible = true;
            this.PATIENT_ID.VisibleIndex = 1;
            this.PATIENT_ID.Width = 80;
            // 
            // INP_NO
            // 
            this.INP_NO.Caption = "住院号";
            this.INP_NO.FieldName = "INP_NO";
            this.INP_NO.Name = "INP_NO";
            this.INP_NO.OptionsColumn.AllowEdit = false;
            this.INP_NO.OptionsColumn.AllowMove = false;
            this.INP_NO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.INP_NO.OptionsColumn.ReadOnly = true;
            this.INP_NO.OptionsFilter.AllowAutoFilter = false;
            this.INP_NO.OptionsFilter.AllowFilter = false;
            this.INP_NO.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.INP_NO.Visible = true;
            this.INP_NO.VisibleIndex = 2;
            this.INP_NO.Width = 62;
            // 
            // NAME
            // 
            this.NAME.Caption = "姓名";
            this.NAME.FieldName = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.OptionsColumn.AllowEdit = false;
            this.NAME.OptionsColumn.AllowMove = false;
            this.NAME.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.NAME.OptionsColumn.ReadOnly = true;
            this.NAME.OptionsFilter.AllowAutoFilter = false;
            this.NAME.OptionsFilter.AllowFilter = false;
            this.NAME.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.NAME.Visible = true;
            this.NAME.VisibleIndex = 3;
            this.NAME.Width = 62;
            // 
            // SEX
            // 
            this.SEX.Caption = "性别";
            this.SEX.FieldName = "SEX";
            this.SEX.Name = "SEX";
            this.SEX.OptionsColumn.AllowEdit = false;
            this.SEX.OptionsColumn.AllowMove = false;
            this.SEX.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.SEX.OptionsColumn.ReadOnly = true;
            this.SEX.OptionsFilter.AllowAutoFilter = false;
            this.SEX.OptionsFilter.AllowFilter = false;
            this.SEX.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.SEX.Visible = true;
            this.SEX.VisibleIndex = 4;
            this.SEX.Width = 47;
            // 
            // YJJ
            // 
            this.YJJ.AppearanceCell.Options.UseTextOptions = true;
            this.YJJ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.YJJ.Caption = "   预交金";
            this.YJJ.FieldName = "YJJ";
            this.YJJ.Name = "YJJ";
            this.YJJ.OptionsColumn.AllowEdit = false;
            this.YJJ.OptionsColumn.AllowMove = false;
            this.YJJ.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.YJJ.OptionsColumn.ReadOnly = true;
            this.YJJ.OptionsFilter.AllowAutoFilter = false;
            this.YJJ.OptionsFilter.AllowFilter = false;
            this.YJJ.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.YJJ.Visible = true;
            this.YJJ.VisibleIndex = 5;
            this.YJJ.Width = 70;
            // 
            // JJFY
            // 
            this.JJFY.AppearanceCell.Options.UseTextOptions = true;
            this.JJFY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.JJFY.Caption = "    计价金额";
            this.JJFY.FieldName = "JJFY";
            this.JJFY.Name = "JJFY";
            this.JJFY.OptionsColumn.AllowEdit = false;
            this.JJFY.OptionsColumn.AllowMove = false;
            this.JJFY.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.JJFY.OptionsColumn.ReadOnly = true;
            this.JJFY.OptionsFilter.AllowAutoFilter = false;
            this.JJFY.OptionsFilter.AllowFilter = false;
            this.JJFY.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.JJFY.Visible = true;
            this.JJFY.VisibleIndex = 6;
            this.JJFY.Width = 84;
            // 
            // SJFY
            // 
            this.SJFY.AppearanceCell.Options.UseTextOptions = true;
            this.SJFY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SJFY.Caption = "   实际金额";
            this.SJFY.FieldName = "SJFY";
            this.SJFY.Name = "SJFY";
            this.SJFY.OptionsColumn.AllowEdit = false;
            this.SJFY.OptionsColumn.AllowMove = false;
            this.SJFY.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.SJFY.OptionsColumn.ReadOnly = true;
            this.SJFY.OptionsFilter.AllowAutoFilter = false;
            this.SJFY.OptionsFilter.AllowFilter = false;
            this.SJFY.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.SJFY.Visible = true;
            this.SJFY.VisibleIndex = 7;
            this.SJFY.Width = 80;
            // 
            // YPFY
            // 
            this.YPFY.AppearanceCell.Options.UseTextOptions = true;
            this.YPFY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.YPFY.Caption = " 药品计价金额";
            this.YPFY.FieldName = "YPFY";
            this.YPFY.Name = "YPFY";
            this.YPFY.OptionsColumn.AllowEdit = false;
            this.YPFY.OptionsColumn.AllowMove = false;
            this.YPFY.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.YPFY.OptionsColumn.ReadOnly = true;
            this.YPFY.OptionsFilter.AllowAutoFilter = false;
            this.YPFY.OptionsFilter.AllowFilter = false;
            this.YPFY.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.YPFY.Visible = true;
            this.YPFY.VisibleIndex = 8;
            this.YPFY.Width = 96;
            // 
            // YPBL
            // 
            this.YPBL.AppearanceCell.Options.UseTextOptions = true;
            this.YPBL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.YPBL.Caption = "   药费比(%)";
            this.YPBL.FieldName = "YPBL";
            this.YPBL.Name = "YPBL";
            this.YPBL.OptionsColumn.AllowEdit = false;
            this.YPBL.OptionsColumn.AllowMove = false;
            this.YPBL.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.YPBL.OptionsColumn.ReadOnly = true;
            this.YPBL.OptionsFilter.AllowAutoFilter = false;
            this.YPBL.OptionsFilter.AllowFilter = false;
            this.YPBL.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.YPBL.Visible = true;
            this.YPBL.VisibleIndex = 9;
            this.YPBL.Width = 89;
            // 
            // FLAG
            // 
            this.FLAG.Caption = "T";
            this.FLAG.FieldName = "FLAG";
            this.FLAG.Name = "FLAG";
            this.FLAG.OptionsColumn.AllowEdit = false;
            this.FLAG.OptionsColumn.AllowMove = false;
            this.FLAG.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.FLAG.OptionsColumn.ReadOnly = true;
            this.FLAG.OptionsFilter.AllowAutoFilter = false;
            this.FLAG.OptionsFilter.AllowFilter = false;
            this.FLAG.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.FLAG.Visible = true;
            this.FLAG.VisibleIndex = 10;
            this.FLAG.Width = 26;
            // 
            // sbtnQuery
            // 
            this.sbtnQuery.Location = new System.Drawing.Point(343, 482);
            this.sbtnQuery.Name = "sbtnQuery";
            this.sbtnQuery.Size = new System.Drawing.Size(75, 23);
            this.sbtnQuery.TabIndex = 1;
            this.sbtnQuery.Text = "查询";
            this.sbtnQuery.Click += new System.EventHandler(this.sbtnQuery_Click);
            // 
            // sbtnPrint
            // 
            this.sbtnPrint.Location = new System.Drawing.Point(448, 482);
            this.sbtnPrint.Name = "sbtnPrint";
            this.sbtnPrint.Size = new System.Drawing.Size(75, 23);
            this.sbtnPrint.TabIndex = 1;
            this.sbtnPrint.Text = "打印";
            this.sbtnPrint.Click += new System.EventHandler(this.sbtnPrint_Click);
            // 
            // sbtnClear
            // 
            this.sbtnClear.Location = new System.Drawing.Point(570, 482);
            this.sbtnClear.Name = "sbtnClear";
            this.sbtnClear.Size = new System.Drawing.Size(75, 23);
            this.sbtnClear.TabIndex = 1;
            this.sbtnClear.Text = "清屏";
            this.sbtnClear.Click += new System.EventHandler(this.sbtnClear_Click);
            // 
            // sbtnClose
            // 
            this.sbtnClose.Location = new System.Drawing.Point(692, 482);
            this.sbtnClose.Name = "sbtnClose";
            this.sbtnClose.Size = new System.Drawing.Size(75, 23);
            this.sbtnClose.TabIndex = 1;
            this.sbtnClose.Text = "关闭";
            this.sbtnClose.Click += new System.EventHandler(this.sbtnClose_Click);
            // 
            // frmHisCustomKsfy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 517);
            this.Controls.Add(this.sbtnClose);
            this.Controls.Add(this.sbtnClear);
            this.Controls.Add(this.sbtnPrint);
            this.Controls.Add(this.sbtnQuery);
            this.Controls.Add(this.gcKsfy);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHisCustomKsfy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "科室病人费用查询";
            this.Load += new System.EventHandler(this.frmHisCustomKsfy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcKsfy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKsfy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GridControl gcKsfy;
        private GridView gvKsfy;
        private GridColumn BED_NO;
        private GridColumn PATIENT_ID;
        private GridColumn INP_NO;
        private GridColumn NAME;
        private GridColumn SEX;
        private GridColumn JJFY;
        private GridColumn SJFY;
        private GridColumn YPFY;
        private GridColumn YPBL;
        private GridColumn YJJ;
        private SimpleButton sbtnQuery;
        private SimpleButton sbtnPrint;
        private SimpleButton sbtnClear;
        private SimpleButton sbtnClose;
        private GridColumn FLAG;
    }
}