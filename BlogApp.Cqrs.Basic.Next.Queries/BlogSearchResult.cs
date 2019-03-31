using BlogApp.Cqrs.Basic.Next.ReadModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Cqrs.Basic.Next.Queries
{
    public class BlogSearchQueryResult : IQueryResult<BlogSearchQuery>
    {
        public BlogsSearchView BlogsSearchView { get; set; }
    }
}
