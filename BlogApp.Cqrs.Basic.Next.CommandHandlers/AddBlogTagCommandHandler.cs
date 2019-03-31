using BlogApp.Cqrs.Basic.Next.Commands;
using Cqrs.Basic.Next.CommandHandlers;
using System;

namespace BlogApp.Cqrs.Basic.Next.CommandHandlers
{
    public class AddBlogTagCommandHandler : ICommandHandler<AddBlogTagCommand>
    {
        public void Handle(AddBlogTagCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
