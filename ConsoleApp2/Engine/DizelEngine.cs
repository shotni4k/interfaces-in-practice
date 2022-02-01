using System;


namespace ConsoleApp2.Engine
{
    internal class DizelEngine : IEngine
    {
        public int Weight { get;}
        public int Power{ get;}

        public DizelEngine()
        {
            Weight = 130;
            Power = 800;
        }
        public void Start()
        {
            Console.WriteLine("чух - чух - чух");
        }
        public void Stop()
        {
            Console.WriteLine("Двиготель Заглох");
        }


    }
}
