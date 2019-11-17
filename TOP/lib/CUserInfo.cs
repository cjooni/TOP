using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOP.lib
{
    public class CUserInfo
    {
        public CUserInfo()
        {

        }

        private string userID;
        private string userNM;

        public string UserID { get => userID; set => userID = value; }
        public string UserNM { get => userNM; set => userNM = value; }
    }
}
