using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_TASK
{
    internal class Washing_Machine:Equipment
    {
        public string Wash;
        public Washing_Machine(string wash, string model, string marka, int price):base(model,marka,price)
        {
            Wash = wash;
        }

        public override void Metal()
        {
            Console.WriteLine("Black Metal");
        }

        public override void Use()
        {
            Console.WriteLine("Wash clothes");
        }
    }
}
