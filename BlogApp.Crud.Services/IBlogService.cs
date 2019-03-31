using BlogApp.Domain;
using System;
using System.Linq;

namespace BlogApp.Services
{
    public interface IBlogService
    {
        void CreateBlog(Blog blog);
        void UpdateBlog(Blog blog);
        void DeleteBlog(Guid blogId);
        IQueryable<Blog> GetBlogs();
        IQueryable<Blog> GetPopularBlogs();
        IQueryable<Blog> GetAbandonnedBlogs();
        Blog GetBlog(Guid bookId);
    }
}
