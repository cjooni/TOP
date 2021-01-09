using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOP.lib
{
    public class CUserException : Exception
    {
        public  CUserException() : base()
        {

        }

        public CUserException(string msg) : base(msg)
        {

        }
    }
}
