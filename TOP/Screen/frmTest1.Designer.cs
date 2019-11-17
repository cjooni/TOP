namespace TOP.Screen
{
    partial class frmTest1
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest1));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUSER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMNGR_GRADE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHP_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEL_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOFFICE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPSWD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_EMPL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_DTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(911, 523);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "USR01M00";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(887, 499);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "USER_ID";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"229\" />";
            table1.Name = "USR01M00";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "USER_NM";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "MNGR_GRADE";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "HP_NO";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "TEL_NO";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "OFFICE_NO";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "PSWD";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "WORK_EMPL";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "WORK_DTM";
            columnExpression9.Table = table1;
            column9.Expression = columnExpression9;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Columns.Add(column9);
            selectQuery1.Name = "USR01M00";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUSER_ID,
            this.colUSER_NM,
            this.colMNGR_GRADE,
            this.colHP_NO,
            this.colTEL_NO,
            this.colOFFICE_NO,
            this.colPSWD,
            this.colWORK_EMPL,
            this.colWORK_DTM});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colUSER_ID
            // 
            this.colUSER_ID.Caption = "USER ID";
            this.colUSER_ID.FieldName = "USER_ID";
            this.colUSER_ID.Name = "colUSER_ID";
            this.colUSER_ID.Visible = true;
            this.colUSER_ID.VisibleIndex = 0;
            // 
            // colUSER_NM
            // 
            this.colUSER_NM.Caption = "사용자 명";
            this.colUSER_NM.FieldName = "USER_NM";
            this.colUSER_NM.Name = "colUSER_NM";
            this.colUSER_NM.Visible = true;
            this.colUSER_NM.VisibleIndex = 1;
            // 
            // colMNGR_GRADE
            // 
            this.colMNGR_GRADE.Caption = "관리권한";
            this.colMNGR_GRADE.FieldName = "MNGR_GRADE";
            this.colMNGR_GRADE.Name = "colMNGR_GRADE";
            this.colMNGR_GRADE.Visible = true;
            this.colMNGR_GRADE.VisibleIndex = 2;
            // 
            // colHP_NO
            // 
            this.colHP_NO.Caption = "휴대전화";
            this.colHP_NO.FieldName = "HP_NO";
            this.colHP_NO.Name = "colHP_NO";
            this.colHP_NO.Visible = true;
            this.colHP_NO.VisibleIndex = 3;
            // 
            // colTEL_NO
            // 
            this.colTEL_NO.Caption = "전화번호";
            this.colTEL_NO.FieldName = "TEL_NO";
            this.colTEL_NO.Name = "colTEL_NO";
            this.colTEL_NO.Visible = true;
            this.colTEL_NO.VisibleIndex = 4;
            // 
            // colOFFICE_NO
            // 
            this.colOFFICE_NO.FieldName = "OFFICE_NO";
            this.colOFFICE_NO.Name = "colOFFICE_NO";
            this.colOFFICE_NO.Visible = true;
            this.colOFFICE_NO.VisibleIndex = 5;
            // 
            // colPSWD
            // 
            this.colPSWD.FieldName = "PSWD";
            this.colPSWD.Name = "colPSWD";
            this.colPSWD.Visible = true;
            this.colPSWD.VisibleIndex = 6;
            // 
            // colWORK_EMPL
            // 
            this.colWORK_EMPL.FieldName = "WORK_EMPL";
            this.colWORK_EMPL.Name = "colWORK_EMPL";
            this.colWORK_EMPL.Visible = true;
            this.colWORK_EMPL.VisibleIndex = 7;
            // 
            // colWORK_DTM
            // 
            this.colWORK_DTM.FieldName = "WORK_DTM";
            this.colWORK_DTM.Name = "colWORK_DTM";
            this.colWORK_DTM.Visible = true;
            this.colWORK_DTM.VisibleIndex = 8;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(911, 523);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(891, 503);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmTest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(911, 546);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmTest1";
            this.Shown += new System.EventHandler(this.frmTest1_Shown);
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colMNGR_GRADE;
        private DevExpress.XtraGrid.Columns.GridColumn colHP_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEL_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colOFFICE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colPSWD;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_EMPL;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_DTM;
    }
}
