# Convert Markdown to PDF Document using C#

The Syncfusion&reg; [.NET Word Library](https://www.syncfusion.com/document-processing/word-framework/net/word-library) (DocIO) enables you to create, read, edit, and convert Word documents programmatically without Microsoft Word or interop dependencies.Using this library, you can **convert Markdown documents to PDF format** using C#.

## Steps to convert Markdown to PDF programmatically

Step 1: Create a new .NET Core console application project.

Step 2: Install the [Syncfusion.DocIORenderer.Net.Core](https://www.nuget.org/packages/Syncfusion.DocIORenderer.Net.Core) NuGet package as a reference to your project from [NuGet.org](https://www.nuget.org/).

Step 3: Include the following namespaces in the Program.cs file.

```csharp
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocIORenderer;
using Syncfusion.Pdf;
```

Step 4: Add the following code snippet in Program.cs file to convert a Markdown document to PDF.

```csharp
// Load an existing Markdown document into DocIO instance
using (FileStream fileStreamPath = new FileStream(Path.GetFullPath(@"Data/Template.md"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
{
    using (WordDocument document = new WordDocument(fileStreamPath, FormatType.Markdown))
    {
        //Creates an instance of DocIORenderer.
        using (DocIORenderer renderer = new DocIORenderer())
        {
            //Converts Markdown document into PDF document.
            using (PdfDocument pdfDocument = renderer.ConvertToPDF(document))
            {
                //Saves the PDF file to file system.    
                using (FileStream outputStream = new FileStream(Path.GetFullPath(@"Output/Result.pdf"), FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
                {
                    pdfDocument.Save(outputStream);
                }
            }
        }
    }
}
```

More information about Markdown to PDF conversion can be found in this [documentation](https://www.syncfusion.com/blogs/post/markdown-to-pdf-in-csharp-word-library) section.