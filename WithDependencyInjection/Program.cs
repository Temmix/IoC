using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace WithDependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleLog>().As<ILog>();
            builder.RegisterType<Engine>();
            builder.RegisterType<Car>(); 
            IContainer container = builder.Build();

            var car = container.Resolve<Car>();
            car.Go(100);
            Console.ReadLine();
        }
    }
}
