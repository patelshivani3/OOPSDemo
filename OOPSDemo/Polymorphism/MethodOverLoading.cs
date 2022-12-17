using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo.Polymorphism
{
    internal class Addition
    {
        public int Add(int first ,int second)
        {
            return first+ second;
        }
        public float Add(int first, float second, long third)
        {
            float res = first + second + third;
            return res;
        }
        public float Add(float first, float second, float third)
        {
            float res = first + second + third;
            return res;
        }
    }
}
