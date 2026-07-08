using Syncfusion.Office.Markdown;

namespace Replacing_image
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
                    // Iterates through the inline elements of the paragraph
                    foreach (IMdInline inline in paragraph.Inlines)
                    {
                        if (inline is MdPicture picture)
                        {
                            // Replaces the image URL
                            if (picture.Url.Contains("Adventure Cycle.png"))
                            {
                                picture.Url = Path.GetFullPath("Data/Mountain-200.png");
                                break;
                            }
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