# Convert Markdown to PowerPoint Document using C#

The Syncfusion&reg; [.NET PowerPoint Library](https://www.syncfusion.com/document-sdk/net-powerpoint-library)  enables you to create, read, edit, and convert PowerPoint presentations programmatically without Microsoft PowerPoint or interop dependencies. Using this library, you can **convert Markdown documents to PowerPoint format** using C#.

## Steps to convert Markdown to PowerPoint programmatically

Step 1: Create a new .NET Core console application project.

Step 2: Install the [Syncfusion.Presentation.Net.Core](https://www.nuget.org/packages/Syncfusion.Presentation.Net.Core) NuGet package as a reference to your project from [NuGet.org](https://www.nuget.org/).

Step 3: Include the following namespaces in the Program.cs file.

```csharp
using Syncfusion.Presentation;
using System.IO;
```

Step 4: Add the following code snippet in Program.cs file to convert a Markdown document to PowerPoint.

```csharp
// Open an existing Markdown file.
using (IPresentation pptxDoc = Presentation.Open(Path.GetFullPath(@"Data/Template.md")))
{
    // Write memory stream to output file
    using (FileStream outputFileStream = new FileStream(Path.GetFullPath(@"Output/Result.PPTX"), FileMode.Create, FileAccess.Write))
    {
        pptxDoc.Save(outputFileStream);
    }
}
```

More information about Markdown to PowerPoint conversion can be found in this [documentation](https://help.syncfusion.com/document-processing/powerpoint/conversions/markdown-to-powerpoint) section.