using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    class Product
    {
        private string sKU;
        private string name;
        private int quantity;
        private double price;
        private string category;

        public Product(string sKU, string name, int quantity, double price, string category)
        {
            this.sKU = sKU;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.category = category;
        }

        public string SKU { get => sKU; set => sKU = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
        public string Category { get => category; set => category = value; }
    }
}
