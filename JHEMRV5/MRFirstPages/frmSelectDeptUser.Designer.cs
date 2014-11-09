using JHEMR.EmrSysUserCtl;
using System.Windows.Forms;
using System.ComponentModel;
using System;
using System.Drawing;
namespace JHEMR.MRFirstPages
{
    partial class frmSelectDeptUser
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
            this.dgvDeptUsers = new JHEMR.EmrSysUserCtl.CCEMRDataGridView();
            this.USER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DB_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeptUsers
            // 
            this.dgvDeptUsers.AllowUserToAddRows = false;
            this.dgvDeptUsers.AllowUserToDeleteRows = false;
            this.dgvDeptUsers.AllowUserToResizeRows = false;
            this.dgvDeptUsers.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvDeptUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeptUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USER_NAME,
            this.DB_USER,
            this.USER_ID});
            this.dgvDeptUsers.Location = new System.Drawing.Point(1, 33);
            this.dgvDeptUsers.Name = "dgvDeptUsers";
            this.dgvDeptUsers.ReadOnly = true;
            this.dgvDeptUsers.RowHeadersVisible = false;
            this.dgvDeptUsers.RowTemplate.Height = 23;
            this.dgvDeptUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeptUsers.Size = new System.Drawing.Size(211, 251);
            this.dgvDeptUsers.TabIndex = 0;
            this.dgvDeptUsers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDeptUsers_KeyDown);
            this.dgvDeptUsers.DoubleClick += new System.EventHandler(this.dgvDeptUsers_DoubleClick);
            // 
            // USER_NAME
            // 
            this.USER_NAME.DataPropertyName = "USER_NAME";
            this.USER_NAME.HeaderText = "姓名";
            this.USER_NAME.Name = "USER_NAME";
            this.USER_NAME.ReadOnly = true;
            this.USER_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.USER_NAME.Width = 60;
            // 
            // DB_USER
            // 
            this.DB_USER.DataPropertyName = "DB_USER";
            this.DB_USER.HeaderText = "登录名";
            this.DB_USER.Name = "DB_USER";
            this.DB_USER.ReadOnly = true;
            this.DB_USER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DB_USER.Width = 70;
            // 
            // USER_ID
            // 
            this.USER_ID.DataPropertyName = "USER_ID";
            this.USER_ID.HeaderText = "ID号";
            this.USER_ID.Name = "USER_ID";
            this.USER_ID.ReadOnly = true;
            this.USER_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.USER_ID.Width = 60;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(40, 289);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(121, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboDept
            // 
            this.cboDept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(46, 7);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(161, 20);
            this.cboDept.TabIndex = 28;
            this.cboDept.SelectedIndexChanged += new System.EventHandler(this.cboDept_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 29;
            this.label1.Text = "科室：";
            // 
            // frmSelectDeptUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvDeptUsers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectDeptUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSelectDeptUser";
            this.Load += new System.EventHandler(this.frmSelectDeptUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCEMRDataGridView dgvDeptUsers;
        private DataGridViewTextBoxColumn USER_NAME;
        private DataGridViewTextBoxColumn DB_USER;
        private DataGridViewTextBoxColumn USER_ID;
        private Button btnOK;
        private Button btnCancel;
        private ComboBox cboDept;
        private Label label1;
    }
}