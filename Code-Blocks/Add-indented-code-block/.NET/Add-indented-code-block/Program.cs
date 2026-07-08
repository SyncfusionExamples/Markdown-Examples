using Syncfusion.Office.Markdown;

namespace Add_indented_code_block
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creates a new MarkdownDocument instance
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Adds a new code block to the document
            MdCodeBlock codeBlock = markdownDocument.AddCodeBlock();
            //Sets the code block as indented
            codeBlock.IsFencedCode = false;
            // Adds code lines to the code block
            codeBlock.Lines.Add("public class Person");
            codeBlock.Lines.Add("{");
            codeBlock.Lines.Add("    public string Name { get; set; }");
            codeBlock.Lines.Add("    public int Age { get; set; }");
            codeBlock.Lines.Add("}");
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}