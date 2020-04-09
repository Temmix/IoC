using System;

namespace WithDependencyInjection
{
    public class ConsoleLog : ILog 
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}