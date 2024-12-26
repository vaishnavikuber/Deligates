using System;
using System.Collections.Generic;
using System.Text;

namespace DeligatesPractice
{
    internal class Calculator
    {

        public int Addition(int a,int b)
        {
            return a + b;
        }

        public int Substarction(int a, int b)
        {
            return a - b;
        }

        public int Multiplication(int a,int b)
        {
            return a * b;
        }

        public int Division(int a, int b)
        {
            return a/b;
        }

        public int Modulus(int a,int b)
        {
            return a%b;
        }

    }
}
