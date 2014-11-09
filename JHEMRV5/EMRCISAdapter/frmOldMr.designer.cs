namespace JHEMR.EMREdit
{
    partial class frmOldMr
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOldMr));
            this.dgvPatientVisits = new JHEMR.EmrSysUserCtl.CCEMRDataGridView();
            this.visit_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admission_date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosis_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tvMrCatalog = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatientVisits
            // 
            this.dgvPatientVisits.AllowUserToAddRows = false;
            this.dgvPatientVisits.AllowUserToDeleteRows = false;
            this.dgvPatientVisits.AllowUserToResizeRows = false;
            this.dgvPatientVisits.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvPatientVisits.ColumnHeadersHeight = 32;
            this.dgvPatientVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPatientVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visit_id,
            this.admission_date_time,
            this.diagnosis_desc});
            this.dgvPatientVisits.Location = new System.Drawing.Point(1, 1);
            this.dgvPatientVisits.Name = "dgvPatientVisits";
            this.dgvPatientVisits.RowHeadersVisible = false;
            this.dgvPatientVisits.RowTemplate.Height = 23;
            this.dgvPatientVisits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientVisits.Size = new System.Drawing.Size(465, 297);
            this.dgvPatientVisits.TabIndex = 0;
            this.dgvPatientVisits.DoubleClick += new System.EventHandler(this.btnOK_Click);
            this.dgvPatientVisits.SelectionChanged += new System.EventHandler(this.dgvPatientVisits_SelectionChanged);
            // 
            // visit_id
            // 
            this.visit_id.DataPropertyName = "visit_id";
            this.visit_id.HeaderText = "住院次";
            this.visit_id.Name = "visit_id";
            this.visit_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.visit_id.Width = 60;
            // 
            // admission_date_time
            // 
            this.admission_date_time.DataPropertyName = "admission_date_time";
            this.admission_date_time.HeaderText = "入院日期";
            this.admission_date_time.Name = "admission_date_time";
            this.admission_date_time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.admission_date_time.Width = 120;
            // 
            // diagnosis_desc
            // 
            this.diagnosis_desc.DataPropertyName = "diagnosis_desc";
            this.diagnosis_desc.HeaderText = "主要诊断";
            this.diagnosis_desc.Name = "diagnosis_desc";
            this.diagnosis_desc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.diagnosis_desc.Width = 280;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(472, 274);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "打开";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(562, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tvMrCatalog
            // 
            this.tvMrCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tvMrCatalog.ImageIndex = 0;
            this.tvMrCatalog.ImageList = this.imageList1;
            this.tvMrCatalog.Location = new System.Drawing.Point(468, 0);
            this.tvMrCatalog.Name = "tvMrCatalog";
            this.tvMrCatalog.SelectedImageIndex = 0;
            this.tvMrCatalog.Size = new System.Drawing.Size(169, 268);
            this.tvMrCatalog.TabIndex = 3;
            this.tvMrCatalog.DoubleClick += new System.EventHandler(this.tvMrCatalog_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "图形信息.bmp");
            // 
            // frmOldMr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 313);
            this.Controls.Add(this.tvMrCatalog);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvPatientVisits);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOldMr";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "住院次选择";
            this.Load += new System.EventHandler(this.frmOldMr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientVisits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private JHEMR.EmrSysUserCtl.CCEMRDataGridView dgvPatientVisits;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn visit_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn admission_date_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosis_desc;
        private System.Windows.Forms.TreeView tvMrCatalog;
        private System.Windows.Forms.ImageList imageList1;
    }
}