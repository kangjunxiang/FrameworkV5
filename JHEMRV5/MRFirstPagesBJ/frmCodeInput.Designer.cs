using System.Windows.Forms;
using System;
using System.ComponentModel;
using System.Drawing;
namespace JHEMR.MRFirstPagesBJ
{
    partial class frmCodeInput
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
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dgvDict = new System.Windows.Forms.DataGridView();
            this.输入码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rb拼音 = new System.Windows.Forms.RadioButton();
            this.rb名称 = new System.Windows.Forms.RadioButton();
            this.rb编码 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDict)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtPhone.Location = new System.Drawing.Point(242, 10);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(138, 21);
            this.txtPhone.TabIndex = 0;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            // 
            // dgvDict
            // 
            this.dgvDict.AllowUserToAddRows = false;
            this.dgvDict.AllowUserToDeleteRows = false;
            this.dgvDict.BackgroundColor = System.Drawing.Color.White;
            this.dgvDict.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDict.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.输入码,
            this.名称,
            this.编码});
            this.dgvDict.Location = new System.Drawing.Point(12, 37);
            this.dgvDict.Name = "dgvDict";
            this.dgvDict.ReadOnly = true;
            this.dgvDict.RowHeadersVisible = false;
            this.dgvDict.RowTemplate.Height = 23;
            this.dgvDict.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDict.Size = new System.Drawing.Size(370, 205);
            this.dgvDict.TabIndex = 1;
            this.dgvDict.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDict_KeyDown);
            this.dgvDict.DoubleClick += new System.EventHandler(this.dgvDict_DoubleClick);
            // 
            // 输入码
            // 
            this.输入码.DataPropertyName = "输入码";
            this.输入码.HeaderText = "输入码";
            this.输入码.Name = "输入码";
            this.输入码.ReadOnly = true;
            // 
            // 名称
            // 
            this.名称.DataPropertyName = "名称";
            this.名称.HeaderText = "名称";
            this.名称.Name = "名称";
            this.名称.ReadOnly = true;
            this.名称.Width = 150;
            // 
            // 编码
            // 
            this.编码.DataPropertyName = "编码";
            this.编码.HeaderText = "编码";
            this.编码.Name = "编码";
            this.编码.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 5;
            this.textBox1.Visible = false;
            // 
            // rb拼音
            // 
            this.rb拼音.AutoSize = true;
            this.rb拼音.Checked = true;
            this.rb拼音.Location = new System.Drawing.Point(12, 11);
            this.rb拼音.Name = "rb拼音";
            this.rb拼音.Size = new System.Drawing.Size(89, 16);
            this.rb拼音.TabIndex = 2;
            this.rb拼音.TabStop = true;
            this.rb拼音.Text = "拼音字头(&P)";
            this.rb拼音.UseVisualStyleBackColor = true;
            this.rb拼音.CheckedChanged += new System.EventHandler(this.rb拼音_CheckedChanged);
            // 
            // rb名称
            // 
            this.rb名称.AutoSize = true;
            this.rb名称.Location = new System.Drawing.Point(103, 11);
            this.rb名称.Name = "rb名称";
            this.rb名称.Size = new System.Drawing.Size(65, 16);
            this.rb名称.TabIndex = 3;
            this.rb名称.Text = "名称(&M)";
            this.rb名称.UseVisualStyleBackColor = true;
            this.rb名称.CheckedChanged += new System.EventHandler(this.rb名称_CheckedChanged);
            // 
            // rb编码
            // 
            this.rb编码.AutoSize = true;
            this.rb编码.Location = new System.Drawing.Point(172, 11);
            this.rb编码.Name = "rb编码";
            this.rb编码.Size = new System.Drawing.Size(65, 16);
            this.rb编码.TabIndex = 4;
            this.rb编码.Text = "编码(&C)";
            this.rb编码.UseVisualStyleBackColor = true;
            this.rb编码.CheckedChanged += new System.EventHandler(this.rb编码_CheckedChanged);
            // 
            // frmCodeInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 254);
            this.Controls.Add(this.rb编码);
            this.Controls.Add(this.rb名称);
            this.Controls.Add(this.rb拼音);
            this.Controls.Add(this.dgvDict);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.textBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCodeInput";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据字典拼音输入法";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCodeInput_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCodeInput_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCodeInput_KeyDown);
            this.Load += new System.EventHandler(this.frmCodeInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtPhone;
        private DataGridView dgvDict;
        private TextBox textBox1;
        private RadioButton rb拼音;
        private RadioButton rb名称;
        private RadioButton rb编码;
        private DataGridViewTextBoxColumn 输入码;
        private DataGridViewTextBoxColumn 名称;
        private DataGridViewTextBoxColumn 编码;
    }
}