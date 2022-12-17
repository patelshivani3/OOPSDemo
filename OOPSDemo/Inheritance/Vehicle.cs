using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo.Inheritance
{
    internal class Vehicle
    {
        public string brand;
        public float price;

        public void VehicleDtails()
        {
            Console.WriteLine("Brand:{0}\t Price:{1}",brand,price);
        }
    }
}
