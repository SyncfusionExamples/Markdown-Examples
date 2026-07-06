# Convert PowerPoint to Markdown Document using C#

The Syncfusion&reg; [.NET PowerPoint Library](https://www.syncfusion.com/document-sdk/net-powerpoint-library) enables you to create, read, edit, and convert PowerPoint presentations programmatically without Microsoft PowerPoint or interop dependencies. Using this library, you can **convert PowerPoint presentations to Markdown format** using C#.

## Steps to convert PowerPoint to Markdown programmatically

Step 1: Create a new .NET Core console application project.

Step 2: Install the [Syncfusion.Presentation.Net.Core](https://www.nuget.org/packages/Syncfusion.Presentation.Net.Core) NuGet package as a reference to your project from [NuGet.org](https://www.nuget.org/).

Step 3: Include the following namespaces in the Program.cs file.

```csharp
using Syncfusion.Presentation;
using System.IO;
```

Step 4: Add the following code snippet in Program.cs  file to convert a PowerPoint presentation to Markdown.

```csharp
//Open an existing presentation.
using (FileStream inputStream = new(Path.GetFullPath(@"Data/Template.pptx"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
{
    //Load the file stream into a Markdown file.
    using (IPresentation presentation = Presentation.Open(inputStream))
    {
        //Save as a PPTX document into the Markdown FileStream.
        using (FileStream outputStream = new FileStream(Path.GetFullPath(@"Output/PPTXtoMd.md"), FileMode.Create, FileAccess.ReadWrite))
        {
            presentation.Save(outputStream);
        }
    }
}

```

More information about PowerPoint to Markdown conversion can be found in this [documentation](https://help.syncfusion.com/document-processing/powerpoint/conversions/powerpoint-to-markdown) section.