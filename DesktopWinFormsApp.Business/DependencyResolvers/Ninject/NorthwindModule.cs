using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using DesktopWinFormsApp.Business.Abstract;
using DesktopWinFormsApp.Business.Concrete;
using DesktopWinFormsApp.DataAccess.Abstract;
using DesktopWinFormsApp.DataAccess.Concrete.EntityFramework;

namespace DesktopWinFormsApp.Business.DependencyResolvers.Ninject
{
    public class NorthwindModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();

            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
        }
    }
}
