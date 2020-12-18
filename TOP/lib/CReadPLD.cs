using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOP.lib
{
    public static class CReadPLD
    {
        ///PLD의 LINE 데이터를 관리한다. 
        public static DataTable ReadPLD_Line(string strFileName)
        {

            String RLine;

            using (StreamReader SR = new StreamReader(strFileName, Encoding.Default, true))
            {
                CTrans<_st_typePLD_Line> Trans_PLD_Line = new CTrans<_st_typePLD_Line>();
                CMakeDataTable<_st_typePLD_Line> MakeTablePLD_Line = new CMakeDataTable<_st_typePLD_Line>();

                bool chk99 = false;
                bool bRead = false;
                decimal tCnt = 0;
                int nInc = 0;

                while ((RLine = SR.ReadLine()) != null)
                {
                    if (RLine.Trim().Length <= 0)
                    {
                        continue;
                    }

                    ///파일을 읽다가 -99 가 나오는지 확인 
                    if (RLine.Substring(0, 3) == "-99")
                    {
                        chk99 = true;
                        continue;
                    }

                    
                    //99가 나오면 관로 정보 인식 
                    if (chk99)
                    {
                        tCnt = Convert.ToDecimal(RLine.Substring(0, 5).ToString());




                        if (tCnt > 0)
                        {
                            chk99 = false;
                            bRead = true;
                        }

                        continue;
                    }

                    if (bRead)
                    {
                        if (nInc < tCnt)
                        {
                            _st_typePLD_Line st_typePLD_Line = Trans_PLD_Line.ByteToStruct(RLine);
                            MakeTablePLD_Line.AddData(st_typePLD_Line);
                            nInc++;
                        }
                        else
                        {
                            continue;
                        }
                    }

                }
                  
                return MakeTablePLD_Line.DATATABLE;
            }

        }
        
    }
}
