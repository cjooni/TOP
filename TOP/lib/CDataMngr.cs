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
        /// </summary>
        /// <param name="orig"></param>
        /// <param name="ext"></param>
        public static void SetExtend(DataTable orig)
        {
            DataTable dt_tmp = new DataTable();

            try
            {
                dt_tmp.Columns.Add("맨홀규격", typeof(string));
                dt_tmp.Columns.Add("굴착공법", typeof(string));
                dt_tmp.Columns.Add("굴착장비", typeof(string));
                dt_tmp.Columns.Add("포장종류", typeof(string));

                foreach (DataColumn item in dt_tmp.Columns)
                {
                    orig.Columns.Add(item.ColumnName, typeof(string));
                }

                int nCnt = orig.Rows.Count;

                foreach (DataRow item in orig.Rows)
                {
                    CData포장 data포장 = CDataMngr.Get포장정보(item["구간"].ToString());

                    item["굴착공법"] = data포장.굴착공법;
                    item["포장종류"] = data포장.포장종류;
                    if (item["맨홀"].ToString().Trim() == "" )
                    {
                        item["맨홀규격"] = "";
                        item["굴착장비"] = "";
                    }
                    else
                    {
                        item["맨홀규격"] = "원형1호";
                        item["굴착장비"] = "B/H0.7";
                    }


                    
                }

                for (int i = 0; i < orig.Rows.Count; i++)
                {
                    if (i == 0)
                    {

                    }
                }
                
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