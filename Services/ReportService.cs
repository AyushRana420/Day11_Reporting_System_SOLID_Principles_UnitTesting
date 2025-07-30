using Reporting_System.Interfaces;

namespace Reporting_System.Services
{
    // High-level module orchestrating report creation
    // DIP: Depends on abstractions (interfaces), not concrete classes
    public class ReportService
    {
        private readonly IReportGenerator _generator;
        private readonly IReportSaver _saver;
        private readonly IReportFormatter _formatter;

        // Constructor injection for dependency management
        public ReportService(IReportGenerator generator, IReportSaver saver, IReportFormatter formatter)
        {
            _generator = generator;
            _saver = saver;
            _formatter = formatter;
        }

        public void CreateReport(string path)
        {
            var data = _generator.GenerateReportData(); // uses IReportGenerator
            var formatted = _formatter.Format(data);    // uses IReportFormatter
            _saver.Save(formatted, path);               // uses IReportSaver
        }
    }
}
