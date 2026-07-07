using Syncfusion.Office.Markdown;

namespace Add_blockquote_using_paragraphstyle
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creates a new Markdown document.
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Adds a new paragraph
            MdParagraph paragraph = markdownDocument.AddParagraph();
            // Applies the Quote paragraph style
            paragraph.ApplyParagraphStyle("Quote");
            // Adds text to the blockquote paragraph.
            paragraph.AddTextRange().Text = "This blockquote is created using paragraph style.";
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}