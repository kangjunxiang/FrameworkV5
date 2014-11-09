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
    public partial class frmHisCustomHistory : DevExpress.XtraEditors.XtraForm
    {
        public string m_strPatient_ID = "";
        public string m_strVisit_ID = "";
        public string m_strNum = "";
        public int m_Flag = 0;
        public frmHisCustomHistory()
        {
            InitializeComponent();
        }
        private void frmHisCustomHistory_Load(object sender, EventArgs e)
        {
            string sQLString;
            if (this.m_Flag == 0)
            {
                sQLString = "select * from PAT_VISIT_CONTAGION where patient_id='" + this.m_strPatient_ID + "'";
            }
            else
            {
                sQLString = "select * from pat_visit_infection where patient_id='" + this.m_strPatient_ID + "'";
            }
            DataTable dataSource = DALUse.Query(sQLString).Tables[0];
            this.gcNum.DataSource = dataSource;
        }
        private void spbtnConfirm_Click(object sender, EventArgs e)
        {
            if (this.gvNum.SelectedRowsCount < 1)
            {
                MessageBox.Show("没有选中的行,请选中要查看的行!");
            }
            else
            {
                DataRow dataRow = this.gvNum.GetDataRow(this.gvNum.FocusedRowHandle);
                this.m_strVisit_ID = dataRow["visit_id"].ToString();
                this.m_strNum = dataRow["num"].ToString();
                base.DialogResult = DialogResult.OK;
                base.Close();
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            base.Close();
        }
    }
}