using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productID = 100000521;
            product1.price = 100000;
            product1.model ="11";
            product1.brand = "Apple";
            product1.description = "Available in 3 colours";
            product1.Display();

            Product product2 = new Product(11273,"Samsung","S20",100000,"Available in 5 different colours!") ;
            product2.Display();

            Product product3 = new Product(123588,"Google", "Pixel 4", 60000);
            product3.Display();


        }
    }
}
