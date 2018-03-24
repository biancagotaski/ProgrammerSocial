using Business.Entities;
using System;

namespace Business
{
    public class Post : EntityBase
    {
        public Post(Profile author)
        {
            Author = author;
        }
        public Profile Author { get; set; }
        public string Content { get; set; }
        public string Photo { get; set; }
        public DateTime Publication { get; set; }
    }
}