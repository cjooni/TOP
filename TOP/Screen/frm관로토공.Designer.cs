
namespace TOP.Screen
{
    partial class frm관로토공
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm관로토공));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataQry = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.col관로번호 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.col측점 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.col누가거리 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.col거리 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.col포장코드 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.col포장 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.col육상면적 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.col육상부피 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.col수중면적 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.col수중부피 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.col관주위면적 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.col관주위부피 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.col관상부 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.col관상부부피 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand8 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.col관기초면적 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.col관기초부피 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand9 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand10 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.col절단 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand11 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.col깨기및복구면적 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.col깨기및복구부피 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand12 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.col보조기층 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.col보조기층부피 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand13 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.col모래 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.col모래부피 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand14 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.col석분면적 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.col석분부피 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.simpleButton11);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1534, -891, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1171, 750);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "QRY_토적표";
            this.gridControl1.DataSource = this.sqlDataQry;
            this.gridControl1.Location = new System.Drawing.Point(22, 50);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1127, 632);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // sqlDataQry
            // 
            this.sqlDataQry.ConnectionName = "localhost_TOPS_Connection";
            this.sqlDataQry.Name = "sqlDataQry";
            customSqlQuery1.Name = "QRY_토적표";
            queryParameter1.Name = "P_PROJECT_CD";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "0";
            customSqlQuery1.Parameters.Add(queryParameter1);
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataQry.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataQry.ResultSchemaSerializable = resources.GetString("sqlDataQry.ResultSchemaSerializable");
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand5,
            this.gridBand8,
            this.gridBand9});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.col관로번호,
            this.col측점,
            this.col누가거리,
            this.col거리,
            this.col포장코드,
            this.col포장,
            this.col육상면적,
            this.col육상부피,
            this.col수중면적,
            this.col수중부피,
            this.col관주위면적,
            this.col관주위부피,
            this.col관상부,
            this.col관상부부피,
            this.col관기초면적,
            this.col관기초부피,
            this.col절단,
            this.col깨기및복구면적,
            this.col깨기및복구부피,
            this.col보조기층,
            this.col보조기층부피,
            this.col모래,
            this.col모래부피,
            this.col석분면적,
            this.col석분부피});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "관로정보";
            this.gridBand1.Columns.Add(this.col관로번호);
            this.gridBand1.Columns.Add(this.col측점);
            this.gridBand1.Columns.Add(this.col누가거리);
            this.gridBand1.Columns.Add(this.col거리);
            this.gridBand1.Columns.Add(this.col포장코드);
            this.gridBand1.Columns.Add(this.col포장);
            this.gridBand1.MinWidth = 33;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 574;
            // 
            // col관로번호
            // 
            this.col관로번호.FieldName = "관로번호";
            this.col관로번호.MinWidth = 37;
            this.col관로번호.Name = "col관로번호";
            this.col관로번호.Visible = true;
            this.col관로번호.Width = 74;
            // 
            // col측점
            // 
            this.col측점.FieldName = "측점";
            this.col측점.MinWidth = 37;
            this.col측점.Name = "col측점";
            this.col측점.Visible = true;
            this.col측점.Width = 234;
            // 
            // col누가거리
            // 
            this.col누가거리.FieldName = "누가거리";
            this.col누가거리.MinWidth = 37;
            this.col누가거리.Name = "col누가거리";
            this.col누가거리.Visible = true;
            this.col누가거리.Width = 74;
            // 
            // col거리
            // 
            this.col거리.FieldName = "거리";
            this.col거리.MinWidth = 37;
            this.col거리.Name = "col거리";
            this.col거리.Visible = true;
            this.col거리.Width = 74;
            // 
            // col포장코드
            // 
            this.col포장코드.FieldName = "포장코드";
            this.col포장코드.MinWidth = 37;
            this.col포장코드.Name = "col포장코드";
            this.col포장코드.Visible = true;
            this.col포장코드.Width = 74;
            // 
            // col포장
            // 
            this.col포장.FieldName = "포장";
            this.col포장.MinWidth = 37;
            this.col포장.Name = "col포장";
            this.col포장.Visible = true;
            this.col포장.Width = 44;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "터파기(토사)";
            this.gridBand2.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand3,
            this.gridBand4});
            this.gridBand2.MinWidth = 22;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 291;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "육상";
            this.gridBand3.Columns.Add(this.col육상면적);
            this.gridBand3.Columns.Add(this.col육상부피);
            this.gridBand3.MinWidth = 15;
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 0;
            this.gridBand3.Width = 145;
            // 
            // col육상면적
            // 
            this.col육상면적.FieldName = "육상면적";
            this.col육상면적.MinWidth = 37;
            this.col육상면적.Name = "col육상면적";
            this.col육상면적.Visible = true;
            this.col육상면적.Width = 72;
            // 
            // col육상부피
            // 
            this.col육상부피.FieldName = "육상부피";
            this.col육상부피.MinWidth = 37;
            this.col육상부피.Name = "col육상부피";
            this.col육상부피.Visible = true;
            this.col육상부피.Width = 73;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.Caption = "용수";
            this.gridBand4.Columns.Add(this.col수중면적);
            this.gridBand4.Columns.Add(this.col수중부피);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 1;
            this.gridBand4.Width = 146;
            // 
            // col수중면적
            // 
            this.col수중면적.FieldName = "수중면적";
            this.col수중면적.MinWidth = 37;
            this.col수중면적.Name = "col수중면적";
            this.col수중면적.Visible = true;
            this.col수중면적.Width = 72;
            // 
            // col수중부피
            // 
            this.col수중부피.FieldName = "수중부피";
            this.col수중부피.MinWidth = 37;
            this.col수중부피.Name = "col수중부피";
            this.col수중부피.Visible = true;
            this.col수중부피.Width = 74;
            // 
            // gridBand5
            // 
            this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand5.Caption = "되메우기";
            this.gridBand5.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand6,
            this.gridBand7});
            this.gridBand5.MinWidth = 15;
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 2;
            this.gridBand5.Width = 291;
            // 
            // gridBand6
            // 
            this.gridBand6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand6.Caption = "관주위";
            this.gridBand6.Columns.Add(this.col관주위면적);
            this.gridBand6.Columns.Add(this.col관주위부피);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 0;
            this.gridBand6.Width = 145;
            // 
            // col관주위면적
            // 
            this.col관주위면적.FieldName = "관주위면적";
            this.col관주위면적.MinWidth = 37;
            this.col관주위면적.Name = "col관주위면적";
            this.col관주위면적.Visible = true;
            this.col관주위면적.Width = 79;
            // 
            // col관주위부피
            // 
            this.col관주위부피.FieldName = "관주위부피";
            this.col관주위부피.MinWidth = 37;
            this.col관주위부피.Name = "col관주위부피";
            this.col관주위부피.Visible = true;
            this.col관주위부피.Width = 66;
            // 
            // gridBand7
            // 
            this.gridBand7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand7.Caption = "관상단";
            this.gridBand7.Columns.Add(this.col관상부);
            this.gridBand7.Columns.Add(this.col관상부부피);
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.VisibleIndex = 1;
            this.gridBand7.Width = 146;
            // 
            // col관상부
            // 
            this.col관상부.FieldName = "관상부";
            this.col관상부.MinWidth = 37;
            this.col관상부.Name = "col관상부";
            this.col관상부.Visible = true;
            this.col관상부.Width = 72;
            // 
            // col관상부부피
            // 
            this.col관상부부피.FieldName = "관상부부피";
            this.col관상부부피.MinWidth = 37;
            this.col관상부부피.Name = "col관상부부피";
            this.col관상부부피.Visible = true;
            this.col관상부부피.Width = 74;
            // 
            // gridBand8
            // 
            this.gridBand8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand8.Caption = "관기초";
            this.gridBand8.Columns.Add(this.col관기초면적);
            this.gridBand8.Columns.Add(this.col관기초부피);
            this.gridBand8.MinWidth = 15;
            this.gridBand8.Name = "gridBand8";
            this.gridBand8.VisibleIndex = 3;
            this.gridBand8.Width = 145;
            // 
            // col관기초면적
            // 
            this.col관기초면적.FieldName = "관기초면적";
            this.col관기초면적.MinWidth = 37;
            this.col관기초면적.Name = "col관기초면적";
            this.col관기초면적.Visible = true;
            this.col관기초면적.Width = 72;
            // 
            // col관기초부피
            // 
            this.col관기초부피.FieldName = "관기초부피";
            this.col관기초부피.MinWidth = 37;
            this.col관기초부피.Name = "col관기초부피";
            this.col관기초부피.Visible = true;
            this.col관기초부피.Width = 73;
            // 
            // gridBand9
            // 
            this.gridBand9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand9.Caption = "포장구성";
            this.gridBand9.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand10,
            this.gridBand11,
            this.gridBand12,
            this.gridBand13,
            this.gridBand14});
            this.gridBand9.MinWidth = 15;
            this.gridBand9.Name = "gridBand9";
            this.gridBand9.VisibleIndex = 4;
            this.gridBand9.Width = 667;
            // 
            // gridBand10
            // 
            this.gridBand10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand10.Caption = "절단";
            this.gridBand10.Columns.Add(this.col절단);
            this.gridBand10.Name = "gridBand10";
            this.gridBand10.VisibleIndex = 0;
            this.gridBand10.Width = 73;
            // 
            // col절단
            // 
            this.col절단.FieldName = "절단";
            this.col절단.MinWidth = 37;
            this.col절단.Name = "col절단";
            this.col절단.Visible = true;
            this.col절단.Width = 73;
            // 
            // gridBand11
            // 
            this.gridBand11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand11.Caption = "깨기및복구";
            this.gridBand11.Columns.Add(this.col깨기및복구면적);
            this.gridBand11.Columns.Add(this.col깨기및복구부피);
            this.gridBand11.Name = "gridBand11";
            this.gridBand11.VisibleIndex = 1;
            this.gridBand11.Width = 147;
            // 
            // col깨기및복구면적
            // 
            this.col깨기및복구면적.FieldName = "깨기및복구면적";
            this.col깨기및복구면적.MinWidth = 37;
            this.col깨기및복구면적.Name = "col깨기및복구면적";
            this.col깨기및복구면적.Visible = true;
            this.col깨기및복구면적.Width = 73;
            // 
            // col깨기및복구부피
            // 
            this.col깨기및복구부피.FieldName = "깨기및복구부피";
            this.col깨기및복구부피.MinWidth = 37;
            this.col깨기및복구부피.Name = "col깨기및복구부피";
            this.col깨기및복구부피.Visible = true;
            this.col깨기및복구부피.Width = 74;
            // 
            // gridBand12
            // 
            this.gridBand12.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand12.Caption = "보조기층";
            this.gridBand12.Columns.Add(this.col보조기층);
            this.gridBand12.Columns.Add(this.col보조기층부피);
            this.gridBand12.Name = "gridBand12";
            this.gridBand12.VisibleIndex = 2;
            this.gridBand12.Width = 147;
            // 
            // col보조기층
            // 
            this.col보조기층.FieldName = "보조기층";
            this.col보조기층.MinWidth = 37;
            this.col보조기층.Name = "col보조기층";
            this.col보조기층.Visible = true;
            this.col보조기층.Width = 73;
            // 
            // col보조기층부피
            // 
            this.col보조기층부피.FieldName = "보조기층부피";
            this.col보조기층부피.MinWidth = 37;
            this.col보조기층부피.Name = "col보조기층부피";
            this.col보조기층부피.Visible = true;
            this.col보조기층부피.Width = 74;
            // 
            // gridBand13
            // 
            this.gridBand13.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand13.Caption = "모래";
            this.gridBand13.Columns.Add(this.col모래);
            this.gridBand13.Columns.Add(this.col모래부피);
            this.gridBand13.Name = "gridBand13";
            this.gridBand13.VisibleIndex = 3;
            this.gridBand13.Width = 147;
            // 
            // col모래
            // 
            this.col모래.FieldName = "모래";
            this.col모래.MinWidth = 37;
            this.col모래.Name = "col모래";
            this.col모래.Visible = true;
            this.col모래.Width = 73;
            // 
            // col모래부피
            // 
            this.col모래부피.FieldName = "모래부피";
            this.col모래부피.MinWidth = 37;
            this.col모래부피.Name = "col모래부피";
            this.col모래부피.Visible = true;
            this.col모래부피.Width = 74;
            // 
            // gridBand14
            // 
            this.gridBand14.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand14.Caption = "석분";
            this.gridBand14.Columns.Add(this.col석분면적);
            this.gridBand14.Columns.Add(this.col석분부피);
            this.gridBand14.Name = "gridBand14";
            this.gridBand14.VisibleIndex = 4;
            this.gridBand14.Width = 153;
            // 
            // col석분면적
            // 
            this.col석분면적.FieldName = "석분면적";
            this.col석분면적.MinWidth = 37;
            this.col석분면적.Name = "col석분면적";
            this.col석분면적.Visible = true;
            this.col석분면적.Width = 76;
            // 
            // col석분부피
            // 
            this.col석분부피.FieldName = "석분부피";
            this.col석분부피.MinWidth = 37;
            this.col석분부피.Name = "col석분부피";
            this.col석분부피.Visible = true;
            this.col석분부피.Width = 77;
            // 
            // simpleButton11
            // 
            this.simpleButton11.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton11.ImageOptions.SvgImage")));
            this.simpleButton11.Location = new System.Drawing.Point(894, 686);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(123, 44);
            this.simpleButton11.StyleController = this.layoutControl1;
            this.simpleButton11.TabIndex = 5;
            this.simpleButton11.Text = "삭제";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(1021, 686);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(128, 44);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "조회";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1171, 750);
            this.Root.TextVisible = false;
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup1;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(1153, 734);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1131, 684);
            this.layoutControlGroup1.Text = "토적표";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1131, 636);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton11;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(872, 636);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(127, 48);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton2;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(999, 636);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(132, 48);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 636);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(872, 48);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frm관로토공
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1171, 780);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm관로토공";
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataQry;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton11;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col관로번호;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col측점;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col누가거리;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col거리;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col포장코드;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col포장;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col육상면적;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col육상부피;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col수중면적;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col수중부피;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col관주위면적;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col관주위부피;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col관상부;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col관상부부피;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand8;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col관기초면적;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col관기초부피;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand9;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand10;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col절단;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand11;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col깨기및복구면적;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col깨기및복구부피;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand12;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col보조기층;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col보조기층부피;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand13;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col모래;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col모래부피;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand14;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col석분면적;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col석분부피;
    }
}
