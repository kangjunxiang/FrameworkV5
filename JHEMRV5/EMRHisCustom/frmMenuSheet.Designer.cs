using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraGrid.Views.Base;
namespace JHEMR.EMRHisCustom
{
    partial class frmMenuSheet
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
            this.gcMenu = new DevExpress.XtraGrid.GridControl();
            this.gvMenu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MENU_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sbtnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gcMenu
            // 
            this.gcMenu.EmbeddedNavigator.Name = "";
            this.gcMenu.Location = new System.Drawing.Point(3, 4);
            this.gcMenu.MainView = this.gvMenu;
            this.gcMenu.Name = "gcMenu";
            this.gcMenu.Size = new System.Drawing.Size(278, 254);
            this.gcMenu.TabIndex = 0;
            this.gcMenu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMenu,
            this.gridView2});
            // 
            // gvMenu
            // 
            this.gvMenu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MENU_NAME});
            this.gvMenu.GridControl = this.gcMenu;
            this.gvMenu.Name = "gvMenu";
            this.gvMenu.OptionsView.ColumnAutoWidth = false;
            this.gvMenu.OptionsView.ShowColumnHeaders = false;
            this.gvMenu.OptionsView.ShowGroupPanel = false;
            this.gvMenu.OptionsView.ShowIndicator = false;
            this.gvMenu.DoubleClick += new System.EventHandler(this.gvMenu_DoubleClick);
            // 
            // MENU_NAME
            // 
            this.MENU_NAME.Caption = "名称";
            this.MENU_NAME.FieldName = "MENU_NAME";
            this.MENU_NAME.Name = "MENU_NAME";
            this.MENU_NAME.Visible = true;
            this.MENU_NAME.VisibleIndex = 0;
            this.MENU_NAME.Width = 250;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcMenu;
            this.gridView2.Name = "gridView2";
            // 
            // sbtnConfirm
            // 
            this.sbtnConfirm.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnConfirm.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.sbtnConfirm.Appearance.Options.UseFont = true;
            this.sbtnConfirm.Appearance.Options.UseForeColor = true;
            this.sbtnConfirm.Location = new System.Drawing.Point(97, 271);
            this.sbtnConfirm.Name = "sbtnConfirm";
            this.sbtnConfirm.Size = new System.Drawing.Size(79, 23);
            this.sbtnConfirm.TabIndex = 1;
            this.sbtnConfirm.Text = "确定(&O)";
            this.sbtnConfirm.Click += new System.EventHandler(this.sbtnConfirm_Click);
            // 
            // sbtnClose
            // 
            this.sbtnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnClose.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.sbtnClose.Appearance.Options.UseFont = true;
            this.sbtnClose.Appearance.Options.UseForeColor = true;
            this.sbtnClose.Location = new System.Drawing.Point(201, 271);
            this.sbtnClose.Name = "sbtnClose";
            this.sbtnClose.Size = new System.Drawing.Size(80, 23);
            this.sbtnClose.TabIndex = 1;
            this.sbtnClose.Text = "关闭(&X)";
            this.sbtnClose.Click += new System.EventHandler(this.sbtnClose_Click);
            // 
            // frmMenuSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 309);
            this.Controls.Add(this.sbtnClose);
            this.Controls.Add(this.sbtnConfirm);
            this.Controls.Add(this.gcMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuSheet";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "申请套餐检查单";
            this.Load += new System.EventHandler(this.frmMenuSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GridControl gcMenu;
        private GridView gvMenu;
        private GridView gridView2;
        private GridColumn MENU_NAME;
        private SimpleButton sbtnConfirm;
        private SimpleButton sbtnClose;
    }
}