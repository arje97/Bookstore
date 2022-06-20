using Core.Application.Dtos;
using Core.Application.Interfaces.Repositories;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;


namespace Core.Application.Validations
{
    public class UpdateBookDtoValidator : AbstractValidator<UpdateBookDto>
    {
        private readonly IBookRepository bookRepository;

        public UpdateBookDtoValidator(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;

            RuleFor(x => x.AuthorId)
          .NotEmpty().WithMessage("აირჩიეთ ")
          .Must(CheckAuthorId).WithMessage("მითითებული AuthorId არ არსებობს");
        }


        private bool CheckAuthorId(int authorId)
        {
            return bookRepository.Existed(authorId);
        }
    }
}
