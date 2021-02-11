using System.Threading.Tasks;

namespace ReportArchitecture
{
    public interface IComputation
    {
        Task<ComputationResult> Compute();
    }
}