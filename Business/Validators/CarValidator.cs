using Domain;
using FluentValidation;

namespace BusinessLogic.Validators
{
    public class CarValidator : AbstractValidator<Car>, IValidator<Car>
    {
        public CarValidator()
        {
            // Rules go here
        }

        public bool IsValid(Car entity)
        {
            return Validate(entity).IsValid;
        }
    }
}
