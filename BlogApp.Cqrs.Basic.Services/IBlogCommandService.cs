using BlogApp.Domain;
using System;
using System.Linq;

namespace BlogApp.Services
{
    public interface IBlogCommandService
    {
        void CreateBlog(Blog blog);
        void UpdateBlogTitle(Guid id, string title);
        void AddTag(Guid id, string tag);
        void RemoveTag(Guid id, string tag);
        void DeleteBlog(Guid blogId);
    }
}
