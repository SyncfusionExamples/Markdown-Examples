
using Syncfusion.XlsIO;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        using (ExcelEngine excelEngine = new ExcelEngine())
        {
            IApplication application = excelEngine.Excel;
            application.DefaultVersion = ExcelVersion.Xlsx;

            IWorkbook workbook = application.Workbooks.Open(Path.GetFullPath(@"../../../Data/Sample.md"), ExcelOpenType.Markdown);

            workbook.SaveAs(Path.GetFullPath("../../../Output/Result.xlsx"));
        }
        stopwatch.Stop();
        Console.WriteLine($"Time taken to open and save text data type xlsx document as Markdown: {stopwatch.Elapsed.TotalSeconds} seconds");
        
    }
}
