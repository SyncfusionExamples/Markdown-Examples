
using Syncfusion.XlsIO;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        // Create an instance of the Excel Engine.
		using (ExcelEngine excelEngine = new ExcelEngine())
		{
			// Access the Excel application and set the default Excel version.
			IApplication application = excelEngine.Excel;
			application.DefaultVersion = ExcelVersion.Xlsx;

			// Open the Markdown document.
			IWorkbook workbook = application.Workbooks.Open(
				Path.GetFullPath(@"Data/Sample.md"),
				ExcelOpenType.Markdown);

			// Save the Markdown document as an Excel workbook.
			workbook.SaveAs(
				Path.GetFullPath("Output/Result.xlsx"));
		}
        stopwatch.Stop();
        Console.WriteLine($"Time taken to open and save text data type xlsx document as Markdown: {stopwatch.Elapsed.TotalSeconds} seconds");
        
    }
}
