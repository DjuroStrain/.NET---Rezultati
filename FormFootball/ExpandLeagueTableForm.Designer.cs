namespace FormFootball
{
    partial class ExpandLeagueTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpandLeagueTableForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit2 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPresent = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblLeagueName = new System.Windows.Forms.Label();
            this.lblLeague = new System.Windows.Forms.Label();
            this.lblSearch2 = new System.Windows.Forms.Label();
            this.textBoxSearch2 = new System.Windows.Forms.TextBox();
            this.dataGridViewLeaguesExpand = new System.Windows.Forms.DataGridView();
            this.clubName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchPlayed2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchWin2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchDraw2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchLose2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoalsScored2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoalsGet2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeagueId3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeagueName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaguesExpand)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 703);
            this.panel1.TabIndex = 0;
            // 
            // btnExit2
            // 
            this.btnExit2.BackColor = System.Drawing.Color.Brown;
            this.btnExit2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit2.ForeColor = System.Drawing.Color.White;
            this.btnExit2.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExit2.IconColor = System.Drawing.Color.Black;
            this.btnExit2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit2.Location = new System.Drawing.Point(0, 656);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(257, 45);
            this.btnExit2.TabIndex = 4;
            this.btnExit2.Text = "Exit";
            this.btnExit2.UseVisualStyleBackColor = false;
            this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::FormFootball.Properties.Resources.logo__1_;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 120);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkRed;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblPresent);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(259, 603);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1030, 100);
            this.panel4.TabIndex = 6;
            // 
            // lblPresent
            // 
            this.lblPresent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPresent.BackColor = System.Drawing.Color.Black;
            this.lblPresent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPresent.ForeColor = System.Drawing.Color.White;
            this.lblPresent.Location = new System.Drawing.Point(194, 29);
            this.lblPresent.Name = "lblPresent";
            this.lblPresent.Size = new System.Drawing.Size(640, 41);
            this.lblPresent.TabIndex = 1;
            this.lblPresent.Text = "Presented to you by: VSMTI SPORT";
            this.lblPresent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblCountryName);
            this.panel3.Controls.Add(this.lblCountry);
            this.panel3.Controls.Add(this.lblLeagueName);
            this.panel3.Controls.Add(this.lblLeague);
            this.panel3.Controls.Add(this.lblSearch2);
            this.panel3.Controls.Add(this.textBoxSearch2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(259, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1030, 120);
            this.panel3.TabIndex = 7;
            // 
            // lblCountryName
            // 
            this.lblCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCountryName.ForeColor = System.Drawing.Color.White;
            this.lblCountryName.Location = new System.Drawing.Point(92, 51);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(100, 23);
            this.lblCountryName.TabIndex = 10;
            this.lblCountryName.Text = "label2";
            this.lblCountryName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCountry
            // 
            this.lblCountry.BackColor = System.Drawing.Color.DarkRed;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCountry.ForeColor = System.Drawing.Color.Yellow;
            this.lblCountry.Location = new System.Drawing.Point(5, 49);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(81, 23);
            this.lblCountry.TabIndex = 9;
            this.lblCountry.Text = "Country:";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeagueName
            // 
            this.lblLeagueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLeagueName.ForeColor = System.Drawing.Color.White;
            this.lblLeagueName.Location = new System.Drawing.Point(92, 85);
            this.lblLeagueName.Name = "lblLeagueName";
            this.lblLeagueName.Size = new System.Drawing.Size(100, 23);
            this.lblLeagueName.TabIndex = 8;
            this.lblLeagueName.Text = "label2";
            this.lblLeagueName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLeague
            // 
            this.lblLeague.BackColor = System.Drawing.Color.DarkRed;
            this.lblLeague.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLeague.ForeColor = System.Drawing.Color.Yellow;
            this.lblLeague.Location = new System.Drawing.Point(5, 83);
            this.lblLeague.Name = "lblLeague";
            this.lblLeague.Size = new System.Drawing.Size(81, 23);
            this.lblLeague.TabIndex = 7;
            this.lblLeague.Text = "League:";
            this.lblLeague.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSearch2
            // 
            this.lblSearch2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearch2.ForeColor = System.Drawing.Color.White;
            this.lblSearch2.Location = new System.Drawing.Point(303, 48);
            this.lblSearch2.Name = "lblSearch2";
            this.lblSearch2.Size = new System.Drawing.Size(60, 21);
            this.lblSearch2.TabIndex = 6;
            this.lblSearch2.Text = "Search";
            this.lblSearch2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSearch2
            // 
            this.textBoxSearch2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSearch2.Location = new System.Drawing.Point(378, 49);
            this.textBoxSearch2.Name = "textBoxSearch2";
            this.textBoxSearch2.Size = new System.Drawing.Size(347, 20);
            this.textBoxSearch2.TabIndex = 5;
            this.textBoxSearch2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSearch2.TextChanged += new System.EventHandler(this.textBoxSearch2_TextChanged_1);
            // 
            // dataGridViewLeaguesExpand
            // 
            this.dataGridViewLeaguesExpand.AllowUserToAddRows = false;
            this.dataGridViewLeaguesExpand.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridViewLeaguesExpand.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLeaguesExpand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLeaguesExpand.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewLeaguesExpand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLeaguesExpand.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLeaguesExpand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLeaguesExpand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeaguesExpand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clubName2,
            this.Position2,
            this.Points2,
            this.MatchPlayed2,
            this.MatchWin2,
            this.MatchDraw2,
            this.MatchLose2,
            this.GoalsScored2,
            this.GoalsGet2,
            this.LeagueId3,
            this.CountryName2,
            this.TeamId2,
            this.LeagueName2});
            this.dataGridViewLeaguesExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLeaguesExpand.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewLeaguesExpand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLeaguesExpand.GridColor = System.Drawing.Color.Black;
            this.dataGridViewLeaguesExpand.Location = new System.Drawing.Point(259, 120);
            this.dataGridViewLeaguesExpand.Name = "dataGridViewLeaguesExpand";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLeaguesExpand.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewLeaguesExpand.RowHeadersVisible = false;
            this.dataGridViewLeaguesExpand.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLeaguesExpand.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewLeaguesExpand.Size = new System.Drawing.Size(1030, 483);
            this.dataGridViewLeaguesExpand.TabIndex = 8;
            this.dataGridViewLeaguesExpand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLeaguesExpand_CellContentClick_1);
            // 
            // clubName2
            // 
            this.clubName2.DataPropertyName = "clubName";
            this.clubName2.HeaderText = "Club name";
            this.clubName2.MinimumWidth = 6;
            this.clubName2.Name = "clubName2";
            // 
            // Position2
            // 
            this.Position2.DataPropertyName = "Position";
            this.Position2.HeaderText = "Position";
            this.Position2.MinimumWidth = 6;
            this.Position2.Name = "Position2";
            // 
            // Points2
            // 
            this.Points2.DataPropertyName = "Points";
            this.Points2.HeaderText = "Points";
            this.Points2.MinimumWidth = 6;
            this.Points2.Name = "Points2";
            // 
            // MatchPlayed2
            // 
            this.MatchPlayed2.DataPropertyName = "MatchPlayed";
            this.MatchPlayed2.HeaderText = "Played";
            this.MatchPlayed2.MinimumWidth = 6;
            this.MatchPlayed2.Name = "MatchPlayed2";
            // 
            // MatchWin2
            // 
            this.MatchWin2.DataPropertyName = "MatchWin";
            this.MatchWin2.HeaderText = "Win";
            this.MatchWin2.MinimumWidth = 6;
            this.MatchWin2.Name = "MatchWin2";
            // 
            // MatchDraw2
            // 
            this.MatchDraw2.DataPropertyName = "MatchDraw";
            this.MatchDraw2.HeaderText = "Draw";
            this.MatchDraw2.MinimumWidth = 6;
            this.MatchDraw2.Name = "MatchDraw2";
            // 
            // MatchLose2
            // 
            this.MatchLose2.DataPropertyName = "MatchLose";
            this.MatchLose2.HeaderText = "Lose";
            this.MatchLose2.MinimumWidth = 6;
            this.MatchLose2.Name = "MatchLose2";
            // 
            // GoalsScored2
            // 
            this.GoalsScored2.DataPropertyName = "GoalsScored";
            this.GoalsScored2.HeaderText = "Goals For";
            this.GoalsScored2.MinimumWidth = 6;
            this.GoalsScored2.Name = "GoalsScored2";
            // 
            // GoalsGet2
            // 
            this.GoalsGet2.DataPropertyName = "GoalsGet";
            this.GoalsGet2.HeaderText = "Goals Against";
            this.GoalsGet2.MinimumWidth = 6;
            this.GoalsGet2.Name = "GoalsGet2";
            // 
            // LeagueId3
            // 
            this.LeagueId3.DataPropertyName = "LeagueId";
            this.LeagueId3.HeaderText = "League Id";
            this.LeagueId3.MinimumWidth = 6;
            this.LeagueId3.Name = "LeagueId3";
            // 
            // CountryName2
            // 
            this.CountryName2.DataPropertyName = "CountryName";
            this.CountryName2.HeaderText = "Country Name";
            this.CountryName2.MinimumWidth = 6;
            this.CountryName2.Name = "CountryName2";
            // 
            // TeamId2
            // 
            this.TeamId2.DataPropertyName = "TeamId";
            this.TeamId2.HeaderText = "Team Id";
            this.TeamId2.MinimumWidth = 6;
            this.TeamId2.Name = "TeamId2";
            // 
            // LeagueName2
            // 
            this.LeagueName2.DataPropertyName = "LeagueName";
            this.LeagueName2.HeaderText = "League Name";
            this.LeagueName2.MinimumWidth = 6;
            this.LeagueName2.Name = "LeagueName2";
            // 
            // ExpandLeagueTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 703);
            this.Controls.Add(this.dataGridViewLeaguesExpand);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1305, 739);
            this.Name = "ExpandLeagueTableForm";
            this.Text = "Football";
            this.Load += new System.EventHandler(this.ExpandLeagueTableForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaguesExpand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPresent;
        private FontAwesome.Sharp.IconButton btnExit2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label lblSearch2;
        public System.Windows.Forms.TextBox textBoxSearch2;
        private System.Windows.Forms.Label lblLeague;
        public System.Windows.Forms.Label lblLeagueName;
        public System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Label lblCountry;
        public System.Windows.Forms.DataGridView dataGridViewLeaguesExpand;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchPlayed2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchWin2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchDraw2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchLose2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoalsScored2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoalsGet2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeagueId3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeagueName2;
    }
}