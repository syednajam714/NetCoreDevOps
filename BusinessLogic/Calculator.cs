using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }
        public int Subract(int first, int second)
        {
            return first - second;
        }
        public int Multiply(int first, int second)
        {
            return first * second;
        }

        public double Devide(int first, int second)
        {
            return first / second;
        }
    }
}
