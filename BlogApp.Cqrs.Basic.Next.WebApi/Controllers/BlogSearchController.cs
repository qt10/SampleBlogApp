using BlogApp.Cqrs.Basic.Next.Queries;
using BlogApp.Cqrs.Basic.Next.ReadModel;
using BlogApp.Cqrs.Basic.WebApi.Utils;
using BlogApp.Cqrs.Next.QueryHandlers;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Cqrs.Basic.Next.WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BlogSearchController : ControllerBase
    {
        private IMapper _mapper;
        public BlogSearchController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<PopularBlogsView> GetPopularBlogs([FromServices] IQueryHandler<PopularBlogsQuery, PopularBlogsQueryResult> queryHandler, int page)
        {
            var result = queryHandler.Exec(new PopularBlogsQuery()
            {
                Page = page
            });
            return result.PopularBlogsView;
        }

        [HttpGet]
        public ActionResult<AbandonnedBlogsView> GetAbandonnedBlogs([FromServices] IQueryHandler<AbandonnedBlogsQuery, AbandonnedBlogsQueryResult> queryHandler, int page)
        {
            var result = queryHandler.Exec(new AbandonnedBlogsQuery()
            {
                Page = page
            });
            return result.AbandonnedBlogsView;
        }


        [HttpGet]
        public ActionResult<BlogsSearchView> GetBlogs([FromServices] IQueryHandler<BlogSearchQuery, BlogSearchQueryResult> queryHandler, 
            [FromBody] BlogSearchFilter filter, int page)
        {
            var result = queryHandler.Exec(new BlogSearchQuery()
            {
                Page = page
            });
            return result.BlogsSearchView;
        }

    }
}
