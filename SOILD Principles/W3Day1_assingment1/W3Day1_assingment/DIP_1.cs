using System;
using System.Collections.Generic;

public interface IReportGenerator
{
    void GenerateReport();
}


public class PDFReport : IReportGenerator
{
    public void GenerateReport()
    {
        Console.WriteLine("Generating PDF Report...");
    }
}

public class ExcelReport : IReportGenerator
{
    public void GenerateReport()
    {
        Console.WriteLine("Generating Excel Report...");
    }
}

public class ReportService
{
    private readonly IEnumerable<IReportGenerator> _reportGenerators;

    public ReportService(IEnumerable<IReportGenerator> reportGenerators)
    {
        _reportGenerators = reportGenerators;
    }

    public void GenerateReports()
    {
        foreach (var report in _reportGenerators)
        {
            report.GenerateReport();
        }
    }
}


class DIP_1
{
    static void Main()
    {
        var reportService = new ReportService(new List<IReportGenerator>
        {
            new PDFReport(),
            new ExcelReport()
        });

        reportService.GenerateReports();
    }
}
