using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main function used to call all the methods in the program.
            Console.WriteLine(Add(9, 10));
            Console.WriteLine(Subtract(99, 10));
            Console.WriteLine(Multiply(55, 70));
            Console.WriteLine(Divide(334, 140));
            Console.ReadLine();
        }

        static decimal Add(decimal numOne, decimal numTwo)
        {
            // Takes in to decimals as parameters and returns the sum.
            return numOne + numTwo;
        }

        static decimal Subtract(decimal numOne, decimal numTwo)
        {
            // Takes in to decimals as parameters and submits the remainder. 
            return numOne - numTwo;
        }

        static decimal Multiply (decimal numOne, decimal numTwo)
        {
            //  Takes in to decimals as parameters and multiplies the two.
            return numOne * numTwo;
        }

        static decimal Divide (decimal numOne, decimal numTwo)
        {
            // Takes in two decimals as parameters and returns the quotient of the two. 
            return numOne / numTwo;
        }
    }
}
