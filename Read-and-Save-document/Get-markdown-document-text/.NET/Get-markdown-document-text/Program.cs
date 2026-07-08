using Syncfusion.Office.Markdown;

namespace Get_markdown_document_text
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Opens an existing Markdown document.
            MarkdownDocument markdownDocument = new MarkdownDocument(Path.GetFullPath("Data/Input.md"));
            // To-Do some manipulation
            // To-Do some manipulation
            // Retrieves the Markdown document content as text.
            string mdContent = markdownDocument.GetMarkdownText();
            // Print the markdown document content
            Console.WriteLine(mdContent);
            // Disposes the document to release all memory
            markdownDocument.Dispose();
        }
    }
}