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
using System.Runtime.InteropServices;
using System.Data.OleDb;
namespace JHEMR.EMREdit
{
    public partial class uchisoraclejc : UserControl, EmrEditUCInterface
    {


       


        [DllImport(@"DoctorWork.dll")]
   public static extern int GINITINTERFACE();
        [DllImport(@"DoctorWork.dll")]
        public static extern int GGETUSERFUNCTION(int gnh,string seorr);
        [DllImport(@"DoctorWork.dll")]
        public static extern void GFREEINTERFACE();
        public uchisoraclejc()
        {
            InitializeComponent();
        }
        private string m_CurPatientID;
        private int m_CurVisitID;
        #region EmrEditUCInterface ≥…‘±
        //public static DataSet getusername(string strDbUser)
        //{
        //    StringBuilder strSQL = new StringBuilder();
        //    strSQL.Append("select a.db_user, a.user_name,a.user_id from users a,EMR_USER_ONLINE b where a.db_user=b.db_user and a.db_user='" + strDbUser + "'");

        //    return DALUse.Query(strSQL.ToString());
        //}
        bool EmrEditUCInterface.cmdCheckIsUnSave()
        {
           
            this.Dispose(true);
          
            return false;
        }

        bool EmrEditUCInterface.getCloseFlag()
        {
           
            this.Dispose(true);
          
            return false;
        }

        void EmrEditUCInterface.setPatientInfo(string strPatientID, int nVisitID)
        {
            int inp_no=0;
            //string db_user = string.Empty;
            //string user_name = string.Empty;
            //string dept_code = string.Empty;

           // string dept_name = string.Empty;
            string strSQL = "select a.db_user, a.user_name,a.user_id,b.dept_name,b.dept_code from users a,EMR_USER_ONLINE b where a.db_user=b.db_user and a.db_user='" + EmrSysPubVar.getDbUser() + "'";
            DataSet usress = new DataSet();
            usress = DALUse.Query(strSQL);

            m_CurPatientID = strPatientID;
            m_CurVisitID = nVisitID;
            string strSQLl = "select * from pat_visit where patient_id ='" + m_CurPatientID + "'";
            DataSet objdateset = new DataSet();
            objdateset = DALUse.Query(strSQLl);
            if (objdateset.Tables[0].Rows[0]["HISORDER"].ToString() == EmrSysPubVar.getDbUser())
            {
            inp_no = Convert.ToInt32(objdateset.Tables[0].Rows[0]["inp_no"]);
            string CurPatientID = m_CurPatientID;
            string db_user = Convert.ToString(usress.Tables[0].Rows[0]["db_user"]);
            string user_name = Convert.ToString(usress.Tables[0].Rows[0]["user_name"]);
            string dept_code = Convert.ToString(usress.Tables[0].Rows[0]["dept_code"]);
            string dept_name = Convert.ToString(usress.Tables[0].Rows[0]["dept_name"]);
            

            string FileName = Application.StartupPath + "\\Doctorinterface.ini";
            IniFiles ini = new IniFiles(FileName);
            ini.WriteString("EMR", "iHzlsh", inp_no.ToString().Trim());
            ini.WriteString("EMR", "sHzbabh", m_CurPatientID.Trim());
            ini.WriteString("EMR", "iHzZycs", m_CurVisitID.ToString().Trim());
            ini.WriteString("EMR", "sCzybm", db_user.Trim());
            ini.WriteString("EMR", "sCzyxm", user_name.Trim());
            ini.WriteString("EMR", "sKsmc", dept_name.Trim());
            ini.WriteString("EMR", "sKsbm", dept_code.Trim());
            ini.WriteString("EMR", "sYsbm", db_user.Trim());
            GINITINTERFACE();
            //GINITINTERFACE(Convert.ToInt32(objdateset.Tables[0].Rows[0]["inp_no"]), m_CurVisitID, m_CurPatientID, EmrSysPubVar.getDbUser(), EmrSysPubVar.getDbUser(), EmrSysPubVar.getDeptCode(), EmrSysPubVar.getDeptName(), EmrSysPubVar.getDbUser());
            //GINITINTERFACE(Convert.ToInt32(objdateset.Tables[0].Rows[0]["inp_no"]), m_CurVisitID, m_CurPatientID, Convert.ToString(usress.Tables[0].Rows[0]["db_user"]), Convert.ToString(usress.Tables[0].Rows[0]["user_name"]), Convert.ToString(usress.Tables[0].Rows[0]["dept_code"]), Convert.ToString(usress.Tables[0].Rows[0]["dept_name"]), Convert.ToString(usress.Tables[0].Rows[0]["db_user"]));
            string abc = "";
            if (GGETUSERFUNCTION(10, abc) < 0)
            {
                MessageBox.Show(abc);
               
            }
                
            }



        }


      


        #endregion

        private void uchisoraclejc_Load(object sender, EventArgs e)
        {

        }
    }
}
