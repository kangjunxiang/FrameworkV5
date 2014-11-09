using JHEMR.EmrSysUserCtl;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.ComponentModel;
namespace JHEMR.MRFirstPages
{
    partial class UCInput
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new JHEMR.EmrSysUserCtl.CCEMRDataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pym = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.user_name,
            this.pym,
            this.DEPT_NAME});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(423, 147);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.Frozen = true;
            this.user_id.HeaderText = "职工编号";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            // 
            // user_name
            // 
            this.user_name.DataPropertyName = "user_name";
            this.user_name.Frozen = true;
            this.user_name.HeaderText = "姓名";
            this.user_name.Name = "user_name";
            this.user_name.ReadOnly = true;
            // 
            // pym
            // 
            this.pym.DataPropertyName = "pym";
            this.pym.Frozen = true;
            this.pym.HeaderText = "拼音码";
            this.pym.Name = "pym";
            this.pym.ReadOnly = true;
            // 
            // DEPT_NAME
            // 
            this.DEPT_NAME.DataPropertyName = "DEPT_NAME";
            this.DEPT_NAME.Frozen = true;
            this.DEPT_NAME.HeaderText = "科室";
            this.DEPT_NAME.Name = "DEPT_NAME";
            this.DEPT_NAME.ReadOnly = true;
            // 
            // UCInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "UCInput";
            this.Size = new System.Drawing.Size(426, 150);
            this.Load += new System.EventHandler(this.UCInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CCEMRDataGridView dataGridView1;
        private DataGridViewTextBoxColumn user_id;
        private DataGridViewTextBoxColumn user_name;
        private DataGridViewTextBoxColumn pym;
        private DataGridViewTextBoxColumn DEPT_NAME;
    }
}
