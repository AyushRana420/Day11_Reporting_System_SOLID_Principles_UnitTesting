using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reporting_System.Services;
using Reporting_System.Formatters;

namespace Reporting_System_Day11_Assignment_
{
    [TestClass]
    public  class ReportServiceTests
    {
        [TestMethod]
        public void CreateReport_ShouldCreateFormattedFile()
        {
            // Arrange - Setup test with concrete implementations
            var generator = new ReportGenerator();
            var formatter = new PdfReportFormatter();
            var saver = new ReportSaver();
            var service = new ReportService(generator, saver, formatter);
            var path = "test_report.txt";

            // Act - Generate report
            service.CreateReport(path);

            // Assert - Validate file was created and contents are as expected
            Assert.IsTrue(File.Exists(path));

            var content = File.ReadAllText(path);
            Assert.AreEqual("<PDF>This is a sample report.</PDF>", content);
        }
    }
}
