using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductApp.Models;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product productA = new Product();
            Product productB = new Product();

            //Entering product details

            productA.SetId(1);
            productA.SetName("product A");
            productA.SetPrice(50);
            productA.SetDiscount(21);


            productB.SetId(2);
            productB.SetName("product B");
            productB.SetPrice(100);
            productB.SetDiscount(10);

            Console.WriteLine("Product A");
            Console.WriteLine("Id : " + productA.GetId());
            Console.WriteLine("Name : " + productA.GetName());
            Console.WriteLine("Price : " + productA.GetPrice());
            Console.WriteLine("Discount : " + productA.GetDiscount());
            Console.WriteLine("Price after Discount is : " + productA.CalculateDiscount());
            
            Console.WriteLine("\nProduct B");
            Console.WriteLine("Id : " + productB.GetId());
            Console.WriteLine("Name : " + productB.GetName());
            Console.WriteLine("Price : " + productB.GetPrice());
            Console.WriteLine("Discount : " + productB.GetDiscount());
            Console.WriteLine("Price after Discount is : " + productB.CalculateDiscount());




        }
    }
}
