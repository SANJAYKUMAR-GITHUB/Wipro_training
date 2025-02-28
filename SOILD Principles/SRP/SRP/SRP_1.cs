//using System;
//using System.IO;

//class ReportManager
//{
//    public string data { get; set; }
//    //using properties
//    public DateTime date { get; set; }

//    public ReportManager(string Data, DateTime Date) //constructor
//    {
//        data = Data;
//        date = Date;
//    }
//}

////class has only one responsibility that to generate report
//class ReportGenerator
//{
//    public string generator(ReportManager report)
//    {
//        return $"Report data: {report.data}\n{report.date}";
//    }
//}


////the class save has only one resposibility that to save file
//class save
//{
//    public void savings(string content, string filename)
//    {
//        File.WriteAllText(filename, content);
//        Console.WriteLine("Report saved successfully");
//    }
//}

//public class example2
//{
//    static void Main(string[] args)
//    {
//        ReportManager r1 = new ReportManager("This is the encrypt file", DateTime.Now);

//        ReportGenerator r2 = new ReportGenerator();
//        string content = r2.generator(r1);

//        save s1 = new save();
//        s1.savings(content, "Report.txt");

//        Console.WriteLine("Successfully generated");

//    }
//}