using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Product //to make the class sttributes inaccessible to other classes access modifier private must be used.
    {
       internal int productID;
        internal string brand;
        internal string model;
        internal double price;
        internal string description;

       internal void Display()
        {
            Console.WriteLine("ID:" + productID + " Brand:" + brand + "-" + model + " Price:" + price + " "+description);
        }
        internal Product(int productID, string brand, string model, double price, string description)
        {
            Console.WriteLine("Parametrised constructor is called.");
            this.productID = productID;
            this.brand = brand;
            this.model = model;
            this.description = description;
            this.price = price;
        }
            internal Product()
        {
            Console.WriteLine("Default Constructor is called.");
        }
        internal Product (int productID,string brand, string model,int price)
        {
            Console.WriteLine("3rd constructor is called.");
            this.brand = brand;
            this.model = model;
            this.price = price;
            this.productID = productID;
        }
    }
}
