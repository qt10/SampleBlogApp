using BlogApp.Cqrs.Basic.Next.Commands;
using Cqrs.Basic.Next.CommandHandlers;
using System;

namespace BlogApp.Cqrs.Basic.Next.CommandHandlers
{
    public class DeleteBlogCommandHandler : ICommandHandler<DeleteBlogCommand>
    {
        public void Handle(DeleteBlogCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
