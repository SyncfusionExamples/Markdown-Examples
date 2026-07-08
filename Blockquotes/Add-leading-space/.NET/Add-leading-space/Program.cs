using Syncfusion.Office.Markdown;

namespace Add_leading_space
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creates a new Markdown document.
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Adds a new paragraph
            MdParagraph firstParagraph = markdownDocument.AddParagraph();
            // Adds text to the blockquote paragraph.
            firstParagraph.AddTextRange().Text = "First paragraph of the document";
            // Adds a new paragraph
            MdParagraph secondParagraph = markdownDocument.AddParagraph();
            // Enables blockquote for the paragraph
            secondParagraph.HasBlockquote = true;
            // Sets the blockquote level to 1
            secondParagraph.BlockQuoteLevel = 1;
            // Enables blockquote has leading space for the paragraph
            secondParagraph.BlockQuoteHasLeadingSpace = true;
            // Adds text to the blockquote paragraph.
            secondParagraph.AddTextRange().Text = "This quote shows a leading space.";
            // Adds a new paragraph
            MdParagraph thirdParagraph = markdownDocument.AddParagraph();
            // Enables blockquote for the paragraph
            thirdParagraph.HasBlockquote = true;
            // Sets the blockquote level to 1
            thirdParagraph.BlockQuoteLevel = 1;
            // Blockquote has no leading space for the paragraph - Default values as False. 
            thirdParagraph.BlockQuoteHasLeadingSpace = false;
            // Adds text to the blockquote paragraph.
            thirdParagraph.AddTextRange().Text = "This quote has no leading space.";
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}
