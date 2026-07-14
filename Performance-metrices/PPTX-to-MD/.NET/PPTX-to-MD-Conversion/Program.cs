
using System.Diagnostics;
using Syncfusion.Presentation;


class Program
{
    static void Main()
    {   
        Stopwatch stopwatch = Stopwatch.StartNew();
        //Open a file as a stream.
        using (FileStream fileStreamPath = new FileStream(Path.GetFullPath(@"../../../Data/Input.pptx"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            //Load the file stream into a PowerPoint presentation.
            using (IPresentation presentation = Presentation.Open(fileStreamPath))
            {
                //Create a file stream.
                using (FileStream outputFileStream = new FileStream(Path.GetFullPath(@"../../../Output/Result.md"), FileMode.Create, FileAccess.ReadWrite))
                {
                    //Save a MD file to the file stream.
                    presentation.Save(outputFileStream, FormatType.Markdown);
                    stopwatch.Stop();
                    Console.WriteLine($"Time taken to open and save a 100-slide PowerPoint presentation as Markdown: {stopwatch.Elapsed.TotalSeconds} seconds");
                }
            }
        }
    }
}
