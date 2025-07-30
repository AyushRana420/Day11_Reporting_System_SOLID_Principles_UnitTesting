namespace Reporting_System.Interfaces
{
    // ISP: Interface only for saving logic
    public interface IReportSaver
    {
        // defines method to save formatted report to a file
        void Save(string data, string path);
    }
}
