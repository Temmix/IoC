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

            // if you register both email and console log,
            // with the clause on EmailLog will preserve the console logs
            // else it will use the EmailLog
            builder.RegisterType<ConsoleLog>().As<ILog>();
            builder.RegisterType<EmailLog>().As<ILog>().PreserveExistingDefaults().As<IConsole>();


           // builder.RegisterType<Engine>(); // direct register, but below uses Lambda exprx. 
            builder.Register(c => new Engine(c.Resolve<ILog>(), 167));
            builder.RegisterType<Car>().UsingConstructor(typeof(Engine)); 
            
            // Register Generic types for learning purpose.
            builder.RegisterGeneric(typeof(List<>)).As(typeof(IList<>));

            // build the container
            IContainer container = builder.Build();

            // Get the real objects.
            var car = container.Resolve<Car>();
            var list = container.Resolve<IList<EmailLog>>();

            car.Go(100);

            // Get the type of list
            Console.WriteLine($"The type of list is : {list.GetType()}");
             
            Console.ReadLine();
        }
    }
}

/*for UNIT TESTING
    var log = new ConsoleLog();
    builder.RegisterInstance(log).As<ILog>();

    With the above you can unit test with prepared object ;)
 
  */