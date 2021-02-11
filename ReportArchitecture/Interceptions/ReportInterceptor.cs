using Castle.DynamicProxy;
using ReportArchitecture.Reports;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReportArchitecture.Interceptions
{
    public class ReportInterception<TReport> : IAsyncInterceptor
        where TReport : IReport, new()
    {
        public void InterceptAsynchronous(IInvocation invocation)
        {
            throw new NotImplementedException();
        }

        public void InterceptAsynchronous<TResult>(IInvocation invocation)
        {
            invocation.ReturnValue = InternalInterceptAsynchronous<TResult>(invocation);
        }

        private async Task<TResult> InternalInterceptAsynchronous<TResult>(IInvocation invocation)
        {
            invocation.Proceed();
            var task = (Task<TResult>)invocation.ReturnValue;
            TResult result = await task;

            Parallel.Invoke(() => SendReportTask(result as ComputationResult));

            return result;
        }

        public void InterceptSynchronous(IInvocation invocation)
        {
            throw new NotImplementedException();
        }

        private Task SendReportTask(ComputationResult result)
        {
            return new TReport().SendReport(result);
        }
    }
}
