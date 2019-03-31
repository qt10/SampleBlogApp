using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Cqrs.Basic.Next.Commands
{
    public class UpdateBlogTitleCommand: ICommand
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}
