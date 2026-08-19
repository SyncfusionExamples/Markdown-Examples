using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.IO;
using System.Text;

namespace Encoding_as_Markdown
{
    class Program
    {
        static void Main(string[] args)
        {
            //Open an existing HTML document.
            using (WordDocument document = new WordDocument(Path.GetFullPath(@"Data/Input.html")))
            {
                //Set the encoding values.
                document.SaveOptions.MarkdownSaveOptions.Encoding = Encoding.ASCII;
                //Save the document as a Markdown file.
                document.Save(Path.GetFullPath(@"Output/Output.md"));
            }
        }
    }
}
