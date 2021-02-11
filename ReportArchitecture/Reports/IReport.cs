using System.Threading.Tasks;

namespace ReportArchitecture.Reports
{
    public interface IReport
    {
        Task SendReport(ComputationResult result);
    }
}