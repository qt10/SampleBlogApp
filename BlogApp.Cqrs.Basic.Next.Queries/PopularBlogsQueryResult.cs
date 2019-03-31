using BlogApp.Cqrs.Basic.Next.ReadModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Cqrs.Basic.Next.Queries
{
    public class PopularBlogsQueryResult : IQueryResult<PopularBlogsQuery>
    {
        public PopularBlogsView PopularBlogsView { get; set; }
    }
}
