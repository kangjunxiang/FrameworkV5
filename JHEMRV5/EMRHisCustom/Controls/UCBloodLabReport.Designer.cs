using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using System.ComponentModel;
using System;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
namespace JHEMR.EMRHisCustom
{
    partial class UCBloodLabReport
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.txtREPORTER_DOCTOR = new System.Windows.Forms.TextBox();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.txtDEPT_CODE = new System.Windows.Forms.TextBox();
            this.txtREPORT_DATE = new System.Windows.Forms.TextBox();
            this.txtBIRTHDAY = new System.Windows.Forms.TextBox();
            this.txtCHARGE_TYPE = new System.Windows.Forms.TextBox();
            this.txtPAT_SEX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtINP_NO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPAT_NAME = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPATIENT_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvBloodResult = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ltxt = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBloodResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiagnosis);
            this.groupBox1.Controls.Add(this.txtREPORTER_DOCTOR);
            this.groupBox1.Controls.Add(this.txtDoctor);
            this.groupBox1.Controls.Add(this.txtDEPT_CODE);
            this.groupBox1.Controls.Add(this.txtREPORT_DATE);
            this.groupBox1.Controls.Add(this.txtBIRTHDAY);
            this.groupBox1.Controls.Add(this.txtCHARGE_TYPE);
            this.groupBox1.Controls.Add(this.txtPAT_SEX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtINP_NO);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPAT_NAME);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPATIENT_ID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(23, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息 ";
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDiagnosis.Location = new System.Drawing.Point(46, 119);
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.ReadOnly = true;
            this.txtDiagnosis.Size = new System.Drawing.Size(245, 21);
            this.txtDiagnosis.TabIndex = 18;
            // 
            // txtREPORTER_DOCTOR
            // 
            this.txtREPORTER_DOCTOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtREPORTER_DOCTOR.Location = new System.Drawing.Point(509, 119);
            this.txtREPORTER_DOCTOR.Name = "txtREPORTER_DOCTOR";
            this.txtREPORTER_DOCTOR.ReadOnly = true;
            this.txtREPORTER_DOCTOR.Size = new System.Drawing.Size(79, 21);
            this.txtREPORTER_DOCTOR.TabIndex = 18;
            // 
            // txtDoctor
            // 
            this.txtDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDoctor.Location = new System.Drawing.Point(347, 119);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.ReadOnly = true;
            this.txtDoctor.Size = new System.Drawing.Size(87, 21);
            this.txtDoctor.TabIndex = 18;
            // 
            // txtDEPT_CODE
            // 
            this.txtDEPT_CODE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDEPT_CODE.Location = new System.Drawing.Point(245, 82);
            this.txtDEPT_CODE.Name = "txtDEPT_CODE";
            this.txtDEPT_CODE.ReadOnly = true;
            this.txtDEPT_CODE.Size = new System.Drawing.Size(130, 21);
            this.txtDEPT_CODE.TabIndex = 18;
            // 
            // txtREPORT_DATE
            // 
            this.txtREPORT_DATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtREPORT_DATE.Location = new System.Drawing.Point(440, 82);
            this.txtREPORT_DATE.Name = "txtREPORT_DATE";
            this.txtREPORT_DATE.ReadOnly = true;
            this.txtREPORT_DATE.Size = new System.Drawing.Size(154, 21);
            this.txtREPORT_DATE.TabIndex = 17;
            // 
            // txtBIRTHDAY
            // 
            this.txtBIRTHDAY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBIRTHDAY.Location = new System.Drawing.Point(45, 79);
            this.txtBIRTHDAY.Name = "txtBIRTHDAY";
            this.txtBIRTHDAY.ReadOnly = true;
            this.txtBIRTHDAY.Size = new System.Drawing.Size(154, 21);
            this.txtBIRTHDAY.TabIndex = 17;
            // 
            // txtCHARGE_TYPE
            // 
            this.txtCHARGE_TYPE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCHARGE_TYPE.Location = new System.Drawing.Point(530, 44);
            this.txtCHARGE_TYPE.Name = "txtCHARGE_TYPE";
            this.txtCHARGE_TYPE.ReadOnly = true;
            this.txtCHARGE_TYPE.Size = new System.Drawing.Size(58, 21);
            this.txtCHARGE_TYPE.TabIndex = 16;
            // 
            // txtPAT_SEX
            // 
            this.txtPAT_SEX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPAT_SEX.Location = new System.Drawing.Point(453, 44);
            this.txtPAT_SEX.Name = "txtPAT_SEX";
            this.txtPAT_SEX.ReadOnly = true;
            this.txtPAT_SEX.Size = new System.Drawing.Size(35, 21);
            this.txtPAT_SEX.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "报告日期";
            // 
            // txtINP_NO
            // 
            this.txtINP_NO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtINP_NO.Location = new System.Drawing.Point(203, 44);
            this.txtINP_NO.Name = "txtINP_NO";
            this.txtINP_NO.ReadOnly = true;
            this.txtINP_NO.Size = new System.Drawing.Size(76, 21);
            this.txtINP_NO.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(450, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "检验医生";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "诊断";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(311, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "医生";
            // 
            // txtPAT_NAME
            // 
            this.txtPAT_NAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPAT_NAME.Location = new System.Drawing.Point(329, 44);
            this.txtPAT_NAME.Name = "txtPAT_NAME";
            this.txtPAT_NAME.ReadOnly = true;
            this.txtPAT_NAME.Size = new System.Drawing.Size(75, 21);
            this.txtPAT_NAME.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "科室\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "出生";
            // 
            // txtPATIENT_ID
            // 
            this.txtPATIENT_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPATIENT_ID.Location = new System.Drawing.Point(45, 44);
            this.txtPATIENT_ID.Name = "txtPATIENT_ID";
            this.txtPATIENT_ID.ReadOnly = true;
            this.txtPATIENT_ID.Size = new System.Drawing.Size(100, 21);
            this.txtPATIENT_ID.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "费别";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "住院号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvBloodResult);
            this.groupBox2.Location = new System.Drawing.Point(23, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "检验报告";
            // 
            // gvBloodResult
            // 
            this.gvBloodResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvBloodResult.EmbeddedNavigator.Name = "";
            this.gvBloodResult.Location = new System.Drawing.Point(3, 17);
            this.gvBloodResult.MainView = this.gridView2;
            this.gvBloodResult.Name = "gvBloodResult";
            this.gvBloodResult.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gvBloodResult.Size = new System.Drawing.Size(604, 174);
            this.gvBloodResult.TabIndex = 0;
            this.gvBloodResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView2.GridControl = this.gvBloodResult;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "            项              目";
            this.gridColumn1.FieldName = "BLOOD_ITEM";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 200;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "                 结                果";
            this.gridColumn2.FieldName = "BLOOD_RESULT";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 300;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ltxt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(706, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ltxt
            // 
            this.ltxt.ForeColor = System.Drawing.Color.Red;
            this.ltxt.Name = "ltxt";
            this.ltxt.Size = new System.Drawing.Size(41, 17);
            this.ltxt.Text = "提示：";
            // 
            // UCBloodLabReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCBloodLabReport";
            this.Size = new System.Drawing.Size(706, 481);
            this.Load += new System.EventHandler(this.UCBloodLabReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvBloodResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GridControl gridControl1;
        private GridView gridView1;
        private GroupBox groupBox1;
        private TextBox txtDEPT_CODE;
        private TextBox txtBIRTHDAY;
        private TextBox txtCHARGE_TYPE;
        private TextBox txtPAT_SEX;
        private TextBox txtINP_NO;
        private TextBox txtPAT_NAME;
        private Label label6;
        private Label label9;
        private TextBox txtPATIENT_ID;
        private Label label5;
        private Label label8;
        private Label label4;
        private Label label7;
        private Label label3;
        private TextBox txtDiagnosis;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GridControl gvBloodResult;
        private GridView gridView2;
        private GridColumn gridColumn1;
        private GridColumn gridColumn2;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private TextBox txtDoctor;
        private Label label10;
        private TextBox txtREPORTER_DOCTOR;
        private Label label11;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ltxt;
        private TextBox txtREPORT_DATE;
    }
}
