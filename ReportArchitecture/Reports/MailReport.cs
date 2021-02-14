using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ReportArchitecture.Reports
{
    public class MailReport : IPrint
    {
        public void Print(ProcessResult result)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Report sent to mail");
        }
    }
}
