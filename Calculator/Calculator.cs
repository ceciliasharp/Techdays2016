using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public int Sum { get; set; }

        public void Add(int i)
        {
            Sum += i;
        }

        public void Substract(int i)
        {
            Sum -= 1;
        }


    }
}
