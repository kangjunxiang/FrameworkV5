using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Excel;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;

namespace JHEMR.EMRHisCustom
{
    public partial class frmHisCustomInOut : DevExpress.XtraEditors.XtraForm
    {
        private System.Data.DataTable dtUserDept = new System.Data.DataTable();
        private System.Data.DataTable m_dtPatInfo = new System.Data.DataTable();
        private int count = 0;
        public frmHisCustomInOut()
        {
            InitializeComponent();
        }
        private void sbtnUpdate_Click(object sender, EventArgs e)
        {
            string sQLString = string.Concat(new string[]
			{
				"select a.patient_id,a.visit_id,b.inp_no,a.ADMISSION_DATE_TIME, b.name,b.sex,'' as AGE,b.birth_place,'' as DEPT_NAME,a.occupation,a.DISCHARGE_DATE_TIME,(case a.DISCHARGE_CONDITIONS  when '1' then '好转' when '2' then '未愈'  when '3' then '治愈' when '4' then '死亡' when '5' then '其他' else '' end)DISCHARGE_CONDITIONS,'' as INHOSDAYS,'' as DIAGNOSIS,'' as DISCHARGE_DIAGNOSIS,'' as TREAT_RESULT,'' as CLINIC_DIAG,a.MAILING_ADDRESS,a.DOCTOR_IN_CHARGE,a.CONSULTING_DOCTOR,a.next_of_kin,a.relationship,a.next_of_kin_phone,b.date_of_birth,a.SFCRCFZD as SFCRCFZD  from pat_visit a, pat_master_index b  where a.patient_id=b.patient_id and a.dept_admission_to='",
				this.cmbDept.Tag.ToString(),
				"' and a.admission_date_time>=to_date('",
				this.dtpStart.Text,
				" 00:00:00','YYYY-MM-DD HH24:MI:SS') and a.admission_date_time<=to_date('",
				this.dtpEnd.Text,
				" 23:59:59','YYYY-MM-DD HH24:MI:SS')"
			});
            this.m_dtPatInfo = DALUse.Query(sQLString).Tables[0];
            this.count = this.m_dtPatInfo.Rows.Count;
            for (int i = 0; i < this.m_dtPatInfo.Rows.Count; i++)
            {
                this.m_dtPatInfo.Rows[i]["AGE"] = EmrSysPubFunction.GetAge(Convert.ToDateTime(this.m_dtPatInfo.Rows[i]["ADMISSION_DATE_TIME"].ToString()), Convert.ToDateTime(this.m_dtPatInfo.Rows[i]["date_of_birth"].ToString()));
                this.m_dtPatInfo.Rows[i]["DEPT_NAME"] = this.cmbDept.Text;
                if (this.m_dtPatInfo.Rows[i]["DISCHARGE_DATE_TIME"] != DBNull.Value)
                {
                    this.m_dtPatInfo.Rows[i]["INHOSDAYS"] = EmrSysPubFunction.GetBetweenDays(Convert.ToDateTime(this.m_dtPatInfo.Rows[i]["ADMISSION_DATE_TIME"].ToString()), Convert.ToDateTime(this.m_dtPatInfo.Rows[i]["DISCHARGE_DATE_TIME"].ToString()));
                    this.m_dtPatInfo.Rows[i]["DIAGNOSIS"] = this.GetAdmissionDiagnosis(this.m_dtPatInfo.Rows[i]["PATIENT_ID"].ToString(), this.m_dtPatInfo.Rows[i]["VISIT_ID"].ToString(), true);
                    this.m_dtPatInfo.Rows[i]["DISCHARGE_DIAGNOSIS"] = this.GeOutDiagnosis(this.m_dtPatInfo.Rows[i]["PATIENT_ID"].ToString(), this.m_dtPatInfo.Rows[i]["VISIT_ID"].ToString(), true);
                    this.m_dtPatInfo.Rows[i]["TREAT_RESULT"] = this.GeTreatResult(this.m_dtPatInfo.Rows[i]["PATIENT_ID"].ToString(), this.m_dtPatInfo.Rows[i]["VISIT_ID"].ToString(), true);
                }
                else
                {
                    this.m_dtPatInfo.Rows[i]["INHOSDAYS"] = EmrSysPubFunction.GetBetweenDays(Convert.ToDateTime(this.m_dtPatInfo.Rows[i]["ADMISSION_DATE_TIME"].ToString()), EmrSysPubFunction.getServerNow());
                    this.m_dtPatInfo.Rows[i]["DIAGNOSIS"] = this.GetAdmissionDiagnosis(this.m_dtPatInfo.Rows[i]["PATIENT_ID"].ToString(), this.m_dtPatInfo.Rows[i]["VISIT_ID"].ToString(), false);
                    this.m_dtPatInfo.Rows[i]["DISCHARGE_DIAGNOSIS"] = this.GeOutDiagnosis(this.m_dtPatInfo.Rows[i]["PATIENT_ID"].ToString(), this.m_dtPatInfo.Rows[i]["VISIT_ID"].ToString(), false);
                    this.m_dtPatInfo.Rows[i]["TREAT_RESULT"] = this.GeTreatResult(this.m_dtPatInfo.Rows[i]["PATIENT_ID"].ToString(), this.m_dtPatInfo.Rows[i]["VISIT_ID"].ToString(), false);
                }
            }
            this.m_dtPatInfo.Columns[0].Caption = "门诊号";
            this.m_dtPatInfo.Columns[1].Caption = "住院号";
            this.m_dtPatInfo.Columns[2].Caption = "住院次";
            this.m_dtPatInfo.Columns[3].Caption = "入院日期";
            this.m_dtPatInfo.Columns[4].Caption = "姓名";
            this.m_dtPatInfo.Columns[5].Caption = "性别";
            this.m_dtPatInfo.Columns[6].Caption = "年龄";
            this.m_dtPatInfo.Columns[7].Caption = "籍贯";
            this.m_dtPatInfo.Columns[8].Caption = "部别";
            this.m_dtPatInfo.Columns[9].Caption = "职别";
            this.m_dtPatInfo.Columns[10].Caption = "出院日期";
            this.m_dtPatInfo.Columns[11].Caption = "住院日数";
            this.m_dtPatInfo.Columns[12].Caption = "入院诊断时治疗经过或施行手术";
            this.m_dtPatInfo.Columns[13].Caption = "出院时诊断";
            this.m_dtPatInfo.Columns[14].Caption = "出院情况";
            this.m_dtPatInfo.Columns[15].Caption = "并发症";
            this.m_dtPatInfo.Columns[16].Caption = "住址";
            this.m_dtPatInfo.Columns[17].Caption = "负责医生";
            this.m_dtPatInfo.Columns[18].Caption = "门诊医生";
            this.m_dtPatInfo.Columns[19].Caption = "联系人";
            this.m_dtPatInfo.Columns[20].Caption = "关系";
            this.m_dtPatInfo.Columns[21].Caption = "联系电话";
            this.m_dtPatInfo.Columns[22].Caption = "出生日期";
            this.m_dtPatInfo.Columns[23].Caption = "是否有传染病，初或复诊";
            this.gcPat.DataSource = this.m_dtPatInfo;
        }
        private string GetAdmissionDiagnosis(string strPatientID, string strVisitID, bool blOut)
        {
            string sQLString = string.Empty;
            string result = "";
            if (blOut)
            {
                sQLString = "select t.diagnosis_desc as diagnosis from diagnosis t where t.diagnosis_type=2 and t.diagnosis_no=1 and t.patient_id='" + strPatientID + "' and visit_id=" + strVisitID;
            }
            else
            {
                sQLString = "select t.diagnosis from pats_in_hospital t where patient_id='" + strPatientID + "' and visit_id=" + strVisitID;
            }
            object single = DALUse.GetSingle(sQLString);
            if (single != null)
            {
                result = single.ToString();
            }
            return result;
        }
        private string GeOutDiagnosis(string strPatientID, string strVisitID, bool blOut)
        {
            string sQLString = string.Empty;
            string result = "";
            if (blOut)
            {
                sQLString = "select t.diagnosis_desc as diagnosis from diagnosis t where t.diagnosis_type=3 and t.diagnosis_no=1 and t.patient_id='" + strPatientID + "' and visit_id=" + strVisitID;
                object single = DALUse.GetSingle(sQLString);
                if (single != null)
                {
                    result = single.ToString();
                }
            }
            else
            {
                result = "";
            }
            return result;
        }
        private string GeTreatResult(string strPatientID, string strVisitID, bool blOut)
        {
            string sQLString = string.Empty;
            string result = "";
            if (blOut)
            {
                sQLString = "select t.treat_result as treat_result  from diagnosis t where t.diagnosis_type=3 and t.diagnosis_no=1 and t.patient_id='" + strPatientID + "' and visit_id=" + strVisitID;
                object single = DALUse.GetSingle(sQLString);
                if (single != null)
                {
                    result = single.ToString();
                }
            }
            else
            {
                result = "";
            }
            return result;
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
        private void frmHisCustomInOut_Load(object sender, EventArgs e)
        {
            this.FillUserDept();
            this.dtpStart.Text = EmrSysPubFunction.getServerNow().AddDays(-1.0).ToShortDateString();
            this.dtpEnd.Text = EmrSysPubFunction.getServerNow().AddDays(1.0).ToShortDateString();
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
        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void 保存为EXCEL文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHisCustomInOut.ExportExcel(this.m_dtPatInfo);
        }
        public static void ExportExcel(System.Data.DataTable eDataTable)
        {
            try
            {
                ApplicationClass applicationClass = new ApplicationClass();
                Workbook workbook = applicationClass.Workbooks.Add(1);
                Worksheet worksheet = (Worksheet)workbook.Worksheets[1];
                applicationClass.Visible = true;
                for (int i = 0; i < eDataTable.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = eDataTable.Columns[i].Caption;
                }
                for (int j = 0; j < eDataTable.Rows.Count; j++)
                {
                    for (int i = 0; i < eDataTable.Columns.Count; i++)
                    {
                        worksheet.Cells[j + 2, i + 1] = eDataTable.Rows[j][i];
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                GC.Collect();
            }
        }
        private void save_frm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.count + 1; i++)
            {
                DataRow dataRow = this.gvPat.GetDataRow(i);
                if (dataRow != null)
                {
                    string text = dataRow["PATIENT_ID"].ToString();
                    string value = dataRow["VISIT_ID"].ToString();
                    int num = (int)Convert.ToInt16(value);
                    string text2 = dataRow["SFCRCFZD"].ToString();
                    string sQLString = string.Concat(new object[]
					{
						"update  pat_visit set SFCRCFZD='",
						text2,
						"' where patient_id='",
						text,
						"' and visit_id=",
						num
					});
                    DALUse.Query(sQLString);
                }
            }
            MessageBox.Show("保存成功！");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "xls";
            saveFileDialog.Filter = "Excel文件|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.gvPat.ExportToExcelOld(saveFileDialog.FileName);
                    MessageBox.Show("导出成功");
                }
                catch (Exception var_1_51)
                {
                    MessageBox.Show("导出异常，请确认导出文件未被其他程序占用");
                }
            }
        }
    }
}