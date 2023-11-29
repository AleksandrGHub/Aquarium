using System;

namespace Aquarium
{
    class Utility
    {
        public static int GetNumber()
        {
            int index;

            while (int.TryParse(Console.ReadLine(), out index) == false)
            {
                Console.WriteLine("Введите число!");
            }
            return index;
        }
    }
}