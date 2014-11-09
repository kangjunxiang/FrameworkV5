using EmrSysWebservices;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;
using System;
using System.Collections.Generic;
using System.Data;
namespace JHEMR.MRFirstPagesBJ
{
	public class MRFirstPageDAL
	{
		public DataSet m_dsPatientMasterIndex = new DataSet();
		public DataSet m_dsPatientVisit = new DataSet();
		public DataSet m_dsDiagnosis = new DataSet();
		public DataTable m_dtDiagnosisTypeDict = new DataTable();
		public DataSet m_dsDiagComparing = new DataSet();
		public DataSet m_dsOperation = new DataSet();
		public DataSet m_dsBloodTransfusion = new DataSet();
		public DataTable m_dtMrFeeClassDict = new DataTable();
		public DataSet m_dsMedicalCosts = new DataSet();
		public DataSet m_dsPatientVisitBaby = new DataSet();
		public DataSet m_dsPatientTumour = new DataSet();
		public DataSet m_dsPatientTumourDetail = new DataSet();
		public DataSet m_dsEMRFirstPageItemDict = new DataSet();
		public DataSet m_dsAdtLog = new DataSet();
		public DataSet m_dsMoniterPatient = new DataSet();
		public DataSet m_dsDoctor = new DataSet();
		public DataTable m_dsCataloger = new DataTable();
		public DataSet m_dsDeptCode = new DataSet();
		public DataSet m_dsGraveWard = new DataSet();
		public DataSet m_dsGraveWardRecond = new DataSet();
		public DataSet m_dsCMFirstPageData = new DataSet();
		public DataSet m_dsCMFirstPageNeonateData = new DataSet();
		public DataSet m_dsFuYe = new DataSet();
		public void fillPatientFirstPageData(string strPatientID, int nVisitID)
		{
			this.getPatientMasterIndex(strPatientID);
			this.getPatientVisit(strPatientID, nVisitID);
			this.getDiagnosis(strPatientID, nVisitID);
			this.getDiagnosisTypeDict();
			this.getDiagComparing(strPatientID, nVisitID);
			this.getOperation(strPatientID, nVisitID);
			this.getBloodTransfusion(strPatientID, nVisitID);
			this.getMrFeeClassDict();
			this.getMedicalCosts(strPatientID, nVisitID);
			this.getdsEMRFirstPageItemDict();
			this.getPatientVisitBaby(strPatientID, nVisitID);
			this.getPatientTumour(strPatientID, nVisitID);
			this.getPatientTumourDetail(strPatientID, nVisitID);
			this.getAdtLog(strPatientID, nVisitID);
			this.getMoniterPatient(strPatientID, nVisitID);
			this.getFuYe(strPatientID, nVisitID);
			this.getCMFirstPageInfo(strPatientID, nVisitID);
		}
		public DataSet getEMRFirstPageItemDict()
		{
			return this.m_dsEMRFirstPageItemDict;
		}
		private void getFuYe(string strPatientID, int nVisitID)
		{
			string sQLString = "SELECT * FROM EMR_FUYE WHERE PATIENT_ID='" + strPatientID + "' AND VISIT_ID=" + nVisitID.ToString();
			this.m_dsFuYe = DALUse.Query(sQLString);
		}
		private void getGrave_Ward(string strPatientID, int nVisitID)
		{
			DataSet dataSet = new DataSet();
			string sQLString = "SELECT * FROM PAT_VISIT WHERE PATIENT_ID='" + strPatientID + "' AND VISIT_ID=" + nVisitID.ToString();
			dataSet = DALUse.Query(sQLString);
			if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
			{
				if (dataSet.Tables[0].Rows[0]["DISCHARGE_DATE_TIME"].ToString().Trim() != "")
				{
					object[] list = new object[]
					{
						"ICURecord",
						strPatientID,
						nVisitID.ToString()
					};
					this.m_dsGraveWardRecond = EmrSysWebservicesUse.myEmrGenralDataSet(list);
				}
			}
			try
			{
				if (this.m_dsGraveWardRecond.IsInitialized)
				{
					if (this.m_dsGraveWardRecond.Tables.Count == 1)
					{
						if (this.m_dsGraveWardRecond.Tables[0].Rows.Count > 0)
						{
							bool flag = false;
							string text = string.Empty;
							string text2 = "";
							List<string> list2 = new List<string>();
							foreach (DataRow dataRow in this.m_dsGraveWardRecond.Tables[0].Rows)
							{
								if (dataRow["action"].ToString().Trim() == "C" || dataRow["action"].ToString().Trim() == "D")
								{
									text = dataRow["log_date_time"].ToString().Trim();
									flag = true;
									text2 = dataRow["ward_name"].ToString().Trim();
								}
								else
								{
									if (dataRow["action"].ToString().Trim() == "E" || dataRow["action"].ToString().Trim() == "F" || dataRow["action"].ToString().Trim() == "G" || dataRow["action"].ToString().Trim() == "H")
									{
										string text3 = string.Empty;
										text3 = dataRow["log_date_time"].ToString().Trim();
										if (flag)
										{
											list2.Add(string.Concat(new object[]
											{
												"insert into GRAVE_WARD_DETAIL (patient_id, visit_id, inp_no, ward_name, enter_time, exit_time) values ('",
												dataRow["patient_id"].ToString().Trim(),
												"', ",
												Convert.ToInt32(dataRow["visit_id"].ToString().Trim()),
												", '",
												dataRow["patient_id"].ToString().Trim(),
												"', '",
												dataRow["ward_name"].ToString().Trim(),
												"', to_date('",
												text,
												"','YYYY-MM-DD  HH24:MI:SS'), to_date('",
												text3,
												"','YYYY-MM-DD  HH24:MI:SS'))"
											}));
										}
										else
										{
											list2.Add(string.Concat(new object[]
											{
												"insert into GRAVE_WARD_DETAIL (patient_id, visit_id, inp_no, ward_name, enter_time, exit_time) values ('",
												dataRow["patient_id"].ToString().Trim(),
												"', ",
												Convert.ToInt32(dataRow["visit_id"].ToString().Trim()),
												", '",
												dataRow["patient_id"].ToString().Trim(),
												"', '",
												dataRow["ward_name"].ToString().Trim(),
												"', null, to_date('",
												text3,
												"','YYYY-MM-DD  HH24:MI:SS'))"
											}));
										}
										flag = false;
									}
								}
							}
							if (flag)
							{
								list2.Add(string.Concat(new object[]
								{
									"insert into GRAVE_WARD_DETAIL (patient_id, visit_id, inp_no, ward_name, enter_time, exit_time) values ('",
									strPatientID,
									"', ",
									nVisitID,
									", '",
									strPatientID,
									"', '",
									text2,
									"', to_date('",
									text,
									"','YYYY-MM-DD  HH24:MI:SS'), null)"
								}));
							}
							bool flag2 = DALUse.ExecuteSqlTran(list2.ToArray());
						}
					}
				}
			}
			catch (Exception var_10_52E)
			{
			}
			string sQLString2 = string.Concat(new object[]
			{
				"select * from GRAVE_WARD_DETAIL t where t.patient_id='",
				strPatientID,
				"' and visit_id=",
				nVisitID,
				" AND INP_NO='",
				EmrSysPubVar.getCurPatientInpNo(),
				"'"
			});
			this.m_dsGraveWard = DALUse.Query(sQLString2);
			string sQLString3 = string.Concat(new object[]
			{
				"delete GRAVE_WARD_DETAIL t where t.patient_id='",
				strPatientID,
				"' and visit_id=",
				nVisitID,
				" AND INP_NO='",
				EmrSysPubVar.getCurPatientInpNo(),
				"'"
			});
			int num = DALUse.ExecuteSql(sQLString3);
		}
		private void getPatientMasterIndex(string strPatientID)
		{
			string sQLString = "SELECT * FROM PAT_MASTER_INDEX WHERE PATIENT_ID='" + strPatientID + "'";
			this.m_dsPatientMasterIndex = DALUse.Query(sQLString);
		}
		private void getPatientVisit(string strPatientID, int nVisitID)
		{
			DataSet dataSet = new DataSet();
			object[] list = new object[]
			{
				"RESPIRATOR_USE_TIME",
				strPatientID,
				nVisitID.ToString()
			};
			dataSet = EmrSysWebservicesUse.myEmrGenralDataSet(list);
			if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0 && dataSet.Tables[0].Rows[0][0].ToString().Trim() != "")
			{
				decimal num = Convert.ToDecimal(dataSet.Tables[0].Rows[0][0].ToString().Trim());
				string sQLString = string.Concat(new object[]
				{
					"update  PAT_VISIT set respirator_use_time = ",
					num,
					" WHERE PATIENT_ID='",
					strPatientID,
					"' AND VISIT_ID=",
					nVisitID.ToString()
				});
				int num2 = DALUse.ExecuteSql(sQLString);
			}
			string sQLString2 = "SELECT * FROM PAT_VISIT WHERE PATIENT_ID='" + strPatientID + "' AND VISIT_ID=" + nVisitID.ToString();
			this.m_dsPatientVisit = DALUse.Query(sQLString2);
		}
		private void getDiagnosis(string strPatientID, int nVisitID)
		{
			string text = "SELECT PATIENT_ID,VISIT_ID,DIAGNOSIS_TYPE,DIAGNOSIS_NO,'' as diagnosis_type_name,DIAGNOSIS_DESC,DIAGNOSIS_DESC_PART,'' as code1,'' as code2,TREAT_DAYS,OPER_TREAT_INDICATOR,ADMISSION_CONDITIONS,TREAT_RESULT,DIAGNOSIS_DATE as DIAGNOSIS_DATE,treat_result  FROM DIAGNOSIS WHERE PATIENT_ID='" + strPatientID + "' AND VISIT_ID=" + nVisitID.ToString();
			text += " ORDER BY DIAGNOSIS_TYPE,DIAGNOSIS_NO";
			this.m_dsDiagnosis = DALUse.Query(text);
		}
		private void getDiagnosisTypeDict()
		{
			DataSet dataSet = new DataSet();
			string sQLString = "SELECT * FROM emr_dict_detail WHERE CLASS_CODE='ZDLB20120101' ORDER BY DICT_CODE";
			dataSet = DALUse.Query(sQLString);
			if (dataSet.Tables.Count > 0)
			{
				this.m_dtDiagnosisTypeDict = dataSet.Tables[0];
			}
		}
		public string getDiagnosisTypeName(string strDiagnosisTypeCode)
		{
			DataSet dataSet = new DataSet();
			DataTable dataTable = new DataTable();
			string sQLString = "SELECT * FROM emr_dict_detail WHERE CLASS_CODE='ZDLB20120101' AND DICT_CODE='" + strDiagnosisTypeCode + "'";
			dataSet = DALUse.Query(sQLString);
			string result;
			if (dataSet.Tables.Count > 0)
			{
				dataTable = dataSet.Tables[0];
				if (dataTable.Rows.Count > 0)
				{
					result = dataTable.Rows[0]["DICT_NAME"].ToString();
					return result;
				}
			}
			result = "";
			return result;
		}
		public DataSet getDiagnosisCode(string strPatientID, string strVisitID, string strDiagnosisType, string strDiagnosisNo)
		{
			DataSet dataSet = new DataSet();
			string sQLString = string.Concat(new string[]
			{
				"SELECT * FROM diagnostic_category a WHERE a.patient_id='",
				strPatientID,
				"' AND visit_id='",
				strVisitID,
				"' AND diagnosis_type='",
				strDiagnosisType,
				"' AND diagnosis_no='",
				strDiagnosisNo,
				"'"
			});
			return DALUse.Query(sQLString);
		}
		private void getDiagComparing(string strPatientID, int nVisitID)
		{
			string sQLString = "SELECT * FROM DIAG_COMPARING WHERE PATIENT_ID='" + strPatientID + "' AND VISIT_ID=" + nVisitID.ToString();
			this.m_dsDiagComparing = DALUse.Query(sQLString);
		}
		private void getOperation(string strPatientID, int nVisitID)
		{
			string sQLString = "SELECT PATIENT_ID,VISIT_ID,OPERATION_NO,operation_desc,operation_desc_part,operation_code,operator,first_assistant,second_assistant,anesthesia_doctor,anaesthesia_method,heal,wound_grade,operating_date,'' AS OPERATION_DEPT,OPERATION_DEPT_CODE,OPERATION_TYPE,STERILE_HEAL,OPERATING_GRADE,ISMAIN ,INFFECT,ILLNESS,OPERACCORD,'0' jcbz FROM OPERATION WHERE PATIENT_ID='" + strPatientID + "' AND VISIT_ID=" + nVisitID.ToString();
			this.m_dsOperation = DALUse.Query(sQLString);
		}
		public void getBloodTransfusion(string strPatientID, int nVisitID)
		{
			string sQLString = "SELECT * FROM BLOOD_TRANSFUSION WHERE PATIENT_ID='" + strPatientID + "' AND VISIT_ID=" + nVisitID.ToString();
			this.m_dsBloodTransfusion = DALUse.Query(sQLString);
		}
		private void getMrFeeClassDict()
		{
			DataSet dataSet = new DataSet();
			string sQLString = "SELECT * FROM emr_dict_detail WHERE CLASS_CODE='BASYFYFL' ORDER BY DICT_CODE";
			dataSet = DALUse.Query(sQLString);
			if (dataSet.Tables.Count > 0)
			{
				this.m_dtMrFeeClassDict = dataSet.Tables[0];
			}
		}
		private void getMedicalCosts(string strPatientID, int nVisitID)
		{
			this.m_dsMedicalCosts = EmrSysWebservicesUse.myEmrGenralDataSet(new object[]
			{
				"FIRST_PAGE_COSTS",
				strPatientID,
				nVisitID.ToString()
			});
		}
		public string GetTotalPay(string strPatientID, int nVisitID)
		{
			string result = "";
			DataSet dataSet = EmrSysWebservicesUse.myEmrGenralDataSet(new object[]
			{
				"GETTOTALPAY",
				strPatientID,
				nVisitID.ToString()
			});
			return result;
		}
		private void getdsEMRFirstPageItemDict()
		{
			string sQLString = "SELECT * FROM emr_first_page_item_dict ORDER BY FIELD_NAME,SHOW_ORDER";
			this.m_dsEMRFirstPageItemDict = DALUse.Query(sQLString);
		}
		public string getEMRFirstPageItemTextByValue(string strFieldName, string strItemValue)
		{
			string result;
			if (this.m_dsEMRFirstPageItemDict.Tables.Count > 0)
			{
				DataTable dataTable = this.m_dsEMRFirstPageItemDict.Tables[0];
				foreach (DataRow dataRow in dataTable.Rows)
				{
					if (strFieldName.Equals(dataRow["FIELD_NAME"].ToString()) && strItemValue.Equals(dataRow["ITEM_VALUE"].ToString()))
					{
						result = dataRow["ITEM_TEXT"].ToString();
						return result;
					}
				}
			}
			result = strItemValue;
			return result;
		}
		public string getEMRFirstPageItemTextByText(string strFieldName, string strItemText)
		{
			string result;
			if (this.m_dsEMRFirstPageItemDict.Tables.Count > 0)
			{
				DataTable dataTable = this.m_dsEMRFirstPageItemDict.Tables[0];
				foreach (DataRow dataRow in dataTable.Rows)
				{
					if (strFieldName.Equals(dataRow["FIELD_NAME"].ToString()) && strItemText.Equals(dataRow["ITEM_TEXT"].ToString()))
					{
						result = dataRow["ITEM_VALUE"].ToString();
						return result;
					}
				}
			}
			result = strItemText;
			return result;
		}
		public DataTable getDiagnosisByType(string strPatientID, int nVisitID, string strDiagnosisType)
		{
			DataTable result = new DataTable();
			DataSet dataSet = new DataSet();
			string text = "SELECT a.DIAGNOSIS_NO,a.DIAGNOSIS_DESC,a.TREAT_RESULT,a.TREAT_DAYS,a.OPER_TREAT_INDICATOR,a.ADMISSION_CONDITIONS,";
			text += " a.DIAGNOSIS_DATE as DIAGNOSIS_DATE,b.DIAGNOSIS_CODE,a.DIAGNOSIS_DESC_PART  FROM DIAGNOSIS a left join DIAGNOSTIC_CATEGORY b ";
			text += " on  ( a.patient_id = b.patient_id ) ";
			text += " AND  ( a.visit_id = b.visit_id ) ";
			text += " AND  ( a.diagnosis_type = b.diagnosis_type ) ";
			text += " AND  ( a.diagnosis_no = b.diagnosis_no ) ";
			string text2 = text;
			text = string.Concat(new string[]
			{
				text2,
				" WHERE a.PATIENT_ID='",
				strPatientID,
				"' AND a.VISIT_ID=",
				nVisitID.ToString()
			});
			text = text + " AND  a.DIAGNOSIS_TYPE in ('" + strDiagnosisType + "')";
			text += " ORDER BY a.DIAGNOSIS_TYPE,a.DIAGNOSIS_NO";
			dataSet = DALUse.Query(text);
			if (dataSet.Tables.Count > 0)
			{
				result = dataSet.Tables[0];
			}
			return result;
		}
		public bool InsertOperationToDoctorCustomDict(string strCode)
		{
			DataTable dataTable = new DataTable();
			DataSet dataSet = new DataSet();
			string text = "SELECT * FROM operation_dict";
			text = text + " WHERE OPERATION_CODE='" + strCode + "'";
			dataSet = DALUse.Query(text);
			bool result;
			if (dataSet.Tables.Count > 0)
			{
				dataTable = dataSet.Tables[0];
				if (dataTable.Rows.Count > 0)
				{
					text = "DELETE FROM EMR_DOCTOR_CUSTOM_DICT WHERE DB_USER='" + EmrSysPubVar.getDbUser() + "'";
					text += " AND DICT_TYPE='手术'";
					text = text + " AND DICT_CODE='" + ((dataTable.Rows[0]["OPERATION_CODE"] == DBNull.Value) ? "" : dataTable.Rows[0]["OPERATION_CODE"].ToString()) + "'";
					text = text + " AND DICT_NAME='" + ((dataTable.Rows[0]["OPERATION_NAME"] == DBNull.Value) ? "" : dataTable.Rows[0]["OPERATION_NAME"].ToString()) + "'";
					DALUse.ExecuteSql(text);
					text = "INSERT INTO EMR_DOCTOR_CUSTOM_DICT(DB_USER,DICT_TYPE,DICT_CODE,DICT_NAME,INPUT_CODE,DEPT_CODE ";
					text += ") VALUES(";
					text = text + "'" + EmrSysPubVar.getDbUser() + "',";
					text += "'手术',";
					text = text + "'" + ((dataTable.Rows[0]["OPERATION_CODE"] == DBNull.Value) ? "" : dataTable.Rows[0]["OPERATION_CODE"].ToString()) + "',";
					text = text + "'" + ((dataTable.Rows[0]["OPERATION_NAME"] == DBNull.Value) ? "" : dataTable.Rows[0]["OPERATION_NAME"].ToString()) + "',";
					text = text + "'" + ((dataTable.Rows[0]["INPUT_CODE"] == DBNull.Value) ? "" : dataTable.Rows[0]["INPUT_CODE"].ToString()) + "'";
					text = text + ",'" + EmrSysPubVar.getDeptCode() + "'";
					text += ")";
					DALUse.ExecuteSql(text);
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}
		public bool InsertDiagToDoctorCustomDict(string strCode)
		{
			DataTable dataTable = new DataTable();
			DataSet dataSet = new DataSet();
			string text = "SELECT * FROM DIAGNOSIS_DICT";
			text = text + " WHERE DIAGNOSIS_CODE='" + strCode + "'";
			dataSet = DALUse.Query(text);
			bool result;
			if (dataSet.Tables.Count > 0)
			{
				dataTable = dataSet.Tables[0];
				if (dataTable.Rows.Count > 0)
				{
					text = "DELETE FROM EMR_DOCTOR_CUSTOM_DICT WHERE DB_USER='" + EmrSysPubVar.getDbUser() + "'";
					text += " AND DICT_TYPE='诊断'";
					text = text + " AND DICT_CODE='" + ((dataTable.Rows[0]["DIAGNOSIS_CODE"] == DBNull.Value) ? "" : dataTable.Rows[0]["DIAGNOSIS_CODE"].ToString()) + "'";
					text = text + " AND DICT_NAME='" + ((dataTable.Rows[0]["DIAGNOSIS_NAME"] == DBNull.Value) ? "" : dataTable.Rows[0]["DIAGNOSIS_NAME"].ToString()) + "'";
					DALUse.ExecuteSql(text);
					text = "INSERT INTO EMR_DOCTOR_CUSTOM_DICT(DB_USER,DICT_TYPE,DICT_CODE,DICT_NAME,INPUT_CODE,DEPT_CODE ";
					text += ") VALUES(";
					text = text + "'" + EmrSysPubVar.getDbUser() + "',";
					text += "'诊断',";
					text = text + "'" + ((dataTable.Rows[0]["DIAGNOSIS_CODE"] == DBNull.Value) ? "" : dataTable.Rows[0]["DIAGNOSIS_CODE"].ToString()) + "',";
					text = text + "'" + ((dataTable.Rows[0]["DIAGNOSIS_NAME"] == DBNull.Value) ? "" : dataTable.Rows[0]["DIAGNOSIS_NAME"].ToString()) + "',";
					text = text + "'" + ((dataTable.Rows[0]["INPUT_CODE"] == DBNull.Value) ? "" : dataTable.Rows[0]["INPUT_CODE"].ToString()) + "'";
					text = text + ",'" + EmrSysPubVar.getDeptCode() + "'";
					text += ")";
					DALUse.ExecuteSql(text);
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}
		private void getPatientVisitBaby(string strPatientID, int nVisitID)
		{
			string sQLString = string.Concat(new string[]
			{
				"SELECT * FROM PAT_VISIT_BABY WHERE PATIENT_ID='",
				strPatientID,
				"' AND VISIT_ID=",
				nVisitID.ToString(),
				" order by baby_no"
			});
			this.m_dsPatientVisitBaby = DALUse.Query(sQLString);
		}
		private void getPatientTumour(string strPatientID, int nVisitID)
		{
			string sQLString = "SELECT * FROM PAT_TUMOUR WHERE PATIENT_ID='" + strPatientID + "' AND VISIT_ID=" + nVisitID.ToString();
			this.m_dsPatientTumour = DALUse.Query(sQLString);
		}
		private void getPatientTumourDetail(string strPatientID, int nVisitID)
		{
			string sQLString = string.Concat(new string[]
			{
				"SELECT * FROM PAT_TUMOUR_DETAIL WHERE PATIENT_ID='",
				strPatientID,
				"' AND VISIT_ID=",
				nVisitID.ToString(),
				"order by detail_no"
			});
			this.m_dsPatientTumourDetail = DALUse.Query(sQLString);
		}
		private void getAdtLog(string strPatientID, int nVisitID)
		{
			string sQLString = string.Concat(new string[]
			{
				"select c.dept_name,a.dept_code, a.log_date_time,a.ward_code, b.patient_id from adt_log a, pat_visit b,dept_dict c  where a.patient_id = b.patient_id and a.visit_id = b.visit_id and a.dept_code=c.dept_code   and b.patient_id = '",
				strPatientID,
				"' and b.visit_id=",
				nVisitID.ToString(),
				"  order by a.log_date_time asc"
			});
			this.m_dsAdtLog = DALUse.Query(sQLString);
		}
		public static DataTable getDeptUser(string strDeptCode, bool bIncludeCurUser)
		{
			DataTable result = new DataTable();
			DataSet dataSet = new DataSet();
			string text = "SELECT a.USER_NAME,a.DB_USER,a.USER_ID";
			text += " FROM USERS a,USER_DEPT b";
			text = text + "  WHERE a.USER_ID=b.USER_ID AND  b.USER_DEPT='" + strDeptCode + "'  ";
			text += "  and b.default_dept_flag=1 ";
			text += " ORDER BY USER_NAME";
			dataSet = DALUse.Query(text);
			if (dataSet.Tables.Count > 0)
			{
				result = dataSet.Tables[0];
			}
			return result;
		}
		public static string getDeptCode(string strDeptName)
		{
			DataTable dataTable = new DataTable();
			DataSet dataSet = new DataSet();
			string result = "";
			string sQLString = "SELECT DEPT_CODE FROM DEPT_DICT WHERE DEPT_NAME='" + strDeptName + "'";
			dataSet = DALUse.Query(sQLString);
			if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
			{
				dataTable = dataSet.Tables[0];
				result = dataTable.Rows[0][0].ToString();
			}
			return result;
		}
		private void getMoniterPatient(string strPatientID, int nVisitID)
		{
			string sQLString = "select a.start_date_time from emr_monitor_patient_order a,emr_monitor_vs_clinic b where a.order_code=b.clinic_item_code and b.monitor_order_code='C20' and a.PATIENT_ID='" + strPatientID + "' AND a.VISIT_ID=" + nVisitID.ToString();
			this.m_dsMoniterPatient = DALUse.Query(sQLString);
		}
		public bool ValidICDCode(string strIcdCode, string strFlag)
		{
			DataSet dataSet = new DataSet();
			string sQLString;
			if (strFlag == "1")
			{
				sQLString = "select * from diagnosis_dict where diagnosis_code='" + strIcdCode + "'";
			}
			else
			{
				sQLString = "select * from operation_dict where operation_code='" + strIcdCode + "'";
			}
			dataSet = DALUse.Query(sQLString);
			return dataSet.Tables.Count <= 0 || dataSet.Tables[0].Rows.Count <= 0 || true;
		}
		public bool ICDNameAndCode(string strIcdCode, string strIcdName)
		{
			DataSet dataSet = new DataSet();
			string sQLString = string.Concat(new string[]
			{
				"select * from diagnosis_dict where diagnosis_code='",
				strIcdCode,
				"' and diagnosis_name='",
				strIcdName,
				"'"
			});
			dataSet = DALUse.Query(sQLString);
			return dataSet.Tables.Count <= 0 || dataSet.Tables[0].Rows.Count <= 0 || true;
		}
		public bool getPatientTemplet(string strMonitorCode, string strPatientID, string strVisitID)
		{
			DataSet dataSet = new DataSet();
			string strSQL = string.Concat(new string[]
			{
				"select count(*) from mr_templet_index a,MR_FILE_INDEX b where a.MR_CODE=b.MR_CODE AND a.monitor_code='",
				strMonitorCode,
				"' AND b.PATIENT_ID='",
				strPatientID,
				"' and b.visit_id='",
				strVisitID,
				"'"
			});
			int count = DALUse.GetCount(strSQL);
			return DALUse.GetCount(strSQL) > 0;
		}
		public string getDoctorID(string strDocName)
		{
			string sQLString = "select user_id from users where user_name='" + strDocName + "'";
			DataSet dataSet = new DataSet();
			dataSet = DALUse.Query(sQLString);
			string result;
			if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
			{
				if (dataSet.Tables[0].Rows[0]["user_id"] != DBNull.Value)
				{
					result = dataSet.Tables[0].Rows[0]["user_id"].ToString();
				}
				else
				{
					result = "";
				}
			}
			else
			{
				result = "";
			}
			return result;
		}
		public DataTable getAnaesthesiaMethod()
		{
			DataTable result = new DataTable();
			string sQLString = "select item_text from emr_first_page_item_dict where field_name='ANAESTHESIA_METHOD'";
			DataSet dataSet = new DataSet();
			dataSet = DALUse.Query(sQLString);
			if (dataSet.Tables.Count > 0)
			{
				result = dataSet.Tables[0];
			}
			return result;
		}
		public string getInDayTime(string ADMISSION_DATE_TIME, string DISCHARGE_DATE_TIME)
		{
			string result;
			if (DISCHARGE_DATE_TIME.Equals(""))
			{
				result = "";
			}
			else
			{
				DateTime value = DateTime.Parse(string.Format("{0:yyyy-MM-dd}", ADMISSION_DATE_TIME));
				result = (DateTime.Parse(string.Format("{0:yyyy-MM-dd}", DISCHARGE_DATE_TIME)).Subtract(value).Days + 1).ToString();
			}
			return result;
		}
		public bool getCataloger(string strPatientID, string strVisitID)
		{
			DataSet dataSet = new DataSet();
			string strSQL = string.Concat(new string[]
			{
				"select count(*) from pat_visit b where b.PATIENT_ID='",
				strPatientID,
				"' and b.visit_id='",
				strVisitID,
				"' and b.cataloger is not null"
			});
			int count = DALUse.GetCount(strSQL);
			return count > 0;
		}
		public bool getDiagTable(string strPatientID, string strVisitID)
		{
			DataSet dataSet = new DataSet();
			string text = "SELECT count(*)  FROM DIAGNOSIS ";
			string text2 = text;
			text = string.Concat(new string[]
			{
				text2,
				" WHERE treat_result ='死亡' AND PATIENT_ID='",
				strPatientID,
				"' AND VISIT_ID=",
				strVisitID.ToString()
			});
			int count = DALUse.GetCount(text);
			return count > 0;
		}
		public bool getPatientSwTemplet(string strPatientID, string strVisitID)
		{
			DataSet dataSet = new DataSet();
			string strSQL = string.Concat(new string[]
			{
				"select COUNT(*) from mr_file_index t where t.Mr_CLASS='ZA' AND T.TOPIC='死亡上报卡' AND t.PATIENT_ID='",
				strPatientID,
				"' and t.visit_id='",
				strVisitID,
				"' and t.file_flag<>'T'"
			});
			int count = DALUse.GetCount(strSQL);
			return DALUse.GetCount(strSQL) > 0;
		}
		public bool getPatientIsOut(string strPatientID, string strVisitID)
		{
			DataSet dataSet = new DataSet();
			string strSQL = "select COUNT(*) from pats_in_hospital t where PATIENT_ID='" + strPatientID + "' AND VISIT_ID=" + strVisitID.ToString();
			int count = DALUse.GetCount(strSQL);
			return DALUse.GetCount(strSQL) > 0;
		}
		public bool getPatientIsInfect(string strPatientID, string strVisitID)
		{
			DataSet dataSet = new DataSet();
			string strSQL = string.Concat(new string[]
			{
				"select COUNT(*) from pat_diagnosis t where PATIENT_ID='",
				strPatientID,
				"' AND VISIT_ID=",
				strVisitID.ToString(),
				" AND CONTAGIOUS =1 and REPORT_CONTAGIOUS=0"
			});
			int count = DALUse.GetCount(strSQL);
			return DALUse.GetCount(strSQL) > 0;
		}
		private void getCMFirstPageInfo(string strPatientID, int nVisitID)
		{
			string sQLString = string.Concat(new object[]
			{
				"select * from EMR_CMFIRSTPAGE_INFO t where PATIENT_ID='",
				strPatientID,
				"' AND VISIT_ID=",
				nVisitID,
				""
			});
			this.m_dsCMFirstPageData = DALUse.Query(sQLString);
		}
		public static string getUserNme(string strUserId)
		{
			string sQLString = "select * from users_pic  t  where t.user_id = '" + strUserId + "'";
			DataTable dataTable = DALUse.Query(sQLString).Tables[0];
			string result;
			if (dataTable != null && dataTable.Rows.Count > 0)
			{
				result = dataTable.Rows[0]["USER_NAME"].ToString();
			}
			else
			{
				result = null;
			}
			return result;
		}
		public static string getUserId(string strUserName)
		{
			string sQLString = "select t.user_id from users t where t.user_name='" + strUserName + "' ";
			DataSet dataSet = DALUse.Query(sQLString);
			string result;
			if (dataSet != null && dataSet.Tables[0].Rows.Count > 0)
			{
				result = dataSet.Tables[0].Rows[0][0].ToString();
			}
			else
			{
				result = null;
			}
			return result;
		}
	}
}
