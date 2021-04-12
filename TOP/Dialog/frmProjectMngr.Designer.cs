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
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter8 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter9 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter10 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter11 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter12 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter13 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter14 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter15 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter16 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter17 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter18 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPROJECT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROJECT_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTART_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colEND_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_ID_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_TM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEND_YN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEND_YN_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.edtProjectNm = new DevExpress.XtraEditors.TextEdit();
            this.dateStart = new DevExpress.XtraEditors.DateEdit();
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.chkDate = new DevExpress.XtraEditors.CheckEdit();
            this.edtUserNm = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.item0 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonEdit2 = new DevExpress.XtraEditors.ButtonEdit();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtProjectNm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtUserNm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.edtProjectNm);
            this.layoutControl1.Controls.Add(this.dateStart);
            this.layoutControl1.Controls.Add(this.dateEnd);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.chkDate);
            this.layoutControl1.Controls.Add(this.edtUserNm);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1370, 772);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(11, 216);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1348, 546);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
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
            this.gridView1.DetailHeight = 280;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 2;
            // 
            // colPROJECT_CD
            // 
            this.colPROJECT_CD.AppearanceHeader.Options.UseTextOptions = true;
            this.colPROJECT_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPROJECT_CD.Caption = "프로젝트 코드";
            this.colPROJECT_CD.FieldName = "PROJECT_CD";
            this.colPROJECT_CD.MinWidth = 27;
            this.colPROJECT_CD.Name = "colPROJECT_CD";
            this.colPROJECT_CD.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colPROJECT_CD.Visible = true;
            this.colPROJECT_CD.VisibleIndex = 0;
            this.colPROJECT_CD.Width = 101;
            // 
            // colPROJECT_NM
            // 
            this.colPROJECT_NM.AppearanceHeader.Options.UseTextOptions = true;
            this.colPROJECT_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPROJECT_NM.Caption = "프로젝트명";
            this.colPROJECT_NM.FieldName = "PROJECT_NM";
            this.colPROJECT_NM.MinWidth = 27;
            this.colPROJECT_NM.Name = "colPROJECT_NM";
            this.colPROJECT_NM.Visible = true;
            this.colPROJECT_NM.VisibleIndex = 1;
            this.colPROJECT_NM.Width = 101;
            // 
            // colSTART_DT
            // 
            this.colSTART_DT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTART_DT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTART_DT.Caption = "시작일";
            this.colSTART_DT.ColumnEdit = this.repositoryItemDateEdit1;
            this.colSTART_DT.FieldName = "START_DT";
            this.colSTART_DT.MinWidth = 27;
            this.colSTART_DT.Name = "colSTART_DT";
            this.colSTART_DT.OptionsEditForm.StartNewRow = true;
            this.colSTART_DT.Visible = true;
            this.colSTART_DT.VisibleIndex = 2;
            this.colSTART_DT.Width = 101;
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
            // colEND_DT
            // 
            this.colEND_DT.AppearanceHeader.Options.UseTextOptions = true;
            this.colEND_DT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEND_DT.Caption = "종료일";
            this.colEND_DT.ColumnEdit = this.repositoryItemDateEdit1;
            this.colEND_DT.FieldName = "END_DT";
            this.colEND_DT.MinWidth = 27;
            this.colEND_DT.Name = "colEND_DT";
            this.colEND_DT.Visible = true;
            this.colEND_DT.VisibleIndex = 3;
            this.colEND_DT.Width = 101;
            // 
            // colCLIENT_CD
            // 
            this.colCLIENT_CD.AppearanceHeader.Options.UseTextOptions = true;
            this.colCLIENT_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCLIENT_CD.Caption = "발주처코드";
            this.colCLIENT_CD.FieldName = "CLIENT_CD";
            this.colCLIENT_CD.MinWidth = 27;
            this.colCLIENT_CD.Name = "colCLIENT_CD";
            this.colCLIENT_CD.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colCLIENT_CD.Visible = true;
            this.colCLIENT_CD.VisibleIndex = 4;
            this.colCLIENT_CD.Width = 101;
            // 
            // colCLIENT_NM
            // 
            this.colCLIENT_NM.AppearanceHeader.Options.UseTextOptions = true;
            this.colCLIENT_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCLIENT_NM.Caption = "발주처";
            this.colCLIENT_NM.FieldName = "CLIENT_NM";
            this.colCLIENT_NM.MinWidth = 27;
            this.colCLIENT_NM.Name = "colCLIENT_NM";
            this.colCLIENT_NM.Visible = true;
            this.colCLIENT_NM.VisibleIndex = 5;
            this.colCLIENT_NM.Width = 101;
            // 
            // colCLIENT_ID
            // 
            this.colCLIENT_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colCLIENT_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCLIENT_ID.Caption = "담당자코드";
            this.colCLIENT_ID.FieldName = "CLIENT_ID";
            this.colCLIENT_ID.MinWidth = 27;
            this.colCLIENT_ID.Name = "colCLIENT_ID";
            this.colCLIENT_ID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colCLIENT_ID.Visible = true;
            this.colCLIENT_ID.VisibleIndex = 6;
            this.colCLIENT_ID.Width = 101;
            // 
            // colCLIENT_ID_NM
            // 
            this.colCLIENT_ID_NM.AppearanceHeader.Options.UseTextOptions = true;
            this.colCLIENT_ID_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCLIENT_ID_NM.Caption = "담당자";
            this.colCLIENT_ID_NM.FieldName = "CLIENT_ID_NM";
            this.colCLIENT_ID_NM.MinWidth = 27;
            this.colCLIENT_ID_NM.Name = "colCLIENT_ID_NM";
            this.colCLIENT_ID_NM.Visible = true;
            this.colCLIENT_ID_NM.VisibleIndex = 7;
            this.colCLIENT_ID_NM.Width = 101;
            // 
            // colWORK_DT
            // 
            this.colWORK_DT.AppearanceHeader.Options.UseTextOptions = true;
            this.colWORK_DT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWORK_DT.Caption = "등록일자";
            this.colWORK_DT.FieldName = "WORK_DT";
            this.colWORK_DT.MinWidth = 27;
            this.colWORK_DT.Name = "colWORK_DT";
            this.colWORK_DT.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colWORK_DT.Visible = true;
            this.colWORK_DT.VisibleIndex = 8;
            this.colWORK_DT.Width = 101;
            // 
            // colWORK_TM
            // 
            this.colWORK_TM.AppearanceHeader.Options.UseTextOptions = true;
            this.colWORK_TM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWORK_TM.Caption = "등록시간";
            this.colWORK_TM.FieldName = "WORK_TM";
            this.colWORK_TM.MinWidth = 27;
            this.colWORK_TM.Name = "colWORK_TM";
            this.colWORK_TM.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colWORK_TM.Visible = true;
            this.colWORK_TM.VisibleIndex = 9;
            this.colWORK_TM.Width = 101;
            // 
            // colEND_YN
            // 
            this.colEND_YN.AppearanceHeader.Options.UseTextOptions = true;
            this.colEND_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEND_YN.Caption = "종료여부코드";
            this.colEND_YN.FieldName = "END_YN";
            this.colEND_YN.MinWidth = 27;
            this.colEND_YN.Name = "colEND_YN";
            this.colEND_YN.Visible = true;
            this.colEND_YN.VisibleIndex = 10;
            this.colEND_YN.Width = 101;
            // 
            // colEND_YN_DESC
            // 
            this.colEND_YN_DESC.AppearanceHeader.Options.UseTextOptions = true;
            this.colEND_YN_DESC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEND_YN_DESC.Caption = "종료여부";
            this.colEND_YN_DESC.FieldName = "END_YN_DESC";
            this.colEND_YN_DESC.MinWidth = 27;
            this.colEND_YN_DESC.Name = "colEND_YN_DESC";
            this.colEND_YN_DESC.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colEND_YN_DESC.Visible = true;
            this.colEND_YN_DESC.VisibleIndex = 11;
            this.colEND_YN_DESC.Width = 101;
            // 
            // edtProjectNm
            // 
            this.edtProjectNm.Location = new System.Drawing.Point(100, 46);
            this.edtProjectNm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edtProjectNm.Name = "edtProjectNm";
            this.edtProjectNm.Size = new System.Drawing.Size(344, 26);
            this.edtProjectNm.StyleController = this.layoutControl1;
            this.edtProjectNm.TabIndex = 7;
            // 
            // dateStart
            // 
            this.dateStart.EditValue = null;
            this.dateStart.Location = new System.Drawing.Point(100, 76);
            this.dateStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateStart.Name = "dateStart";
            this.dateStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Properties.DisplayFormat.FormatString = "";
            this.dateStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStart.Properties.EditFormat.FormatString = "";
            this.dateStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStart.Size = new System.Drawing.Size(172, 26);
            this.dateStart.StyleController = this.layoutControl1;
            this.dateStart.TabIndex = 8;
            // 
            // dateEnd
            // 
            this.dateEnd.EditValue = null;
            this.dateEnd.Location = new System.Drawing.Point(100, 106);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Size = new System.Drawing.Size(172, 26);
            this.dateEnd.StyleController = this.layoutControl1;
            this.dateEnd.TabIndex = 9;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1227, 176);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(132, 36);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "조회";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // chkDate
            // 
            this.chkDate.Location = new System.Drawing.Point(276, 76);
            this.chkDate.Name = "chkDate";
            this.chkDate.Properties.Caption = "전체조회";
            this.chkDate.Size = new System.Drawing.Size(168, 24);
            this.chkDate.StyleController = this.layoutControl1;
            this.chkDate.TabIndex = 12;
            this.chkDate.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // edtUserNm
            // 
            this.edtUserNm.Location = new System.Drawing.Point(100, 136);
            this.edtUserNm.Name = "edtUserNm";
            this.edtUserNm.Size = new System.Drawing.Size(172, 26);
            this.edtUserNm.StyleController = this.layoutControl1;
            this.edtUserNm.TabIndex = 13;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlGroup2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1370, 772);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton1;
            this.layoutControlItem2.Location = new System.Drawing.Point(1216, 166);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(136, 40);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 166);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(1216, 40);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(448, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(904, 166);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 206);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1352, 550);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.item0,
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem22,
            this.emptySpaceItem5});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(448, 166);
            this.layoutControlGroup2.Text = "프로젝트 조회";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.edtProjectNm;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "프로젝트명";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(426, 30);
            this.layoutControlItem4.Text = "프로젝트명";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(75, 20);
            // 
            // item0
            // 
            this.item0.Control = this.dateStart;
            this.item0.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.item0.CustomizationFormText = "시작일";
            this.item0.Location = new System.Drawing.Point(0, 30);
            this.item0.Name = "item0";
            this.item0.Size = new System.Drawing.Size(254, 30);
            this.item0.Text = "시작일";
            this.item0.TextSize = new System.Drawing.Size(75, 20);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dateEnd;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(254, 30);
            this.layoutControlItem5.Text = "종료일";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(75, 20);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.edtUserNm;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 90);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(254, 30);
            this.layoutControlItem3.Text = "담당자";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(75, 20);
            // 
            // layoutControlItem22
            // 
            this.layoutControlItem22.Control = this.chkDate;
            this.layoutControlItem22.Location = new System.Drawing.Point(254, 30);
            this.layoutControlItem22.Name = "layoutControlItem22";
            this.layoutControlItem22.Size = new System.Drawing.Size(172, 60);
            this.layoutControlItem22.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem22.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(254, 90);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(172, 30);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
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
            queryParameter4.Name = "P_USER_NM";
            queryParameter4.Type = typeof(string);
            queryParameter4.ValueInfo = "1";
            customSqlQuery1.Parameters.Add(queryParameter1);
            customSqlQuery1.Parameters.Add(queryParameter2);
            customSqlQuery1.Parameters.Add(queryParameter3);
            customSqlQuery1.Parameters.Add(queryParameter4);
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            customSqlQuery2.Name = "QRY_PROJECT_CD";
            queryParameter5.Name = "P_PROJECT_CD";
            queryParameter5.Type = typeof(string);
            queryParameter5.ValueInfo = "0000000001";
            customSqlQuery2.Parameters.Add(queryParameter5);
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "Connection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            customSqlQuery3.Name = "UPDATE_PROJECT_INFO";
            queryParameter6.Name = "P_PROJECT_NM";
            queryParameter6.Type = typeof(string);
            queryParameter6.ValueInfo = "2019000001";
            queryParameter7.Name = "P_START_DT";
            queryParameter7.Type = typeof(string);
            queryParameter7.ValueInfo = "1";
            queryParameter8.Name = "P_END_DT";
            queryParameter8.Type = typeof(string);
            queryParameter8.ValueInfo = "1";
            queryParameter9.Name = "P_CLIENT_CD";
            queryParameter9.Type = typeof(string);
            queryParameter9.ValueInfo = "1";
            queryParameter10.Name = "P_CLIENT_ID";
            queryParameter10.Type = typeof(string);
            queryParameter10.ValueInfo = "1";
            queryParameter11.Name = "P_PROJECT_CD";
            queryParameter11.Type = typeof(string);
            queryParameter11.ValueInfo = "2019000001";
            customSqlQuery3.Parameters.Add(queryParameter6);
            customSqlQuery3.Parameters.Add(queryParameter7);
            customSqlQuery3.Parameters.Add(queryParameter8);
            customSqlQuery3.Parameters.Add(queryParameter9);
            customSqlQuery3.Parameters.Add(queryParameter10);
            customSqlQuery3.Parameters.Add(queryParameter11);
            customSqlQuery3.Sql = null;
            customSqlQuery4.Name = "INSERT_PROJECT_CD";
            queryParameter12.Name = "P_PROJECT_NM";
            queryParameter12.Type = typeof(string);
            queryParameter13.Name = "P_START_DT";
            queryParameter13.Type = typeof(string);
            queryParameter14.Name = "P_END_DT";
            queryParameter14.Type = typeof(string);
            queryParameter15.Name = "P_CLIENT_ID";
            queryParameter15.Type = typeof(string);
            queryParameter16.Name = "P_CLIENT_CD";
            queryParameter16.Type = typeof(string);
            queryParameter16.ValueInfo = "0";
            queryParameter17.Name = "P_USER_ID";
            queryParameter17.Type = typeof(string);
            queryParameter17.ValueInfo = "0";
            queryParameter18.Name = "P_PROJECT_DESC";
            queryParameter18.Type = typeof(string);
            queryParameter18.ValueInfo = "0";
            customSqlQuery4.Parameters.Add(queryParameter12);
            customSqlQuery4.Parameters.Add(queryParameter13);
            customSqlQuery4.Parameters.Add(queryParameter14);
            customSqlQuery4.Parameters.Add(queryParameter15);
            customSqlQuery4.Parameters.Add(queryParameter16);
            customSqlQuery4.Parameters.Add(queryParameter17);
            customSqlQuery4.Parameters.Add(queryParameter18);
            customSqlQuery4.Sql = resources.GetString("customSqlQuery4.Sql");
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery3,
            customSqlQuery4});
            this.sqlDataSource2.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTIiPjxWaWV3IE5hbWU9IlVQREFURV9QUk9KRUNUX0lOR" +
    "k8iIC8+PFZpZXcgTmFtZT0iSU5TRVJUX1BST0pFQ1RfQ0QiIC8+PC9EYXRhU2V0Pg==";
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 80);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1324, 125);
            this.layoutControlGroup3.Text = "발주처 정보";
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem7,
            this.emptySpaceItem4,
            this.layoutControlItem13,
            this.layoutControlItem14,
            this.emptySpaceItem8,
            this.emptySpaceItem9,
            this.layoutControlItem15});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(1308, 62);
            this.layoutControlGroup4.Text = "프로젝트 정보";
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(297, 0);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(38, 20);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(1280, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(20, 20);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.buttonEdit2;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(297, 30);
            this.layoutControlItem13.Text = "담당자";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(50, 20);
            // 
            // buttonEdit2
            // 
            this.buttonEdit2.Location = new System.Drawing.Point(131, 50);
            this.buttonEdit2.Name = "buttonEdit2";
            this.buttonEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit2.Size = new System.Drawing.Size(186, 26);
            this.buttonEdit2.TabIndex = 11;
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.textEdit5;
            this.layoutControlItem14.Location = new System.Drawing.Point(335, 0);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(268, 30);
            this.layoutControlItem14.Text = "담당자코드";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(50, 20);
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(466, 50);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(157, 26);
            this.textEdit5.TabIndex = 12;
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(297, 20);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(38, 10);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.AllowHotTrack = false;
            this.emptySpaceItem9.Location = new System.Drawing.Point(1280, 20);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(20, 10);
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.memoEdit1;
            this.layoutControlItem15.Location = new System.Drawing.Point(603, 0);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(677, 30);
            this.layoutControlItem15.Text = "프로젝트 정보";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(50, 20);
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(734, 50);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(566, 26);
            this.memoEdit1.TabIndex = 13;
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 205);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(1324, 388);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmProjectMngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1370, 802);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProjectMngr";
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtProjectNm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtUserNm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraEditors.CheckEdit chkDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJECT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJECT_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colSTART_DT;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colEND_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_ID_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_TM;
        private DevExpress.XtraGrid.Columns.GridColumn colEND_YN;
        private DevExpress.XtraGrid.Columns.GridColumn colEND_YN_DESC;
        private DevExpress.XtraEditors.TextEdit edtUserNm;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    }
}
