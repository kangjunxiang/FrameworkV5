using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace JHEMR.EMREdit
{
    public partial class frmMedcomExam : Form
    {
        [DllImport("HisBrowser", SetLastError = true)]
        static extern void MdcClose();
        [DllImport("HisBrowser", SetLastError = true)]
        static extern void MdcSetFileServer(string sFileServer);
        [DllImport("HisBrowser", SetLastError = true)]
        static extern void MdcSetFileServerPath(string sFileServerPath);

        //连接服务器
        [DllImport("HisBrowser", SetLastError = true)]
        static extern int MdcConnect(string sServer, string sDatabase); //

        //获取复诊号
        [DllImport("HisBrowser", SetLastError = true)]
        static extern bool MdcGetRecheckCode(string sHisID, [Out, MarshalAs(UnmanagedType.LPArray)]char[] sReCheckCodeList, int nBufSize); //

        //获取字段值
        [DllImport("HisBrowser", SetLastError = true)]
        static extern bool MdcGetFieldValue(string sRecheckCode, string FieldName, [Out, MarshalAs(UnmanagedType.LPArray)]char[] strBuff, int nBufSize);//

        //获取图像
        [DllImport("HisBrowser", SetLastError = true)]
        static extern int MdcGetImages(string strReCheckCode, string sLocalDirectory); //


        [DllImport("HisBrowser", SetLastError = true)]
        static extern int MdcShowImages(string strReCheckCode);

        //获取字段数量
        [DllImport("HisBrowser", SetLastError = true)]
        static extern int MdcGetFieldCount();

        //获取字段名称
        [DllImport("HisBrowser", SetLastError = true)]
        static extern bool MdcGetFieldName(long nIndex, [Out, MarshalAs(UnmanagedType.LPArray)]char[] strBuff, int nBufSize);//


        private string m_CurPatientID;
        private int m_CurVisitID;
        private DataSet m_dsSetting = new DataSet();
        private string m_strServer="";
        private string m_strServerPath="";
        private string m_strDatabase="";
        private string m_strFieldName = "超声所见";
        private string m_strExeFile = "";

        public frmMedcomExam()
        {
            InitializeComponent();
        }

        public bool setPatient(string strPatientID, int intVisitID,string strClassName)
        {
            m_CurPatientID = strPatientID;
            m_CurVisitID = intVisitID;
            m_dsSetting.ReadXml(Application.StartupPath + "\\CISAdapterConfig.xml");
            if (m_dsSetting.Tables.Count > 0)
            {
                DataTable dt = m_dsSetting.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    TreeNode TreeNode_New = new TreeNode();
                    TreeNode_New.Text = dr["CLASSNAME"].ToString();
                    TreeNode_New.Tag = dr["CLASSNAME"].ToString();
                    tvRecheckCode.Nodes.Add(TreeNode_New);

                    /*
                    if (dr["CLASSNAME"].ToString().IndexOf(strClassName) >= 0)
                    {
                        m_strServer = dr["SERVER"].ToString();
                        m_strServerPath = dr["SERVERPATH"].ToString();
                        m_strDatabase = dr["DATABASE"].ToString();
                        m_strFieldName = dr["FIELDNAME"].ToString();
                        m_strExeFile = dr["EXEFILE"].ToString();
                    }
                    */
                }
            }

            //if (m_strServer.Length == 0)
            //    return false;

            return true;// DataLoad();
        }

        private void frmMedcomExam_Load(object sender, EventArgs e)
        {


        }

        private bool DataLoad()
        {
            try
            {
                MdcSetFileServer(m_strServer);
                MdcSetFileServerPath(m_strServerPath);
                int nResult = MdcConnect(m_strServer, m_strDatabase);
                char[] sReCheckCodeList = new char[256];
                MdcGetRecheckCode(m_CurPatientID, sReCheckCodeList, 256); //"000265688600"
                String s = new string(sReCheckCodeList);
                string[] strItems = s.Split(new Char[] { ',' });
                if (strItems != null)
                {
                    lbRecheckCode.Items.AddRange(strItems);
                }
                MdcClose();
                if (lbRecheckCode.Items.Count == 0)
                    return false;
            }
            catch (System.Exception E)
            {
                return false;
            }
            return true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbRecheckCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbRecheckCode.SelectedIndex > -1)
            {
                MdcSetFileServer(m_strServer);
                MdcSetFileServerPath(m_strServerPath);
                int nResult = MdcConnect(m_strServer, m_strDatabase);

                char[] strbuf = new char[1024];
                MdcGetFieldValue(lbRecheckCode.Text, m_strFieldName, strbuf, 1024);
                String s = new string(strbuf);
                txtResult.Text = s;
                MdcClose();
            }

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            if (lbRecheckCode.SelectedIndex > -1)
            {
                MdcSetFileServer(m_strServer);
                MdcSetFileServerPath(m_strServerPath);
                int nResult = MdcConnect(m_strServer, m_strDatabase);
                Directory.CreateDirectory(Application.StartupPath + "\\MEDCOM");
                MdcGetImages(lbRecheckCode.Text, Application.StartupPath + "\\MEDCOM");
                MdcShowImages(lbRecheckCode.Text);
            }
        }

        private void frmMedcomExam_FormClosed(object sender, FormClosedEventArgs e)
        {
            MdcClose();
        }
    }
}