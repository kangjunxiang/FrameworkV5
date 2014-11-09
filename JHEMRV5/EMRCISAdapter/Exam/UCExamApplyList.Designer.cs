namespace JHEMR.EMREdit
{
    partial class UCExamApplyList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvExamMaster = new System.Windows.Forms.DataGridView();
            this.EXAM_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXAM_CLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXAM_DATE_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExamMaster
            // 
            this.dgvExamMaster.AllowUserToAddRows = false;
            this.dgvExamMaster.AllowUserToDeleteRows = false;
            this.dgvExamMaster.AllowUserToResizeRows = false;
            this.dgvExamMaster.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvExamMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EXAM_NO,
            this.EXAM_CLASS,
            this.EXAM_DATE_TIME});
            this.dgvExamMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvExamMaster.Location = new System.Drawing.Point(0, 0);
            this.dgvExamMaster.Name = "dgvExamMaster";
            this.dgvExamMaster.RowHeadersVisible = false;
            this.dgvExamMaster.RowTemplate.Height = 23;
            this.dgvExamMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExamMaster.Size = new System.Drawing.Size(744, 118);
            this.dgvExamMaster.TabIndex = 1;
            this.dgvExamMaster.SelectionChanged += new System.EventHandler(this.dgvExamMaster_SelectionChanged);
            this.dgvExamMaster.Click += new System.EventHandler(this.dgvExamMaster_Click);
            // 
            // EXAM_NO
            // 
            this.EXAM_NO.DataPropertyName = "EXAM_NO";
            this.EXAM_NO.HeaderText = "检查号";
            this.EXAM_NO.Name = "EXAM_NO";
            this.EXAM_NO.ReadOnly = true;
            this.EXAM_NO.Width = 80;
            // 
            // EXAM_CLASS
            // 
            this.EXAM_CLASS.DataPropertyName = "EXAM_CLASS";
            this.EXAM_CLASS.HeaderText = "类别";
            this.EXAM_CLASS.Name = "EXAM_CLASS";
            this.EXAM_CLASS.ReadOnly = true;
            this.EXAM_CLASS.Width = 120;
            // 
            // EXAM_DATE_TIME
            // 
            this.EXAM_DATE_TIME.DataPropertyName = "EXAM_DATE_TIME";
            this.EXAM_DATE_TIME.HeaderText = "检查日期";
            this.EXAM_DATE_TIME.Name = "EXAM_DATE_TIME";
            this.EXAM_DATE_TIME.ReadOnly = true;
            this.EXAM_DATE_TIME.Width = 120;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 118);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(744, 338);
            this.webBrowser1.TabIndex = 2;
            // 
            // UCExamApplyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.dgvExamMaster);
            this.Name = "UCExamApplyList";
            this.Size = new System.Drawing.Size(744, 456);
            this.Load += new System.EventHandler(this.UCExamApplyList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExamMaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXAM_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXAM_CLASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXAM_DATE_TIME;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}
