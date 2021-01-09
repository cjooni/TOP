using System;
using System.Data;

namespace TOP.lib
{
    public static class CGetTableType
    {

        public const string tbl_토적표기초데이터 = "토적표기초데이터";
        public const string tbl_맨홀구간정보 = "맨홀구간정보";


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
            dt.Columns.Add("누가거리", typeof(string));
            dt.Columns.Add("NO", typeof(string));
            dt.Columns.Add("지반고", typeof(string));
            dt.Columns.Add("관저고", typeof(string));
            dt.Columns.Add("계획고", typeof(string));
            dt.Columns.Add("육상(토사)", typeof(string));
            dt.Columns.Add("육상(풍화암)", typeof(string));
            dt.Columns.Add("육상(연암)", typeof(string));
            dt.Columns.Add("수중(토사)", typeof(string));
            dt.Columns.Add("수중(풍화암)", typeof(string));
            dt.Columns.Add("수중(연암)", typeof(string));
            dt.Columns.Add("관상부", typeof(string));
            dt.Columns.Add("관주위", typeof(string));
            dt.Columns.Add("ASP", typeof(string));
            dt.Columns.Add("CONC", typeof(string));
            dt.Columns.Add("덧씌우기", typeof(string));
            dt.Columns.Add("보도블럭", typeof(string));
            dt.Columns.Add("모래부설", typeof(string));
            dt.Columns.Add("보조기층", typeof(string));
            dt.Columns.Add("동상방지층", typeof(string));
            dt.Columns.Add("구간", typeof(string));
            dt.Columns.Add("관경", typeof(string));
            dt.Columns.Add("맨홀규격", typeof(string));
            dt.Columns.Add("굴착공법", typeof(string));
            dt.Columns.Add("굴착장비", typeof(string));
            dt.Columns.Add("포장종류", typeof(string));

            return dt;
        }

        /// <summary>
        /// 전체 Sheet 요약정보를 가지고 있는 테이블을 만들어보아요
        /// </summary>
        /// <returns></returns>
        public static DataTable GetSheetInfo()
        {
            DataTable dt = new DataTable();
            dt.TableName = "SHEET_INFO";
            try
            {
                dt.Columns.Add("SHEET_NAME", typeof(string));
                dt.Columns.Add("PIPE_TYPE", typeof(string));
                dt.Columns.Add("DATA1_RANGE", typeof(string));
                dt.Columns.Add("DATA2_RANGE", typeof(string));
                dt.Columns.Add("토적_RANGE", typeof(string));
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