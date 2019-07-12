using Application.Commands;

namespace Example.Adapters.Infrastructure
{
    using System;
    public class ConsoleOutput : IConsoleOutput
    {
        public void PutMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}