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
    public partial class frm관로토공 : TOP.Parent.PForm
    {
        public CPrjInfo PrjInfo;


        public frm관로토공()
        {
            InitializeComponent();
            PrjInfo = new CPrjInfo();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Qry_토적표();
        }

        /// <summary>
        /// 맨홀 규격을 조회한다.
        /// </summary>
        /// <returns></returns>
        private void Qry_토적표()
        {
            try
            {
                advBandedGridView1.OptionsBehavior.Editable = false;
                sqlDataQry.Queries["QRY_토적표"].Parameters.Find(x => x.Name == "P_PROJECT_CD").Value = PrjInfo.ProjectCd;
                sqlDataQry.Fill("QRY_토적표");

                DataTable dt = CUtil.GetTable(sqlDataQry.Result["QRY_토적표"]);
                gridControl1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.Message;
            }
        }
    }
}
