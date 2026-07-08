using Syncfusion.Office.Markdown;

namespace Add_task_lists
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creates a new MarkdownDocument instance
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Adds a heading for the task list
            MdParagraph heading = markdownDocument.AddParagraph();
            heading.ApplyParagraphStyle("Heading 2");
            heading.AddTextRange().Text = "Project Tasks";
            // Adds a checked task item
            MdParagraph firstTask = markdownDocument.AddParagraph();
            firstTask.TaskItemProperties = new MdTaskProperties();
            firstTask.TaskItemProperties.IsChecked = true;
            firstTask.AddTextRange().Text = "Initialize repository";
            // Adds an unchecked task item
            MdParagraph secondTask = markdownDocument.AddParagraph();
            secondTask.TaskItemProperties = new MdTaskProperties();
            secondTask.TaskItemProperties.IsChecked = false;
            secondTask.AddTextRange().Text = "Setup CI/CD pipeline";
            // Adds another unchecked task item
            MdParagraph thirdTask = markdownDocument.AddParagraph();
            thirdTask.TaskItemProperties = new MdTaskProperties();
            thirdTask.TaskItemProperties.IsChecked = false;
            thirdTask.AddTextRange().Text = "Configure environments";
            // Saves the Markdown document to the file system
            markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
            // Disposes the document
            markdownDocument.Dispose();
        }
    }
}