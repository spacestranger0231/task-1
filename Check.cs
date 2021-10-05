using System;
using System.Collections.Generic;
using System.Text;

namespace дз____
{
    class Check
    {
        static void Main(string[] args)
        {
            Buy products = new Buy { };
            Console.WriteLine("Input data:");
            products.input();
            Console.WriteLine("\n==================");
            Console.WriteLine("Your data:");
            Console.WriteLine("==================");
            products.output();
        }
    }
}
