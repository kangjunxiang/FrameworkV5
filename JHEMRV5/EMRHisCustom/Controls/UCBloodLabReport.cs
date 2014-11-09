using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;

namespace JHEMR.EMRHisCustom
{
    public partial class UCBloodLabReport : UserControl, EmrEditUCInterface
    {
        private DataSet dsItem = new DataSet();
        private DataSet dsReportResult = new DataSet();
        private string m_strDBConnet = "HISConnect";
        public UCBloodLabReport()
        {
            InitializeComponent();
        }
        private void fillPat()
        {
            string sQLString = string.Concat(new object[]
			{
				"select * from blood_report_pat a where a.patient_id='",
				EmrSysPubVar.getCurPatientID(),
				"' and visit_id='",
				EmrSysPubVar.getCurPatientVisitID(),
				"' "
			});
            DataTable dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                if (dataRow["PATIENT_ID"] != DBNull.Value)
                {
                    this.txtPATIENT_ID.Text = dataRow["PATIENT_ID"].ToString();
                }
                if (dataRow["INP_NO"] != DBNull.Value)
                {
                    this.txtINP_NO.Text = dataRow["INP_NO"].ToString();
                }
                if (dataRow["DEPT_CODE"] != DBNull.Value)
                {
                    this.txtDEPT_CODE.Tag = dataRow["DEPT_CODE"].ToString();
                    this.txtDEPT_CODE.Text = EmrSysPubFunction.getDeptName(dataRow["DEPT_CODE"].ToString(), false);
                }
                if (dataRow["PAT_NAME"] != DBNull.Value)
                {
                    this.txtPAT_NAME.Text = dataRow["PAT_NAME"].ToString();
                }
                if (dataRow["PAT_SEX"] != DBNull.Value)
                {
                    this.txtPAT_SEX.Text = dataRow["PAT_SEX"].ToString();
                }
                if (dataRow["BIRTHDAY"] != DBNull.Value)
                {
                    this.txtBIRTHDAY.Text = dataRow["BIRTHDAY"].ToString();
                }
                if (dataRow["FEE_TYPE"] != DBNull.Value)
                {
                    this.txtCHARGE_TYPE.Text = dataRow["FEE_TYPE"].ToString();
                }
                if (dataRow["DIAGNOSE"] != DBNull.Value)
                {
                    this.txtDiagnosis.Text = dataRow["DIAGNOSE"].ToString();
                }
                if (dataRow["REPORTER_DATE"] != DBNull.Value)
                {
                    this.txtREPORT_DATE.Text = dataRow["REPORTER_DATE"].ToString();
                }
                if (dataRow["REQUEST_DOCTOR"] != DBNull.Value)
                {
                    this.txtDoctor.Text = dataRow["REQUEST_DOCTOR"].ToString();
                }
                if (dataRow["REPORTER_DOCTOR"] != DBNull.Value)
                {
                    this.txtREPORTER_DOCTOR.Text = dataRow["REPORTER_DOCTOR"].ToString();
                }
            }
            else
            {
                this.txtPATIENT_ID.Text = EmrSysPubVar.getCurPatientID().ToString();
                this.txtINP_NO.Text = EmrSysPubVar.getCurPatientInpNo();
                this.txtPAT_NAME.Text = EmrSysPubVar.getCurPatientName();
                this.txtPAT_SEX.Text = EmrSysPubVar.getCurPatientSex();
                this.txtDEPT_CODE.Text = EmrSysPubVar.getDeptName();
                this.txtDEPT_CODE.Tag = EmrSysPubVar.getDeptCode();
                this.txtBIRTHDAY.Text = EmrSysPubVar.getCurPatientBirthDate().ToString();
                this.txtCHARGE_TYPE.Text = EmrSysPubVar.getCurVisitChargeType();
                this.txtDoctor.Text = EmrSysPubVar.getOperator();
                this.txtDiagnosis.Text = EmrSysPubVar.getCurPatientClinicDiag();
            }
        }
        private void ReportResult()
        {
            string sQLString = string.Concat(new object[]
			{
				"select  a.report_item as blood_item,a.report_result as blood_result  from blood_report_result a where a.patient_id='",
				EmrSysPubVar.getCurPatientID(),
				"' and visit_id='",
				EmrSysPubVar.getCurPatientVisitID(),
				"'"
			});
            this.dsReportResult = DALUseSpecial.Query(sQLString, this.m_strDBConnet);
            if (this.dsReportResult.Tables.Count > 0)
            {
                this.gvBloodResult.DataSource = this.dsReportResult.Tables[0];
            }
        }
        public bool cmdCheckIsUnSave()
        {
            return false;
        }
        public bool getCloseFlag()
        {
            return false;
        }
        public void setPatientInfo(string strPatientID, int nVisitID)
        {
        }
        private void UCBloodLabReport_Load(object sender, EventArgs e)
        {
            this.fillPat();
            this.ReportResult();
        }
        private void txtREPORTER_DOCTOR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                ((TextBox)sender).Text = "";
                foreach (Control control in this.groupBox1.Controls)
                {
                    if (control.Name == "input")
                    {
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(this.groupBox1.Controls, (TextBox)sender);
                instance.loadData("USERS", this.txtDEPT_CODE.Tag.ToString(), "");
                instance.Name = "input";
                this.groupBox1.Controls.Add(instance);
                this.groupBox1.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < this.groupBox1.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(this.groupBox1.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                instance.filter();
            }
        }
        private void txtDoctor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                ((TextBox)sender).Text = "";
                foreach (Control control in this.groupBox1.Controls)
                {
                    if (control.Name == "input")
                    {
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(this.groupBox1.Controls, (TextBox)sender);
                instance.loadData("USERS", this.txtDEPT_CODE.Tag.ToString(), "");
                instance.Name = "input";
                this.groupBox1.Controls.Add(instance);
                this.groupBox1.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < this.groupBox1.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(this.groupBox1.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                instance.filter();
            }
        }
        private void txtDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                ((TextBox)sender).Text = "";
                foreach (Control control in this.groupBox1.Controls)
                {
                    if (control.Name == "input")
                    {
                        e.KeyChar = '\0';
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(this.groupBox1.Controls, (TextBox)sender);
                instance.loadData("USERS", this.txtDEPT_CODE.Tag.ToString(), "");
                instance.Name = "input";
                this.groupBox1.Controls.Add(instance);
                this.groupBox1.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < base.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(this.groupBox1.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                e.KeyChar = '\0';
                instance.filter();
            }
        }
        private void txtDoctor_Enter(object sender, EventArgs e)
        {
            this.ltxt.Text = "提示:按F9或者空格调用拼音字典操作";
        }
        private void txtDoctor_Leave(object sender, EventArgs e)
        {
            this.ltxt.Text = "提示:";
        }
        private void txtREPORTER_DOCTOR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                ((TextBox)sender).Text = "";
                foreach (Control control in this.groupBox1.Controls)
                {
                    if (control.Name == "input")
                    {
                        e.KeyChar = '\0';
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(this.groupBox1.Controls, (TextBox)sender);
                instance.loadData("USERS", this.txtDEPT_CODE.Tag.ToString(), "");
                instance.Name = "input";
                this.groupBox1.Controls.Add(instance);
                this.groupBox1.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < base.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(this.groupBox1.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                e.KeyChar = '\0';
                instance.filter();
            }
        }
        private void txtREPORTER_DOCTOR_Leave(object sender, EventArgs e)
        {
            this.ltxt.Text = "提示:";
        }
        private void item_dict()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("name"));
            dataTable.Columns.Add(new DataColumn("code"));
            DataRow dataRow = dataTable.NewRow();
            dataRow["name"] = "ABO血型鉴定";
            dataRow["code"] = "0";
            dataTable.Rows.Add(dataRow);
            DataRow dataRow2 = dataTable.NewRow();
            dataRow2["name"] = "Ph血型鉴定";
            dataRow2["code"] = "1";
            dataTable.Rows.Add(dataRow2);
            DataRow dataRow3 = dataTable.NewRow();
            dataRow3["name"] = "柯姆氏试验";
            dataRow3["code"] = "2";
            dataTable.Rows.Add(dataRow3);
            DataRow dataRow4 = dataTable.NewRow();
            dataRow4["name"] = "抗体鉴定";
            dataRow4["code"] = "3";
            dataTable.Rows.Add(dataRow4);
            DataRow dataRow5 = dataTable.NewRow();
            dataRow5["name"] = "血型物质鉴定";
            dataRow5["code"] = "4";
            dataTable.Rows.Add(dataRow5);
            DataRow dataRow6 = dataTable.NewRow();
            dataRow6["name"] = "新生儿溶血病检查";
            dataRow6["code"] = "5";
            dataTable.Rows.Add(dataRow6);
            DataRow dataRow7 = dataTable.NewRow();
            dataRow7["name"] = "孕妇免疫检查";
            dataRow7["code"] = "6";
            dataTable.Rows.Add(dataRow7);
            DataRow dataRow8 = dataTable.NewRow();
            dataRow8["name"] = "白细胞抗体";
            dataRow8["code"] = "7";
            dataTable.Rows.Add(dataRow8);
            DataRow dataRow9 = dataTable.NewRow();
            dataRow9["name"] = "血小板抗体";
            dataRow9["code"] = "8";
            dataTable.Rows.Add(dataRow9);
            DataRow dataRow10 = dataTable.NewRow();
            dataRow10["name"] = "HLA位点鉴定";
            dataRow10["code"] = "9";
            dataTable.Rows.Add(dataRow10);
            this.repositoryItemLookUpEdit1.DataSource = dataTable;
        }
    }
}
