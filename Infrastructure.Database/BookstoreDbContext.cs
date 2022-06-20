using Core.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Database
{
    class BookstoreDbContext: DbContext
    {
        public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options) : base(options)
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }


    }
}
