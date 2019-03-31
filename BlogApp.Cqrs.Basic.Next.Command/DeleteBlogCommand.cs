using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Cqrs.Basic.Next.Commands
{
    public class DeleteBlogCommand: ICommand
    {
        public Guid? Id { get; set; }
    }
}
