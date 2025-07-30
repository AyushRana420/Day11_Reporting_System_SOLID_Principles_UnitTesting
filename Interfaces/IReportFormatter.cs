namespace Reporting_System.Interfaces
{
    // ISP: Interface only for formatting logic
    public interface IReportFormatter
    {
        // defines method to format the raw report content
        string Format(string data);
    }
}