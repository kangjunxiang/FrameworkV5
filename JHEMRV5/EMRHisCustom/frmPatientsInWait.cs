using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
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
    public partial class frmPatientsInWait : DevExpress.XtraEditors.XtraForm
    {
        private string m_strDBConnet = "HISConnect";
        public frmPatientsInWait()
        {
            InitializeComponent();
        }
        private string getUserGroupWard()
        {
            string text = "''";
            string text2 = "";
            int num = 0;
            string str = EmrSysPubVar.getDbUser().ToUpper();
            string text3 = "select emp_no from staff_dict where upper(user_name)='" + str + "'";
            object single = DALUseSpecial.GetSingle(text3, this.m_strDBConnet);
            if (single != null)
            {
                text2 = single.ToString();
            }
            string result;
            if (text2.Length == 0)
            {
                result = text;
            }
            else
            {
                text3 = " select count(*) from staff_vs_group ";
                text3 = text3 + " where emp_no='" + text2 + "' and group_class='病区医生'";
                single = DALUseSpecial.GetSingle(text3, this.m_strDBConnet);
                if (single != null)
                {
                    if (single.ToString().Length > 0)
                    {
                        num = Convert.ToInt32(single.ToString());
                    }
                }
                if (num == 0)
                {
                    result = text;
                }
                else
                {
                    text3 = "SELECT b.ward_code  FROM STAFF_VS_GROUP a,dept_vs_ward b  WHERE a.GROUP_CODE=b.dept_code and a.emp_no='" + text2 + "' and a.group_class='病区医生'";
                    DataSet dataSet = new DataSet();
                    dataSet = DALUse.Query(text3);
                    if (dataSet.Tables.Count > 0)
                    {
                        if (dataSet.Tables[0].Rows.Count > 0)
                        {
                            text = "";
                            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                            {
                                if (text.Length > 0)
                                {
                                    text += ",";
                                }
                                text = text + "'" + dataRow["ward_code"].ToString() + "'";
                            }
                        }
                    }
                    result = text;
                }
            }
            return result;
        }
        private void frmPatientsInWait_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            string text = "SELECT WAIT_BED_PATS.NAME,WAIT_BED_PATS.SEX,WAIT_BED_PATS.DATE_OF_BIRTH,";
            text += "WAIT_BED_PATS.CHARGE_TYPE,WAIT_BED_PATS.CLINIC_DIAGNOSIS,WAIT_BED_PATS.MAILING_ADDRESS,";
            text += "DEPT_DICT.DEPT_NAME,WAIT_BED_PATS.REGISTERING_DATE,'' as AGE,WAIT_BED_PATS.PHONE_NUMBER ";
            text += " FROM WAIT_BED_PATS,DEPT_VS_WARD,DEPT_DICT ";
            text += " WHERE WAIT_BED_PATS.DEPT_WAITING_FOR=DEPT_VS_WARD.DEPT_CODE ";
            text += " AND  WAIT_BED_PATS.DEPT_WAITING_FOR=DEPT_DICT.DEPT_CODE";
            text += " AND  WAIT_BED_PATS.NOTIFY_TIMES>=0";
            text = text + " AND  (WAIT_BED_PATS.DEPT_WAITING_FOR in ('" + EmrSysPubVar.getDeptCode() + "'))";
            dataSet = DALUseSpecial.Query(text, this.m_strDBConnet);
            if (dataSet.Tables.Count > 0)
            {
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    dataSet.Tables[0].Rows[i]["AGE"] = EmrSysPubFunction.GetAge(Convert.ToDateTime(dataSet.Tables[0].Rows[i]["REGISTERING_DATE"]), Convert.ToDateTime(dataSet.Tables[0].Rows[i]["DATE_OF_BIRTH"]));
                }
                this.gridWaitForBeds.DataSource = dataSet.Tables[0];
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }
    }
}