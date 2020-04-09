using System;

namespace NoDependencyInjection
{
    public class ConsoleLog : ILog 
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}