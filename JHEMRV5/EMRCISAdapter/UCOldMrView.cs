using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EmrSysWebservices;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysUserCtl;
using System.Runtime.InteropServices;

namespace EMRCISAdapter
{
    public struct struct_HOSPITALINFO
    {
        public string strMR_PATH;
        public string strFILE_USER;
        public string strFILE_PWD;
        public string strIP_ADDR;
    }
    public partial class UCOldMrView : UserControl
    {
        private string m_strPatientID;
        private DataTable objTablezy_bl_patient_record=new DataTable();
        private UCEMRPad30 m_objPad=null;
        private string m_strTmp = "tmpDoc";
        s_pat_info us_data = new s_pat_info();
        public struct_HOSPITALINFO m_s_hosinfo;
        [DllImport("FSRV.DLL")]
        public static extern int get_file(string host_addr, string remote_file, string local_file, int option);
        private string genMrPath(string strPatientID)
        {
            string str;
            string str2;
            if (strPatientID.Length < 2)
            {
                str = strPatientID;
                str2 = "";
            }
            //else if (strPatientID.Length <= 8)
            //{
            //    str = strPatientID.Substring(strPatientID.Length - 2, 2);
            //    str2 = strPatientID.Substring(0, strPatientID.Length - 2);
            //}
            else
            {
                str = strPatientID.Substring(strPatientID.Length - 2, 2);
                str2 = strPatientID.Substring(0, strPatientID.Length - 2);
            }
            if (str.Length == 1)
            {
                str = "0" + str;
            }
            str = str + @"\";
            string str3 = "00000000000000";
            if (str2.Length <= 8)
            {
                str2 = str3.Substring(0, 8 - str2.Length) + str2;
            }
            else
            {
                str2 = str3.Substring(0, 12 - str2.Length) + str2;
            }
            return (str + str2 + @"\");
        }
        public UCOldMrView()
        {
            InitializeComponent();
            dgvPatientVisits.RegisterExistHeaderColumn();
        }

        public void SetPatientInfo(string strPatientID)
        {
            m_strPatientID = strPatientID;

            FillPatVists();
        }

        public void setParentPad(UCEMRPad30 objPad)
        {
            m_objPad = objPad;
        }

        private void FillRecordType()
        {
            string[] aryField = new string[1];
            aryField[0] = "zy_bl_record_type";
            DataSet objDataset;
            objDataset = EmrSysWebservicesUse.myEmrGenralDataSet(aryField);
            if (objDataset!=null && objDataset.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = objDataset.Tables[0];
                foreach (DataRow drCurrent in objTable.Rows)
                {
                    TreeNode TreeNode_New = new TreeNode();
                    TreeNode_New.Text = drCurrent["TYPE_NAME"].ToString();
                    TreeNode_New.Name =drCurrent["TYPE_CODE"].ToString();
                    TreeNode_New.Tag = drCurrent["TYPE_CODE"].ToString();
                    tvTypes.Nodes.Add(TreeNode_New);
                }
            }
        }

        //处理既往入院信息
        private void FillPatVists()
        {
            //string[] aryField = new string[2];
            //aryField[0] = "zy_inactpatient";
            //aryField[1] = m_strPatientID;
            //DataSet objDataset;
            //objDataset = EmrSysWebservicesUse.myEmrGenralDataSet(aryField);
            //if (objDataset.Tables.Count > 0)
            //    dgvPatientVisits.DataSource = objDataset.Tables[0].DefaultView;
            DataSet dsHosInfo = new DataSet();
            try
            {
                dsHosInfo = EmrSysWebservicesUse.myEmrGetGeneralSQL(m_strPatientID, "1");  //Type 2 获取医院ＨＩＳ信息
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            if (dsHosInfo != null && dsHosInfo.Tables.Count > 0)
            {
                if (dsHosInfo.Tables[0].Rows.Count > 0)
                {
                    m_s_hosinfo.strIP_ADDR = dsHosInfo.Tables[0].Rows[0]["ip_addr"].ToString();
                    m_s_hosinfo.strMR_PATH = dsHosInfo.Tables[0].Rows[0]["mr_path"].ToString();
                    m_s_hosinfo.strFILE_USER = dsHosInfo.Tables[0].Rows[0]["file_user"].ToString();
                    m_s_hosinfo.strFILE_PWD = dsHosInfo.Tables[0].Rows[0]["file_pwd"].ToString();
                }
            }
            DataTable objTable = new DataTable();
            DataSet dsPatVisit = new DataSet();
            dsPatVisit = EmrSysWebservicesUse.myEmrGetGeneralSQL(m_strPatientID, "2");  //Type 2 获取患者住院信息
            if (dsPatVisit!=null && dsPatVisit.Tables.Count > 0)
            {
                if (dsPatVisit.Tables[0].Rows.Count > 0)
                {
                    objTable = dsPatVisit.Tables[0];
                }
            }
            //从接口取得pat_visit
            //objTable = EMRViewDAL.getPatientVisits(m_strPatientID);
            dgvPatientVisits.DataSource = objTable.DefaultView;
        }

        private void dgvPatientVisits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tvTypes_DoubleClick(object sender, EventArgs e)
        {
            
            if (tvTypes.SelectedNode == null)
                return;
            axFWord.Close();            

            ////要取叶子节点
            //if ((tvMrCatalog.SelectedNode.ImageIndex == 0 || tvMrCatalog.SelectedNode.ImageIndex == 1))
            //{
            //mr_file_info s_data;
            //s_data = (mr_file_info)tvMrCatalog.SelectedNode.Tag;
            //通过接口取得his的ip
            string strPatientID = this.genMrPath(m_strPatientID);
            string str4 = m_s_hosinfo.strMR_PATH + "\\" + strPatientID + tvTypes.SelectedNode.Name.ToString();//************************* _info.mr_path + strPatientID + str;
            string ip = m_s_hosinfo.strIP_ADDR;
            string str3 = EmrSysPubVar.getTempFileFullName()+"1";
            //取得文件
            if (get_file(ip, str4, str3, 1) == 0)
            {
                axFWord.Open(EmrSysPubVar.getTempFileFullName() + "1");
                //Word.Document wDoc = null;
                //Word.Application wApp = null;
                //CreateWordDocument(EmrSysPubVar.getTempFileFullName(), ref wDoc, ref wApp);
            }
            //tvMrCatalog.Focus();
            //}
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (m_objPad != null)
            {
                //txtForChange.Text = rtbpatientRecord.SelectedText;
                //if (txtForChange.Text.Length == 0)
                //    txtForChange.Text = rtbpatientRecord.Text;
                string strForCopy = txtForChange.Text;
                strForCopy = strForCopy.Replace("\r", "");
                strForCopy = strForCopy.Replace("\n", "");

                Clipboard.SetDataObject(strForCopy, false);//
                m_objPad.PadSetPasteMode(2); //设置为粘贴文本格式		
                m_objPad.PadEditPaste();
                m_objPad.PadSetPasteMode(1); //设置为粘贴病历格式	
            }

        }

        private void dgvPatientVisits_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgvPatientVisits.SelectedRows.Count > 0)
            //{
            //    s_pat_info us_data = new s_pat_info();
            //    DataGridViewRow objCurRow = dgvPatientVisits.SelectedRows[0];
            //    if (EmrSysPubFunction.fillPatientInfo(m_strPatientID, Convert.ToInt32(objCurRow.Cells["visit_id"].Value.ToString()), ref us_data))
            //    {
            //        tvTypes.Nodes.Clear();

            //        string[] aryField = new string[3];
            //        aryField[0] = "zy_bl_patient_record";
            //        aryField[1] = us_data.patient_id;
            //        aryField[2] = us_data.visit_id.ToString();
            //        DataSet objDataset;
            //        objDataset = EmrSysWebservicesUse.myEmrGenralDataSet(aryField);
            //        if (objDataset.Tables.Count > 0)
            //        {
            //            FillRecordType();
            //            //循环填充病历

            //            objTablezy_bl_patient_record = objDataset.Tables[0];
            //            foreach (DataRow drCurrent in objTablezy_bl_patient_record.Rows)
            //            {
            //                TreeNode TreeNode_New = new TreeNode();
            //                TreeNode_New.Text = drCurrent["create_time"].ToString();
            //                TreeNode_New.Tag = drCurrent["record_serial"].ToString();
            //                TreeNode[] findTreeNodes = tvTypes.Nodes.Find(drCurrent["record_type"].ToString(), false);
            //                if (findTreeNodes.Length > 0)
            //                {
            //                    findTreeNodes[0].Nodes.Add(TreeNode_New);
            //                }
            //            }

            //            this.Text = us_data.name + "(" + us_data.patient_id + ")第" + us_data.visit_id.ToString() + "次住院病历浏览";
            //        }
            //    }
            //    else
            //        MessageBox.Show("提取患者信息错误!");
            //}
            if (dgvPatientVisits.SelectedRows.Count < 1)
                return;
            DataGridViewRow dgvr = dgvPatientVisits.SelectedRows[0];
            string strVisitId = dgvr.Cells["visit_id"].Value.ToString();
            tvTypes.Nodes.Clear();
            DataSet dsMr = new DataSet();
            dsMr = EmrSysWebservicesUse.myEmrGetGeneralSQL(m_strPatientID + "@" + strVisitId, "3");  //Type 3 获取患者病历信息            
            if (dsMr != null)
            {
                if (dsMr.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in dsMr.Tables[0].Rows)
                    {
                        TreeNode TreeNode_New = new TreeNode();
                        TreeNode_New.Text = dr["topic"].ToString();
                        TreeNode_New.Name = dr["file_name"].ToString();
                        TreeNode_New.Tag = dr["file_no"].ToString();
                        TreeNode_New.ImageIndex = 0;
                        TreeNode_New.SelectedImageIndex = 0;
                        tvTypes.Nodes.Add(TreeNode_New);
                    }
                    if (tvTypes.Nodes.Count > 0)
                        tvTypes.Focus();
                }
            }

        }

        private void tvTypes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvTypes.SelectedNode == null)
                return;
            if (tvTypes.SelectedNode.Level == 1)
            {
                string strrecord_serial;
                strrecord_serial = tvTypes.SelectedNode.Tag.ToString();
                foreach (DataRow drCurrent in objTablezy_bl_patient_record.Rows)
                {
                    if (drCurrent["record_serial"].ToString().Equals(strrecord_serial))
                    {
                        string strpatientRecord;
                        strpatientRecord = drCurrent["patient_record"].ToString();
                       // rtbpatientRecord.Rtf = strpatientRecord;

                    }
                }
            }

        }

        private void axFWord_OnFileCommand(object sender, AxDSOFramer._DFramerCtlEvents_OnFileCommandEvent e)
        {

        }


    }
}
