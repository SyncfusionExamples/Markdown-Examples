using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;

namespace Convert_Markdown_to_Word
{
    class Program
    {
        static void Main(string[] args)
        {          
            // Load an existing Markdown document into DocIO instance
            using (FileStream fileStreamPath = new FileStream(Path.GetFullPath(@"Data/Input.md"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (WordDocument document = new WordDocument(fileStreamPath, FormatType.Markdown))
                {
                    //Creates file stream
                    using (FileStream outputFileStream = new FileStream(Path.GetFullPath(@"Output/Result.docx"), FileMode.Create, FileAccess.ReadWrite))
                    {
                        // Save the Markdown document as a Word file
                        document.Save(outputFileStream, FormatType.Docx);
                    }
                }
            }
        }
    }
}
