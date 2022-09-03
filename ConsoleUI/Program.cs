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
            ProductTest();
            //CategoryTest();
            
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetProductDetails())
                Console.WriteLine(item.ProductName+"-"+item.CategoryName);
        }
    }
}

