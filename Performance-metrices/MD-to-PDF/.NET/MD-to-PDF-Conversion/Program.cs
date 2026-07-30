
using Syncfusion.DocIO.DLS;
using Syncfusion.DocIORenderer;
using Syncfusion.Pdf;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        // Open an existing Markdown file.
        using (WordDocument document = new WordDocument(Path.GetFullPath("Data/Document-50.md")))
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
        stopwatch.Stop();
        Console.WriteLine($"Time taken to save PDF document as Markdown: {stopwatch.Elapsed.TotalSeconds} seconds");
        
    }
}
