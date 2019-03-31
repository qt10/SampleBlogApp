using BlogApp.Domain;
using System;
using System.Linq;

namespace BlogApp.Cqrs.Basic.Services
{
    public interface IBlogQueryService
    {
        IQueryable<Blog> GetAbandonnedBlogs();
        IQueryable<Blog> GetPopularBlogs();
        IQueryable<Blog> GetBlogs(BlogFilter filter);
        Blog GetBlog(Guid bookId);
    }
}
