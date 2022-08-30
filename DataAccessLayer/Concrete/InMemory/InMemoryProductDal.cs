using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
           {
               new Product{ProtuctId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitInStock=15},
               new Product{ProtuctId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitInStock=3},
               new Product{ProtuctId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitInStock=2},
               new Product{ProtuctId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitInStock=65},
               new Product{ProtuctId=1,CategoryId=1,ProductName="Mouse",UnitPrice=85,UnitInStock=1},
           };
            
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.Where(x => x.ProtuctId == product.ProtuctId).FirstOrDefault();
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products.ToList();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(x => x.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product updateToProduct = _products.FirstOrDefault(x => x.ProtuctId == product.ProtuctId);
            updateToProduct.ProductName = product.ProductName;
            updateToProduct.CategoryId = product.CategoryId;
            updateToProduct.UnitInStock = product.UnitInStock;
            updateToProduct.UnitPrice = product.UnitPrice;
        }
    }
}
