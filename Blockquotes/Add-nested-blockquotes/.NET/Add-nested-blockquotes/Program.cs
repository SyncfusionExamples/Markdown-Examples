using Syncfusion.Office.Markdown;

namespace Add_nested_blockquotes
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creates a new MarkdownDocument instance
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Adds a new paragraph
            MdParagraph blockLevel1 = markdownDocument.AddParagraph();
            // Enables blockquote for the paragraph
            blockLevel1.HasBlockquote = true;
            // Sets the blockquote level
            blockLevel1.BlockQuoteLevel = 1;
            // Adds text to the blockquote paragraph.
            blockLevel1.AddTextRange().Text = "This is the first level blockquote.";
            // Adds a level 2 blockquote (nested)
            MdParagraph blockLevel2 = markdownDocument.AddParagraph();
            // Enables blockquote for the paragraph
            blockLevel2.HasBlockquote = true;
            // Sets the blockquote level
            blockLevel2.BlockQuoteLevel = 2;
            // Adds text to the blockquote paragraph.
            blockLevel2.AddTextRange().Text = "This is the second level blockquote.";
            // Adds a level 3 blockquote (double nested)
            MdParagraph blockLevel3 = markdownDocument.AddParagraph();
            // Enables blockquote for the paragraph
            blockLevel3.HasBlockquote = true;
            // Sets the blockquote level
            blockLevel3.BlockQuoteLevel = 3;
            // Adds text to the blockquote paragraph.
            blockLevel3.AddTextRange().Text = "This is the third level blockquote.";
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}
