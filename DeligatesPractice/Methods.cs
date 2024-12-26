using System;
using System.Collections.Generic;
using System.Text;

namespace DeligatesPractice
{
    internal class Methods
    {

        public void Message(string message)
        {
            Console.WriteLine(message);

        }


        public void ConsoleMessage(string message)
        {
            Console.WriteLine("Console: "+message);
        }

        public void PrintMessage(string message) 
        { 
        
            Console.WriteLine("print: "+message);
        }



    }
}
