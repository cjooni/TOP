namespace TOP.Dialog
{
    partial class frmProjectInfo
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectInfo));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dateEndDt = new DevExpress.XtraEditors.DateEdit();
            this.dateStartDt = new DevExpress.XtraEditors.DateEdit();
            this.edtProjectNm = new DevExpress.XtraEditors.TextEdit();
            this.gridProjectInfo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPROJECT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROJECT_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTART_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colEND_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_TM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtProjectNm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProjectInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.dateEndDt);
            this.layoutControl1.Controls.Add(this.dateStartDt);
            this.layoutControl1.Controls.Add(this.edtProjectNm);
            this.layoutControl1.Controls.Add(this.gridProjectInfo);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1301, 825);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(969, 46);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(310, 32);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dateEndDt
            // 
            this.dateEndDt.EditValue = null;
            this.dateEndDt.Location = new System.Drawing.Point(112, 80);
            this.dateEndDt.Name = "dateEndDt";
            this.dateEndDt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEndDt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEndDt.Size = new System.Drawing.Size(530, 30);
            this.dateEndDt.StyleController = this.layoutControl1;
            this.dateEndDt.TabIndex = 6;
            // 
            // dateStartDt
            // 
            this.dateStartDt.EditValue = null;
            this.dateStartDt.Location = new System.Drawing.Point(112, 46);
            this.dateStartDt.Name = "dateStartDt";
            this.dateStartDt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStartDt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStartDt.Size = new System.Drawing.Size(530, 30);
            this.dateStartDt.StyleController = this.layoutControl1;
            this.dateStartDt.TabIndex = 1;
            // 
            // edtProjectNm
            // 
            this.edtProjectNm.Location = new System.Drawing.Point(112, 12);
            this.edtProjectNm.Name = "edtProjectNm";
            this.edtProjectNm.Size = new System.Drawing.Size(287, 30);
            this.edtProjectNm.StyleController = this.layoutControl1;
            this.edtProjectNm.TabIndex = 5;
            // 
            // gridProjectInfo
            // 
            this.gridProjectInfo.Location = new System.Drawing.Point(12, 114);
            this.gridProjectInfo.MainView = this.gridView1;
            this.gridProjectInfo.Name = "gridProjectInfo";
            this.gridProjectInfo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.gridProjectInfo.Size = new System.Drawing.Size(1277, 699);
            this.gridProjectInfo.TabIndex = 4;
            this.gridProjectInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridProjectInfo.Click += new System.EventHandler(this.gridProjectInfo_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPROJECT_CD,
            this.colPROJECT_NM,
            this.colSTART_DT,
            this.colEND_DT,
            this.colCLIENT_CD,
            this.colCLIENT_ID,
            this.colWORK_DT,
            this.colWORK_TM});
            this.gridView1.GridControl = this.gridProjectInfo;
            this.gridView1.Name = "gridView1";
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colPROJECT_CD
            // 
            this.colPROJECT_CD.Caption = "프로젝트코드";
            this.colPROJECT_CD.FieldName = "PROJECT_CD";
            this.colPROJECT_CD.MinWidth = 30;
            this.colPROJECT_CD.Name = "colPROJECT_CD";
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
            this.colSTART_DT.Caption = "프로젝트 시작일";
            this.colSTART_DT.FieldName = "START_DT";
            this.colSTART_DT.MinWidth = 30;
            this.colSTART_DT.Name = "colSTART_DT";
            this.colSTART_DT.Visible = true;
            this.colSTART_DT.VisibleIndex = 2;
            this.colSTART_DT.Width = 112;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.DisplayFormat.FormatString = "yyyyMMdd";
            this.repositoryItemDateEdit1.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.CalendarTimeProperties.EditFormat.FormatString = "yyyyMMdd";
            this.repositoryItemDateEdit1.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.CalendarTimeProperties.Mask.EditMask = "yyyyMMdd";
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "yyyyMMdd";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "yyyyMMdd";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "yyyyMMdd";
            this.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // colEND_DT
            // 
            this.colEND_DT.Caption = "프로젝트 종료일";
            this.colEND_DT.FieldName = "END_DT";
            this.colEND_DT.MinWidth = 30;
            this.colEND_DT.Name = "colEND_DT";
            this.colEND_DT.Visible = true;
            this.colEND_DT.VisibleIndex = 3;
            this.colEND_DT.Width = 112;
            // 
            // colCLIENT_CD
            // 
            this.colCLIENT_CD.FieldName = "CLIENT_CD";
            this.colCLIENT_CD.MinWidth = 30;
            this.colCLIENT_CD.Name = "colCLIENT_CD";
            this.colCLIENT_CD.Visible = true;
            this.colCLIENT_CD.VisibleIndex = 4;
            this.colCLIENT_CD.Width = 112;
            // 
            // colCLIENT_ID
            // 
            this.colCLIENT_ID.FieldName = "CLIENT_ID";
            this.colCLIENT_ID.MinWidth = 30;
            this.colCLIENT_ID.Name = "colCLIENT_ID";
            this.colCLIENT_ID.Visible = true;
            this.colCLIENT_ID.VisibleIndex = 5;
            this.colCLIENT_ID.Width = 112;
            // 
            // colWORK_DT
            // 
            this.colWORK_DT.FieldName = "WORK_DT";
            this.colWORK_DT.MinWidth = 30;
            this.colWORK_DT.Name = "colWORK_DT";
            this.colWORK_DT.Visible = true;
            this.colWORK_DT.VisibleIndex = 6;
            this.colWORK_DT.Width = 112;
            // 
            // colWORK_TM
            // 
            this.colWORK_TM.FieldName = "WORK_TM";
            this.colWORK_TM.MinWidth = 30;
            this.colWORK_TM.Name = "colWORK_TM";
            this.colWORK_TM.Visible = true;
            this.colWORK_TM.VisibleIndex = 7;
            this.colWORK_TM.Width = 112;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.emptySpaceItem1,
            this.emptySpaceItem3,
            this.layoutControlItem3,
            this.emptySpaceItem4,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1301, 825);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridProjectInfo;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 102);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1281, 703);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.edtProjectNm;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(391, 34);
            this.layoutControlItem2.Text = "프로젝트명";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(97, 22);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(391, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(880, 34);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(1271, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 102);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(644, 34);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(313, 68);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dateStartDt;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(634, 34);
            this.layoutControlItem3.Text = "프로젝트 시작일";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(97, 22);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(634, 34);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(10, 68);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dateEndDt;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(634, 34);
            this.layoutControlItem4.Text = "프로젝트 종료일";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(97, 22);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton1;
            this.layoutControlItem5.Location = new System.Drawing.Point(957, 34);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(314, 68);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "QRY_PROJECT_INFO";
            queryParameter1.Name = "P_PROJECT_NM";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "2019";
            customSqlQuery1.Parameters.Add(queryParameter1);
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "Connection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            customSqlQuery2.Name = "UPDATE_PROJECT_INFO";
            queryParameter2.Name = "P_PROJECT_NM";
            queryParameter2.Type = typeof(string);
            queryParameter2.ValueInfo = "2019000001";
            queryParameter3.Name = "P_START_DT";
            queryParameter3.Type = typeof(string);
            queryParameter3.ValueInfo = "1";
            queryParameter4.Name = "P_END_DT";
            queryParameter4.Type = typeof(string);
            queryParameter4.ValueInfo = "1";
            queryParameter5.Name = "P_CLIENT_CD";
            queryParameter5.Type = typeof(string);
            queryParameter5.ValueInfo = "1";
            queryParameter6.Name = "P_CLIENT_ID";
            queryParameter6.Type = typeof(string);
            queryParameter6.ValueInfo = "1";
            queryParameter7.Name = "P_PROJECT_CD";
            queryParameter7.Type = typeof(string);
            queryParameter7.ValueInfo = "2019000001";
            customSqlQuery2.Parameters.Add(queryParameter2);
            customSqlQuery2.Parameters.Add(queryParameter3);
            customSqlQuery2.Parameters.Add(queryParameter4);
            customSqlQuery2.Parameters.Add(queryParameter5);
            customSqlQuery2.Parameters.Add(queryParameter6);
            customSqlQuery2.Parameters.Add(queryParameter7);
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSource2.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTIiPjxWaWV3IE5hbWU9IlVQREFURV9QUk9KRUNUX0lOR" +
    "k8iIC8+PC9EYXRhU2V0Pg==";
            // 
            // frmProjectInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.ClientSize = new System.Drawing.Size(1301, 858);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmProjectInfo";
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtProjectNm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProjectInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridProjectInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJECT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJECT_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colSTART_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colEND_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_TM;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit dateEndDt;
        private DevExpress.XtraEditors.DateEdit dateStartDt;
        private DevExpress.XtraEditors.TextEdit edtProjectNm;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
    }
}
