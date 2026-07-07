using Syncfusion.Office.Markdown;

namespace Remove_an_table
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Opens an existing Markdown document
            MarkdownDocument markdownDocument = new MarkdownDocument(Path.GetFullPath("Data/Input.md"));
            // Iterates through all blocks in the document
            for (int i = 0; i < markdownDocument.Blocks.Count; i++)
            {
                // Gets the current block
                IMdBlock mdBlock = markdownDocument.Blocks[i];
                // Checks if the block is a table
                if (mdBlock is MdTable)
                {
                    // Removes the table block from the document
                    markdownDocument.Blocks.Remove(mdBlock);
                    // Adjusts the loop index after removing a block
                    i--;
                }
            }
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}