using System;

namespace ConsoleApp2
{
    interface IEngine
    {
        void Start();
        void Stop();
        int Weight { get; }
        int Power { get; }

    }
}
