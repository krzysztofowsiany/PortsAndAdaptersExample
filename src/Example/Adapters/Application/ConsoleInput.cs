namespace Example.Adapters.Application {
    using System;
    using Example.Application.Commands;
    using Example.Ports.Application;
    
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