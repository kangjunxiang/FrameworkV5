using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysAdaper;

namespace JHEMR.EMRHisCustom
{
    public partial class frmPrint : Form
    {
        public frmPrint()
        {
            InitializeComponent();
        }
        private void frmPrint_Load(object sender, EventArgs e)
        {
        }
        public bool PrintLabExam(string strFileName, DataTable dtInfo, DataTable dtReplace)
        {
            bool result;
            if (!EMRArchiveAdaperUse.retrieveEmrFile(new object[]
			{
				1,
				strFileName,
				"首页"
			}))
            {
                MessageBox.Show("模板文件未挂接!");
                result = false;
            }
            else
            {
                this.ucemrPad301.PadSetDocumentMode(1);
                this.ucemrPad301.PadCleanPadDocumentMircoFieldElemValue();
                if (dtInfo != null)
                {
                    foreach (DataRow dataRow in dtInfo.Rows)
                    {
                        this.ucemrPad301.PadSetMicroField(dataRow[0].ToString(), dataRow[1].ToString());
                    }
                    this.ucemrPad301.PadUpdateMicroField(true);
                }
                if (!this.ucemrPad301.PadOpenFile(EmrSysPubVar.getTempFileFullName()))
                {
                    MessageBox.Show("模板出错!");
                    result = false;
                }
                else
                {
                    if (dtReplace != null)
                    {
                        foreach (DataRow dataRow2 in dtReplace.Rows)
                        {
                            this.ucemrPad301.PadEditReplaceInternal(dataRow2[0].ToString(), dataRow2[1].ToString(), 1);
                        }
                    }
                    this.ucemrPad301.PadSetDocumentMode(2);
                    this.ucemrPad301.PadPrint(3);
                    result = true;
                }
            }
            return result;
        }
        public bool PrintOperation(string strFileName, DataTable dtInfo, DataTable dtReplace)
        {
            bool result;
            if (!EMRArchiveAdaperUse.retrieveEmrFile(new object[]
			{
				1,
				strFileName,
				"首页"
			}))
            {
                MessageBox.Show("模板文件未挂接!");
                result = false;
            }
            else
            {
                this.ucemrPad301.PadSetDocumentMode(1);
                this.ucemrPad301.PadCleanPadDocumentMircoFieldElemValue();
                if (dtInfo != null)
                {
                    foreach (DataRow dataRow in dtInfo.Rows)
                    {
                        this.ucemrPad301.PadSetMicroField(dataRow[0].ToString(), dataRow[1].ToString());
                    }
                    this.ucemrPad301.PadUpdateMicroField(true);
                }
                if (!this.ucemrPad301.PadOpenFile(EmrSysPubVar.getTempFileFullName()))
                {
                    MessageBox.Show("模板出错!");
                    result = false;
                }
                else
                {
                    if (dtReplace != null)
                    {
                        int num = 1;
                        if (!this.ucemrPad301.PadFindField("统计数据", 1, 2, true))
                        {
                            result = false;
                            return result;
                        }
                        this.ucemrPad301.PadSetDocumentMode(1);
                        this.ucemrPad301.PadFindField("统计数据", 1, 2, true);
                        int num2 = -1;
                        int nCellIndex = -1;
                        int nLineIndex = -1;
                        int num3 = -1;
                        int num4 = -1;
                        this.ucemrPad301.PadGetCurCursorPos(ref num2, ref nCellIndex, ref nLineIndex, ref num3, ref num4, true);
                        int num5 = 0;
                        int num6 = 0;
                        int num7 = 0;
                        num5 = this.ucemrPad301.PadGetObjectCount(num2, nCellIndex, nLineIndex, 2);
                        num6 = this.ucemrPad301.PadGetObjectCount(num2, nCellIndex, nLineIndex, 3);
                        int num8 = this.ucemrPad301.PadGetObjectCount(num2, nCellIndex, nLineIndex, 1);
                        num7 = num5 * num6 - num8;
                        if (dtReplace.Rows.Count > 1)
                        {
                            this.ucemrPad301.PadInsertNewRowCloneLastRowByBatch(-1, dtReplace.Rows.Count - 1);
                        }
                        foreach (DataRow dataRow2 in dtReplace.Rows)
                        {
                            object[] itemArray = dataRow2.ItemArray;
                            for (int i = 0; i < itemArray.Length; i++)
                            {
                                this.ucemrPad301.PadSetSel(num2, (num5 - 1) * num6 + i - num7, 0, 0, 0, num2, (num5 - 1) * num6 + i - num7, 0, 0, 0);
                                object obj = itemArray[i];
                                if (obj != null)
                                {
                                    try
                                    {
                                        this.ucemrPad301.PadInsertText(obj.ToString());
                                        this.ucemrPad301.PadCleanUndoBuffer();
                                    }
                                    catch (Exception ex)
                                    {
                                        ex.ToString();
                                    }
                                }
                            }
                            num5++;
                            num++;
                        }
                    }
                    this.ucemrPad301.PadSetDocumentMode(2);
                    this.ucemrPad301.PadCleanUndoBuffer();
                    this.ucemrPad301.PadPrint(3);
                    result = true;
                }
            }
            return result;
        }
		
    }
}