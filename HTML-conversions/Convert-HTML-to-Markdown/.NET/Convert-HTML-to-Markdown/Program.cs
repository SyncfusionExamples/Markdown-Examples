using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.IO;

namespace Convert_HTML_to_Markdown

{
    class Program
    {
        static void Main(string[] args)
        {
            // Open an existing HTML file.
            using (WordDocument document = new WordDocument(Path.GetFullPath("Data/Input.html")))
            {
                //Save as a Markdown document.
                document.Save(Path.GetFullPath("Output/Output.md"));
            }
        }
    }
}
