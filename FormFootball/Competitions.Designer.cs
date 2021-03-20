namespace FormFootball
{
    partial class Competitions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Competitions));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.comboBoxLeagues = new System.Windows.Forms.ComboBox();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.comboBoxCountries = new System.Windows.Forms.ComboBox();
            this.BtnCountries = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExport = new FontAwesome.Sharp.IconButton();
            this.btnResults = new FontAwesome.Sharp.IconButton();
            this.btnSubscribe = new FontAwesome.Sharp.IconButton();
            this.lblSubscribe = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnExpand = new FontAwesome.Sharp.IconButton();
            this.lblStandings = new System.Windows.Forms.Label();
            this.labelGames = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewLeagues = new System.Windows.Forms.DataGridView();
            this.clubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeagueId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchWin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchLose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchDraw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchPlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoalsScored = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoalsGet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeagueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewFixtures = new System.Windows.Forms.DataGridView();
            this.HomeTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AwayTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeagueName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelImage = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeagues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFixtures)).BeginInit();
            this.panelImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.comboBoxLeagues);
            this.panel1.Controls.Add(this.menuPanel);
            this.panel1.Controls.Add(this.BtnCountries);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 703);
            this.panel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRefresh.IconColor = System.Drawing.Color.Black;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.Location = new System.Drawing.Point(0, 594);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(259, 45);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Brown;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 639);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(259, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // comboBoxLeagues
            // 
            this.comboBoxLeagues.BackColor = System.Drawing.Color.Black;
            this.comboBoxLeagues.ForeColor = System.Drawing.Color.White;
            this.comboBoxLeagues.FormattingEnabled = true;
            this.comboBoxLeagues.Location = new System.Drawing.Point(0, 188);
            this.comboBoxLeagues.Name = "comboBoxLeagues";
            this.comboBoxLeagues.Size = new System.Drawing.Size(259, 23);
            this.comboBoxLeagues.TabIndex = 1;
            this.comboBoxLeagues.Text = "Choose league";
            this.comboBoxLeagues.SelectedIndexChanged += new System.EventHandler(this.comboBoxLeagues_SelectedIndexChanged);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.DarkGray;
            this.menuPanel.Controls.Add(this.comboBoxCountries);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 165);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(259, 24);
            this.menuPanel.TabIndex = 2;
            // 
            // comboBoxCountries
            // 
            this.comboBoxCountries.BackColor = System.Drawing.Color.Black;
            this.comboBoxCountries.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxCountries.ForeColor = System.Drawing.Color.White;
            this.comboBoxCountries.FormattingEnabled = true;
            this.comboBoxCountries.Location = new System.Drawing.Point(0, 0);
            this.comboBoxCountries.Name = "comboBoxCountries";
            this.comboBoxCountries.Size = new System.Drawing.Size(259, 23);
            this.comboBoxCountries.TabIndex = 0;
            this.comboBoxCountries.Text = "Choose country";
            this.comboBoxCountries.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountries_SelectedIndexChanged);
            // 
            // BtnCountries
            // 
            this.BtnCountries.BackColor = System.Drawing.Color.Black;
            this.BtnCountries.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCountries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnCountries.ForeColor = System.Drawing.Color.White;
            this.BtnCountries.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnCountries.IconColor = System.Drawing.Color.Black;
            this.BtnCountries.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCountries.Location = new System.Drawing.Point(0, 120);
            this.BtnCountries.Name = "BtnCountries";
            this.BtnCountries.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnCountries.Size = new System.Drawing.Size(259, 45);
            this.BtnCountries.TabIndex = 1;
            this.BtnCountries.Text = "Countries";
            this.BtnCountries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCountries.UseVisualStyleBackColor = false;
            this.BtnCountries.Click += new System.EventHandler(this.BtnCountries_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::FormFootball.Properties.Resources.logo__1_;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 120);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnExport);
            this.panel3.Controls.Add(this.btnResults);
            this.panel3.Controls.Add(this.btnSubscribe);
            this.panel3.Controls.Add(this.lblSubscribe);
            this.panel3.Controls.Add(this.txtMail);
            this.panel3.Controls.Add(this.lblSearch);
            this.panel3.Controls.Add(this.textBoxSearch);
            this.panel3.Controls.Add(this.btnExpand);
            this.panel3.Controls.Add(this.lblStandings);
            this.panel3.Controls.Add(this.labelGames);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(259, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1030, 120);
            this.panel3.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExport.BackColor = System.Drawing.Color.White;
            this.btnExport.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExport.IconColor = System.Drawing.Color.Black;
            this.btnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExport.Location = new System.Drawing.Point(735, 84);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(145, 34);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnResults
            // 
            this.btnResults.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnResults.BackColor = System.Drawing.Color.Black;
            this.btnResults.ForeColor = System.Drawing.Color.White;
            this.btnResults.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnResults.IconColor = System.Drawing.Color.Black;
            this.btnResults.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResults.Location = new System.Drawing.Point(878, 84);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(151, 34);
            this.btnResults.TabIndex = 8;
            this.btnResults.Text = "Results";
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubscribe.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubscribe.IconColor = System.Drawing.Color.Black;
            this.btnSubscribe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubscribe.Location = new System.Drawing.Point(895, 23);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(104, 23);
            this.btnSubscribe.TabIndex = 7;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // lblSubscribe
            // 
            this.lblSubscribe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubscribe.ForeColor = System.Drawing.Color.White;
            this.lblSubscribe.Location = new System.Drawing.Point(584, 25);
            this.lblSubscribe.Name = "lblSubscribe";
            this.lblSubscribe.Size = new System.Drawing.Size(86, 19);
            this.lblSubscribe.TabIndex = 6;
            this.lblSubscribe.Text = "Enter mail";
            this.lblSubscribe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMail
            // 
            this.txtMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMail.Location = new System.Drawing.Point(676, 25);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(213, 21);
            this.txtMail.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(-3, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(90, 21);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(73, 25);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(381, 21);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // btnExpand
            // 
            this.btnExpand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExpand.BackColor = System.Drawing.Color.Black;
            this.btnExpand.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExpand.FlatAppearance.BorderSize = 0;
            this.btnExpand.ForeColor = System.Drawing.Color.White;
            this.btnExpand.IconChar = FontAwesome.Sharp.IconChar.ExpandArrowsAlt;
            this.btnExpand.IconColor = System.Drawing.Color.White;
            this.btnExpand.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExpand.IconSize = 33;
            this.btnExpand.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExpand.Location = new System.Drawing.Point(384, 84);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(148, 34);
            this.btnExpand.TabIndex = 2;
            this.btnExpand.Text = "Expand Table";
            this.btnExpand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click_1);
            // 
            // lblStandings
            // 
            this.lblStandings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStandings.BackColor = System.Drawing.Color.Black;
            this.lblStandings.ForeColor = System.Drawing.Color.White;
            this.lblStandings.Location = new System.Drawing.Point(1, 84);
            this.lblStandings.Name = "lblStandings";
            this.lblStandings.Size = new System.Drawing.Size(131, 34);
            this.lblStandings.TabIndex = 1;
            this.lblStandings.Text = "Standings";
            this.lblStandings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGames
            // 
            this.labelGames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGames.BackColor = System.Drawing.Color.Black;
            this.labelGames.ForeColor = System.Drawing.Color.White;
            this.labelGames.Location = new System.Drawing.Point(587, 84);
            this.labelGames.Name = "labelGames";
            this.labelGames.Size = new System.Drawing.Size(106, 34);
            this.labelGames.TabIndex = 0;
            this.labelGames.Text = "Fixtures";
            this.labelGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkRed;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(259, 603);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1030, 100);
            this.panel4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(240, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Presented to you by: VSMTI SPORT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewLeagues
            // 
            this.dataGridViewLeagues.AllowUserToAddRows = false;
            this.dataGridViewLeagues.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridViewLeagues.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLeagues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLeagues.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewLeagues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLeagues.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewLeagues.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLeagues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLeagues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeagues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clubName,
            this.LeagueId2,
            this.CountryName,
            this.MatchWin,
            this.MatchLose,
            this.MatchDraw,
            this.MatchPlayed,
            this.GoalsScored,
            this.GoalsGet,
            this.TeamId,
            this.LeagueName,
            this.Position,
            this.Points});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLeagues.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewLeagues.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewLeagues.Location = new System.Drawing.Point(259, 120);
            this.dataGridViewLeagues.Name = "dataGridViewLeagues";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLeagues.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewLeagues.RowHeadersVisible = false;
            this.dataGridViewLeagues.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewLeagues.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewLeagues.Size = new System.Drawing.Size(532, 483);
            this.dataGridViewLeagues.TabIndex = 8;
            // 
            // clubName
            // 
            this.clubName.DataPropertyName = "clubName";
            this.clubName.HeaderText = "Club name";
            this.clubName.MinimumWidth = 6;
            this.clubName.Name = "clubName";
            // 
            // LeagueId2
            // 
            this.LeagueId2.DataPropertyName = "LeagueId";
            this.LeagueId2.HeaderText = "League Id";
            this.LeagueId2.MinimumWidth = 6;
            this.LeagueId2.Name = "LeagueId2";
            // 
            // CountryName
            // 
            this.CountryName.DataPropertyName = "CountryName";
            this.CountryName.HeaderText = "Country Name";
            this.CountryName.MinimumWidth = 6;
            this.CountryName.Name = "CountryName";
            // 
            // MatchWin
            // 
            this.MatchWin.DataPropertyName = "MatchWin";
            this.MatchWin.HeaderText = "Win";
            this.MatchWin.MinimumWidth = 6;
            this.MatchWin.Name = "MatchWin";
            // 
            // MatchLose
            // 
            this.MatchLose.DataPropertyName = "MatchLose";
            this.MatchLose.HeaderText = "Lose";
            this.MatchLose.MinimumWidth = 6;
            this.MatchLose.Name = "MatchLose";
            // 
            // MatchDraw
            // 
            this.MatchDraw.DataPropertyName = "MatchDraw";
            this.MatchDraw.HeaderText = "Draw";
            this.MatchDraw.MinimumWidth = 6;
            this.MatchDraw.Name = "MatchDraw";
            // 
            // MatchPlayed
            // 
            this.MatchPlayed.DataPropertyName = "MatchPlayed";
            this.MatchPlayed.HeaderText = "Played";
            this.MatchPlayed.MinimumWidth = 6;
            this.MatchPlayed.Name = "MatchPlayed";
            // 
            // GoalsScored
            // 
            this.GoalsScored.DataPropertyName = "GoalsScored";
            this.GoalsScored.HeaderText = "Goals Scored";
            this.GoalsScored.MinimumWidth = 6;
            this.GoalsScored.Name = "GoalsScored";
            // 
            // GoalsGet
            // 
            this.GoalsGet.DataPropertyName = "GoalsGet";
            this.GoalsGet.HeaderText = "Goals Get";
            this.GoalsGet.MinimumWidth = 6;
            this.GoalsGet.Name = "GoalsGet";
            // 
            // TeamId
            // 
            this.TeamId.DataPropertyName = "TeamId";
            this.TeamId.HeaderText = "Team Id";
            this.TeamId.MinimumWidth = 6;
            this.TeamId.Name = "TeamId";
            // 
            // LeagueName
            // 
            this.LeagueName.DataPropertyName = "LeagueName";
            this.LeagueName.HeaderText = "League Name";
            this.LeagueName.MinimumWidth = 6;
            this.LeagueName.Name = "LeagueName";
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Position";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            // 
            // Points
            // 
            this.Points.DataPropertyName = "Points";
            this.Points.HeaderText = "Points";
            this.Points.MinimumWidth = 6;
            this.Points.Name = "Points";
            // 
            // dataGridViewFixtures
            // 
            this.dataGridViewFixtures.AllowUserToAddRows = false;
            this.dataGridViewFixtures.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.dataGridViewFixtures.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewFixtures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFixtures.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewFixtures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFixtures.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewFixtures.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFixtures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewFixtures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFixtures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HomeTeam,
            this.AwayTeam,
            this.Date,
            this.LeagueName2});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFixtures.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewFixtures.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewFixtures.Location = new System.Drawing.Point(848, 120);
            this.dataGridViewFixtures.Name = "dataGridViewFixtures";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFixtures.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewFixtures.RowHeadersVisible = false;
            this.dataGridViewFixtures.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewFixtures.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewFixtures.Size = new System.Drawing.Size(441, 483);
            this.dataGridViewFixtures.TabIndex = 9;
            // 
            // HomeTeam
            // 
            this.HomeTeam.DataPropertyName = "HomeTeam";
            this.HomeTeam.HeaderText = "Home Team";
            this.HomeTeam.MinimumWidth = 6;
            this.HomeTeam.Name = "HomeTeam";
            // 
            // AwayTeam
            // 
            this.AwayTeam.DataPropertyName = "AwayTeam";
            this.AwayTeam.HeaderText = "Away Team";
            this.AwayTeam.MinimumWidth = 6;
            this.AwayTeam.Name = "AwayTeam";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // LeagueName2
            // 
            this.LeagueName2.DataPropertyName = "LeagueName";
            this.LeagueName2.HeaderText = "League name";
            this.LeagueName2.Name = "LeagueName2";
            // 
            // panelImage
            // 
            this.panelImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelImage.BackColor = System.Drawing.Color.White;
            this.panelImage.BackgroundImage = global::FormFootball.Properties.Resources._14059cabed5424a2eba4fd3d099ae543__1_;
            this.panelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImage.Controls.Add(this.lblWelcome);
            this.panelImage.Location = new System.Drawing.Point(259, 120);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(1030, 483);
            this.panelImage.TabIndex = 10;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(333, 35);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(386, 76);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "WELCOME";
            // 
            // Competitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1289, 703);
            this.Controls.Add(this.dataGridViewFixtures);
            this.Controls.Add(this.dataGridViewLeagues);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1305, 739);
            this.Name = "Competitions";
            this.Text = "Football";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeagues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFixtures)).EndInit();
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel menuPanel;
        private FontAwesome.Sharp.IconButton BtnCountries;
        public System.Windows.Forms.ComboBox comboBoxCountries;
        public System.Windows.Forms.ComboBox comboBoxLeagues;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblStandings;
        private System.Windows.Forms.Label labelGames;
        private FontAwesome.Sharp.IconButton btnExpand;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridViewLeagues;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeagueId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchWin;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchLose;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchDraw;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchPlayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoalsScored;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoalsGet;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeagueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        public System.Windows.Forms.DataGridView dataGridViewFixtures;
        public System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Label lblWelcome;
        public System.Windows.Forms.Label lblSearch;
        public System.Windows.Forms.TextBox textBoxSearch;
        private FontAwesome.Sharp.IconButton btnSubscribe;
        private System.Windows.Forms.Label lblSubscribe;
        public System.Windows.Forms.TextBox txtMail;
        private FontAwesome.Sharp.IconButton btnRefresh;
        public FontAwesome.Sharp.IconButton btnResults;
        private FontAwesome.Sharp.IconButton btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwayTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeagueName2;
    }
}

