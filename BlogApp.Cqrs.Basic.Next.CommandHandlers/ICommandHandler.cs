
using BlogApp.Cqrs.Basic.Next.Commands;

namespace Cqrs.Basic.Next.CommandHandlers
{
    public interface ICommandHandler<T> where T: ICommand
    {
        void Handle(T command);
    }
}
