using System;


namespace _08PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogPackages = int.Parse(Console.ReadLine());
            int catPackages = int.Parse(Console.ReadLine());

            double dogPackagesTotal = 2.50 * dogPackages;
            double catPackagesTotal = 4 * catPackages;

            double total = dogPackagesTotal + catPackagesTotal;

            Console.WriteLine($"{total} lv.");
        }
    }
}
