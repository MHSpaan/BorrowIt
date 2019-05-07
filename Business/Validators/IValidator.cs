namespace BusinessLogic.Validators
{
    public interface IValidator<T>
    {
        bool IsValid(T entity);
    }
}
