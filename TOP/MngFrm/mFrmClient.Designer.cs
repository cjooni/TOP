
namespace TOP.MngFrm
{
    partial class mFrmClient
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery5 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column21 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression21 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column22 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression22 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column23 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression23 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column24 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression24 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column25 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression25 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mFrmClient));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery6 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column26 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression26 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column27 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression27 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column28 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression28 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column29 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression29 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column30 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression30 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery5 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter19 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter20 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter21 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter22 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery6 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter23 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter24 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter25 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter26 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter27 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col고객코드 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col고객명 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col전화번호 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col팩스번호 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col설명 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1210, 754);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sqlDataSource2;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1186, 668);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "localhost_TOPS_Connection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            columnExpression21.ColumnName = "CLIENT_CD";
            table5.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"276\" />";
            table5.Name = "cod01m00";
            columnExpression21.Table = table5;
            column21.Expression = columnExpression21;
            columnExpression22.ColumnName = "CLIENT_NM";
            columnExpression22.Table = table5;
            column22.Expression = columnExpression22;
            columnExpression23.ColumnName = "TEL_NO";
            columnExpression23.Table = table5;
            column23.Expression = columnExpression23;
            columnExpression24.ColumnName = "FAX_NO";
            columnExpression24.Table = table5;
            column24.Expression = columnExpression24;
            columnExpression25.ColumnName = "DESCRIPT";
            columnExpression25.Table = table5;
            column25.Expression = columnExpression25;
            selectQuery5.Columns.Add(column21);
            selectQuery5.Columns.Add(column22);
            selectQuery5.Columns.Add(column23);
            selectQuery5.Columns.Add(column24);
            selectQuery5.Columns.Add(column25);
            selectQuery5.Name = "QRY_COD01M00";
            selectQuery5.Tables.Add(table5);
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery5});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col고객코드,
            this.col고객명,
            this.col전화번호,
            this.col팩스번호,
            this.col설명});
            this.gridView1.DetailHeight = 280;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.EditFormHidden += new DevExpress.XtraGrid.Views.Grid.EditFormHiddenEventHandler(this.gridView1_EditFormHidden);
            this.gridView1.ShowingPopupEditForm += new DevExpress.XtraGrid.Views.Grid.ShowingPopupEditFormEventHandler(this.gridView1_ShowingPopupEditForm);
            this.gridView1.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView1_ValidatingEditor);
            // 
            // col고객코드
            // 
            this.col고객코드.AppearanceHeader.Options.UseTextOptions = true;
            this.col고객코드.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col고객코드.Caption = "고객코드";
            this.col고객코드.FieldName = "CLIENT_CD";
            this.col고객코드.MinWidth = 27;
            this.col고객코드.Name = "col고객코드";
            this.col고객코드.Visible = true;
            this.col고객코드.VisibleIndex = 0;
            this.col고객코드.Width = 101;
            // 
            // col고객명
            // 
            this.col고객명.AppearanceHeader.Options.UseTextOptions = true;
            this.col고객명.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col고객명.Caption = "고객명";
            this.col고객명.FieldName = "CLIENT_NM";
            this.col고객명.MinWidth = 27;
            this.col고객명.Name = "col고객명";
            this.col고객명.Visible = true;
            this.col고객명.VisibleIndex = 1;
            this.col고객명.Width = 101;
            // 
            // col전화번호
            // 
            this.col전화번호.AppearanceHeader.Options.UseTextOptions = true;
            this.col전화번호.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col전화번호.Caption = "전화번호";
            this.col전화번호.FieldName = "TEL_NO";
            this.col전화번호.MinWidth = 27;
            this.col전화번호.Name = "col전화번호";
            this.col전화번호.Visible = true;
            this.col전화번호.VisibleIndex = 2;
            this.col전화번호.Width = 101;
            // 
            // col팩스번호
            // 
            this.col팩스번호.AppearanceHeader.Options.UseTextOptions = true;
            this.col팩스번호.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col팩스번호.Caption = "FAX 번호";
            this.col팩스번호.FieldName = "FAX_NO";
            this.col팩스번호.MinWidth = 27;
            this.col팩스번호.Name = "col팩스번호";
            this.col팩스번호.Visible = true;
            this.col팩스번호.VisibleIndex = 3;
            this.col팩스번호.Width = 101;
            // 
            // col설명
            // 
            this.col설명.AppearanceHeader.Options.UseTextOptions = true;
            this.col설명.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col설명.Caption = "상세설명";
            this.col설명.FieldName = "DESCRIPT";
            this.col설명.MinWidth = 27;
            this.col설명.Name = "col설명";
            this.col설명.Visible = true;
            this.col설명.VisibleIndex = 4;
            this.col설명.Width = 101;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 684);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(1186, 27);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 715);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(1186, 27);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "simpleButton2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1210, 754);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1190, 672);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 672);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1190, 31);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton2;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 703);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1190, 31);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_TOPS_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression26.ColumnName = "CLIENT_CD";
            table6.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"245\" />";
            table6.Name = "cod01m00";
            columnExpression26.Table = table6;
            column26.Expression = columnExpression26;
            columnExpression27.ColumnName = "CLIENT_NM";
            columnExpression27.Table = table6;
            column27.Expression = columnExpression27;
            columnExpression28.ColumnName = "TEL_NO";
            columnExpression28.Table = table6;
            column28.Expression = columnExpression28;
            columnExpression29.ColumnName = "FAX_NO";
            columnExpression29.Table = table6;
            column29.Expression = columnExpression29;
            columnExpression30.ColumnName = "DESCRIPT";
            columnExpression30.Table = table6;
            column30.Expression = columnExpression30;
            selectQuery6.Columns.Add(column26);
            selectQuery6.Columns.Add(column27);
            selectQuery6.Columns.Add(column28);
            selectQuery6.Columns.Add(column29);
            selectQuery6.Columns.Add(column30);
            selectQuery6.Name = "cod01m00";
            selectQuery6.Tables.Add(table6);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery6});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // sqlDataSource3
            // 
            this.sqlDataSource3.ConnectionName = "localhost_TOPS_Connection";
            this.sqlDataSource3.Name = "sqlDataSource3";
            customSqlQuery5.Name = "INSERT_COD01M00";
            queryParameter19.Name = "P_CLIENT_NM";
            queryParameter19.Type = typeof(string);
            queryParameter19.ValueInfo = "\'test1\'";
            queryParameter20.Name = "P_TEL_NO";
            queryParameter20.Type = typeof(string);
            queryParameter20.ValueInfo = "0";
            queryParameter21.Name = "P_FAX_NO";
            queryParameter21.Type = typeof(string);
            queryParameter21.ValueInfo = "0";
            queryParameter22.Name = "P_DESCRIPT";
            queryParameter22.Type = typeof(string);
            queryParameter22.ValueInfo = "0";
            customSqlQuery5.Parameters.Add(queryParameter19);
            customSqlQuery5.Parameters.Add(queryParameter20);
            customSqlQuery5.Parameters.Add(queryParameter21);
            customSqlQuery5.Parameters.Add(queryParameter22);
            customSqlQuery5.Sql = resources.GetString("customSqlQuery5.Sql");
            customSqlQuery6.Name = "UPDATE_COD01M00";
            queryParameter23.Name = "P_CLIENT_CD";
            queryParameter23.Type = typeof(string);
            queryParameter23.ValueInfo = "1";
            queryParameter24.Name = "P_CLIENT_NM";
            queryParameter24.Type = typeof(string);
            queryParameter24.ValueInfo = "1";
            queryParameter25.Name = "P_FAX_NO";
            queryParameter25.Type = typeof(string);
            queryParameter25.ValueInfo = "1";
            queryParameter26.Name = "P_TEL_NO";
            queryParameter26.Type = typeof(string);
            queryParameter26.ValueInfo = "1";
            queryParameter27.Name = "P_DESCRIPT";
            queryParameter27.Type = typeof(string);
            queryParameter27.ValueInfo = "1";
            customSqlQuery6.Parameters.Add(queryParameter23);
            customSqlQuery6.Parameters.Add(queryParameter24);
            customSqlQuery6.Parameters.Add(queryParameter25);
            customSqlQuery6.Parameters.Add(queryParameter26);
            customSqlQuery6.Parameters.Add(queryParameter27);
            customSqlQuery6.Sql = "UPDATE COD01M00\r\n   SET CLIENT_NM = @P_CLIENT_NM\r\n     , TEL_NO = @P_TEL_NO\r\n    " +
    " , FAX_NO = @P_FAX_NO\r\n     , DESCRIPT = @P_DESCRIPT\r\n WHERE CLIENT_CD = @P_CLIE" +
    "NT_CD";
            this.sqlDataSource3.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery5,
            customSqlQuery6});
            this.sqlDataSource3.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTMiPjxWaWV3IE5hbWU9IklOU0VSVF9DT0QwMU0wMCIgL" +
    "z48VmlldyBOYW1lPSJVUERBVEVfQ09EMDFNMDAiIC8+PC9EYXRhU2V0Pg==";
            // 
            // mFrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1210, 784);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mFrmClient";
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col고객코드;
        private DevExpress.XtraGrid.Columns.GridColumn col고객명;
        private DevExpress.XtraGrid.Columns.GridColumn col전화번호;
        private DevExpress.XtraGrid.Columns.GridColumn col팩스번호;
        private DevExpress.XtraGrid.Columns.GridColumn col설명;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
    }
}
