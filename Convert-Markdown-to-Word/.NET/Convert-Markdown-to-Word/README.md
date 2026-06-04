# Convert Markdown to Word Document using C#

The Syncfusion&reg; [.NET Word Library](https://www.syncfusion.com/document-processing/word-framework/net/word-library) (DocIO) enables you to create, read, edit, and convert Word documents programmatically without Microsoft Word or interop dependencies. Using this library, you can **convert Markdown documents to Word format** using C#.

## Steps to convert Markdown to Word programmatically

Step 1: Create a new .NET Core console application project.

Step 2: Install the [Syncfusion.DocIO.Net.Core](https://www.nuget.org/packages/Syncfusion.DocIO.Net.Core) NuGet package as a reference to your project from [NuGet.org](https://www.nuget.org/).

Step 3: Include the following namespaces in the Program.cs file.

```csharp
using Syncfusion.DocIO; 
using Syncfusion.DocIO.DLS;
```

Step 4: Add the following code snippet in Program.cs file to convert a Markdown document to Word.

```csharp
// Load an existing Markdown document into DocIO instance
using (FileStream fileStreamPath = new FileStream(Path.GetFullPath(@"Data/Input.md"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
{
    using (WordDocument document = new WordDocument(fileStreamPath, FormatType.Markdown))
    {
        //Creates file stream
        using (FileStream outputFileStream = new FileStream(Path.GetFullPath(@"Output/Result.docx"), FileMode.Create, FileAccess.ReadWrite))
        {
            // Save the Markdown document as a Word file
            document.Save(outputFileStream, FormatType.Docx);
        }
    }
}
```

More information about Markdown to Word conversion and vice versa can be found in this [documentation](https://help.syncfusion.com/document-processing/word/conversions/markdown-to-word-conversion) section.