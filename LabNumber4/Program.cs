using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lab #3- Serena Tindle 
            bool ContinueOn = true;  //boolean expression
            while (ContinueOn == true)
            {
                int Num1;  //declare integers
                long fact;
               
                Console.WriteLine("Please enter a number between 1 and 10:");
                Num1 = int.Parse(Console.ReadLine()); //user input will be factored 
                fact = Num1;

                for (int i = 1; i <= Num1; i++)

                {
                    fact = (fact * i); //put in brackets, outside for loop
                }
                Console.WriteLine("Factorial of the given number is:" + fact); //output
            }
        }
    }
}
