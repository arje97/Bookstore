using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Models
{
  public  class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; } 
        public List<Book> Books { get; set; }
    }
}
