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
    public partial class frmLabApply : Form
    {
        private string m_strReturn = "";
        private string m_strTestNo = "";

        DataSet objDataSetDept = new DataSet();
        DataSet objDataSetSheet = new DataSet();
        DataSet objDataSetSpeciman = new DataSet();

        public frmLabApply()
        {
            InitializeComponent();
        }

        public string LabApplyValue
        {
            get { return m_strReturn; }
            set { m_strReturn = value; }
        }

        public string TestNo
        {
            get { return m_strTestNo; }
            set { m_strTestNo = value; }
        }


        private void frmLabApply_Load(object sender, EventArgs e)
        {
            dtApply.Value=EmrSysPubFunction.getServerNow();
            objDataSetDept = EMREditHisAdaperUse.getLabDeptDict();
            if (objDataSetDept.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = objDataSetDept.Tables[0];
                foreach (DataRow drCurrent in objTable.Rows)
                    cboDept.Items.Add(drCurrent["DEPT_NAME"].ToString());
            }



        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (cboSpeciman.Text.Length <= 0)
            {
                MessageBox.Show("请输入标本！");
                return;
            }

            //循环删除未选中的检验条目
            int i,nCount;
            nCount = lvItems.Items.Count;
            for (i = nCount - 1; i >= 0; i--)
            {
                ListViewItem objItem = lvItems.Items[i];
                if (!objItem.Checked)
                    lvItems.Items.Remove(objItem);
            }

            if (lvItems.Items.Count <= 0)
            {
                MessageBox.Show("请选择检验项目！");
                return;
            }

            DateTime dtRequestedDateTime;
            dtRequestedDateTime = dtApply.Value;
            int priority_indicator=0;
            if (cbxPriorityIndicator.Checked)
                priority_indicator = 1;

            string specimen, notes_for_spcm;
            notes_for_spcm = txtNotesForSpcm.Text;
            specimen = cboSpeciman.Text;

            //插入医嘱
            int no=0;
            string strSQL;
 /*         strSQL="select max(order_no)  from doctor_orders ";
            strSQL+=" where patient_id='"+EmrSysPubVar.getCurPatientID()+"' and ";
            strSQL+=" visit_id="+EmrSysPubVar.getCurPatientVisitID().ToString();
            object objReturn=DALUse.GetSingle(strSQL);
            if (objReturn!=null)
                no=Convert.ToInt32(objReturn.ToString())+1;

            int subno = 0;
            no = no+1;
            for (i = 0; i < lvOrders.Items.Count; i++)
            {
                ListViewItem objItem = lvOrders.Items[i];
                subno = subno + 1;
                strSQL = "INSERT INTO DOCTOR_ORDERS(patient_id,visit_id,order_no,order_sub_no,start_stop_indicator,";
                strSQL += "repeat_indicator,billing_attr,freq_counter,freq_interval,freq_interval_unit,order_status,";
                strSQL += "ordering_dept,order_text,order_class,start_date_time,doctor) values(";
                strSQL += "'" + EmrSysPubVar.getCurPatientID() + "',";
                strSQL += " " + EmrSysPubVar.getCurPatientVisitID().ToString() + ",";
                strSQL += " " + no.ToString() + ",";
                strSQL += " " + subno.ToString() + ",";
                strSQL += " 0,0,3,1,1,'日',1,";
                strSQL += " '" + EmrSysPubVar.getDeptCode() + "',";
                strSQL += " '" + objItem.SubItems[2].Text + "',";
                strSQL += " '" + objItem.SubItems[4].Text + "',";
                strSQL += " to_date('" + objItem.SubItems[1].Text + "','YYYY-MM-DD HH24:MI:SS'),";
                strSQL += " '" + EmrSysPubVar.getOperator() + "')";
                DALUse.ExecuteSql(strSQL);
            }
*/
            //插入检验主记录
            string strTestNo="";
            strTestNo=EmrSysPubFunction.getServerNow().ToString("yyMMddmmss");//临时用一下，正式要改成序列发生器
/*
            strSQL = "INSERT INTO  lab_test_master(test_no,PRIORITY_INDICATOR, patient_id, visit_id, name, sex, age, relevant_clinic_diag,";
            strSQL += " specimen,notes_for_spcm, requested_date_time, ordering_dept, ordering_provider, performed_by,charge_type,SUBJECT)";
		    strSQL += " VALUES(";
            strSQL += "'"+strTestNo+"',";
            strSQL += " "+priority_indicator.ToString()+",";
            strSQL += " '"+ EmrSysPubVar.getCurPatientID()+"',";
            strSQL += " "+ EmrSysPubVar.getCurPatientVisitID().ToString()+",";
            strSQL += " '"+ EmrSysPubVar.getCurPatientName()+"',";
            strSQL += " '"+ EmrSysPubVar.getCurPatientSex()+"',";
            strSQL += " 0,'',";
            strSQL += " '"+cboSpeciman.Text+"',";
            strSQL += " '"+txtNotesForSpcm.Text+"',";
            strSQL += " to_date('" + dtApply.Text + "','YYYY-MM-DD HH24:MI'),";
            strSQL += " '" + EmrSysPubVar.getDeptCode() + "',";
            strSQL += " '" + EmrSysPubVar.getOperator() + "',";
            DataRow drCurrent=objDataSetDept.Tables[0].Rows[cboDept.SelectedIndex];
            strSQL += " '" + drCurrent["PERFORMED_BY"].ToString() + "',";
            strSQL += " '" + EmrSysPubVar.getCurVisitChargeType() + "',";
            strSQL += " '" + cboSheet.Text + "')";
            DALUse.ExecuteSql(strSQL);
            */
            m_strReturn = cboSheet.Text+"(";
            //插入检验项目
            for (i = 1; i <= lvItems.Items.Count; i++)
            {
                ListViewItem objItem = lvItems.Items[i-1];
                strSQL = "INSERT INTO LAB_TEST_ITEMS(TEST_NO,ITEM_NO,ITEM_NAME,ITEM_CODE) values(";
                strSQL += "'"+strTestNo+"',";
                strSQL += " "+i.ToString()+",";
                strSQL += "'"+objItem.SubItems[0].Text+"',";
                strSQL += "'" + objItem.SubItems[1].Text + "')";
                //DALUse.ExecuteSql(strSQL);
                if (i > 1) m_strReturn += "、";
                m_strReturn += objItem.SubItems[0].Text;
            }
            m_strReturn += ")";

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDept.SelectedIndex < 0) return;
            cboSheet.Items.Clear();
            lvItems.Items.Clear();
            cboSpeciman.Items.Clear();

            //填充数据
            DataRow drCurrent=objDataSetDept.Tables[0].Rows[cboDept.SelectedIndex];
            objDataSetSheet = EMREditHisAdaperUse.getLabSheetMaster(drCurrent["PERFORMED_BY"].ToString());

            if (objDataSetSheet.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = objDataSetSheet.Tables[0];
                foreach (DataRow drCurrent1 in objTable.Rows)
                    cboSheet.Items.Add(drCurrent1["SHEET_TITLE"].ToString());
            }
            if (cboSheet.Items.Count > 0)
                cboSheet.SelectedIndex = 0;


            objDataSetSpeciman = EMREditHisAdaperUse.getLabSpecimanDict(drCurrent["PERFORMED_BY"].ToString());
            if (objDataSetSpeciman.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = objDataSetSpeciman.Tables[0];
                foreach (DataRow drCurrent1 in objTable.Rows)
                    cboSpeciman.Items.Add(drCurrent1["SPECIMAN_NAME"].ToString());
            }


        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSheet.SelectedIndex < 0) return;
            lvItems.Items.Clear();
            lvOrders.Items.Clear();

            //填充数据
            DataSet objDataSet = new DataSet();
            DataRow drCurrent = objDataSetSheet.Tables[0].Rows[cboSheet.SelectedIndex];
            objDataSet = EMREditHisAdaperUse.getLabSheetItems(drCurrent["LAB_SHEET_ID"].ToString());

            int i=0;
            if (objDataSet.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = objDataSet.Tables[0];
                foreach (DataRow drCurrent1 in objTable.Rows)
                {
                    string[] strItems1 = new string[2];
                    strItems1[0] = drCurrent1["LAB_ITEM_NAME"].ToString();
                    strItems1[1] = drCurrent1["LAB_ITEM_CODE"].ToString();

                    ListViewItem objItem1 = new ListViewItem(strItems1);
                    lvItems.Items.Add(objItem1);

                    lvItems.Items[i].Checked = true;
                    i++;
                }
            }

            string[] strItems = new string[5];
            strItems[0] = "检验";
            strItems[1] = dtApply.Text;
            strItems[2] = cboSheet.Text;
            strItems[3] = EmrSysPubVar.getOperator();
            strItems[4] = "C";

            ListViewItem objItem = new ListViewItem(strItems);
            lvOrders.Items.Add(objItem);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtOperate.Text.Length > 0)
            {
                string[] strItems = new string[5];
                strItems[0] = "操作";
                strItems[1] = dtApply.Text;
                strItems[2] = txtOperate.Text;
                strItems[3] = EmrSysPubVar.getOperator();
                strItems[4] = "E";

                ListViewItem objItem = new ListViewItem(strItems);
                lvOrders.Items.Add(objItem);
            }

        }
    }
}