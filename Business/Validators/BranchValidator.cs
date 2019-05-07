using Domain;
using FluentValidation;

namespace BusinessLogic.Validators
{
    public class BranchValidator : AbstractValidator<Branch>, IValidator<Branch>
    {
        public BranchValidator()
        {
            // Rules go here
        }

        public bool IsValid(Branch entity)
        {
            return Validate(entity).IsValid;
        }
    }
}
