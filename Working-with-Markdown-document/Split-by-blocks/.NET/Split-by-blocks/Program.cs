using Syncfusion.Office.Markdown;

namespace Split_by_blocks
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Opens an existing Markdown document
            MarkdownDocument sourceDocument = new MarkdownDocument(Path.GetFullPath("Data/Input.md"));
            //Processes each blocks in the Markdown document
            for (int i = 0; i < sourceDocument.Blocks.Count; i++)
            {
                //Creates new MarkdownDocument instance to add cloned section
                MarkdownDocument destinationDocument = new MarkdownDocument();
                //Clones and adds source document Blocks to the destination document
                destinationDocument.Blocks.Add((IMdBlock)sourceDocument.Blocks[i].Clone());
                //Saves and closes the document instance
                destinationDocument.Save(Path.GetFullPath("Output/Block_" + i + ".md"));
                destinationDocument.Dispose();
            }
            //Closes the source document instance
            sourceDocument.Dispose();
        }
    }
}
