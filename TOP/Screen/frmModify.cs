using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.EditForm.Helpers.Controls;
using MySql.Data.MySqlClient;
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
    public partial class frmModify : TOP.Parent.PForm
    {
        public CPrjInfo PrjInfo;

        /// <summary>
        /// 굴착장비
        /// </summary>
        private RepositoryItemGridLookUpEdit repLookUp_굴착장비;

        /// <summary>
        /// 맨홀규격
        /// </summary>
        private RepositoryItemGridLookUpEdit repLookUp_맨홀규격;

        /// <summary>
        /// 포장종류
        /// </summary>
        private RepositoryItemGridLookUpEdit repLookUp_포장종류;

        /// <summary>
        /// 포장공법
        /// </summary>
        private RepositoryItemGridLookUpEdit repLookUp_포장공법;

        public frmModify()
        {
            InitializeComponent();
            PrjInfo = new CPrjInfo();

            InitControl();
        }

        private void InitControl()
        {
            //GridView1.OptionsBehavior.Editable = true;

            ///굴착장비 Data Load
            repLookUp_굴착장비 = new RepositoryItemGridLookUpEdit();
            repLookUp_굴착장비.DisplayMember = "cd_nm";
            repLookUp_굴착장비.ValueMember = "cd";
            repLookUp_굴착장비.NullText = "미등록";
            repLookUp_굴착장비.KeyMember = "cd";
            repLookUp_굴착장비.DataSource = Qry_굴착장비();
            repLookUp_굴착장비.PopulateViewColumns();
            repLookUp_굴착장비.EditValueChanged += ChangeValueUpdate_굴착장비;
            gridControl1.RepositoryItems.Add(repLookUp_굴착장비);

            

            //맨홀규격
            repLookUp_맨홀규격 = new RepositoryItemGridLookUpEdit();
            repLookUp_맨홀규격.DisplayMember = "cd_nm";
            repLookUp_맨홀규격.ValueMember = "cd";
            repLookUp_맨홀규격.NullText = "미등록";
            repLookUp_맨홀규격.KeyMember = "cd";
            repLookUp_맨홀규격.DataSource = Qry_맨홀();
            repLookUp_맨홀규격.PopulateViewColumns();
            repLookUp_맨홀규격.EditValueChanged += ChangeValueUpdate_맨홀규격;
            gridControl1.RepositoryItems.Add(repLookUp_맨홀규격);




            repLookUp_포장종류 = new RepositoryItemGridLookUpEdit();
            repLookUp_포장종류.DisplayMember = "cd_nm";
            repLookUp_포장종류.ValueMember = "cd";
            repLookUp_포장종류.NullText = "미등록";
            repLookUp_포장종류.KeyMember = "cd";
            repLookUp_포장종류.DataSource = Qry_포장종류();
            repLookUp_포장종류.PopulateViewColumns();
            //repLookUp2.DataSource = CGetTableType.Get맨홀규격();
            //repLookUp2.View.PopulateColumns();
            repLookUp_포장종류.EditValueChanged += ChangeValueUpdate_포장종류;
            gridControl1.RepositoryItems.Add(repLookUp_포장종류);


            repLookUp_포장공법 = new RepositoryItemGridLookUpEdit();
            repLookUp_포장공법.DisplayMember = "cd_nm";
            repLookUp_포장공법.ValueMember = "cd";
            repLookUp_포장공법.NullText = "미등록";
            repLookUp_포장공법.KeyMember = "cd";
            repLookUp_포장공법.DataSource = Qry_굴착공법();
            repLookUp_포장공법.PopulateViewColumns();
            //repLookUp2.DataSource = CGetTableType.Get맨홀규격();
            //repLookUp2.View.PopulateColumns();
            repLookUp_포장공법.EditValueChanged += ChangeValueUpdate_굴착공법;
            gridControl1.RepositoryItems.Add(repLookUp_포장종류);
        }


        /// <summary>
        /// 맨홀 규격을 조회한다.
        /// </summary>
        /// <returns></returns>
        private DataTable Qry_맨홀()
        {
            try
            {
                sqlDataQry.Fill("QRY_MANHOLE");

                DataTable dt = CUtil.GetTable(sqlDataQry.Result["QRY_MANHOLE"]);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        /// <summary>
        /// 맨홀 규격을 조회한다.
        /// </summary>
        /// <returns></returns>
        private DataTable Qry_포장종류()
        {
            try
            {
                sqlDataQry.Fill("QRY_포장종류");

                DataTable dt = CUtil.GetTable(sqlDataQry.Result["QRY_포장종류"]);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// 굴착장비를 조회한다.
        /// </summary>
        /// <returns></returns>
        private DataTable Qry_굴착장비()
        {
            try
            {
                sqlDataQry.Fill("QRY_굴착장비");

                DataTable dt = CUtil.GetTable(sqlDataQry.Result["QRY_굴착장비"]);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 굴착공법 조회한다.
        /// </summary>
        /// <returns></returns>
        private DataTable Qry_굴착공법()
        {
            try
            {
                sqlDataQry.Fill("QRY_굴착공법");

                DataTable dt = CUtil.GetTable(sqlDataQry.Result["QRY_굴착공법"]);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        /// <summary>
        /// 맨홀 규격을 조회한다.
        /// </summary>
        /// <returns></returns>
        private void Qry_PIPE()
        {
            DataTable dt = new DataTable();
            CMySql mysql = new CMySql();
            
           
            try
            {
                mysql.Connect();

                using (MySqlCommand mycommand = mysql.Connection.CreateCommand())
                {
                    mycommand.Connection = mysql.Connection;

                    //DELETE PIPE01M00
                    CustomSqlQuery query = sqlDataQry.Queries["QRY_PIPE"] as CustomSqlQuery;
                    mycommand.CommandText = query.Sql;
                    mycommand.Parameters.Clear();

                    mycommand.Parameters.AddWithValue("@P_PROJECT_CD", PrjInfo.ProjectCd);
                    MySqlDataAdapter adpt = new MySqlDataAdapter(mycommand);
                    adpt.Fill(dt);
                }

                gridControl1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.Message;
            }
            finally
            {
                mysql.Connection.Close();
            }

         
         }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Qry_PIPE();
        }

        private void advBandedGridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
        }

        private void frmModify_Load(object sender, EventArgs e)
        {
            GridView1.OptionsBehavior.Editable = true;
            //repLookUp.DataSource = Qry_굴착장비();
            ////repLookUp.PopulateViewColumns();

            //repLookUp2.DataSource = new BindingSource( Qry_맨홀(), null);
            //repLookUp2.PopulateViewColumns();

            //GridView1.Columns["PAVE"].OptionsColumn.AllowEdit = true;
            //GridView1.Columns["PAVE"].ColumnEdit = repLookUp;

            GridView1.Columns["PAVE_CD"].OptionsColumn.AllowEdit = true;
            GridView1.Columns["PAVE_CD"].ColumnEdit = repLookUp_포장종류;

            GridView1.Columns["PAVE_TYPE_CD"].OptionsColumn.AllowEdit = true;
            GridView1.Columns["PAVE_TYPE_CD"].ColumnEdit = repLookUp_포장공법;

            GridView1.Columns["BH_CD"].OptionsColumn.AllowEdit = true;
            GridView1.Columns["BH_CD"].ColumnEdit = repLookUp_굴착장비;

            GridView1.Columns["MH_CD"].OptionsColumn.AllowEdit = true;
            GridView1.Columns["MH_CD"].ColumnEdit = repLookUp_맨홀규격;
        }

        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
            
        }

        private void ChangeValueUpdate_굴착장비(object sender, EventArgs e)
        {
            //RepositoryItemGridLookUpEdit item = (RepositoryItemGridLookUpEdit)sender;

            if( ((DevExpress.XtraEditors.BaseEdit)sender).EditValue is null)
            {
                MsgCaption.Caption = "데이터가 없습니다.";
            }

            string edtvalue;
            edtvalue = ((DevExpress.XtraEditors.BaseEdit)sender).EditValue.ToString();

            UPDATE_굴착장비(edtvalue);
        }


        ///맨홀규격UPDATE
        private void UPDATE_굴착장비(string edtvalue)
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
                    DataRow dr = GridView1.GetFocusedDataRow();


                    //DELETE PIPE01M00
                    CustomSqlQuery query = sqlDataTran.Queries["UPDATE_굴착장비"] as CustomSqlQuery;
                    mycommand.CommandText = query.Sql;
                    mycommand.Parameters.Clear();


                    mycommand.Parameters.AddWithValue("@P_PROJECT_CD", PrjInfo.ProjectCd);
                    mycommand.Parameters.AddWithValue("@P_LINENAME", dr["LINENAME"]);
                    mycommand.Parameters.AddWithValue("@P_SEQ", dr["SEQ"]);
                    mycommand.Parameters.AddWithValue("@P_MNGR_BH_CD", "BH_CD");
                    mycommand.Parameters.AddWithValue("@P_BH_CD", edtvalue);
                    //mycommand.Parameters.AddWithValue("@P_BH_CD", dr["BH_CD"]);
                    mycommand.ExecuteNonQuery();

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

        private void ChangeValueUpdate_맨홀규격(object sender, EventArgs e)
        {
            //RepositoryItemGridLookUpEdit item = (RepositoryItemGridLookUpEdit)sender;

            if (((DevExpress.XtraEditors.BaseEdit)sender).EditValue is null)
            {
                MsgCaption.Caption = "데이터가 없습니다.";
            }

            string edtvalue;
            edtvalue = ((DevExpress.XtraEditors.BaseEdit)sender).EditValue.ToString();

            UPDATE_맨홀규격(edtvalue);
        }

        ///맨홀규격UPDATE
        private void UPDATE_맨홀규격(string edtvalue)
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
                    DataRow dr = GridView1.GetFocusedDataRow();


                    //DELETE PIPE01M00
                    CustomSqlQuery query = sqlDataTran.Queries["UPDATE_맨홀규격"] as CustomSqlQuery;
                    mycommand.CommandText = query.Sql;
                    mycommand.Parameters.Clear();



                    mycommand.Parameters.AddWithValue("@P_PROJECT_CD", PrjInfo.ProjectCd);
                    mycommand.Parameters.AddWithValue("@P_LINENAME", dr["LINENAME"]);
                    mycommand.Parameters.AddWithValue("@P_SEQ", dr["SEQ"]);
                    mycommand.Parameters.AddWithValue("@P_MNGR_MH_CD", "MH_CD");
                    mycommand.Parameters.AddWithValue("@P_MH_CD", edtvalue);
                    mycommand.ExecuteNonQuery();

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

        private void ChangeValueUpdate_포장종류(object sender, EventArgs e)
        {
            //RepositoryItemGridLookUpEdit item = (RepositoryItemGridLookUpEdit)sender;
            if (((DevExpress.XtraEditors.BaseEdit)sender).EditValue is null)
            {
                MsgCaption.Caption = "데이터가 없습니다.";
            }

            string edtvalue;
            edtvalue = ((DevExpress.XtraEditors.BaseEdit)sender).EditValue.ToString();

            UPDATE_포장종류(edtvalue);
            //MsgCaption.Caption = sender.ToString();
        }

        ///맨홀규격UPDATE
        private void UPDATE_포장종류(string edtvalue)
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
                    DataRow dr = GridView1.GetFocusedDataRow();


                    //DELETE PIPE01M00
                    CustomSqlQuery query = sqlDataTran.Queries["UPDATE_포장종류"] as CustomSqlQuery;
                    mycommand.CommandText = query.Sql;
                    mycommand.Parameters.Clear();



                    mycommand.Parameters.AddWithValue("@P_PROJECT_CD", PrjInfo.ProjectCd);
                    mycommand.Parameters.AddWithValue("@P_LINENAME", dr["LINENAME"]);
                    mycommand.Parameters.AddWithValue("@P_SEQ", dr["SEQ"]);
                    mycommand.Parameters.AddWithValue("@P_MNGR_PAVE_CD", "PAVE_CD");
                    mycommand.Parameters.AddWithValue("@P_PAVE_CD", edtvalue);
                    mycommand.ExecuteNonQuery();

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeValueUpdate_굴착공법(object sender, EventArgs e)
        {
            //RepositoryItemGridLookUpEdit item = (RepositoryItemGridLookUpEdit)sender;
            if (((DevExpress.XtraEditors.BaseEdit)sender).EditValue is null)
            {
                MsgCaption.Caption = "데이터가 없습니다.";
            }


            string edtvalue;
            edtvalue = ((DevExpress.XtraEditors.BaseEdit)sender).EditValue.ToString();

            UPDATE_굴착공법(edtvalue);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="edtvalue"></param>
        private void UPDATE_굴착공법(string edtvalue)
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
                    DataRow dr = GridView1.GetFocusedDataRow();


                    //DELETE PIPE01M00
                    CustomSqlQuery query = sqlDataTran.Queries["UPDATE_굴착공법"] as CustomSqlQuery;
                    mycommand.CommandText = query.Sql;
                    mycommand.Parameters.Clear();



                    mycommand.Parameters.AddWithValue("@P_PROJECT_CD", PrjInfo.ProjectCd);
                    mycommand.Parameters.AddWithValue("@P_LINENAME", dr["LINENAME"]);
                    mycommand.Parameters.AddWithValue("@P_SEQ", dr["SEQ"]);
                    mycommand.Parameters.AddWithValue("@P_MNGR_PAVE_TYPE_CD", "PAVE_TYPE_CD");
                    mycommand.Parameters.AddWithValue("@P_PAVE_TYPE_CD", edtvalue);
                    mycommand.ExecuteNonQuery();

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

        private void GridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //switch (e.Column.FieldName.ToString())
            //{
            //    case "PAVE_CD":
            //    case "PAVE_TYPE_CD":
            //    case "BH_CD":
            //    case "MH_CD":
            //        MsgCaption.Caption = "wwww";
            //        break;
            //    default:
            //        MsgCaption.Caption = "OOOOO";
            //        break;
            //}
        }
    }
}
