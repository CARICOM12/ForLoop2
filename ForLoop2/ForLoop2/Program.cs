using System;

namespace ForLoop2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number;
            for (number = 0; number <= 100; number = number + 1)
                Console.WriteLine("This is number: " + number);
            Console.WriteLine("Bravo! Bravissimo!");
        }
    }
}
