// File: Domain/FizzBuzzValidator.cs
namespace FizzBuzz.Domain.Validators
{
    using System.Collections.Generic;
    using System.Linq;

    public class FizzBuzzValidator : IValidator
    {
        public string Message => Say.FizzBuzz;

        public List<Divisor> Divisors { get; set; }

        public FizzBuzzValidator()
        {
            Divisors = new List<Divisor> { Divisor.Fizz, Divisor.Buzz };
        }

        public bool Validate(int index)
        {
            return Divisors.All(d => index % (int)d == 0);
        }
    }
}
