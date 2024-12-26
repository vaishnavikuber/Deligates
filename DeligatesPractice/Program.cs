using System;

namespace DeligatesPractice
{
    internal class Program
    {
        public delegate void PrintMessage(string message);

        public delegate int CalculatorDel(int a, int b);

        static void Main(string[] args)
        {
            Methods m= new Methods();


            //PrintMessage printDel = new PrintMessage(m.Message);
            //printDel("hiii,Hello");

            //PrintMessage print = m.ConsoleMessage;
            //print = print + m.PrintMessage;

            //print("Hii, Hello");

            Calculator c = new Calculator();
            CalculatorDel addition = c.Addition;
            Console.WriteLine("Addition: "+ addition(2, 4));

            CalculatorDel sub = c.Substarction;
            Console.WriteLine("Substraction: " + sub(2, 4));

            CalculatorDel mul = c.Multiplication;
            Console.WriteLine("Multiplication: " + mul(2, 4));

            CalculatorDel div = c.Division;
            Console.WriteLine("Division: " + div(2, 4));

            CalculatorDel mod = c.Modulus;
            Console.WriteLine("Remainder: " + mod(2, 4));


        }
    }
}
