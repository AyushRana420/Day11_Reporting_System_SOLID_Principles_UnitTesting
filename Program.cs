// Program.cs
using Reporting_System.Interfaces;
using Reporting_System.Formatters;
using Reporting_System.Services;

namespace Reporting_System
{
    class Program
    {
        // Dependency Inversion Principle (DIP): Program depends on abstractions, not concrete implementations
        static void Main(string[] args)
        {
            // abstraction for generating report content
            IReportGenerator generator = new ReportGenerator();
            // abstraction for formatting strategy (PDF in this case)
            IReportFormatter formatter = new PdfReportFormatter();
            // abstraction for saving logic
            IReportSaver saver = new ReportSaver();

            // Injecting dependencies into the high-level module
            var reportService = new ReportService(generator, saver, formatter);
            reportService.CreateReport("report.pdf");

            Console.WriteLine("Report created successfully.");
        }
    }
}