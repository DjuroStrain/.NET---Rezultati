using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballData;

namespace FormFootball
{
    public partial class PlayersForm : Form
    {
        public PlayersForm()
        {
            InitializeComponent();
            
        }
        private BindingSource bindingSource = new BindingSource();
        private CompetitionsRepository _competitionsRepository = new CompetitionsRepository();
        private void PlayersForm_Load(object sender, EventArgs e)
        {
            TeamInfo info = new TeamInfo();
            info.TeamId = ExpandLeagueTableForm.TeamId;
            bindingSource.DataSource = _competitionsRepository.GetTeamInfo(info);
            dataGridViewPlayers.DataSource = bindingSource;

            dataGridViewPlayers.Columns["TeamId3"].Visible = false;
            dataGridViewPlayers.Columns["ClubName3"].Visible = false;

            dataGridViewPlayers.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridViewPlayers.EnableHeadersVisualStyles = false;

            lblLeagueName2.Text = Competitions.LeagueId;
            lblCountryName2.Text = Competitions.lblCountryName;
            lblClubName.Text = ExpandLeagueTableForm.Club_Name;
        }

        private void btnExit3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBoxSearch3_TextChanged(object sender, EventArgs e)
        {
            string word = comboBoxSearchBy.Text;
            switch (word)
            {
                case "Name":
                    string playername = textBoxSearch3.Text;
                    TeamInfo info = new TeamInfo();
                    info.TeamId = ExpandLeagueTableForm.TeamId;
                    var clubs = _competitionsRepository.GetTeamInfo(info);
                    List<TeamInfo> clubNames = clubs.Where(xx => xx.PlayerName.ToLower().Contains(playername.ToLower())).ToList();
                    bindingSource.DataSource = clubNames;
                    break;

                case "Country":
                    string playercountry = textBoxSearch3.Text;
                    TeamInfo info2 = new TeamInfo();
                    info2.TeamId = ExpandLeagueTableForm.TeamId;
                    var country = _competitionsRepository.GetTeamInfo(info2);
                    List<TeamInfo> countrynames = country.Where(xx => xx.PlayerCountry.ToLower().Contains(playercountry.ToLower())).ToList();
                    bindingSource.DataSource = countrynames;
                    break;

                case "Position":
                    string playerposition = textBoxSearch3.Text;
                    TeamInfo info3 = new TeamInfo();
                    info3.TeamId = ExpandLeagueTableForm.TeamId;
                    var position = _competitionsRepository.GetTeamInfo(info3);
                    List<TeamInfo> lPosition = position.Where(xx => xx.PlayerPosition.ToLower().Contains(playerposition.ToLower())).ToList();
                    bindingSource.DataSource = lPosition;
                    break;
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TeamInfo teamInfo = new TeamInfo();
            teamInfo.TeamId = ExpandLeagueTableForm.TeamId;
            bindingSource.DataSource = _competitionsRepository.RefreshTeamInfo(teamInfo);
            dataGridViewPlayers.DataSource = bindingSource;
        }
    }
}
