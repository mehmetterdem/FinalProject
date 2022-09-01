using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategoryId(int id);
        List<Product> GetByUniPrice(decimal min,decimal max);
    }
}
