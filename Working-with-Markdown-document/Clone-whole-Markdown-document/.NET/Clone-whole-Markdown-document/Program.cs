using Syncfusion.Office.Markdown;

namespace Clone_whole_markdown_document
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Opens an existing Markdown document
            using (MarkdownDocument sourceDocument = new MarkdownDocument(Path.GetFullPath("Data/Input.md")))
            {
                //Creates a clone of Input Template 
                MarkdownDocument clonedDocument = sourceDocument.Clone();
                //Saves and closes the cloned document instance
                clonedDocument.Save(Path.GetFullPath("Output/Output.md"));
                //Closes the document
                clonedDocument.Dispose();
            }
        }
    }
}