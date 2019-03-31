using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Cqrs.Basic.Next.Queries
{
    public class PopularBlogsQuery : IQuery
    {
        public int Page { get; set; }
    }
}
