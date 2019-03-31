using BlogApp.Cqrs.Basic.Next.Commands;
using Cqrs.Basic.Next.CommandHandlers;
using System;

namespace BlogApp.Cqrs.Basic.Next.CommandHandlers
{
    public class UpdateBlogTitleCommandHandler : ICommandHandler<UpdateBlogTitleCommand>
    {
        public void Handle(UpdateBlogTitleCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
