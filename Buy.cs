using System;
using System.Collections.Generic;
using System.Text;

namespace дз____
{
    class Buy : Product
    {
        int number_of_onebought;
        int price_of_all;

        public Buy() { }
        public Buy(string _name, int _price, int _weight, int _number_of_onebought, int _price_of_all)
        {
            number_of_onebought = _number_of_onebought;
            price_of_all = _price_of_all;
        }

        public int Number
        {
            get
            {
                return number_of_onebought;
            }

            set
            {
                number_of_onebought = value;
            }
        }

        public int All_price
        {
            get
            {
                return price_of_all;
            }

            set
            {
                price_of_all = value;
            }
        }


        public void input()
        {
            Console.WriteLine("\nYour product:");
            name = Console.ReadLine();
            Console.WriteLine("\nYour price:");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nYour weight:");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nNumber of one_bought:");
            number_of_onebought = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPrice of all of the product:");
            price_of_all = Convert.ToInt32(Console.ReadLine());
        }

        public void output()
        {
            Console.WriteLine("Product:");
            Console.WriteLine(name);
            Console.WriteLine("\nPrice:");
            Console.WriteLine(price);
            Console.WriteLine("\nWeight:");
            Console.WriteLine(weight);
            Console.WriteLine("\nNumber of one by one:");
            Console.WriteLine(number_of_onebought);
            Console.WriteLine("\nPrice of all:");
            Console.WriteLine(price_of_all);
        }
    }

}
