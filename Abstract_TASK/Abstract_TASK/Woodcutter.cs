using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_TASK
{
    internal class Woodcutter:Equipment
    {
        public string Cut;
        public Woodcutter(string cut,string model,string marka,int price):base(model,marka,price)
        {
            Cut = cut;
        }

        public override void Metal()
        {
            Console.WriteLine("Lagun");
        }

        public override void Use()
        {
            Console.WriteLine("Cut trees");
        }
    }
}
