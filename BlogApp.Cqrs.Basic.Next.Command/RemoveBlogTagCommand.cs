using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Cqrs.Basic.Next.Commands
{
    public class RemoveBlogTagCommand: ICommand
    {
        public Guid? Id { get; set; }
        public string Tag { get; set; }
    }
}
