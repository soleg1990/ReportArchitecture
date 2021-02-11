using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReportArchitecture.Reports
{
    public class DbReport : IReport
    {
        public async Task SendReport(ComputationResult result)
        {
            await Task.Delay(1000);
            Console.WriteLine("Report sent to db");
        }
    }
}
