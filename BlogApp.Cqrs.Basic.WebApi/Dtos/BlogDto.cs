using BlogApp.Cqrs.Basic.WebApi;
using System;
using System.Collections.Generic;

namespace BlogApp.CrudWebApi
{
    public class BlogDto
    {
        public string Name { get; set; }
        public Guid AuthodId { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<PostDto> Posts { get; set; }
    }
}
