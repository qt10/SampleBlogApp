using BlogApp.Cqrs.Basic.Next.Queries;
using System;

namespace BlogApp.Cqrs.Next.QueryHandlers
{
    public class AbandonnedBlogsQueryHandler: IQueryHandler<AbandonnedBlogsQuery, AbandonnedBlogsQueryResult>
    {
        public AbandonnedBlogsQueryResult Exec(AbandonnedBlogsQuery query)
        {
            return new AbandonnedBlogsQueryResult();
        }
        
    }
}
