using Syncfusion.Office.Markdown;

namespace Apply_text_formatting
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creates a new MarkdownDocument instance
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Adds a new paragraph to the document
            MdParagraph firstParagraph = markdownDocument.AddParagraph();
            // Apply bold for the text range
            MdTextRange firstTextRange = firstParagraph.AddTextRange();
            firstTextRange.Text = "This is the first text range";
            firstTextRange.TextFormat.Bold = true;
            // Add line break
            MdTextRange lineBreak = firstParagraph.AddTextRange();
            lineBreak.IsLineBreak = true;
            // Apply strikethrough for the second text range
            MdTextRange secondTextRange = firstParagraph.AddTextRange();
            secondTextRange.Text = "This is the second text range";
            secondTextRange.TextFormat.StrikeThrough = true;
            lineBreak = firstParagraph.AddTextRange();
            lineBreak.IsLineBreak = true;
            // Apply italic for the third text range
            MdTextRange thirdTextRange = firstParagraph.AddTextRange();
            thirdTextRange.Text = "This is the third text range";
            thirdTextRange.TextFormat.Italic = true;
            // Add a Second Paragraph
            MdParagraph secondParagraph = markdownDocument.AddParagraph();
            // Add text to the second paragraph
            MdTextRange fourthTextRange = secondParagraph.AddTextRange();
            fourthTextRange.Text = "X";
            MdTextRange fifthTextRange = secondParagraph.AddTextRange();
            fifthTextRange.Text = "2";
            // Apply super script formatting for fifth text range.
            fifthTextRange.TextFormat.SubSuperScriptType = MdSubSuperScript.SuperScript;
            // Add a third Paragraph
            MdParagraph thirdParagraph = markdownDocument.AddParagraph();
            // Add text to the third Paragraph
            MdTextRange sixthTextRange = thirdParagraph.AddTextRange();
            sixthTextRange.Text = "m";
            MdTextRange seventhTextRange = thirdParagraph.AddTextRange();
            seventhTextRange.Text = "3";
            // Apply sub script formatting for seventh text range
            seventhTextRange.TextFormat.SubSuperScriptType = MdSubSuperScript.SubScript;
            // Add a fourth paragraph
            MdParagraph fourthParagraph = markdownDocument.AddParagraph();
            // Add a text to the fourth paragraph
            MdTextRange eighthTextRange = fourthParagraph.AddTextRange();
            eighthTextRange.Text = "This is the last text range";
            // Apply code span for the eight text range
            eighthTextRange.TextFormat.CodeSpan = true;
            MdTextRange ninthTextRange = fourthParagraph.AddTextRange();
            ninthTextRange.Text = "It's a hidden text range";
            ninthTextRange.TextFormat.IsHidden = true;
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}