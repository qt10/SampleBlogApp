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
    public class BlogSearchController : ControllerBase
    {
        private const int PageSize = 10;
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;

        public BlogSearchController(IBlogService blogService, IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BlogDto>> Search(int page)
        {
            var popularBlogs = _blogService
                .GetPopularBlogs()
                .Skip(PageSize * page)
                .Take(PageSize);

            return _mapper.MapCollection<Blog, BlogDto>(popularBlogs);
        }

        [HttpGet]
        public ActionResult<IEnumerable<BlogDto>> GetPopularBlogs(int page)
        {
            var popularBlogs = _blogService
                .GetPopularBlogs()
                .Skip(PageSize * page)
                .Take(PageSize);

            return _mapper.MapCollection<Blog, BlogDto>(popularBlogs);
        }

        [HttpGet]
        public ActionResult<IEnumerable<BlogDto>> GetAbandonnedBlogs(int page)
        {
            var popularBlogs = _blogService
               .GetAbandonnedBlogs()
               .Skip(PageSize * page)
               .Take(PageSize);

            return _mapper.MapCollection<Blog, BlogDto>(popularBlogs);
        }
    }
}
