using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;

namespace JHEMR.EMREdit
{
    public partial class frmExamApply : Form
    {
        private string m_strReturn = "";
        private string m_strExamNo = "";
        public frmExamApply()
        {
            InitializeComponent();
        }


        public string ExamApplyValue
        {
            get { return m_strReturn; }
            set { m_strReturn = value; }
        }

        public string ExamNo
        {
            get { return m_strExamNo; }
            set { m_strExamNo = value; }
        }


        private void frmExamApply_Load(object sender, EventArgs e)
        {
            cboExamClass.Items.Add("");
            //填充数据
            DataSet objDataSet = new DataSet();
            objDataSet = EMREditHisAdaperUse.getExamClassDict();

            if (objDataSet.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = objDataSet.Tables[0];
                foreach (DataRow drCurrent in objTable.Rows)
                    cboExamClass.Items.Add(drCurrent["EXAM_CLASS_NAME"].ToString());
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string	v_exam_no;				//申请序号
            string	v_exam_class;			//检查类别
            string	v_exam_sub_class;		//检查子类
            string	v_performed_by;			//执行科室
            int	i;

            v_exam_class=cboExamClass.Text;
            v_exam_sub_class=cboExamSubClass.Text;
            if (txtDept.Text.Length <= 0)
            {
	            MessageBox.Show("检查类别，执行科室不能为空");
	            return;
            }
            v_performed_by = txtDept.Tag.ToString();

            //插入预约申请主记录
            //获取申请序号
            int nMaxExamNo=0;
            string strSQL = "select max(EXAM_NO) from exam_appoints";
            object objTemp = DALUse.GetSingle(strSQL);
            if (objTemp == null)
                nMaxExamNo = 1;
            else
                nMaxExamNo = Convert.ToInt32(objTemp.ToString()) + 1;//Convert.ToInt32(DALUse.GetSingle(strSQL).ToString())+1;
            v_exam_no=nMaxExamNo.ToString();
            //SELECT exam_no_seq.nextval INTO :v_exam_no FROM dual;
            strSQL="insert into EXAM_APPOINTS (EXAM_NO,PATIENT_ID,VISIT_ID,EXAM_CLASS,EXAM_SUB_CLASS,PERFORMED_BY,REQ_DATE_TIME,REQ_DEPT,REQ_PHYSICIAN) ";
            strSQL+= " VALUES (";
            strSQL+= " '"+v_exam_no+"',";
            strSQL+= " '"+EmrSysPubVar.getCurPatientID()+"',";
            strSQL+= " "+EmrSysPubVar.getCurPatientVisitID().ToString()+",";
            strSQL+= " '"+v_exam_class+"',";
            strSQL+= " '"+v_exam_sub_class+"',";
            strSQL+= " '"+v_performed_by+"',"; 
            strSQL += " to_date('" + dtApply.Text + "','YYYY-MM-DD HH24:MI'),";
            strSQL+= " '"+EmrSysPubVar.getDeptCode()+"',";
            strSQL+= " '"+EmrSysPubVar.getOperator()+"')";
            DALUse.ExecuteSql(strSQL);

            m_strReturn = v_exam_class + "-" + v_exam_sub_class;
            if (lbxItemSelected.Items.Count > 0)
                m_strReturn += "(";

            //插入预约条目
            for (i=0;i<lbxItemSelected.Items.Count;i++)
            {
                if (i > 0) m_strReturn += "、";
                strSQL="INSERT INTO EXAM_ITEMS (EXAM_NO,EXAM_ITEM_NO,EXAM_ITEM) values(";
                strSQL+= " '"+v_exam_no+"',";
                strSQL+= " "+i.ToString()+",";
                strSQL+= " '"+lbxItemSelected.Items[i].ToString() +"')";
                m_strReturn += lbxItemSelected.Items[i].ToString();
                DALUse.ExecuteSql(strSQL);
            }
            if (lbxItemSelected.Items.Count > 0)
                m_strReturn += ")";
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void cboExamClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboExamClass.SelectedIndex < 0) return;
            cboExamSubClass.Items.Clear();
            //填充数据
            DataSet objDataSet = new DataSet();
            objDataSet = EMREditHisAdaperUse.getExamSubClassDict(cboExamClass.Text);

            if (objDataSet.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = objDataSet.Tables[0];
                foreach (DataRow drCurrent in objTable.Rows)
                    cboExamSubClass.Items.Add(drCurrent["EXAM_SUBCLASS_NAME"].ToString());
            }

            if (cboExamSubClass.Items.Count > 0)
                cboExamSubClass.SelectedIndex = 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            codeStruc pcodeStruc = new codeStruc();
            pcodeStruc = EmrSysPubFunction.openCodeInput("dept", "");
            if (pcodeStruc.codename.Length > 0)
            {
                txtDept.Text = pcodeStruc.codename;
                txtDept.Tag = pcodeStruc.codeitem;
            }
            else
            {
                txtDept.Text = "";
                txtDept.Tag = "";
            }
        }

        private void cboExamSubClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxItemForSel.Items.Clear();
            lbxItemSelected.Items.Clear();
            //填充数据
            DataSet objDataSet = new DataSet();
            objDataSet = EMREditHisAdaperUse.getExamRptPattern(cboExamClass.Text, cboExamSubClass.Text);

            if (objDataSet.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = objDataSet.Tables[0];
                foreach (DataRow drCurrent in objTable.Rows)
                    lbxItemForSel.Items.Add(drCurrent["description"].ToString());
            }


        }

        private void lbxItemForSel_Click(object sender, EventArgs e)
        {
            if (lbxItemForSel.SelectedIndex>=0)
            {
                lbxItemSelected.Items.Add(lbxItemForSel.Text);
                lbxItemForSel.Items.RemoveAt(lbxItemForSel.SelectedIndex);
            }
        }

        private void lbxItemSelected_Click(object sender, EventArgs e)
        {
            if (lbxItemSelected.SelectedIndex >= 0)
            {
                lbxItemForSel.Items.Add(lbxItemSelected.Text);
                lbxItemSelected.Items.RemoveAt(lbxItemSelected.SelectedIndex);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}