using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BasicCalculatorWithNUnitTest.Utility;
using BasicCalculatorTest;

namespace BasicCalculatorWithNUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Select Operation:");
            string operation = Console.ReadLine();

            if (operation == "Add")
            {
                new TestClass().AddTest();
            } 
            else if (operation == "Subtract")
            {
                new TestClass().SubtractTest();
            }
            else if (operation == "Divide")
            {
                new TestClass().DivideTest();
            }
            else if (operation == "Multiply")
            {
                new TestClass().MultiplyTest();
            }
            else
            {
                throw new ArithmeticException();
            }
        }
    }
}
