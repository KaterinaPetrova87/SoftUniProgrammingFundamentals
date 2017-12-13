using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04_Elevator
{
    class p04_Elevator
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)numOfPeople/capacityOfElevator);

            Console.WriteLine(courses);
        }
    }
}
