using Autofac;
using ReportArchitecture.Reports;
using System;

namespace ReportArchitecture
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<AppProcess>().As<IProcess>();
            builder
                .RegisterType<ReportsAggregator>()
                .As<IPrint>()
                .WithParameter(new TypedParameter(typeof(IPrint[]), 
                    new IPrint[] {
                        new MailReport(),
                        new FileReport(),
                        new DbReport() 
                    }));
            var container = builder.Build();

            var process = container.Resolve<IProcess>();

            process.Process();

            Console.ReadLine();
        }
    }
}
