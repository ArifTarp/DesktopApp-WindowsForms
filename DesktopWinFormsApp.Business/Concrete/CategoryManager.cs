using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopWinFormsApp.Business.Abstract;
using DesktopWinFormsApp.DataAccess.Abstract;
using DesktopWinFormsApp.Entity.Concrete;

namespace DesktopWinFormsApp.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
