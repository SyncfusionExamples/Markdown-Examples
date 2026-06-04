using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;

namespace Convert_Word_to_Markdown
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loads an existing Word document into DocIO instance. 
            using (FileStream fileStreamPath = new FileStream(Path.GetFullPath(@"Data/Input.docx"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (WordDocument document = new WordDocument(fileStreamPath, FormatType.Docx))
                {
                    //Creates file stream.
                    using (FileStream outputFileStream = new FileStream(Path.GetFullPath(@"Output/Result.md"), FileMode.Create, FileAccess.ReadWrite))
                    {
                        //Saves the Word document to file stream.
                        document.Save(outputFileStream, FormatType.Markdown);
                    }
                }
            }
        }
    }
}

