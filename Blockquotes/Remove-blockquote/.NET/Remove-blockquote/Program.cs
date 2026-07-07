using Syncfusion.Office.Markdown;

namespace Remove_blockquote
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Opens an existing Markdown document
            MarkdownDocument markdownDocument = new MarkdownDocument(Path.GetFullPath("Data/Input.md"));
            // Iterates through the blocks of the document.
            foreach (IMdBlock block in markdownDocument.Blocks)
            {
                // Checks whether the block is a paragraph
                if (block is MdParagraph)
                {
                    MdParagraph paragraph = block as MdParagraph;
                    // Checks whether the paragraph is a blockquote
                    if (paragraph.HasBlockquote)
                    {
                        // Removes the blockquote.
                        paragraph.HasBlockquote = false;
                        paragraph.BlockQuoteLevel = 0;
                        paragraph.ApplyParagraphStyle("");
                        break;
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