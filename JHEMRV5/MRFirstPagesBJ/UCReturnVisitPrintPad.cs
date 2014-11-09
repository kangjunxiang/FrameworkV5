using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysUserCtl;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;

namespace JHEMR.MRFirstPagesBJ
{
    public partial class UCReturnVisitPrintPad : UCEMRPad30
    {
        public string m_strPatientID;
        public string m_strPatientName;
        public string m_nVisitID;
        public static string strTemp = string.Empty;
        public UCReturnVisitPrintPad()
        {
            InitializeComponent(); base.PadSetDocumentMode(2);
            base.PadShowToolbar(false);
        }
        public bool open_templet_file()
        {
            base.PadCleanPadDocumentMircoFieldElemValue();
            base.PadSetMicroField("住院号", this.m_strPatientID);
            base.PadSetMicroField("姓名", this.m_strPatientName);
            base.PadUpdateMicroField(true);
            bool result;
            if (!base.PadOpenFile(EmrSysPubVar.getTempFileFullName()))
            {
                MessageBox.Show("打开文件出错!");
                result = false;
            }
            else
            {
                this.fillFirstPageData();
                base.PadCleanUndoBuffer();
                result = true;
            }
            return result;
        }
        public static int getascii(char c)
        {
            return (int)c;
        }
        private void fillFirstPageData()
        {
            string sQLString = string.Concat(new string[]
			{
				"select patient_name, outhospital_diagnose, datetime_year, datetime_month, datetime_day, datetime_noon, return_visit_dept, return_visit_time, return_visit_type \r\n                                  from fu_return_visit_order \r\n                                 where patient_id = '",
				this.m_strPatientID,
				"' and inp_no = '",
				this.m_nVisitID,
				"'"
			});
            DataTable dataTable = new DataTable();
            try
            {
                DataSet dataSet = new DataSet();
                dataSet = DALUse.Query(sQLString);
                if (dataSet.Tables.Count <= 0 || dataSet.Tables[0].Rows.Count <= 0)
                {
                    MessageBox.Show("数据库连接错误！");
                    return;
                }
                dataTable = dataSet.Tables[0];
            }
            catch (Exception var_3_AC)
            {
                MessageBox.Show("数据库连接错误！");
                return;
            }
            DataRow dataRow = dataTable.Rows[0];
            string strText = string.Concat(new string[]
			{
				dataRow["datetime_year"].ToString(),
				" 年  ",
				dataRow["datetime_month"].ToString(),
				" 月  ",
				dataRow["datetime_day"].ToString(),
				" 日  ",
				dataRow["datetime_noon"].ToString(),
				" 午  ",
				dataRow["return_visit_dept"].ToString(),
				" 科"
			});
            if (base.PadFindField("姓名", -1, 1, true))
            {
                base.PadSetFieldText(-1, -1, -1, -1, dataRow["patient_name"].ToString());
            }
            if (base.PadFindField("出院诊断", -1, 1, true))
            {
                base.PadSetFieldText(-1, -1, -1, -1, dataRow["outhospital_diagnose"].ToString());
            }
            if (base.PadFindField("预约时间", -1, 1, true))
            {
                base.PadSetFieldText(-1, -1, -1, -1, strText);
            }
            if (base.PadFindField("预约医生", -1, 1, true))
            {
                base.PadSetFieldText(-1, -1, -1, -1, dataRow["return_visit_type"].ToString());
            }
        }
    }
}
