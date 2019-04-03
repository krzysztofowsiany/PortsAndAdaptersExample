using System;

namespace ExampleTest {
    using Example.Application.Commands;
    using Example.Application.Domain.Services;
    using Example.Adapters.API;
    using Example.Adapters.Infrastructure;
    class Program {
        static void Main(string[] args) {
            var upperCaseTextChanger = new UpperCaseTextChanger();
            var consoleOutput = new ConsoleOutput();
            var useConsoleMessageHandler = new UseConsoleMessageHandler(upperCaseTextChanger, consoleOutput);

            var consoleInput = new ConsoleInput(useConsoleMessageHandler);

            consoleInput.GetTextToEnter();

            Console.WriteLine("Wciskaj klawisz by wyjść!");
            Console.ReadKey();
        }
    }
}