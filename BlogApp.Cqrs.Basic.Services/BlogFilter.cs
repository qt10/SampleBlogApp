using System;
using System.Collections.Generic;

namespace BlogApp.Cqrs.Basic.Services
{
    public class BlogFilter
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public List<string> Tags { get; set; }
    }
}
