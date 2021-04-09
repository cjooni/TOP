namespace TOP.Dialog
{
    partial class frmUserMngr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserMngr));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter8 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter9 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter10 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter11 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter12 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter13 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter14 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter15 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter16 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.aa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMNGR_GRADE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHP_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEL_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOFFICE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPSWD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_EMPL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_DTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.edtUserID = new DevExpress.XtraEditors.TextEdit();
            this.edtUserNM = new DevExpress.XtraEditors.TextEdit();
            this.v = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtUserID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtUserNM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.edtUserID);
            this.layoutControl1.Controls.Add(this.edtUserNM);
            this.layoutControl1.Controls.Add(this.v);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1301, 940);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(992, 48);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(146, 36);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "신규";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.gridControl1.Location = new System.Drawing.Point(12, 88);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1277, 840);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.aa,
            this.colUSER_NM,
            this.colMNGR_GRADE,
            this.colHP_NO,
            this.colTEL_NO,
            this.colOFFICE_NO,
            this.colPSWD,
            this.colWORK_EMPL,
            this.colWORK_DTM});
            this.gridView1.DetailHeight = 397;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.EditFormShowing += new DevExpress.XtraGrid.Views.Grid.EditFormShowingEventHandler(this.gridView1_EditFormShowing);
            this.gridView1.ShowingPopupEditForm += new DevExpress.XtraGrid.Views.Grid.ShowingPopupEditFormEventHandler(this.gridView1_ShowingPopupEditForm);
            // 
            // aa
            // 
            this.aa.AppearanceHeader.Options.UseTextOptions = true;
            this.aa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.aa.Caption = "사용자 ID";
            this.aa.FieldName = "USER_ID";
            this.aa.MinWidth = 30;
            this.aa.Name = "aa";
            this.aa.Visible = true;
            this.aa.VisibleIndex = 0;
            this.aa.Width = 111;
            // 
            // colUSER_NM
            // 
            this.colUSER_NM.AppearanceHeader.Options.UseTextOptions = true;
            this.colUSER_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSER_NM.Caption = "사용자명";
            this.colUSER_NM.FieldName = "USER_NM";
            this.colUSER_NM.MinWidth = 30;
            this.colUSER_NM.Name = "colUSER_NM";
            this.colUSER_NM.Visible = true;
            this.colUSER_NM.VisibleIndex = 1;
            this.colUSER_NM.Width = 111;
            // 
            // colMNGR_GRADE
            // 
            this.colMNGR_GRADE.AppearanceHeader.Options.UseTextOptions = true;
            this.colMNGR_GRADE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMNGR_GRADE.FieldName = "MNGR_GRADE";
            this.colMNGR_GRADE.MinWidth = 30;
            this.colMNGR_GRADE.Name = "colMNGR_GRADE";
            this.colMNGR_GRADE.Visible = true;
            this.colMNGR_GRADE.VisibleIndex = 2;
            this.colMNGR_GRADE.Width = 111;
            // 
            // colHP_NO
            // 
            this.colHP_NO.AppearanceHeader.Options.UseTextOptions = true;
            this.colHP_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHP_NO.Caption = "휴대전화";
            this.colHP_NO.FieldName = "HP_NO";
            this.colHP_NO.MinWidth = 30;
            this.colHP_NO.Name = "colHP_NO";
            this.colHP_NO.Visible = true;
            this.colHP_NO.VisibleIndex = 3;
            this.colHP_NO.Width = 111;
            // 
            // colTEL_NO
            // 
            this.colTEL_NO.AppearanceHeader.Options.UseTextOptions = true;
            this.colTEL_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTEL_NO.Caption = "일반전화";
            this.colTEL_NO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTEL_NO.FieldName = "TEL_NO";
            this.colTEL_NO.MinWidth = 30;
            this.colTEL_NO.Name = "colTEL_NO";
            this.colTEL_NO.Visible = true;
            this.colTEL_NO.VisibleIndex = 4;
            this.colTEL_NO.Width = 111;
            // 
            // colOFFICE_NO
            // 
            this.colOFFICE_NO.AppearanceHeader.Options.UseTextOptions = true;
            this.colOFFICE_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOFFICE_NO.Caption = "사무실";
            this.colOFFICE_NO.FieldName = "OFFICE_NO";
            this.colOFFICE_NO.MinWidth = 30;
            this.colOFFICE_NO.Name = "colOFFICE_NO";
            this.colOFFICE_NO.Visible = true;
            this.colOFFICE_NO.VisibleIndex = 5;
            this.colOFFICE_NO.Width = 111;
            // 
            // colPSWD
            // 
            this.colPSWD.AppearanceHeader.Options.UseTextOptions = true;
            this.colPSWD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPSWD.Caption = "비밀번호";
            this.colPSWD.FieldName = "PSWD";
            this.colPSWD.MinWidth = 30;
            this.colPSWD.Name = "colPSWD";
            this.colPSWD.Visible = true;
            this.colPSWD.VisibleIndex = 6;
            this.colPSWD.Width = 111;
            // 
            // colWORK_EMPL
            // 
            this.colWORK_EMPL.AppearanceHeader.Options.UseTextOptions = true;
            this.colWORK_EMPL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWORK_EMPL.Caption = "등록자";
            this.colWORK_EMPL.FieldName = "WORK_EMPL";
            this.colWORK_EMPL.MinWidth = 30;
            this.colWORK_EMPL.Name = "colWORK_EMPL";
            this.colWORK_EMPL.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colWORK_EMPL.Visible = true;
            this.colWORK_EMPL.VisibleIndex = 7;
            this.colWORK_EMPL.Width = 111;
            // 
            // colWORK_DTM
            // 
            this.colWORK_DTM.AppearanceHeader.Options.UseTextOptions = true;
            this.colWORK_DTM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWORK_DTM.Caption = "등록시간";
            this.colWORK_DTM.FieldName = "WORK_DTM";
            this.colWORK_DTM.MinWidth = 30;
            this.colWORK_DTM.Name = "colWORK_DTM";
            this.colWORK_DTM.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colWORK_DTM.Visible = true;
            this.colWORK_DTM.VisibleIndex = 8;
            this.colWORK_DTM.Width = 111;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // edtUserID
            // 
            this.edtUserID.Location = new System.Drawing.Point(93, 12);
            this.edtUserID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edtUserID.Name = "edtUserID";
            this.edtUserID.Size = new System.Drawing.Size(247, 34);
            this.edtUserID.StyleController = this.layoutControl1;
            this.edtUserID.TabIndex = 5;
            // 
            // edtUserNM
            // 
            this.edtUserNM.Location = new System.Drawing.Point(93, 50);
            this.edtUserNM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edtUserNM.Name = "edtUserNM";
            this.edtUserNM.Size = new System.Drawing.Size(247, 34);
            this.edtUserNM.StyleController = this.layoutControl1;
            this.edtUserNM.TabIndex = 6;
            // 
            // v
            // 
            this.v.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("v.ImageOptions.Image")));
            this.v.Location = new System.Drawing.Point(1142, 48);
            this.v.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(147, 36);
            this.v.StyleController = this.layoutControl1;
            this.v.TabIndex = 7;
            this.v.Text = "조회";
            this.v.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1301, 940);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 76);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1281, 844);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.edtUserID;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(332, 38);
            this.layoutControlItem2.Text = "사용자 ID";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(78, 25);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.edtUserNM;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 38);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(332, 38);
            this.layoutControlItem3.Text = "사용자 명";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(78, 25);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(980, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(301, 36);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.v;
            this.layoutControlItem4.Location = new System.Drawing.Point(1130, 36);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(151, 40);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButton1;
            this.layoutControlItem6.Location = new System.Drawing.Point(980, 36);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(150, 40);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(332, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(648, 76);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "QRY_USER_ID";
            queryParameter1.Name = "P_USER_ID";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = " ";
            queryParameter2.Name = "P_USER_NM";
            queryParameter2.Type = typeof(string);
            queryParameter2.ValueInfo = " ";
            customSqlQuery1.Parameters.Add(queryParameter1);
            customSqlQuery1.Parameters.Add(queryParameter2);
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            customSqlQuery2.Name = "INSERT_USER_ID";
            queryParameter3.Name = "P_USER_ID";
            queryParameter3.Type = typeof(string);
            queryParameter3.ValueInfo = "TEST3";
            queryParameter4.Name = "P_USER_NM";
            queryParameter4.Type = typeof(string);
            queryParameter5.Name = "P_MNGR_GRADE";
            queryParameter5.Type = typeof(string);
            queryParameter6.Name = "P_HP_NO";
            queryParameter6.Type = typeof(string);
            queryParameter7.Name = "P_TEL_NO";
            queryParameter7.Type = typeof(string);
            queryParameter8.Name = "P_OFFICE_NO";
            queryParameter8.Type = typeof(string);
            queryParameter9.Name = "P_PSWD";
            queryParameter9.Type = typeof(string);
            customSqlQuery2.Parameters.Add(queryParameter3);
            customSqlQuery2.Parameters.Add(queryParameter4);
            customSqlQuery2.Parameters.Add(queryParameter5);
            customSqlQuery2.Parameters.Add(queryParameter6);
            customSqlQuery2.Parameters.Add(queryParameter7);
            customSqlQuery2.Parameters.Add(queryParameter8);
            customSqlQuery2.Parameters.Add(queryParameter9);
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            customSqlQuery3.Name = "UPDATE_USER_ID";
            queryParameter10.Name = "P_USER_NM";
            queryParameter10.Type = typeof(string);
            queryParameter10.ValueInfo = "TEST";
            queryParameter11.Name = "P_MNGR_GRADE";
            queryParameter11.Type = typeof(string);
            queryParameter12.Name = "P_HP_NO";
            queryParameter12.Type = typeof(string);
            queryParameter13.Name = "P_TEL_NO";
            queryParameter13.Type = typeof(string);
            queryParameter14.Name = "P_OFFICE_NO";
            queryParameter14.Type = typeof(string);
            queryParameter15.Name = "P_PSWD";
            queryParameter15.Type = typeof(string);
            queryParameter16.Name = "P_USER_ID";
            queryParameter16.Type = typeof(string);
            customSqlQuery3.Parameters.Add(queryParameter10);
            customSqlQuery3.Parameters.Add(queryParameter11);
            customSqlQuery3.Parameters.Add(queryParameter12);
            customSqlQuery3.Parameters.Add(queryParameter13);
            customSqlQuery3.Parameters.Add(queryParameter14);
            customSqlQuery3.Parameters.Add(queryParameter15);
            customSqlQuery3.Parameters.Add(queryParameter16);
            customSqlQuery3.Sql = resources.GetString("customSqlQuery3.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2,
            customSqlQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // frmUserMngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.ClientSize = new System.Drawing.Size(1301, 975);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "frmUserMngr";
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtUserID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtUserNM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit edtUserID;
        private DevExpress.XtraEditors.TextEdit edtUserNM;
        private DevExpress.XtraEditors.SimpleButton v;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn aa;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colMNGR_GRADE;
        private DevExpress.XtraGrid.Columns.GridColumn colHP_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEL_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colOFFICE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colPSWD;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_EMPL;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_DTM;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}
