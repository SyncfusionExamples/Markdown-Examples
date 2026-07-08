# Convert Markdown to Excel Document using C#

The Syncfusion&reg; [.NET Excel Library](https://www.syncfusion.com/document-sdk/net-excel-library) (XlsIO) enables you to create, read, edit, and convert Excel workbooks programmatically without Microsoft Excel or interop dependencies. Using this library, you can **convert Markdown to Excel format** using C#.

## Steps to convert Markdown to Excel programmatically

Step 1: Create a new .NET Core console application project.

Step 2: Install the [Syncfusion.XlsIO.Net.Core](https://www.nuget.org/packages/Syncfusion.XlsIO.Net.Core) NuGet package as a reference to your project from [NuGet.org](https://www.nuget.org/).

Step 3: Include the following namespaces in the Program.cs file.

```csharp
using Syncfusion.XlsIO;
```

Step 4: Add the following code snippet in Program.cs file to convert a Markdown document to Excel.

```csharp
// Initialize Excel engine and application
using (ExcelEngine excelEngine = new ExcelEngine())
{
    IApplication application = excelEngine.Excel;
    application.DefaultVersion = ExcelVersion.Xlsx;

    IWorkbook workbook = application.Workbooks.Open(Path.GetFullPath(@"Data/Template.md"), ExcelOpenType.Markdown);
    // Save the workbook
    using FileStream outputStream = new FileStream(Path.GetFullPath("Output/Result.xlsx"), FileMode.Create, FileAccess.Write);
    workbook.SaveAs(outputStream);
}
```

More information about Markdown to Excel conversion and vice versa can be found in this [documentation](https://help.syncfusion.com/document-processing/excel/conversions/markdown-to-excel/overview) section.