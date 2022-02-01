using System;

namespace ConsoleApp2
{
    internal class Rocket
    {
        public RocketHeader Header { get; set; }
        public IEngine Engine { get; set; }
        public int Weight
        {
            get { return Header.GetWeight() + Engine.Weight; }

        }
    }


    class RocketHeader
    {
        public int Cosmonauts { get; private set; }
        public int MassShell { get; private set; }

        public RocketHeader()
        {
            Cosmonauts = 3;
            MassShell = 3500;
        }
        public int GetWeight() // возвращает общую массу модуля с учётом веса космонавтов
        {
            return (Cosmonauts * 80) + MassShell;
        }
       
    }
}
