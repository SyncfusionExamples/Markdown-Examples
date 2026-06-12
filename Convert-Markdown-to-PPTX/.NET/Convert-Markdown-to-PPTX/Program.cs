using Syncfusion.Presentation;
using System.IO;

namespace Convert_PowerPoint_to_Markdown
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open an existing Markdown file.
            using (IPresentation pptxDoc = Presentation.Open(Path.GetFullPath(@"Data/Input.md")))
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


