using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballData;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace FormFootball
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private ResultsRepository _resultsRepository = new ResultsRepository();
        BindingSource bindingSource = new BindingSource();

        private void dataGridViewResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            Results results = new Results();
            results.LeagueName2 = Competitions.LeagueId;
            bindingSource.DataSource = _resultsRepository.GetResults(results);
            dataGridViewResults.DataSource = bindingSource;

            dataGridViewResults.AutoGenerateColumns = false;

            dataGridViewResults.Columns["LeagueName"].Visible = false;

            lblCountryName.Text = Competitions.lblCountryName;
            lblLeagueName.Text = Competitions.LeagueId;

            dataGridViewResults.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridViewResults.EnableHeadersVisualStyles = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportPdf(dataGridViewResults, "Results");
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

            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }

            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefile = new SaveFileDialog();
            savefile.FileName = filename;
            savefile.DefaultExt = ".pdf";
            if (savefile.ShowDialog() == DialogResult.OK)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
