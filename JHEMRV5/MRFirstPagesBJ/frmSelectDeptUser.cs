using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;

namespace JHEMR.MRFirstPagesBJ
{
    public partial class frmSelectDeptUser : Form
    {
        private DataTable objTable = new DataTable();
        public string m_strDBUser;
        public string m_strName;
        private DataTable dtUserDept = new DataTable();
        public int m_nanesthesia_doctor = 0;
        public frmSelectDeptUser()
        {
            InitializeComponent();
        }
        private void FillUserDept()
        {
            DataSet dataSet = new DataSet();
            string text;
            if (this.m_nanesthesia_doctor == 1)
            {
                text = "select dept_code as USER_DEPT, DEPT_NAME from DEPT_DICT where dept_name like '%Âé×í¿Æ%'";
            }
            else
            {
                text = "SELECT  USER_DEPT,DEPT_NAME FROM USER_DEPT a, DEPT_DICT b  ";
                text = text + " WHERE a.USER_DEPT=b.DEPT_CODE and  a.USER_ID='" + EmrSysPubVar.getUserID() + "'";
                text += " union  select dept_code as USER_DEPT, DEPT_NAME from DEPT_DICT where dept_name like '%Âé×í¿Æ'";
            }
            dataSet = DALUse.Query(text);
            if (dataSet.Tables.Count > 0)
            {
                this.dtUserDept = dataSet.Tables[0];
                int num = 0;
                bool flag = false;
                foreach (DataRow dataRow in this.dtUserDept.Rows)
                {
                    this.cboDept.Items.Add(dataRow["DEPT_NAME"].ToString());
                    if (EmrSysPubVar.getDeptCode().Equals(dataRow["USER_DEPT"].ToString()))
                    {
                        this.cboDept.SelectedIndex = num;
                        flag = true;
                    }
                    num++;
                }
                if (!flag && this.cboDept.Items.Count > 0)
                {
                    this.cboDept.SelectedIndex = 0;
                    this.cboDept_SelectedIndexChanged(null, null);
                }
            }
        }
        private void frmSelectDeptUser_Load(object sender, EventArgs e)
        {
            this.Text = EmrSysPubVar.getDeptName();
            this.dgvDeptUsers.RegisterExistHeaderColumn();
            this.FillUserDept();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.dgvDeptUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow dataGridViewRow = this.dgvDeptUsers.SelectedRows[0];
                this.m_strDBUser = dataGridViewRow.Cells["USER_ID"].Value.ToString();
                this.m_strName = dataGridViewRow.Cells["USER_NAME"].Value.ToString();
                base.DialogResult = DialogResult.OK;
                base.Close();
                SendKeys.Send("{tab}");
            }
        }
        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.dtUserDept != null)
            {
                if (this.dtUserDept.IsInitialized)
                {
                    if (this.dtUserDept.Rows.Count > this.cboDept.SelectedIndex)
                    {
                        DataRow dataRow = this.dtUserDept.Rows[this.cboDept.SelectedIndex];
                        this.objTable = MRFirstPageDAL.getDeptUser(dataRow["USER_DEPT"].ToString(), false);
                        this.Text = dataRow["DEPT_NAME"].ToString();
                        this.dgvDeptUsers.DataSource = this.objTable.DefaultView;
                    }
                }
            }
        }
        private void dgvDeptUsers_DoubleClick(object sender, EventArgs e)
        {
            this.btnOK_Click(sender, e);
        }
        private void dgvDeptUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.btnOK_Click(sender, e);
            }
        }
    }
}