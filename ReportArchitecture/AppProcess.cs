using ReportArchitecture.Reports;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReportArchitecture
{
    public class AppProcess : IProcess
    {
        private readonly IPrint _print;
        
        public AppProcess(IPrint print)
        {
            _print = print;
        }

        public void Process()
        {
            var result = new ProcessResult();
            _print.Print(result);
        }
    }
}
