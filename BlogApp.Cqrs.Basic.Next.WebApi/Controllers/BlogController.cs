using System;
using BlogApp.Cqrs.Basic.Next.Commands;
using BlogApp.Cqrs.Basic.WebApi.Utils;
using Cqrs.Basic.Next.CommandHandlers;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Cqrs.Basic.Next.WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
       public BlogController()
       {
       }

        [HttpPost]
        public void CreateBlog([FromServices] ICommandHandler<CreateBlogCommand> commandHandler, [FromBody] BlogDto blogDto)
        {
            commandHandler.Handle(new CreateBlogCommand()
            {
                AuthorId = blogDto.AuthodId,
                Title = blogDto.Name
            });
        }

        [HttpPut("{id}")]
        public void UpdateBlogTitle([FromServices] ICommandHandler<UpdateBlogTitleCommand> commandHandler, Guid id, [FromBody] string title)
        {
            commandHandler.Handle(new UpdateBlogTitleCommand()
            {
                Id = id,
                Title = title
            });
        }

        [HttpPut("{id}")]
        public void AddTag([FromServices] ICommandHandler<AddBlogTagCommand> commandHandler, Guid id, [FromBody] string tag)
        {
            commandHandler.Handle(new AddBlogTagCommand()
            {
                Id = id,
                Tag = tag
            });
        }

        [HttpPut("{id}")]
        public void RemoveTag([FromServices] ICommandHandler<RemoveBlogTagCommand> commandHandler, Guid id, [FromBody] string tag)
        {
            commandHandler.Handle(new RemoveBlogTagCommand()
            {
                Id = id,
                Tag = tag
            });
        }

        [HttpDelete("{id}")]
        public void DeleteBlog([FromServices] ICommandHandler<DeleteBlogCommand> commandHandler, Guid id)
        {
            commandHandler.Handle(new DeleteBlogCommand()
            {
                Id = id
            });
        }
    }
}
