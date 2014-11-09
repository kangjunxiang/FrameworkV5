namespace JHEMR.EMREdit
{
    partial class UCChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCChart));
            this.axMSChart1 = new AxMSChart20Lib.AxMSChart();
            ((System.ComponentModel.ISupportInitialize)(this.axMSChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // axMSChart1
            // 
            this.axMSChart1.DataSource = null;
            this.axMSChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMSChart1.Location = new System.Drawing.Point(0, 0);
            this.axMSChart1.Name = "axMSChart1";
            this.axMSChart1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMSChart1.OcxState")));
            this.axMSChart1.Size = new System.Drawing.Size(150, 150);
            this.axMSChart1.TabIndex = 0;
            // 
            // UCChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.axMSChart1);
            this.Name = "UCChart";
            this.Load += new System.EventHandler(this.UCChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axMSChart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxMSChart20Lib.AxMSChart axMSChart1;
    }
}
