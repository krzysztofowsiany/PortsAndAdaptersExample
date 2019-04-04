namespace ExampleTest {
    using System;
    using ExampleDomain.Services;
    using ExampleAdapters.Infrastructure;
    using ExampleAdapters.API;
    using ExampleApplication.Commands;

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