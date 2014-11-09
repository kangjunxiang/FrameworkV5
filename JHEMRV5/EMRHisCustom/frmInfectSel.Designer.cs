using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.Utils;
using System;
using DevExpress.XtraGrid.Views.Base;
namespace JHEMR.EMRHisCustom
{
    partial class frmInfectSel
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
            this.btnSel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtInpNo = new DevExpress.XtraEditors.TextEdit();
            this.gcPatVisit = new DevExpress.XtraGrid.GridControl();
            this.gvPatvisit = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PATIENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VISIT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtInpNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatVisit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatvisit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSel
            // 
            this.btnSel.Location = new System.Drawing.Point(224, 19);
            this.btnSel.Name = "btnSel";
            this.btnSel.Size = new System.Drawing.Size(75, 25);
            this.btnSel.TabIndex = 0;
            this.btnSel.Text = "查　询";
            this.btnSel.Click += new System.EventHandler(this.btnSel_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "病案号：";
            // 
            // txtInpNo
            // 
            this.txtInpNo.Location = new System.Drawing.Point(74, 21);
            this.txtInpNo.Name = "txtInpNo";
            this.txtInpNo.Size = new System.Drawing.Size(100, 21);
            this.txtInpNo.TabIndex = 2;
            // 
            // gcPatVisit
            // 
            this.gcPatVisit.EmbeddedNavigator.Name = "";
            this.gcPatVisit.Location = new System.Drawing.Point(12, 62);
            this.gcPatVisit.MainView = this.gvPatvisit;
            this.gcPatVisit.Name = "gcPatVisit";
            this.gcPatVisit.Size = new System.Drawing.Size(308, 160);
            this.gcPatVisit.TabIndex = 3;
            this.gcPatVisit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPatvisit});
            // 
            // gvPatvisit
            // 
            this.gvPatvisit.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PATIENT_ID,
            this.VISIT_ID,
            this.NAME});
            this.gvPatvisit.GridControl = this.gcPatVisit;
            this.gvPatvisit.Name = "gvPatvisit";
            this.gvPatvisit.OptionsView.ShowGroupPanel = false;
            this.gvPatvisit.DoubleClick += new System.EventHandler(this.gvPatvisit_DoubleClick);
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
            // 
            // NAME
            // 
            this.NAME.Caption = " 姓名";
            this.NAME.FieldName = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.OptionsColumn.AllowEdit = false;
            this.NAME.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.NAME.OptionsColumn.ReadOnly = true;
            this.NAME.Visible = true;
            this.NAME.VisibleIndex = 2;
            // 
            // frmInfectSel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 248);
            this.Controls.Add(this.gcPatVisit);
            this.Controls.Add(this.txtInpNo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnSel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInfectSel";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "感染出院病人上报";
            ((System.ComponentModel.ISupportInitialize)(this.txtInpNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatVisit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatvisit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SimpleButton btnSel;
        private LabelControl labelControl1;
        private TextEdit txtInpNo;
        private GridControl gcPatVisit;
        private GridView gvPatvisit;
        private GridColumn PATIENT_ID;
        private GridColumn VISIT_ID;
        private GridColumn NAME;
    }
}