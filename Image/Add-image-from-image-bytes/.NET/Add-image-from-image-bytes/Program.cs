using Syncfusion.Office.Markdown;

namespace Add_image_from_image_bytes
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creates a new MarkdownDocument instance
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Adds a new paragraph to the document
            MdParagraph paragraph = markdownDocument.AddParagraph();
            // Loads image bytes from file
            byte[] imageBytes = File.ReadAllBytes(Path.GetFullPath(@"Data/Adventure Cycle.png"));
            // Creates a new picture instance
            MdPicture image = new MdPicture();
            // Adds the image to the paragraph
            paragraph.Inlines.Add(image);
            // Sets the image bytes
            image.ImageBytes = imageBytes;
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}