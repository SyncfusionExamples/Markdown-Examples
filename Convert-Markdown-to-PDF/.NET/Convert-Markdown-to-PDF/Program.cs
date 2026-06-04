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
            // Load an existing Markdown document into DocIO instance
            using (FileStream fileStreamPath = new FileStream(Path.GetFullPath(@"Data/Template.md"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (WordDocument document = new WordDocument(fileStreamPath, FormatType.Markdown))
                {
                    //Creates an instance of DocIORenderer.
                    using (DocIORenderer renderer = new DocIORenderer())
                    {
                        //Converts Word document into PDF document.
                        using (PdfDocument pdfDocument = renderer.ConvertToPDF(document))
                        {
                            //Saves the PDF file to file system.    
                            using (FileStream outputStream = new FileStream(Path.GetFullPath(@"Output/Result.pdf"), FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
                            {
                                pdfDocument.Save(outputStream);
                            }
                        }
                    }
                }
            }
        }
    }
}


