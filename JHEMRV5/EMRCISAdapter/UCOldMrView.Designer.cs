namespace EMRCISAdapter
{
    partial class UCOldMrView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCOldMrView));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvTypes = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.axFWord = new AxDSOFramer.AxFramerControl();
            this.dgvPatientVisits = new JHEMR.EmrSysUserCtl.CCEMRDataGridView();
            this.visit_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admission_date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISCHARGE_DATE_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosis_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPaste = new System.Windows.Forms.Button();
            this.txtForChange = new System.Windows.Forms.TextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axFWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 113);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvTypes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.axFWord);
            this.splitContainer1.Size = new System.Drawing.Size(561, 280);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.TabIndex = 6;
            // 
            // tvTypes
            // 
            this.tvTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTypes.ImageIndex = 0;
            this.tvTypes.ImageList = this.imageList1;
            this.tvTypes.Location = new System.Drawing.Point(0, 0);
            this.tvTypes.Name = "tvTypes";
            this.tvTypes.SelectedImageIndex = 0;
            this.tvTypes.Size = new System.Drawing.Size(97, 280);
            this.tvTypes.TabIndex = 0;
            this.tvTypes.DoubleClick += new System.EventHandler(this.tvTypes_DoubleClick);
            this.tvTypes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTypes_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "xp_button_5_1.bmp");
            // 
            // axFWord
            // 
            this.axFWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axFWord.Enabled = true;
            this.axFWord.Location = new System.Drawing.Point(0, 0);
            this.axFWord.Name = "axFWord";
            this.axFWord.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axFWord.OcxState")));
            this.axFWord.Size = new System.Drawing.Size(460, 280);
            this.axFWord.TabIndex = 0;
            this.axFWord.UseWaitCursor = true;
            this.axFWord.OnFileCommand += new AxDSOFramer._DFramerCtlEvents_OnFileCommandEventHandler(this.axFWord_OnFileCommand);
            // 
            // dgvPatientVisits
            // 
            this.dgvPatientVisits.AllowUserToAddRows = false;
            this.dgvPatientVisits.AllowUserToDeleteRows = false;
            this.dgvPatientVisits.AllowUserToResizeRows = false;
            this.dgvPatientVisits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatientVisits.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvPatientVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPatientVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visit_id,
            this.admission_date_time,
            this.DISCHARGE_DATE_TIME,
            this.diagnosis_desc});
            this.dgvPatientVisits.Location = new System.Drawing.Point(3, 3);
            this.dgvPatientVisits.Name = "dgvPatientVisits";
            this.dgvPatientVisits.ReadOnly = true;
            this.dgvPatientVisits.RowHeadersVisible = false;
            this.dgvPatientVisits.RowTemplate.Height = 23;
            this.dgvPatientVisits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientVisits.Size = new System.Drawing.Size(561, 106);
            this.dgvPatientVisits.TabIndex = 3;
            this.dgvPatientVisits.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientVisits_CellDoubleClick);
            this.dgvPatientVisits.SelectionChanged += new System.EventHandler(this.dgvPatientVisits_SelectionChanged);
            // 
            // visit_id
            // 
            this.visit_id.DataPropertyName = "visit_id";
            this.visit_id.HeaderText = "住院次";
            this.visit_id.Name = "visit_id";
            this.visit_id.ReadOnly = true;
            this.visit_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.visit_id.Width = 60;
            // 
            // admission_date_time
            // 
            this.admission_date_time.DataPropertyName = "admission_date_time";
            this.admission_date_time.HeaderText = "入院日期";
            this.admission_date_time.Name = "admission_date_time";
            this.admission_date_time.ReadOnly = true;
            this.admission_date_time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.admission_date_time.Width = 120;
            // 
            // DISCHARGE_DATE_TIME
            // 
            this.DISCHARGE_DATE_TIME.DataPropertyName = "DISCHARGE_DATE_TIME";
            this.DISCHARGE_DATE_TIME.HeaderText = "出院日期";
            this.DISCHARGE_DATE_TIME.Name = "DISCHARGE_DATE_TIME";
            this.DISCHARGE_DATE_TIME.ReadOnly = true;
            this.DISCHARGE_DATE_TIME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DISCHARGE_DATE_TIME.Width = 280;
            // 
            // diagnosis_desc
            // 
            this.diagnosis_desc.DataPropertyName = "diagnosis_desc";
            this.diagnosis_desc.HeaderText = "诊断";
            this.diagnosis_desc.Name = "diagnosis_desc";
            this.diagnosis_desc.ReadOnly = true;
            this.diagnosis_desc.Width = 120;
            // 
            // btnPaste
            // 
            this.btnPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaste.ForeColor = System.Drawing.Color.Blue;
            this.btnPaste.Location = new System.Drawing.Point(554, 3);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(10, 104);
            this.btnPaste.TabIndex = 7;
            this.btnPaste.Text = "粘贴选中的文字到病历的光标位置";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Visible = false;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // txtForChange
            // 
            this.txtForChange.Location = new System.Drawing.Point(165, 86);
            this.txtForChange.Name = "txtForChange";
            this.txtForChange.Size = new System.Drawing.Size(138, 21);
            this.txtForChange.TabIndex = 8;
            this.txtForChange.Visible = false;
            // 
            // UCOldMrView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtForChange);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.dgvPatientVisits);
            this.Name = "UCOldMrView";
            this.Size = new System.Drawing.Size(567, 398);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axFWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientVisits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JHEMR.EmrSysUserCtl.CCEMRDataGridView dgvPatientVisits;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvTypes;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.TextBox txtForChange;
        private AxDSOFramer.AxFramerControl axFWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn visit_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn admission_date_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISCHARGE_DATE_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosis_desc;
        private System.Windows.Forms.ImageList imageList1;
    }
}
