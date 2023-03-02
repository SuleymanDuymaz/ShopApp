using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EFProductDal());

            foreach (var item in productManager.Get())
            {
                Console.WriteLine(item.ProductName);

            }


        }
    }
}
