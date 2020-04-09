using System;

namespace WithDependencyInjection
{
    public class EmailLog : ILog, IConsole
    {
        private readonly string _adminEmail = "temmix@webbrains.com";

        public void Write(string message)
        {
            Console.WriteLine($"Email Logger sent email sent to {_adminEmail} with the message , {message}");
        }

    }
}