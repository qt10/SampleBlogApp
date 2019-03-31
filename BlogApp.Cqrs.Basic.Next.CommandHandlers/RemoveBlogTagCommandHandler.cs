using BlogApp.Cqrs.Basic.Next.Commands;
using Cqrs.Basic.Next.CommandHandlers;
using System;

namespace BlogApp.Cqrs.Basic.Next.CommandHandlers
{
    public class RemoveBlogTagCommandHandler : ICommandHandler<RemoveBlogTagCommand>
    {
        public void Handle(RemoveBlogTagCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
