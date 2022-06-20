using AutoMapper;
using Core.Application.Dtos;
using Core.Domain.Models;

namespace Core.Application.AutoMapperProfiles
{
    class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<AddBookDto, Book>();
            CreateMap<UpdateBookDto, Book>();
        }

    }
}
