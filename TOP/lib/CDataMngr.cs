using System;
using System.Data;

namespace TOP.lib
{
    public class CData포장
    {
        private string 포장종류1;
        private string 굴착공법1;

        public string 포장종류 { get => 포장종류1; set => 포장종류1 = value; }
        public string 굴착공법 { get => 굴착공법1; set => 굴착공법1 = value; }
    }

    public enum enum_포장종류
    {
        OPEN
       , 가시설
    }

    public static class CDataMngr
    {
        public static string[] GetPoint(string data)
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
        /// 토적 Data를 Load해서 필요한 정보를 만들어내요
        /// </summary>
        /// <returns></returns>
        public static DataTable Make토적Data(string sheet_name, DataTable orig)
        {

            DataTable dt = CGetTableType.Get토적DataTable();

            int nIdx = 0;

            try
            {
                foreach (DataRow item in orig.Rows)
                {
                    DataRow Dr = dt.NewRow();

                    Dr[CGetTableType.col_LINENAME] = sheet_name;
                    Dr[CGetTableType.col_INDEX] = nIdx;
                    Dr[CGetTableType.col_NO] = item[CGetTableType.col_NO].ToString();


                    if (item[CGetTableType.col_NO].ToString().Contains("(전)"))
                    {
                        Dr[CGetTableType.col_전후단면_IDX] = 1;
                        Dr[CGetTableType.col_전후단면] = "(전)";
                    }
                    else if (item[CGetTableType.col_NO].ToString().Contains("(후)"))
                    {
                        Dr[CGetTableType.col_전후단면_IDX] = 2;
                        Dr[CGetTableType.col_전후단면] = "(후)";
                    }
                    else
                    {
                        Dr[CGetTableType.col_전후단면_IDX] = 0;
                        Dr[CGetTableType.col_전후단면] = "";
                    }


                    string[] sss = GetPoint(item[CGetTableType.col_NO].ToString());
                    decimal dist = (Convert.ToDecimal(sss[0]) * 20) + Convert.ToDecimal(sss[2]);
                    Dr[CGetTableType.col_누가거리] = dist;
                    Dr[CGetTableType.col_거리] = 0;

                    Dr[CGetTableType.col_지반고] = Convert.ToDecimal((item[CGetTableType.col_지반고] == DBNull.Value) ? 0 : item[CGetTableType.col_지반고]);
                    Dr[CGetTableType.col_관저고] = Convert.ToDecimal((item[CGetTableType.col_관저고] == DBNull.Value) ? 0 : item[CGetTableType.col_관저고]);
                    Dr[CGetTableType.col_계획고] = Convert.ToDecimal((item[CGetTableType.col_계획고] == DBNull.Value) ? 0 : item[CGetTableType.col_계획고]);
                    Dr[CGetTableType.col_육상_토사] = Convert.ToDecimal((item[CGetTableType.col_육상_토사] == DBNull.Value) ? 0 : item[CGetTableType.col_육상_토사]);
                    Dr[CGetTableType.col_육상_풍화암] = Convert.ToDecimal((item[CGetTableType.col_육상_풍화암] == DBNull.Value) ? 0 : item[CGetTableType.col_육상_풍화암]);
                    Dr[CGetTableType.col_육상_연암] = Convert.ToDecimal((item[CGetTableType.col_육상_연암] == DBNull.Value) ? 0 : item[CGetTableType.col_육상_연암]);
                    Dr[CGetTableType.col_수중_토사] = Convert.ToDecimal((item[CGetTableType.col_수중_토사] == DBNull.Value) ? 0 : item[CGetTableType.col_수중_토사]);
                    Dr[CGetTableType.col_수중_풍화암] = Convert.ToDecimal((item[CGetTableType.col_수중_풍화암] == DBNull.Value) ? 0 : item[CGetTableType.col_수중_풍화암]);
                    Dr[CGetTableType.col_수중_연암] = Convert.ToDecimal((item[CGetTableType.col_수중_연암] == DBNull.Value) ? 0 : item[CGetTableType.col_수중_연암]);
                    Dr[CGetTableType.col_관상부] = Convert.ToDecimal((item[CGetTableType.col_관상부] == DBNull.Value) ? 0 : item[CGetTableType.col_관상부]);
                    Dr[CGetTableType.col_관주위] = Convert.ToDecimal((item[CGetTableType.col_관주위] == DBNull.Value) ? 0 : item[CGetTableType.col_관주위]);
                    Dr[CGetTableType.col_ASP] = Convert.ToDecimal((item[CGetTableType.col_ASP] == DBNull.Value) ? 0 : item[CGetTableType.col_ASP]);
                    Dr[CGetTableType.col_CONC] = Convert.ToDecimal((item[CGetTableType.col_CONC] == DBNull.Value) ? 0 : item[CGetTableType.col_CONC]);
                    Dr[CGetTableType.col_덧씌우기] = Convert.ToDecimal((item[CGetTableType.col_덧씌우기] == DBNull.Value) ? 0 : item[CGetTableType.col_덧씌우기]);
                    Dr[CGetTableType.col_보도블럭] = Convert.ToDecimal((item[CGetTableType.col_보도블럭] == DBNull.Value) ? 0 : item[CGetTableType.col_보도블럭]);
                    Dr[CGetTableType.col_모래부설] = Convert.ToDecimal((item[CGetTableType.col_모래부설] == DBNull.Value) ? 0 : item[CGetTableType.col_모래부설]);
                    Dr[CGetTableType.col_보조기층] = Convert.ToDecimal((item[CGetTableType.col_보조기층] == DBNull.Value) ? 0 : item[CGetTableType.col_보조기층]);
                    Dr[CGetTableType.col_동상방지층] = Convert.ToDecimal((item[CGetTableType.col_동상방지층] == DBNull.Value) ? 0 : item[CGetTableType.col_동상방지층]);



                    dt.Rows.Add(Dr);

                    nIdx++;


                    //dt.Columns.Add(col_INDEX, typeof(int));
                    //dt.Columns.Add(col_NO, typeof(string));
                    //dt.Columns.Add(col_전후단면, typeof(string));
                    //dt.Columns.Add(col_전후단면_IDX, typeof(int));
                    //dt.Columns.Add(col_누가거리, typeof(int));
                    //dt.Columns.Add(col_거리, typeof(int));
                    //dt.Columns.Add(col_지반고, typeof(decimal));
                    //dt.Columns.Add(col_관저고, typeof(decimal));
                    //dt.Columns.Add(col_계획고, typeof(decimal));
                    //dt.Columns.Add(col_육상_토사, typeof(decimal));
                    //dt.Columns.Add(col_육상_풍화암, typeof(decimal));
                    //dt.Columns.Add(col_육상_연암, typeof(decimal));
                    //dt.Columns.Add(col_수중_토사, typeof(decimal));
                    //dt.Columns.Add(col_수중_풍화암, typeof(decimal));
                    //dt.Columns.Add(col_수중_연암, typeof(decimal));
                    //dt.Columns.Add(col_관상부, typeof(decimal));
                    //dt.Columns.Add(col_관주위, typeof(decimal));
                    //dt.Columns.Add(col_ASP, typeof(decimal));
                    //dt.Columns.Add(col_CONC, typeof(decimal));
                    //dt.Columns.Add(col_덧씌우기, typeof(decimal));
                    //dt.Columns.Add(col_보도블럭, typeof(decimal));
                    //dt.Columns.Add(col_모래부설, typeof(decimal));
                    //dt.Columns.Add(col_보조기층, typeof(decimal));
                    //dt.Columns.Add(col_동상방지층, typeof(decimal));

                }


                var qry = from a in dt.AsEnumerable()
                          orderby a.Field<int>(CGetTableType.col_INDEX) descending,
                                  a.Field<int>(CGetTableType.col_전후단면_IDX) descending
                          select a;

                DataTable Sort_dt = qry.CopyToDataTable();
               

                int nSortIdx = 0;
                foreach (DataRow item in Sort_dt.Rows)
                {
                    item[CGetTableType.col_INDEX] = nSortIdx;

                    nSortIdx++;
                }

                return Sort_dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }



        public static DataTable SetExtend토적(DataTable orig)
        {
            orig.Columns.Add("누가거리", typeof(double));
            orig.Columns.Add("전후단면정렬", typeof(int));   //전단면 :1  후단면:2

            foreach (DataRow dr in orig.Rows)
            {
                string[] sss = GetPoint(dr["NO"].ToString());

                decimal dist = (Convert.ToDecimal(sss[0]) * 20) + Convert.ToDecimal(sss[2]);

                dr["누가거리"] = dist;

                if (sss[3].ToString().Trim() == "")
                {
                    dr["전후단면정렬"] = 1;
                }
                else if (sss[3].ToString().Trim() == "(전)")
                {
                    dr["전후단면정렬"] = 2;
                }
                else if (sss[3].ToString().Trim() == "(후)")
                {
                    dr["전후단면정렬"] = 3;
                }
            }

            orig.DefaultView.Sort = "누가거리 DESC, 전후 DESC";
            return orig.DefaultView.ToTable();
        }

        /// <summary>
        /// 포장 측점과, 포장명을 기존 파이툴 생성 데이터에 추가해요
        /// 그러면서 row에 Index를 추가해요
        /// </summary>
        /// <param name="orig"></param>
        /// <param name="ext"></param>
        public static DataTable MakePipeToolData(string sheet_name, DataTable orig)
        {

            DataTable dt_tmp = CGetTableType.GetPipeToolTable();
            dt_tmp.TableName = orig.TableName;               

            try
            {
                int nCnt = orig.Rows.Count;
                int nIdx = 0;
                foreach (DataRow item in orig.Rows)
                {

                    DataRow dr = dt_tmp.NewRow();


                    CData포장 data포장 = CDataMngr.Get포장정보(item["구간"].ToString());
                    dr[CGetTableType.col_LINENAME] = sheet_name;
                    dr[CGetTableType.col_INDEX] = nIdx;
                    dr[CGetTableType.col_누가거리] = Convert.ToInt32((item[CGetTableType.col_누가거리] == DBNull.Value) ? 0 : item[CGetTableType.col_누가거리]);    
                    dr[CGetTableType.col_지반고] = Convert.ToDecimal((item[CGetTableType.col_지반고] == DBNull.Value) ? 0 : item[CGetTableType.col_지반고]);   
                    dr[CGetTableType.col_관저고] = Convert.ToDecimal((item[CGetTableType.col_관저고] == DBNull.Value) ? 0 : item[CGetTableType.col_관저고]); 
                    dr[CGetTableType.col_관경] = Convert.ToInt32((item[CGetTableType.col_관경] == DBNull.Value) ? 0 : item[CGetTableType.col_관경]);   
                    dr[CGetTableType.col_맨홀] = item[CGetTableType.col_맨홀].ToString();
                    dr[CGetTableType.col_TEXT1] = item[CGetTableType.col_TEXT1].ToString();
                    dr[CGetTableType.col_TEXT2] = item[CGetTableType.col_TEXT2].ToString();
                    dr[CGetTableType.col_구간] = item[CGetTableType.col_구간].ToString();
                    dr[CGetTableType.col_구배] = Convert.ToDecimal((item[CGetTableType.col_구배] == DBNull.Value) ? 0 : item[CGetTableType.col_구배]);  
                    dr[CGetTableType.col_INV] = Convert.ToDecimal((item[CGetTableType.col_INV] == DBNull.Value) ? 0: item[CGetTableType.col_INV]);
                    dr[CGetTableType.col_SIZE] = Convert.ToDecimal((item[CGetTableType.col_SIZE] == DBNull.Value) ? 0 : item[CGetTableType.col_SIZE]);
                    dr[CGetTableType.col_라인명] = (item[CGetTableType.col_라인명] == DBNull.Value) ? String.Empty : item[CGetTableType.col_라인명].ToString();
                    dr[CGetTableType.col_지하수위] = Convert.ToDecimal((item[CGetTableType.col_지하수위] == DBNull.Value) ? 0 : item[CGetTableType.col_지하수위]);
                    dr[CGetTableType.col_맨홀_INVERT] = Convert.ToDecimal((item[CGetTableType.col_맨홀_INVERT] == DBNull.Value) ? 0 : item[CGetTableType.col_맨홀_INVERT]);

                    dr[CGetTableType.col_굴착공법] = data포장.굴착공법;
                    dr[CGetTableType.col_포장종류] = data포장.포장종류;
                    //col_맨홀규격, col_굴착장비 는 Default 값이 있음 

                    dt_tmp.Rows.Add(dr);

                    nIdx++;

                    //dt.Columns.Add(col_INDEX, typeof(int));
                    //dt.Columns.Add(col_누가거리, typeof(int));
                    //dt.Columns.Add(col_지반고, typeof(decimal));
                    //dt.Columns.Add(col_관저고, typeof(decimal));
                    //dt.Columns.Add(col_관경, typeof(int));
                    //dt.Columns.Add(col_맨홀, typeof(string));
                    //dt.Columns.Add(col_TEXT1, typeof(string));
                    //dt.Columns.Add(col_TEXT2, typeof(string));
                    //dt.Columns.Add(col_구간, typeof(string));
                    //dt.Columns.Add(col_구배, typeof(decimal));
                    //dt.Columns.Add(col_INV, typeof(decimal));
                    //dt.Columns.Add(col_SIZE, typeof(decimal));
                    //dt.Columns.Add(col_라인명, typeof(string));
                    //dt.Columns.Add(col_지하수위, typeof(decimal));
                    //dt.Columns.Add(col_맨홀_INVERT, typeof(decimal));
                    //DataColumn dc;
                    //dc = dt.Columns.Add(col_맨홀규격, typeof(string));
                    //dc.DefaultValue = "원형1호";

                    //dt.Columns.Add(col_굴착공법, typeof(string));
                    //dc = dt.Columns.Add(col_굴착장비, typeof(string));
                    //dc.DefaultValue = "B/H 0.7";

                    //dt.Columns.Add(col_포장종류, typeof(string));

                }

                return dt_tmp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// pipetool 구간정보에서 포장종류와 굴착공법을 찾아낸다.
        /// </summary>
        public static CData포장 Get포장정보(string strData)
        {
            CData포장 data = new CData포장();

            switch (strData.ToUpper())
            {
                case "OP01":   //open 토사
                    data.포장종류 = "토사";
                    data.굴착공법 = "OPEN";
                    break;

                case "OP02":  //open asp
                    data.포장종류 = "ASP";
                    data.굴착공법 = "OPEN";
                    break;

                case "OP03":  //open concrete
                    data.포장종류 = "CON'C";
                    data.굴착공법 = "OPEN";
                    break;

                case "OP04":  //open 보도
                    data.포장종류 = "보도";
                    data.굴착공법 = "OPEN";
                    break;

                case "OP05":   //open asp+concrete
                    //막서에서 표기가 안되므로 콘크리트로 처리함
                    data.포장종류 = "A+C";
                    data.굴착공법 = "OPEN";
                    break;

                case "GA01":
                    data.포장종류 = "토사";
                    data.굴착공법 = "가시설";

                    break;

                case "GA02":
                    data.포장종류 = "ASP";
                    data.굴착공법 = "가시설";
                    break;

                case "GA03":
                    data.포장종류 = "CON'C";
                    data.굴착공법 = "가시설";

                    break;

                case "GA04":
                    data.포장종류 = "보도";
                    data.굴착공법 = "가시설";
                    break;

                case "GA05":
                    //막서에서 표기가 안되므로 콘크리트로 처리함
                    data.포장종류 = "A+C";
                    data.굴착공법 = "가시설";
                    break;

                default:
                    break;
            }

            return data;
        }
    }
}