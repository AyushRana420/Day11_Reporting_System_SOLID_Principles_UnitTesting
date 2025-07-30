using Reporting_System.Interfaces;

namespace Reporting_System.Services
{
    // SRP: Only responsible for saving report data to a file
    public class ReportSaver : IReportSaver
    {
        public void Save(string data, string path)
        {
            // writes data to file
            File.WriteAllText(path, data);
        }
    }
}
