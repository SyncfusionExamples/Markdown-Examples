using Syncfusion.Office.Markdown;

namespace Add_bullet_list
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creates a new MarkdownDocument instance
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Adds new paragraph to the document
            MdParagraph paragraph = markdownDocument.AddParagraph();
            // Initializes list formatting for the paragraph
            paragraph.ListFormat = new MdListFormat();
            // Sets the list marker to "- " 
            paragraph.ListFormat.ListValue = "- ";
            // Adds a text range to the paragraph
            paragraph.AddTextRange().Text = "First item";
            // Adds new paragraph to the document
            paragraph = markdownDocument.AddParagraph();
            // Initializes list formatting for the paragraph
            paragraph.ListFormat = new MdListFormat();
            // Sets the list marker to "- " 
            paragraph.ListFormat.ListValue = "- ";
            // Adds a text range to the paragraph
            paragraph.AddTextRange().Text = "Second item";
            // Adds new paragraph to the document
            paragraph = markdownDocument.AddParagraph();
            // Initializes list formatting for the paragraph
            paragraph.ListFormat = new MdListFormat();
            // Sets the list marker to "- " 
            paragraph.ListFormat.ListValue = "- ";
            // Adds a text range to the paragraph
            paragraph.AddTextRange().Text = "Third item";
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}