namespace ExampleApplication.Commands
{
    using CQRSBase.Contracts.Command;
    public class UseConsoleMessage : ICommand
    {
        public string Message { get; }
        private UseConsoleMessage(string message)
        {
            Message = message;
        }

        static public UseConsoleMessage Create(string message) => new UseConsoleMessage(message);
    }
}