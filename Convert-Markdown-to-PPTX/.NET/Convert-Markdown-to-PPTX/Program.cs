using Syncfusion.Presentation;
using System.IO;

namespace Convert_Markdown_to_PowerPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open an existing Markdown file.
            using (IPresentation pptxDoc = Presentation.Open(Path.GetFullPath(@"Data/Template.md")))
            {
                // Write memory stream to output file
                using (FileStream outputFileStream = new FileStream(Path.GetFullPath(@"Output/Result.PPTX"), FileMode.Create, FileAccess.Write))
                {
                    pptxDoc.Save(outputFileStream);
                }
            }
        }
    }
}


