using System;
using System.Collections.Generic;
using System.Linq;
using BlogApp.Cqrs.Basic.Services;
using BlogApp.Cqrs.Basic.WebApi.Utils;
using BlogApp.Domain;
using BlogApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.CrudWebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogCommandService _blogCommandService;
        private readonly IMapper _mapper;

        public BlogController(IBlogCommandService blogCommandService, 
            IMapper mapper)
        {
            _mapper = mapper;
            _blogCommandService = blogCommandService;
        }

        [HttpPost]
        public void CreateBlog([FromBody] BlogDto blogDto)
        {
            var blog = _mapper.Map<BlogDto, Blog>(blogDto);
            _blogCommandService.CreateBlog(blog);
        }

        [HttpPut("{id}")]
        public void UpdateBlogTitle(Guid id, [FromBody] string title)
        {
            _blogCommandService.UpdateBlogTitle(id, title);
        }

        [HttpPut("{id}")]
        public void AddTag(Guid id, [FromBody] string tag)
        {
            _blogCommandService.AddTag(id, tag);
        }

        [HttpPut("{id}")]
        public void RemoveTag(Guid id, [FromBody] string tag)
        {
            _blogCommandService.RemoveTag(id, tag);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _blogCommandService.DeleteBlog(id);
        }
    }
}
