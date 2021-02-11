using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReportArchitecture.Reports
{
    public class MailReport : IReport
    {
        public async Task SendReport(ComputationResult result)
        {
            await Task.Delay(2000);
            Console.WriteLine("Report sent to mail");
        }
    }
}
