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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            QRY_맨홀토공_MASTER();
        }

        private void QRY_맨홀토공_MASTER()
        {
            try
            {
                MsgCaption.Caption = "";

                gridView3.OptionsBehavior.Editable = false;
                sqlDataQry.Queries["QRY_맨홀토공_MASTER"].Parameters.Find(x => x.Name == "P_PROJECT_CD").Value = PrjInfo.ProjectCd;
                sqlDataQry.Fill("QRY_맨홀토공_MASTER");

                DataTable dt = CUtil.GetTable(sqlDataQry.Result["QRY_맨홀토공_MASTER"]);
                gridControl3.DataSource = dt;

                MsgCaption.Caption = "조회 되었습니다.";
            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.Message;
            }
        }


        /// <summary>
        /// 맨홀 구조물을 조회한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            QRY_맨홀구조물();
        }

        private void QRY_맨홀구조물()
        {
            try
            {
                MsgCaption.Caption = "";

                gridView5.OptionsBehavior.Editable = false;
                sqlDataQry.Queries["QRY_맨홀구조물"].Parameters.Find(x => x.Name == "P_PROJECT_CD").Value = PrjInfo.ProjectCd;
                sqlDataQry.Queries["QRY_맨홀구조물"].Parameters.Find(x => x.Name == "P_P_CD").Value = edtMH_CD.Text;
                sqlDataQry.Fill("QRY_맨홀구조물");

                DataTable dt = CUtil.GetTable(sqlDataQry.Result["QRY_맨홀구조물"]);
                gridControl5.DataSource = dt;

                MsgCaption.Caption = "조회 되었습니다.";
            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.Message;
            }
        }

        private void gridControl3_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gridView3.GetFocusedDataRow();

                edt맨홀규격.Text = dr["맨홀규격"].ToString();
                edt굴착공법.Text = dr["굴착공법"].ToString();
                edt굴착장비.Text = dr["굴착장비"].ToString();
                edtBH_CD.Text = dr["BH_CD"].ToString();
                edtMH_CD.Text = dr["MH_CD"].ToString();
                edtPaveType.Text = dr["pave_type_cd"].ToString();

                QRY_맨홀토공_DETAIL();
            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.Message;
            }
           
        }


        private void QRY_맨홀토공()
        {

        }

        /// <summary>
        /// 포장구성을 조회한다. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            QRY_포장구조();
        }

        private void QRY_포장구조()
        {
            try
            {
                MsgCaption.Caption = "";

                gridView6.OptionsBehavior.Editable = false;
                sqlDataQry.Queries["QRY_포장구조"].Parameters.Find(x => x.Name == "P_PROJECT_CD").Value = PrjInfo.ProjectCd;
                //sqlDataQry.Queries["QRY_포장구조"].Parameters.Find(x => x.Name == "P_P_CD").Value = edtMH_CD.Text;
                sqlDataQry.Fill("QRY_포장구조");

                DataTable dt = CUtil.GetTable(sqlDataQry.Result["QRY_포장구조"]);
                gridControl6.DataSource = dt;

                MsgCaption.Caption = "조회 되었습니다.";
            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.Message;
            }
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            QRY_관로();
        }

        private void QRY_관로()
        {
            try
            {
                MsgCaption.Caption = "";

                gridView7.OptionsBehavior.Editable = false;
                sqlDataQry.Queries["QRY_관로"].Parameters.Find(x => x.Name == "P_PROJECT_CD").Value = PrjInfo.ProjectCd;
                //sqlDataQry.Queries["QRY_포장구조"].Parameters.Find(x => x.Name == "P_P_CD").Value = edtMH_CD.Text;
                sqlDataQry.Fill("QRY_관로");

                DataTable dt = CUtil.GetTable(sqlDataQry.Result["QRY_관로"]);
                gridControl7.DataSource = dt;

                MsgCaption.Caption = "조회 되었습니다.";
            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.Message;
            }
        }

        private void QRY_맨홀토공_DETAIL()
        {
            try
            {
                MsgCaption.Caption = "";

                gridView5.OptionsBehavior.Editable = false;
                sqlDataQry.Queries["QRY_맨홀토공_DETAIL"].Parameters.Find(x => x.Name == "P_PROJECT_CD").Value = PrjInfo.ProjectCd;
                sqlDataQry.Queries["QRY_맨홀토공_DETAIL"].Parameters.Find(x => x.Name == "P_MH_CD").Value = edtMH_CD.Text;
                sqlDataQry.Queries["QRY_맨홀토공_DETAIL"].Parameters.Find(x => x.Name == "P_BH_CD").Value = edtBH_CD.Text;
                sqlDataQry.Queries["QRY_맨홀토공_DETAIL"].Parameters.Find(x => x.Name == "P_PAVE_TYPE_CD").Value = edtPaveType.Text;
                sqlDataQry.Fill("QRY_맨홀토공_DETAIL");

                DataTable dt = CUtil.GetTable(sqlDataQry.Result["QRY_맨홀토공_DETAIL"]);
                gridControl5.DataSource = dt;

                MsgCaption.Caption = "조회 되었습니다.";
            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.Message;
            }
        }
    }
}
