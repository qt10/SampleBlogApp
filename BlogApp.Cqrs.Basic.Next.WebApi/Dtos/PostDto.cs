using System;
using System.Collections.Generic;

namespace BlogApp.Cqrs.Basic.Next.WebApi.Controllers
{
    public class PostDto
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public List<string> Tags { get; set; }
    }
}
