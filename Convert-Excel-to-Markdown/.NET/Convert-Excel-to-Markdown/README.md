# Convert Excel to Markdown Document using C#

The Syncfusion&reg; [.NET Excel Library](https://www.syncfusion.com/document-sdk/net-excel-library) (XlsIO) enables you to create, read, edit, and convert Excel workbooks programmatically without Microsoft Excel or interop dependencies. Using this library, you can **convert Excel documents to Markdown format** using C#.

## Steps to convert Excel to Markdown programmatically

Step 1: Create a new .NET Core console application project.

Step 2: Install the [Syncfusion.XlsIO.Net.Core](https://www.nuget.org/packages/Syncfusion.XlsIO.Net.Core) NuGet package as a reference to your project from [NuGet.org](https://www.nuget.org/).

Step 3: Include the following namespaces in the Program.cs file.

```csharp
using Syncfusion.XlsIO;
```

Step 4: Add the following code snippet in Program.cs  file to convert an Excel document to Markdown.

```csharp
 // Initialize Excel engine and application
using (ExcelEngine excelEngine = new ExcelEngine())
{
    IApplication application = excelEngine.Excel;
    application.DefaultVersion = ExcelVersion.Xlsx;

    // Open an existing workbook
    using (FileStream inputStream = new FileStream(Path.GetFullPath("Data/Template.xlsx"), FileMode.Open, FileAccess.Read))
    {
        IWorkbook workbook = application.Workbooks.Open(inputStream);

        // Save the workbook in .md format
        using (FileStream fileStream = new FileStream(Path.GetFullPath("Output/Result.md"), FileMode.Create, FileAccess.Write))
        {
            workbook.SaveAs(fileStream, ExcelSaveType.Markdown);
        }
    }              
}
```

More information about Excel to Markdown conversion can be found in this [documentation](https://help.syncfusion.com/document-processing/excel/conversions/excel-to-markdown/overview) section.