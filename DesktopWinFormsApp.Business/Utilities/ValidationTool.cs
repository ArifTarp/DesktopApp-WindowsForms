using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWinFormsApp.Business.Utilities
{
    public static class ValidationTool
    {
        public static void Validate(IValidator iValidator, object entity)
        {
            var result = iValidator.Validate(entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
