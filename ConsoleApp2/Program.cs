using System;

namespace ConsoleApp2
{
    internal class Program
    {

        static void Main()
        {
            Rocket rocket = new Rocket();
            rocket.Header = new RocketHeader();

            rocket.Engine = new Engine.BugurtEngine();
            Console.WriteLine("бугрутная тяга: " + NassaMethod(rocket.Engine.Power, rocket.Weight));
            rocket.Engine = new Engine.DizelEngine();
            Console.WriteLine("дизилная тяга: " + NassaMethod(rocket.Engine.Power, rocket.Weight));
            Console.ReadKey();
        }
        public static int NassaMethod(int power, int mass)
        {
            return (mass / power * 10) + 85;
        }

    }
}
