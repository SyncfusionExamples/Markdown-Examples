using Syncfusion.Office.Markdown;
using System.IO;
using System.Text;

// Creates a new MarkdownDocument instance.
MarkdownDocument markdownDocument = new MarkdownDocument();
// Creates import settings and specifies the encoding.
MdImportSettings mdImportSettings = new MdImportSettings();
mdImportSettings.Encoding = Encoding.UTF8;
// Opens an existing Markdown document with import settings.
markdownDocument.Open(Path.GetFullPath("Data/Input.md"), mdImportSettings);
// Saves the Markdown document to the file system.
markdownDocument.Save(Path.GetFullPath("Output/Output.md"));
// Disposes the document to release all memory.
markdownDocument.Dispose();
