using System;


namespace ConsoleApp2.Engine
{
    internal class BugurtEngine : IEngine
    {
        public int Weight { get; }
        public int Power { get; }

        public BugurtEngine()
        {
            Weight = 550;
            Power = 100;
        }

        public void Start()
        {
            Console.WriteLine("чух - чух");
        }
        public void Stop()
        {
            Console.WriteLine("Двиготель потух");
        }

    }
}
