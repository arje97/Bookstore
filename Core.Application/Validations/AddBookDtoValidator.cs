using Core.Application.Dtos;
using Core.Application.Interfaces.Repositories;
using FluentValidation;

namespace Core.Application.Validations
{
  public class AddBookDtoValidator : AbstractValidator<AddBookDto>
    {
        private readonly IBookRepository bookRepository;

        public AddBookDtoValidator(IBookRepository bookRepository)
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
