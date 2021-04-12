namespace TOP.Dialog
{
    partial class frmScrnInfo
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
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScrnInfo));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter8 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridScrnInfo = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSCRN_SRC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSCRN_TEXT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSCRN_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.edtScrnSrc = new DevExpress.XtraEditors.TextEdit();
            this.edtScrnText = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridScrnInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtScrnSrc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtScrnText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridScrnInfo);
            this.layoutControl1.Controls.Add(this.edtScrnSrc);
            this.layoutControl1.Controls.Add(this.edtScrnText);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1171, 750);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridScrnInfo
            // 
            this.gridScrnInfo.DataSource = this.sqlDataSource1;
            this.gridScrnInfo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gridScrnInfo.Location = new System.Drawing.Point(11, 127);
            this.gridScrnInfo.MainView = this.gridView1;
            this.gridScrnInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridScrnInfo.Name = "gridScrnInfo";
            this.gridScrnInfo.Size = new System.Drawing.Size(1149, 613);
            this.gridScrnInfo.TabIndex = 4;
            this.gridScrnInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "QRY_SCRN_INFO";
            queryParameter1.Name = "P_SCRN_SRC";
            queryParameter1.Type = typeof(string);
            queryParameter2.Name = "P_SCRN_TEXT";
            queryParameter2.Type = typeof(string);
            customSqlQuery1.Parameters.Add(queryParameter1);
            customSqlQuery1.Parameters.Add(queryParameter2);
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            customSqlQuery2.Name = "INSERT_SCRN_INFO";
            queryParameter3.Name = "P_SCRN_SRC";
            queryParameter3.Type = typeof(string);
            queryParameter3.ValueInfo = "11";
            queryParameter4.Name = "P_SCRN_TEXT";
            queryParameter4.Type = typeof(string);
            queryParameter5.Name = "P_SCRN_DESC";
            queryParameter5.Type = typeof(string);
            customSqlQuery2.Parameters.Add(queryParameter3);
            customSqlQuery2.Parameters.Add(queryParameter4);
            customSqlQuery2.Parameters.Add(queryParameter5);
            customSqlQuery2.Sql = "INSERT INTO SCR01M00\r\nSELECT :P_SCRN_SRC\r\n      ,:P_SCRN_TEXT\r\n      ,:P_SCRN_DES" +
    "C\r\n  FROM DUAL";
            customSqlQuery3.Name = "UPDATE_SCRN_INFO";
            queryParameter6.Name = "P_SCRN_SRC";
            queryParameter6.Type = typeof(string);
            queryParameter6.ValueInfo = "1";
            queryParameter7.Name = "P_SCRN_TEXT";
            queryParameter7.Type = typeof(string);
            queryParameter7.ValueInfo = "1";
            queryParameter8.Name = "P_SCRN_DESC";
            queryParameter8.Type = typeof(string);
            queryParameter8.ValueInfo = "1";
            customSqlQuery3.Parameters.Add(queryParameter6);
            customSqlQuery3.Parameters.Add(queryParameter7);
            customSqlQuery3.Parameters.Add(queryParameter8);
            customSqlQuery3.Sql = "UPDATE SCR01M00\r\n   SET SCRN_TEXT = :P_SCRN_TEXT\r\n     , SCRN_DESC = :P_SCRN_DESC" +
    "\r\n WHERE SCRN_SRC = :P_SCRN_SRC";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2,
            customSqlQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSCRN_SRC,
            this.colSCRN_TEXT,
            this.colSCRN_DESC});
            this.gridView1.DetailHeight = 500;
            this.gridView1.FixedLineWidth = 3;
            this.gridView1.GridControl = this.gridScrnInfo;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.ShowingPopupEditForm += new DevExpress.XtraGrid.Views.Grid.ShowingPopupEditFormEventHandler(this.gridView1_ShowingPopupEditForm);
            // 
            // colSCRN_SRC
            // 
            this.colSCRN_SRC.AppearanceCell.Options.UseTextOptions = true;
            this.colSCRN_SRC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSCRN_SRC.AppearanceHeader.Options.UseTextOptions = true;
            this.colSCRN_SRC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSCRN_SRC.Caption = "소스코드";
            this.colSCRN_SRC.FieldName = "SCRN_SRC";
            this.colSCRN_SRC.MinWidth = 26;
            this.colSCRN_SRC.Name = "colSCRN_SRC";
            this.colSCRN_SRC.Visible = true;
            this.colSCRN_SRC.VisibleIndex = 0;
            this.colSCRN_SRC.Width = 96;
            // 
            // colSCRN_TEXT
            // 
            this.colSCRN_TEXT.AppearanceCell.Options.UseTextOptions = true;
            this.colSCRN_TEXT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSCRN_TEXT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSCRN_TEXT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSCRN_TEXT.Caption = "화면명";
            this.colSCRN_TEXT.FieldName = "SCRN_TEXT";
            this.colSCRN_TEXT.MinWidth = 26;
            this.colSCRN_TEXT.Name = "colSCRN_TEXT";
            this.colSCRN_TEXT.Visible = true;
            this.colSCRN_TEXT.VisibleIndex = 1;
            this.colSCRN_TEXT.Width = 96;
            // 
            // colSCRN_DESC
            // 
            this.colSCRN_DESC.AppearanceCell.Options.UseTextOptions = true;
            this.colSCRN_DESC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSCRN_DESC.AppearanceHeader.Options.UseTextOptions = true;
            this.colSCRN_DESC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSCRN_DESC.Caption = "화면설명";
            this.colSCRN_DESC.FieldName = "SCRN_DESC";
            this.colSCRN_DESC.MinWidth = 26;
            this.colSCRN_DESC.Name = "colSCRN_DESC";
            this.colSCRN_DESC.Visible = true;
            this.colSCRN_DESC.VisibleIndex = 2;
            this.colSCRN_DESC.Width = 96;
            // 
            // edtScrnSrc
            // 
            this.edtScrnSrc.Location = new System.Drawing.Point(74, 10);
            this.edtScrnSrc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edtScrnSrc.Name = "edtScrnSrc";
            this.edtScrnSrc.Size = new System.Drawing.Size(378, 26);
            this.edtScrnSrc.StyleController = this.layoutControl1;
            this.edtScrnSrc.TabIndex = 5;
            // 
            // edtScrnText
            // 
            this.edtScrnText.Location = new System.Drawing.Point(74, 40);
            this.edtScrnText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edtScrnText.Name = "edtScrnText";
            this.edtScrnText.Size = new System.Drawing.Size(378, 26);
            this.edtScrnText.StyleController = this.layoutControl1;
            this.edtScrnText.TabIndex = 6;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(903, 70);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(122, 53);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "신규";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(1029, 70);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(131, 53);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "조회";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
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
            this.emptySpaceItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1171, 750);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridScrnInfo;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 117);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1153, 617);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.edtScrnSrc;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(445, 30);
            this.layoutControlItem2.Text = "소스코드";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.edtScrnText;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(445, 30);
            this.layoutControlItem3.Text = "소스명";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(60, 20);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(445, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(708, 30);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(445, 30);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(708, 30);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton1;
            this.layoutControlItem4.Location = new System.Drawing.Point(892, 60);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(85, 57);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(126, 57);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton2;
            this.layoutControlItem5.Location = new System.Drawing.Point(1018, 60);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(135, 57);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(135, 57);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(135, 57);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 60);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(892, 57);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmScrnInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1171, 780);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmScrnInfo";
            this.Text = "화면관리";
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridScrnInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtScrnSrc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtScrnText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridScrnInfo;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSCRN_SRC;
        private DevExpress.XtraGrid.Columns.GridColumn colSCRN_TEXT;
        private DevExpress.XtraGrid.Columns.GridColumn colSCRN_DESC;
        private DevExpress.XtraEditors.TextEdit edtScrnSrc;
        private DevExpress.XtraEditors.TextEdit edtScrnText;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}
