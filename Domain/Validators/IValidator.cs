// File: Domain/IValidator.cs
namespace FizzBuzz.Domain.Validators
{
    using System.Collections.Generic;

    public interface IValidator
    {
        string Message { get; }

        List<Divisor> Divisors { get; set; }

        bool Validate(int index);
    }
}
