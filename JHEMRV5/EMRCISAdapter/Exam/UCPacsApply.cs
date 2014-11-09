using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;
using System.Runtime.InteropServices;


namespace JHEMR.EMREdit
{
    public partial class UCPacsApply : UserControl,EmrEditUCInterface
    {
        string strSQL = "";
        string strInpNo = "";//סԺ��
        string strExamNo = "";//��ҳ���
        string strDeptCode = "";//�������
        string strUserID = "";//����ҽʦ
        public UCPacsApply()
        {
            InitializeComponent();
        }
        [DllImport("PacsApply.dll", EntryPoint = "ExecPacsCommand")]
        static extern string ExecPacsCommand(string ACommand, string ACommandParam);
        #region EmrEditUCInterface ��Ա

        public bool cmdCheckIsUnSave()
        {
            return false;
        }

        public bool getCloseFlag()
        {
            return true;
        }

        public void setPatientInfo(string strPatientID, int nVisitID)
        {
            //throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        private void UCPacsApply_Load(object sender, EventArgs e)
        {
            strSQL = "select inp_no from pat_master_index where patient_id='"+EmrSysPubVar.getCurPatientID()+"'";
            object objInpNo = DALUse.GetSingle(strSQL);
            if (objInpNo != null)
            {
                strInpNo = objInpNo.ToString();
            }
            strSQL = "select X_EXAM_NO from pat_visit where patient_id='" + EmrSysPubVar.getCurPatientID() + "' visit_id="+EmrSysPubVar.getCurPatientVisitID()+"";
            object objExamNo = DALUse.GetSingle(strSQL);
            if (objExamNo != null)
            {
                strExamNo = objExamNo.ToString();
            }


            ExecPacsCommand("StudyPatientIn", strInpNo);  //סԺ��
            ExecPacsCommand("HisInHospitalNo", strExamNo);    //��ҳ���
            ExecPacsCommand("PreStudyAppliedDepartment", EmrSysPubVar.getDeptName());   //�������
            ExecPacsCommand("PreStudyAppliedPhysician",EmrSysPubFunction.getUserName(EmrSysPubVar.getUserID(),true));     //����ҽ��
            ExecPacsCommand("SHOWFORM", "");     //��ʾ����
        }
    }
}
