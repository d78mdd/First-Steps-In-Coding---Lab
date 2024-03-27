using System;

namespace _09YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double kvadratura = double.Parse(Console.ReadLine());

            double price = 7.61 * kvadratura;

            double discount = 0.18 * price;
            double finalPrice = price - discount;
            
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");

        }
    }
}
