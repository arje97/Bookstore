using AutoMapper;
using Core.Application.Dtos;
using Core.Application.Interfaces.Repositories;
using Core.Application.Paging;
using Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Services
{
  public  class BookService
    {
        private readonly IMapper mapper;
        private readonly IBookRepository bookRepository;
      

        public BookService( IMapper mapper,IBookRepository bookRepository
        )
        {
            this.mapper = mapper;
            this.bookRepository = bookRepository;

        }

        public IEnumerable<Book> GetAll(PageRequest pageRequest)
        {
            var res = bookRepository.GetBooksList(pageRequest,out PageResponse pageResponse);
            return res;
        }

        public void Add(AddBookDto addBooknDto)
        {
            var book = mapper.Map<Book>(addBooknDto);
             bookRepository.Add(book);

        }
        public void Update(int id, UpdateBookDto updateBookDto)
        {
            var book = mapper.Map<Book>(updateBookDto);  
            bookRepository.Update(id, book);

        }
        public void Delete(int id)
        {
            
            bookRepository.Delete(id);
        }

    }
}
