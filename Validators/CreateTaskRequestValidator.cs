using Assignment7.DTO;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Assignment7.Validators
{
    public class CreateTaskRequestValidator : AbstractValidator<CreateTaskRequest>
    {
        public CreateTaskRequestValidator()
        {
            RuleFor(x => x.Title)
           .NotEmpty()
           .WithMessage("Title is required");

            RuleFor(x => x.Title)
                .MaximumLength(200)
                .WithMessage("Title must not exceed 200 characters");

            RuleFor(x => x.Title)
                .Must(title => !Regex.IsMatch(title ?? "", "<[^>]*>"))
                .WithMessage("Title must not contain HTML tags");

            RuleFor(x => x.DueDate)
                .GreaterThan(DateTime.UtcNow)
                .WithMessage("Due date must be in the future");
        }

    }

}
