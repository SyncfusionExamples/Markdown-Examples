
using System.Diagnostics;
using System.Text;
using Syncfusion.SmartDataExtractor;

class Program
{
    static void Main()
    {   
        Stopwatch stopwatch = Stopwatch.StartNew();
        //Open the input PDF file as a stream.
        using (FileStream stream = new FileStream("../../../Data/Document-50.pdf", FileMode.Open, FileAccess.Read))
        {
            //Initialize the Data Extractor.
            DataExtractor extractor = new DataExtractor();
            //Extract data as Markdown.
            string data = extractor.ExtractDataAsMarkdown(stream);
            //Save the extracted Markdown data into an output file.
            File.WriteAllText("../../../Output/Result.md", data, Encoding.UTF8);
        }
        stopwatch.Stop();
        Console.WriteLine($"Time taken to save PDF document as Markdown: {stopwatch.Elapsed.TotalSeconds} seconds");
        Console.WriteLine($"After: {GetMemoryUsageMB()} MB");
    }
}
