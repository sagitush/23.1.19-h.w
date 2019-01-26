using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H.W_23._1._19
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Computer CTX = new Computer()
            {
                model = "CTX",
                price = 2950,
                numberOfProcessors = 3,
                screenSize = 5.63f,
                isTurnOn = true
            };
            Computer Dell = new Computer
            {
                model = "Dell",
                price=3000,
                numberOfProcessors=4,
                screenSize=14.7F,
                isTurnOn=false
           
            };
            Computer KSP = new Computer
            {
                model = "KSP",
                price = 4500,
                numberOfProcessors = 2,
                screenSize = 21.8F,
                isTurnOn = true
            };
            Console.WriteLine($"The price of {CTX.model} is:{CTX.TellMeThePrice()}");
            KSP.ToString();
            Dell.ToString();
            CTX.ToString();
            Console.WriteLine($"The screen size of{Dell.model} is {Dell.TellMeTheScreenSize()}");
            KSP.AddProcessor();


        }
    }
}
