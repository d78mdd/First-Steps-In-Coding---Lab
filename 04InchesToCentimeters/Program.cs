using System;

namespace _04InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double chislo = double.Parse(Console.ReadLine());

            double result = chislo * 2.54;

            Console.WriteLine(result);
        }
    }
}
