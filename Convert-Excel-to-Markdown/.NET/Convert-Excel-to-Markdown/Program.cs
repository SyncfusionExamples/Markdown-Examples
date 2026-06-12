using Syncfusion.XlsIO;

namespace Convert_Excel_to_Markdown
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
        }
    }
}



