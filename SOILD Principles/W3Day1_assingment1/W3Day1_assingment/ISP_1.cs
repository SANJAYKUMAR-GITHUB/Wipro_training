
//using System;

//public interface IReport
//{
//    void GenerateReport();
//}


//public interface IPdfExportable
//{
//    void ExportToPDF();
//}

//public interface IExcelExportable
//{
//    void ExportToExcel();
//}


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


//class ISP_1
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
