using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_TASK
{
    abstract class Equipment
    {
        public string Marka;
        public string Model;
        public int Price;       
        public Equipment(string marka,string model,int price)
        {
            Marka = marka;
            Model = model;  
            Price = price;              
        }

        public abstract void Use();
        public abstract void Metal();

        public void GetInfo() 
        {

            Console.WriteLine($"Marka:{Marka},Model:{Model},Price:{Price}");
        
        }

    }
}
