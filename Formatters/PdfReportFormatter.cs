using Reporting_System.Interfaces;

namespace Reporting_System.Formatters
{
    // Open/Closed Principle (OCP): New formatter added without modifying existing code
    public class PdfReportFormatter : IReportFormatter
    {
        public string Format(string data)
        {
            // simple wrapper simulating PDF content
            return $"<PDF>{data}</PDF>";
        }
    }
}
