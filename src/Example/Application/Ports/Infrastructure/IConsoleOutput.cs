namespace Example.Application.Ports.Infrastructure
{
    using System;
    public interface IConsoleOutput
    {
         void PutMessage(string message);
    }
}