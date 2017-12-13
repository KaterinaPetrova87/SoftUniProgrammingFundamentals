using System;

namespace p03_PokeMon
{
    public class PokeMon
    {
        public static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int count = 0;
            int firstPokePower = pokePower;

            while(pokePower >= distance)
            {
                pokePower -= distance;
                count++;
                if(pokePower == firstPokePower / 2 && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(count);
        }
    }
}
