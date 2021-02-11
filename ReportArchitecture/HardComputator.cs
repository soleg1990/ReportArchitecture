using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReportArchitecture
{
    public class HardComputation : IComputation
    {
        public async Task<ComputationResult> Compute()
        {
            await Task.Delay(1000);
            Console.WriteLine("Hard computation finished");
            return await Task.FromResult(new ComputationResult());
        }
    }
}
