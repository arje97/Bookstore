using Core.Application.Dtos;
using Core.Application.Interfaces.Repositories;
using Core.Application.Paging;
using Core.Application.Services;
using Core.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository bookRepository;
        private readonly BookService bookService;

        public BookController(IBookRepository bookRepository, BookService bookService)
        {
            this.bookRepository = bookRepository;
            this.bookService = bookService;
        }
       // GET: api/<BookController>
        [HttpGet]
        public IActionResult Get([FromQuery] PageRequest pageRequest)
        {
            var result = bookService.GetAll(pageRequest);

         //   Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(pageResponse));

            return Ok(result);


        }

 
        // POST api/<BookController>
        [HttpPost]
        public IActionResult Post([FromBody] AddBookDto book)
        {

            bookService.Add(book);
            return Ok();
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateBookDto updateBookDto)
        {
            bookService.Update(id, updateBookDto);
            return Ok();
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            bookService.Delete(id);
        }
    }
}
