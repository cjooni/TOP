using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOP.lib
{
    public static class CGetTableType
    {
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



        public static DataTable  GetPipExt()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("맨홀", typeof(string));
            dt.Columns.Add("맨홀규격", typeof(string));
            dt.Columns.Add("굴착공법", typeof(string));
            dt.Columns.Add("장비", typeof(string));
            dt.Columns.Add("포장종류", typeof(string));

            return dt;
        }


        public static DataTable GtMassData()
        {
            //NO	지반고	관저고	계획고	육상(토사)	육상(풍화암)	육상(연암)	수중(토사)	수중(풍화암)	수중(연암)	관상부	
            //관주위	ASP	CONC	덧씌우기	보도블럭	모래부설	보조기층	동상방지층 구간 , 관경 , 
            //맨홀규격  굴착공법  Column3 (임시이름) 포장종류
            DataTable dt = new DataTable();

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
    }
}
