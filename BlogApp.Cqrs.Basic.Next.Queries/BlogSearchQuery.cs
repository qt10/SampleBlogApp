using BlogApp.Cqrs.Basic.Next.ReadModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Cqrs.Basic.Next.Queries
{
    public class BlogSearchQuery : IQuery
    {
        public BlogSearchFilter Filter { get; set; }
        public int Page { get; set; }
    }
}
