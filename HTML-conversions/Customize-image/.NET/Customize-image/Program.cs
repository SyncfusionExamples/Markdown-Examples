using Syncfusion.DocIO.DLS;
using Syncfusion.Office.Markdown;
using System.IO;

namespace Customize_image
{
    class Program
    {
        static void Main(string[] args)
        {
            //Open an existing HTML document.
            using (WordDocument document = new WordDocument(Path.GetFullPath(@"../../../Data/Input.html")))
            {
                //Hook the event to customize the image. 
                document.SaveOptions.MarkdownSaveOptions.ImageNodeVisited += SaveImage;
                //Save the document as a Markdown file.
                document.Save(Path.GetFullPath(@"../../../Output/Output.md"));
            }
        }
        static void SaveImage(object sender, MdImageNodeVisitedEventArgs args)
        {
            string imagepath = @"../../../Output/Image.png";
            //Save the image stream as a file.
            using (FileStream fileStreamOutput = File.Create(imagepath))
                args.ImageStream.CopyTo(fileStreamOutput);
            //Set the URI to be used for the image in the output Markdown. 
            args.Uri = imagepath;
        }
    }
}