using Syncfusion.Office.Markdown;

namespace Add_blockquote
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creates a new MarkdownDocument instance
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Adds a new paragraph to the document
            MdParagraph paragraph = markdownDocument.AddParagraph();
            // Enables blockquote for the paragraph
            paragraph.HasBlockquote = true;
            // Sets the blockquote level to 1
            paragraph.BlockQuoteLevel = 1;
            // Adds text to the blockquote paragraph.
            paragraph.AddTextRange().Text = "This is a simple blockquote in a Markdown document.";
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}