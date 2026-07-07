using Syncfusion.Office.Markdown;

namespace Append_line_break
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creates a new MarkdownDocument instance
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Adds a new paragraph to the document
            MdParagraph paragraph = markdownDocument.AddParagraph();
            // Adds the first text range
            MdTextRange firstText = paragraph.AddTextRange();
            firstText.Text = "A first text range is added to the paragraph";
            // Adds the text range for line break and enable the line break
            MdTextRange lineBreak = paragraph.AddTextRange();
            lineBreak.IsLineBreak = true;
            // Adds the second text range
            MdTextRange secondText = paragraph.AddTextRange();
            secondText.Text = "A second text range is added to the paragraph";
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}
