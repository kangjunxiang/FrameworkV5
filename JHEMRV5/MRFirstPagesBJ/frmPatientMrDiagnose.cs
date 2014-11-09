using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using JHEMR.EmrSysDAL;

namespace JHEMR.MRFirstPagesBJ
{
    public partial class frmPatientMrDiagnose : Form
    {
        private string m_strPatientID = "";
        private int m_nVisitID = 0;
        private string m_strDiagnoseName = "";
        private string m_strDiagnoseCode = "";
        private DateTime m_dtDiagnoseDate = default(DateTime);
        public DataTable dtDiagnosis = new DataTable();
        private ArrayList DiagnoseNameList = new ArrayList();
        private ArrayList DiagnoseCodeList = new ArrayList();
        public frmPatientMrDiagnose()
        {
            InitializeComponent();
            this.dgvDiagnose.RegisterExistHeaderColumn();
        }

        public ArrayList GetDiagnoseNameList()
        {
            return this.DiagnoseNameList;
        }
        public ArrayList GetDiagnoseCodeList()
        {
            return this.DiagnoseCodeList;
        }
        public string getDiagnoseName()
        {
            return this.m_strDiagnoseName;
        }
        public string getDiagnoseCode()
        {
            return this.m_strDiagnoseCode;
        }
        public DateTime getDiagnoseDate()
        {
            return this.m_dtDiagnoseDate;
        }
        public void setPatientInfo(string strPatientID, int nVisitID)
        {
            this.m_strPatientID = strPatientID;
            this.m_nVisitID = nVisitID;
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();
            string text = "SELECT  DIAGNOSIS_TYPE_NAME as �������,DIAGNOSIS_NO as ���,DIAGNOSIS_SUB_NO as �Ӻ�,";
            text += " DIAGNOSIS_DESC as ������� ,CONFIRMED_INDICATOR,DIAGNOSIS_DATE as �������,DIAGNOSIS_CODE as ��ϱ���,DIAGNOSTICIAN_ID as ҽʦ,";
            text += " HOUSEMAN as ʵϰҽʦ,MODIFIER_ID as �ϼ�ҽʦ,LAST_MODIFY_DATE as �ϼ���ǩ����,";
            text += " SUPER_ID as ����ҽʦ, SUPER_SIGN_DATE as ������ǩ����,DIAGNOSIS_CLASS,FLAG, PATIENT_ID,VISIT_ID,DIAGNOSIS_TYPE ";
            text += " FROM PAT_DIAGNOSIS ";
            text = text + " WHERE ( PATIENT_ID ='" + this.m_strPatientID + "') ";
            object obj = text;
            text = string.Concat(new object[]
			{
				obj,
				"   AND  ( VISIT_ID =",
				this.m_nVisitID,
				") "
			});
            text += "   ORDER BY  DIAGNOSIS_TYPE_NAME,DIAGNOSIS_NO,DIAGNOSIS_SUB_NO";
            dataSet = DALUse.Query(text);
            if (dataSet.Tables.Count > 0)
            {
                dataTable = dataSet.Tables[0];
                this.dgvDiagnose.DataSource = dataTable.DefaultView;
            }
        }
        private void frmPatientMrDiagnose_Load(object sender, EventArgs e)
        {
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.dtDiagnosis.Columns.Add(new DataColumn("�������"));
            this.dtDiagnosis.Columns.Add(new DataColumn("��ϱ���"));
            this.dtDiagnosis.Columns.Add(new DataColumn("�������"));
            if (this.dgvDiagnose.SelectedRows.Count > 0)
            {
                for (int i = this.dgvDiagnose.SelectedRows.Count; i > 0; i--)
                {
                    DataRow dataRow = this.dtDiagnosis.NewRow();
                    dataRow["�������"] = this.dgvDiagnose.SelectedRows[i - 1].Cells["�������"].Value;
                    dataRow["��ϱ���"] = this.dgvDiagnose.SelectedRows[i - 1].Cells["��ϱ���"].Value;
                    dataRow["�������"] = this.dgvDiagnose.SelectedRows[i - 1].Cells["�������"].Value;
                    this.dtDiagnosis.Rows.Add(dataRow);
                }
                base.DialogResult = DialogResult.OK;
                base.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void dgvDiagnose_DoubleClick(object sender, EventArgs e)
        {
            this.btnOK_Click(sender, e);
        }
    }
}