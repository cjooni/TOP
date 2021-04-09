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
    public partial class frmLoadData : TOP.Parent.PForm
    {
        public CPrjInfo PrjInfo;
        public frmLoadData()
        {
            InitializeComponent();

            PrjInfo = new CPrjInfo();
        }
    }
}
