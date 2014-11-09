using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace JHEMR.EMREdit
{
    public partial class UCExamApplyList : UserControl 
    {
        private string m_CurPatientID;
        private int m_CurVisitID;
        private string strExamUrl = "";

        public UCExamApplyList()
        {
          
            InitializeComponent();
        }

        public void setPatient(string strPatientID, int intVisitID)
        {
            m_CurPatientID = strPatientID;
            m_CurVisitID = intVisitID;
            object[] objUrl = new object[1];
            objUrl[0] = "EXAMWEBURL";
            strExamUrl = EmrSysWebservices.EmrSysWebservicesUse.myEmrGenralStr(objUrl);

            DataLoad();
        }

        private void DataLoad()
        {
            DataSet objDataSet = new DataSet();
            objDataSet = EmrSysWebservices.EmrSysWebservicesUse.myEmrGetExamMaster(m_CurPatientID, m_CurVisitID);
            if (objDataSet == null)
                return;
            if (objDataSet.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = objDataSet.Tables[0];
                dgvExamMaster.DataSource = objTable.DefaultView;
            }
            //foreach (DataGridViewRow row in dgvExamMaster.Rows)
            //{
            //    if (row.Cells["RESULT_STATUS"] != null)
            //    {
            //        if (row.Cells["RESULT_STATUS"].Value.ToString() == "报告")
            //        {
            //            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            //            cellStyle.BackColor = Color.Wheat;
            //            row.DefaultCellStyle = cellStyle;
            //        }
            //    }
            //}
            dgvExamMaster_Click(dgvExamMaster, new EventArgs());
        }

        private void UCExamApplyList_Load(object sender, EventArgs e)
        {
           
        }

        private void dgvExamMaster_Click(object sender, EventArgs e)
        {
            if (dgvExamMaster.SelectedRows.Count > 0)
            {
                //DataGridViewRow objCurRow = dgvExamMaster.SelectedRows[0];
                //string strContent = "";
                //string strReportDate;
                //string strExamSubClass;	//检查项目
                //string strExamClass;	//检查项目
                //string strExamNo;
                //string strExamReport;
       
                //strExamNo = objCurRow.Cells["EXAM_NO"].Value.ToString().Trim();
                //DataSet dtExamReport;
                //dtExamReport=EmrSysWebservices.EmrSysWebservicesUse.myEmrGetExamReport(strExamNo);
                //if (dtExamReport.Tables[0].Rows.Count != 1)
                //{
                //    txtExam.Text = "";
                //    return;
                //}
                //if (dtExamReport.Tables[0].Rows[0]["exam_report"] != DBNull.Value)
                //{
                //    strExamReport = dtExamReport.Tables[0].Rows[0]["exam_report"].ToString();
                //    txtExam.Text = strExamReport;
                //}
                //else
                //    txtExam.Text = "";

            }

        }

        private void dgvExamMaster_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvExamMaster.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvdr = dgvExamMaster.SelectedRows[0];
                if (dgvdr.Cells["EXAM_NO"].Value.ToString().Length > 0)
                {
                    webBrowser1.Navigate(strExamUrl + dgvdr.Cells["EXAM_NO"].Value);
                    //webBrowser1.Navigate("http://172.16.2.57/nj/nj.fw?exam_id=10001");
                }
            }
        }
    }
}
