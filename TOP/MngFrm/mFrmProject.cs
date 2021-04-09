using DevExpress.DataAccess.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TOP.lib;

namespace TOP.MngFrm
{
    public partial class mFrmProject : TOP.Parent.PForm
    {
        public mFrmProject()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                sqlDataSource1.Queries["INSERT_PRJ01M00"].Parameters.Find(x => x.Name == "P_PROJECT_NM").Value = edtProjectNm.Text.ToString();
                sqlDataSource1.Queries["INSERT_PRJ01M00"].Parameters.Find(x => x.Name == "P_CLIENT_CD").Value = lookUpClient.GetColumnValue("CLIENT_CD").ToString();
                sqlDataSource1.Queries["INSERT_PRJ01M00"].Parameters.Find(x => x.Name == "P_PROJECT_DESC").Value = memoDesc.Text;
                sqlDataSource1.Queries["INSERT_PRJ01M00"].Parameters.Find(x => x.Name == "P_FROM_DT").Value = dateFromDt.DateTime.ToString("yyyyMMdd");

                sqlDataSource1.Queries["INSERT_PRJ01M00"].Parameters.Find(x => x.Name == "P_TO_DT").Value = dateToDt.DateTime.ToString("yyyyMMdd");


                SqlDataSource.DisableCustomQueryValidation = true;

                sqlDataSource1.Fill("INSERT_PRJ01M00");

                MsgCaption.Caption = "등록 되었습니다.";

                qry_prj01m00();
            }
            catch (Exception ex )
            {
                MsgCaption.Caption = ex.Message;
                
            }


        }

        private void QRY_CLIENT_INFO()
        {
            sqlDataSource2.Fill("QRY_CLIENT_INFO");
            DataTable dt = CUtil.GetTable(sqlDataSource2.Result["QRY_CLIENT_INFO"]);
            lookUpClient.Properties.DataSource = dt;
        }

        private void qry_prj01m00()
        {
            sqlDataSource1.Fill("QRY_PRJ01M00");
            DataTable dt = CUtil.GetTable(sqlDataSource1.Result["QRY_PRJ01M00"]);
            gridControl1.DataSource = dt;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            qry_prj01m00();
        }

        private void mFrmProject_Load(object sender, EventArgs e)
        {
            qry_prj01m00();
            QRY_CLIENT_INFO();

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetFocusedDataRow();

            edtProjectCd.Text   = dr["PROJECT_CD"].ToString();
            edtProjectNm.Text   = dr["PROJECT_NM"].ToString();
            lookUpClient.EditValue  = dr["CLIENT_CD"].ToString();
            dateFromDt.DateTime = DateTime.ParseExact(dr["FROM_DT"].ToString(), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
            dateToDt.DateTime = DateTime.ParseExact(dr["TO_DT"].ToString(), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);

        }
    }
}
