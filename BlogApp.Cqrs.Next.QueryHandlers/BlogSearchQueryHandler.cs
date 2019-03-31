using BlogApp.Cqrs.Basic.Next.Queries;
using System;

namespace BlogApp.Cqrs.Next.QueryHandlers
{
    public class BlogSearchQueryHandler: IQueryHandler<BlogSearchQuery, BlogSearchQueryResult>
    {
        public BlogSearchQueryResult Exec(BlogSearchQuery query)
        {
            return new BlogSearchQueryResult();
        }

    }
}
