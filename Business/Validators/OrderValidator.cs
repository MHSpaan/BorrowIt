using Domain;
using FluentValidation;

namespace BusinessLogic.Validators
{
    public class OrderValidator: AbstractValidator<Order>, IValidator<Order>
    {
        public OrderValidator()
        {
            // Rules go here
        }

        public bool IsValid(Order entity)
        {
            return Validate(entity).IsValid;
        }
    }
}
