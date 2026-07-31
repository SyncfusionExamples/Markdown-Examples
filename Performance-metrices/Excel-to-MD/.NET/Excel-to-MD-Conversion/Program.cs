
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

			// Open the existing Excel workbook.
			IWorkbook workbook = application.Workbooks.Open(
				Path.GetFullPath("Data/Input.xlsx"));

			// Create a file stream for the output Markdown file.
			using (FileStream fileStream = new FileStream(
				Path.GetFullPath("Output/Result.md"),
				FileMode.Create,
				FileAccess.Write))
			{
				// Save the workbook as a Markdown document.
				workbook.SaveAs(fileStream, ExcelSaveType.Markdown);
			}
		}
        stopwatch.Stop();
        Console.WriteLine($"Time taken to open and save text data type xlsx document as Markdown: {stopwatch.Elapsed.TotalSeconds} seconds");
        
    }
}
