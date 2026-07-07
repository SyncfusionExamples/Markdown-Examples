using Syncfusion.Office.Markdown;

namespace Modifying_an_existing_code_block
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Opens an existing Markdown document
            MarkdownDocument markdownDocument = new MarkdownDocument(Path.GetFullPath("Data/Input.md"));
            // Iterates through the blocks of the document
            foreach (IMdBlock block in markdownDocument.Blocks)
            {
                if (block is MdCodeBlock codeBlock)
                {
                    // Adds a comment at the beginning of each code block
                    codeBlock.Lines.Insert(0, "// Code modified by Markdown Library");
                    // Converts to fenced code block if it's indented
                    if (!codeBlock.IsFencedCode)
                    {
                        codeBlock.IsFencedCode = true;
                    }
                }
            }
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}