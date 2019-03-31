using System;
using System.Collections.Generic;

namespace BlogApp.Domain
{
    public class Blog
    {
        public string Name { get; set; }
        public Guid AuthodId { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public List<Post> Post { get; set; }
        public List<string> Tags { get; set; }
    }
}
