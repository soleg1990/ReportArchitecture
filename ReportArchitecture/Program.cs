using Autofac;
using Castle.DynamicProxy;
using ReportArchitecture.Interceptions;
using ReportArchitecture.Reports;
using System;
using System.Threading.Tasks;

namespace ReportArchitecture
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<HardComputation>().As<IComputation>();
            builder.RegisterType<MailReport>().As<IReport>();
            builder.RegisterType<FileReport>().As<IReport>();
            builder.RegisterType<DbReport>().As<IReport>();
            builder.RegisterType<ReportsRunner>().As<IReportsRunner>();
            var container = builder.Build();

            var computation = container.Resolve<IComputation>();

            //вариант а (Interceptor'ы)
            var generator = new ProxyGenerator();
            var proxy = generator.CreateInterfaceProxyWithTargetInterface(computation,
                new ReportInterception<MailReport>(),
                new ReportInterception<FileReport>(),
                new ReportInterception<DbReport>()
                );
            var result = await proxy.Compute();

            //вариант b - по сути да, это список. И в предыдущем варианте по сути тоже список
            var runner = container.Resolve<IReportsRunner>();
            runner.Run(result);

            Console.ReadLine();
        }
    }
}
