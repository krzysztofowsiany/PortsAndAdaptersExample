namespace ExampleApplication.Commands {
    using ExampleDomain.Services;
    using CQRSBase.Contracts.Command;
    using System;
    using ExampleApplication.Ports.Infrastructure;
    

    public class UseConsoleMessageHandler : ICommandHandler<UseConsoleMessage> {

        private readonly UpperCaseTextChanger _upperCaseTextChanger;
        private readonly IConsoleOutput _consoleOutput;

        public UseConsoleMessageHandler(
            UpperCaseTextChanger upperCaseTextChanger,
            IConsoleOutput consoleOutput) {
            _upperCaseTextChanger = upperCaseTextChanger;
            _consoleOutput = consoleOutput;
        }

        public void Handle(UseConsoleMessage useConsoleMessage) {
            var upperCaseText = _upperCaseTextChanger.Change(useConsoleMessage.Message);
            
            _consoleOutput.PutMessage(upperCaseText);
        }
    }
}