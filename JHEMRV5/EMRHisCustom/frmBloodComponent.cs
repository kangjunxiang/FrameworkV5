using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using JHEMR.EmrSysDAL;

namespace JHEMR.EMRHisCustom
{
    public partial class frmBloodComponent : Form
    {
        public string m_strPatientID;
        private string m_strDBConnet = "HISConnect";
        private DataTable m_dtPatVisitBlood = new DataTable();
        private DataTable m_dtBloodCapacity = new DataTable();
        private DataTable m_dtBloodApply = new DataTable();
        private DataTable m_dtBloodTypeDict = new DataTable();
        private DataTable m_dtBloodFastSlow = new DataTable();
		
        public frmBloodComponent()
        {
            InitializeComponent();
        }
        private void frmBloodComponent_Load(object sender, EventArgs e)
        {
            this.FillBloodTypeDict();
            this.FillBloodApply();
            this.gvApply.Focus();
        }
        private void FillBloodTypeDict()
        {
            string sQLString = "select blood_type,blood_type_name,unit from BLOOD_COMPONENT where blood_match=1";
            this.m_dtBloodTypeDict = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            if (this.m_dtBloodTypeDict.Rows.Count > 0)
            {
                this.repositoryItemLookUpEdit1.DataSource = this.m_dtBloodTypeDict;
            }
            this.m_dtBloodFastSlow.Columns.Add(new DataColumn("name"));
            this.m_dtBloodFastSlow.Columns.Add(new DataColumn("code"));
            DataRow dataRow = this.m_dtBloodFastSlow.NewRow();
            dataRow["name"] = "¼±Õï";
            dataRow["code"] = "1";
            this.m_dtBloodFastSlow.Rows.Add(dataRow);
            DataRow dataRow2 = this.m_dtBloodFastSlow.NewRow();
            dataRow2["name"] = "¼Æ»®";
            dataRow2["code"] = "2";
            this.m_dtBloodFastSlow.Rows.Add(dataRow2);
            DataRow dataRow3 = this.m_dtBloodFastSlow.NewRow();
            dataRow3["name"] = "±¸Ñª";
            dataRow3["code"] = "3";
            this.m_dtBloodFastSlow.Rows.Add(dataRow3);
            this.repositoryItemLookUpEdit2.DataSource = this.m_dtBloodFastSlow;
        }
        private void FillBloodCapacity(string strApplyNum)
        {
            string sQLString = "SELECT a.FAST_SLOW,a.TRANS_DATE,a.TRANS_CAPACITY,a.APPLY_NUM,a.BLOOD_TYPE, a.MATCH_SUB_NUM,a.OPERATOR,b.BLOOD_TYPE_NAME,b.UNIT  FROM BLOOD_CAPACITY a , BLOOD_COMPONENT b WHERE (a.BLOOD_TYPE = b.BLOOD_TYPE) and ((a.APPLY_NUM= '" + strApplyNum + "') and (b.BLOOD_MATCH = '1' ))  ";
            this.m_dtBloodCapacity = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            this.gcBLOODCAPACITY.DataSource = this.m_dtBloodCapacity;
        }
        private void FillBloodApply()
        {
            string sQLString = "SELECT * FROM BLOOD_APPLY  WHERE (patient_id ='" + this.m_strPatientID + "' )";
            this.m_dtBloodApply = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            if (this.m_dtBloodApply.Rows.Count > 0)
            {
                this.gcApply.DataSource = this.m_dtBloodApply;
            }
        }
        private void gvApply_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 1)
            {
                DataRow dataRow = this.gvApply.GetDataRow(e.FocusedRowHandle);
                this.FillBloodCapacity(dataRow["APPLY_NUM"].ToString());
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void gvApply_GotFocus(object sender, EventArgs e)
        {
            if (this.gvApply.FocusedRowHandle >= 0)
            {
                DataRow dataRow = this.gvApply.GetDataRow(this.gvApply.FocusedRowHandle);
                this.FillBloodCapacity(dataRow["APPLY_NUM"].ToString());
            }
        }
        private void gvApply_DoubleClick(object sender, EventArgs e)
        {
            if (this.gvApply.FocusedRowHandle >= 0)
            {
                DataRow dataRow = this.gvApply.GetDataRow(this.gvApply.FocusedRowHandle);
                frmBloodApply frmBloodApply = new frmBloodApply();
                if (dataRow["APPLY_NUM"] != DBNull.Value)
                {
                    frmBloodApply.strApplyNum = dataRow["APPLY_NUM"].ToString();
                    if (frmBloodApply.ShowDialog() == DialogResult.OK)
                    {
                    }
                }
            }
        }
	
    }
}