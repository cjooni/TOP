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

        private DataTable dt_user_info;
        private CUserInfo m_UserInfo;
        public frmLogin()
        {
            InitializeComponent();

            m_UserInfo = new CUserInfo();
        }

        public string UserId { get => userId; set => userId = value; }
        public CUserInfo UserInfo { get => m_UserInfo; set => m_UserInfo = value; }

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

                dt_user_info = CUtil.GetTable(sqlDataSource1.Result["Qry_UserID"]);

                if (dt_user_info.Rows.Count <= 0)
                {
                    InfoMsg.Caption = "등록된 사용자가 아닙니다.";
                    return;
                }
            }
            catch (Exception ex)
            {

                //InfoMsg.Caption = ex.Message;
                InfoMsg.Caption = ex.InnerException.InnerException.InnerException.Message;
                return;
            }

            UserInfo.UserID = dt_user_info.Rows[0]["USER_ID"].ToString();
            UserInfo.UserNM = dt_user_info.Rows[0]["USER_NM"].ToString();

            DialogResult = DialogResult.OK;

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}