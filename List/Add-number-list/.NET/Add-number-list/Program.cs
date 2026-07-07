using Syncfusion.Office.Markdown;

namespace Add_number_list
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
            // Enables numbered list formatting
            paragraph.ListFormat.IsNumbered = true;
            // Sets the list marker to "1. "
            paragraph.ListFormat.ListValue = "1. ";
            // Adds a text range to the paragraph
            paragraph.AddTextRange().Text = "First item";
            // Adds new paragraph to the document
            paragraph = markdownDocument.AddParagraph();
            // Initializes list formatting for the paragraph
            paragraph.ListFormat = new MdListFormat();
            // Enables numbered list formatting
            paragraph.ListFormat.IsNumbered = true;
            // Sets the list marker to "2. "
            paragraph.ListFormat.ListValue = "2. ";
            // Adds a text range to the paragraph
            paragraph.AddTextRange().Text = "Second item";
            // Adds new paragraph to the document
            paragraph = markdownDocument.AddParagraph();
            // Initializes list formatting for the paragraph
            paragraph.ListFormat = new MdListFormat();
            // Enables numbered list formatting
            paragraph.ListFormat.IsNumbered = true;
            // Sets the list marker to "3. "
            paragraph.ListFormat.ListValue = "3. ";
            // Adds a text range to the paragraph
            paragraph.AddTextRange().Text = "Third item";
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}