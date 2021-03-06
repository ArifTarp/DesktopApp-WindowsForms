using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopWinFormsApp.Business.Abstract;
using DesktopWinFormsApp.Business.Utilities;
using DesktopWinFormsApp.Business.ValidationRules.FluentValidation;
using DesktopWinFormsApp.DataAccess.Abstract;
using DesktopWinFormsApp.Entity.Concrete;

namespace DesktopWinFormsApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p=>p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByProductName(string productName, int categoryId)
        {
            return _productDal.GetAll(p=>p.ProductName.ToLower().Contains(productName.ToLower()) & p.CategoryId == categoryId);
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch
            {
                throw new Exception("Delete failed");
            }
        }
    }
}
