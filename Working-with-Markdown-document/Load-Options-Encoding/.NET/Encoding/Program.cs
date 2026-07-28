using Syncfusion.Office.Markdown;
using System.Text;

namespace Encoding_in_LoadOptions
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creates a new MarkdownDocument instance.
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Creates import settings and specifies the encoding.
            MdImportSettings mdImportSettings = new MdImportSettings();
            mdImportSettings.Encoding = Encoding.Unicode;
            // Opens an existing Markdown document with import settings.
            markdownDocument.Open("Data/Input.md", mdImportSettings);
            // Saves the Markdown document to the file system.
            markdownDocument.Save("Output/Output.md");
            // Disposes the document to release all memory.
            markdownDocument.Dispose();
        }
    }
}
