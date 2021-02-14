using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ReportArchitecture.Reports
{
    public class FileReport : IPrint
    {
        public void Print(ProcessResult result)
        {
            Thread.Sleep(500);
            Console.WriteLine("Report sent to file");
        }
    }
}
