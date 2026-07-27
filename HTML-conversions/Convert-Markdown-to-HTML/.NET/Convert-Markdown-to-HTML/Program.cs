using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.IO;

namespace Convert_Markdown_to_HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open an existing Markdown file.
            using (WordDocument document = new WordDocument(Path.GetFullPath("Data/Input.md")))
            {
                //Save as a HTML document.
                document.Save(Path.GetFullPath("Output/Output.html"));
            }
        }
    }
}
