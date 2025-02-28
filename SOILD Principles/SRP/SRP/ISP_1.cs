//// Base interface for all reports
//using System;

//public interface IReport
//{
//    void GenerateReport();
//}

//// Separate interfaces for export functionality
//public interface IPdfExportable
//{
//    void ExportToPDF();
//}

//public interface IExcelExportable
//{
//    void ExportToExcel();
//}

//// FinancialReport implements all functionalities
//public class FinancialReport : IReport, IPdfExportable, IExcelExportable
//{
//    public void GenerateReport()
//    {
//        Console.WriteLine("Generating Financial Report...");
//    }

//    public void ExportToPDF()
//    {
//        Console.WriteLine("Exporting Financial Report to PDF...");
//    }

//    public void ExportToExcel()
//    {
//        Console.WriteLine("Exporting Financial Report to Excel...");
//    }
//}

//// SummaryReport only implements PDF export
//public class SummaryReport : IReport, IPdfExportable
//{
//    public void GenerateReport()
//    {
//        Console.WriteLine("Generating Summary Report...");
//    }

//    public void ExportToPDF()
//    {
//        Console.WriteLine("Exporting Summary Report to PDF...");
//    }
//}

//// Usage
//class Program
//{
//    static void Main()
//    {
//        IReport financialReport = new FinancialReport();
//        financialReport.GenerateReport();

//        IPdfExportable pdfReport = new SummaryReport();
//        pdfReport.ExportToPDF();

//        IExcelExportable excelReport = new FinancialReport();
//        excelReport.ExportToExcel();
//    }
//}
