using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            string petName, city, favBand;

            Console.Write("Enter Your Pet Name:");
            petName = Console.ReadLine();

            Console.Write("Enter Your City:");
            city = Console.ReadLine();

            Console.Write("Enter Your Favoritr Band:");
            favBand = Console.ReadLine();


            Console.Write("Your password is: " + petName.Substring(0, 3) + city.Substring(0, 3) + favBand.Substring(0, 3));



        }
    }
}
