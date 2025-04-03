using FluentValidation;

namespace NewProject.Controllers
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator() 
        {
            RuleFor(user => user.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(user => user.Email).EmailAddress().WithMessage("Invalid email");
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
