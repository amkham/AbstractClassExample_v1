using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Car car = new Car();
           Bus bus = new Bus();

            

           Transport[] transports = new Transport[10];

            transports[0] = car;
            transports[1] = bus;

            bus.Passengers = 40;


            (transports[0] as Transport).Print();
            
            Console.WriteLine((transports[1] as Bus).Passengers);


            if (transports[0] is Car)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            Console.ReadKey();
        }
    }
}
