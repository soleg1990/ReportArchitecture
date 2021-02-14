using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ReportArchitecture.Reports
{
    public class DbReport : IPrint
    {
        public void Print(ProcessResult result)
        {
            Thread.Sleep(1000);
            Console.WriteLine("Report sent to db");
        }
    }
}
