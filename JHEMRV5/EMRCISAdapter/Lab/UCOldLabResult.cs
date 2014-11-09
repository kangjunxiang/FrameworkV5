using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using JHEMR.EmrSysUserCtl;
using JHEMR.EmrSysCom;
namespace JHEMR.EMREdit
{
    public partial class UCOldLabResult : UserControl
    {
        private string m_CurPatientID;
        private int m_CurVisitID ;
        public UCOldLabResult()
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
            objDataSet = EmrSysWebservices.EmrSysWebservicesUse.myEmrGetLabDataSetByPatientID(m_CurPatientID, m_CurVisitID);
            if (objDataSet == null) return;
            gcLabApply.DataSource = objDataSet.Tables[0];

        }
        private void gvLabApply_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            if (this.gvLabApply.SelectedRowsCount > 0)
            {
                try
                {

                    string strApplyNo = this.gvLabApply.GetRowCellValue(e.FocusedRowHandle, "ApplyNo").ToString().Trim();
                    DataSet objDataSet = EmrSysWebservices.EmrSysWebservicesUse.myEmrGetLabReportDataSet(strApplyNo);
                    if (objDataSet != null)
                    {
                        if (objDataSet.Tables.Count > 0)
                        {
                            DataTable objTable;
                            objTable = objDataSet.Tables[0];
                            this.gcReportt.DataSource = objTable.DefaultView;
                        }
                    }
                }
                catch (System.Exception E)
                {
                    EmrSysPubFunction.DoWithSystemException(E);
                }
            }
        }
    }
}
