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
using JHEMR.EmrSysDAL;

namespace JHEMR.EMRHisCustom
{
    public partial class frmInfectSel : XtraForm
    {
        public string strPatientID = string.Empty;
        public int nVisitID = 1;
        public frmInfectSel()
        {
            InitializeComponent();
        }
        private void gvPatvisit_DoubleClick(object sender, EventArgs e)
        {
            if (this.gvPatvisit.FocusedRowHandle >= 0)
            {
                this.strPatientID = this.gvPatvisit.GetDataRow(this.gvPatvisit.FocusedRowHandle)["PATIENT_ID"].ToString();
                this.nVisitID = Convert.ToInt32(this.gvPatvisit.GetDataRow(this.gvPatvisit.FocusedRowHandle)["VISIT_ID"].ToString());
                base.DialogResult = DialogResult.OK;
                base.Close();
            }
        }
        private void btnSel_Click(object sender, EventArgs e)
        {
            string sQLString = "SELECT A.NAME,B.PATIENT_ID,B.VISIT_ID FROM PAT_MASTER_INDEX A,PAT_VISIT B WHERE A.PATIENT_ID=B.PATIENT_ID AND A.INP_NO='" + this.txtInpNo.Text.Trim() + "'";
            DataTable dataSource = new DataTable();
            dataSource = DALUse.Query(sQLString).Tables[0];
            this.gcPatVisit.DataSource = dataSource;
        }
    }
}