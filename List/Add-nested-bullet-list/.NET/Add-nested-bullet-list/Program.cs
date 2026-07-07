using Syncfusion.Office.Markdown;

namespace Add_nested_bullet_list
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
            // Sets the list level 
            paragraph.ListFormat.ListLevel = 0;
            // Sets the list marker to "- " 
            paragraph.ListFormat.ListValue = "- ";
            // Adds a text range to the paragraph
            paragraph.AddTextRange().Text = "Parent item 1";
            // Adds new paragraph to the document
            paragraph = markdownDocument.AddParagraph();
            // Initializes list formatting for the paragraph
            paragraph.ListFormat = new MdListFormat();
            // Sets the list level 
            paragraph.ListFormat.ListLevel = 1;
            // Sets the list marker to "  - " 
            paragraph.ListFormat.ListValue = "  - ";
            // Adds a text range to the paragraph
            paragraph.AddTextRange().Text = "Child item 1";
            // Adds new paragraph to the document
            paragraph = markdownDocument.AddParagraph();
            // Initializes list formatting for the paragraph
            paragraph.ListFormat = new MdListFormat();
            // Sets the list level 
            paragraph.ListFormat.ListLevel = 1;
            // Sets the list marker to "  - " 
            paragraph.ListFormat.ListValue = "  - ";
            // Adds a text range to the paragraph
            paragraph.AddTextRange().Text = "Child item 2";
            // Adds new paragraph to the document
            paragraph = markdownDocument.AddParagraph();
            // Initializes list formatting for the paragraph
            paragraph.ListFormat = new MdListFormat();
            // Sets the list level 
            paragraph.ListFormat.ListLevel = 2;
            // Sets the list marker to "    - " 
            paragraph.ListFormat.ListValue = "    - ";
            // Adds a text range to the paragraph
            paragraph.AddTextRange().Text = "Grandchild item";
            // Adds new paragraph to the document
            paragraph = markdownDocument.AddParagraph();
            // Initializes list formatting for the paragraph
            paragraph.ListFormat = new MdListFormat();
            // Sets the list level 
            paragraph.ListFormat.ListLevel = 0;
            // Sets the list marker to "- " 
            paragraph.ListFormat.ListValue = "- ";
            // Adds a text range to the paragraph
            paragraph.AddTextRange().Text = "Parent item 2";
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}