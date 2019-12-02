using DevExpress.DataAccess.Sql;
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
    public partial class frmProjectInfo : TOP.Parent.PForm
    {
        private CPrjInfo prjInfo;

        internal CPrjInfo PrjInfo { get => prjInfo; set => prjInfo = value; }

        public frmProjectInfo()
        {
            InitializeComponent();

            PrjInfo = new CPrjInfo();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlQuery query = sqlDataSource1.Queries["QRY_PROJECT_INFO"];
            try
            {


                foreach (QueryParameter item in sqlDataSource1.Queries["QRY_PROJECT_INFO"].Parameters)
                {
                    if (item.Name == "P_PROJECT_NM")
                    {
                        item.Value = edtProjectNm.Text;
                    }

                    if (item.Name == "P_END_YN")
                    {
                        if (chkEndYn.Checked == true)
                        {
                            //완료 포함이면 전체 조회
                            item.Value = "";
                        }
                        else
                        {
                            //완료 포함이 아니면 진행중인것만 
                            item.Value = "N";
                        }
                             
                    }
               
                }

                sqlDataSource1.Fill("QRY_PROJECT_INFO");

               DataTable dt = CUtil.GetTable(sqlDataSource1.Result["QRY_PROJECT_INFO"]);

                gridProjectInfo.DataSource = dt;
                //gridProjectInfo.DataSource

                //if (dt.Rows[0]["CNT"].ToString() != "1")
                //{
                //    InfoMsg.Caption = "등록된 사용자가 아닙니다.";
                //    return;
                //}
            }
            catch (Exception ex)
            {

                //InfoMsg.Caption = ex.Message;
            }

            //UserId = edtID.Text;
            //DialogResult = DialogResult.OK;

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetFocusedDataRow();

            CPrjInfo PrjInfo = new CPrjInfo();
            PrjInfo.ProjectCd = dr["PROJECT_CD"].ToString();
            PrjInfo.ProjectNm = dr["PROJECT_NM"].ToString();

            this.PrjInfo = PrjInfo;
            DialogResult = DialogResult.OK;

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
           
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataRow dr = gridView1.GetFocusedDataRow();
         
            SqlQuery query = sqlDataSource2.Queries["UPDATE_PROJECT_INFO"];
            string aaa = query.ToString();
            try
            {

                sqlDataSource2.Queries["UPDATE_PROJECT_INFO"].Parameters.Find(x => x.Name == "P_PROJECT_CD").Value = dr["PROJECT_CD"].ToString();
                sqlDataSource2.Queries["UPDATE_PROJECT_INFO"].Parameters.Find(x => x.Name == "P_PROJECT_NM").Value = dr["PROJECT_NM"].ToString();
                sqlDataSource2.Queries["UPDATE_PROJECT_INFO"].Parameters.Find(x => x.Name == "P_START_DT").Value = dr["START_DT"].ToString();
                sqlDataSource2.Queries["UPDATE_PROJECT_INFO"].Parameters.Find(x => x.Name == "P_END_DT").Value = dr["END_DT"].ToString();
                sqlDataSource2.Queries["UPDATE_PROJECT_INFO"].Parameters.Find(x => x.Name == "P_CLIENT_CD").Value = dr["CLIENT_CD"].ToString();
                sqlDataSource2.Queries["UPDATE_PROJECT_INFO"].Parameters.Find(x => x.Name == "P_CLIENT_ID").Value = dr["CLIENT_ID"].ToString();
                SqlDataSource.DisableCustomQueryValidation = true;
                
                sqlDataSource2.Fill();
            

             //   sqlDataSource1.Fill();

             //   DataTable dt = CUtil.GetTable(sqlDataSource1.Result["QRY_PROJECT_INFO"]);

             //   gridProjectInfo.DataSource = dt;
                //gridProjectInfo.DataSource

                //if (dt.Rows[0]["CNT"].ToString() != "1")
                //{
                //    InfoMsg.Caption = "등록된 사용자가 아닙니다.";
                //    return;
                //}
            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.Message;
                
            }


        }
    }
}
