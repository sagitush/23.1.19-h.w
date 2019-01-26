using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h.w_23._1._19_1
{

    [DebuggerDisplay("{model} {(price*3.67)}$")]

    class computer1
    {

        public string model;
        public int price;
        public int numberOfProcessors;
        public float screenSize;
        public bool isTurnOn;

        public int TellMeThePrice()
        {
            return price;
        }
        public float TellMeTheScreenSize()
        {
            return screenSize;
        }
        public void TurnOn()
        {
            Console.WriteLine("The computer is on");

        }
        public void TurnOff()
        {
            Console.WriteLine("The computer is off");

        }
        public void AddProcessor()
        {
            Console.WriteLine("You add another processor");
        }
        public override string ToString()
        {
            return $"Model={model},Price={price},Number of processors={numberOfProcessors},Screen size={screenSize},Is turn{isTurnOn}";

        }
    }
}
