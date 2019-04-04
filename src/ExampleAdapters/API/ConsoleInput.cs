namespace ExampleAdapters.API {
    using System;
    using ExampleApplication.Commands;
    using ExampleApplication.Ports.API;
    
    public class ConsoleInput : IConsoleInput {
        private readonly UseConsoleMessageHandler _useConsoleMessageHandle;

        public ConsoleInput(UseConsoleMessageHandler useConsoleMessageHandler) {
            _useConsoleMessageHandle = useConsoleMessageHandler;
        }

        public void GetTextToEnter() {
            Console.WriteLine("Wprowadź dane: ");
            var message = Console.ReadLine();
            _useConsoleMessageHandle.Handle(UseConsoleMessage.Create(message));
        }
    }
}