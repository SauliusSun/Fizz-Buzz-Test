// File: FizzBuzz.cs
namespace FizzBuzz
{
    using Domain.Validators;
    using Infrastructure.Printing;
    using System.Collections.Generic;

    internal class FizzBuzz
    {
        private static IList<IValidator> Validators = new List<IValidator> { new FizzBuzzValidator(), new FizzValidator(), new BuzzValidator() };

        static void Main()
        {
            for (int index = 1; index <= 100; index++)
            {
                foreach (var validator in Validators)
                {
                    if (validator.Validate(index))
                    {
                        PrintService.Print(validator.Message);

                        break;
                    }
                }

                PrintService.Print(index);
            }
        }
    }
}