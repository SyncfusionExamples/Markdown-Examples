
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

            IWorkbook workbook = application.Workbooks.Open(@"../../../Data/Input.xlsx");

            using (FileStream fileStream = new FileStream(@"../../../Output/Result.md", FileMode.Create, FileAccess.Write))
            {
                workbook.SaveAs(fileStream, ExcelSaveType.Markdown);
            }
        }
        stopwatch.Stop();
        Console.WriteLine($"Time taken to open and save text data type xlsx document as Markdown: {stopwatch.Elapsed.TotalSeconds} seconds");
        
    }
}
