//using System;
//using System.IO;


//public class ReportManager
//{
//    public string data { get; set; }
//    public DateTime date { get; set; }

//    public ReportManager(string Data, DateTime Date)
//    {
//        data = Data;
//        date = Date;
//    }
//}

//public interface report_formatter
//{
//    string FormatReport(ReportManager report);
//}


//public class Text : report_formatter
//{
//    public string FormatReport(ReportManager report)
//    {
//        return $"Report Data: {report.data}\nDate: {report.date}";
//    }
//}


//public class PDF : report_formatter
//{
//    public string FormatReport(ReportManager report)
//    {
//        return $"PDF Report:\n[Report Data: {report.data}]\n[Date: {report.date}]";
//    }
//}


//public class Excel : report_formatter
//{
//    public string FormatReport(ReportManager report)
//    {
//        return $"Excel Report:\nData: {report.data}, Date: {report.date}";
//    }
//}


//public class ReportGenerator
//{
//    private readonly report_formatter _formatter;

//    public ReportGenerator(report_formatter formatter)
//    {
//        _formatter = formatter;
//    }

//    public string Generate(ReportManager report)
//    {
//        return _formatter.FormatReport(report);
//    }
//}

//public class Save
//{
//    public void savetofile(string content, string filename)
//    {
//        File.WriteAllText(filename, content);
//        Console.WriteLine("Report saved successfully as " + filename);
//    }
//}

//// Step 6: Usage
//public class Example2
//{
//    static void Main(string[] args)
//    {
//        // Create report data
//        ReportManager report = new ReportManager("This is the report content", DateTime.Now);

        
//        report_formatter pdf1 = new PDF();
//        report_formatter excel1= new Excel();

//        // Generate report
//        ReportGenerator generator = new ReportGenerator(pdf1);
//        ReportGenerator generator1 = new ReportGenerator (excel1);
//        string content = generator.Generate(report);
//        string content1 = generator1.Generate(report);

//        // Save report
//        Save saver = new Save();
//        saver.savetofile(content, "Report.pdf");
//        saver.savetofile(content1, "excel_sheet.csv");

//        Console.WriteLine("Report generation successful.");
//    }
//}
