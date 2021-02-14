using System.Threading.Tasks;

namespace ReportArchitecture.Reports
{
    public interface IPrint
    {
        void Print(ProcessResult result);
    }
}