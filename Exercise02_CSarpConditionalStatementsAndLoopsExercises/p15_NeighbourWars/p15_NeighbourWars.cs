using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p15_NeighbourWars
{
    class p15_NeighbourWars
    {
        static void Main(string[] args)
        {
            int peshosDamage = int.Parse(Console.ReadLine());
            int goshosDamage = int.Parse(Console.ReadLine());
            int peshosHealth = 100;
            int goshosHealth = 100;
            int roundCounter = 0;
            bool isPeshoAlive = true;
            bool isGoshoAlive = true;
  
            while(isPeshoAlive && isGoshoAlive)
            {
                roundCounter++;
                if (roundCounter % 2 == 1)
                {
                    goshosHealth -= peshosDamage;
                    if (goshosHealth <= 0)
                    {
                        isGoshoAlive = false;
                        continue;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health.");
                }
                else
                {
                    peshosHealth -= goshosDamage;
                    if (peshosHealth <= 0)
                    {
                        isPeshoAlive = false;
                        continue;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health.");
                }
                if (roundCounter % 3 == 0)
                {
                    peshosHealth += 10;
                    goshosHealth += 10;
                }
            }
            if (isPeshoAlive)
            {
                Console.WriteLine($"Pesho won in {roundCounter}th round.");
            }
            else
            {
                Console.WriteLine($"Gosho won in {roundCounter}th round.");
            }
        }
    }
}
