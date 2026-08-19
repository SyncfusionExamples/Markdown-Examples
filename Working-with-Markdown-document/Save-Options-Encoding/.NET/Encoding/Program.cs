using Syncfusion.Office.Markdown;
using System.IO;
using System.Text;


// Opens an existing Markdown document.
MarkdownDocument markdownDocument = new MarkdownDocument(Path.GetFullPath("Data/Input.md"));
// Creates a SaveOptions instance.
SaveOptions saveOptions = new SaveOptions();
// Sets the encoding to use when saving the Markdown document.
saveOptions.Encoding = Encoding.UTF8;
// Saves the Markdown document with the specified encoding.
markdownDocument.Save(Path.GetFullPath("Output/Output.md"), saveOptions);
// Disposes the document to release all memory.
markdownDocument.Dispose();
