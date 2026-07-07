using Syncfusion.Office.Markdown;

namespace Add_alternative_text
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creates a new MarkdownDocument instance
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Adds a paragraph for the chart image
            MdParagraph paragraph = markdownDocument.AddParagraph();
            // Creates a new picture instance
            MdPicture picture = new MdPicture();
            // Adds the image to the paragraph
            paragraph.Inlines.Add(picture);
            // Sets the image URL
            picture.Url = "./images/Adventure Cycle.png";
            // Sets descriptive alternative text for accessibility
            picture.AltText = "Adventure Cycle Image";
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}