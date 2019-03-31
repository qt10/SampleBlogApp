using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.CrudWebApi;
using BlogApp.CrudWebApi.Utils;
using BlogApp.Domain;
using BlogApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.CrudWebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private const int PageSize = 10;
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;

        public BlogController(IBlogService blogService, IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BlogDto>> Get(int startInx)
        {
            var blogs = _blogService.GetBlogs()
                .Skip(startInx)
                .Take(PageSize)
                .ToList();

            return _mapper.MapCollection<Blog, BlogDto>(blogs);
        }

        [HttpGet("{id}")]
        public ActionResult<Blog> Get(Guid id)
        {
            return _blogService.GetBlog(id);
        }

        [HttpPost]
        public void Post([FromBody] Blog blog)
        {
            _blogService.CreateBlog(blog);
        }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Blog blog)
        {
            _blogService.UpdateBlog(blog);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _blogService.DeleteBlog(id);
        }
    }
}
