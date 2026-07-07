using Syncfusion.Office.Markdown;

namespace Add_an_table
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creates a new MarkdownDocument instance
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Adds a new table to the document
            MdTable table = markdownDocument.AddTable();
            // Adds header row to the table
            MdTableRow headerRow = table.AddTableRow();
            headerRow.AddTableCell().Items.Add(new MdTextRange { Text = "Product" });
            // Sets column alignments (left, center, right)
            table.ColumnAlignments.Add(MdColumnAlignment.Left);
            headerRow.AddTableCell().Items.Add(new MdTextRange { Text = "Price" });
            // Sets column alignments (left, center, right)
            table.ColumnAlignments.Add(MdColumnAlignment.Left);
            headerRow.AddTableCell().Items.Add(new MdTextRange { Text = "Stock" });
            // Sets column alignments (left, center, right)
            table.ColumnAlignments.Add(MdColumnAlignment.Left);
            // Defines data for multiple rows
            string[][] data = {
                 new[] { "Widget", "$10", "50" },
                 new[] { "Gadget", "$20", "30" },
                 new[] { "Tool", "$15", "40" }
             };
            // Adds data rows to the table
            foreach (string[] rowData in data)
            {
                // Creates a new data row
                MdTableRow dataRow = table.AddTableRow();
                foreach (string value in rowData)
                {
                    // Adds each cell value to the row
                    dataRow.AddTableCell().Items.Add(new MdTextRange { Text = value });
                }
            }
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}