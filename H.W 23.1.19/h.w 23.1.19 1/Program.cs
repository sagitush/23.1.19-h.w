using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h.w_23._1._19_1
{
    class Program
    {
        static void Main(string[] args)
        {
            computer1 CTX=new computer1
            {
                model = "CTX",
                price = 2950,
                numberOfProcessors = 3,
                screenSize = 5.63f,
                isTurnOn = true
            };
            computer1 Dell = new computer1
            {
                model = "Dell",
                price = 3000,
                numberOfProcessors = 4,
                screenSize = 14.7F,
                isTurnOn = false

            };
            computer1 KSP = new computer1
            {
                model = "KSP",
                price = 4500,
                numberOfProcessors = 2,
                screenSize = 21.8F,
                isTurnOn = true
            };
            Console.WriteLine($"The price of {CTX.model} is:{CTX.TellMeThePrice()}");
            Console.WriteLine(KSP.ToString());
            Console.WriteLine(Dell.ToString());
            Console.WriteLine(CTX.ToString());
            Console.WriteLine($"The screen size of{Dell.model} is {Dell.TellMeTheScreenSize()}");
            KSP.AddProcessor();


        }
    }
}
