// File: Domain/FizzValidator.cs
namespace FizzBuzz.Domain.Validators
{
    using System.Collections.Generic;
    using System.Linq;

    public class FizzValidator : IValidator
    {
        public string Message => Say.Fizz;

        public List<Divisor> Divisors { get; set; }

        public FizzValidator()
        {
            Divisors = new List<Divisor> { Divisor.Fizz };
        }

        public bool Validate(int index)
        {
            return Divisors.All(d => index % (int)d == 0);
        }
    }
}
