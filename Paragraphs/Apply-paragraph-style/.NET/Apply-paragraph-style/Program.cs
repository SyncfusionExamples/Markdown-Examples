using Syncfusion.Office.Markdown;

namespace Apply_paragraph_style
{
    class Program
    {
        static void Main(string[] args)
        {       
            // Creates a new MarkdownDocument instance
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Adds a paragraph and applies the Heading 1 style
            MdParagraph heading1 = markdownDocument.AddParagraph();
            heading1.ApplyParagraphStyle("Heading 1");
            heading1.AddTextRange().Text = "Heading 1";
            // Adds a paragraph and applies the Heading 2 style
            MdParagraph heading2 = markdownDocument.AddParagraph();
            heading2.ApplyParagraphStyle("Heading 2");
            heading2.AddTextRange().Text = "Heading 2";
            // Adds a paragraph and applies the Heading 3 style
            MdParagraph heading3 = markdownDocument.AddParagraph();
            heading3.ApplyParagraphStyle("Heading 3");
            heading3.AddTextRange().Text = "Heading 3";
            // Adds a paragraph and applies the Heading 4 style
            MdParagraph heading4 = markdownDocument.AddParagraph();
            heading4.ApplyParagraphStyle("Heading 4");
            heading4.AddTextRange().Text = "Heading 4";
            // Adds a paragraph and applies the Heading 5 style
            MdParagraph heading5 = markdownDocument.AddParagraph();
            heading5.ApplyParagraphStyle("Heading 5");
            heading5.AddTextRange().Text = "Heading 5";
            // Adds a paragraph and applies the Heading 6 style
            MdParagraph heading6 = markdownDocument.AddParagraph();
            heading6.ApplyParagraphStyle("Heading 6");
            heading6.AddTextRange().Text = "Heading 6";
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}