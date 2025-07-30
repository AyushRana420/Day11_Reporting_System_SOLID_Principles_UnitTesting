using Reporting_System.Interfaces;

namespace Reporting_System.Services
{
    // Single Responsibility Principle (SRP): Only handles report content generation
    public class ReportGenerator : IReportGenerator
    {
        public string GenerateReportData()
        {
            // returns raw report content
            return "This is a sample report.";
        }
    }
}
