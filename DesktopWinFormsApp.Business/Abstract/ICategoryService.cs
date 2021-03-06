using DesktopWinFormsApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWinFormsApp.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
