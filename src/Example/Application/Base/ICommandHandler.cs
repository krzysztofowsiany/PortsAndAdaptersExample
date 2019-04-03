namespace Example.Application.Base {
    public interface ICommandHandler<in TCommand>
        where TCommand : ICommand {
            void Handle(TCommand command);
        }
}