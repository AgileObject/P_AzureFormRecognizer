using System;
using System.Threading.Tasks;
using Azure;
using Azure.AI.FormRecognizer.DocumentAnalysis;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Configuration;
using System.Diagnostics;

namespace AzureFormRecognizer
{
    public partial class Form1 : Form
    {
        #region declarations
        private string _SelectedFileName = string.Empty;
        private string _PDFResultName = string.Empty;
        private string lastDirectory = @"D:\"; // Standardverzeichnis

        private string _Endpoint = string.Empty;
        private string _ApiKey = string.Empty;
        #endregion

        #region constructor
        public Form1()
        {
            InitializeComponent();
            InitPictureBox();
            InitAzureFormRecognizer();
        }
        #endregion

        #region initialize
        private void InitPictureBox()
        {
            string path2InitialPicture = ConfigurationManager.AppSettings["InitPictureBox"].ToString();
            pictureBoxSelectedFile.Image = System.Drawing.Image.FromFile(path2InitialPicture, true);
        }

        private void InitAzureFormRecognizer()
        {
            try
            {
                _Endpoint = ConfigurationManager.AppSettings["AzureFormRecognizerEndpoint"].ToString();
                _ApiKey = ConfigurationManager.AppSettings["AzureFormRecognizerKey"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region program handling
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonCreateSearchablePDF_Click(object sender, EventArgs e)
        {
            var client = new DocumentAnalysisClient(new Uri(_Endpoint), new AzureKeyCredential(_ApiKey));

            string filePath = _SelectedFileName;

            using var stream = new FileStream(filePath, FileMode.Open);
            AnalyzeDocumentOperation operation = await client.AnalyzeDocumentAsync(WaitUntil.Completed, "prebuilt-read", stream);

            AnalyzeResult result = operation.Value;

            var extractedText = new System.Text.StringBuilder();
            foreach (DocumentPage page in result.Pages)
            {
                foreach (DocumentLine line in page.Lines)
                {
                    extractedText.AppendLine(line.Content);
                }
            }

            string ocrText = extractedText.ToString();

            CreateSearchablePdf(ocrText);
            checkBoxPDFIsCreated.Checked = true;
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            checkBoxPDFIsCreated.Checked = false;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = lastDirectory;
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _SelectedFileName = openFileDialog.FileName;
                    System.Drawing.Image img = null;
                    using (Bitmap bitmap = new Bitmap(_SelectedFileName))
                    {
                        img = new Bitmap(bitmap);
                    }
                    pictureBoxSelectedFile.Image = img;
                    pictureBoxSelectedFile.SizeMode = PictureBoxSizeMode.Zoom;
                    lastDirectory = System.IO.Path.GetDirectoryName(_SelectedFileName);
                }
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(_PDFResultName) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Öffnen der PDF-Datei: {ex.Message}");
            }
        }
        #endregion

        #region helpers
        private void CreateSearchablePdf(string text)
        {
            FileInfo fi = new FileInfo(_SelectedFileName);
            _PDFResultName = GetDateTimeStr() + fi.Name + ".pdf";

            // PDF mit iText7 erstellen
            using (var writer = new PdfWriter(_PDFResultName))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var document = new Document(pdf);

                    // Füge den extrahierten OCR-Text zum PDF hinzu
                    document.Add(new Paragraph(text));

                    document.Close();
                }
            }
        }

        private string GetDateTimeStr()
        {
            DateTime dateTime = DateTimeOffset.Now.DateTime;
            string timeOCRStr = dateTime.Year.ToString();
            timeOCRStr += dateTime.Month.ToString();
            timeOCRStr += dateTime.Day.ToString();
            timeOCRStr += dateTime.Hour.ToString();
            timeOCRStr += dateTime.Minute.ToString();
            timeOCRStr += dateTime.Second.ToString();

            return timeOCRStr;
        }
        #endregion
    }
}
