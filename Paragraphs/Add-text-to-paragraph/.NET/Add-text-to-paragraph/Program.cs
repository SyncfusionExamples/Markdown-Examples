using Syncfusion.Office.Markdown;

namespace Add_text_to_paragraph
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a new MarkdownDocument instance
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Adds a new paragraph to the document
            MdParagraph paragraph = markdownDocument.AddParagraph();
            // Adds a bold text range
            MdTextRange firstText = paragraph.AddTextRange();
            firstText.Text = "A new text is added to the paragraph";
            firstText.TextFormat.Bold = true;
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}