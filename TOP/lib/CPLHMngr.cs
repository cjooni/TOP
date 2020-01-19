using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOP.lib
{
    /// <summary>
    /// PLH, PLD 파일로 PIPE TOOL Excel파일을 만든다.
    /// </summary>
    public class CPLHData
    {
        private string fileName;
        private DataTable plhdata;
        private DataTable plddata;

        public string FileName { get => fileName; set => fileName = value; }

        public DataTable PLHData { get => plhdata; set => plhdata = value; }
        public DataTable PLDData { get => plddata; set => plddata = value; }
    }


    public class CPLHMngr
    {
        public List<CPLHData> PLHDataList;

        public CPLHMngr()
        {
            PLHDataList = new List<CPLHData>();
        }

        public void AddPLHData(CPLHData Data)
        {
          
            if (PLHDataList.Exists(x => x.FileName == Data.FileName))
            {
                PLHDataList.Find(x => x.FileName == Data.FileName).PLHData = Data.PLHData;
            }
            else
            {
                PLHDataList.Add(Data);
            }
        }

        public void AddPLDData(CPLHData Data)
        {

            if (PLHDataList.Exists(x => x.FileName == Data.FileName))
            {
                PLHDataList.Find(x => x.FileName == Data.FileName).PLDData = Data.PLDData;
            }
            else
            {
                PLHDataList.Add(Data);
            }
        }

        public void AddData(CPLHData Data)
        {
            PLHDataList.Add(Data);
        }

        public DataTable GetData()
        {
            DataTable Data = new DataTable();
            Data.Columns.Add("filename", typeof(string));
            Data.Columns.Add("plhdata", typeof(DataTable));
            Data.Columns.Add("plddata", typeof(DataTable));


            foreach (CPLHData item in PLHDataList)
            {
                DataRow Dr = Data.NewRow();
                Dr["filename"] = item.FileName;
                Dr["plhdata"] = item.PLHData;
                Dr["plddata"] = item.PLDData;

                Data.Rows.Add(Dr);
            }

            return Data;

        }
    }


    public class CPipeToolData
    {
        private string fileName;
        private DataTable data1; //상단 구간정보
        private DataTable data2; //하단 측점정보

        public string FileName { get => fileName; set => fileName = value; }
        public DataTable Data1 { get => data1; set => data1 = value; }
        public DataTable Data2 { get => data2; set => data2 = value; }
    }




    /// <summary>
    /// 파이프툴 데이터 정보를 관리한다. 
    /// </summary>
    public class CPipeToolMngr
    {
        public List<CPipeToolData> PipeToolDataList;

        public CPipeToolMngr()
        {
            PipeToolDataList = new List<CPipeToolData>();
        }


        /// <summary>
        /// 상단의 구간정보를 추가한다.
        /// </summary>
        /// <param name="Data"></param>
        public void AddData1(CPipeToolData Data)
        {
            if (PipeToolDataList.Exists(x => x.FileName == Data.FileName))
            {
                PipeToolDataList.Find(x => x.FileName == Data.FileName).Data1 = Data.Data1;
            }
            else
            {
                PipeToolDataList.Add(Data);
            }
        }

        /// <summary>
        /// 하단의 측점 정보를 추가한다.
        /// </summary>
        /// <param name="Data"></param>
        public void AddData2(CPipeToolData Data)
        {
            if (PipeToolDataList.Exists(x => x.FileName == Data.FileName))
            {
                PipeToolDataList.Find(x => x.FileName == Data.FileName).Data2 = Data.Data2;
            }
            else
            {
                PipeToolDataList.Add(Data);
            }
        }


        public void AddData(CPipeToolData Data)
        {
            PipeToolDataList.Add(Data);
        }
    }



    /// <summary>
    /// PLH , PLD 데이터로 PipeTool Data를 만든다.
    /// </summary>
    public class CPLHDataProc
    {
        private CPLHMngr PLHMngr;
        public CPipeToolMngr PipeToolMngr;
        
        /// <summary>
        /// 구성된 PLH, PLD를 인자로 전달받아야 해
        /// </summary>
        /// <param name="Data"></param>
        public CPLHDataProc(CPLHMngr Data)
        {
            PipeToolMngr = new CPipeToolMngr();
            PLHMngr = Data;
        }



        /// <summary>
        /// PLH 정보를 읽어서 PIPE TOOL 정보를 만든다.
        /// </summary>
        public void MakePipeToolData()
        {
            foreach (CPLHData item in PLHMngr.PLHDataList)
            {
                CPipeToolData PIpeData = new CPipeToolData();
                PIpeData.FileName = item.FileName;
                PIpeData.Data1 = ParsePLH(item.FileName);
                PIpeData.Data2 = ParsePLD(item.FileName);

                MakeManholeCheck(PIpeData.Data1);
                PipeToolMngr.AddData(PIpeData);
            }
           
        }


        /// <summary>
        /// 전단면 후단면 정보를 PIPE툴 정보로 교체한다. 
        /// 전단면 후단면인 경우 후단면의 라인명을 전단면에 동일하게 넣어준다. 
        /// 그리도 전단면도 'P' 표시를 넣어준다.
        /// </summary>
        public void MakeManholeCheck(DataTable data)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i]["manhole"].ToString() != "P")
                {
                    data.Rows[i]["맨홀"] = "";
                }
                    if (i == 0 )
                {
                    continue;
                }

                if ( (data.Rows[i]["누가거리"].ToString() == data.Rows[i-1]["누가거리"].ToString()) &&
                     (data.Rows[i]["manhole"].ToString() == "P") )
                {
                    data.Rows[i - 1]["manhole"] = "P";
                    data.Rows[i - 1]["맨홀"] = data.Rows[i]["맨홀"];
                }

               
            }

         
        }


        /// <summary>
        /// 파일명으로 PLD 데이터를 찾아 DataTable로 return 한다.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public DataTable ParsePLD(string fileName)
        {
            DataTable pldData = PLHMngr.PLHDataList.Find(x => x.FileName == fileName).PLDData;

            String strLineName = "";
            DataTable pipeData = GetPipeDataTablePoint();

            foreach (DataRow item in pldData.Rows)
            {
                DataRow PipeDr = pipeData.NewRow();


                string dist;

                int qty = 0;
                double remain = 0;
                double dtmp;
                dtmp = Math.Truncate(Convert.ToDouble(item["dist"]) / 20);
                remain = Convert.ToDouble(item["dist"]) % 20;

                if (dtmp >=1 )
                {
                    dist = string.Format("{0}+{1}", Convert.ToInt32(dtmp), remain);    
                }
                else
                {
                    dist = string.Format("{0}+{1}", 0, remain);
                }

                PipeDr["측점"] = dist;
                PipeDr["INV"] = Convert.ToDouble(item["inv"]);
                PipeDr["SIZE"] = Convert.ToDouble(item["dia"]) * 1000;
                PipeDr["TEXT"] = "";
                PipeDr["BoxT1"] = "";
                PipeDr["BoxT2"] = "";
                PipeDr["BoxT3"] = "";
               

                pipeData.Rows.Add(PipeDr);

            }

            return pipeData;
        }

        /// <summary>
        /// 파일명으로 PLH 데이터를 찾아 DataTable로 return 한다.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public DataTable ParsePLH(string fileName)
        {
            DataTable plhData = PLHMngr.PLHDataList.Find(x => x.FileName == fileName).PLHData;

            String strLineName = "";
            DataTable pipeData = GetPipeDataTable();


            ///pipe tool의 구간 정보를 설정한다.
            CPipetoolSector.SetData(plhData);

            foreach (DataRow item in plhData.Rows)
            {
                DataRow PipeDr = pipeData.NewRow();

                if (strLineName != item["LINENAME"].ToString().Trim())
                {
                    strLineName = item["LINENAME"].ToString().Trim();
                    PipeDr["manhole"] = "P";
                }

                PipeDr["누가거리"] = Convert.ToDouble(item["dist2"]);
                PipeDr["지반고"] = Convert.ToDouble(item["gh"]);
                PipeDr["관저고"] = Convert.ToDouble(item["INV"]);
                PipeDr["관경"] = Convert.ToDouble(item["DIA"]) * 1000; //item["DIA"];
                PipeDr["맨홀"] = item["LINENAME"];
                PipeDr["구간"] = CPipetoolSector.GetSector(item);
                PipeDr["구배"] = Convert.ToDouble(item["SLOPE"]);
                               
                pipeData.Rows.Add(PipeDr);

            }

            return pipeData;

        }



        /// <summary>
        /// Pipe Tool 데이터 하단부의 측점 정보를 DataTable로 생성한다.
        /// </summary>
        /// <returns></returns>
        public DataTable GetPipeDataTablePoint()
        {
            DataTable Data = new DataTable();
            Data.Columns.Add("측점", typeof(string));
            Data.Columns.Add("INV", typeof(string));
            Data.Columns.Add("SIZE", typeof(string));
            Data.Columns.Add("TEXT", typeof(string));
            Data.Columns.Add("BoxT1", typeof(string));
            Data.Columns.Add("BoxT2", typeof(string));
            Data.Columns.Add("BoxT3", typeof(string));

            return Data;
        }
        /// <summary>
        /// PIPE TOOL 데이터의 상단부 구간 정보를 DataTable로 생성한다.
        /// </summary>
        /// <returns></returns>
        public DataTable GetPipeDataTable()
        {
            DataTable Data = new DataTable();
            Data.Columns.Add("manhole", typeof(string));
            Data.Columns.Add("누가거리", typeof(string));
            Data.Columns.Add("지반고", typeof(string));
            Data.Columns.Add("관저고", typeof(string));
            Data.Columns.Add("관경", typeof(string));
            Data.Columns.Add("맨홀", typeof(string));
            Data.Columns.Add("TEXT1", typeof(string));
            Data.Columns.Add("TEXT2", typeof(string));
            Data.Columns.Add("구간", typeof(string));
            Data.Columns.Add("구배", typeof(string));
            Data.Columns.Add("INV", typeof(string));
            Data.Columns.Add("SIZE", typeof(string));
            Data.Columns.Add("라인명", typeof(string));
            Data.Columns.Add("L지반", typeof(string));
            Data.Columns.Add("R지반", typeof(string));
            Data.Columns.Add("L포장", typeof(string));
            Data.Columns.Add("R포장", typeof(string));
            Data.Columns.Add("L건물", typeof(string));
            Data.Columns.Add("R건물", typeof(string));
            Data.Columns.Add("INV2", typeof(string));
            Data.Columns.Add("DIA2", typeof(string));
            Data.Columns.Add("지장물1", typeof(string));
            Data.Columns.Add("지장물2", typeof(string));
            Data.Columns.Add("지장물3", typeof(string));
            Data.Columns.Add("지장물4", typeof(string));
            Data.Columns.Add("각선면적", typeof(string));
            Data.Columns.Add("유입유량", typeof(string));
            Data.Columns.Add("X1", typeof(string));
            Data.Columns.Add("Y1", typeof(string));
            Data.Columns.Add("지하수위", typeof(string));
            Data.Columns.Add("관리도로", typeof(string));
            Data.Columns.Add("도로구배", typeof(string));
            Data.Columns.Add("풍화암", typeof(string));
            Data.Columns.Add("연 암", typeof(string));
            Data.Columns.Add("관번호", typeof(string));
            Data.Columns.Add("관  종", typeof(string));
            Data.Columns.Add("노면L", typeof(string));
            Data.Columns.Add("노면R", typeof(string));
            Data.Columns.Add("관기초", typeof(string));
            Data.Columns.Add("맨홀INVERT", typeof(string));

            return Data;
         
        }

    }

}
