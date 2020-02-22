using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_159
{
    class Addition
    {
        //1.
        public int MathAdd(int x)
        {
            x = x + 2;
            return x;
        }

        //2. 4.
        public int MathAdd(int x) //take in int and show same int to screen & take in decimal and display as decimal
        {
            return x;
        }

        //3.6.
        public decimal MathAdd(decimal y) //take in a decimal and convert answer to int
        {
            y = y + 2;
            decimal newVar1 = Convert.ToInt32(y);
            return y;
        }
        //5.
        public string MathAdd(string z) //take in a string and convert answer to int
        {
            var newVar = Convert.ToInt32(z);
        }

    }
}