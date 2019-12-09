namespace TOP.Dialog
{
    partial class frmProjectMngr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectMngr));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.edtProjectNm = new DevExpress.XtraEditors.TextEdit();
            this.dateStart = new DevExpress.XtraEditors.DateEdit();
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.item0 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPROJECT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROJECT_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTART_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEND_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_ID_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_TM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEND_YN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEND_YN_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtProjectNm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.xtraTabControl1);
            this.layoutControl1.Controls.Add(this.edtProjectNm);
            this.layoutControl1.Controls.Add(this.dateStart);
            this.layoutControl1.Controls.Add(this.dateEnd);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1522, 966);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // edtProjectNm
            // 
            this.edtProjectNm.Location = new System.Drawing.Point(105, 12);
            this.edtProjectNm.Name = "edtProjectNm";
            this.edtProjectNm.Size = new System.Drawing.Size(298, 34);
            this.edtProjectNm.StyleController = this.layoutControl1;
            this.edtProjectNm.TabIndex = 7;
            // 
            // dateStart
            // 
            this.dateStart.EditValue = null;
            this.dateStart.Location = new System.Drawing.Point(105, 50);
            this.dateStart.Name = "dateStart";
            this.dateStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Properties.DisplayFormat.FormatString = "";
            this.dateStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStart.Properties.EditFormat.FormatString = "";
            this.dateStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStart.Size = new System.Drawing.Size(278, 34);
            this.dateStart.StyleController = this.layoutControl1;
            this.dateStart.TabIndex = 8;
            // 
            // dateEnd
            // 
            this.dateEnd.EditValue = null;
            this.dateEnd.Location = new System.Drawing.Point(500, 50);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Size = new System.Drawing.Size(278, 34);
            this.dateEnd.StyleController = this.layoutControl1;
            this.dateEnd.TabIndex = 9;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1343, 88);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(167, 36);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "조회";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(1176, 88);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(163, 36);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "신규";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.item0,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem5,
            this.emptySpaceItem5,
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.emptySpaceItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1522, 966);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.edtProjectNm;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "프로젝트명";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(395, 38);
            this.layoutControlItem4.Text = "프로젝트명";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(90, 25);
            // 
            // item0
            // 
            this.item0.Control = this.dateStart;
            this.item0.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.item0.CustomizationFormText = "시작일";
            this.item0.Location = new System.Drawing.Point(0, 38);
            this.item0.Name = "item0";
            this.item0.Size = new System.Drawing.Size(375, 38);
            this.item0.Text = "시작일";
            this.item0.TextSize = new System.Drawing.Size(90, 25);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(395, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1107, 38);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(770, 38);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(732, 38);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dateEnd;
            this.layoutControlItem5.Location = new System.Drawing.Point(395, 38);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(375, 38);
            this.layoutControlItem5.Text = "종료일";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(90, 25);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(375, 38);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(20, 38);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton1;
            this.layoutControlItem2.Location = new System.Drawing.Point(1331, 76);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(171, 40);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButton2;
            this.layoutControlItem6.Location = new System.Drawing.Point(1164, 76);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(167, 40);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 76);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(1164, 40);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(1, 41);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(1496, 784);
            this.layoutControl2.TabIndex = 2;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1496, 784);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "QRY_PROJECT";
            queryParameter1.Name = "P_PROJECT_NM";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "  ";
            queryParameter2.Name = "P_START_DT";
            queryParameter2.Type = typeof(string);
            queryParameter2.ValueInfo = "20111111";
            queryParameter3.Name = "P_END_DT";
            queryParameter3.Type = typeof(string);
            queryParameter3.ValueInfo = "20191220";
            customSqlQuery1.Parameters.Add(queryParameter1);
            customSqlQuery1.Parameters.Add(queryParameter2);
            customSqlQuery1.Parameters.Add(queryParameter3);
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1496, 784);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1496, 784);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.xtraTabControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 116);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1502, 830);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 128);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1498, 826);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1472, 760);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPROJECT_CD,
            this.colPROJECT_NM,
            this.colSTART_DT,
            this.colEND_DT,
            this.colCLIENT_CD,
            this.colCLIENT_NM,
            this.colCLIENT_ID,
            this.colCLIENT_ID_NM,
            this.colWORK_DT,
            this.colWORK_TM,
            this.colEND_YN,
            this.colEND_YN_DESC});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 2;
            this.gridView1.ShowingPopupEditForm += new DevExpress.XtraGrid.Views.Grid.ShowingPopupEditFormEventHandler(this.gridView1_ShowingPopupEditForm);
            // 
            // colPROJECT_CD
            // 
            this.colPROJECT_CD.Caption = "프로젝트 코드";
            this.colPROJECT_CD.FieldName = "PROJECT_CD";
            this.colPROJECT_CD.MinWidth = 30;
            this.colPROJECT_CD.Name = "colPROJECT_CD";
            this.colPROJECT_CD.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colPROJECT_CD.Visible = true;
            this.colPROJECT_CD.VisibleIndex = 0;
            this.colPROJECT_CD.Width = 112;
            // 
            // colPROJECT_NM
            // 
            this.colPROJECT_NM.Caption = "프로젝트명";
            this.colPROJECT_NM.FieldName = "PROJECT_NM";
            this.colPROJECT_NM.MinWidth = 30;
            this.colPROJECT_NM.Name = "colPROJECT_NM";
            this.colPROJECT_NM.Visible = true;
            this.colPROJECT_NM.VisibleIndex = 1;
            this.colPROJECT_NM.Width = 112;
            // 
            // colSTART_DT
            // 
            this.colSTART_DT.Caption = "시작일";
            this.colSTART_DT.ColumnEdit = this.repositoryItemDateEdit1;
            this.colSTART_DT.FieldName = "START_DT";
            this.colSTART_DT.MinWidth = 30;
            this.colSTART_DT.Name = "colSTART_DT";
            this.colSTART_DT.OptionsEditForm.StartNewRow = true;
            this.colSTART_DT.Visible = true;
            this.colSTART_DT.VisibleIndex = 2;
            this.colSTART_DT.Width = 112;
            // 
            // colEND_DT
            // 
            this.colEND_DT.Caption = "종료일";
            this.colEND_DT.ColumnEdit = this.repositoryItemDateEdit1;
            this.colEND_DT.FieldName = "END_DT";
            this.colEND_DT.MinWidth = 30;
            this.colEND_DT.Name = "colEND_DT";
            this.colEND_DT.Visible = true;
            this.colEND_DT.VisibleIndex = 3;
            this.colEND_DT.Width = 112;
            // 
            // colCLIENT_CD
            // 
            this.colCLIENT_CD.Caption = "발주처코드";
            this.colCLIENT_CD.FieldName = "CLIENT_CD";
            this.colCLIENT_CD.MinWidth = 30;
            this.colCLIENT_CD.Name = "colCLIENT_CD";
            this.colCLIENT_CD.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colCLIENT_CD.Visible = true;
            this.colCLIENT_CD.VisibleIndex = 4;
            this.colCLIENT_CD.Width = 112;
            // 
            // colCLIENT_NM
            // 
            this.colCLIENT_NM.Caption = "발주처";
            this.colCLIENT_NM.FieldName = "CLIENT_NM";
            this.colCLIENT_NM.MinWidth = 30;
            this.colCLIENT_NM.Name = "colCLIENT_NM";
            this.colCLIENT_NM.Visible = true;
            this.colCLIENT_NM.VisibleIndex = 5;
            this.colCLIENT_NM.Width = 112;
            // 
            // colCLIENT_ID
            // 
            this.colCLIENT_ID.Caption = "담당자코드";
            this.colCLIENT_ID.FieldName = "CLIENT_ID";
            this.colCLIENT_ID.MinWidth = 30;
            this.colCLIENT_ID.Name = "colCLIENT_ID";
            this.colCLIENT_ID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colCLIENT_ID.Visible = true;
            this.colCLIENT_ID.VisibleIndex = 6;
            this.colCLIENT_ID.Width = 112;
            // 
            // colCLIENT_ID_NM
            // 
            this.colCLIENT_ID_NM.Caption = "담당자";
            this.colCLIENT_ID_NM.FieldName = "CLIENT_ID_NM";
            this.colCLIENT_ID_NM.MinWidth = 30;
            this.colCLIENT_ID_NM.Name = "colCLIENT_ID_NM";
            this.colCLIENT_ID_NM.Visible = true;
            this.colCLIENT_ID_NM.VisibleIndex = 7;
            this.colCLIENT_ID_NM.Width = 112;
            // 
            // colWORK_DT
            // 
            this.colWORK_DT.Caption = "등록일자";
            this.colWORK_DT.FieldName = "WORK_DT";
            this.colWORK_DT.MinWidth = 30;
            this.colWORK_DT.Name = "colWORK_DT";
            this.colWORK_DT.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colWORK_DT.Visible = true;
            this.colWORK_DT.VisibleIndex = 8;
            this.colWORK_DT.Width = 112;
            // 
            // colWORK_TM
            // 
            this.colWORK_TM.Caption = "등록시간";
            this.colWORK_TM.FieldName = "WORK_TM";
            this.colWORK_TM.MinWidth = 30;
            this.colWORK_TM.Name = "colWORK_TM";
            this.colWORK_TM.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colWORK_TM.Visible = true;
            this.colWORK_TM.VisibleIndex = 9;
            this.colWORK_TM.Width = 112;
            // 
            // colEND_YN
            // 
            this.colEND_YN.Caption = "종료여부코드";
            this.colEND_YN.FieldName = "END_YN";
            this.colEND_YN.MinWidth = 30;
            this.colEND_YN.Name = "colEND_YN";
            this.colEND_YN.Visible = true;
            this.colEND_YN.VisibleIndex = 10;
            this.colEND_YN.Width = 112;
            // 
            // colEND_YN_DESC
            // 
            this.colEND_YN_DESC.Caption = "종료여부";
            this.colEND_YN_DESC.FieldName = "END_YN_DESC";
            this.colEND_YN_DESC.MinWidth = 30;
            this.colEND_YN_DESC.Name = "colEND_YN_DESC";
            this.colEND_YN_DESC.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colEND_YN_DESC.Visible = true;
            this.colEND_YN_DESC.VisibleIndex = 11;
            this.colEND_YN_DESC.Width = 112;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // frmProjectMngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.ClientSize = new System.Drawing.Size(1522, 1002);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmProjectMngr";
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edtProjectNm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit edtProjectNm;
        private DevExpress.XtraEditors.DateEdit dateStart;
        private DevExpress.XtraEditors.DateEdit dateEnd;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem item0;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJECT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJECT_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colSTART_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colEND_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_ID_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_TM;
        private DevExpress.XtraGrid.Columns.GridColumn colEND_YN;
        private DevExpress.XtraGrid.Columns.GridColumn colEND_YN_DESC;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
    }
}
