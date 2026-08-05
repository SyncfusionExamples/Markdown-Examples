using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Syncfusion.Office.Markdown;

namespace Create_Markdown_Document
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log,ExecutionContext context)
        {
            // Creates a new instance of MarkdownDocument.
            MarkdownDocument markdownDocument = new MarkdownDocument();
            // Adds a heading to the Markdown document.
            MdParagraph mdHeadingParagraph = markdownDocument.AddParagraph();
            // Applies the Heading 1 style to the paragraph.
            mdHeadingParagraph.ApplyParagraphStyle("Heading 1");
            MdTextRange mdHeadingTextRange = mdHeadingParagraph.AddTextRange();
            mdHeadingTextRange.Text = "Adventure Works Cycles";
            // Adds a paragraph to the Markdown document.
            MdParagraph mdParagraph = markdownDocument.AddParagraph();
            MdTextRange mdTextRange = mdParagraph.AddTextRange();
            mdTextRange.Text = "Adventure Works Cycles, the fictitious company on which the AdventureWorks sample databases are based, is a large, multinational manufacturing company. The company manufactures and sells metal and composite bicycles to North American, European and Asian commercial markets. While its base operation is in Bothell, Washington with 290 employees, several regional sales teams are located throughout their market base.";
            // Adds the first list item.
            MdParagraph item1 = markdownDocument.AddParagraph();
            item1.ListFormat = new MdListFormat();
            item1.ListFormat.IsNumbered = false;
            item1.ListFormat.ListLevel = 0;
            item1.ListFormat.ListValue = "- ";
            item1.AddTextRange().Text = "First item";
            // Adds the second list item.
            MdParagraph item2 = markdownDocument.AddParagraph();
            item2.ListFormat = new MdListFormat();
            item2.ListFormat.IsNumbered = false;
            item2.ListFormat.ListLevel = 0;
            item2.ListFormat.ListValue = "- ";
            item2.AddTextRange().Text = "Second item";
            // Adds the third list item.
            MdParagraph item3 = markdownDocument.AddParagraph();
            item3.ListFormat = new MdListFormat();
            item3.ListFormat.IsNumbered = false;
            item3.ListFormat.ListLevel = 0;
            item3.ListFormat.ListValue = "- ";
            item3.AddTextRange().Text = "Third item";
            // Adds a table to the Markdown document.
            MdTable table = markdownDocument.AddTable();
            table.ColumnAlignments.Add(MdColumnAlignment.Left);
            table.ColumnAlignments.Add(MdColumnAlignment.Left);
            // Adds the header row.
            MdTableRow headerRow = table.AddTableRow();
            MdTableCell header1 = headerRow.AddTableCell();
            header1.Items.Add(new MdTextRange { Text = "Profile picture" });
            MdTableCell header2 = headerRow.AddTableCell();
            header2.Items.Add(new MdTextRange { Text = "Description" });

            // Adds a data row.
            MdTableRow dataRow = table.AddTableRow();
            MdTableCell cell1 = dataRow.AddTableCell();
            MdPicture picture = new MdPicture();
            picture.Url = "Data\\photo.jpg";
            picture.AltText = "Profile picture";
            cell1.Items.Add(picture);
            MdTableCell cell2 = dataRow.AddTableCell();
            cell2.Items.Add(new MdTextRange { Text = "AdventureWorks Cycles, the fictitious company on which the AdventureWorks sample databases are based, is a large, multinational manufacturing company." });
            

            MemoryStream memoryStream = new MemoryStream();
            //Saves the markdown document file.
            markdownDocument.Save(memoryStream);
            //Create the response to return.
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
            //Set the Markdown document saved stream as content of response.
            response.Content = new ByteArrayContent(memoryStream.ToArray());
            //Set the contentDisposition as attachment.
            response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
            {
                FileName = "Sample.md"
            };
            //Set the content type as Markdown document mime type.
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("text/markdown");
            //Return the response with output Markdown document stream.
            return response;
        }
    }
}
