using System.Windows.Forms;
using System;
using System.ComponentModel;
using System.Drawing;
namespace JHEMR.EMRHisCustom
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
            this.dataGridView1 = new DataGridView();
            this.ITEM_CODE = new DataGridViewTextBoxColumn();
            this.pym = new DataGridViewTextBoxColumn();
            this.NAME = new DataGridViewTextBoxColumn();
            ((ISupportInitialize)this.dataGridView1).BeginInit();
            base.SuspendLayout();
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.ITEM_CODE,
				this.pym,
				this.NAME
			});
            this.dataGridView1.Location = new Point(3, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 4;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new Size(287, 163);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new EventHandler(this.dataGridView1_DoubleClick);
            this.ITEM_CODE.DataPropertyName = "ITEM_CODE";
            this.ITEM_CODE.HeaderText = "编码";
            this.ITEM_CODE.Name = "ITEM_CODE";
            this.ITEM_CODE.ReadOnly = true;
            this.ITEM_CODE.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.ITEM_CODE.Visible = false;
            this.pym.DataPropertyName = "pym";
            this.pym.HeaderText = "拼音字头";
            this.pym.Name = "pym";
            this.pym.ReadOnly = true;
            this.pym.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "名称";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.NAME.Width = 160;
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.Controls.Add(this.dataGridView1);
            base.Name = "UCInput";
            base.Size = new Size(292, 166);
            base.Load += new EventHandler(this.UCInput_Load);
            ((ISupportInitialize)this.dataGridView1).EndInit();
            base.ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ITEM_CODE;
        private DataGridViewTextBoxColumn pym;
        private DataGridViewTextBoxColumn NAME;
    }
}
