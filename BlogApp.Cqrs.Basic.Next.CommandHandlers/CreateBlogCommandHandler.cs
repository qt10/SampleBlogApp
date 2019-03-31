using BlogApp.Cqrs.Basic.Next.Commands;
using Cqrs.Basic.Next.CommandHandlers;
using System;

namespace BlogApp.Cqrs.Basic.Next.CommandHandlers
{
    public class CreateBlogCommandHandler : ICommandHandler<CreateBlogCommand>
    {
        public void Handle(CreateBlogCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
