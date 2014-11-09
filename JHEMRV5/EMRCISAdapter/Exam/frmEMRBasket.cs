using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace JHEMR.EMREdit
{
    public partial class UCExamApplyList : UserControl
    {
        private DataSet m_dsSetting = new DataSet();
        private string m_CurPatientID;
        private int m_CurVisitID;

        public UCExamApplyList()
        {
            InitializeComponent();
        }

        public void setPatient(string strPatientID, int intVisitID)
        {
            m_CurPatientID = strPatientID;
            m_CurVisitID = intVisitID;

            DataLoad();
        }

        private void DataLoad()
        {
            DataSet objDataSet = new DataSet();
            objDataSet = EmrSysWebservices.EmrSysWebservicesUse.myEmrGetExamMaster(m_CurPatientID,m_CurVisitID);
            if (objDataSet == null)
                return;
            if (objDataSet.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = objDataSet.Tables[0];
                dgvExamMaster.DataSource = objTable.DefaultView;
            }
            foreach (DataGridViewRow row in dgvExamMaster.Rows)
            {
                if (row.Cells["RESULT_STATUS"].Value.ToString() == "报告")
                {
                    DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                    cellStyle.BackColor = Color.Wheat;
                    row.DefaultCellStyle = cellStyle;
                }
            }
            dgvExamMaster_Click(dgvExamMaster, new EventArgs());
        }

        private void GetCSDataLoad()
        {
          
        }

        private void UCExamApplyList_Load(object sender, EventArgs e)
        {
           
        }

        private void dgvExamMaster_Click(object sender, EventArgs e)
        {
            if (dgvExamMaster.SelectedRows.Count > 0)
            {
                DataGridViewRow objCurRow = dgvExamMaster.SelectedRows[0];
                string strContent = "";
                string strReportDate;
                string strExamSubClass;	//检查项目
                string strExamClass;	//检查项目
                string strExamNo;
                string strExamReport;
                if (objCurRow.Cells["RESULT_STATUS"].Value.ToString() != "报告")
                {
                    txtExam.Rtf = "";
                    return;
                }
                strExamNo = objCurRow.Cells["EXAM_NO"].Value.ToString().Trim();
                DataSet dtExamReport;
                dtExamReport=EmrSysWebservices.EmrSysWebservicesUse.myEmrGetExamReport(strExamNo);
                if (dtExamReport.Tables[0].Rows.Count != 1) return;
                strExamReport = dtExamReport.Tables[0].Rows[0]["exam_report"].ToString();


            }

        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void dgvExamMaster_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvExamMaster.SelectedRows.Count > 0)
            {
                DataGridViewRow objCurRow = dgvExamMaster.SelectedRows[0];
                string strContent = "";
                string strReportDate;
                string strExamSubClass;	//检查项目
                string strExamClass;	//检查项目
                string strExamNo;
                string strExamReport;
                if (objCurRow.Cells["RESULT_STATUS"].Value.ToString() != "报告")
                {
                    txtExam.Rtf = "";
                    return;
                }
                strExamNo = objCurRow.Cells["EXAM_NO"].Value.ToString().Trim();
                DataSet dtExamReport;
                dtExamReport = EmrSysWebservices.EmrSysWebservicesUse.myEmrGetExamReport(strExamNo);
                if (dtExamReport.Tables[0].Rows.Count != 1) return;
                strExamReport = dtExamReport.Tables[0].Rows[0]["exam_report"].ToString();
                txtExam.Text = strExamReport;

       

            }


        }

        private void btnMedcom_Click(object sender, EventArgs e)
        {
            DataTable dt = m_dsSetting.Tables[0];

            string m_strServer = "";
            string m_strServerPath = "";
            string m_strDatabase = "";
            string m_strFieldName = "";
            string m_strExeFile = "";
            string m_strTemp = "";
            DataRow dr = dt.Rows[0];
            m_strServer = dr["SERVER"].ToString();
            m_strServerPath = dr["SERVERPATH"].ToString();
            m_strDatabase = dr["DATABASE"].ToString();
            m_strFieldName = dr["FIELDNAME"].ToString();
            m_strExeFile = dr["EXEFILE"].ToString();

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = Application.StartupPath + "\\" + m_strExeFile;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            p.StartInfo.Arguments = m_CurPatientID;
            try
            {
                p.Start();
            }
            catch (Exception e11)
            {
                //MessageBox.Show("调用"
            }

            //Application.StartupPath + "\\

            /*
            if (dgvExamMaster.SelectedRows.Count > 0)
            {
                DataGridViewRow objCurRow = dgvExamMaster.SelectedRows[0];

                frmMedcomExam objFrm = new frmMedcomExam();
                if (objFrm.setPatient(m_CurPatientID, m_CurVisitID, objCurRow.Cells["EXAM_CLASS"].Value.ToString()))
                    objFrm.ShowDialog();
            }
            */
        }
        
    }
}
