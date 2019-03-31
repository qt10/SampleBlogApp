using BlogApp.Cqrs.Basic.Next.Queries;
using System;

namespace BlogApp.Cqrs.Next.QueryHandlers
{
    public interface IQueryHandler<TQuery, TResult> where TQuery: IQuery
        where TResult: IQueryResult<TQuery>
    {
        TResult Exec(TQuery query);
    }
}
