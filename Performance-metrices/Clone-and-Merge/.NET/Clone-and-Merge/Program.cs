
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Office.Markdown;
using System;
using System.Diagnostics;


class Program
{
    static void Main()
    {
       
        Stopwatch stopwatch = Stopwatch.StartNew();
        //Opens an existing Markdown document
        using (MarkdownDocument sourceDocument = new MarkdownDocument("../../../Data/Document-100.md"))
        {
            //Creates a clone of Input Template 
            MarkdownDocument clonedDocument = sourceDocument.Clone();
            //Saves and closes the cloned document instance
            clonedDocument.Save("../../../Output/Result.md");
            //Closes the document
            clonedDocument.Dispose();
        }
        stopwatch.Stop();
        Console.WriteLine($"Time taken to clone a 100-page md file as Markdown: {stopwatch.Elapsed.TotalSeconds} seconds");
    }

}
