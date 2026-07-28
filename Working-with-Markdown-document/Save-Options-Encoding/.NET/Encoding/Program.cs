using Syncfusion.Office.Markdown;
using System.Text;


namespace Encoding_in_SaveOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opens an existing Markdown document.
            MarkdownDocument markdownDocument = new MarkdownDocument("Data/Input.md");
            // Creates a SaveOptions instance.
            SaveOptions saveOptions = new SaveOptions();
            // Sets the encoding to use when saving the Markdown document.
            saveOptions.Encoding = Encoding.Unicode;
            // Saves the Markdown document with the specified encoding.
            markdownDocument.Save("Output/Output.md", saveOptions);
            // Disposes the document to release all memory.
            markdownDocument.Dispose();
        }
    }
}
