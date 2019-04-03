namespace Example.Application.Commands {
    using Example.Application.Base;

    public class UseConsoleMessage : ICommand {
        public string Message { get; }
        private UseConsoleMessage(string message) {
            Message = message;
        }

        static public UseConsoleMessage Create(string message) => new UseConsoleMessage(message);
    }
}