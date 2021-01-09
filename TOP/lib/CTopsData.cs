using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TOP.lib
{
    public class CTopsData
    {
        public DataSet MainData;

        public CTopsData()
        {
            MainData = new DataSet();
        }

        public void LoadFromXml()
        {
        }

        public void SaveToXml()
        {
        }

        /// <summary>
        /// 토적 Data를 Load 한다.
        /// 토적 Data는 PipeTool데이터 이후에 Load해야 한다.
        /// </summary>
        public void LoadFrom토적Data()
        {
            if (MainData.Tables["SHEET_INFO"].Rows.Count <= 0)
            {
                MessageBox.Show("먼저 PIPE TOOL 데이터를 Load 하세요.");

                return;
            }

            DataTable sheet_info = MainData.Tables["SHEET_INFO"];

            string filename = "";
            SpreadsheetControl MainSheet = new SpreadsheetControl();
            try
            {
                filename = CUtil.LoadExcel(MainSheet);

                IWorkbook workbook = MainSheet.Document;

                foreach (Worksheet item in workbook.Worksheets)
                {
                    int nRow = item.GetUsedRange().RowCount;

                    IEnumerable<Cell> searchResult = ExcelDataSourceExtension.FindCell(item, "NO");

                    string strPos2;
                    string strPos1;
                    string strPos3;

                    foreach (Cell cell in searchResult)
                    {
                        if (cell.ColumnIndex != 1)
                        {
                            continue;
                        }

                        ///토적Data는 Sheet별로 DataTable을 관리하는 구조야
                        //CMassData Data = new CMassData();

                        if (MainData.Tables.Contains(item.Name) == false)
                        {
                            MessageBox.Show("토적Data Sheet[" + item.Name + "]가 PipeTool 데이터에 없습니다.");
                        }

                        string strPos;

                        strPos1 = string.Format("{0}{1}:{2}{3}", "B", 1, "T", nRow);

                        DataTable dt1 = ExcelDataSourceExtension.ExcelToDataSource(filename, item, strPos1);

                        string sfillter = string.Format("SHEET_NAME = '{0}'", item.Name);

                        ///Sheet Info 정보에 추가
                        DataRow[] rows = sheet_info.Select(sfillter);

                        if (rows.Count() > 1)
                        {
                            //다른 정보가 있는거얌
                        }

                        rows[0]["토적_RANGE"] = strPos1;

                        DataTable sortTable = 토적정렬(dt1);
                        sortTable.TableName = item.Name + "_토적";

                        MainData.Tables.Add(sortTable);
                    }
                }
                Make토적Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }

        private string[] GetPoint(string data)
        {
            string[] sRet = new string[4];

            char[] sTocken = { '-', '+' };
            string[] sss = data.Split(sTocken);

            sRet[0] = sss[0];
            sRet[1] = sss[1];

            int npos = data.IndexOf('(');

            if (npos < 0)
            {
                sRet[2] = sss[1];
                sRet[3] = "";
            }
            else
            {
                sRet[2] = sss[1].Replace(data.Substring(npos, data.Length - npos), "");
                sRet[3] = data.Substring(npos, data.Length - npos);
            }

            return sRet;
        }

        /// <summary>
        /// 토적표가 정렬이 안되어 있는경우가 있어요
        /// 그래서 전단면과 후단면을 기준으로 정렬해요
        /// 정열 기준은 누가거리 그리고 전단면 후단면 형식이에요
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private DataTable 토적정렬(DataTable data)
        {
            data.Columns.Add("누가거리", typeof(decimal));
            data.Columns.Add("전후", typeof(decimal));

            foreach (DataRow Dr in data.Rows)
            {
                string[] sss = GetPoint(Dr["NO"].ToString());

                decimal dist = (Convert.ToDecimal(sss[0]) * 20) + Convert.ToDecimal(sss[2]);
                Dr["누가거리"] = dist;

                if (sss[3].ToString().Trim() == "")
                {
                    Dr["전후"] = 1;
                }
                else if (sss[3].ToString().Trim() == "(전)")
                {
                    Dr["전후"] = 2;
                }
                else if (sss[3].ToString().Trim() == "(후)")
                {
                    Dr["전후"] = 3;
                }
            }
            data.DefaultView.Sort = "누가거리 DESC, 전후 DESC";
            return data.DefaultView.ToTable();
        }

        /// <summary>
        /// Load 된 두개의 데이터 (PIPE TOOL과 토적 데이터) 합쳐 한개의 DataTable로 만들어요
        /// 그런데 하다 보니까. 엑셀 데이터의 개수가 맞지 않는 경우가 생겼어요
        /// 아마도 작업자가 빠뜨리는 경우가 생기는 듯요
        /// 그래서 점검하는 기능이 필요한거 같아요
        /// </summary>
        private void Make토적Data()
        {
            if (Chk토적Data() == false)
            {
                return;
            }

            DataTable dt토적표기초데이터 = CGetTableType.GtMassData();

            foreach (DataRow sheet_dr in MainData.Tables["SHEET_INFO"].Rows)
            {
                string sheet_name = sheet_dr["SHEET_NAME"].ToString();
                DataTable dtPipeTool = MainData.Tables[sheet_name].Copy();
                DataTable dt토적 = MainData.Tables[sheet_name + "_토적"].Copy();

                //pipe tool data
                var qry = (from a in dtPipeTool.AsEnumerable()
                           select new
                           {
                               누가거리 = a.Field<double>("누가거리")
                           }).Distinct();

                DataTable dt = CUtil.LinqQueryToDataTable(qry);



                foreach (DataRow 누가거리_dr in dt.Rows)
                {
                    //먼저  Pipe Tool 기반으로 토적 데이터를 찾아보자
                    string sFillter = string.Format("누가거리 = {0}", Convert.ToDouble(누가거리_dr["누가거리"]));
                    DataRow[] result = dt토적.Select(sFillter, "전후 ASC");

                    //if (result.Count() > 1)
                    //{
                    //만약 같은게 2개 이상 나왔다면 그건 전후단면이라는 말이지
                    DataRow[] p_result = dtPipeTool.Select(sFillter);

                    for (int i = 0; i < p_result.Count(); i++)
                    {
                        DataRow dr = dt토적표기초데이터.NewRow();

                        ///맨홀명 앞에 이상한 내용이 들어있어요 M1-, E1- D1- 이렇게 ... 그래서 (하이픈)- 이 2개 이면 1개 앞쪽은 다 날려버리자구
                        ///
                        string strData = p_result[i]["맨홀"].ToString();

                        System.Text.RegularExpressions.Regex cntStr = new System.Text.RegularExpressions.Regex("-");
                        int nCnt = int.Parse(cntStr.Matches(strData, 0).Count.ToString());

                        if (nCnt > 1)
                        {
                            dr["LINENAME"] = strData.Substring(strData.IndexOf("-") + 1);
                        }
                        else
                        {
                            dr["LINENAME"] = p_result[i]["맨홀"];
                        }

                        dr["LINE"] = sheet_name;
                        dr["누가거리"] = p_result[i]["누가거리"];
                        dr["NO"] = result[i]["NO"];
                        dr["지반고"] = result[i]["지반고"];
                        dr["관저고"] = result[i]["관저고"];
                        dr["계획고"] = result[i]["계획고"];
                        dr["육상(토사)"] = result[i]["육상(토사)"];
                        dr["육상(풍화암)"] = result[i]["육상(풍화암)"];
                        dr["육상(연암)"] = result[i]["육상(연암)"];
                        dr["수중(토사)"] = result[i]["수중(토사)"];
                        dr["수중(풍화암)"] = result[i]["수중(풍화암)"];
                        dr["수중(연암)"] = result[i]["수중(연암)"];
                        dr["관상부"] = result[i]["관상부"];
                        dr["관주위"] = result[i]["관주위"];
                        dr["ASP"] = result[i]["ASP"];
                        dr["CONC"] = result[i]["CONC"];
                        dr["덧씌우기"] = result[i]["덧씌우기"];
                        dr["보도블럭"] = result[i]["보도블럭"];
                        dr["모래부설"] = result[i]["모래부설"];
                        dr["보조기층"] = result[i]["보조기층"];
                        dr["동상방지층"] = result[i]["동상방지층"];
                        dr["구간"] = p_result[i]["구간"];
                        dr["관경"] = p_result[i]["관경"];
                        dr["맨홀규격"] = p_result[i]["맨홀규격"];
                        dr["굴착공법"] = p_result[i]["굴착공법"];
                        dr["굴착장비"] = p_result[i]["굴착장비"];
                        dr["포장종류"] = p_result[i]["포장종류"];

                        dt토적표기초데이터.Rows.Add(dr);
                    }

                }
            }

            MainData.Tables.Add(dt토적표기초데이터);
        }

        /// <summary>
        /// PipeTool 생성 Sheet별 Data Count와 토적데이터 Sheet별 RowCount를 비교해요
        /// </summary>
        /// <returns></returns>
        private Boolean Chk토적Data()
        {
            //if (PipeMngr.Data.Count <= 0)
            //{
            //    MessageBox.Show("PIPE TOOL 데이터 Load 여부를 확인하세요", "데이터 확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            //if (MassMngr.Data.Count <= 0)
            //{
            //    MessageBox.Show("토적 데이터 Load 여부를 확인하세요", "데이터 확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            try
            {
                string sheet_name = "";
                string sheet_name2 = "";
                int cnt1 = 0;
                int cnt2 = 0;

                foreach (DataRow dr in MainData.Tables["SHEET_INFO"].Rows)
                {
                    sheet_name = dr["SHEET_NAME"].ToString();
                    sheet_name2 = dr["SHEET_NAME"].ToString() + "_토적";

                    cnt1 = MainData.Tables[sheet_name].Rows.Count;
                    cnt2 = MainData.Tables[sheet_name2].Rows.Count;

                    if (cnt1 != cnt2)
                    {
                        string strmsg;
                        strmsg = string.Format("PipeToolData와 토적데이터 비교중 Sheet{0}의 데이터 Count 가 일치하지 않습니다. 처리는 가능하지만 데이터의 적합성을 보장할 수는 없습니다.  계속 하시겠습니까?", cnt1);

                        if (MessageBox.Show(strmsg, "데이터 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("토적 데이터 처리중 오류가 발생했습니다.", "데이터 확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public void LoadFromPipeTool()
        {
            string filename = "";
            SpreadsheetControl MainSheet = new SpreadsheetControl();

            ///기본데이터를 생성한다.
            ///
            DataTable SheetInfo = CGetTableType.GetSheetInfo();

            ///데이터셋에 추가한다.
            MainData.Tables.Add(SheetInfo);

            ///엑셀을 불러와 봅시다.
            try
            {
                filename = CUtil.LoadExcel(MainSheet);
                //splashScreenManager1.ShowWaitForm();
                IWorkbook workbook = MainSheet.Document;

                //불러온 EXCEL을 Data화 해봅니다.
                foreach (Worksheet item in workbook.Worksheets)
                {
                    int nRow = item.GetUsedRange().RowCount;

                    //dt.Columns.Add("SHEET_NAME", typeof(string)); sheet명
                    //dt.Columns.Add("PIPE_TYPE", typeof(string));  관종
                    //dt.Columns.Add("DATA1_RANGE", typeof(string));
                    //dt.Columns.Add("DATA2_RANGE", typeof(string));

                    IEnumerable<Cell> searchResult = ExcelDataSourceExtension.FindCell(item, "측점");

                    string strPos2;
                    string strPos1;

                    foreach (Cell cell in searchResult)
                    {
                        if (cell.ColumnIndex != 1)
                        {
                            continue;
                        }

                        //PIPE Data를 구성합니다.

                        strPos1 = string.Format("{0}{1}:{2}{3}", "B", 3, "AN", cell.RowIndex - 1);

                        if (nRow == cell.RowIndex + 1)
                        {
                            strPos2 = string.Format("{0}{1}:{2}{3}", "B", cell.RowIndex + 1, "H", nRow);
                        }
                        else
                        {
                            strPos2 = string.Format("{0}{1}:{2}{3}", "B", cell.RowIndex + 1, "H", nRow - 1);
                        }

                        ///Sheet Info 정보에 추가
                        SheetInfo.Rows.Add(item.Name, item.GetCellValue(8, 1).ToString(), strPos1, strPos2, "");

                        DataTable dt1 = ExcelDataSourceExtension.ExcelToDataSource(filename, item, strPos1);
                        DataTable dt2 = ExcelDataSourceExtension.ExcelToDataSource(filename, item, strPos2);

                        dt1.TableName = item.Name;
                        CDataMngr.SetExtend(dt1);

                        MainData.Tables.Add(dt1);
                    }
                }

             
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show(sheetname + "::" + ex.Message);
            }
            finally
            {
                // splashScreenManager1.CloseWaitForm();
            }
        }

        /// <summary>
        /// 출력물을 생성하기 전에 중간뎅터 생성을 한다. \
        /// 구간 정보의 경우 맨홀규격 및 관경등이 필수 항목이기에 
        /// 사전에 입력할 수 없는 경우가 있다 
        /// 출력하기전에 입력값에서 완전한 값을 넣어야 한다. 
        /// </summary>
        public void MakeBidge()
        {
            //구간정보를 생성한다.
            MainData.Tables.Add(MakeManholeSection());
        }


        /// <summary>
        /// Pipe Tool 데이터로 맨홀 구간정보를 만들어요
        /// </summary>
        /// <param name="Pipe_dt"></param>
        /// <returns></returns>
        private DataTable MakeManholeSection()
        {
            try
            {
                DataTable 구간정보_dt = CGetTableType.Get맨홀구간정보();

                int row_idx = 0;

                DataTable sheetinfo_dt = MainData.Tables["SHEET_INFO"];

                foreach (DataRow item_dr in sheetinfo_dt.Rows)
                {
                    string sheet_name = item_dr["SHEET_NAME"].ToString();

                    DataTable qry_tmp = MainData.Tables[sheet_name];


                    var qry = from a in qry_tmp.AsEnumerable()
                              select new
                              {
                                  LINENAME = item_dr["SHEET_NAME"].ToString()
                              ,
                                  관종 = item_dr["PIPE_TYPE"].ToString()
                              ,
                                  맨홀 = a.Field<string>("맨홀")
                              ,
                                  관경 = a.Field<double>("관경")
                              ,
                                  맨홀규격 = a.Field<string>("맨홀규격")
                              ,
                                  누가거리 = a.Field<double>("누가거리")
                              };

                    DataTable qry_dt = CUtil.LinqQueryToDataTable(qry);

                    DataRow dr_tmp = 구간정보_dt.NewRow();

                    ///마지막 열까지 돌면 안되요
                    ///마지막에서 하나 뺀거 까지만 돌기로 해용
                    for (int i = 0; i < qry_dt.Rows.Count - 1; i++)
                    {
                        DataRow dr1 = qry_dt.Rows[i];
                        DataRow dr2 = qry_dt.Rows[i + 1];

                        string sfilter = "";

                        if (dr1["맨홀"].ToString() == "M2-A-019")
                        {
                        }

                        if (dr1["맨홀규격"].ToString() == "")
                        {
                            /// 맨홀 규격이 없는데 관종도 앞구간과 관경이 다르면 빼버리자
                            ///
                            if (Convert.ToDouble(dr1["관경"]) == 160)
                            {
                            }

                            sfilter = string.Format("LINENAME='{0}'  AND 관종 = '{1}'  AND 관경 = {2} ",
                                                dr1["LINENAME"].ToString()
                                              , dr1["관종"].ToString()
                                              , Convert.ToDouble(dr1["관경"])
                                                //, Convert.ToDouble(dr1["누가거리"])
                                                );
                        }
                        else
                        {
                            sfilter = string.Format("LINENAME='{0}'  AND 관종 = '{1}'  AND 관경 = {2} AND 맨홀규격 = '{3}' AND 맨홀 = '{4}'",
                                                dr1["LINENAME"].ToString()
                                              , dr1["관종"].ToString()
                                              , Convert.ToDouble(dr1["관경"])
                                              , dr1["맨홀규격"].ToString()
                                              , dr1["맨홀"].ToString()
                                                );
                        }
                        //sfilter = string.Format("LINENAME='{0}'  AND 관종 = '{1}' AND 맨홀 = '{2}' AND 관경 = {3} AND 맨홀규격 = '{4}' AND  시작위치 = {5} ",

                        DataRow[] result = 구간정보_dt.Select(sfilter, "INDEX ASC");

                        if (Convert.ToDouble(dr1["누가거리"]) <= 0)
                        {
                            DataRow dr = 구간정보_dt.NewRow();
                            dr["INDEX"] = row_idx;
                            dr["LINENAME"] = dr1["LINENAME"];
                            dr["관종"] = dr1["관종"];
                            dr["맨홀"] = dr1["맨홀"];
                            dr["관경"] = dr1["관경"];
                            dr["맨홀규격"] = dr1["맨홀규격"];
                            dr["시작위치"] = dr1["누가거리"];
                            dr["종료위치"] = dr2["누가거리"];
                            dr["구간거리"] = Convert.ToDouble(dr2["누가거리"]) - Convert.ToDouble(dr1["누가거리"]);

                            구간정보_dt.Rows.Add(dr);
                            row_idx++;

                            continue;
                        }
                        else if (result.Count() <= 0)
                        {
                            DataRow dr0 = qry_dt.Rows[i - 1];
                            //신규로 추가 할라 그랬는데 맨홀규격도 없고 앞관로와 관경도 다르면 패쑤
                            if (dr1["맨홀규격"].ToString() == "")
                            {
                                continue;
                            }

                            DataRow dr = 구간정보_dt.NewRow();
                            dr["INDEX"] = row_idx;
                            dr["LINENAME"] = dr1["LINENAME"];
                            dr["관종"] = dr1["관종"];
                            dr["맨홀"] = dr1["맨홀"];
                            dr["관경"] = dr1["관경"];
                            dr["맨홀규격"] = dr1["맨홀규격"];
                            dr["시작위치"] = dr1["누가거리"];
                            dr["종료위치"] = dr2["누가거리"];
                            dr["구간거리"] = Convert.ToDouble(dr2["누가거리"]) - Convert.ToDouble(dr1["누가거리"]);

                            구간정보_dt.Rows.Add(dr);
                            row_idx++;
                        }
                        else
                        {
                            int nCnt = 0;
                            nCnt = result.Count() - 1;

                            DataRow dr0 = qry_dt.Rows[i - 1];

                            //Update 할라 그랬는데 맨홀규격도 없고 앞관로와 관경도 다르면 패쑤
                            if (dr1["맨홀규격"].ToString() == "" && Convert.ToDouble(result[nCnt]["관경"]) != Convert.ToDouble(dr1["관경"]))
                            {
                                continue;
                            }

                            result[nCnt]["종료위치"] = Convert.ToDouble(dr2["누가거리"]);
                            result[nCnt]["구간거리"] = Convert.ToDouble(result[nCnt]["구간거리"]) + (Convert.ToDouble(dr2["누가거리"]) - Convert.ToDouble(dr1["누가거리"]));

                            continue;
                        }
                    }
                }

                return 구간정보_dt;
            }
            catch (Exception ex)
            {
                throw new CUserException("구간정보 생성중 오류가 발생했습니다.");
            }
        }


        /// <summary>
        /// 토적표를 출력한다.
        /// </summary>
        /// <param name="dt"></param>
        public void Print토적표(IWorkbook workbook)
        {
            if (workbook.Worksheets.Contains("토적표") == true)
            {
                workbook.Worksheets.Remove(workbook.Worksheets["토적표"]);
            }

            DataTable dt = MainData.Tables[CGetTableType.tbl_토적표기초데이터];

            Worksheet sheet = workbook.Worksheets.Add();
            sheet.Name = "토적표";

            workbook.BeginUpdate();

            //LINENAME NO	지반고	관저고	계획고	육상(토사)	육상(풍화암)	육상(연암)	수중(토사)	수중(풍화암)	수중(연암)	관상부
            //관주위	ASP	CONC	덧씌우기	보도블럭	모래부설	보조기층	동상방지층

            int nIndex = 3;
            int nCol = 0;

            string nLine = "";

            //Header Font 설정
            CellRange range = sheet.Range["A1:BT3"];
            CUtil.setSheetHeaderFormat(range, "맑은 고딕", 10);

            //Header 출력
            sheet.Rows[0]["C"].SetValue("관로번호");
            sheet.MergeCells(sheet.Range["C1:C3"]);

            sheet.Rows[0]["D"].SetValue("측점");
            sheet.MergeCells(sheet.Range["D1:H3"]);

            sheet.Rows[0]["I"].SetValue("누가거리");
            sheet.Rows[2]["I"].SetValue("m");
            sheet.MergeCells(sheet.Range["I1:I2"]);

            sheet.Rows[0]["J"].SetValue("거리");
            sheet.Rows[2]["I"].SetValue("m");
            sheet.MergeCells(sheet.Range["J1:J2"]);

            //터파기
            sheet.Rows[0]["K"].SetValue("터파기(토사)");
            sheet.MergeCells(sheet.Range["k1:N1"]);
            sheet.Rows[1]["K"].SetValue("육상");
            sheet.MergeCells(sheet.Range["K2:L2"]);
            sheet.Rows[2]["K"].SetValue("m2");
            sheet.Rows[2]["L"].SetValue("m2");

            sheet.Rows[1]["M"].SetValue("용수");
            sheet.MergeCells(sheet.Range["M2:N2"]);
            sheet.Rows[2]["M"].SetValue("m2");
            sheet.Rows[2]["N"].SetValue("m2");

            //되메우기
            sheet.Rows[0]["W"].SetValue("되메우기");
            sheet.MergeCells(sheet.Range["W1:Z1"]);
            sheet.Rows[1]["W"].SetValue("관주위(토사)");
            sheet.MergeCells(sheet.Range["W2:X2"]);
            sheet.Rows[2]["W"].SetValue("m2");
            sheet.Rows[2]["X"].SetValue("m2");

            sheet.Rows[1]["Y"].SetValue("관상단(토사)");
            sheet.MergeCells(sheet.Range["Y2:Z2"]);
            sheet.Rows[2]["Y"].SetValue("m2");
            sheet.Rows[2]["Z"].SetValue("m2");

            //관기초
            sheet.Rows[0]["AA"].SetValue("관기초");
            sheet.MergeCells(sheet.Range["AA1:AB2"]);
            sheet.Rows[2]["AA"].SetValue("m2");
            sheet.Rows[2]["AB"].SetValue("m2");

            //ASP포장(국도)
            sheet.Rows[0]["AC"].SetValue("ASP 포장(국도)");
            sheet.MergeCells(sheet.Range["AC1:AG1"]);
            sheet.Rows[1]["AC"].SetValue("절단");
            sheet.Rows[1]["AD"].SetValue("깨기 및 복구");
            sheet.MergeCells(sheet.Range["AD2:AE2"]);
            sheet.Rows[2]["AD"].SetValue("m2");
            sheet.Rows[2]["AE"].SetValue("m2");

            sheet.Rows[1]["AF"].SetValue("보조기층");
            sheet.MergeCells(sheet.Range["AF2:AG2"]);
            sheet.Rows[2]["AF"].SetValue("m2");
            sheet.Rows[2]["AG"].SetValue("m2");

            //ASP포장
            sheet.Rows[0]["AJ"].SetValue("ASP 포장");
            sheet.MergeCells(sheet.Range["AJ1:AN1"]);
            sheet.Rows[1]["AJ"].SetValue("절단");
            sheet.Rows[1]["AK"].SetValue("깨기 및 복구");
            sheet.MergeCells(sheet.Range["AK2:AL2"]);
            sheet.Rows[2]["AK"].SetValue("m2");
            sheet.Rows[2]["AL"].SetValue("m2");

            sheet.Rows[1]["AM"].SetValue("보조기층");
            sheet.MergeCells(sheet.Range["AM2:AN2"]);
            sheet.Rows[2]["AM"].SetValue("m2");
            sheet.Rows[2]["AN"].SetValue("m2");

            //CON'C 포장
            sheet.Rows[0]["AQ"].SetValue("CON'C 포장");
            sheet.MergeCells(sheet.Range["AQ1:AU1"]);
            sheet.Rows[1]["AQ"].SetValue("절단");
            sheet.Rows[1]["AR"].SetValue("깨기 및 복구");
            sheet.MergeCells(sheet.Range["AR2:AS2"]);
            sheet.Rows[2]["AR"].SetValue("m2");
            sheet.Rows[2]["AS"].SetValue("m2");

            sheet.Rows[1]["AT"].SetValue("보조기층");
            sheet.MergeCells(sheet.Range["AT2:AU2"]);
            sheet.Rows[2]["AT"].SetValue("m2");
            sheet.Rows[2]["AU"].SetValue("m2");

            //ASP + CON'C 포장
            sheet.Rows[0]["AV"].SetValue("ASP+CON'C 포장");
            sheet.MergeCells(sheet.Range["AV1:AZ1"]);
            sheet.Rows[1]["AV"].SetValue("절단");
            sheet.Rows[1]["AW"].SetValue("깨기 및 복구");
            sheet.MergeCells(sheet.Range["AW2:AX2"]);
            sheet.Rows[2]["AW"].SetValue("m2");
            sheet.Rows[2]["AX"].SetValue("m2");

            sheet.Rows[1]["AY"].SetValue("보조기층");
            sheet.MergeCells(sheet.Range["AY2:AZ2"]);
            sheet.Rows[2]["AY"].SetValue("m2");
            sheet.Rows[2]["AZ"].SetValue("m2");

            //투수콘 포장
            sheet.Rows[0]["BA"].SetValue("투수콘 포장");
            sheet.MergeCells(sheet.Range["BA1:BG1"]);
            sheet.Rows[1]["BA"].SetValue("절단");
            sheet.Rows[1]["BB"].SetValue("깨기 및 복구");
            sheet.MergeCells(sheet.Range["BB2:BC2"]);
            sheet.Rows[2]["BB"].SetValue("m2");
            sheet.Rows[2]["BC"].SetValue("m2");

            sheet.Rows[1]["BD"].SetValue("보조기층");
            sheet.MergeCells(sheet.Range["BD2:BE2"]);
            sheet.Rows[2]["BD"].SetValue("m2");
            sheet.Rows[2]["BE"].SetValue("m2");

            sheet.Rows[1]["BF"].SetValue("모래");
            sheet.MergeCells(sheet.Range["BF2:BG2"]);
            sheet.Rows[2]["BF"].SetValue("m2");
            sheet.Rows[2]["BG"].SetValue("m2");

            //보도블럭 포장
            sheet.Rows[0]["BH"].SetValue("보도블럭 포장");
            sheet.MergeCells(sheet.Range["BH1:BM1"]);
            sheet.Rows[1]["BH"].SetValue("헐기 및 복구");
            sheet.MergeCells(sheet.Range["BH2:BI2"]);
            sheet.Rows[2]["BH"].SetValue("m2");
            sheet.Rows[2]["BI"].SetValue("m2");

            sheet.Rows[1]["BJ"].SetValue("석분");
            sheet.MergeCells(sheet.Range["BJ2:BK2"]);
            sheet.Rows[2]["BJ"].SetValue("m2");
            sheet.Rows[2]["BK"].SetValue("m2");

            sheet.Rows[1]["BL"].SetValue("보조기층");
            sheet.MergeCells(sheet.Range["BL2:BM2"]);
            sheet.Rows[2]["BL"].SetValue("m2");
            sheet.Rows[2]["BM"].SetValue("m2");

            //sheet.Rows[1]["Y"].SetValue("관상단(토사)");
            //sheet.MergeCells(sheet.Range["Y2:Z2"]);
            //sheet.Rows[2]["Y"].SetValue("m2");
            //sheet.Rows[2]["Z"].SetValue("m2");

            //sheet.Rows[0]["M"].SetValue("수중(토사)");
            //sheet.Rows[0]["W"].SetValue("관주위");
            //sheet.Rows[0]["Y"].SetValue("관상부");
            //sheet.Rows[0]["AA"].SetValue("모래부설");

            //sheet.Rows[0]["AJ"].SetValue("ASP절단");
            //sheet.Rows[0]["AK"].SetValue("ASP");
            //sheet.Rows[0]["AM"].SetValue("보조기층");
            //sheet.Rows[0]["AR"].SetValue("CONC");
            //sheet.Rows[0]["AT"].SetValue("보조기층");

            //sheet.Rows[0]["BH"].SetValue("보도블럭");
            //sheet.Rows[0]["BL"].SetValue("보조기층");
            //sheet.Rows[0]["BN"].SetValue("덧씌우기");
            //sheet.Rows[0]["BS"].SetValue("굴착장비");

            foreach (DataRow Row in dt.Rows)
            {
                nCol = 0;

                if (nLine != Row["LINE"].ToString())
                {
                    nLine = Row["LINE"].ToString();

                    sheet.Rows[nIndex]["C"].SetValue(Row["LINE"].ToString() + " LINE");
                    nIndex++;
                }

                nLine = Row["LINE"].ToString();
                //sheet.Cells[nIndex, nCol].SetValue(Row["LINE"].ToString());

                sheet.Rows[nIndex]["C"].SetValue(Row["LINENAME"].ToString());

                string[] sss = GetPoint(Row["NO"].ToString());

                //측점 출력
                sheet.Rows[nIndex]["D"].SetValue("No.");
                sheet.Rows[nIndex]["E"].SetValue(Convert.ToDecimal(sss[0]));
                //sheet.Rows[nIndex]["F"].SetValue(sss[1]);
                sheet.Rows[nIndex]["F"].SetValue("+");

                sheet.Rows[nIndex]["G"].SetValue(Convert.ToDecimal(sss[2]));
                sheet.Rows[nIndex]["H"].SetValue(sss[3]);

                sheet.Rows[nIndex]["I"].SetValue(Convert.ToDecimal(Row["누가거리"])); //누가거리 I

                if (Convert.ToDecimal(sss[2]) < 0)
                {
                    string abab = "";
                }

                if (Convert.ToDecimal(Row["누가거리"]) == 0)
                {
                    sheet.Rows[nIndex]["J"].SetValue(0); //거리
                }
                else
                {
                    sheet.Rows[nIndex]["J"].Formula = String.Format("= I{0} - I{1}", nIndex + 1, nIndex);
                }

                sheet.Rows[nIndex]["K"].SetValue(Convert.ToDecimal(Row["육상(토사)"]));
                sheet.Rows[nIndex]["L"].Formula = String.Format("= ROUND((K{0}+K{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);  //ROUND((K4+K5)/2*$J5,2)

                sheet.Rows[nIndex]["M"].SetValue(Convert.ToDecimal(Row["수중(토사)"]));
                sheet.Rows[nIndex]["N"].Formula = String.Format("= ROUND((M{0}+M{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);  //ROUND((K4+K5)/2*$J5,2)
                sheet.Rows[nIndex]["W"].SetValue(Convert.ToDecimal(Row["관주위"]));
                sheet.Rows[nIndex]["X"].Formula = String.Format("= ROUND((W{0}+W{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);  //ROUND((K4+K5)/2*$J5,2)
                sheet.Rows[nIndex]["Y"].SetValue(Convert.ToDecimal(Row["관상부"]));
                sheet.Rows[nIndex]["Z"].Formula = String.Format("= ROUND((Y{0}+Y{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);  //ROUND((K4+K5)/2*$J5,2)
                sheet.Rows[nIndex]["AA"].SetValue(Convert.ToDecimal(Row["모래부설"]));
                sheet.Rows[nIndex]["AB"].Formula = String.Format("= ROUND((AA{0}+AA{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);  //ROUND((K4+K5)/2*$J5,2)

                //ASP절단
                sheet.Rows[nIndex]["AJ"].Formula = String.Format("= IF(AK{0} = 0, 0, $J{1} *2)", nIndex + 1, nIndex + 1); // = IF(AD5 = 0, 0,$J5 * 2)

                if (Row["ASP"].ToString().Trim() != "")
                {
                    //ASP 깨기 및 복구
                    if (Convert.ToDecimal(Row["ASP"]) > 0)
                    {
                        sheet.Rows[nIndex]["AK"].SetValue(Convert.ToDecimal(Row["ASP"])); // ROUND((K4+K5)/2*$J5,2)
                        sheet.Rows[nIndex]["AL"].Formula = String.Format("= ROUND((AK{0}+AK{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);

                        sheet.Rows[nIndex]["AM"].SetValue(Convert.ToDecimal(Row["보조기층"]));
                        sheet.Rows[nIndex]["AN"].Formula = String.Format("= ROUND((AM{0}+AM{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);
                    }
                }
                //conc
                sheet.Rows[nIndex]["AQ"].Formula = String.Format("= IF(AR{0} = 0, 0, $J{1} *2)", nIndex + 1, nIndex + 1); // = IF(AD5 = 0, 0,$J5 * 2)

                if (Row["CONC"].ToString().Trim() != "")
                {
                    if (Convert.ToDecimal(Row["CONC"]) > 0)
                    {
                        sheet.Rows[nIndex]["AR"].SetValue(Convert.ToDecimal(Row["CONC"])); // ROUND((K4+K5)/2*$J5,2)
                        sheet.Rows[nIndex]["AS"].Formula = String.Format("= ROUND((AR{0}+AR{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);

                        sheet.Rows[nIndex]["AT"].SetValue(Convert.ToDecimal(Row["보조기층"]));
                        sheet.Rows[nIndex]["AU"].Formula = String.Format("= ROUND((AT{0}+AT{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);
                    }
                }

                //덧씌우기가 asp+con 이란다
                sheet.Rows[nIndex]["AV"].Formula = String.Format("= IF(AW{0} = 0, 0, $J{1} *2)", nIndex + 1, nIndex + 1); // = IF(AD5 = 0, 0,$J5 * 2)

                if (Row["덧씌우기"].ToString().Trim() != "")
                {
                    sheet.Rows[nIndex]["AW"].SetValue(Convert.ToDecimal(Row["덧씌우기"])); // ROUND((K4+K5)/2*$J5,2)
                    sheet.Rows[nIndex]["AX"].Formula = String.Format("= ROUND((AW{0}+AW{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);

                    sheet.Rows[nIndex]["AY"].SetValue(Convert.ToDecimal(Row["보조기층"])); // ROUND((K4+K5)/2*$J5,2)
                    sheet.Rows[nIndex]["AZ"].Formula = String.Format("= ROUND((AY{0}+AY{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);
                }

                //보도블럭
                if (Row["보도블럭"].ToString().Trim() != "")
                {
                    if (Convert.ToDecimal(Row["보도블럭"]) > 0)
                    {
                        sheet.Rows[nIndex]["BH"].SetValue(Convert.ToDecimal(Row["보도블럭"])); // ROUND((K4+K5)/2*$J5,2)
                        sheet.Rows[nIndex]["BI"].Formula = String.Format("= ROUND((BH{0}+BH{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);
                        sheet.Rows[nIndex]["BJ"].Formula = String.Format("= BH{0}*0.04", nIndex);
                        sheet.Rows[nIndex]["BK"].Formula = String.Format("= ROUND((BJ{0}+BJ{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);

                        sheet.Rows[nIndex]["BL"].SetValue(Convert.ToDecimal(Row["보조기층"]));
                        sheet.Rows[nIndex]["BM"].Formula = String.Format("= ROUND((BL{0}+BL{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);
                    }
                }

                //장비
                //sheet.Rows[nIndex]["BS"].SetValue(Row["Column3"].ToString());
                sheet.Rows[nIndex]["BS"].SetValue(Row["굴착장비"].ToString());

                //sheet.Cells[nIndex, nCol++].SetValue(Row["지반고"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["관저고"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["계획고"].ToString());

                //sheet.Cells[nIndex, nCol++].SetValue(Row["육상(풍화암)"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["육상(연암)"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["수중(토사)"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["수중(풍화암)"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["수중(연암)"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["관상부"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["관주위"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["ASP"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["CONC"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["덧씌우기"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["보도블럭"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["모래부설"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["보조기층"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["동상방지층"].ToString());
                //sheet.Cells[nIndex, nCol++].Formula = String.Format("ROUND((D{0}+D{1})/2*$D{2},2)", nIndex, nIndex, nIndex);

                nIndex++;
            }

            string strRange;
            strRange = string.Format("A1:ST{0}", nIndex + 1);
            sheet.Range[strRange].AutoFitColumns();

            string sRange = string.Format("{0}{1}:{2}{3}", "A", 2, "BT", nIndex + 1);
            CellRange body_range = sheet.Range[sRange];
            CUtil.setSheetBodyFormat(body_range, "맑은 고딕", 9);

            workbook.EndUpdate();
        }



        /// <summary>
        /// 간이 흙막이 조서를 출력한다.
        /// </summary>
        /// <param name="dt"></param>
        public void Print간이흙막이연장조서(IWorkbook workbook)
        {
            //간이흙막이연장조서는 말그대로 가시설에만 해당 되므로 그에 대한 데이터만 찾자.
            DataTable dt = MainData.Tables[CGetTableType.tbl_토적표기초데이터].Copy();

            DataRow[] drs = dt.Select("SUBSTRING(구간, 1, 3) = 'GA' ");

            foreach (DataRow item in drs)
            {
                dt.Rows.Remove(item);
            }


            //var qry = from a in dt.AsEnumerable()
            //          where a.Field<string>("구간").ToString().Substring(0, 2).ToUpper() == "GA"
            //          select a;


            //dt = CUtil.LinqQueryToDataTable(qry);

            if (workbook.Worksheets.Contains("간이흙막이연장조서") == true)
            {
                workbook.Worksheets.Remove(workbook.Worksheets["간이흙막이연장조서"]);
            }

            Worksheet sheet = workbook.Worksheets.Add();
            sheet.Name = "간이흙막이연장조서";

            workbook.BeginUpdate();

            //LINENAME NO	지반고	관저고	계획고	육상(토사)	육상(풍화암)	육상(연암)	수중(토사)	수중(풍화암)	수중(연암)	관상부
            //관주위	ASP	CONC	덧씌우기	보도블럭	모래부설	보조기층	동상방지층 , 구간, 관경

            int nIndex = 1;
            int nCol = 0;

            string nLine = "";

            //Header Font 설정
            CellRange range = sheet.Range["A1:Q1"];
            CUtil.setSheetHeaderFormat(range, "맑은 고딕", 10);

            sheet.Rows[0]["A"].SetValue("LINENAME");
            sheet.Rows[0]["B"].SetValue("관경");
            sheet.Rows[0]["C"].SetValue("측점");
            sheet.MergeCells(sheet.Range["C1:F1"]);
            sheet.Rows[0]["G"].SetValue("누가거리");
            sheet.Rows[0]["H"].SetValue("구간거리");
            sheet.Rows[0]["I"].SetValue("지반고");
            sheet.Rows[0]["J"].SetValue("관저고");
            sheet.Rows[0]["K"].SetValue("H");
            sheet.Rows[0]["L"].SetValue("굴착고(H + 0.1)");
            sheet.Rows[0]["M"].SetValue("L X H");
            sheet.Rows[0]["N"].SetValue("굴착폭");
            sheet.Rows[0]["O"].SetValue("가시설");
            sheet.Rows[0]["P"].SetValue("규격");
            sheet.Rows[0]["Q"].SetValue("비고");

            foreach (DataRow Row in dt.Rows)
            {
                nCol = 0;

                if (nLine != Row["LINE"].ToString())
                {
                    nLine = Row["LINE"].ToString();

                    sheet.Rows[nIndex]["A"].SetValue(Row["LINE"].ToString() + " LINE");
                    nIndex++;
                }

                nLine = Row["LINE"].ToString();
                //sheet.Cells[nIndex, nCol].SetValue(Row["LINE"].ToString());

                if (Row["구간"].ToString().Substring(0, 2).ToUpper() != "GA")
                {
                    continue;
                }

                sheet.Rows[nIndex]["A"].SetValue(Row["LINENAME"].ToString());

                string[] sss = GetPoint(Row["NO"].ToString());

                //측점 출력
                sheet.Rows[nIndex]["B"].SetValue(Convert.ToDecimal(Row["관경"]));

                sheet.Rows[nIndex]["C"].SetValue(Convert.ToDecimal(sss[0]));

                //sheet.Rows[nIndex]["D"].SetValue(sss[1]);
                sheet.Rows[nIndex]["D"].SetValue("+");

                sheet.Rows[nIndex]["E"].SetValue(Convert.ToDecimal(sss[2]));
                sheet.Rows[nIndex]["F"].SetValue(sss[3]);

                sheet.Rows[nIndex]["G"].SetValue(Convert.ToDecimal(Row["누가거리"])); //누가거리 I

                ///후단면이면 구간거리를 0으로 처리
                if (sss[3].ToString() == "(후)")
                {
                    sheet.Rows[nIndex]["H"].SetValue(0);
                }
                else
                {
                    sheet.Rows[nIndex]["H"].Formula = String.Format("= G{0} - G{1}", nIndex + 1, nIndex); //구간거리
                }

                sheet.Rows[nIndex]["I"].SetValue(Convert.ToDecimal(Row["지반고"])); //
                sheet.Rows[nIndex]["J"].SetValue(Convert.ToDecimal(Row["관저고"])); //I
                sheet.Rows[nIndex]["K"].Formula = String.Format("= I{0} - J{1}", nIndex + 1, nIndex + 1); //H
                sheet.Rows[nIndex]["L"].Formula = String.Format("= K{0} +0.1", nIndex + 1); //H
                sheet.Rows[nIndex]["M"].Formula = String.Format("= H{0} *L{1}", nIndex + 1, nIndex + 1); //H

                //= IF(AND(B21 >= 150, B21 <= 200), 1.2, B21 / 1000 + 1)
                sheet.Rows[nIndex]["N"].Formula = String.Format("= IF(AND(B{0} >= 150, B{1} <= 200), 1.2, B{2} / 1000 + 1)", nIndex + 1, nIndex + 1, nIndex + 1);

                //갑자기 수식에 의한 계산이 참조 되지 않음 (동일 행 처리시)
                decimal iVal = Convert.ToDecimal(sheet.Rows[nIndex]["I"].Value.ToString());
                decimal jVal = Convert.ToDecimal(sheet.Rows[nIndex]["J"].Value.ToString());
                decimal LVal = iVal - jVal + Convert.ToDecimal(0.1);

                //=IF(AND(L21>4,S21="가시설"),"조절식간이흙막이",IF(S21="가시설","조립식간이흙막이",""))
                //string as1 = sheet.Rows[nIndex]["L"].Value.ToString();

                if (LVal > 4)
                {
                    sheet.Rows[nIndex]["O"].SetValue("조절식간이흙막이");
                }
                else
                {
                    sheet.Rows[nIndex]["O"].SetValue("조립식간이흙막이");
                }

                //=IFERROR(IF(FIND("흙막이",O21)>=1,IF(L21<=3,"300형",IF(AND(L21>3,L21<=4),"400형",IF(AND(L21>4,L21<=5),"500형",IF(AND(L21>5,L21<=6),"600형",IF(AND(L21>6,L21<=7),"700형")))))),"")

                //string as2 = sheet.Rows[nIndex]["L"].Value.ToString();
                //decimal rrr = Convert.ToDecimal(as2);

                if (LVal <= 3)
                {
                    sheet.Rows[nIndex]["P"].SetValue("300형");
                }
                else if (LVal > 3 && LVal <= 4)
                {
                    sheet.Rows[nIndex]["P"].SetValue("400형");
                }
                else if (LVal > 4 && LVal <= 5)
                {
                    sheet.Rows[nIndex]["P"].SetValue("500형");
                }
                else if (LVal > 5 && LVal <= 6)
                {
                    sheet.Rows[nIndex]["P"].SetValue("600형");
                }
                else if (LVal > 6 && LVal <= 7)
                {
                    sheet.Rows[nIndex]["P"].SetValue("700형");
                }

                nIndex++;
            }

            string strRange;
            strRange = string.Format("A1:Q{0}", nIndex + 1);
            sheet.Range[strRange].AutoFitColumns();

            //Body Font 설정
            string sRange;
            sRange = string.Format("{0}{1}:{2}{3}", "A", "2", "Q", nIndex + 1);
            CellRange body_range = sheet.Range[sRange];
            CUtil.setSheetBodyFormat(body_range, "맑은 고딕", 9);

            workbook.EndUpdate();
        }



        /// <summary>
        /// 맨호 조서를 출력한다.
        /// </summary>
        /// <param name="dt"></param>
        public void Print맨홀조서(IWorkbook workbook)
        {

            DataTable dt = MainData.Tables[CGetTableType.tbl_토적표기초데이터].Copy();
            ///맨홀조서니까 맨홀만 필요해요
            ///맨홀규격이 있는 애들만 찾아요

            //where(parentCategoryId != null ? c.ParenCategoryId == parentCategoryId : c.ParenCategoryId == null)
            //(c.ResourcesName == null ? "" : c.ResourcesName).Contains(this.txtSearchString.Text)

            DataRow[] drs = dt.Select("맨홀규격 is null ");


            foreach (DataRow item in drs)
            {
                dt.Rows.Remove(item);
            }

            //var qry = from a in tmp_dt.AsEnumerable()
            //          where a.Field<string>("맨홀규격").ToString()  == null ? "" : a.Field<string>("맨홀규격").ToString() 
            //          select a;

            //if (qry.Count() == 0 || qry == null)
            //{
            //    return;
            //}

            //DataTable dt = CUtil.LinqQueryToDataTable(qry);


            if (workbook.Worksheets.Contains("맨홀조서") == true)
            {
                workbook.Worksheets.Remove(workbook.Worksheets["맨홀조서"]);
            }

            Worksheet sheet = workbook.Worksheets.Add();
            sheet.Name = "맨홀조서";

            workbook.BeginUpdate();

            //LINENAME NO	지반고	관저고	계획고	육상(토사)	육상(풍화암)	육상(연암)	수중(토사)	수중(풍화암)	수중(연암)	관상부
            //관주위	ASP	CONC	덧씌우기	보도블럭	모래부설	보조기층	동상방지층 , 구간, 관경

            int nIndex = 1;
            int nCol = 0;

            string nLine = "";

            //Header Font 설정
            CellRange range = sheet.Range["A1:L1"];
            CUtil.setSheetHeaderFormat(range, "맑은 고딕", 10);

            sheet.Rows[0]["B"].SetValue("LINENAME");
            sheet.Rows[0]["C"].SetValue("지반고");
            sheet.Rows[0]["D"].SetValue("관저고");
            sheet.Rows[0]["E"].SetValue("L.W.L(c)");
            sheet.Rows[0]["F"].SetValue("높이(H)(a - b)");
            sheet.Rows[0]["G"].SetValue("내부높이(h = H - 0.4)");
            sheet.Rows[0]["H"].SetValue("터파기높이(H + 0.4)");
            sheet.Rows[0]["I"].SetValue("맨홀규격");
            sheet.Rows[0]["J"].SetValue("굴착공법");
            sheet.Rows[0]["k"].SetValue("굴착장비");
            sheet.Rows[0]["L"].SetValue("포장종류");

            foreach (DataRow Row in dt.Rows)
            {
                nCol = 0;

                sheet.Rows[nIndex]["B"].SetValue(Row["LINENAME"].ToString());

                sheet.Rows[nIndex]["C"].SetValue(Convert.ToDecimal(Row["지반고"])); //
                sheet.Rows[nIndex]["D"].SetValue(Convert.ToDecimal(Row["관저고"])); //I
                //=IF(E3=0,C3-D3,C3-E3+0.5)
                //= IF(E3 = 0, F3 - 0.2 - 0.2, F3 - 0.5)
                sheet.Rows[nIndex]["F"].Formula = String.Format("=IF(E{0}=0,C{1}-D{2},C{3}-E{4}+0.5)", nIndex + 1, nIndex + 1, nIndex + 1, nIndex + 1, nIndex + 1); //H
                sheet.Rows[nIndex]["G"].Formula = String.Format("=IF(E{0} = 0, F{1} - 0.2 - 0.2, F{2} - 0.5)", nIndex + 1, nIndex + 1, nIndex + 1); //H
                sheet.Rows[nIndex]["H"].Formula = String.Format("=F{0}+0.4", nIndex + 1); //H
                sheet.Rows[nIndex]["I"].SetValue(Row["맨홀규격"].ToString());
                sheet.Rows[nIndex]["J"].SetValue(Row["굴착공법"].ToString());
                //sheet.Rows[nIndex]["K"].SetValue ( Row["Column3"].ToString());  //굴착장비
                sheet.Rows[nIndex]["K"].SetValue(Row["굴착장비"].ToString());  //굴착장비

                ///포장종류를 표기하는데  인풋데이터와 아웃풋 데이터가 다르다.
                ///나중에 인풋데이터를 수정해야함.
                ///
                string strTmp = "";

                switch (Row["포장종류"].ToString().Trim())
                {
                    case "CONC":
                        strTmp = "CON'C";
                        break;

                    case "ASP+CON":
                        strTmp = "A+C";
                        break;

                    default:
                        strTmp = strTmp;
                        break;
                }

                //sheet.Rows[nIndex]["L"].SetValue(Row["포장종류"].ToString());
                sheet.Rows[nIndex]["L"].SetValue(strTmp);

                nIndex++;
            }

            string strRange;
            strRange = string.Format("B1:L{0}", nIndex + 1);
            sheet.Range[strRange].AutoFitColumns();

            string sRange;
            sRange = string.Format("{0}{1}:{2}{3}", "B", "2", "L", nIndex + 1);
            CellRange body_range = sheet.Range[sRange];
            CUtil.setSheetBodyFormat(body_range, "맑은고딕", 9);

            workbook.EndUpdate();
        }


        /// <summary>
        /// 구조물공맨홀조서를 출력
        /// </summary>
        /// <param name="dt"></param>
        private void Print4(IWorkbook workbook)
        {
            DataTable dt = MainData.Tables[CGetTableType.tbl_토적표기초데이터].Copy();
            ///맨홀조서니까 맨홀만 필요해요
            ///맨홀규격이 있는 애들만 찾아요

            //where(parentCategoryId != null ? c.ParenCategoryId == parentCategoryId : c.ParenCategoryId == null)
            //(c.ResourcesName == null ? "" : c.ResourcesName).Contains(this.txtSearchString.Text)

            DataRow[] drs = dt.Select("맨홀규격 is null ");


            foreach (DataRow item in drs)
            {
                dt.Rows.Remove(item);
            }


            if (workbook.Worksheets.Contains("구조물공맨홀조서") == true)
            {
                workbook.Worksheets.Remove(workbook.Worksheets["구조물공맨홀조서"]);
            }

            Worksheet sheet = workbook.Worksheets.Add();
            sheet.Name = "구조물공맨홀조서";

            workbook.BeginUpdate();

            //LINENAME NO	지반고	관저고	계획고	육상(토사)	육상(풍화암)	육상(연암)	수중(토사)	수중(풍화암)	수중(연암)	관상부
            //관주위	ASP	CONC	덧씌우기	보도블럭	모래부설	보조기층	동상방지층 , 구간, 관경

            int nIndex = 1;
            int nCol = 0;

            string nLine = "";

            int nSeq = 0; //맨홀 순서
            string newLine = "";
            bool bNewLine = false;

            CellRange range = sheet.Range["E1:I1"];
            CUtil.setSheetHeaderFormat(range, "맑은 고딕", 10);

            sheet.Rows[0]["E"].SetValue("맨홀번호");
            sheet.MergeCells(sheet.Range["E1:F1"]);
            sheet.Rows[0]["G"].SetValue("맨홀높이");
            sheet.Rows[0]["H"].SetValue("내부높이");
            sheet.Rows[0]["I"].SetValue("규격");

            foreach (DataRow Row in dt.Rows)
            {
                nCol = 0;

                if (newLine != Row["LINE"].ToString())
                {
                    bNewLine = true;
                    nSeq = 1;
                    sheet.Rows[nIndex]["E"].SetValue(Row["LINE"].ToString());
                }
                else
                {
                    bNewLine = false;
                    nSeq++;
                    sheet.Rows[nIndex]["E"].SetValue("");
                }

                //새로운 라인이면
                newLine = Row["LINE"].ToString();

                //sheet.Rows[nIndex]["F"].SetValue(nSeq);
                sheet.Rows[nIndex]["G"].SetValue(Convert.ToDecimal(Row["지반고"]) - Convert.ToDecimal(Row["관저고"]));

                //sheet.Rows[nIndex]["I"].SetValue(GetManholeType(Row["맨홀규격"].ToString()));

                decimal nnn = 0;
                try
                {
                    nnn = Convert.ToDecimal(GetManholeType(Row["맨홀규격"].ToString()).Substring(0, 1));
                }
                catch (Exception ex)
                {
                    nnn = 0;
                }

                sheet.Rows[nIndex]["I"].SetValue(nnn);

                //sheet.Rows[nIndex]["C"].SetValue(Convert.ToDecimal(Row["지반고"])); //
                //sheet.Rows[nIndex]["D"].SetValue(Convert.ToDecimal(Row["관저고"])); //I
                ////=IF(E3=0,C3-D3,C3-E3+0.5)
                ////= IF(E3 = 0, F3 - 0.2 - 0.2, F3 - 0.5)
                //sheet.Rows[nIndex]["F"].Formula = String.Format("=IF(E{0}=0,C{1}-D{2},C{3}-E{4}+0.5)", nIndex + 1, nIndex + 1, nIndex + 1, nIndex + 1, nIndex + 1); //H
                //sheet.Rows[nIndex]["G"].Formula = String.Format("=IF(E{0} = 0, F{1} - 0.2 - 0.2, F{2} - 0.5)", nIndex + 1, nIndex + 1, nIndex + 1); //H
                //sheet.Rows[nIndex]["H"].Formula = String.Format("=F{0}+0.4", nIndex + 1); //H
                //sheet.Rows[nIndex]["I"].SetValue(Row["맨홀규격"].ToString());
                //sheet.Rows[nIndex]["J"].SetValue(Row["굴착공법"].ToString());
                //sheet.Rows[nIndex]["K"].SetValue(Row["Column3"].ToString());  //굴착장비
                //sheet.Rows[nIndex]["L"].SetValue(Row["포장종류"].ToString());

                nIndex++;
            }

            string strRange;
            strRange = string.Format("E1:I{0}", nIndex + 1);
            sheet.Range[strRange].AutoFitColumns();

            string sRange;
            sRange = string.Format("{0}{1}:{2}{3}", "E", "2", "I", nIndex + 1);
            CellRange body_range = sheet.Range[sRange];
            CUtil.setSheetBodyFormat(body_range, "맑은고딕", 9);

            workbook.EndUpdate();
        }

        private string GetManholeType(string strType)
        {
            int spos = strType.IndexOf("(");

            strType = strType.Substring(spos, strType.Length - spos);
            strType = strType.Replace("(", "");
            strType = strType.Replace(")", "");
            return strType;
        }



        /// <summary>
        /// 오수관 조서를 출력한다.
        /// </summary>
        public void Proc오수관(IWorkbook workbook)
        {
            double prv_관경 = 0;
            double prv_시점 = 0;
            double prv_종점 = 0;

            double 관경 = 0;
            double 시점 = 0;
            double 종점 = 0;

            DataTable dt_O = new DataTable();
            dt_O.Columns.Add("노선명", typeof(string));
            dt_O.Columns.Add("관종", typeof(string));
            dt_O.Columns.Add("관경", typeof(double));
            dt_O.Columns.Add("시점", typeof(double));
            dt_O.Columns.Add("종점", typeof(double));

            if (workbook.Worksheets.Contains("오수관조서") == true)
            {
                workbook.Worksheets.Remove(workbook.Worksheets["오수관조서"]);
            }

            Worksheet sheet = workbook.Worksheets.Add();
            sheet.Name = "오수관조서";

            workbook.BeginUpdate();

            int start_idx = 3;

            int cur_idx = start_idx;

            string LineName = "";
            string 관종 = "";

            //Header Font 설정
            CellRange range = sheet.Range["A1:M3"];
            CUtil.setSheetHeaderFormat(range, "맑은 고딕", 10);

            sheet.Rows[0]["A"].SetValue("오수관 조서");

            sheet.Rows[1]["A"].SetValue("노선명");
            sheet.Rows[1]["B"].SetValue("관종");
            sheet.Rows[1]["C"].SetValue("관경");
            sheet.Rows[2]["C"].SetValue("(mm)");
            sheet.MergeCells(sheet.Range["D2:k2"]);
            sheet.Rows[1]["D"].SetValue("측   점");

            sheet.MergeCells(sheet.Range["D3:G3"]);
            sheet.Rows[2]["D"].SetValue("시   점");

            sheet.MergeCells(sheet.Range["H3:K3"]);
            sheet.Rows[2]["H"].SetValue("시   점");

            sheet.Rows[1]["L"].SetValue("연장");
            sheet.Rows[2]["L"].SetValue("(m)");

            sheet.MergeCells(sheet.Range["M2:M3"]);
            sheet.Rows[1]["M"].SetValue("비고");

            foreach (DataRow item in MainData.Tables["SHEET_INFO"].Rows)
            {
                LineName = item["SHEET_NAME"].ToString() + " LINE";
                관종 = item["PIPE_TYPE"].ToString();

                foreach (DataRow row in MainData.Tables[item["SHEET_NAME"].ToString()].Rows)
                {
                    if (start_idx == cur_idx)
                    {
                        //그럼 첫 데이터라는 뜻이니까... 그냥 작성
                        sheet.Rows[cur_idx]["A"].SetValue(LineName);
                        sheet.Rows[cur_idx]["B"].SetValue(관종);
                        sheet.Rows[cur_idx]["C"].SetValue(row["관경"]);
                        sheet.Rows[cur_idx]["D"].SetValue("No.");
                        sheet.Rows[cur_idx]["E"].SetValue(0);
                        sheet.Rows[cur_idx]["F"].SetValue("+");
                        sheet.Rows[cur_idx]["G"].SetValue(Convert.ToDouble("0.0"));
                        sheet.Rows[cur_idx]["H"].SetValue("No.");
                        decimal q = 0;
                        q = Math.Truncate(Convert.ToDecimal(row["누가거리"]) / 20);
                        sheet.Rows[cur_idx]["I"].SetValue(q);
                        sheet.Rows[cur_idx]["J"].SetValue("+");

                        double qq = 0.0;
                        qq = Convert.ToDouble(row["누가거리"]) % 20;
                        sheet.Rows[cur_idx]["K"].SetValue(qq);

                        //연장
                        double dLen = 0.0;
                        dLen = (Convert.ToDouble(sheet.Rows[cur_idx]["I"].Value.ToString()) * 20 + Convert.ToDouble(sheet.Rows[cur_idx]["K"].Value.ToString())) -
                              (Convert.ToDouble(sheet.Rows[cur_idx]["E"].Value.ToString()) * 20 + Convert.ToDouble(sheet.Rows[cur_idx]["G"].Value.ToString()));
                        sheet.Rows[cur_idx]["L"].SetValue(dLen);

                        start_idx = -999; //시작점이 달라졋다는 의미

                        continue;
                    }
                    else
                    {
                        /// 이전 라인과 라인이 같고 관경이 같으면 갱신

                        if (sheet.Rows[cur_idx][0].Value.ToString() == LineName &&
                            sheet.Rows[cur_idx][2].Value.ToString() == row["관경"].ToString())
                        {
                            //sheet.Rows[cur_idx]["A"].SetValue(LineName);
                            //sheet.Rows[cur_idx]["B"].SetValue(관종);
                            //sheet.Rows[cur_idx]["C"].SetValue(row["관경"]);
                            //sheet.Rows[cur_idx]["D"].SetValue("No.");
                            //sheet.Rows[cur_idx]["E"].SetValue(sheet.Rows[cur_idx-1]["I"].Value.ToString());
                            //sheet.Rows[cur_idx]["F"].SetValue("+");
                            //sheet.Rows[cur_idx]["G"].SetValue(sheet.Rows[cur_idx-1]["K"].Value.ToString());

                            sheet.Rows[cur_idx]["H"].SetValue("No.");
                            decimal q = 0;
                            q = Math.Truncate(Convert.ToDecimal(row["누가거리"]) / 20);
                            sheet.Rows[cur_idx]["I"].SetValue(q);
                            sheet.Rows[cur_idx]["J"].SetValue("+");

                            double qq = 0.0;
                            qq = Convert.ToDouble(row["누가거리"]) % 20;
                            sheet.Rows[cur_idx]["K"].SetValue(qq);

                            //연장
                            double dLen = 0.0;
                            dLen = (Convert.ToDouble(sheet.Rows[cur_idx]["I"].Value.ToString()) * 20 + Convert.ToDouble(sheet.Rows[cur_idx]["K"].Value.ToString())) -
                                   (Convert.ToDouble(sheet.Rows[cur_idx]["E"].Value.ToString()) * 20 + Convert.ToDouble(sheet.Rows[cur_idx]["G"].Value.ToString()));
                            sheet.Rows[cur_idx]["L"].SetValue(dLen);

                            //cur_idx++;
                            continue;
                        }
                        else  //추가의 대상
                        {
                            //라인이 같은데 관경이 다른 경우
                            if (sheet.Rows[cur_idx][0].Value.ToString() == LineName &&
                                sheet.Rows[cur_idx][2].Value.ToString() != row["관경"].ToString())
                            {
                                cur_idx++;
                                sheet.Rows[cur_idx]["A"].SetValue(LineName);
                                sheet.Rows[cur_idx]["B"].SetValue(관종);
                                sheet.Rows[cur_idx]["C"].SetValue(row["관경"]);
                                sheet.Rows[cur_idx]["D"].SetValue("No.");
                                sheet.Rows[cur_idx]["E"].SetValue(Convert.ToInt32(sheet.Rows[cur_idx - 1]["I"].Value.ToString()));
                                sheet.Rows[cur_idx]["F"].SetValue("+");
                                sheet.Rows[cur_idx]["G"].SetValue(Convert.ToDouble(sheet.Rows[cur_idx - 1]["K"].Value.ToString()));
                                sheet.Rows[cur_idx]["I"].SetValue(0);
                                sheet.Rows[cur_idx]["K"].SetValue(0.0);

                                //연장
                                double dLen = 0.0;
                                dLen = (Convert.ToDouble(sheet.Rows[cur_idx]["I"].Value.ToString()) * 20 + Convert.ToDouble(sheet.Rows[cur_idx]["K"].Value.ToString())) -
                                       (Convert.ToDouble(sheet.Rows[cur_idx]["E"].Value.ToString()) * 20 + Convert.ToDouble(sheet.Rows[cur_idx]["G"].Value.ToString()));
                                sheet.Rows[cur_idx]["L"].SetValue(dLen);

                                continue;
                            }
                            else  //요기는 라인도 관경도 다른 경우 새로운 시트
                            {
                                cur_idx++;
                                sheet.Rows[cur_idx]["A"].SetValue(LineName);
                                sheet.Rows[cur_idx]["B"].SetValue(관종);
                                sheet.Rows[cur_idx]["C"].SetValue(row["관경"]);
                                sheet.Rows[cur_idx]["D"].SetValue("No.");
                                sheet.Rows[cur_idx]["E"].SetValue(0);
                                sheet.Rows[cur_idx]["F"].SetValue("+");
                                sheet.Rows[cur_idx]["G"].SetValue(Convert.ToDouble("0.0"));
                                sheet.Rows[cur_idx]["H"].SetValue("No.");
                                decimal q = 0;
                                q = Math.Truncate(Convert.ToDecimal(row["누가거리"]) / 20);
                                sheet.Rows[cur_idx]["I"].SetValue(q);
                                sheet.Rows[cur_idx]["J"].SetValue("+");

                                double qq = 0.0;
                                qq = Convert.ToDouble(row["누가거리"]) % 20;
                                sheet.Rows[cur_idx]["K"].SetValue(qq);

                                //연장
                                double dLen = 0.0;
                                dLen = (Convert.ToDouble(sheet.Rows[cur_idx]["I"].Value.ToString()) * 20 + Convert.ToDouble(sheet.Rows[cur_idx]["K"].Value.ToString())) -
                                       (Convert.ToDouble(sheet.Rows[cur_idx]["E"].Value.ToString()) * 20 + Convert.ToDouble(sheet.Rows[cur_idx]["G"].Value.ToString()));
                                sheet.Rows[cur_idx]["L"].SetValue(dLen);

                                continue;
                            }

                            MessageBox.Show("오수관 데이터중 일부가 누락되었습니다.");
                            continue;
                        }
                    }

                    cur_idx++;
                }

                //요기서는 당연히 노선(sheet)가 바뀌니까.. 증가
                //cur_idx++;
            }

            string strRange;
            strRange = string.Format("A4:M{0}", cur_idx + 1);
            sheet.Range[strRange].AutoFitColumns();

            string sBodyRange = string.Format("{0}{1}:{2}{3}", "A", 4, "M", cur_idx + 1);
            CellRange body_range = sheet.Range[sBodyRange];
            CUtil.setSheetBodyFormat(body_range, "맑은 고딕", 9);

            workbook.EndUpdate();
        }

        public  void Proc오수관실연장조서(IWorkbook workbook)
        {
            if (workbook.Worksheets.Contains("오수관실연장조서") == true)
            {
                workbook.Worksheets.Remove(workbook.Worksheets["오수관실연장조서"]);
            }

            Worksheet sheet = workbook.Worksheets.Add();
            sheet.Name = "오수관실연장조서";

           

            string LineName;

            var qry = from a in MainData.Tables[CGetTableType.tbl_맨홀구간정보].AsEnumerable()
                      group a by new
                      {
                          LINENAME = a.Field<string>("LINENAME")
                                     ,
                          관종 = a.Field<string>("관종")
                                     ,
                          맨홀규격 = a.Field<string>("맨홀규격")
                                     ,
                          관경 = a.Field<double>("관경")
                          //, 연장 = a.Field<double>("구간거리")
                      } into g
                      select new
                      {
                          LINENAME = g.Key.LINENAME
                          ,
                          관종 = g.Key.관종
                         ,
                          관경 = g.Key.관경
                         ,
                          맨홀규격 = g.Key.맨홀규격
                         ,
                          개소 = g.Count()
                         ,
                          연장 = g.Sum(a => a.Field<double>("구간거리"))
                      };

            DataTable dt = CUtil.LinqQueryToDataTable(qry);

            workbook.BeginUpdate();

            //Header Font 설정
            CellRange range = sheet.Range["A1:K2"];
            CUtil.setSheetHeaderFormat(range, "맑은 고딕", 10);

            sheet.Rows[0]["A"].SetValue("오수관 실제 연장 산정");

            sheet.Rows[1]["A"].SetValue("관로명");
            sheet.Rows[1]["B"].SetValue("관종");
            sheet.Rows[1]["C"].SetValue("관경");
            sheet.MergeCells(sheet.Range["D2:F2"]);
            sheet.Rows[1]["D"].SetValue("맨홀(개소)");
            sheet.Rows[1]["G"].SetValue("연장(m)");

            sheet.Rows[1]["H"].SetValue("맨홀공제(m)");
            sheet.Rows[1]["I"].SetValue("지수단관공제(m)");
            sheet.Rows[1]["J"].SetValue("실연장(m)");
            sheet.Rows[1]["K"].SetValue("비고");

            //Range oRng = sheet.Columns[iColPos];
            //oRng.AutoFitColumns();

            int cur_idx = 2;

            foreach (DataRow item in dt.Rows)
            {
                //그럼 첫 데이터라는 뜻이니까... 그냥 작성
                sheet.Rows[cur_idx]["A"].SetValue(item["LINENAME"]);
                sheet.Rows[cur_idx]["B"].SetValue(item["관종"]);
                sheet.Rows[cur_idx]["C"].SetValue(item["관경"]);
                sheet.Rows[cur_idx]["D"].SetValue(item["맨홀규격"]);
                sheet.Rows[cur_idx]["E"].SetValue("");
                sheet.Rows[cur_idx]["F"].SetValue(item["개소"]);
                sheet.Rows[cur_idx]["G"].SetValue(item["연장"]);

                cur_idx++;
            }
            string strRange;
            strRange = string.Format("A1:K{0}", cur_idx + 1);
            sheet.Range[strRange].AutoFitColumns();

            string sBodyRange = string.Format("{0}{1}:{2}{3}", "A", 2, "K", cur_idx + 1);
            CellRange body_range = sheet.Range[sBodyRange];
            CUtil.setSheetBodyFormat(body_range, "맑은 고딕", 9);

            ///합계
            var qry2 = from a in MainData.Tables[CGetTableType.tbl_맨홀구간정보].AsEnumerable()
                       group a by new
                       {
                           관종 = a.Field<string>("관종")
                                      ,
                           맨홀규격 = a.Field<string>("맨홀규격")
                                      ,
                           관경 = a.Field<double>("관경")
                           //, 연장 = a.Field<double>("구간거리")
                       } into g
                       select new
                       {
                           관종 = g.Key.관종
                          ,
                           관경 = g.Key.관경
                          ,
                           맨홀규격 = g.Key.맨홀규격
                          ,
                           개소 = g.Count()
                          ,
                           연장 = g.Sum(a => a.Field<double>("구간거리"))
                       };

            DataTable dt2 = CUtil.LinqQueryToDataTable(qry2);

            int cur_idx2 = cur_idx + 4;
            int start2 = cur_idx2;
            //Header Font 설정
            //CellRange range2 = sheet.Range["A1:K2"];
            //CUtil.setSheetHeaderFormat(range2, "맑은 고딕", 10);

            //sheet.Rows[0]["A"].SetValue("오수관 실제 연장 산정");

            //sheet.Rows[1]["A"].SetValue("관로명");
            //sheet.Rows[1]["B"].SetValue("관종");
            //sheet.Rows[1]["C"].SetValue("관경");
            //sheet.MergeCells(sheet.Range["D2:F2"]);
            //sheet.Rows[1]["D"].SetValue("맨홀(개소)");
            //sheet.Rows[1]["G"].SetValue("연장(m)");

            //sheet.Rows[1]["H"].SetValue("맨홀공제(m)");
            //sheet.Rows[1]["I"].SetValue("지수단관공제(m)");
            //sheet.Rows[1]["J"].SetValue("실연장(m)");
            //sheet.Rows[1]["K"].SetValue("비고");

            foreach (DataRow item in dt2.Rows)
            {
                //그럼 첫 데이터라는 뜻이니까... 그냥 작성
                sheet.Rows[cur_idx2]["B"].SetValue(item["관종"]);
                sheet.Rows[cur_idx2]["C"].SetValue(item["관경"]);
                sheet.Rows[cur_idx2]["D"].SetValue(item["맨홀규격"]);
                sheet.Rows[cur_idx2]["E"].SetValue("");
                sheet.Rows[cur_idx2]["F"].SetValue(item["개소"]);
                sheet.Rows[cur_idx2]["G"].SetValue(item["연장"]);

                cur_idx2++;
            }

            string tmp;
            tmp = string.Format("A{0}:A{1}", start2 + 1, cur_idx2);
            sheet.MergeCells(sheet.Range[tmp]);
            sheet.Rows[start2]["A"].SetValue("계");
            workbook.EndUpdate();
        }


        /// <summary>
        /// 
        /// </summary>
        public void Proc오수관접합및절단조서(IWorkbook workbook)
        {
            if (workbook.Worksheets.Contains("오수관접합및절단조서") == true)
            {
                workbook.Worksheets.Remove(workbook.Worksheets["오수관접합및절단조서"]);
            }

            Worksheet sheet = workbook.Worksheets.Add();
            sheet.Name = "오수관접합및절단조서";


            string LineName;

            var qry = from a in MainData.Tables[CGetTableType.tbl_맨홀구간정보].AsEnumerable()
                      group a by new
                      {
                          LINENAME = a.Field<string>("LINENAME")
                          ,
                          관경 = a.Field<double>("관경")
                      } into g
                      select new
                      {
                          LINENAME = g.Key.LINENAME
                         ,
                          관경 = g.Key.관경
                      };

            DataTable dt = CUtil.LinqQueryToDataTable(qry);

            //var qryOut = from a in dt.AsEnumerable()
            //             select new
            //             {
            //                 LINENAME = " "
            //                , 관경 = 0.00
            //                , 1_ = 0.00
            //                , 2 = 0.00
            //                ,
            //                 3 = 0.00
            //                ,
            //                 4 = 0.00
            //                ,
            //                 5 = 0.00
            //                ,
            //                 6 = 0.00
            //                ,
            //                 7 = 0.00
            //                ,
            //                 8 = 0.00
            //                ,
            //                 9 = 0.00
            //                ,
            //                 10 = 0.00
            //                 ,
            //                , 직관 = 0
            //                , 소켓 = 0
            //                , 절단 = 0
            //                , 비고 = " "
            //             };

            //DataTable layout_tmp = CUtil.LinqQueryToDataTable(qryOut);
            //DataTable layout_dt = layout_tmp.Clone();

            workbook.BeginUpdate();

            //Header Font 설정
            CellRange range = sheet.Range["A1:P4"];
            CUtil.setSheetHeaderFormat(range, "맑은 고딕", 10);

            sheet.Rows[0]["A"].SetValue("오수관 접합 및 절단 조서");

            sheet.Rows[1]["A"].SetValue("노선명");
            sheet.MergeCells(sheet.Range["A2:A4"]);
            sheet.Rows[1]["B"].SetValue("관경");
            sheet.Rows[2]["B"].SetValue("(mm)");
            sheet.MergeCells(sheet.Range["B3:B4"]);

            sheet.Rows[1]["C"].SetValue("전맨홀~후맨홀 구간 연장");
            sheet.MergeCells(sheet.Range["C2:L2"]);
            sheet.Rows[2]["C"].SetValue("1");
            sheet.MergeCells(sheet.Range["C3:C4"]);
            sheet.Rows[2]["D"].SetValue("2");
            sheet.MergeCells(sheet.Range["D3:D4"]);
            sheet.Rows[2]["E"].SetValue("3");
            sheet.MergeCells(sheet.Range["E3:E4"]);
            sheet.Rows[2]["F"].SetValue("4");
            sheet.MergeCells(sheet.Range["F3:F4"]);
            sheet.Rows[2]["G"].SetValue("5");
            sheet.MergeCells(sheet.Range["G3:G4"]);
            sheet.Rows[2]["H"].SetValue("6");
            sheet.MergeCells(sheet.Range["H3:H4"]);
            sheet.Rows[2]["I"].SetValue("7");
            sheet.MergeCells(sheet.Range["I3:I4"]);
            sheet.Rows[2]["J"].SetValue("8");
            sheet.MergeCells(sheet.Range["J3:J4"]);
            sheet.Rows[2]["K"].SetValue("9");
            sheet.MergeCells(sheet.Range["K3:K4"]);
            sheet.Rows[2]["L"].SetValue("10");
            sheet.MergeCells(sheet.Range["L3:L4"]);

            sheet.Rows[1]["M"].SetValue("직관\n접합\n(편수)");
            sheet.MergeCells(sheet.Range["M2:M3"]);
            sheet.Rows[3]["M"].SetValue("개소");

            sheet.Rows[1]["N"].SetValue("소켓\n접합");
            sheet.MergeCells(sheet.Range["N2:N3"]);
            sheet.Rows[3]["N"].SetValue("개소");

            sheet.Rows[1]["O"].SetValue("관");
            sheet.Rows[2]["O"].SetValue("절단");
            sheet.Rows[3]["O"].SetValue("(개소)");

            sheet.Rows[1]["P"].SetValue("비고");
            sheet.MergeCells(sheet.Range["P2:P4"]);

            int row_idx = 4;

            foreach (DataRow item in dt.Rows)
            {
                var qryTmp = from a in MainData.Tables[CGetTableType.tbl_맨홀구간정보].AsEnumerable()
                             where a.Field<string>("LINENAME") == item["LINENAME"].ToString() &&
                                   a.Field<double>("관경") == Convert.ToDouble(item["관경"])
                             orderby a.Field<double>("종료위치")
                             select new
                             {
                                 LINENAME = a.Field<string>("LINENAME")
                             ,
                                 관경 = a.Field<double>("관경")
                                ,
                                 종료위치 = a.Field<double>("종료위치")
                                ,
                                 구간거리 = a.Field<double>("구간거리")
                             };

                DataTable TmpDt = CUtil.LinqQueryToDataTable(qryTmp);

                int nRecCnt = 0;
                nRecCnt = TmpDt.Rows.Count;

                int col_idx = 0;

                foreach (DataRow dr2 in TmpDt.Rows)
                {
                    sheet.Cells[row_idx, 0].SetValue(dr2["LINENAME"].ToString() + " LINE");
                    sheet.Cells[row_idx, 1].SetValue(dr2["관경"].ToString());
                    sheet.Cells[row_idx, col_idx + 2].SetValue(Convert.ToDouble(dr2["구간거리"]));
                    sheet.Rows[row_idx]["O"].Formula = String.Format("=COUNT(C{0}:L{1})", row_idx + 1, row_idx + 1); //H
                    sheet.Rows[row_idx]["N"].Formula = String.Format("=O{0}", row_idx + 1); //H

                    col_idx++;

                    if (col_idx >= 10)
                    {
                        row_idx++;
                        col_idx = 0;
                    }
                }

                row_idx++;
            }

            string sAutoFit = string.Format("{0}{1}:{2}{3}", "A", 2, "P", row_idx + 1);
            sheet.Range[sAutoFit].AutoFitColumns();

            string sBodyRange = string.Format("{0}{1}:{2}{3}", "A", 5, "P", row_idx + 1);
            CellRange body_range = sheet.Range[sBodyRange];

            CUtil.setSheetBodyFormat(body_range, "맑은 고딕", 9);

            workbook.EndUpdate();
        }
    }
}