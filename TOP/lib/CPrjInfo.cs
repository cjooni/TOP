using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOP.lib
{
    /// <summary>
    /// Project 정보를 관리한다.
    /// </summary>
    public class CPrjInfo
    {
        private string projectCd;
        private string projectNm;
        public CPrjInfo()
        {

        }

        public string ProjectCd { get => projectCd; set => projectCd = value; }
        public string ProjectNm { get => projectNm; set => projectNm = value; }
    }
}
