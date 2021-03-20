using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballData;

namespace FormFootball
{
    public partial class ExpandLeagueTableForm : Form
    {
        public ExpandLeagueTableForm()
        {
            InitializeComponent();

        }
        private BindingSource bindingSource = new BindingSource();
        private CompetitionsRepository _competitionsRepository = new CompetitionsRepository();
        private void ExpandLeagueTableForm_Load(object sender, EventArgs e)
        {
            this.dataGridViewLeaguesExpand.Columns["LeagueId3"].Visible = false;
            this.dataGridViewLeaguesExpand.Columns["TeamId2"].Visible = false;
            this.dataGridViewLeaguesExpand.Columns["LeagueName2"].Visible = false;
            this.dataGridViewLeaguesExpand.Columns["CountryName2"].Visible = false;



            CompetitionInfo info = new CompetitionInfo();
            string LeagueName = Competitions.LeagueId;
            bindingSource.DataSource = _competitionsRepository.GetCompetitonsInfo(LeagueName);
            dataGridViewLeaguesExpand.DataSource = bindingSource;

            dataGridViewLeaguesExpand.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridViewLeaguesExpand.EnableHeadersVisualStyles = false;

            DataGridViewImageColumn Button = new DataGridViewImageColumn();

            Button.Image = Image.FromFile(@"C:\Users\38599\Documents\Morningstar\Faks\2. godina\.NET\FootballData\seemore.png");    
            Button.Width = 20;
            Button.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Button.Name = "See more";
            dataGridViewLeaguesExpand.Columns.Add(Button);
            dataGridViewLeaguesExpand.AutoGenerateColumns = false;

            lblLeagueName.Text = Competitions.LeagueId;
            lblCountryName.Text = Competitions.lblCountryName;
        }
        private void btnExit2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBoxSearch2_TextChanged_1(object sender, EventArgs e)
        {
            string clubName = textBoxSearch2.Text;
            CompetitionInfo competitionInfo = new CompetitionInfo();
            string LeagueName = Competitions.LeagueId;
            var clubs = _competitionsRepository.GetCompetitonsInfo(LeagueName);
            List<CompetitionInfo> clubNames = clubs.Where(xx => xx.clubName.ToLower().Contains(clubName.ToLower())).ToList();
            bindingSource.DataSource = clubNames;
            dataGridViewLeaguesExpand.DataSource = bindingSource;
        }
        public static string TeamId;
        public static string Club_Name;
        private void dataGridViewLeaguesExpand_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewLeaguesExpand.Rows[e.RowIndex].Selected = true;
            if (dataGridViewLeaguesExpand.CurrentCell.ColumnIndex.Equals(13) && e.RowIndex != -1)
            {
                PlayersForm playersForm = new PlayersForm();
                TeamId = dataGridViewLeaguesExpand.Rows[e.RowIndex].Cells[1].Value.ToString();
                Club_Name = dataGridViewLeaguesExpand.Rows[e.RowIndex].Cells[0].Value.ToString();
                playersForm.Show();

            }
        }
    }

    
    
}
