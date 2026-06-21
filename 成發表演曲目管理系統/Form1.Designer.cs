namespace 成發表演曲目管理系統
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSearchCount = new System.Windows.Forms.Button();
            this.btnSearchGroup = new System.Windows.Forms.Button();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.btnBattle = new System.Windows.Forms.Button();
            this.btnOverview = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlOverview = new System.Windows.Forms.Panel();
            this.lblBattleCount = new System.Windows.Forms.Label();
            this.lblTotalSongs = new System.Windows.Forms.Label();
            this.flpAllSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOverviewTitle = new System.Windows.Forms.Label();
            this.pnlBattlePage = new System.Windows.Forms.Panel();
            this.flpBattleSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBattleTotal = new System.Windows.Forms.Label();
            this.lblBattleDesc = new System.Windows.Forms.Label();
            this.lblBattleTitle = new System.Windows.Forms.Label();
            this.pnlSearchMemberPage = new System.Windows.Forms.Panel();
            this.flpMemberResult = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMemberSongCount = new System.Windows.Forms.Label();
            this.lblMemberResultTitle = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblMemberSearchTitle = new System.Windows.Forms.Label();
            this.pnlSearchGroupPage = new System.Windows.Forms.Panel();
            this.flpGroupResult = new System.Windows.Forms.FlowLayoutPanel();
            this.lblGroupSongCount = new System.Windows.Forms.Label();
            this.lblGroupResultTitle = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.lblGroupSearchTitle = new System.Windows.Forms.Label();
            this.pnlSearchCountPage = new System.Windows.Forms.Panel();
            this.flpCountResult = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCountSongTotal = new System.Windows.Forms.Label();
            this.lblCountResultTitle = new System.Windows.Forms.Label();
            this.nudOriginalCount = new System.Windows.Forms.NumericUpDown();
            this.lblCountSearchTitle = new System.Windows.Forms.Label();
            this.pnlImportPage = new System.Windows.Forms.Panel();
            this.btnGenerateCards = new System.Windows.Forms.Button();
            this.dgvImportPreview = new System.Windows.Forms.DataGridView();
            this.lblPreviewTitle = new System.Windows.Forms.Label();
            this.lblImportHint = new System.Windows.Forms.Label();
            this.lblSongFileName = new System.Windows.Forms.Label();
            this.btnImportFile = new System.Windows.Forms.Button();
            this.lblImportTitle = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlMenu.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlOverview.SuspendLayout();
            this.pnlBattlePage.SuspendLayout();
            this.pnlSearchMemberPage.SuspendLayout();
            this.pnlSearchGroupPage.SuspendLayout();
            this.pnlSearchCountPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOriginalCount)).BeginInit();
            this.pnlImportPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnImport);
            this.pnlMenu.Controls.Add(this.btnSearchCount);
            this.pnlMenu.Controls.Add(this.btnSearchGroup);
            this.pnlMenu.Controls.Add(this.btnSearchMember);
            this.pnlMenu.Controls.Add(this.btnBattle);
            this.pnlMenu.Controls.Add(this.btnOverview);
            this.pnlMenu.Location = new System.Drawing.Point(13, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(776, 94);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(653, 18);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(101, 59);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "匯入資料";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnSearchCount
            // 
            this.btnSearchCount.Location = new System.Drawing.Point(530, 18);
            this.btnSearchCount.Name = "btnSearchCount";
            this.btnSearchCount.Size = new System.Drawing.Size(101, 59);
            this.btnSearchCount.TabIndex = 4;
            this.btnSearchCount.Text = "查人數";
            this.btnSearchCount.UseVisualStyleBackColor = true;
            // 
            // btnSearchGroup
            // 
            this.btnSearchGroup.Location = new System.Drawing.Point(405, 18);
            this.btnSearchGroup.Name = "btnSearchGroup";
            this.btnSearchGroup.Size = new System.Drawing.Size(101, 59);
            this.btnSearchGroup.TabIndex = 3;
            this.btnSearchGroup.Text = "查團體";
            this.btnSearchGroup.UseVisualStyleBackColor = true;
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Location = new System.Drawing.Point(279, 18);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(101, 59);
            this.btnSearchMember.TabIndex = 2;
            this.btnSearchMember.Text = "查表演者";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            // 
            // btnBattle
            // 
            this.btnBattle.Location = new System.Drawing.Point(147, 18);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(101, 59);
            this.btnBattle.TabIndex = 1;
            this.btnBattle.Text = "Battle專區";
            this.btnBattle.UseVisualStyleBackColor = true;
            // 
            // btnOverview
            // 
            this.btnOverview.Location = new System.Drawing.Point(20, 18);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(101, 59);
            this.btnOverview.TabIndex = 0;
            this.btnOverview.Text = "總覽";
            this.btnOverview.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pnlOverview);
            this.pnlMain.Controls.Add(this.pnlBattlePage);
            this.pnlMain.Controls.Add(this.pnlSearchMemberPage);
            this.pnlMain.Controls.Add(this.pnlSearchGroupPage);
            this.pnlMain.Controls.Add(this.pnlSearchCountPage);
            this.pnlMain.Controls.Add(this.pnlImportPage);
            this.pnlMain.Location = new System.Drawing.Point(12, 138);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(776, 294);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlOverview
            // 
            this.pnlOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOverview.BackColor = System.Drawing.Color.White;
            this.pnlOverview.Controls.Add(this.lblBattleCount);
            this.pnlOverview.Controls.Add(this.lblTotalSongs);
            this.pnlOverview.Controls.Add(this.flpAllSongs);
            this.pnlOverview.Controls.Add(this.lblOverviewTitle);
            this.pnlOverview.Location = new System.Drawing.Point(0, 0);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Size = new System.Drawing.Size(1073, 505);
            this.pnlOverview.TabIndex = 0;
            // 
            // lblBattleCount
            // 
            this.lblBattleCount.AutoSize = true;
            this.lblBattleCount.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBattleCount.ForeColor = System.Drawing.Color.Red;
            this.lblBattleCount.Location = new System.Drawing.Point(401, 25);
            this.lblBattleCount.Name = "lblBattleCount";
            this.lblBattleCount.Size = new System.Drawing.Size(122, 25);
            this.lblBattleCount.TabIndex = 3;
            this.lblBattleCount.Text = "需 Battle：0";
            // 
            // lblTotalSongs
            // 
            this.lblTotalSongs.AutoSize = true;
            this.lblTotalSongs.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalSongs.Location = new System.Drawing.Point(264, 25);
            this.lblTotalSongs.Name = "lblTotalSongs";
            this.lblTotalSongs.Size = new System.Drawing.Size(104, 25);
            this.lblTotalSongs.TabIndex = 2;
            this.lblTotalSongs.Text = "總曲目：0";
            this.lblTotalSongs.Click += new System.EventHandler(this.label1_Click);
            // 
            // flpAllSongs
            // 
            this.flpAllSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpAllSongs.AutoScroll = true;
            this.flpAllSongs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAllSongs.Location = new System.Drawing.Point(21, 68);
            this.flpAllSongs.Name = "flpAllSongs";
            this.flpAllSongs.Size = new System.Drawing.Size(734, 209);
            this.flpAllSongs.TabIndex = 1;
            // 
            // lblOverviewTitle
            // 
            this.lblOverviewTitle.AutoSize = true;
            this.lblOverviewTitle.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOverviewTitle.Location = new System.Drawing.Point(18, 16);
            this.lblOverviewTitle.Name = "lblOverviewTitle";
            this.lblOverviewTitle.Size = new System.Drawing.Size(209, 40);
            this.lblOverviewTitle.TabIndex = 0;
            this.lblOverviewTitle.Text = "完整清單預覽";
            // 
            // pnlBattlePage
            // 
            this.pnlBattlePage.Controls.Add(this.flpBattleSongs);
            this.pnlBattlePage.Controls.Add(this.lblBattleTotal);
            this.pnlBattlePage.Controls.Add(this.lblBattleDesc);
            this.pnlBattlePage.Controls.Add(this.lblBattleTitle);
            this.pnlBattlePage.Location = new System.Drawing.Point(0, 0);
            this.pnlBattlePage.Name = "pnlBattlePage";
            this.pnlBattlePage.Size = new System.Drawing.Size(777, 291);
            this.pnlBattlePage.TabIndex = 0;
            this.pnlBattlePage.Visible = false;
            // 
            // flpBattleSongs
            // 
            this.flpBattleSongs.AutoScroll = true;
            this.flpBattleSongs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpBattleSongs.Location = new System.Drawing.Point(21, 68);
            this.flpBattleSongs.Name = "flpBattleSongs";
            this.flpBattleSongs.Size = new System.Drawing.Size(734, 209);
            this.flpBattleSongs.TabIndex = 3;
            // 
            // lblBattleTotal
            // 
            this.lblBattleTotal.AutoSize = true;
            this.lblBattleTotal.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBattleTotal.Location = new System.Drawing.Point(649, 28);
            this.lblBattleTotal.Name = "lblBattleTotal";
            this.lblBattleTotal.Size = new System.Drawing.Size(74, 25);
            this.lblBattleTotal.TabIndex = 2;
            this.lblBattleTotal.Text = "共 0 首";
            // 
            // lblBattleDesc
            // 
            this.lblBattleDesc.AutoSize = true;
            this.lblBattleDesc.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBattleDesc.Location = new System.Drawing.Point(305, 28);
            this.lblBattleDesc.Name = "lblBattleDesc";
            this.lblBattleDesc.Size = new System.Drawing.Size(312, 25);
            this.lblBattleDesc.TabIndex = 1;
            this.lblBattleDesc.Text = "以下歌曲報名人數已超過原定人數";
            // 
            // lblBattleTitle
            // 
            this.lblBattleTitle.AutoSize = true;
            this.lblBattleTitle.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBattleTitle.Location = new System.Drawing.Point(18, 16);
            this.lblBattleTitle.Name = "lblBattleTitle";
            this.lblBattleTitle.Size = new System.Drawing.Size(281, 40);
            this.lblBattleTitle.TabIndex = 0;
            this.lblBattleTitle.Text = "需要 Battle 的曲目";
            // 
            // pnlSearchMemberPage
            // 
            this.pnlSearchMemberPage.Controls.Add(this.flpMemberResult);
            this.pnlSearchMemberPage.Controls.Add(this.lblMemberSongCount);
            this.pnlSearchMemberPage.Controls.Add(this.lblMemberResultTitle);
            this.pnlSearchMemberPage.Controls.Add(this.txtMemberName);
            this.pnlSearchMemberPage.Controls.Add(this.lblMemberSearchTitle);
            this.pnlSearchMemberPage.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchMemberPage.Name = "pnlSearchMemberPage";
            this.pnlSearchMemberPage.Size = new System.Drawing.Size(776, 294);
            this.pnlSearchMemberPage.TabIndex = 0;
            // 
            // flpMemberResult
            // 
            this.flpMemberResult.AutoScroll = true;
            this.flpMemberResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpMemberResult.Location = new System.Drawing.Point(21, 56);
            this.flpMemberResult.Name = "flpMemberResult";
            this.flpMemberResult.Size = new System.Drawing.Size(743, 221);
            this.flpMemberResult.TabIndex = 4;
            this.flpMemberResult.Visible = false;
            // 
            // lblMemberSongCount
            // 
            this.lblMemberSongCount.AutoSize = true;
            this.lblMemberSongCount.Location = new System.Drawing.Point(483, 16);
            this.lblMemberSongCount.Name = "lblMemberSongCount";
            this.lblMemberSongCount.Size = new System.Drawing.Size(80, 18);
            this.lblMemberSongCount.TabIndex = 3;
            this.lblMemberSongCount.Text = "共 0 首歌";
            // 
            // lblMemberResultTitle
            // 
            this.lblMemberResultTitle.AutoSize = true;
            this.lblMemberResultTitle.Location = new System.Drawing.Point(376, 16);
            this.lblMemberResultTitle.Name = "lblMemberResultTitle";
            this.lblMemberResultTitle.Size = new System.Drawing.Size(80, 18);
            this.lblMemberResultTitle.TabIndex = 2;
            this.lblMemberResultTitle.Text = "搜尋結果";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMemberName.Location = new System.Drawing.Point(180, 7);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(166, 34);
            this.txtMemberName.TabIndex = 1;
            // 
            // lblMemberSearchTitle
            // 
            this.lblMemberSearchTitle.AutoSize = true;
            this.lblMemberSearchTitle.Location = new System.Drawing.Point(22, 16);
            this.lblMemberSearchTitle.Name = "lblMemberSearchTitle";
            this.lblMemberSearchTitle.Size = new System.Drawing.Size(152, 18);
            this.lblMemberSearchTitle.TabIndex = 0;
            this.lblMemberSearchTitle.Text = "輸入表演人員姓名";
            // 
            // pnlSearchGroupPage
            // 
            this.pnlSearchGroupPage.Controls.Add(this.flpGroupResult);
            this.pnlSearchGroupPage.Controls.Add(this.lblGroupSongCount);
            this.pnlSearchGroupPage.Controls.Add(this.lblGroupResultTitle);
            this.pnlSearchGroupPage.Controls.Add(this.txtGroupName);
            this.pnlSearchGroupPage.Controls.Add(this.lblGroupSearchTitle);
            this.pnlSearchGroupPage.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchGroupPage.Name = "pnlSearchGroupPage";
            this.pnlSearchGroupPage.Size = new System.Drawing.Size(776, 291);
            this.pnlSearchGroupPage.TabIndex = 0;
            this.pnlSearchGroupPage.Visible = false;
            // 
            // flpGroupResult
            // 
            this.flpGroupResult.AutoScroll = true;
            this.flpGroupResult.AutoSize = true;
            this.flpGroupResult.Location = new System.Drawing.Point(21, 59);
            this.flpGroupResult.Name = "flpGroupResult";
            this.flpGroupResult.Size = new System.Drawing.Size(734, 218);
            this.flpGroupResult.TabIndex = 4;
            // 
            // lblGroupSongCount
            // 
            this.lblGroupSongCount.AutoSize = true;
            this.lblGroupSongCount.Location = new System.Drawing.Point(504, 25);
            this.lblGroupSongCount.Name = "lblGroupSongCount";
            this.lblGroupSongCount.Size = new System.Drawing.Size(80, 18);
            this.lblGroupSongCount.TabIndex = 3;
            this.lblGroupSongCount.Text = "共 0 首歌";
            // 
            // lblGroupResultTitle
            // 
            this.lblGroupResultTitle.AutoSize = true;
            this.lblGroupResultTitle.Location = new System.Drawing.Point(394, 28);
            this.lblGroupResultTitle.Name = "lblGroupResultTitle";
            this.lblGroupResultTitle.Size = new System.Drawing.Size(80, 18);
            this.lblGroupResultTitle.TabIndex = 2;
            this.lblGroupResultTitle.Text = "搜尋結果";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGroupName.Location = new System.Drawing.Point(149, 16);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(221, 34);
            this.txtGroupName.TabIndex = 1;
            // 
            // lblGroupSearchTitle
            // 
            this.lblGroupSearchTitle.AutoSize = true;
            this.lblGroupSearchTitle.Location = new System.Drawing.Point(18, 23);
            this.lblGroupSearchTitle.Name = "lblGroupSearchTitle";
            this.lblGroupSearchTitle.Size = new System.Drawing.Size(116, 18);
            this.lblGroupSearchTitle.TabIndex = 0;
            this.lblGroupSearchTitle.Text = "輸入團體名稱";
            // 
            // pnlSearchCountPage
            // 
            this.pnlSearchCountPage.Controls.Add(this.flpCountResult);
            this.pnlSearchCountPage.Controls.Add(this.lblCountSongTotal);
            this.pnlSearchCountPage.Controls.Add(this.lblCountResultTitle);
            this.pnlSearchCountPage.Controls.Add(this.nudOriginalCount);
            this.pnlSearchCountPage.Controls.Add(this.lblCountSearchTitle);
            this.pnlSearchCountPage.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchCountPage.Name = "pnlSearchCountPage";
            this.pnlSearchCountPage.Size = new System.Drawing.Size(776, 294);
            this.pnlSearchCountPage.TabIndex = 0;
            this.pnlSearchCountPage.Visible = false;
            // 
            // flpCountResult
            // 
            this.flpCountResult.AutoScroll = true;
            this.flpCountResult.AutoSize = true;
            this.flpCountResult.Location = new System.Drawing.Point(21, 59);
            this.flpCountResult.Name = "flpCountResult";
            this.flpCountResult.Size = new System.Drawing.Size(734, 218);
            this.flpCountResult.TabIndex = 4;
            // 
            // lblCountSongTotal
            // 
            this.lblCountSongTotal.AutoSize = true;
            this.lblCountSongTotal.Location = new System.Drawing.Point(418, 23);
            this.lblCountSongTotal.Name = "lblCountSongTotal";
            this.lblCountSongTotal.Size = new System.Drawing.Size(80, 18);
            this.lblCountSongTotal.TabIndex = 3;
            this.lblCountSongTotal.Text = "共 0 首歌";
            // 
            // lblCountResultTitle
            // 
            this.lblCountResultTitle.AutoSize = true;
            this.lblCountResultTitle.Location = new System.Drawing.Point(320, 23);
            this.lblCountResultTitle.Name = "lblCountResultTitle";
            this.lblCountResultTitle.Size = new System.Drawing.Size(80, 18);
            this.lblCountResultTitle.TabIndex = 2;
            this.lblCountResultTitle.Text = "搜尋結果";
            // 
            // nudOriginalCount
            // 
            this.nudOriginalCount.Location = new System.Drawing.Point(144, 16);
            this.nudOriginalCount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudOriginalCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOriginalCount.Name = "nudOriginalCount";
            this.nudOriginalCount.Size = new System.Drawing.Size(120, 29);
            this.nudOriginalCount.TabIndex = 1;
            this.nudOriginalCount.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // lblCountSearchTitle
            // 
            this.lblCountSearchTitle.AutoSize = true;
            this.lblCountSearchTitle.Location = new System.Drawing.Point(22, 23);
            this.lblCountSearchTitle.Name = "lblCountSearchTitle";
            this.lblCountSearchTitle.Size = new System.Drawing.Size(116, 18);
            this.lblCountSearchTitle.TabIndex = 0;
            this.lblCountSearchTitle.Text = "輸入原曲人數";
            // 
            // pnlImportPage
            // 
            this.pnlImportPage.Controls.Add(this.btnGenerateCards);
            this.pnlImportPage.Controls.Add(this.dgvImportPreview);
            this.pnlImportPage.Controls.Add(this.lblPreviewTitle);
            this.pnlImportPage.Controls.Add(this.lblImportHint);
            this.pnlImportPage.Controls.Add(this.lblSongFileName);
            this.pnlImportPage.Controls.Add(this.btnImportFile);
            this.pnlImportPage.Controls.Add(this.lblImportTitle);
            this.pnlImportPage.Location = new System.Drawing.Point(0, 0);
            this.pnlImportPage.Name = "pnlImportPage";
            this.pnlImportPage.Size = new System.Drawing.Size(777, 294);
            this.pnlImportPage.TabIndex = 0;
            this.pnlImportPage.Visible = false;
            // 
            // btnGenerateCards
            // 
            this.btnGenerateCards.Location = new System.Drawing.Point(21, 220);
            this.btnGenerateCards.Name = "btnGenerateCards";
            this.btnGenerateCards.Size = new System.Drawing.Size(153, 57);
            this.btnGenerateCards.TabIndex = 6;
            this.btnGenerateCards.Text = "產生曲目卡片";
            this.btnGenerateCards.UseVisualStyleBackColor = true;
            // 
            // dgvImportPreview
            // 
            this.dgvImportPreview.AllowUserToAddRows = false;
            this.dgvImportPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImportPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportPreview.Location = new System.Drawing.Point(421, 23);
            this.dgvImportPreview.Name = "dgvImportPreview";
            this.dgvImportPreview.ReadOnly = true;
            this.dgvImportPreview.RowHeadersVisible = false;
            this.dgvImportPreview.RowHeadersWidth = 62;
            this.dgvImportPreview.RowTemplate.Height = 31;
            this.dgvImportPreview.Size = new System.Drawing.Size(334, 254);
            this.dgvImportPreview.TabIndex = 5;
            // 
            // lblPreviewTitle
            // 
            this.lblPreviewTitle.AutoSize = true;
            this.lblPreviewTitle.Location = new System.Drawing.Point(25, 191);
            this.lblPreviewTitle.Name = "lblPreviewTitle";
            this.lblPreviewTitle.Size = new System.Drawing.Size(116, 18);
            this.lblPreviewTitle.TabIndex = 4;
            this.lblPreviewTitle.Text = "匯入資料預覽";
            // 
            // lblImportHint
            // 
            this.lblImportHint.AutoSize = true;
            this.lblImportHint.Location = new System.Drawing.Point(25, 143);
            this.lblImportHint.Name = "lblImportHint";
            this.lblImportHint.Size = new System.Drawing.Size(372, 18);
            this.lblImportHint.TabIndex = 3;
            this.lblImportHint.Text = "檔案格式：團體-曲目/原定人數/姓名、姓名......";
            // 
            // lblSongFileName
            // 
            this.lblSongFileName.AutoSize = true;
            this.lblSongFileName.Location = new System.Drawing.Point(194, 83);
            this.lblSongFileName.Name = "lblSongFileName";
            this.lblSongFileName.Size = new System.Drawing.Size(152, 18);
            this.lblSongFileName.TabIndex = 2;
            this.lblSongFileName.Text = "尚未選擇曲目檔案";
            // 
            // btnImportFile
            // 
            this.btnImportFile.Location = new System.Drawing.Point(28, 68);
            this.btnImportFile.Name = "btnImportFile";
            this.btnImportFile.Size = new System.Drawing.Size(160, 49);
            this.btnImportFile.TabIndex = 1;
            this.btnImportFile.Text = "匯入曲目名單檔案";
            this.btnImportFile.UseVisualStyleBackColor = true;
            // 
            // lblImportTitle
            // 
            this.lblImportTitle.AutoSize = true;
            this.lblImportTitle.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblImportTitle.Location = new System.Drawing.Point(22, 23);
            this.lblImportTitle.Name = "lblImportTitle";
            this.lblImportTitle.Size = new System.Drawing.Size(127, 35);
            this.lblImportTitle.TabIndex = 0;
            this.lblImportTitle.Text = "匯入資料";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 690);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlOverview.ResumeLayout(false);
            this.pnlOverview.PerformLayout();
            this.pnlBattlePage.ResumeLayout(false);
            this.pnlBattlePage.PerformLayout();
            this.pnlSearchMemberPage.ResumeLayout(false);
            this.pnlSearchMemberPage.PerformLayout();
            this.pnlSearchGroupPage.ResumeLayout(false);
            this.pnlSearchGroupPage.PerformLayout();
            this.pnlSearchCountPage.ResumeLayout(false);
            this.pnlSearchCountPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOriginalCount)).EndInit();
            this.pnlImportPage.ResumeLayout(false);
            this.pnlImportPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSearchCount;
        private System.Windows.Forms.Button btnSearchGroup;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Button btnBattle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlOverview;
        private System.Windows.Forms.Panel pnlBattlePage;
        private System.Windows.Forms.Panel pnlSearchMemberPage;
        private System.Windows.Forms.Panel pnlSearchGroupPage;
        private System.Windows.Forms.Panel pnlSearchCountPage;
        private System.Windows.Forms.Panel pnlImportPage;
        private System.Windows.Forms.Label lblOverviewTitle;
        private System.Windows.Forms.FlowLayoutPanel flpAllSongs;
        private System.Windows.Forms.FlowLayoutPanel flpBattleSongs;
        private System.Windows.Forms.Label lblBattleTotal;
        private System.Windows.Forms.Label lblBattleDesc;
        private System.Windows.Forms.Label lblBattleTitle;
        private System.Windows.Forms.FlowLayoutPanel flpMemberResult;
        private System.Windows.Forms.Label lblMemberSongCount;
        private System.Windows.Forms.Label lblMemberResultTitle;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lblMemberSearchTitle;
        private System.Windows.Forms.FlowLayoutPanel flpGroupResult;
        private System.Windows.Forms.Label lblGroupSongCount;
        private System.Windows.Forms.Label lblGroupResultTitle;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label lblGroupSearchTitle;
        private System.Windows.Forms.FlowLayoutPanel flpCountResult;
        private System.Windows.Forms.Label lblCountSongTotal;
        private System.Windows.Forms.Label lblCountResultTitle;
        private System.Windows.Forms.NumericUpDown nudOriginalCount;
        private System.Windows.Forms.Label lblCountSearchTitle;
        private System.Windows.Forms.Label lblSongFileName;
        private System.Windows.Forms.Button btnImportFile;
        private System.Windows.Forms.Label lblImportTitle;
        private System.Windows.Forms.Button btnGenerateCards;
        private System.Windows.Forms.DataGridView dgvImportPreview;
        private System.Windows.Forms.Label lblPreviewTitle;
        private System.Windows.Forms.Label lblImportHint;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblTotalSongs;
        private System.Windows.Forms.Label lblBattleCount;
    }
}

