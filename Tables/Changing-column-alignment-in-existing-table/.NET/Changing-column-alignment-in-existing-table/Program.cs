using Syncfusion.Office.Markdown;

namespace Changing_column_alignment_in_existing_table
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
                // Checks if the current block is a table
                if (block is MdTable)
                {
                    MdTable table = block as MdTable;
                    // Ensures the table has at least one row
                    if (table.Rows.Count > 0)
                    {
                        // Creates a list to store column alignments
                        List<MdColumnAlignment> alignments = new List<MdColumnAlignment>();
                        // Iterates through all cells in the first row
                        for (int i = 0; i < table.Rows[0].Cells.Count; i++)
                        {
                            // Sets each column alignment to center
                            alignments.Add(MdColumnAlignment.Center);
                        }
                        // Applies the new column alignments to the table
                        table.ColumnAlignments = alignments;
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