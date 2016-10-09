// File: Infrastructure/PrintService.cs
namespace Infrastructure.Printing
{
    using System;

    public static class PrintService
    {
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static void Print(int index)
        {
            Console.WriteLine(index);
        }
    }
}
