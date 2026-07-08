using Syncfusion.Office.Markdown;

namespace Customize_open_markdown_document
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create an Import setting instance
            MdImportSettings mdImportSettings = new MdImportSettings();
            // Hooks the ImageNodeVisited event to open the image from a specific location.
            mdImportSettings.ImageNodeVisited += ImageNodeVisited;
            // Opens an existing Markdown document with import settings using constructor.
            MarkdownDocument markdownDocument = new MarkdownDocument(Path.GetFullPath("Data/Input.md"), mdImportSettings);
            // Unhooks the ImageNodeVisited event after opening the document
            mdImportSettings.ImageNodeVisited -= ImageNodeVisited;
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document to release all memory
            markdownDocument.Dispose();
        }
        private static void ImageNodeVisited(object sender, MdImageNodeVisitedEventArgs args)
        {
            // Check if the current image URI
            if (args.Uri == "Road-550.png")
            {
                // Replace it by loading another image from local file
                args.ImageStream = new FileStream(Path.GetFullPath(@"Data/Mountain-200.png"), FileMode.Open);
            }
        }
    }
}