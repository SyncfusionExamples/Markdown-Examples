using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocIORenderer;
using Syncfusion.Pdf;

namespace Convert_Markdown_to_PDF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open an existing Markdown file.
            using (WordDocument document = new WordDocument(Path.GetFullPath("Data/Input.md")))
            {
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
            }
        }
    }
}


