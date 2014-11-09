using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;

namespace JHEMR.EMRHisCustom
{
    public partial class frmHisCustomCrbQuery : XtraForm
    {
        private DataTable dtUserDept = new DataTable();
        private DataTable m_dtInfection = new DataTable();
        public frmHisCustomCrbQuery()
        {
            InitializeComponent();
        }
        private void frmHisCustomCrbQuery_Load(object sender, EventArgs e)
        {
            this.FillUserDept();
            this.dtpStart.Text = EmrSysPubFunction.getServerNow().AddDays(-7.0).ToString();
            this.dtpEnd.Text = EmrSysPubFunction.getServerNow().AddDays(1.0).ToString();
            this.UpdateGvInfection();
        }
        private void FillUserDept()
        {
            DataSet dataSet = new DataSet();
            string text = "SELECT USER_DEPT,DEPT_NAME,DEFAULT_DEPT_FLAG FROM USER_DEPT a, DEPT_DICT b  ";
            text = text + " WHERE a.USER_DEPT=b.DEPT_CODE AND  a.USER_ID='" + EmrSysPubVar.getUserID() + "' ORDER BY DEPT_NAME";
            dataSet = DALUse.Query(text);
            if (dataSet.Tables.Count > 0)
            {
                this.dtUserDept = dataSet.Tables[0];
                foreach (DataRow dataRow in this.dtUserDept.Rows)
                {
                    this.cmbDept.Items.Add(dataRow["DEPT_NAME"].ToString());
                }
                this.cmbDept.Text = EmrSysPubVar.getDeptName();
                this.cmbDept.Tag = EmrSysPubVar.getDeptCode();
            }
        }
        private void UpdateGvInfection()
        {
            string sQLString = string.Concat(new string[]
			{
				"select a.*, b.name,b.sex,b.date_of_birth,c.admission_date_time,'' as dept_name,'' as age from pat_visit_contagion a,pat_master_index b,pat_visit c  where a.patient_id=b.patient_id and a.patient_id=c.patient_id and a.visit_id=c.visit_id and a.dept_code='",
				this.cmbDept.Tag.ToString(),
				"' and a.report_date_time>=to_date('",
				this.dtpStart.Text,
				"','YYYY-MM-DD HH24:MI:SS') and a.report_date_time<=to_date('",
				this.dtpEnd.Text,
				"','YYYY-MM-DD HH24:MI:SS')  "
			});
            this.m_dtInfection = DALUse.Query(sQLString).Tables[0];
            if (this.m_dtInfection.Rows.Count > 0)
            {
                for (int i = 0; i < this.m_dtInfection.Rows.Count; i++)
                {
                    this.m_dtInfection.Rows[i]["DEPT_NAME"] = EmrSysPubFunction.getDeptName(this.m_dtInfection.Rows[i]["dept_code"].ToString(), false);
                    this.m_dtInfection.Rows[i]["AGE"] = EmrSysPubFunction.GetAge(Convert.ToDateTime(this.m_dtInfection.Rows[i]["ADMISSION_DATE_TIME"].ToString()), Convert.ToDateTime(this.m_dtInfection.Rows[i]["DATE_OF_BIRTH"].ToString()));
                }
            }
            this.gcInfection.DataSource = this.m_dtInfection;
        }
        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.dtUserDept != null)
            {
                if (this.dtUserDept.IsInitialized)
                {
                    if (this.dtUserDept.Rows.Count > this.cmbDept.SelectedIndex)
                    {
                        DataRow dataRow = this.dtUserDept.Rows[this.cmbDept.SelectedIndex];
                        this.cmbDept.Tag = dataRow["USER_DEPT"].ToString();
                    }
                }
            }
        }
        private void sbtnUpdate_Click(object sender, EventArgs e)
        {
            this.UpdateGvInfection();
        }
        private void spbtnClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void gvInfection_DoubleClick(object sender, EventArgs e)
        {
            if (this.gvInfection.SelectedRowsCount >= 1)
            {
                DataRow dataRow = this.gvInfection.GetDataRow(this.gvInfection.FocusedRowHandle);
                frmHisCustomCrb frmHisCustomCrb = new frmHisCustomCrb();
                frmHisCustomCrb.FillPatInfo(dataRow["PATIENT_ID"].ToString(), Convert.ToInt32(dataRow["VISIT_ID"].ToString()), Convert.ToInt32(dataRow["NUM"].ToString()));
                frmHisCustomCrb.m_nQueryFlag = 1;
                frmHisCustomCrb.ShowDialog();
            }
        }
        private void spbtnPrint_Click(object sender, EventArgs e)
        {
        }
    }
}