using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TOP.lib;

namespace TOP.Screen
{
    public partial class frm관로공 : TOP.Parent.PForm
    {
        public CPrjInfo PrjInfo;
        public frm관로공()
        {

            InitializeComponent();
            PrjInfo = new CPrjInfo();
        }
    }
}
