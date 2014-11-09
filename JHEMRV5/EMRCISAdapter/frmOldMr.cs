using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysCom;
using System.Runtime.InteropServices;
using EmrSysWebservices;

namespace JHEMR.EMREdit
{
    public struct struct_HOSPITALINFO
    {
        public string strMR_PATH;
        public string strFILE_USER;
        public string strFILE_PWD;
        public string strIP_ADDR;
    }
    public partial class frmOldMr : Form
    {
        
        s_pat_info us_data = new s_pat_info();
        public struct_HOSPITALINFO m_s_hosinfo;
       
        string m_strPatientID="";
        public frmOldMr()
        {
            InitializeComponent();
        }

        public s_pat_info getPatientInfo()
        {
            return us_data;
        }


        public void setPatientID(string strPatientID)
        {
            m_strPatientID = strPatientID;

        }
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
            else if (strPatientID.Length <= 8)
            {
                str = strPatientID.Substring(strPatientID.Length - 2, 2);
                str2 = strPatientID.Substring(0, strPatientID.Length - 2);
            }
            else
            {
                str = strPatientID.Substring(strPatientID.Length - 4, 4);
                str2 = strPatientID.Substring(0, strPatientID.Length - 4);
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
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tvMrCatalog.SelectedNode == null)
                return;
            ////要取叶子节点
            //if ((tvMrCatalog.SelectedNode.ImageIndex == 0 || tvMrCatalog.SelectedNode.ImageIndex == 1))
            //{
            //mr_file_info s_data;
            //s_data = (mr_file_info)tvMrCatalog.SelectedNode.Tag;
            //通过接口取得his的ip
            string strPatientID = this.genMrPath(EmrSysPubVar.getCurPatientID());
            string str4 = m_s_hosinfo.strMR_PATH +"\\"+ strPatientID + tvMrCatalog.SelectedNode.Name.ToString();//************************* _info.mr_path + strPatientID + str;
            string ip = m_s_hosinfo.strIP_ADDR;
            string str3 = EmrSysPubVar.getTempFileFullName();
            //取得文件
            if (get_file(ip, str4, str3, 1) == 0)
            {
                Word.Document wDoc = null;
                Word.Application wApp = null;
                CreateWordDocument(EmrSysPubVar.getTempFileFullName(), ref wDoc, ref wApp);
            }
            tvMrCatalog.Focus();
            //}

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region 打开Word文档,并且返回对象wDoc,wDoc
        /// 
        /// 打开Word文档,并且返回对象wDoc,wDoc
        /// 
        /// 完整Word文件路径+名称 
        /// 返回的Word.Document wDoc对象
        /// 返回的Word.Application对象
        //public static void CreateWordDocument(string FileName, ref Word.Document wDoc, ref Word.Application WApp)
        //{
        //    if (FileName == "") return;
        //    Word.Document thisDocument = null;
        //    Word.FormFields formFields = null;
        //    Word.Application thisApplication = new Word.ApplicationClass();
        //    thisApplication.Visible = true;
        //    thisApplication.Caption = "";
        //    thisApplication.Options.CheckSpellingAsYouType = false;
        //    thisApplication.Options.CheckGrammarAsYouType = false;

        //    Object filename = FileName;
        //    Object ConfirmConversions = false;
        //    Object ReadOnly = true;
        //    Object AddToRecentFiles = false;

        //    Object PasswordDocument = System.Type.Missing;
        //    Object PasswordTemplate = System.Type.Missing;
        //    Object Revert = System.Type.Missing;
        //    Object WritePasswordDocument = System.Type.Missing;
        //    Object WritePasswordTemplate = System.Type.Missing;
        //    Object Format = System.Type.Missing;
        //    Object Encoding = System.Type.Missing;
        //    Object Visible = System.Type.Missing;
        //    Object OpenAndRepair = System.Type.Missing;
        //    Object DocumentDirection = System.Type.Missing;
        //    Object NoEncodingDialog = System.Type.Missing;
        //    Object XMLTransform = System.Type.Missing;

        //    try
        //    {
        //        Word.Document wordDoc =
        //        thisApplication.Documents.Open(ref filename, ref ConfirmConversions,
        //        ref ReadOnly, ref AddToRecentFiles, ref PasswordDocument, ref PasswordTemplate,
        //        ref Revert, ref WritePasswordDocument, ref WritePasswordTemplate, ref Format,
        //        ref Encoding, ref Visible, ref OpenAndRepair, ref DocumentDirection,
        //        ref NoEncodingDialog, ref XMLTransform);

        //        thisDocument = wordDoc;
        //        wDoc = wordDoc;
        //        WApp = thisApplication;
        //        formFields = wordDoc.FormFields;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        #endregion

        private void tvMrCatalog_DoubleClick(object sender, EventArgs e)
        {
            btnOK_Click(btnOK, new EventArgs());
        }
        public static int fillTreeEmrCatalog(ref TreeView tree, ref TreeNode parentTreeNode, string strParentcode, string strPatientID, int nVisitID)
        {
            //DataSet objDataset = new DataSet();
            ////从接口取得
            ////objDataset = EMRViewDAL.getEmrCatalog(strParentcode);
            //DataTable objTable;
            //objTable = objDataset.Tables[0];
            //foreach (DataRow drCurrent in objTable.Rows)
            //{
            //    string strTemp;
            //    s_emr_catalog s_data = new s_emr_catalog();
            //    s_data.catalog_code = drCurrent["CATALOG_CODE"].ToString();
            //    s_data.catalog_name = drCurrent["CATALOG_NAME"].ToString();
            //    s_data.catalog_type = drCurrent["CATALOG_TYPE"].ToString();
            //    s_data.WRITABLE_FLAG = Convert.ToInt32(drCurrent["WRITABLE_FLAG"].ToString());
            //    strTemp = drCurrent["IMAGEINDEX"].ToString();
            //    s_data.imageindex = Convert.ToInt32(strTemp);
            //    strTemp = drCurrent["SELECTEDIMAGEINDEX"].ToString();
            //    s_data.selectedimageindex = Convert.ToInt32(strTemp);

            //    TreeNode TreeNode_New = new TreeNode();
            //    TreeNode_New.Text = s_data.catalog_name;
            //    TreeNode_New.Name = s_data.catalog_name;
            //    TreeNode_New.Tag = s_data;
            //    TreeNode_New.ImageIndex = s_data.imageindex;
            //    TreeNode_New.SelectedImageIndex = s_data.selectedimageindex;

            //    int nIndex = -1;
            //    if (parentTreeNode == null)
            //        nIndex = tree.Nodes.Add(TreeNode_New);
            //    else
            //        nIndex = parentTreeNode.Nodes.Add(TreeNode_New);
            //    if (s_data.catalog_type == "2")
            //    {
            //        //fillTreeMrFile(ref TreeNode_New, -1, strPatientID, nVisitID);
            //    }
            //    else
            //        fillTreeEmrCatalog(ref tree, ref TreeNode_New, s_data.catalog_code, strPatientID, nVisitID);
            //}
            return 0;
        }

        private void frmOldMr_Load(object sender, EventArgs e)
        {
            this.Close();
            return;
            dgvPatientVisits.RegisterExistHeaderColumn();
            m_strPatientID = EmrSysCom.EmrSysPubVar.getCurPatientID();
            DataSet dsHosInfo = new DataSet();
            try
            {
                dsHosInfo = EmrSysWebservicesUse.myEmrGetGeneralSQL(m_strPatientID, "1");  //Type 2 获取医院ＨＩＳ信息
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            if (dsHosInfo.Tables.Count > 0)
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
            if (dsPatVisit.Tables.Count > 0)
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

        private void dgvPatientVisits_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvPatientVisits.SelectedRows.Count<1)
                return;
            DataGridViewRow dgvr=dgvPatientVisits.SelectedRows[0];
            string strVisitId = dgvr.Cells["visit_id"].Value.ToString();
            tvMrCatalog.Nodes.Clear();
            DataSet dsMr = new DataSet();
            dsMr = EmrSysWebservicesUse.myEmrGetGeneralSQL(m_strPatientID+"@"+strVisitId, "3");  //Type 3 获取患者病历信息            
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
                        tvMrCatalog.Nodes.Add(TreeNode_New);
                    }
                    if (tvMrCatalog.Nodes.Count > 0)
                        tvMrCatalog.Focus();
                }
            }
        }

    }
}