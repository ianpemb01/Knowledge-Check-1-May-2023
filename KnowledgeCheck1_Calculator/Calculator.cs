using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        public decimal Add(decimal first, decimal second)
        {
            return first + second;
        }

        public decimal Subtract(decimal first, decimal second)
        {
            return first - second;
        }

        public decimal Multiply(decimal first, decimal second)
        {
            return first * second;
        }

        public decimal Divide(decimal first, decimal second)
        {
            return first / second;
        }
    }
}
