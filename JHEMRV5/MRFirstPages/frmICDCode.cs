using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;

namespace JHEMR.MRFirstPages
{
    public partial class frmICDCode : Form
    {
        private string code = "";
        private string name = "";
        public frmICDCode()
        {
            this.InitializeComponent();
        }
        public string GetCode()
        {
            return this.code;
        }
        public string GetName()
        {
            return this.name;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text;
            if (this.Text == "常用手术")
            {
                text = "select dict_code,dict_name,input_code from emr_doctor_custom_dict where dict_type='手术' and dept_code like '" + EmrSysPubVar.getDeptCode() + "'";
            }
            else
            {
                text = "select dict_code,dict_name,input_code from emr_doctor_custom_dict where dict_type='诊断' and dept_code='" + EmrSysPubVar.getDeptCode() + "'";
            }
            if (this.radioButton1.Checked)
            {
                text = text + " and input_code like '%" + this.textBox1.Text + "%'";
            }
            else
            {
                if (this.radioButton2.Checked)
                {
                    text = text + " and dict_name like '%" + this.textBox1.Text + "%'";
                }
                else
                {
                    text = text + " and dict_code like '%" + this.textBox1.Text + "%'";
                }
            }
            DataSet dataSet = DALUse.Query(text);
            if (dataSet.Tables.Count > 0)
            {
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    this.dataGridView1.DataSource = dataSet.Tables[0];
                }
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                if (this.dataGridView1.SelectedRows[0].Cells.Count > 1)
                {
                    this.txtCode.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim();
                    this.txtName.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim();
                }
            }
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                this.code = this.txtCode.Text;
                this.name = this.txtName.Text;
            }
            base.Close();
        }
        private void frmICDCode_Load(object sender, EventArgs e)
        {
            string sQLString;
            if (this.Text == "常用手术")
            {
                sQLString = "select dict_code,dict_name,input_code from emr_doctor_custom_dict where dict_type='手术' and dept_code='" + EmrSysPubVar.getDeptCode() + "'";
            }
            else
            {
                sQLString = "select dict_code,dict_name,input_code from emr_doctor_custom_dict where dict_type='诊断' and dept_code='" + EmrSysPubVar.getDeptCode() + "'";
            }
            DataSet dataSet = DALUse.Query(sQLString);
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                this.dataGridView1.DataSource = dataSet.Tables[0];
            }
            this.textBox1.Focus();
        }
    }
}