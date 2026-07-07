using Syncfusion.Office.Markdown;

namespace Add_thematic_break
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creates a new MarkdownDocument instance
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Adds a new paragraph to the document
            MdParagraph firstParagraph = markdownDocument.AddParagraph();
            firstParagraph.AddTextRange().Text = "This is the first section content.";
            // Adds a thematic break to the document
            MdThematicBreak thematicBreak = markdownDocument.AddThematicBreak();
            // Adds another paragraph after the thematic break
            MdParagraph secondParagraph = markdownDocument.AddParagraph();
            secondParagraph.AddTextRange().Text = "This is the second section content.";
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}
