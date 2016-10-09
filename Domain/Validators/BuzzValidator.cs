// File: Domain/BuzzValidator.cs
namespace FizzBuzz.Domain.Validators
{
    using System.Collections.Generic;
    using System.Linq;

    public class BuzzValidator : IValidator
    {
        public string Message => Say.Buzz;

        public List<Divisor> Divisors { get; set; }

        public BuzzValidator()
        {
            Divisors = new List<Divisor> { Divisor.Buzz };
        }

        public bool Validate(int index)
        {
            return Divisors.All(d => index % (int)d == 0);
        }
    }
}
