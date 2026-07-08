using Syncfusion.Office.Markdown;

namespace Add_nested_number_list
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
            // Sets the list level to 0
            paragraph.ListFormat.ListLevel = 0;
            // Sets the list marker to "1. "
            paragraph.ListFormat.ListValue = "1. ";
            // Adds a text range to the paragraph
            paragraph.AddTextRange().Text = "Main topic 1";
            // Adds new paragraph to the document
            paragraph = markdownDocument.AddParagraph();
            // Initializes list formatting for the paragraph
            paragraph.ListFormat = new MdListFormat();
            // Enables numbered list formatting
            paragraph.ListFormat.IsNumbered = true;
            // Sets the list level to 1
            paragraph.ListFormat.ListLevel = 1;
            // Sets the list marker to "  1. "
            paragraph.ListFormat.ListValue = "  1. ";
            // Adds a text range to the paragraph
            paragraph.AddTextRange().Text = "Subtopic 1.1";
            // Adds new paragraph to the document
            paragraph = markdownDocument.AddParagraph();
            // Initializes list formatting for the paragraph
            paragraph.ListFormat = new MdListFormat();
            // Enables numbered list formatting
            paragraph.ListFormat.IsNumbered = true;
            // Sets the list level to 1
            paragraph.ListFormat.ListLevel = 1;
            // Sets the list marker to "  2. "
            paragraph.ListFormat.ListValue = "  2. ";
            paragraph.AddTextRange().Text = "Subtopic 1.2";
            // Adds new paragraph to the document
            paragraph = markdownDocument.AddParagraph();
            // Initializes list formatting for the paragraph
            paragraph.ListFormat = new MdListFormat();
            // Enables numbered list formatting
            paragraph.ListFormat.IsNumbered = true;
            // Sets the list level to 2
            paragraph.ListFormat.ListLevel = 2;
            // Sets the list marker to "    1. "
            paragraph.ListFormat.ListValue = "    1. ";
            // Adds a text range to the paragraph
            paragraph.AddTextRange().Text = "Detail 1.2.1";
            // Adds new paragraph to the document
            paragraph = markdownDocument.AddParagraph();
            // Initializes list formatting for the paragraph
            paragraph.ListFormat = new MdListFormat();
            // Enables numbered list formatting
            paragraph.ListFormat.IsNumbered = true;
            // Sets the list level to 0
            paragraph.ListFormat.ListLevel = 0;
            // Sets the list marker to "2. "
            paragraph.ListFormat.ListValue = "2. ";
            // Adds a text range to the paragraph
            paragraph.AddTextRange().Text = "Main topic 2";
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}
