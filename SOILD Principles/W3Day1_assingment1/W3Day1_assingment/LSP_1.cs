//// Base class
//using System.Collections.Generic;
//using System;

//public abstract class Report
//{
//    public abstract void GenerateReport();
//}

//// Derived class 1
//public class GeneralReport : Report
//{
//    public override void GenerateReport()
//    {
//        Console.WriteLine("Generating a general report...");
//    }
//}

//// Derived class 2
//public class FinancialReport : Report
//{
//    public override void GenerateReport()
//    {
//        Console.WriteLine("Generating a financial report with additional setup...");
//    }
//}

//// Derived class 3
//public class HRReport : Report
//{
//    public override void GenerateReport()
//    {
//        Console.WriteLine("Generating an HR report...");
//    }
//}

//class LSP_1
//{
//    static void Main()
//    {
//        List<Report> reports = new List<Report>
//        {
//            new GeneralReport(),
//            new FinancialReport(),
//            new HRReport()
//        };

//        foreach (var report in reports)
//        {
//            report.GenerateReport();
//        }
//    }
//}
