# Word Document to Markdown using C#

The Syncfusion&reg; [.NET Word Library](https://www.syncfusion.com/document-sdk/net-word-library) (DocIO) enables you to create, read, edit, and convert Word documents programmatically without Microsoft Word or interop dependencies. Using this library, you can **convert Word documents to Markdown format** using C#.

## Steps to convert Word to Markdown programmatically

Step 1: Create a new .NET Core console application project.

Step 2: Install the [Syncfusion.DocIO.Net.Core](https://www.nuget.org/packages/Syncfusion.DocIO.Net.Core) NuGet package as a reference to your project from [NuGet.org](https://www.nuget.org/).

Step 3: Include the following namespaces in the Program.cs file.

```csharp
using Syncfusion.DocIO; 
using Syncfusion.DocIO.DLS;
```

Step 4: Add the following code snippet in Program.cs file to convert a Word document to Markdown.

```csharp
 //Loads an existing Word document into DocIO instance. 
 using (FileStream fileStreamPath = new FileStream(Path.GetFullPath(@"Data/Input.docx"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
 {
     using (WordDocument document = new WordDocument(fileStreamPath, FormatType.Docx))
     {
         //Creates file stream.
         using (FileStream outputFileStream = new FileStream(Path.GetFullPath(@"Output/Result.md"), FileMode.Create, FileAccess.ReadWrite))
         {
             //Saves the Word document to file stream.
             document.Save(outputFileStream, FormatType.Markdown);
         }
     }
 }
```

More information about Word to Markdown conversion and vice versa can be found in this [documentation](https://help.syncfusion.com/document-processing/word/conversions/word-to-markdown-conversion) section.