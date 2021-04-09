using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TOP.lib;

namespace TOP.Dialog
{
    public partial class frmMngr포장공정 : TOP.Parent.PForm
    {
        public frmMngr포장공정()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Qry포장_LIST();
            Qry포장공정_LIST();
        }

        private void Qry포장_LIST()
        {

            try
            {
               
                sqlDataQry.Fill("QRY_포장_LIST");

                DataTable dt = CUtil.GetTable(sqlDataQry.Result["QRY_포장_LIST"]);

                gridControl1.DataSource = dt;
               
            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.Message;

            }
        }


        private void Qry포장공정_LIST()
        {

            try
            {

                sqlDataQry.Fill("QRY_포장공정_LIST");

                DataTable dt = CUtil.GetTable(sqlDataQry.Result["QRY_포장공정_LIST"]);

                gridControl3.DataSource = dt;

            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.Message;

            }
        }

       
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
      

        }


        /// <summary>
        /// 포장 List 를 Click했을때 Event를 설정한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetFocusedDataRow();

            try
            {
                labelControl1.Text = dr["descr"].ToString();
                label포장.Text = dr["cd"].ToString();
                sqlDataQry.Fill("QRY_포장별_공정_LIST");
                DataTable dt = CUtil.GetTable(sqlDataQry.Result["QRY_포장별_공정_LIST"]);

                gridControl2.DataSource = dt;

            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.Message;
            }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            

            try
            {
                DataRow 포장Row = gridView3.GetFocusedDataRow();

                DataTable dt = (DataTable)gridControl2.DataSource;

                ///이미 포함되어 있는 포장공정인지 확인해 보자
                ///\
                


                int nCnt = 0;
                nCnt = dt.Rows.Count;
                DataRow dr = dt.NewRow();

                dr["p_mngr_cd"] = "PAVE_CD";
                dr["p_cd"] = label포장.Text;
                dr["p_cd_nm"] = labelControl1.Text;
                dr["mngr_cd"] = 포장Row["mngr_cd"];
                dr["cd"] = 포장Row["cd"];
                dr["cd_nm"] = 포장Row["cd_nm"];
                dr["ord_seq"] = nCnt;



                dt.Rows.Add(dr);

                gridControl2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.Message;
            }
                
        }


        private Boolean chk포장(string 포장코드)
        {
            try
            {
                if (label포장.Text.Trim() == "")
                {
                    MsgCaption.Caption = "포장을 선택하세요";

                    return false;
                }


            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.Message;
            }


            return true;
        }


        /// <summary>
        /// 포장별 공정 List를 Double Click하면 삭제하자
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("선택항목을 삭제 하시겠습니까", "선택항목 삭제", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }

            try
            {

            }
            catch (Exception ex)
            {

                MsgCaption.Caption = ex.Message;
            }

            gridView2.DeleteSelectedRows();
        }
    }
}
