using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Cqrs.Basic.Services;
using BlogApp.Cqrs.Basic.WebApi;
using BlogApp.Cqrs.Basic.WebApi.Utils;
using BlogApp.Domain;
using BlogApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.CrudWebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BlogSearchController : ControllerBase
    {
        private const int PageSize = 10;
        private readonly IBlogQueryService _blogQueryService;
        private readonly IMapper _mapper;

        public BlogSearchController(IBlogQueryService blogReadService, IMapper mapper)
        {
            _blogQueryService = blogReadService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BlogDto>> GetBlogs(BlogFilter filter, int page)
        {
            var blogs = _blogQueryService.GetBlogs(filter)
                .Skip(page * PageSize)
                .Take(PageSize)
                .ToList();

            return _mapper.MapCollection<Blog, BlogDto>(blogs);
        }

        [HttpGet("{id}")]
        public ActionResult<Blog> GetBlog(Guid id)
        {
            return _blogQueryService.GetBlog(id);
        }

        [HttpGet]
        public ActionResult<IEnumerable<BlogDto>> GetPopularBlogs(int startInx)
        {
            var popularBlogs = _blogQueryService
                .GetPopularBlogs()
                .Skip(startInx)
                .Take(PageSize);

            return _mapper.MapCollection<Blog, BlogDto>(popularBlogs);
        }

        [HttpGet]
        public ActionResult<IEnumerable<BlogDto>> GetAbandonnedBlogs(int page)
        {
            var popularBlogs = _blogQueryService
               .GetAbandonnedBlogs()
               .Skip(page * PageSize)
               .Take(PageSize);

            return _mapper.MapCollection<Blog, BlogDto>(popularBlogs);
        }

    }
}
