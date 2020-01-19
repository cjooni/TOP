using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOP.lib
{
    public static class CPipetoolSector
    {

        public static string GetSector(DataRow item)
        {
            string 가시설 = "0";
            string sector = "";

            if (Convert.ToDouble(item["SLOPE"]) > 0)
            {
                가시설 = "1";
            }

            //가시설 [0]; 가시설 
            //sector [1]: 토사
            //[2]: asphalt
            //[3]: concA
            //[4]: 보도
            //[5]: asp+con

            if (가시설 == "1") //OPEN
            {
                switch (item["sector"].ToString())
                {
                    case "1":
                        sector = "OP01";
                        break;
                    case "2":
                        sector = "OP02";
                        break;
                    case "3":
                        sector = "OP03";
                        break;
                    case "4":
                        sector = "OP04";
                        break;
                    case "5":
                        sector = "OP05";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (item["sector"].ToString())
                {
                    case "1":
                        sector = "GA01";
                        break;
                    case "2":
                        sector = "GA02";
                        break;
                    case "3":
                        sector = "GA03";
                        break;
                    case "4":
                        sector = "GA04";
                        break;
                    case "5":
                        sector = "GA05";
                        break;
                    default:
                        break;
                }
            }
            return sector;
        }

        public static void SetData(DataTable Data)
        {
            Data.Columns.Add("sector", typeof(string));

            //가시설 [0]; 가시설 
            //sector [1]: 토사
            //[2]: asphalt
            //[3]: concA
            //[4]: 보도
            //[5]: asp+con







            foreach (DataRow item in Data.Rows)
            {
                string sector = "";
                string 가시설 = "0";
                // 기울기 가시설 표현 [0]: 가시설
                if (Convert.ToDouble(item["SLOPE"]) > 0)
                {
                    가시설 = "1";
                }

                //토사
                if (Convert.ToDouble(item["sand"]) > 0)
                {
                    sector = "1";
                    item["sector"] = "1";
                    continue;
                }

                if (Convert.ToDouble(item["asphalt1"]) > 0)
                {
                    sector = "2";

                    item["sector"] = "2";
                    continue;
                }

                //concrete
                if (Convert.ToDouble(item["concrete"]) > 0)
                {
                    sector = "3";

                    item["sector"] = "3";
                    continue;
                }

                //보도
                if (Convert.ToDouble(item["humanity"]) > 0)
                {
                    sector = "4";
                    item["sector"] = "4";
                    continue;
                }

                //ASP + concrete
                if (Convert.ToDouble(item["asphalt1"]) > 0 && Convert.ToDouble(item["concrete"]) >= 200)
                {
                    sector = "5";

                    item["sector"] = "5";
                    continue;
                }

             
            }
        }

    }
}
