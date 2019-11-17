using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Sql.DataApi;
using DevExpress.Data;
using TOP.lib;

namespace TOP
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private String userId;
        public frmLogin()
        {
            InitializeComponent();
        }

        public string UserId { get => userId; set => userId = value; }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            SqlQuery query = sqlDataSource1.Queries["Qry_UserID"];
            try
            {
                

                foreach (QueryParameter item in sqlDataSource1.Queries["Qry_UserID"].Parameters)
                {
                    if (item.Name == "P_USER_ID")
                    {
                        item.Value = edtID.Text.ToString().PadRight(8);
                    }
                }

                sqlDataSource1.Fill();

                DataTable dt = CUtil.GetTable(sqlDataSource1.Result["Qry_UserID"]);

                
               

                if (dt.Rows[0]["CNT"].ToString() != "1")
                {
                    InfoMsg.Caption = "등록된 사용자가 아닙니다.";
                    return;
                }
            }
            catch (Exception ex)
            {

                InfoMsg.Caption = ex.Message;
            }

            UserId = edtID.Text;
            DialogResult = DialogResult.OK;

        }
    }
}