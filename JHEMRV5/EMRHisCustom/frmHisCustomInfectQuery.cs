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
    public partial class frmHisCustomInfectQuery : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dtUserDept;
        private DataTable m_dtInfection = new DataTable();
        public frmHisCustomInfectQuery()
        {
            InitializeComponent();
        }
        private void frmHisCustomInfectQuery_Load(object sender, EventArgs e)
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
				"select a.*, b.name,b.sex,b.date_of_birth,c.admission_date_time,'' as dept_name,'' as age from pat_visit_infection a,pat_master_index b,pat_visit c  where a.patient_id=b.patient_id and a.patient_id=c.patient_id and a.visit_id=c.visit_id and a.dept_code='",
				this.cmbDept.Tag.ToString(),
				"' and a.report_date_time>=to_date('",
				this.dtpStart.Text,
				"','YYYY-MM-DD HH24:MI:SS') and a.report_date_time<=to_date('",
				this.dtpEnd.Text,
				"','YYYY-MM-DD HH24:MI:SS') order by a.infection_part,c.admission_date_time,a.infection_date_time"
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
        private void spbtnClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void sbtnUpdate_Click(object sender, EventArgs e)
        {
            this.UpdateGvInfection();
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
        private void gvInfection_DoubleClick(object sender, EventArgs e)
        {
            if (this.gvInfection.SelectedRowsCount >= 1)
            {
                DataRow dataRow = this.gvInfection.GetDataRow(this.gvInfection.FocusedRowHandle);
                frmHisCustomInfect frmHisCustomInfect = new frmHisCustomInfect();
                frmHisCustomInfect.FillPatInfo(dataRow["PATIENT_ID"].ToString(), Convert.ToInt32(dataRow["VISIT_ID"].ToString()), Convert.ToInt32(dataRow["NUM"].ToString()));
                frmHisCustomInfect.m_QueryFlag = 1;
                frmHisCustomInfect.ShowDialog();
            }
        }
        private void spbtnPrint_Click(object sender, EventArgs e)
        {
            if (this.m_dtInfection.Rows.Count >= 1)
            {
                DataTable dataTable = new DataTable();
                for (int i = 0; i <= 1; i++)
                {
                    dataTable.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
                }
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = "科室名称";
                dataRow[1] = this.cmbDept.Text;
                dataTable.Rows.Add(dataRow);
                DataRow dataRow2 = dataTable.NewRow();
                dataRow2[0] = "统计时间";
                dataRow2[1] = Convert.ToDateTime(this.dtpStart.Text).ToString("yyyy年MM月dd日") + " 到 " + Convert.ToDateTime(this.dtpEnd.Text).ToString("yyyy年MM月dd日");
                dataTable.Rows.Add(dataRow2);
                DataTable dataTable2 = new DataTable();
                for (int i = 0; i <= 10; i++)
                {
                    dataTable2.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
                }
                foreach (DataRow dataRow3 in this.m_dtInfection.Rows)
                {
                    DataRow dataRow4 = dataTable2.NewRow();
                    dataRow4[0] = dataRow3["PATIENT_ID"].ToString();
                    dataRow4[1] = dataRow3["NAME"].ToString();
                    dataRow4[2] = dataRow3["SEX"].ToString();
                    dataRow4[3] = dataRow3["AGE"].ToString();
                    dataRow4[4] = dataRow3["ADMISSION_DATE_TIME"].ToString();
                    dataRow4[5] = dataRow3["DEPT_NAME"].ToString();
                    dataRow4[6] = ((dataRow3["CLINIC_DIAG"] == DBNull.Value) ? " " : dataRow3["CLINIC_DIAG"].ToString());
                    dataRow4[7] = dataRow3["INFECTION_DATE_TIME"].ToString();
                    dataRow4[8] = dataRow3["REPORT_DATE_TIME"].ToString();
                    dataRow4[9] = dataRow3["INFECTION_PART_PARENT"].ToString();
                    dataRow4[10] = ((dataRow3["BYXSJ_FLAG"] == DBNull.Value) ? " " : dataRow3["BYXSJ_FLAG"].ToString());
                    dataTable2.Rows.Add(dataRow4);
                }
                frmPrint frmPrint = new frmPrint();
                frmPrint.PrintOperation("院内感染上报登记表", dataTable, dataTable2);
            }
        }
        private void spbtnExcel_Click(object sender, EventArgs e)
        {
        }
    }
}