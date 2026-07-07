using Syncfusion.Office.Markdown;

namespace Removeing_image
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
                if (block is MdParagraph paragraph)
                {
                    // Iterates through the inline elements in reverse to safely remove items
                    for (int i = paragraph.Inlines.Count - 1; i >= 0; i--)
                    {
                        if (paragraph.Inlines[i] is MdPicture)
                        {
                            // Removes the image from the paragraph
                            paragraph.Inlines.RemoveAt(i);
                            break;
                        }
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
