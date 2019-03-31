using BlogApp.Cqrs.Basic.Next.Queries;
using System;

namespace BlogApp.Cqrs.Next.QueryHandlers
{
    public class PopularBlogsQueryHandler : IQueryHandler<PopularBlogsQuery, PopularBlogsQueryResult>
    {
        public PopularBlogsQueryResult Exec(PopularBlogsQuery query)
        {
            return new PopularBlogsQueryResult();
        }
    }
}
