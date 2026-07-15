using Syncfusion.Office.Markdown;
using System.IO;

//Opens an existing Markdown documents
MarkdownDocument sourceDocument = new MarkdownDocument(Path.GetFullPath("Data/SourceDocument.md"));
MarkdownDocument destinationDocument = new MarkdownDocument(Path.GetFullPath("Data/DestinationDocument.md"));
//Processes each blocks in the Markdown document
for (int i = 0; i < sourceDocument.Blocks.Count; i++)
{
    //Clones and adds source document Blocks to the destination document
    destinationDocument.Blocks.Add((IMdBlock)sourceDocument.Blocks[i].Clone());
}
//Saves and closes the document instance
destinationDocument.Save(Path.GetFullPath("Output/MergedDocument.md"));
destinationDocument.Dispose();
//Closes the source document instance
sourceDocument.Dispose();

