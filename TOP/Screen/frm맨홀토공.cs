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
    public partial class frm맨홀토공 : TOP.Parent.PForm
    {
        public CPrjInfo PrjInfo;

        public frm맨홀토공()
        {
            InitializeComponent();
            PrjInfo = new CPrjInfo();
        }

        /// <summary>
        /// 맨홀조서를 조회한다. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Qry_맨홀조서();
        }

        /// <summary>
        /// 맨홀조서를 조회한다. .
        /// </summary>
        /// <returns></returns>
        private void Qry_맨홀조서()
        {
            try
            {
                gridView1.OptionsBehavior.Editable = false;
                sqlDataQry.Queries["QRY_맨홀조서"].Parameters.Find(x => x.Name == "P_PROJECT_CD").Value = PrjInfo.ProjectCd;
                sqlDataQry.Fill("QRY_맨홀조서");

                DataTable dt = CUtil.GetTable(sqlDataQry.Result["QRY_맨홀조서"]);
                gridControl1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.Message;
            }
        }

        /// <summary>
        /// 맨홀조서집계를 조회한다. .
        /// </summary>
        /// <returns></returns>
        private void Qry_맨홀조서집계()
        {
            try
            {
                gridView2.OptionsBehavior.Editable = false;
                sqlDataQry.Queries["QRY_맨홀조서집계"].Parameters.Find(x => x.Name == "P_PROJECT_CD").Value = PrjInfo.ProjectCd;
                sqlDataQry.Fill("QRY_맨홀조서집계");

                DataTable dt = CUtil.GetTable(sqlDataQry.Result["QRY_맨홀조서집계"]);
                gridControl2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.Message;
            }
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            Qry_맨홀조서집계();
        }
    }
}
