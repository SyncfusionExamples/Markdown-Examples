using Syncfusion.DocIO.DLS;
using System.IO;
using System.Net;

namespace Customize_image_data
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Word document.
            WordDocument document = new WordDocument();
            // Hook the event to customize the image while importing Markdown document.
            document.MdImportSettings.ImageNodeVisited += MdImportSettings_ImageNodeVisited;
            // Open the Markdown file.
            document.Open(Path.GetFullPath("Data/Input.md"));
            // Save as a HTML document.
            document.Save(Path.GetFullPath("Output/Output.html"));
            document.Close();
        }
        private static void MdImportSettings_ImageNodeVisited(object sender, Syncfusion.Office.Markdown.MdImageNodeVisitedEventArgs args)
        {
            //Set the image stream based on the image name from the input Markdown.
            if (args.Uri == "Image_1.png")
                args.ImageStream = new FileStream("Data/Image_1.png", FileMode.Open);
            else if (args.Uri == "Image_2.png")
                args.ImageStream = new FileStream("Data/Image_2.png", FileMode.Open);
            //Retrieve the image from the website and use it.
            else if (args.Uri.StartsWith("https://"))
            {
                WebClient client = new WebClient();
                //Download the image as a stream.
                byte[] image = client.DownloadData(args.Uri);
                Stream stream = new MemoryStream(image);
                //Set the retrieved image from the input Markdown.
                args.ImageStream = stream;
            }
        }
    }
}
