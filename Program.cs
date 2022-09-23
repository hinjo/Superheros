using System;

namespace ArvTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Superman superman = new Superman("Clark Kent", 3000, 1500);

            Console.WriteLine("Hello " + superman.Name + ", " + superman.FlightHeight + ", " + superman.LifeLengthYears);

            SupermanI supermanI = new SupermanI("Clark Kent", 3000, 1500);

            Console.WriteLine("Hello " + supermanI.Name + ", " + supermanI.FlightHeight + ", " + supermanI.LifeLengthYears);

        }
    }
}
