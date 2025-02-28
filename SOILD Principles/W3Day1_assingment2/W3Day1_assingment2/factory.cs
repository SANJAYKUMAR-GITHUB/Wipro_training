//using System;

//// Step 1: Create an abstract product (Document)
//public abstract class doc
//{
//    public abstract void Open();
//}

//public class pdf : doc
//{
//    public override void Open()
//    {
//        Console.WriteLine("Opening a PDF Document.");
//    }
//}

//public class wrod : doc
//{
//    public override void Open()
//    {
//        Console.WriteLine("Opening a Word Document.");
//    }
//}


//public class docfactory
//{
//    public static doc CreateDocument(string type)
//    {
//        switch (type.ToLower())
//        {
//            case "pdf":
//                return new pdf();
//            case "word":
//                return new wrod();
//            default:
//                throw new ArgumentException("Invalid document type.");
//        }
//    }
//}

//class factory { 
//    static void Main()
//    {
//        doc pdfDoc = docfactory.CreateDocument("pdf");
//        pdfDoc.Open();

//        doc wordDoc = docfactory.CreateDocument("word");
//        wordDoc.Open();
//    }
//}
