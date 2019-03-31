using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Cqrs.Basic.Next.Commands
{
    public class CreateBlogCommand: ICommand
    {
        public string Title { get; set; }
        public Guid AuthorId { get; set; }
    }
}
