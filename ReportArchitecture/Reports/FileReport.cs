using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReportArchitecture.Reports
{
    public class FileReport : IReport
    {
        public async Task SendReport(ComputationResult result)
        {
            await Task.Delay(500);
            Console.WriteLine("Report sent to file");
        }
    }
}
