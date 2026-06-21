using System;

public interface IDocument
{
    void Open();
}

public class WordDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Word Document Opened");
    }
}

public class PdfDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("PDF Document Opened");
    }
}

public class ExcelDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Excel Document Opened");
    }
}

public abstract class DocumentFactory
{
    public abstract IDocument CreateDocument();
}


public class WordFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new WordDocument();
    }
}

public class PdfFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new PdfDocument();
    }
}

public class ExcelFactory : DocumentFactory
    {
    public override IDocument CreateDocument()
    {
        return new ExcelDocument();
    }
}

class Program
{
    static void Main(string[] args)
    {
        DocumentFactory wordFactory = new WordFactory();
        IDocument wordDoc = wordFactory.CreateDocument();
        wordDoc.Open();

        DocumentFactory pdfFactory = new PdfFactory();
        IDocument pdfDoc = pdfFactory.CreateDocument();
        pdfDoc.Open();

        DocumentFactory excelFactory = new ExcelFactory();
        IDocument excelDoc = excelFactory.CreateDocument();
        excelDoc.Open();
    }
}