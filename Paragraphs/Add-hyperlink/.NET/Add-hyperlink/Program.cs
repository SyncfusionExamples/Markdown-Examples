using Syncfusion.Office.Markdown;

namespace Add_hyperlink
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creates a new MarkdownDocument instance
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Adds a new paragraph to the document
            MdParagraph firstParagraph = markdownDocument.AddParagraph();
            // Adds a hyperlink to the paragraph
            MdHyperlink hyperlink = firstParagraph.AddHyperlink();
            // Sets the display text of the hyperlink
            hyperlink.DisplayText = "Syncfusion";
            // Sets the URL of the hyperlink
            hyperlink.Url = "http://www.syncfusion.com";
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}