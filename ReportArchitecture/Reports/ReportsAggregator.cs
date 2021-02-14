using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReportArchitecture.Reports
{
    public class ReportsAggregator : IPrint
    {
        private readonly IEnumerable<IPrint> _reports;

        public ReportsAggregator(IPrint[] reports)
        {
            _reports = reports;
        }
        public void Print(ProcessResult result)
        {
            Parallel.ForEach(_reports, (report) => report.Print(result));
        }
    }
}
