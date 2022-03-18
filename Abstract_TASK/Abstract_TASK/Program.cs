using System;

namespace Abstract_TASK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Washing_Machine washing_machine = new Washing_Machine("Clothes","TW-354","Bosch",589);
            Console.ReadLine();
            washing_machine.GetInfo();
            washing_machine.Use();
            washing_machine.Metal();

            Console.ReadLine();
            Woodcutter woodcutter = new Woodcutter("Wood","TR-33F","Husqvarna",178);
            woodcutter.GetInfo();
            woodcutter.Use();
            woodcutter.Metal();
            
        }
    }
}
