using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocIORenderer;
using Syncfusion.Pdf;
using System.IO;
using System.Text;

namespace Encoding_As_PDF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Word document.
            WordDocument document = new WordDocument();
            // Set the encoding for the Markdown file.
            document.MdImportSettings.Encoding = Encoding.UTF8;
            // Open the Markdown file.
            document.Open(Path.GetFullPath("Data/Input.md"));
            // Create an instance of DocIORenderer.
            using (DocIORenderer renderer = new DocIORenderer())
            {
                // Convert Markdown to PDF.
                using (PdfDocument pdfDocument = renderer.ConvertToPDF(document))
                {
                    // Save the PDF document.
                    using (FileStream outputStream = new FileStream(Path.GetFullPath("Output/Output.pdf"), FileMode.Create, FileAccess.Write))
                    {
                        pdfDocument.Save(outputStream);
                    }
                }
            }
            document.Close();
        }
    }
}
