namespace ExampleAdapters.Infrastructure
{
    using ExampleApplication.Ports.Infrastructure;
    using System;
    public class ConsoleOutput : IConsoleOutput
    {
        public void PutMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}