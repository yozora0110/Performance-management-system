using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 成發表演曲目管理系統
{
    public partial class Form1 : Form
    {
        private List<SongItem> songs = new List<SongItem>();

        public Form1()
        {
            InitializeComponent();

            ApplyLayout();
            SetupEvents();
            ShowPage("pnlOverview");
            UpdateStats();
        }

        // =========================
        // 曲目資料類別
        // =========================
        private class SongItem
        {
            public string GroupName { get; set; }
            public string SongName { get; set; }
            public int OriginalCount { get; set; }
            public List<string> Members { get; set; }

            public int CurrentCount
            {
                get { return Members.Count; }
            }

            public bool NeedBattle
            {
                get { return CurrentCount > OriginalCount; }
            }

            public int ExtraCount
            {
                get { return CurrentCount - OriginalCount; }
            }

            public string MemberText
            {
                get { return string.Join("、", Members); }
            }
        }

        // =========================
        // 版面設定
        // =========================
        private void ApplyLayout()
        {
            this.Size = new Size(1150, 750);

            Panel pnlMenu = FindControlByName<Panel>("pnlMenu");
            Panel pnlMain = FindControlByName<Panel>("pnlMain");

            if (pnlMenu != null)
            {
                pnlMenu.Location = new Point(25, 25);
                pnlMenu.Size = new Size(1060, 100);
            }

            if (pnlMain != null)
            {
                pnlMain.Location = new Point(25, 150);
                pnlMain.Size = new Size(1060, 530);
            }

            SetButtonStyle(FindControlByName<Button>("btnOverview"), new Point(30, 22), "總覽");
            SetButtonStyle(FindControlByName<Button>("btnBattle"), new Point(180, 22), "Battle專區");
            SetButtonStyle(FindControlByName<Button>("btnSearchMember"), new Point(330, 22), "查表演者");
            SetButtonStyle(FindControlByName<Button>("btnSearchGroup"), new Point(480, 22), "查團體");
            SetButtonStyle(FindControlByName<Button>("btnSearchCount"), new Point(630, 22), "查人數");
            SetButtonStyle(FindControlByName<Button>("btnImport"), new Point(780, 22), "匯入資料");

            string[] pageNames =
            {
                "pnlOverview",
                "pnlBattlePage",
                "pnlSearchMemberPage",
                "pnlSearchGroupPage",
                "pnlSearchCountPage",
                "pnlImportPage"
            };

            foreach (string pageName in pageNames)
            {
                Panel page = FindControlByName<Panel>(pageName);

                if (page != null)
                {
                    page.Dock = DockStyle.Fill;
                    page.BackColor = Color.White;
                }
            }

            // 總覽頁
            Label lblOverviewTitle = FindControlByName<Label>("lblOverviewTitle");
            Label lblTotalSongs = FindControlByName<Label>("lblTotalSongs");
            Label lblBattleCount = FindControlByName<Label>("lblBattleCount");

            if (lblOverviewTitle != null)
            {
                lblOverviewTitle.Location = new Point(30, 25);
                lblOverviewTitle.Font = new Font("微軟正黑體", 18, FontStyle.Bold);
                lblOverviewTitle.AutoSize = true;
            }

            if (lblTotalSongs != null)
            {
                lblTotalSongs.Location = new Point(310, 32);
                lblTotalSongs.Font = new Font("微軟正黑體", 13, FontStyle.Bold);
                lblTotalSongs.AutoSize = true;
            }

            if (lblBattleCount != null)
            {
                lblBattleCount.Location = new Point(470, 32);
                lblBattleCount.Font = new Font("微軟正黑體", 13, FontStyle.Bold);
                lblBattleCount.ForeColor = Color.Red;
                lblBattleCount.AutoSize = true;
            }

            EnsureResultFlow("pnlOverview", "flpAllSongs", new Point(30, 85), new Size(980, 400));

            // Battle 頁
            Label lblBattleTitle = FindControlByName<Label>("lblBattleTitle");
            Label lblBattleDesc = FindControlByName<Label>("lblBattleDesc");
            Label lblBattleTotal = FindControlByName<Label>("lblBattleTotal");

            if (lblBattleTitle != null)
            {
                lblBattleTitle.Location = new Point(30, 25);
                lblBattleTitle.Font = new Font("微軟正黑體", 18, FontStyle.Bold);
                lblBattleTitle.AutoSize = true;
            }

            if (lblBattleDesc != null)
            {
                lblBattleDesc.Location = new Point(310, 35);
                lblBattleDesc.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
                lblBattleDesc.AutoSize = true;
            }

            if (lblBattleTotal != null)
            {
                lblBattleTotal.Location = new Point(620, 35);
                lblBattleTotal.Font = new Font("微軟正黑體", 11, FontStyle.Bold);
                lblBattleTotal.AutoSize = true;
            }

            EnsureResultFlow("pnlBattlePage", "flpBattleSongs", new Point(30, 85), new Size(980, 400));

            // 查表演者頁
            Label lblMemberSearchTitle = FindControlByName<Label>("lblMemberSearchTitle");
            Label lblMemberResultTitle = FindControlByName<Label>("lblMemberResultTitle");
            Label lblMemberSongCount = FindControlByName<Label>("lblMemberSongCount");
            TextBox txtMemberName = FindControlByName<TextBox>("txtMemberName");

            if (lblMemberSearchTitle != null)
            {
                lblMemberSearchTitle.Location = new Point(30, 25);
                lblMemberSearchTitle.Font = new Font("微軟正黑體", 11, FontStyle.Bold);
                lblMemberSearchTitle.AutoSize = true;
            }

            if (txtMemberName != null)
            {
                txtMemberName.Location = new Point(160, 20);
                txtMemberName.Size = new Size(220, 35);
                txtMemberName.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
            }

            if (lblMemberResultTitle != null)
            {
                lblMemberResultTitle.Location = new Point(420, 25);
                lblMemberResultTitle.Font = new Font("微軟正黑體", 11, FontStyle.Bold);
                lblMemberResultTitle.AutoSize = true;
            }

            if (lblMemberSongCount != null)
            {
                lblMemberSongCount.Location = new Point(520, 25);
                lblMemberSongCount.Font = new Font("微軟正黑體", 11, FontStyle.Bold);
                lblMemberSongCount.AutoSize = true;
            }

            EnsureResultFlow("pnlSearchMemberPage", "flpMemberResult", new Point(30, 80), new Size(980, 400));

            // 查團體頁
            Label lblGroupSearchTitle = FindControlByName<Label>("lblGroupSearchTitle");
            Label lblGroupResultTitle = FindControlByName<Label>("lblGroupResultTitle");
            Label lblGroupSongCount = FindControlByName<Label>("lblGroupSongCount");
            TextBox txtGroupName = FindControlByName<TextBox>("txtGroupName");

            if (lblGroupSearchTitle != null)
            {
                lblGroupSearchTitle.Location = new Point(30, 25);
                lblGroupSearchTitle.Font = new Font("微軟正黑體", 11, FontStyle.Bold);
                lblGroupSearchTitle.AutoSize = true;
            }

            if (txtGroupName != null)
            {
                txtGroupName.Location = new Point(160, 20);
                txtGroupName.Size = new Size(220, 35);
                txtGroupName.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
            }

            if (lblGroupResultTitle != null)
            {
                lblGroupResultTitle.Location = new Point(420, 25);
                lblGroupResultTitle.Font = new Font("微軟正黑體", 11, FontStyle.Bold);
                lblGroupResultTitle.AutoSize = true;
            }

            if (lblGroupSongCount != null)
            {
                lblGroupSongCount.Location = new Point(520, 25);
                lblGroupSongCount.Font = new Font("微軟正黑體", 11, FontStyle.Bold);
                lblGroupSongCount.AutoSize = true;
            }

            EnsureResultFlow("pnlSearchGroupPage", "flpGroupResult", new Point(30, 80), new Size(980, 400));

            // 查人數頁
            Label lblCountSearchTitle = FindControlByName<Label>("lblCountSearchTitle");
            Label lblCountResultTitle = FindControlByName<Label>("lblCountResultTitle");
            Label lblCountSongTotal = FindControlByName<Label>("lblCountSongTotal");
            NumericUpDown nudOriginalCount = FindControlByName<NumericUpDown>("nudOriginalCount");

            if (lblCountSearchTitle != null)
            {
                lblCountSearchTitle.Location = new Point(30, 25);
                lblCountSearchTitle.Font = new Font("微軟正黑體", 11, FontStyle.Bold);
                lblCountSearchTitle.AutoSize = true;
            }

            if (nudOriginalCount != null)
            {
                nudOriginalCount.Location = new Point(160, 20);
                nudOriginalCount.Size = new Size(100, 35);
                nudOriginalCount.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
            }

            if (lblCountResultTitle != null)
            {
                lblCountResultTitle.Location = new Point(320, 25);
                lblCountResultTitle.Font = new Font("微軟正黑體", 11, FontStyle.Bold);
                lblCountResultTitle.AutoSize = true;
            }

            if (lblCountSongTotal != null)
            {
                lblCountSongTotal.Location = new Point(420, 25);
                lblCountSongTotal.Font = new Font("微軟正黑體", 11, FontStyle.Bold);
                lblCountSongTotal.AutoSize = true;
            }

            EnsureResultFlow("pnlSearchCountPage", "flpCountResult", new Point(30, 80), new Size(980, 400));

            // 匯入資料頁
            Label lblImportTitle = FindControlByName<Label>("lblImportTitle");
            Label lblSongFileName = FindControlByName<Label>("lblSongFileName");
            Label lblFileName = FindControlByName<Label>("lblFileName");
            Label lblImportHint = FindControlByName<Label>("lblImportHint");
            Label lblPreviewTitle = FindControlByName<Label>("lblPreviewTitle");
            Button btnImportFile = FindControlByName<Button>("btnImportFile");
            Button btnGenerateCards = FindControlByName<Button>("btnGenerateCards");
            DataGridView dgvImportPreview = FindControlByName<DataGridView>("dgvImportPreview");

            if (lblImportTitle != null)
            {
                lblImportTitle.Location = new Point(30, 20);
                lblImportTitle.Font = new Font("微軟正黑體", 18, FontStyle.Bold);
                lblImportTitle.AutoSize = true;
                lblImportTitle.BringToFront();
            }

            if (btnImportFile != null)
            {
                btnImportFile.Location = new Point(30, 75);
                btnImportFile.Size = new Size(180, 45);
                btnImportFile.Font = new Font("微軟正黑體", 10, FontStyle.Bold);
                btnImportFile.BringToFront();
            }

            if (lblSongFileName != null)
            {
                lblSongFileName.Location = new Point(230, 88);
                lblSongFileName.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
                lblSongFileName.AutoSize = true;
                lblSongFileName.BringToFront();
            }

            if (lblFileName != null)
            {
                lblFileName.Location = new Point(230, 88);
                lblFileName.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
                lblFileName.AutoSize = true;
                lblFileName.BringToFront();
            }

            if (lblImportHint != null)
            {
                lblImportHint.Location = new Point(30, 140);
                lblImportHint.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
                lblImportHint.AutoSize = true;
                lblImportHint.BringToFront();
            }

            if (lblPreviewTitle != null)
            {
                lblPreviewTitle.Location = new Point(30, 185);
                lblPreviewTitle.Font = new Font("微軟正黑體", 11, FontStyle.Bold);
                lblPreviewTitle.AutoSize = true;
                lblPreviewTitle.BringToFront();
            }

            if (btnGenerateCards != null)
            {
                btnGenerateCards.Location = new Point(30, 230);
                btnGenerateCards.Size = new Size(180, 45);
                btnGenerateCards.Font = new Font("微軟正黑體", 10, FontStyle.Bold);
                btnGenerateCards.BringToFront();
            }

            if (dgvImportPreview != null)
            {
                dgvImportPreview.Dock = DockStyle.None;
                dgvImportPreview.Location = new Point(320, 180);
                dgvImportPreview.Size = new Size(650, 260);
                dgvImportPreview.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                dgvImportPreview.ReadOnly = true;
                dgvImportPreview.AllowUserToAddRows = false;
                dgvImportPreview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvImportPreview.RowHeadersVisible = false;
                dgvImportPreview.BringToFront();
            }
        }

        private void SetButtonStyle(Button btn, Point location, string text)
        {
            if (btn == null)
            {
                return;
            }

            btn.Text = text;
            btn.Location = location;
            btn.Size = new Size(120, 55);
            btn.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
        }

        // 確保結果顯示區存在，找不到就自動建立
        private FlowLayoutPanel EnsureResultFlow(string pageName, string flowName, Point location, Size size)
        {
            Panel page = FindControlByName<Panel>(pageName);

            if (page == null)
            {
                return null;
            }

            FlowLayoutPanel flow = FindControlByName<FlowLayoutPanel>(flowName);

            if (flow == null)
            {
                flow = new FlowLayoutPanel();
                flow.Name = flowName;
                page.Controls.Add(flow);
            }
            else
            {
                if (flow.Parent != page)
                {
                    flow.Parent.Controls.Remove(flow);
                    page.Controls.Add(flow);
                }
            }

            flow.Dock = DockStyle.None;
            flow.Location = location;
            flow.Size = size;
            flow.AutoScroll = true;
            flow.WrapContents = false;
            flow.FlowDirection = FlowDirection.TopDown;
            flow.BorderStyle = BorderStyle.FixedSingle;
            flow.BackColor = Color.White;
            flow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flow.Visible = true;
            flow.Enabled = true;
            flow.BringToFront();

            return flow;
        }

        // =========================
        // 綁定事件
        // =========================
        private void SetupEvents()
        {
            Button btnOverview = FindControlByName<Button>("btnOverview");
            Button btnBattle = FindControlByName<Button>("btnBattle");
            Button btnSearchMember = FindControlByName<Button>("btnSearchMember");
            Button btnSearchGroup = FindControlByName<Button>("btnSearchGroup");
            Button btnSearchCount = FindControlByName<Button>("btnSearchCount");
            Button btnImport = FindControlByName<Button>("btnImport");

            Button btnImportFile = FindControlByName<Button>("btnImportFile");
            Button btnGenerateCards = FindControlByName<Button>("btnGenerateCards");

            TextBox txtMemberName = FindControlByName<TextBox>("txtMemberName");
            TextBox txtGroupName = FindControlByName<TextBox>("txtGroupName");
            NumericUpDown nudOriginalCount = FindControlByName<NumericUpDown>("nudOriginalCount");

            if (btnOverview != null)
            {
                btnOverview.Click += (s, e) =>
                {
                    ShowPage("pnlOverview");
                    UpdateStats();
                    RenderSongsToFlow("pnlOverview", "flpAllSongs", songs);
                };
            }

            if (btnBattle != null)
            {
                btnBattle.Click += (s, e) =>
                {
                    ShowPage("pnlBattlePage");
                    RenderBattleSongs();
                };
            }

            if (btnSearchMember != null)
            {
                btnSearchMember.Click += (s, e) =>
                {
                    ShowPage("pnlSearchMemberPage");
                    SearchMember();
                };
            }

            if (btnSearchGroup != null)
            {
                btnSearchGroup.Click += (s, e) =>
                {
                    ShowPage("pnlSearchGroupPage");
                    SearchGroup();
                };
            }

            if (btnSearchCount != null)
            {
                btnSearchCount.Click += (s, e) =>
                {
                    ShowPage("pnlSearchCountPage");
                    SearchCount();
                };
            }

            if (btnImport != null)
            {
                btnImport.Click += (s, e) =>
                {
                    ShowPage("pnlImportPage");
                };
            }

            if (btnImportFile != null)
            {
                btnImportFile.Click += (s, e) =>
                {
                    ImportFile();
                };
            }

            if (btnGenerateCards != null)
            {
                btnGenerateCards.Click += (s, e) =>
                {
                    if (songs.Count == 0)
                    {
                        MessageBox.Show("請先匯入曲目名單檔案。");
                        return;
                    }

                    UpdateStats();
                    ShowPage("pnlOverview");
                    RenderSongsToFlow("pnlOverview", "flpAllSongs", songs);
                };
            }

            if (txtMemberName != null)
            {
                txtMemberName.TextChanged += (s, e) =>
                {
                    SearchMember();
                };
            }

            if (txtGroupName != null)
            {
                txtGroupName.TextChanged += (s, e) =>
                {
                    SearchGroup();
                };
            }

            if (nudOriginalCount != null)
            {
                nudOriginalCount.ValueChanged += (s, e) =>
                {
                    SearchCount();
                };
            }
        }

        // =========================
        // 匯入檔案
        // =========================
        private void ImportFile()
        {
            openFileDialog1.Filter = "文字檔案 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
            openFileDialog1.Title = "選擇曲目名單檔案";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                songs.Clear();

                string[] lines = File.ReadAllLines(openFileDialog1.FileName, Encoding.UTF8);

                int errorCount = 0;

                foreach (string rawLine in lines)
                {
                    string line = rawLine.Trim();

                    if (line == "")
                    {
                        continue;
                    }

                    SongItem item = ParseLine(line);

                    if (item != null)
                    {
                        songs.Add(item);
                    }
                    else
                    {
                        errorCount++;
                    }
                }

                Label lblSongFileName = FindControlByName<Label>("lblSongFileName");
                Label lblFileName = FindControlByName<Label>("lblFileName");

                if (lblSongFileName != null)
                {
                    lblSongFileName.Text = Path.GetFileName(openFileDialog1.FileName);
                }

                if (lblFileName != null)
                {
                    lblFileName.Text = Path.GetFileName(openFileDialog1.FileName);
                }

                ShowImportPreview();
                UpdateStats();

                MessageBox.Show("匯入完成！共匯入 " + songs.Count + " 首曲目。");

                if (errorCount > 0)
                {
                    MessageBox.Show("有 " + errorCount + " 行格式錯誤，已略過。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("匯入失敗：" + ex.Message);
            }
        }

        // 格式：團體-曲目/原定人數/姓名、姓名、姓名
        private SongItem ParseLine(string line)
        {
            try
            {
                string[] parts = line.Split('/');

                if (parts.Length < 3)
                {
                    return null;
                }

                string groupAndSong = parts[0].Trim();
                string countText = parts[1].Trim();
                string membersText = string.Join("/", parts.Skip(2)).Trim();

                int dashIndex = groupAndSong.IndexOf('-');

                if (dashIndex < 0)
                {
                    return null;
                }

                string groupName = groupAndSong.Substring(0, dashIndex).Trim();
                string songName = groupAndSong.Substring(dashIndex + 1).Trim();

                int originalCount;
                if (!int.TryParse(countText, out originalCount))
                {
                    return null;
                }

                List<string> members = membersText
                    .Split(new char[] { '、', ',', '，' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .Where(x => x != "")
                    .ToList();

                SongItem item = new SongItem();
                item.GroupName = groupName;
                item.SongName = songName;
                item.OriginalCount = originalCount;
                item.Members = members;

                return item;
            }
            catch
            {
                return null;
            }
        }

        // =========================
        // 匯入資料預覽
        // =========================
        private void ShowImportPreview()
        {
            DataGridView dgv = FindControlByName<DataGridView>("dgvImportPreview");

            if (dgv == null)
            {
                return;
            }

            DataTable table = new DataTable();
            table.Columns.Add("團體名稱");
            table.Columns.Add("曲目名稱");
            table.Columns.Add("原定人數");
            table.Columns.Add("報名人數");
            table.Columns.Add("需Battle");
            table.Columns.Add("報名名單");

            foreach (SongItem song in songs)
            {
                table.Rows.Add(
                    song.GroupName,
                    song.SongName,
                    song.OriginalCount,
                    song.CurrentCount,
                    song.NeedBattle ? "是" : "否",
                    song.MemberText
                );
            }

            dgv.DataSource = table;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
        }

        // =========================
        // 更新總曲目與 Battle 數
        // =========================
        private void UpdateStats()
        {
            Label lblTotalSongs = FindControlByName<Label>("lblTotalSongs");
            Label lblBattleCount = FindControlByName<Label>("lblBattleCount");

            int battleCount = songs.Count(x => x.NeedBattle);

            if (lblTotalSongs != null)
            {
                lblTotalSongs.Text = "總曲目：" + songs.Count;
            }

            if (lblBattleCount != null)
            {
                lblBattleCount.Text = "需 Battle：" + battleCount;
                lblBattleCount.ForeColor = Color.Red;
            }
        }

        // =========================
        // Battle 專區
        // =========================
        private void RenderBattleSongs()
        {
            List<SongItem> battleSongs = songs.Where(x => x.NeedBattle).ToList();

            Label lblBattleTotal = FindControlByName<Label>("lblBattleTotal");

            if (lblBattleTotal != null)
            {
                lblBattleTotal.Text = "共 " + battleSongs.Count + " 首";
            }

            RenderSongsToFlow("pnlBattlePage", "flpBattleSongs", battleSongs);
        }

        // =========================
        // 查表演者
        // =========================
        private void SearchMember()
        {
            TextBox txtMemberName = FindControlByName<TextBox>("txtMemberName");
            Label lblMemberSongCount = FindControlByName<Label>("lblMemberSongCount");

            if (txtMemberName == null)
            {
                return;
            }

            string keyword = txtMemberName.Text.Trim();

            List<SongItem> result;

            if (keyword == "")
            {
                result = new List<SongItem>();
            }
            else
            {
                result = songs
                    .Where(x => x.Members.Any(m => m.Contains(keyword)))
                    .ToList();
            }

            if (lblMemberSongCount != null)
            {
                lblMemberSongCount.Text = "共 " + result.Count + " 首歌";
            }

            RenderSongsToFlow("pnlSearchMemberPage", "flpMemberResult", result);
        }

        // =========================
        // 查團體
        // =========================
        private void SearchGroup()
        {
            TextBox txtGroupName = FindControlByName<TextBox>("txtGroupName");
            Label lblGroupSongCount = FindControlByName<Label>("lblGroupSongCount");

            if (txtGroupName == null)
            {
                return;
            }

            string keyword = txtGroupName.Text.Trim();

            List<SongItem> result;

            if (keyword == "")
            {
                result = new List<SongItem>();
            }
            else
            {
                result = songs
                    .Where(x => x.GroupName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();
            }

            if (lblGroupSongCount != null)
            {
                lblGroupSongCount.Text = "共 " + result.Count + " 首歌";
            }

            RenderSongsToFlow("pnlSearchGroupPage", "flpGroupResult", result);
        }

        // =========================
        // 查人數
        // =========================
        private void SearchCount()
        {
            NumericUpDown nudOriginalCount = FindControlByName<NumericUpDown>("nudOriginalCount");
            Label lblCountSongTotal = FindControlByName<Label>("lblCountSongTotal");

            if (nudOriginalCount == null)
            {
                return;
            }

            int count = (int)nudOriginalCount.Value;

            List<SongItem> result = songs
                .Where(x => x.OriginalCount == count)
                .ToList();

            if (lblCountSongTotal != null)
            {
                lblCountSongTotal.Text = "共 " + result.Count + " 首歌";
            }

            RenderSongsToFlow("pnlSearchCountPage", "flpCountResult", result);
        }

        // =========================
        // 顯示歌曲卡片
        // =========================
        private void RenderSongsToFlow(string pageName, string flowName, List<SongItem> list)
        {
            Point location = new Point(30, 80);
            Size size = new Size(980, 400);

            if (flowName == "flpAllSongs" || flowName == "flpBattleSongs")
            {
                location = new Point(30, 85);
                size = new Size(980, 400);
            }

            FlowLayoutPanel flow = EnsureResultFlow(pageName, flowName, location, size);

            if (flow == null)
            {
                MessageBox.Show("找不到頁面：" + pageName);
                return;
            }

            flow.Controls.Clear();
            flow.Visible = true;
            flow.Enabled = true;
            flow.BringToFront();

            if (list.Count == 0)
            {
                Label emptyLabel = new Label();
                emptyLabel.Text = "沒有符合的曲目";
                emptyLabel.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                emptyLabel.ForeColor = Color.Gray;
                emptyLabel.AutoSize = true;
                emptyLabel.Margin = new Padding(15);

                flow.Controls.Add(emptyLabel);
                return;
            }

            foreach (SongItem song in list)
            {
                Panel card = CreateSongCard(song);
                flow.Controls.Add(card);
            }
        }

        private Panel CreateSongCard(SongItem song)
        {
            Panel card = new Panel();
            card.Width = 900;
            card.Height = 150;
            card.Margin = new Padding(10);
            card.BorderStyle = BorderStyle.FixedSingle;
            card.BackColor = song.NeedBattle ? Color.MistyRose : Color.White;

            Label lblTitle = new Label();
            lblTitle.Text = song.GroupName + " - " + song.SongName;
            lblTitle.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
            lblTitle.Location = new Point(15, 10);
            lblTitle.Size = new Size(850, 28);

            Label lblCount = new Label();
            lblCount.Text = "目前：" + song.CurrentCount + " / 原定：" + song.OriginalCount;
            lblCount.Font = new Font("微軟正黑體", 10, FontStyle.Bold);
            lblCount.Location = new Point(15, 45);
            lblCount.Size = new Size(850, 25);

            Label lblBattle = new Label();

            if (song.NeedBattle)
            {
                lblBattle.Text = "需 Battle：是，多 " + song.ExtraCount + " 人";
                lblBattle.ForeColor = Color.Red;
            }
            else
            {
                lblBattle.Text = "需 Battle：否";
                lblBattle.ForeColor = Color.Black;
            }

            lblBattle.Font = new Font("微軟正黑體", 10, FontStyle.Bold);
            lblBattle.Location = new Point(15, 72);
            lblBattle.Size = new Size(850, 25);

            Label lblMembers = new Label();
            lblMembers.Text = "報名：" + song.MemberText;
            lblMembers.Font = new Font("微軟正黑體", 9, FontStyle.Regular);
            lblMembers.Location = new Point(15, 100);
            lblMembers.Size = new Size(850, 45);

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblCount);
            card.Controls.Add(lblBattle);
            card.Controls.Add(lblMembers);

            return card;
        }

        // =========================
        // 切換頁面
        // =========================
        private void ShowPage(string pageName)
        {
            string[] pageNames =
            {
                "pnlOverview",
                "pnlBattlePage",
                "pnlSearchMemberPage",
                "pnlSearchGroupPage",
                "pnlSearchCountPage",
                "pnlImportPage"
            };

            foreach (string name in pageNames)
            {
                Panel panel = FindControlByName<Panel>(name);

                if (panel != null)
                {
                    panel.Visible = false;
                }
            }

            Panel target = FindControlByName<Panel>(pageName);

            if (target != null)
            {
                target.Visible = true;
                target.BringToFront();
            }
        }

        // =========================
        // 用名稱找控制項
        // =========================
        private T FindControlByName<T>(string name) where T : Control
        {
            return FindControlRecursive<T>(this, name);
        }

        private T FindControlRecursive<T>(Control parent, string name) where T : Control
        {
            foreach (Control c in parent.Controls)
            {
                if (c.Name == name && c is T)
                {
                    return (T)c;
                }

                T child = FindControlRecursive<T>(c, name);

                if (child != null)
                {
                    return child;
                }
            }

            return null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}