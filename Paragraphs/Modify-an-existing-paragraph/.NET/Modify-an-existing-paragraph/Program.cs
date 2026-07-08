using Syncfusion.Office.Markdown;

namespace Modify_an_existing_paragraph
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opens an existing Markdown document
            MarkdownDocument markdownDocument = new MarkdownDocument(Path.GetFullPath("Data/Input.md"));
            // Iterates through the blocks of the document
            foreach (IMdBlock block in markdownDocument.Blocks)
            {
                if (block is MdParagraph)
                {
                    MdParagraph paragraph = block as MdParagraph;
                    // Iterates through the inline elements of the paragraph
                    foreach (IMdInline inline in paragraph.Inlines)
                    {
                        if (inline is MdTextRange)
                        {
                            MdTextRange textRange = inline as MdTextRange;
                            // Modifies the text content
                            textRange.Text = "Modified paragraph content.";
                            break;
                        }
                    }
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