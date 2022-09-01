using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Concrete.InMemory;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetByUniPrice(15,20))
                Console.WriteLine(item.ProductName);
        }

    }
}

