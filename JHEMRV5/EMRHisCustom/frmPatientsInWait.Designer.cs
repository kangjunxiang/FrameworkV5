using System.Windows.Forms;
using System;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Base;
using System.ComponentModel;
namespace JHEMR.EMRHisCustom
{
    partial class frmPatientsInWait
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
            this.gridWaitForBeds = new DevExpress.XtraGrid.GridControl();
            this.gridViewWaitForBeds = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PHONE_NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridWaitForBeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWaitForBeds)).BeginInit();
            this.SuspendLayout();
            // 
            // gridWaitForBeds
            // 
            this.gridWaitForBeds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridWaitForBeds.EmbeddedNavigator.Name = "";
            this.gridWaitForBeds.Location = new System.Drawing.Point(4, 3);
            this.gridWaitForBeds.MainView = this.gridViewWaitForBeds;
            this.gridWaitForBeds.Name = "gridWaitForBeds";
            this.gridWaitForBeds.Size = new System.Drawing.Size(668, 406);
            this.gridWaitForBeds.TabIndex = 0;
            this.gridWaitForBeds.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWaitForBeds});
            // 
            // gridViewWaitForBeds
            // 
            this.gridViewWaitForBeds.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.PHONE_NUMBER});
            this.gridViewWaitForBeds.GridControl = this.gridWaitForBeds;
            this.gridViewWaitForBeds.Name = "gridViewWaitForBeds";
            this.gridViewWaitForBeds.OptionsBehavior.Editable = false;
            this.gridViewWaitForBeds.OptionsView.ColumnAutoWidth = false;
            this.gridViewWaitForBeds.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "等 床 科 室";
            this.gridColumn1.FieldName = "DEPT_NAME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 147;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "姓 名";
            this.gridColumn2.FieldName = "NAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 54;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "性别";
            this.gridColumn3.FieldName = "SEX";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 51;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "年龄";
            this.gridColumn4.FieldName = "AGE";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 57;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "费别";
            this.gridColumn5.FieldName = "CHARGE_TYPE";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 65;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "登记日期";
            this.gridColumn6.FieldName = "REGISTERING_DATE";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 108;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "诊         断";
            this.gridColumn7.FieldName = "CLINIC_DIAGNOSIS";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 138;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "通  信  地  址";
            this.gridColumn8.FieldName = "MAILING_ADDRESS";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 244;
            // 
            // PHONE_NUMBER
            // 
            this.PHONE_NUMBER.Caption = "电话号码";
            this.PHONE_NUMBER.FieldName = "PHONE_NUMBER";
            this.PHONE_NUMBER.Name = "PHONE_NUMBER";
            this.PHONE_NUMBER.OptionsColumn.AllowEdit = false;
            this.PHONE_NUMBER.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.PHONE_NUMBER.OptionsColumn.ReadOnly = true;
            this.PHONE_NUMBER.Visible = true;
            this.PHONE_NUMBER.VisibleIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(564, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "关闭(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPatientsInWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gridWaitForBeds);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPatientsInWait";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "等床病人情况";
            this.Load += new System.EventHandler(this.frmPatientsInWait_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridWaitForBeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWaitForBeds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GridControl gridWaitForBeds;
        private GridView gridViewWaitForBeds;
        private SimpleButton btnCancel;
        private GridColumn gridColumn1;
        private GridColumn gridColumn2;
        private GridColumn gridColumn3;
        private GridColumn gridColumn4;
        private GridColumn gridColumn5;
        private GridColumn gridColumn6;
        private GridColumn gridColumn7;
        private GridColumn gridColumn8;
        private GridColumn PHONE_NUMBER;
    }
}