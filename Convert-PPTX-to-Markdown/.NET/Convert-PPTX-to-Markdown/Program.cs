using Syncfusion.Presentation;
using System.IO;

namespace Convert_PowerPoint_to_Markdown
{
    class Program
    {
        static void Main(string[] args)
        {       
            //Open an existing presentation.
            using (FileStream inputStream = new(Path.GetFullPath(@"Data/Template.pptx"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                //Load the file stream into a Markdown file.
                using (IPresentation presentation = Presentation.Open(inputStream))
                {
                    //Save as a PPTX document into the Markdown FileStream.
                    using (FileStream outputStream = new FileStream("PPTXtoMd.md", FileMode.Create, FileAccess.ReadWrite))
                    {
                        presentation.Save(outputStream);
                    }
                }
            }
        }
    }
}

