namespace Example.Adapters.Infrastructure
{
    using Example.Ports.Infrastructure;
    using System;
    public class ConsoleOutput : IConsoleOutput
    {
        public void PutMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}