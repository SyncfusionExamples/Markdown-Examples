using Syncfusion.Office.Markdown;

namespace Apply_text_formatting_in_bloockquote
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creates a new Markdown document.
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Adds a new paragraph to the document
            MdParagraph firstQuote = markdownDocument.AddParagraph();
            // Enables blockquote for the paragraph
            firstQuote.HasBlockquote = true;
            // Enables blockquote has leading space for the paragraph
            firstQuote.BlockQuoteHasLeadingSpace = true;
            // Sets the blockquote level to 1
            firstQuote.BlockQuoteLevel = 1;
            // Adds plain text to the blockquote paragraph.
            firstQuote.AddTextRange().Text = "This is the ";
            // Adds bold text to the blockquote paragraph.
            MdTextRange boldText = firstQuote.AddTextRange();
            boldText.Text = "first level";
            boldText.TextFormat.Bold = true;
            // Adds a new paragraph to the document
            MdParagraph secondQuote = markdownDocument.AddParagraph();
            // Enables blockquote for the paragraph
            secondQuote.HasBlockquote = true;
            // Enables blockquote has leading space for the paragraph
            secondQuote.BlockQuoteHasLeadingSpace = true;
            // Sets the blockquote level to 1
            secondQuote.BlockQuoteLevel = 1;
            // Adds plain text to the blockquote paragraph.
            secondQuote.AddTextRange().Text = "This is the ";
            // Adds italic text to the blockquote paragraph.
            MdTextRange italicText = secondQuote.AddTextRange();
            italicText.Text = "first level";
            italicText.TextFormat.Italic = true;
            // Adds a new paragraph to the document
            MdParagraph thirdQuote = markdownDocument.AddParagraph();
            // Enables blockquote for the paragraph
            thirdQuote.HasBlockquote = true;
            // Enables blockquote has leading space for the paragraph
            thirdQuote.BlockQuoteHasLeadingSpace = true;
            // Sets the blockquote level to 1
            thirdQuote.BlockQuoteLevel = 1;
            // Adds plain text to the blockquote paragraph.
            thirdQuote.AddTextRange().Text = "This is the ";
            // Adds italic text to the blockquote paragraph.
            MdTextRange codespanText = thirdQuote.AddTextRange();
            codespanText.Text = "first level";
            codespanText.TextFormat.CodeSpan = true;
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}
