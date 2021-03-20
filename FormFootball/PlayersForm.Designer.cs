namespace FormFootball
{
    partial class PlayersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayersForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnExit3 = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.lblClubName = new System.Windows.Forms.Label();
            this.lblClub = new System.Windows.Forms.Label();
            this.lblCountryName2 = new System.Windows.Forms.Label();
            this.lblCountry2 = new System.Windows.Forms.Label();
            this.lblLeagueName2 = new System.Windows.Forms.Label();
            this.lblLeague2 = new System.Windows.Forms.Label();
            this.lblSearch3 = new System.Windows.Forms.Label();
            this.textBoxSearch3 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPresent = new System.Windows.Forms.Label();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.ClubName3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamId3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnExit3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 666);
            this.panel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRefresh.IconColor = System.Drawing.Color.Black;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.Location = new System.Drawing.Point(0, 574);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(256, 45);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExit3
            // 
            this.btnExit3.BackColor = System.Drawing.Color.Brown;
            this.btnExit3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit3.ForeColor = System.Drawing.Color.White;
            this.btnExit3.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExit3.IconColor = System.Drawing.Color.Black;
            this.btnExit3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit3.Location = new System.Drawing.Point(0, 619);
            this.btnExit3.Name = "btnExit3";
            this.btnExit3.Size = new System.Drawing.Size(256, 45);
            this.btnExit3.TabIndex = 5;
            this.btnExit3.Text = "Exit";
            this.btnExit3.UseVisualStyleBackColor = false;
            this.btnExit3.Click += new System.EventHandler(this.btnExit3_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::FormFootball.Properties.Resources.logo__1_;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(256, 120);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblSearchBy);
            this.panel2.Controls.Add(this.comboBoxSearchBy);
            this.panel2.Controls.Add(this.lblClubName);
            this.panel2.Controls.Add(this.lblClub);
            this.panel2.Controls.Add(this.lblCountryName2);
            this.panel2.Controls.Add(this.lblCountry2);
            this.panel2.Controls.Add(this.lblLeagueName2);
            this.panel2.Controls.Add(this.lblLeague2);
            this.panel2.Controls.Add(this.lblSearch3);
            this.panel2.Controls.Add(this.textBoxSearch3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(258, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 121);
            this.panel2.TabIndex = 1;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearchBy.ForeColor = System.Drawing.Color.White;
            this.lblSearchBy.Location = new System.Drawing.Point(296, 22);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(90, 21);
            this.lblSearchBy.TabIndex = 18;
            this.lblSearchBy.Text = "Search by";
            this.lblSearchBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "Name",
            "Country",
            "Position"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(392, 23);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(259, 21);
            this.comboBoxSearchBy.TabIndex = 17;
            // 
            // lblClubName
            // 
            this.lblClubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblClubName.ForeColor = System.Drawing.Color.White;
            this.lblClubName.Location = new System.Drawing.Point(92, 78);
            this.lblClubName.Name = "lblClubName";
            this.lblClubName.Size = new System.Drawing.Size(100, 23);
            this.lblClubName.TabIndex = 16;
            this.lblClubName.Text = "label2";
            this.lblClubName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblClub
            // 
            this.lblClub.BackColor = System.Drawing.Color.DarkRed;
            this.lblClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblClub.ForeColor = System.Drawing.Color.Yellow;
            this.lblClub.Location = new System.Drawing.Point(5, 76);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(81, 23);
            this.lblClub.TabIndex = 15;
            this.lblClub.Text = "Club:";
            this.lblClub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountryName2
            // 
            this.lblCountryName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCountryName2.ForeColor = System.Drawing.Color.White;
            this.lblCountryName2.Location = new System.Drawing.Point(92, 10);
            this.lblCountryName2.Name = "lblCountryName2";
            this.lblCountryName2.Size = new System.Drawing.Size(100, 23);
            this.lblCountryName2.TabIndex = 14;
            this.lblCountryName2.Text = "label2";
            this.lblCountryName2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblCountry2
            // 
            this.lblCountry2.BackColor = System.Drawing.Color.DarkRed;
            this.lblCountry2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCountry2.ForeColor = System.Drawing.Color.Yellow;
            this.lblCountry2.Location = new System.Drawing.Point(5, 8);
            this.lblCountry2.Name = "lblCountry2";
            this.lblCountry2.Size = new System.Drawing.Size(81, 23);
            this.lblCountry2.TabIndex = 13;
            this.lblCountry2.Text = "Country:";
            this.lblCountry2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeagueName2
            // 
            this.lblLeagueName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLeagueName2.ForeColor = System.Drawing.Color.White;
            this.lblLeagueName2.Location = new System.Drawing.Point(92, 44);
            this.lblLeagueName2.Name = "lblLeagueName2";
            this.lblLeagueName2.Size = new System.Drawing.Size(100, 23);
            this.lblLeagueName2.TabIndex = 12;
            this.lblLeagueName2.Text = "label2";
            this.lblLeagueName2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblLeague2
            // 
            this.lblLeague2.BackColor = System.Drawing.Color.DarkRed;
            this.lblLeague2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLeague2.ForeColor = System.Drawing.Color.Yellow;
            this.lblLeague2.Location = new System.Drawing.Point(5, 42);
            this.lblLeague2.Name = "lblLeague2";
            this.lblLeague2.Size = new System.Drawing.Size(81, 23);
            this.lblLeague2.TabIndex = 11;
            this.lblLeague2.Text = "League:";
            this.lblLeague2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSearch3
            // 
            this.lblSearch3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSearch3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearch3.ForeColor = System.Drawing.Color.White;
            this.lblSearch3.Location = new System.Drawing.Point(296, 50);
            this.lblSearch3.Name = "lblSearch3";
            this.lblSearch3.Size = new System.Drawing.Size(90, 21);
            this.lblSearch3.TabIndex = 8;
            this.lblSearch3.Text = "Search";
            this.lblSearch3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSearch3
            // 
            this.textBoxSearch3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSearch3.Location = new System.Drawing.Point(392, 50);
            this.textBoxSearch3.Name = "textBoxSearch3";
            this.textBoxSearch3.Size = new System.Drawing.Size(259, 20);
            this.textBoxSearch3.TabIndex = 7;
            this.textBoxSearch3.TextChanged += new System.EventHandler(this.textBoxSearch3_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblPresent);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(258, 566);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(826, 100);
            this.panel3.TabIndex = 2;
            // 
            // lblPresent
            // 
            this.lblPresent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPresent.BackColor = System.Drawing.Color.Black;
            this.lblPresent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPresent.ForeColor = System.Drawing.Color.White;
            this.lblPresent.Location = new System.Drawing.Point(173, 28);
            this.lblPresent.Name = "lblPresent";
            this.lblPresent.Size = new System.Drawing.Size(478, 41);
            this.lblPresent.TabIndex = 2;
            this.lblPresent.Text = "Presented to you by: VSMTI SPORT";
            this.lblPresent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.AllowUserToAddRows = false;
            this.dataGridViewPlayers.AllowUserToDeleteRows = false;
            this.dataGridViewPlayers.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridViewPlayers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPlayers.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClubName3,
            this.TeamId3,
            this.PlayerName,
            this.PlayerNumber,
            this.PlayerCountry,
            this.PlayerPosition,
            this.PlayerAge});
            this.dataGridViewPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPlayers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPlayers.GridColor = System.Drawing.Color.Black;
            this.dataGridViewPlayers.Location = new System.Drawing.Point(258, 121);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.RowHeadersVisible = false;
            this.dataGridViewPlayers.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewPlayers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPlayers.Size = new System.Drawing.Size(826, 445);
            this.dataGridViewPlayers.TabIndex = 3;
            // 
            // ClubName3
            // 
            this.ClubName3.DataPropertyName = "ClubName";
            this.ClubName3.HeaderText = "Club name";
            this.ClubName3.MinimumWidth = 6;
            this.ClubName3.Name = "ClubName3";
            // 
            // TeamId3
            // 
            this.TeamId3.DataPropertyName = "TeamId";
            this.TeamId3.HeaderText = "Team id";
            this.TeamId3.MinimumWidth = 6;
            this.TeamId3.Name = "TeamId3";
            // 
            // PlayerName
            // 
            this.PlayerName.DataPropertyName = "PlayerName";
            this.PlayerName.HeaderText = "Player name";
            this.PlayerName.MinimumWidth = 6;
            this.PlayerName.Name = "PlayerName";
            // 
            // PlayerNumber
            // 
            this.PlayerNumber.DataPropertyName = "PlayerNumber";
            this.PlayerNumber.HeaderText = "Player number";
            this.PlayerNumber.MinimumWidth = 6;
            this.PlayerNumber.Name = "PlayerNumber";
            // 
            // PlayerCountry
            // 
            this.PlayerCountry.DataPropertyName = "PlayerCountry";
            this.PlayerCountry.HeaderText = "Player country";
            this.PlayerCountry.MinimumWidth = 6;
            this.PlayerCountry.Name = "PlayerCountry";
            // 
            // PlayerPosition
            // 
            this.PlayerPosition.DataPropertyName = "PlayerPosition";
            this.PlayerPosition.HeaderText = "Position";
            this.PlayerPosition.MinimumWidth = 6;
            this.PlayerPosition.Name = "PlayerPosition";
            // 
            // PlayerAge
            // 
            this.PlayerAge.DataPropertyName = "PlayerAge";
            this.PlayerAge.HeaderText = "Age";
            this.PlayerAge.MinimumWidth = 6;
            this.PlayerAge.Name = "PlayerAge";
            // 
            // PlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 666);
            this.Controls.Add(this.dataGridViewPlayers);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayersForm";
            this.Text = "Football";
            this.Load += new System.EventHandler(this.PlayersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnExit3;
        public System.Windows.Forms.DataGridView dataGridViewPlayers;
        private System.Windows.Forms.Label lblPresent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClubName3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamId3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerAge;
        public System.Windows.Forms.Label lblSearch3;
        public System.Windows.Forms.TextBox textBoxSearch3;
        public System.Windows.Forms.Label lblClubName;
        private System.Windows.Forms.Label lblClub;
        public System.Windows.Forms.Label lblCountryName2;
        private System.Windows.Forms.Label lblCountry2;
        public System.Windows.Forms.Label lblLeagueName2;
        private System.Windows.Forms.Label lblLeague2;
        public System.Windows.Forms.ComboBox comboBoxSearchBy;
        public System.Windows.Forms.Label lblSearchBy;
        private FontAwesome.Sharp.IconButton btnRefresh;
    }
}