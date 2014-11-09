using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Base;
namespace JHEMR.EMRHisCustom
{
    partial class frmHisCustomHistory
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
            this.gcNum = new DevExpress.XtraGrid.GridControl();
            this.gvNum = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PATIENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VISIT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.spbtnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gcNum
            // 
            this.gcNum.EmbeddedNavigator.Name = "";
            this.gcNum.Location = new System.Drawing.Point(1, 1);
            this.gcNum.MainView = this.gvNum;
            this.gcNum.Name = "gcNum";
            this.gcNum.Size = new System.Drawing.Size(304, 219);
            this.gcNum.TabIndex = 0;
            this.gcNum.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNum,
            this.gridView2});
            // 
            // gvNum
            // 
            this.gvNum.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PATIENT_ID,
            this.VISIT_ID,
            this.NUM});
            this.gvNum.GridControl = this.gcNum;
            this.gvNum.Name = "gvNum";
            this.gvNum.OptionsView.ColumnAutoWidth = false;
            this.gvNum.OptionsView.ShowGroupPanel = false;
            // 
            // PATIENT_ID
            // 
            this.PATIENT_ID.Caption = "病人ID";
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
            this.PATIENT_ID.VisibleIndex = 0;
            this.PATIENT_ID.Width = 104;
            // 
            // VISIT_ID
            // 
            this.VISIT_ID.Caption = "住院次";
            this.VISIT_ID.FieldName = "VISIT_ID";
            this.VISIT_ID.Name = "VISIT_ID";
            this.VISIT_ID.OptionsColumn.AllowEdit = false;
            this.VISIT_ID.OptionsColumn.AllowMove = false;
            this.VISIT_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.VISIT_ID.OptionsColumn.ReadOnly = true;
            this.VISIT_ID.OptionsFilter.AllowAutoFilter = false;
            this.VISIT_ID.OptionsFilter.AllowFilter = false;
            this.VISIT_ID.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.VISIT_ID.Visible = true;
            this.VISIT_ID.VisibleIndex = 1;
            this.VISIT_ID.Width = 78;
            // 
            // NUM
            // 
            this.NUM.Caption = "上报次";
            this.NUM.FieldName = "NUM";
            this.NUM.Name = "NUM";
            this.NUM.OptionsColumn.AllowEdit = false;
            this.NUM.OptionsColumn.AllowMove = false;
            this.NUM.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.NUM.OptionsColumn.ReadOnly = true;
            this.NUM.OptionsFilter.AllowAutoFilter = false;
            this.NUM.OptionsFilter.AllowFilter = false;
            this.NUM.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.NUM.Visible = true;
            this.NUM.VisibleIndex = 2;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcNum;
            this.gridView2.Name = "gridView2";
            // 
            // spbtnConfirm
            // 
            this.spbtnConfirm.Location = new System.Drawing.Point(119, 228);
            this.spbtnConfirm.Name = "spbtnConfirm";
            this.spbtnConfirm.Size = new System.Drawing.Size(75, 23);
            this.spbtnConfirm.TabIndex = 1;
            this.spbtnConfirm.Text = "确定(&C)";
            this.spbtnConfirm.Click += new System.EventHandler(this.spbtnConfirm_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(221, 228);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "取消(&X)";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frmHisCustomHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 261);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.spbtnConfirm);
            this.Controls.Add(this.gcNum);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHisCustomHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "住院次以及上报次选择";
            this.Load += new System.EventHandler(this.frmHisCustomHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GridControl gcNum;
        private GridView gvNum;
        private GridView gridView2;
        private SimpleButton spbtnConfirm;
        private SimpleButton simpleButton2;
        private GridColumn PATIENT_ID;
        private GridColumn VISIT_ID;
        private GridColumn NUM;
    }
}