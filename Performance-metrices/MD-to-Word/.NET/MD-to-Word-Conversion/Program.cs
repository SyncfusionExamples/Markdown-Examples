
using System.Diagnostics;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;


class Program
{
    static void Main()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        //Open a file as a stream.
        using (FileStream fileStreamPath = new FileStream(Path.GetFullPath(@"../../../Data/Document-100.md"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            //Load the file stream into a Markdown document.
            using (WordDocument document = new WordDocument(fileStreamPath, FormatType.Markdown))
            {
                //Create a file stream.
                using (FileStream outputFileStream = new FileStream(Path.GetFullPath(@"../../../Output/Result.docx"), FileMode.Create, FileAccess.ReadWrite))
                {
                    //Save a Word document to the file stream.
                    document.Save(outputFileStream, FormatType.Docx);
                    stopwatch.Stop();
                    Console.WriteLine($"Time taken to open and save a 100-page document as Markdown: {stopwatch.Elapsed.TotalSeconds} seconds");
                }
            }
        }
        
    }
}
