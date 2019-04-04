namespace ExampleApplication.Ports.Infrastructure
{
    using System;
    public interface IConsoleOutput
    {
         void PutMessage(string message);
    }
}