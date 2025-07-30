namespace Reporting_System.Interfaces
{
    // Interface Segregation Principle (ISP): Small, focused interface for report generation
    public interface IReportGenerator
    {
        // defines method to return raw report data
        string GenerateReportData();
    }
}
