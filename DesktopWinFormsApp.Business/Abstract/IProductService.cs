using DesktopWinFormsApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWinFormsApp.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetProductsByCategory(int categoryId);
        List<Product> GetProductsByProductName(string productName, int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
