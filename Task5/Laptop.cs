using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5;

namespace Task5
{
    internal class Laptop : ElectronicDevice
    {
        public Laptop(string brand, double price) : base(brand, price)
        {
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Laptop - Brand: {Brand}, Price: {Price}");
        }

        public void TurnOnBattery()
        {
            Console.WriteLine("Laptop battery turned on.");
        }
    }
}