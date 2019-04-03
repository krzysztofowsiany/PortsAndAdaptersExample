namespace Example.Adapters.Infrastructure {
    using System;
    using Example.Application.Ports.Infrastructure;
    public class ConsoleOutput : IConsoleOutput {
        public void PutMessage(string message) {
            Console.WriteLine(message);
        }
    }
}