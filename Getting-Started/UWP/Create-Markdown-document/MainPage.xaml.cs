using Syncfusion.Office.Markdown;
using System;
using System.Collections.Generic;
using System.IO;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Create_Markdown_document
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private async void OnButtonClicked(object sender, RoutedEventArgs e)
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
            picture.Url = "Assets\\photo.jpg";
            picture.AltText = "Profile picture";
            cell1.Items.Add(picture);
            MdTableCell cell2 = dataRow.AddTableCell();
            cell2.Items.Add(new MdTextRange { Text = "AdventureWorks Cycles, the fictitious company on which the AdventureWorks sample databases are based, is a large, multinational manufacturing company." });


            // Downloads the Markdown document in the browser.

            MemoryStream stream = new MemoryStream();
            markdownDocument.Save(stream);
            stream.Position = 0;
            // Disposes the document.
            markdownDocument.Dispose();
            //Saves the stream as Markdown document file in local machine.
            Save(stream, "Sample.md");
            
        }

        //Saves the Markdown document.
        async void Save(MemoryStream streams, string filename)
        {
            streams.Position = 0;
            StorageFile stFile;
            if (!(Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.Phone.UI.Input.HardwareButtons")))
            {
                FileSavePicker savePicker = new FileSavePicker();
                savePicker.DefaultFileExtension = ".md";
                savePicker.SuggestedFileName = filename;
                savePicker.FileTypeChoices.Add("Markdown Documents", new List<string>() { ".md" });
                stFile = await savePicker.PickSaveFileAsync();
            }
            else
            {
                StorageFolder local = Windows.Storage.ApplicationData.Current.LocalFolder;
                stFile = await local.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting);
            }
            if (stFile != null)
            {
                using (IRandomAccessStream zipStream = await stFile.OpenAsync(FileAccessMode.ReadWrite))
                {
                    //Write compressed data from memory to file.
                    using (Stream outstream = zipStream.AsStreamForWrite())
                    {
                        byte[] buffer = streams.ToArray();
                        outstream.Write(buffer, 0, buffer.Length);
                        outstream.Flush();
                    }
                }
            }
            //Launch the saved Word file.
            await Windows.System.Launcher.LaunchFileAsync(stFile);
        }
    }
}
