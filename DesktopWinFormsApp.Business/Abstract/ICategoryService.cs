using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopWinFormsApp.Entity.Concrete;

namespace DesktopWinFormsApp.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
