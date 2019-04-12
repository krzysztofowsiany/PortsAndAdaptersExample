namespace ExampleTest {
    using System;
    using Example.Domain.Services;
    using Example.Adapters.Infrastructure;
    using Example.Adapters.Application;
    using Example.Application.Commands;

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