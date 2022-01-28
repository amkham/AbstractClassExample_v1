using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample_v1
{
    internal class Bus : Transport
    {
        private int _passengers;
        

        public override void Move()
        {
            Console.WriteLine("Bus move");
        }

        public override void PitStop()
        {
            Console.WriteLine("Bus pitstop");
        }

  
        public int Passengers { get => _passengers; set => _passengers = value; }

        public override void Print()
        {
           Console.WriteLine("This is Bus");
        }
    }
}
