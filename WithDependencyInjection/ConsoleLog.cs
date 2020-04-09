using System;

namespace WithDependencyInjection
{
    public class ConsoleLog : ILog , IConsole
    {
        public void Write(string message)
        {
            Console.WriteLine($"using console logger, with the message : {message}");
        }
    }
}