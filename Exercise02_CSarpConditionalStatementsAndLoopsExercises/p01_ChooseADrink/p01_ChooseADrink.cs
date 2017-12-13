using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01_ChooseADrink
{
    class p01_ChooseADrink
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            string drink = "";

            if (profession == "Athlete")
            {
                drink = "Water";
            } 
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                drink = "Coffee";
            }
            else if (profession == "SoftUni Student")
            {
                drink = "Beer";
            }
            else
            {
                drink = "Tea";
            }
            Console.WriteLine(drink);
        }
    }
}
