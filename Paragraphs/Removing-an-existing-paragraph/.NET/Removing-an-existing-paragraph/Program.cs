using Syncfusion.Office.Markdown;

namespace Removing_an_existing_paragraph
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
                // Retrieves the first paragraph of the Blocks 
                if (block is MdParagraph)
                {
                    // Removes the first paragraph from the document
                    markdownDocument.Blocks.Remove(block);
                    break;
                }
            }
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}
