using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample_v1
{
    internal class Car : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Move");
        }

        public override void PitStop()
        {
            Console.WriteLine("PitStop");
        }

        
    }
}
