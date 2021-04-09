using System;
using System.Data;

namespace TOP.lib
{
    public static class CGetTableType
    {
        public const string tbl_PIPE_TOOL_INPUT = "PIPETOOL_INPUT";
        public const string tbl_토적표_INPUT = "토적표_INPUT";
        public const string tbl_토적표_BASE = "토적표_BASE";

        /// <summary>
        /// 토적생성용 기초 데이터
        /// PIPETOOL_INPUT 과 토적표 INPUT을 JOIN 해서 만들어요
        /// </summary>
        public const string tbl_토적_BASE = "토적_BASE";

        /// <summary>
        /// 토적생성용 기초 데이터인데요
        /// 기존 frmMass에서 사용하던 형식이에요 이후 근절된 내용이죠
        /// </summary>
        public const string tbl_토적표기초데이터 = "토적표기초데이터";
        public const string tbl_맨홀구간정보 = "맨홀구간정보";
        
        /// <summary>
        /// EXCEL 에서 Load한 Sheet  정보를 관리하는 Table
        /// </summary>
        public const string tbl_SHEET_INFO = "SHEET_INFO";

        /// <summary>
        /// Sheet Name과 동일하다.
        /// </summary>
        public const string col_LINENAME = "LINENAME";   //SheetName 
        public const string col_INDEX = "INDEX";
        public const string col_누가거리 = "누가거리";
        public const string col_거리     = "거리";
        public const string col_지반고   = "지반고";
        public const string col_관저고   = "관저고";
        public const string col_관경     = "관경";
        public const string col_맨홀     = "맨홀";
        public const string col_TEXT1    = "TEXT1";
        public const string col_TEXT2    = "TEXT2";
        public const string col_구간     = "구간";
        public const string col_구배     = "구배";
        public const string col_INV      = "INV";
        public const string col_SIZE     = "SIZE";
        public const string col_라인명   = "라인명";
        public const string col_지하수위 = "지하수위";
        public const string col_맨홀_INVERT = "맨홀INVERT";
        public const string col_맨홀규격 = "맨홀규격";
        public const string col_굴착공법 = "굴착공법";
        public const string col_굴착장비 = "굴착장비";
        public const string col_포장종류 = "포장종류";

        public const string col_NO = "NO";
        public const string col_전후단면 = "전후단면";
        public const string col_전후단면_IDX = "전후단면_IDX";  //전후단면 정렬시 사용하는 INDEX
        public const string col_계획고 = "계획고";

        public const string col_육상_토사 = "육상(토사)";
        public const string col_육상_풍화암 = "육상(풍화암)";
        public const string col_육상_연암 = "육상(연암)";
        public const string col_수중_토사 = "수중(토사)";
        public const string col_수중_풍화암 = "수중(풍화암)";
        public const string col_수중_연암 = "수중(연암)";
        public const string col_관상부 = "관상부";
        public const string col_관주위 = "관주위";
        public const string col_ASP= "ASP";
        public const string col_CONC= "CONC";
        public const string col_덧씌우기= "덧씌우기";
        public const string col_보도블럭= "보도블럭";
        public const string col_모래부설= "모래부설";
        public const string col_보조기층= "보조기층";
        public const string col_동상방지층= "동상방지층";


        ///SHEET_INFO TABLE
        public const string col_SHEET_NAME = "SHEET_NAME";
        public const string col_PIPE_TYPE = "PIPE_TYPE";
        public const string col_DATA1_RANGE = "DATA1_RANGE";
        public const string col_DATA2_RANGE = "DATA2_RANGE";
        public const string col_토적_RANGE = "토적_RANGE";



        

        ////
        ///
        //dt.Columns.Add("육상(토사)", typeof(string));
        //    dt.Columns.Add("육상(풍화암)", typeof(string));
        //    dt.Columns.Add("육상(연암)", typeof(string));
        //    dt.Columns.Add("육상(연암)", typeof(string));
        //    dt.Columns.Add("수중(풍화암)", typeof(string));
        //    dt.Columns.Add("수중(연암)", typeof(string));
        //    dt.Columns.Add("관상부", typeof(string));
        //    dt.Columns.Add("관주위", typeof(string));




        /// <summary>
        /// 맨홀 높이를 관리하는 데이터 테이블을 만든다.
        /// </summary>
        /// <returns></returns>
        public static DataTable GetMhHeight()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("LINENAME", typeof(string));
            dt.Columns.Add("MhHeight", typeof(string));

            return dt;
        }

        public static DataTable GetPipeTmp()
        {
            //누가거리 지반고 관저고 관경  맨홀
            DataTable dt = new DataTable();

            dt.Columns.Add("누가거리", typeof(string));
            dt.Columns.Add("지반고", typeof(string));
            dt.Columns.Add("관저고", typeof(string));
            dt.Columns.Add("관경", typeof(string));
            dt.Columns.Add("맨홀", typeof(string));

            return dt;
        }

        public static DataTable GetPipExt()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("맨홀", typeof(string));
            dt.Columns.Add("맨홀규격", typeof(string));
            dt.Columns.Add("굴착공법", typeof(string));
            dt.Columns.Add("장비", typeof(string));
            dt.Columns.Add("포장종류", typeof(string));

            return dt;
        }


        public static DataTable GetPipeToolTable()
        {
            DataTable dt = new DataTable();
            dt.TableName = tbl_PIPE_TOOL_INPUT;

            dt.Columns.Add(col_LINENAME, typeof(string));
            dt.Columns.Add(col_INDEX, typeof(int));
            dt.Columns.Add(col_누가거리, typeof(decimal));
            dt.Columns.Add(col_지반고, typeof(decimal));
            dt.Columns.Add(col_관저고, typeof(decimal));
            dt.Columns.Add(col_관경, typeof(int));
            dt.Columns.Add(col_맨홀, typeof(string));
            dt.Columns.Add(col_TEXT1, typeof(string));
            dt.Columns.Add(col_TEXT2, typeof(string));
            dt.Columns.Add(col_구간, typeof(string));
            dt.Columns.Add(col_구배, typeof(decimal));
            dt.Columns.Add(col_INV, typeof(decimal));
            dt.Columns.Add(col_SIZE, typeof(decimal));
            dt.Columns.Add(col_라인명, typeof(string));
            dt.Columns.Add(col_지하수위, typeof(decimal));
            dt.Columns.Add(col_맨홀_INVERT, typeof(decimal));
            DataColumn dc;
            dc = dt.Columns.Add(col_맨홀규격, typeof(string));
            dc.DefaultValue = "원형1호";

            dt.Columns.Add(col_굴착공법, typeof(string));
            dc = dt.Columns.Add(col_굴착장비, typeof(string));
            dc.DefaultValue = "B/H 0.7";

            dt.Columns.Add(col_포장종류, typeof(string));

            return dt;
        }

        /// <summary>
        /// 관경별 연장길이를 관리한다.
        /// 동일 라인에서도 관경이 변경할 수 있는데
        /// 300 ->400->500->300 관경이 바뀔때마다 해당 관경별 연장을 관리합니다.
        /// </summary>
        /// <returns></returns>
        public static DataTable Get관경별PIPE연장()
        {
            DataTable dt = new DataTable();


            return dt;
        }

        public static DataTable Get토적DataTable()
        {
            //NO	지반고	관저고	계획고	육상(토사)	육상(풍화암)	육상(연암)	수중(토사)	수중(풍화암)	수중(연암)	관상부
            //관주위	ASP	CONC	덧씌우기	보도블럭	모래부설	보조기층	동상방지층 구간 , 관경 ,
            //맨홀규격  굴착공법  Column3 (임시이름) 포장종류
            DataTable dt = new DataTable();

            dt.TableName = tbl_토적표_INPUT;
            dt.Columns.Add(col_LINENAME, typeof(string));
            dt.Columns.Add(col_INDEX, typeof(int));
            dt.Columns.Add(col_NO   , typeof(string));
            dt.Columns.Add(col_전후단면, typeof(string));
            dt.Columns.Add(col_전후단면_IDX, typeof(int));
            dt.Columns.Add(col_누가거리, typeof(decimal));
            dt.Columns.Add(col_거리, typeof(decimal));
            dt.Columns.Add(col_지반고, typeof(decimal));
            dt.Columns.Add(col_관저고, typeof(decimal));
            dt.Columns.Add(col_계획고, typeof(decimal));
            dt.Columns.Add(col_육상_토사, typeof(decimal));
            dt.Columns.Add(col_육상_풍화암, typeof(decimal));
            dt.Columns.Add(col_육상_연암, typeof(decimal));
            dt.Columns.Add(col_수중_토사, typeof(decimal));
            dt.Columns.Add(col_수중_풍화암, typeof(decimal));
            dt.Columns.Add(col_수중_연암, typeof(decimal));
            dt.Columns.Add(col_관상부, typeof(decimal));
            dt.Columns.Add(col_관주위, typeof(decimal));
            dt.Columns.Add(col_ASP, typeof(decimal));
            dt.Columns.Add(col_CONC, typeof(decimal));
            dt.Columns.Add(col_덧씌우기, typeof(decimal));
            dt.Columns.Add(col_보도블럭, typeof(decimal));
            dt.Columns.Add(col_모래부설, typeof(decimal));
            dt.Columns.Add(col_보조기층, typeof(decimal));
            dt.Columns.Add(col_동상방지층, typeof(decimal));


            return dt;
        }


        /// <summary>
        /// PIPETOOL INPUT과 토적 Data를 JOIN 해서 만들 토적 기초 데이터 Table을 만든다. 
        /// tbl_토적_BASE 
        /// </summary>
        /// <returns></returns>
        public static DataTable Get토적BaseTable()
        {
            //NO	지반고	관저고	계획고	육상(토사)	육상(풍화암)	육상(연암)	수중(토사)	수중(풍화암)	수중(연암)	관상부
            //관주위	ASP	CONC	덧씌우기	보도블럭	모래부설	보조기층	동상방지층 구간 , 관경 ,
            //맨홀규격  굴착공법  Column3 (임시이름) 포장종류
            DataTable dt = new DataTable();

            dt.TableName = tbl_토적_BASE;
            dt.Columns.Add(col_INDEX, typeof(int));
            dt.Columns.Add(col_LINENAME, typeof(string));
            dt.Columns.Add(col_맨홀, typeof(string));
            dt.Columns.Add(col_NO, typeof(string));
            dt.Columns.Add(col_전후단면, typeof(string));
            dt.Columns.Add(col_전후단면_IDX, typeof(int));
            dt.Columns.Add(col_누가거리, typeof(int));
            dt.Columns.Add(col_거리, typeof(int));
            dt.Columns.Add(col_지반고, typeof(decimal));
            dt.Columns.Add(col_관저고, typeof(decimal));
            dt.Columns.Add(col_계획고, typeof(decimal));
            dt.Columns.Add(col_육상_토사, typeof(decimal));
            dt.Columns.Add(col_육상_풍화암, typeof(decimal));
            dt.Columns.Add(col_육상_연암, typeof(decimal));
            dt.Columns.Add(col_수중_토사, typeof(decimal));
            dt.Columns.Add(col_수중_풍화암, typeof(decimal));
            dt.Columns.Add(col_수중_연암, typeof(decimal));
            dt.Columns.Add(col_관상부, typeof(decimal));
            dt.Columns.Add(col_관주위, typeof(decimal));
            dt.Columns.Add(col_ASP, typeof(decimal));
            dt.Columns.Add(col_CONC, typeof(decimal));
            dt.Columns.Add(col_덧씌우기, typeof(decimal));
            dt.Columns.Add(col_보도블럭, typeof(decimal));
            dt.Columns.Add(col_모래부설, typeof(decimal));
            dt.Columns.Add(col_보조기층, typeof(decimal));
            dt.Columns.Add(col_동상방지층, typeof(decimal));


            return dt;
        }



        /// <summary>
        /// 토적표를 만들때 쓸 기초 데이터를 생성해요
        /// </summary>
        /// <returns></returns>
        public static DataTable GtMassData()
        {
            //NO	지반고	관저고	계획고	육상(토사)	육상(풍화암)	육상(연암)	수중(토사)	수중(풍화암)	수중(연암)	관상부
            //관주위	ASP	CONC	덧씌우기	보도블럭	모래부설	보조기층	동상방지층 구간 , 관경 ,
            //맨홀규격  굴착공법  Column3 (임시이름) 포장종류
            DataTable dt = new DataTable();
            dt.TableName = tbl_토적표기초데이터;

            dt.Columns.Add("LINE", typeof(string));
            dt.Columns.Add("LINENAME", typeof(string));
            dt.Columns.Add(col_누가거리, typeof(string));
            dt.Columns.Add(col_NO, typeof(string));
            dt.Columns.Add(col_지반고, typeof(string));
            dt.Columns.Add(col_관저고, typeof(string));
            dt.Columns.Add(col_계획고, typeof(string));
            dt.Columns.Add(col_육상_토사, typeof(string));
            dt.Columns.Add(col_육상_풍화암, typeof(string));
            dt.Columns.Add(col_육상_연암, typeof(string));
            dt.Columns.Add(col_수중_토사, typeof(string));
            dt.Columns.Add(col_수중_풍화암, typeof(string));
            dt.Columns.Add(col_수중_연암, typeof(string));
            dt.Columns.Add(col_관상부, typeof(string));
            dt.Columns.Add(col_관주위, typeof(string));
            dt.Columns.Add(col_ASP, typeof(string));
            dt.Columns.Add(col_CONC, typeof(string));
            dt.Columns.Add(col_덧씌우기, typeof(string));
            dt.Columns.Add(col_모래부설, typeof(string));
            dt.Columns.Add(col_보도블럭, typeof(string));
            dt.Columns.Add(col_보조기층, typeof(string));
            dt.Columns.Add(col_동상방지층, typeof(string));
            dt.Columns.Add(col_구간, typeof(string));
            dt.Columns.Add(col_관경, typeof(string));
            dt.Columns.Add(col_맨홀규격, typeof(string));
            dt.Columns.Add(col_굴착공법, typeof(string));
            dt.Columns.Add(col_굴착장비, typeof(string));
            dt.Columns.Add(col_포장종류, typeof(string));

            return dt;
        }

        /// <summary>
        /// 전체 Sheet 요약정보를 가지고 있는 테이블을 만들어보아요
        /// </summary>
        /// <returns></returns>
        public static DataTable GetSheetInfo()
        {
            DataTable dt = new DataTable();
            dt.TableName = tbl_SHEET_INFO;
            try
            {
                dt.Columns.Add(col_SHEET_NAME, typeof(string));
                dt.Columns.Add(col_PIPE_TYPE, typeof(string));
                dt.Columns.Add(col_DATA1_RANGE, typeof(string));
                dt.Columns.Add(col_DATA2_RANGE, typeof(string));
                dt.Columns.Add(col_토적_RANGE, typeof(string));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public static DataTable Get굴착장비()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(double));
            dt.Columns.Add("명칭", typeof(string));

            dt.Rows.Add(0.2, "B/H0.2");
            dt.Rows.Add(0.5, "B/H0.5");
            dt.Rows.Add(0.7, "B/H0.7");

            return dt;
        }

        public static DataTable Get맨홀규격()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("명칭", typeof(string));

            dt.Rows.Add(1, "원형1호");
            dt.Rows.Add(2, "원형2호");
            dt.Rows.Add(3, "원형3호");

            return dt;
        }

        public static DataTable Get맨홀구간정보()
        {
            DataTable dt = new DataTable();
            dt.TableName = tbl_맨홀구간정보;
            dt.Columns.Add("INDEX", typeof(int));
            dt.Columns.Add("LINENAME", typeof(string));
            dt.Columns.Add("관종", typeof(string));
            dt.Columns.Add("맨홀", typeof(string));
            dt.Columns.Add("관경", typeof(double));
            dt.Columns.Add("맨홀규격", typeof(string));
            dt.Columns.Add("시작위치", typeof(double));
            dt.Columns.Add("종료위치", typeof(double));
            dt.Columns.Add("구간거리", typeof(double));

            DataColumn[] dtkey = new DataColumn[6];
            dtkey[0] = dt.Columns["LINENAME"];
            dtkey[1] = dt.Columns["관종"];
            dtkey[2] = dt.Columns["맨홀"];
            dtkey[3] = dt.Columns["관경"];
            dtkey[4] = dt.Columns["맨홀규격"];
            dtkey[5] = dt.Columns["시작위치"];

            dt.PrimaryKey = dtkey;

            return dt;
        }
    }
}