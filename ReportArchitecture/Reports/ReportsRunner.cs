using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReportArchitecture.Reports
{
    public class ReportsRunner : IReportsRunner
    {
        private readonly IEnumerable<IReport> _reports;

        public ReportsRunner(IEnumerable<IReport> reports)
        {
            _reports = reports;
        }
        public void Run(ComputationResult result)
        {
            Parallel.ForEach(_reports, (report) => report.SendReport(result));
        }
    }
}
