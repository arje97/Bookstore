using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Models
{
  public  class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TotalPage { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }


    }
}
