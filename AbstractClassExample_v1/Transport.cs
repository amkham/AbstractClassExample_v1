using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample_v1
{
    internal abstract class Transport
    {

        abstract public void Move();

        abstract public void PitStop();

        public virtual void Print()
        {
            Console.WriteLine("This is transport");
        }

    }
}
