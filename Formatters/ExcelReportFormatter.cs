using Reporting_System.Interfaces;

namespace Reporting_System.Formatters
{
    // OCP: New Excel formatting strategy
    public class ExcelReportFormatter : IReportFormatter
    {
        public string Format(string data)
        {
            // simple wrapper simulating Excel content
            return $"<Excel>{data}</Excel>";
        }
    }
}
