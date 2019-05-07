using Domain;
using FluentValidation;

namespace BusinessLogic.Validators
{
    public class UserValidator : AbstractValidator<User>, IValidator<User>
    {
        public UserValidator()
        {
            // Rules go here
        }

        public bool IsValid(User entity)
        {
            return Validate(entity).IsValid;
        }
    }
}
