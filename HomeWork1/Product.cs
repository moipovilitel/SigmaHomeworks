﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Product
    {
        private string name;
        private decimal price;
        private decimal weight;

        public decimal Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Product() : this("none", 0, 0)
        {

        }

        public Product(string Name, decimal Price, decimal Weight)
        {
            this.Name = Name;
            this.Price = Price;
            this.Weight = Weight;
        }

        public override string ToString()
        {
            return $"Name: {name}\n" +
                $"price: {price}\n" +
                $"weight: {weight}";
        }
    }
}
