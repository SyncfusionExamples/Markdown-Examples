using Syncfusion.Office.Markdown;

namespace Apply_formatting_for_hyperlink_display_text
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creates a new MarkdownDocument instance
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Adds a new paragraph to the document
            MdParagraph firstParagraph = markdownDocument.AddParagraph();
            MdHyperlink boldHyperlink = firstParagraph.AddHyperlink();
            boldHyperlink.DisplayText = "**Syncfusion**";
            boldHyperlink.Url = "http://www.syncfusion.com";
            // Adds a new paragraph to the document
            MdParagraph secondParagraph = markdownDocument.AddParagraph();
            MdHyperlink italicHyperlink = secondParagraph.AddHyperlink();
            italicHyperlink.DisplayText = "*Syncfusion*";
            italicHyperlink.Url = "http://www.syncfusion.com";
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}
