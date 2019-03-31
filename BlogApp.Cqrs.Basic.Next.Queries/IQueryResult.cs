using System;

namespace BlogApp.Cqrs.Basic.Next.Queries
{
    public interface IQueryResult<T> where T: IQuery
    {
        
    }
}
