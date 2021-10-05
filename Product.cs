using System;
using System.Collections.Generic;
using System.Text;

namespace дз____
{

    class Product
    {
        protected string name;
        protected int price;
        protected int weight;

        public Product() { }
        public Product(string _name, int _price, int _weight)
        {
            name = _name;
            price = _price;
            weight = _weight;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

    }

}
