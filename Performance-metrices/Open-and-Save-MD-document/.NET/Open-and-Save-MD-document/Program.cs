
using Syncfusion.Office.Markdown;
using System.Diagnostics;



class Program
{
    static void Main()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        //Open a file as a stream.
        using (FileStream fileStreamPath = new FileStream(Path.GetFullPath(@"../../../Data/Document-100.md"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            //Load the file stream into a Markdown document.
            using (MarkdownDocument mdDocument = new MarkdownDocument(fileStreamPath))
            {
                //Create a file stream.
                using (FileStream outputFileStream = new FileStream(Path.GetFullPath(@"../../../Output/Result-100.md"), FileMode.Create, FileAccess.ReadWrite))
                {
                    //Save a Markdown file to the file stream.
                    mdDocument.Save(outputFileStream);
                    stopwatch.Stop();
                    Console.WriteLine($"Time taken to open and save a 100-page md document: {stopwatch.Elapsed.TotalSeconds} seconds");
                }
            }
        }
        
    }
}
