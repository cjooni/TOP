﻿using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
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
                sqlDataQry.Queries["QRY_포장별_공정_LIST"].Parameters.Find(x => x.Name == "P_P_CD").Value = label포장.Text;
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
            MsgCaption.Caption = "";

            try
            {
                DataRow 포장Row = gridView3.GetFocusedDataRow();

                DataTable dt = (DataTable)gridControl2.DataSource;

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

        /// <summary>
        /// 편집한 포장정보 내용을 저장한다. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Set포장공정();
        }

        private void Set포장공정()
        {
            try
            {
                CMySql mysql = new CMySql();
                mysql.Connect();

                using (MySqlCommand mycommand = mysql.Connection.CreateCommand())
                {
                    MySqlTransaction mytrans;

                    mytrans = mysql.Connection.BeginTransaction();
                    mycommand.Connection = mysql.Connection;
                    mycommand.Transaction = mytrans;

                    try
                    {
                        //DELETE COD10T00
                        CustomSqlQuery query = sqlData.Queries["포장별공정_DELETE"] as CustomSqlQuery;
                        mycommand.CommandText = query.Sql;
                        mycommand.Parameters.Clear();

                        ///기본 프로젝트는 'XXXXXXXXXX' 이다
                        mycommand.Parameters.AddWithValue("@P_PROJECT_CD", "XXXXXXXXXX");
                        mycommand.Parameters.AddWithValue("@P_P_MNGR_CD", "PAVE_CD");
                        mycommand.Parameters.AddWithValue("@P_P_CD", label포장.Text);
                        mycommand.ExecuteNonQuery();


                        //INSERT COD10T00
                        //지운 후 신규작성해 불자 
                        DataTable dt = (DataTable)gridControl2.DataSource;

                        foreach (DataRow item in dt.Rows)
                        {
                            query = sqlData.Queries["포장별공정_INSERT"] as CustomSqlQuery;
                            mycommand.CommandText = query.Sql;
                            mycommand.Parameters.Clear();

                            ///기본 프로젝트는 'XXXXXXXXXX' 이다
                            mycommand.Parameters.AddWithValue("@P_PROJECT_CD", "XXXXXXXXXX");
                            mycommand.Parameters.AddWithValue("@P_P_MNGR_CD", item["p_mngr_cd"]);
                            mycommand.Parameters.AddWithValue("@P_P_CD", item["p_cd"]);
                            mycommand.Parameters.AddWithValue("@P_MNGR_CD", item["mngr_cd"]);
                            mycommand.Parameters.AddWithValue("@P_CD", item["cd"]);
                            mycommand.Parameters.AddWithValue("@P_ORD_SEQ", item["ord_seq"] );
                            mycommand.ExecuteNonQuery();
                        }

                        //dr["p_mngr_cd"] = "PAVE_CD";
                        //dr["p_cd"] = label포장.Text;
                        //dr["p_cd_nm"] = labelControl1.Text;
                        //dr["mngr_cd"] = 포장Row["mngr_cd"];
                        //dr["cd"] = 포장Row["cd"];
                        //dr["cd_nm"] = 포장Row["cd_nm"];
                        //dr["ord_seq"] = nCnt;



                        MsgCaption.Caption = "정상 처리되었습니다.";
                        mytrans.Commit();
                    }
                    catch (Exception ex)
                    {
                        mytrans.Rollback();
                        MsgCaption.Caption = ex.Message;
                        throw ex;
                    }
                    finally
                    {
                        mysql.Connection.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
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