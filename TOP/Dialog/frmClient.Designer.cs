namespace TOP.Dialog
{
    partial class frmClient
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter8 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter9 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col고객코드 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col고객명 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col대표전화 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col주소 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.edtClientNm = new DevExpress.XtraEditors.TextEdit();
            this.btnQryClient = new DevExpress.XtraEditors.SimpleButton();
            this.edtClientCd = new DevExpress.XtraEditors.TextEdit();
            this.edtOffice = new DevExpress.XtraEditors.TextEdit();
            this.edtAddress = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtClientNm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtClientCd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtOffice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.edtClientNm);
            this.layoutControl1.Controls.Add(this.btnQryClient);
            this.layoutControl1.Controls.Add(this.edtClientCd);
            this.layoutControl1.Controls.Add(this.edtOffice);
            this.layoutControl1.Controls.Add(this.edtAddress);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1301, 939);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 204);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1277, 723);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col고객코드,
            this.col고객명,
            this.col대표전화,
            this.col주소});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.ShowingPopupEditForm += new DevExpress.XtraGrid.Views.Grid.ShowingPopupEditFormEventHandler(this.gridView1_ShowingPopupEditForm);
            // 
            // col고객코드
            // 
            this.col고객코드.AppearanceHeader.Options.UseTextOptions = true;
            this.col고객코드.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col고객코드.Caption = "고객코드";
            this.col고객코드.FieldName = "CLIENT_CD";
            this.col고객코드.MinWidth = 30;
            this.col고객코드.Name = "col고객코드";
            this.col고객코드.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.col고객코드.Visible = true;
            this.col고객코드.VisibleIndex = 0;
            this.col고객코드.Width = 112;
            // 
            // col고객명
            // 
            this.col고객명.AppearanceHeader.Options.UseTextOptions = true;
            this.col고객명.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col고객명.Caption = "고객명";
            this.col고객명.FieldName = "CLIENT_NM";
            this.col고객명.MinWidth = 30;
            this.col고객명.Name = "col고객명";
            this.col고객명.Visible = true;
            this.col고객명.VisibleIndex = 1;
            this.col고객명.Width = 112;
            // 
            // col대표전화
            // 
            this.col대표전화.AppearanceHeader.Options.UseTextOptions = true;
            this.col대표전화.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col대표전화.Caption = "대표전화";
            this.col대표전화.FieldName = "OFFICE";
            this.col대표전화.MinWidth = 30;
            this.col대표전화.Name = "col대표전화";
            this.col대표전화.Visible = true;
            this.col대표전화.VisibleIndex = 2;
            this.col대표전화.Width = 112;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "999)999-9999";
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // col주소
            // 
            this.col주소.AppearanceHeader.Options.UseTextOptions = true;
            this.col주소.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col주소.Caption = "주소";
            this.col주소.FieldName = "ADDRESS";
            this.col주소.MinWidth = 30;
            this.col주소.Name = "col주소";
            this.col주소.Visible = true;
            this.col주소.VisibleIndex = 3;
            this.col주소.Width = 112;
            // 
            // edtClientNm
            // 
            this.edtClientNm.Location = new System.Drawing.Point(87, 12);
            this.edtClientNm.Name = "edtClientNm";
            this.edtClientNm.Size = new System.Drawing.Size(457, 34);
            this.edtClientNm.StyleController = this.layoutControl1;
            this.edtClientNm.TabIndex = 5;
            // 
            // btnQryClient
            // 
            this.btnQryClient.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQryClient.ImageOptions.Image")));
            this.btnQryClient.Location = new System.Drawing.Point(1177, 164);
            this.btnQryClient.Name = "btnQryClient";
            this.btnQryClient.Size = new System.Drawing.Size(112, 36);
            this.btnQryClient.StyleController = this.layoutControl1;
            this.btnQryClient.TabIndex = 6;
            this.btnQryClient.Text = "조회";
            this.btnQryClient.Click += new System.EventHandler(this.btnQryClient_Click);
            // 
            // edtClientCd
            // 
            this.edtClientCd.Location = new System.Drawing.Point(87, 50);
            this.edtClientCd.Name = "edtClientCd";
            this.edtClientCd.Size = new System.Drawing.Size(235, 34);
            this.edtClientCd.StyleController = this.layoutControl1;
            this.edtClientCd.TabIndex = 7;
            // 
            // edtOffice
            // 
            this.edtOffice.Location = new System.Drawing.Point(87, 88);
            this.edtOffice.Name = "edtOffice";
            this.edtOffice.Size = new System.Drawing.Size(235, 34);
            this.edtOffice.StyleController = this.layoutControl1;
            this.edtOffice.TabIndex = 8;
            // 
            // edtAddress
            // 
            this.edtAddress.Location = new System.Drawing.Point(87, 126);
            this.edtAddress.Name = "edtAddress";
            this.edtAddress.Size = new System.Drawing.Size(1202, 34);
            this.edtAddress.StyleController = this.layoutControl1;
            this.edtAddress.TabIndex = 9;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1054, 164);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(119, 36);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "신규";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.layoutControlItem7,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1301, 939);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 192);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1281, 727);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.edtClientNm;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(536, 38);
            this.layoutControlItem2.Text = "고객명";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 25);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnQryClient;
            this.layoutControlItem3.Location = new System.Drawing.Point(1165, 152);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(116, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.edtClientCd;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 38);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(314, 38);
            this.layoutControlItem4.Text = "고객코드";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(72, 25);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.edtOffice;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 76);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(314, 38);
            this.layoutControlItem5.Text = "대표전화";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(72, 25);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.edtAddress;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 114);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(1281, 38);
            this.layoutControlItem6.Text = "주소";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(72, 25);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(536, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(745, 38);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(314, 38);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(967, 38);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(314, 76);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(967, 38);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.simpleButton1;
            this.layoutControlItem7.Location = new System.Drawing.Point(1042, 152);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(123, 40);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 152);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1042, 40);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "QRY_CLIENT";
            queryParameter1.Name = "P_CLIENT_NM";
            queryParameter1.Type = typeof(string);
            queryParameter2.Name = "P_ADDRESS";
            queryParameter2.Type = typeof(string);
            customSqlQuery1.Parameters.Add(queryParameter1);
            customSqlQuery1.Parameters.Add(queryParameter2);
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            customSqlQuery2.Name = "INSERT_CLIENT";
            queryParameter3.Name = "P_CLIENT_NM";
            queryParameter3.Type = typeof(string);
            queryParameter4.Name = "P_OFFICE";
            queryParameter4.Type = typeof(string);
            queryParameter5.Name = "P_ADDRESS";
            queryParameter5.Type = typeof(string);
            customSqlQuery2.Parameters.Add(queryParameter3);
            customSqlQuery2.Parameters.Add(queryParameter4);
            customSqlQuery2.Parameters.Add(queryParameter5);
            customSqlQuery2.Sql = "INSERT INTO CLIENT01M00 (CLIENT_CD, CLIENT_NM, OFFICE, ADDRESS)\r\nSELECT LPAD(COUN" +
    "T(*), 10, \'0\')\r\n      ,:P_CLIENT_NM\r\n      ,:P_OFFICE\r\n      ,:P_ADDRESS\r\n  FROM" +
    " CLIENT01M00";
            customSqlQuery3.Name = "UPDATE_CLIENT";
            queryParameter6.Name = "P_CLIENT_NM";
            queryParameter6.Type = typeof(string);
            queryParameter7.Name = "P_OFFICE";
            queryParameter7.Type = typeof(string);
            queryParameter8.Name = "P_ADDRESS";
            queryParameter8.Type = typeof(string);
            queryParameter9.Name = "P_CLIENT_CD";
            queryParameter9.Type = typeof(string);
            customSqlQuery3.Parameters.Add(queryParameter6);
            customSqlQuery3.Parameters.Add(queryParameter7);
            customSqlQuery3.Parameters.Add(queryParameter8);
            customSqlQuery3.Parameters.Add(queryParameter9);
            customSqlQuery3.Sql = "UPDATE CLIENT01M00\r\n   SET CLIENT_NM  = TRIM(:P_CLIENT_NM)\r\n      ,OFFICE     = T" +
    "RIM(:P_OFFICE)\r\n      ,ADDRESS    = TRIM(:P_ADDRESS)\r\n WHERE CLIENT_CD = :P_CLIE" +
    "NT_CD";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2,
            customSqlQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.ClientSize = new System.Drawing.Size(1301, 975);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmClient";
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtClientNm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtClientCd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtOffice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit edtClientNm;
        private DevExpress.XtraEditors.SimpleButton btnQryClient;
        private DevExpress.XtraEditors.TextEdit edtClientCd;
        private DevExpress.XtraEditors.TextEdit edtOffice;
        private DevExpress.XtraEditors.TextEdit edtAddress;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn col고객코드;
        private DevExpress.XtraGrid.Columns.GridColumn col고객명;
        private DevExpress.XtraGrid.Columns.GridColumn col대표전화;
        private DevExpress.XtraGrid.Columns.GridColumn col주소;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}
