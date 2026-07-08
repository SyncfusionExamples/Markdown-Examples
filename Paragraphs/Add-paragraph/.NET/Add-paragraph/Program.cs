using Syncfusion.Office.Markdown;

namespace Add_paragraph
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a new Markdown document
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Adds a new paragraph to the document
            MdParagraph paragraph = markdownDocument.AddParagraph();
            // Adds a text range to the paragraph
            paragraph.AddTextRange().Text = "Adventure Works Cycles, the fictitious company on which the AdventureWorks sample databases are based, is a large, multinational manufacturing company.";
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath(@"Output/Result.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}