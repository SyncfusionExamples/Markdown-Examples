using Syncfusion.XlsIO;

namespace Convert_Markdown_to_Excel
{
    class Program
    {
        static void Main(string[] args)
        {      
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
        }
    }
}




