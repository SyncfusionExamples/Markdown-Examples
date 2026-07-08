using Syncfusion.Office.Markdown;

namespace Customize_save_markdown_conversion
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Opens an existing Markdown document.
            MarkdownDocument markdownDocument = new MarkdownDocument(Path.GetFullPath("Data/Input.md"));
            // Creates a SaveOptions instance to customize the save process
            SaveOptions saveOptions = new SaveOptions();
            // Hooks the ImageNodeVisited event to handle image saving
            saveOptions.ImageNodeVisited += SaveImage;
            // Saves the Markdown document to the file system with the specified save options
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"), saveOptions);
            // Unhooks the ImageNodeVisited event after saving
            saveOptions.ImageNodeVisited -= SaveImage;
            // Disposes the document to release all memory
            markdownDocument.Dispose();
        }
        private static void SaveImage(object sender, MdImageNodeVisitedEventArgs args)
        {
            string imagepath = @"D:\Temp\Image.png";
            // Save the image stream as a file.
            using (FileStream fileStreamOutput = File.Create(imagepath))
                args.ImageStream.CopyTo(fileStreamOutput);
            // Set the URI to be used for the image in the output Markdown document. 
            args.Uri = imagepath;
        }
    }
}
