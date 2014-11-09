using JHEMR.EmrSysUserCtl;
using System.Windows.Forms;
using System;
using System.ComponentModel;
using System.Drawing;
namespace JHEMR.MRFirstPagesBJ
{
    partial class frmPatientMrDiagnose
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDiagnose = new JHEMR.EmrSysUserCtl.CCEMRDataGridView();
            this.诊断类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.子号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.诊断名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONFIRMED_INDICATOR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.诊断日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.诊断编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.医师 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.实习医师 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.上级医师 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.上级审签日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.主任医师 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.主任审签日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnose)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiagnose
            // 
            this.dgvDiagnose.AllowUserToAddRows = false;
            this.dgvDiagnose.AllowUserToDeleteRows = false;
            this.dgvDiagnose.AllowUserToResizeRows = false;
            this.dgvDiagnose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiagnose.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvDiagnose.ColumnHeadersHeight = 30;
            this.dgvDiagnose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDiagnose.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.诊断类型,
            this.序号,
            this.子号,
            this.诊断名称,
            this.CONFIRMED_INDICATOR,
            this.诊断日期,
            this.诊断编码,
            this.医师,
            this.实习医师,
            this.上级医师,
            this.上级审签日期,
            this.主任医师,
            this.主任审签日期});
            this.dgvDiagnose.Location = new System.Drawing.Point(3, 3);
            this.dgvDiagnose.Name = "dgvDiagnose";
            this.dgvDiagnose.RowHeadersVisible = false;
            this.dgvDiagnose.RowTemplate.Height = 23;
            this.dgvDiagnose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiagnose.Size = new System.Drawing.Size(579, 324);
            this.dgvDiagnose.TabIndex = 11;
            this.dgvDiagnose.DoubleClick += new System.EventHandler(this.dgvDiagnose_DoubleClick);
            // 
            // 诊断类型
            // 
            this.诊断类型.DataPropertyName = "诊断类型";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.诊断类型.DefaultCellStyle = dataGridViewCellStyle8;
            this.诊断类型.HeaderText = "诊断类型";
            this.诊断类型.Name = "诊断类型";
            this.诊断类型.ReadOnly = true;
            this.诊断类型.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.诊断类型.Width = 80;
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "序号";
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.序号.Width = 40;
            // 
            // 子号
            // 
            this.子号.DataPropertyName = "子号";
            this.子号.HeaderText = "子号";
            this.子号.Name = "子号";
            this.子号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.子号.Width = 40;
            // 
            // 诊断名称
            // 
            this.诊断名称.DataPropertyName = "诊断名称";
            this.诊断名称.HeaderText = "诊断名称";
            this.诊断名称.Name = "诊断名称";
            this.诊断名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.诊断名称.Width = 160;
            // 
            // CONFIRMED_INDICATOR
            // 
            this.CONFIRMED_INDICATOR.DataPropertyName = "CONFIRMED_INDICATOR";
            this.CONFIRMED_INDICATOR.FalseValue = "0";
            this.CONFIRMED_INDICATOR.HeaderText = "确诊";
            this.CONFIRMED_INDICATOR.Name = "CONFIRMED_INDICATOR";
            this.CONFIRMED_INDICATOR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CONFIRMED_INDICATOR.TrueValue = "1";
            this.CONFIRMED_INDICATOR.Width = 40;
            // 
            // 诊断日期
            // 
            this.诊断日期.DataPropertyName = "诊断日期";
            this.诊断日期.HeaderText = "诊断日期";
            this.诊断日期.Name = "诊断日期";
            this.诊断日期.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.诊断日期.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 诊断编码
            // 
            this.诊断编码.DataPropertyName = "诊断编码";
            this.诊断编码.HeaderText = "诊断编码";
            this.诊断编码.Name = "诊断编码";
            this.诊断编码.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 医师
            // 
            this.医师.DataPropertyName = "医师";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.医师.DefaultCellStyle = dataGridViewCellStyle9;
            this.医师.HeaderText = "医师";
            this.医师.Name = "医师";
            this.医师.ReadOnly = true;
            this.医师.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 实习医师
            // 
            this.实习医师.DataPropertyName = "实习医师";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.实习医师.DefaultCellStyle = dataGridViewCellStyle10;
            this.实习医师.HeaderText = "实习医师";
            this.实习医师.Name = "实习医师";
            this.实习医师.ReadOnly = true;
            this.实习医师.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 上级医师
            // 
            this.上级医师.DataPropertyName = "上级医师";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.上级医师.DefaultCellStyle = dataGridViewCellStyle11;
            this.上级医师.HeaderText = "上级医师";
            this.上级医师.Name = "上级医师";
            this.上级医师.ReadOnly = true;
            this.上级医师.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 上级审签日期
            // 
            this.上级审签日期.DataPropertyName = "上级审签日期";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.上级审签日期.DefaultCellStyle = dataGridViewCellStyle12;
            this.上级审签日期.HeaderText = "上级审签日期";
            this.上级审签日期.Name = "上级审签日期";
            this.上级审签日期.ReadOnly = true;
            this.上级审签日期.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 主任医师
            // 
            this.主任医师.DataPropertyName = "主任医师";
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.主任医师.DefaultCellStyle = dataGridViewCellStyle13;
            this.主任医师.HeaderText = "主任医师";
            this.主任医师.Name = "主任医师";
            this.主任医师.ReadOnly = true;
            this.主任医师.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 主任审签日期
            // 
            this.主任审签日期.DataPropertyName = "主任审签日期";
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.主任审签日期.DefaultCellStyle = dataGridViewCellStyle14;
            this.主任审签日期.HeaderText = "主任审签日期";
            this.主任审签日期.Name = "主任审签日期";
            this.主任审签日期.ReadOnly = true;
            this.主任审签日期.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(362, 332);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 30);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "保存";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(475, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPatientMrDiagnose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 374);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvDiagnose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPatientMrDiagnose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "病历诊断";
            this.Load += new System.EventHandler(this.frmPatientMrDiagnose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridViewTextBoxColumn 诊断类型;
        private DataGridViewTextBoxColumn 序号;
        private DataGridViewTextBoxColumn 子号;
        private DataGridViewTextBoxColumn 诊断名称;
        private DataGridViewCheckBoxColumn CONFIRMED_INDICATOR;
        private DataGridViewTextBoxColumn 诊断日期;
        private DataGridViewTextBoxColumn 诊断编码;
        private DataGridViewTextBoxColumn 医师;
        private DataGridViewTextBoxColumn 实习医师;
        private DataGridViewTextBoxColumn 上级医师;
        private DataGridViewTextBoxColumn 上级审签日期;
        private DataGridViewTextBoxColumn 主任医师;
        private DataGridViewTextBoxColumn 主任审签日期;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        public CCEMRDataGridView dgvDiagnose;
    }
}