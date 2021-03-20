namespace FormFootball
{
    partial class ResultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExport = new FontAwesome.Sharp.IconButton();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblLeagueName = new System.Windows.Forms.Label();
            this.lblLeague = new System.Windows.Forms.Label();
            this.lblSearch2 = new System.Windows.Forms.Label();
            this.textBoxSearch2 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPresent = new System.Windows.Forms.Label();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.HomeTeam2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeTeamGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AwayTeam2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AwayTeamGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeagueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
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
            this.btnExit.Location = new System.Drawing.Point(0, 656);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(257, 45);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 703);
            this.panel1.TabIndex = 1;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnExport);
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
            this.panel3.TabIndex = 8;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExport.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExport.IconColor = System.Drawing.Color.Black;
            this.btnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExport.Location = new System.Drawing.Point(884, 83);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(145, 34);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            this.panel4.TabIndex = 9;
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
            // dataGridViewResults
            // 
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridViewResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResults.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HomeTeam2,
            this.HomeTeamGoals,
            this.AwayTeam2,
            this.AwayTeamGoals,
            this.Date2,
            this.LeagueName});
            this.dataGridViewResults.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResults.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResults.GridColor = System.Drawing.Color.Black;
            this.dataGridViewResults.Location = new System.Drawing.Point(259, 120);
            this.dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewResults.RowHeadersVisible = false;
            this.dataGridViewResults.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResults.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewResults.Size = new System.Drawing.Size(1030, 483);
            this.dataGridViewResults.TabIndex = 10;
            // 
            // HomeTeam2
            // 
            this.HomeTeam2.DataPropertyName = "HomeTeam2";
            this.HomeTeam2.HeaderText = "Home Team";
            this.HomeTeam2.Name = "HomeTeam2";
            // 
            // HomeTeamGoals
            // 
            this.HomeTeamGoals.DataPropertyName = "HomeTeamGoals";
            this.HomeTeamGoals.HeaderText = "Home Team Score";
            this.HomeTeamGoals.Name = "HomeTeamGoals";
            // 
            // AwayTeam2
            // 
            this.AwayTeam2.DataPropertyName = "AwayTeam2";
            this.AwayTeam2.HeaderText = "Away Team";
            this.AwayTeam2.Name = "AwayTeam2";
            // 
            // AwayTeamGoals
            // 
            this.AwayTeamGoals.DataPropertyName = "AwayTeamGoals";
            this.AwayTeamGoals.HeaderText = "Away Team Score";
            this.AwayTeamGoals.Name = "AwayTeamGoals";
            // 
            // Date2
            // 
            this.Date2.DataPropertyName = "Date2";
            this.Date2.HeaderText = "Date";
            this.Date2.Name = "Date2";
            // 
            // LeagueName
            // 
            this.LeagueName.DataPropertyName = "LeagueName2";
            this.LeagueName.HeaderText = "League name";
            this.LeagueName.Name = "LeagueName";
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 703);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultsForm";
            this.Text = "Football";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Label lblCountry;
        public System.Windows.Forms.Label lblLeagueName;
        private System.Windows.Forms.Label lblLeague;
        public System.Windows.Forms.Label lblSearch2;
        public System.Windows.Forms.TextBox textBoxSearch2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPresent;
        public System.Windows.Forms.DataGridView dataGridViewResults;
        private FontAwesome.Sharp.IconButton btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeTeam2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeTeamGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwayTeam2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwayTeamGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeagueName;
    }
}