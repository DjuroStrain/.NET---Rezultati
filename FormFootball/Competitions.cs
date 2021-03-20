using FootballData;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace FormFootball
{
    public partial class Competitions : Form
    { 
        public Competitions()
        {
            InitializeComponent();
            MenuPanel();
            GetCountries();
            dataGridViewLeagues.Visible = false;
            dataGridViewFixtures.Visible = false;
            lblStandings.Visible = false;
            labelGames.Visible = false;
            btnExpand.Visible = false;
            lblSearch.Visible = false;
            textBoxSearch.Visible = false;
            lblSubscribe.Visible = false;
            txtMail.Visible = false;
            btnSubscribe.Visible = false;
            btnResults.Visible = false;
            btnExport.Visible = false;
        }

        private BindingSource tableBindingSource = new BindingSource();
        private BindingSource tableBindingSource2 = new BindingSource();
        private CompetitionsRepository _competitionsRepository = new CompetitionsRepository();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridViewLeagues.Columns["LeagueId2"].Visible = false;
            this.dataGridViewLeagues.Columns["TeamId"].Visible = false;
            this.dataGridViewLeagues.Columns["LeagueName"].Visible = false;
            this.dataGridViewLeagues.Columns["CountryName"].Visible = false;
            this.dataGridViewLeagues.Columns["MatchWin"].Visible = false;
            this.dataGridViewLeagues.Columns["MatchLose"].Visible = false;
            this.dataGridViewLeagues.Columns["MatchDraw"].Visible = false;
            this.dataGridViewLeagues.Columns["MatchPlayed"].Visible = false;
            this.dataGridViewLeagues.Columns["GoalsScored"].Visible = false;
            this.dataGridViewLeagues.Columns["GoalsGet"].Visible = false;
            this.dataGridViewFixtures.Columns["LeagueName2"].Visible = false;
            dataGridViewFixtures.AutoGenerateColumns = false;

            dataGridViewLeagues.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridViewLeagues.EnableHeadersVisualStyles = false;

            dataGridViewFixtures.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridViewFixtures.EnableHeadersVisualStyles = false;

            dataGridViewLeagues.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void MenuPanel()
        {
            comboBoxCountries.Visible = false;
            comboBoxLeagues.Visible = false;
            menuPanel.Visible = false;
        }

        private void hideSubMenu()
        {
            if (menuPanel.Visible == true)
            {
                menuPanel.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }

            else
            {
                subMenu.Visible = false;
            }
        }

        private void BtnCountries_Click(object sender, EventArgs e)
        {
            if(menuPanel.Visible == true)
            {
                menuPanel.Visible = false;
                comboBoxCountries.Visible = false;
                comboBoxLeagues.Visible = false;
            }
            else
            {
                menuPanel.Visible = true;
                comboBoxCountries.Visible = true;
                comboBoxLeagues.Visible = false;
            }
        }
        public static string lblCountryName;
        private void comboBoxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetLeagues();
            comboBoxLeagues.Visible = true;
            lblCountryName = comboBoxCountries.SelectedItem.ToString();
        }
        public static string LeagueId;
        private void comboBoxLeagues_SelectedIndexChanged(object sender, EventArgs e)
        {

            CompetitionInfo info = new CompetitionInfo();
            string LeagueName = comboBoxLeagues.SelectedItem.ToString();
            tableBindingSource.DataSource = _competitionsRepository.GetCompetitonsInfoShort(LeagueName);
            dataGridViewLeagues.DataSource = tableBindingSource.DataSource;

            LeagueId = comboBoxLeagues.SelectedItem.ToString();
            Fixtures fixtures = new Fixtures();
            fixtures.LeagueName = comboBoxLeagues.SelectedItem.ToString();

            LeagueName = comboBoxLeagues.SelectedItem.ToString();
            tableBindingSource2.DataSource = _competitionsRepository.GetFixtures(fixtures);
            dataGridViewFixtures.DataSource = tableBindingSource2;

            dataGridViewLeagues.Visible = true;
            dataGridViewFixtures.Visible = true;
            lblStandings.Visible = true;
            labelGames.Visible = true;
            btnExpand.Visible = true;
            panelImage.Visible = false;
            lblWelcome.Visible = false;
            lblSearch.Visible = true;
            textBoxSearch.Visible = true;
            lblSubscribe.Visible = true;
            txtMail.Visible = true;
            btnSubscribe.Visible = true;
            btnResults.Visible = true;
            btnExport.Visible = true;
        }

        private void btnExpand_Click_1(object sender, EventArgs e)
        {
            ExpandLeagueTableForm expand = new ExpandLeagueTableForm();
            expand.Show();
        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string clubName = textBoxSearch.Text;
            CompetitionInfo info = new CompetitionInfo();
            string LeagueName = Competitions.LeagueId;
            var clubs = _competitionsRepository.GetCompetitonsInfo(LeagueName);
            List<CompetitionInfo> clubNames = clubs.Where(xx => xx.clubName.ToLower().Contains(clubName.ToLower())).ToList();
            tableBindingSource.DataSource = clubNames;
            dataGridViewLeagues.DataSource = tableBindingSource;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string Mail = txtMail.Text;
            string sSmtpClient = "smtp.office365.com";
            string sUsername = "duro.belacic@vsmti.hr";
            string sPassword = "Alpha0851";
            int nPort = 587;

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient(sSmtpClient);

            mail.From = new MailAddress(sUsername);
            mail.To.Add(new MailAddress(Mail));
            mail.Subject = "Fixtures";
            mail.IsBodyHtml = true;
            SmtpServer.Port = nPort;
            SmtpServer.Credentials = new System.Net.NetworkCredential(sUsername, sPassword);
            SmtpServer.EnableSsl = true;
            string mailBody = "<table>";

            mailBody += "<td>" + "Home Team" + "</td>";
            mailBody += "<td>" + "Away Team" + "</td>";
            mailBody += "<td>" + "Date" + "</td>";
            mailBody += "<td>" + "League" + "</td>";

            foreach (DataGridViewRow row in dataGridViewFixtures.Rows)
            {
                mailBody += "<tr>";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    mailBody += "<td>" + cell.Value + "    " + "</td>";
                }
                mailBody += "<tr>";
            }
            mailBody += "</table>";
            mail.Body = mailBody;
            SmtpServer.Send(mail);

            txtMail.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CompetitionInfo info = new CompetitionInfo();
            info.LeagueName = comboBoxLeagues.SelectedItem.ToString();
            tableBindingSource.DataSource = _competitionsRepository.refreshInfo(info);
            dataGridViewLeagues.DataSource = tableBindingSource.DataSource;
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            ResultsForm resultsForm = new ResultsForm();
            resultsForm.Show();
        }

        private void ExportPdf(DataGridView dgw, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            foreach(DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }

            foreach(DataGridViewRow row in dgw.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefile = new SaveFileDialog();
            savefile.FileName = filename;
            savefile.DefaultExt = ".pdf";
            if(savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(pdfDoc, fileStream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdftable);
                    pdfDoc.Close();
                    fileStream.Close();
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportPdf(dataGridViewFixtures, "Fixtures");
        }

        private void GetCountries()
        {
            var country = _competitionsRepository.GetCompetitons();
            List<string> coun = country.Select(x => x.CountryName).ToList();

            comboBoxCountries.DisplayMember = "Name";
            comboBoxCountries.ValueMember = "Id";
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = coun;
            comboBoxCountries.DataSource = bindingSource1.DataSource;
        }

        private void GetLeagues()
        {
            var leagues = _competitionsRepository.GetCompetitons();
            List<string> leg = leagues.Where(x => x.CountryName == comboBoxCountries.SelectedItem.ToString()).Select(x => x.LeagueName).ToList();

            comboBoxLeagues.DisplayMember = "Name2";
            comboBoxLeagues.ValueMember = "Id2";
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = leg;
            comboBoxLeagues.DataSource = bindingSource.DataSource;
        }
    }
}
