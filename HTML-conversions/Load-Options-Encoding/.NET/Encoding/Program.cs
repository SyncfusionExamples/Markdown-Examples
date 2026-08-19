using Syncfusion.DocIO.DLS;
using System.IO;
using System.Text;

namespace Encoding
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Word document.
            WordDocument document = new WordDocument();
            // Set the encoding for the Markdown file.
            document.MdImportSettings.Encoding = Encoding.UTF8;
            // Open the Markdown file.
            document.Open(Path.GetFullPath("Data/Input.md"));
            // Save as a HTML document.
            document.Save(Path.GetFullPath("Output/Output.html"));
            document.Close();
        }
    }
}
