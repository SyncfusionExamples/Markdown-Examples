using Syncfusion.Office.Markdown;

namespace Open_and_save_markdown_document
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creates an empty MarkdownDocument instance
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Opens an existing Markdown document using the Open method.
            markdownDocument.Open(Path.GetFullPath("Data/Input.md"));
            // To-Do some manipulation
            // To-Do some manipulation
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document to release all memory
            markdownDocument.Dispose();
        }
    }
}
