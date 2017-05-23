using System.Linq;
using System.Web.Mvc;
using MRF.Web.ActionResults;

namespace MRF.Web.Controllers
{
    public class BaseController : Controller
    {
        protected BetterJsonResult JsonValidationError()
        {
            var result = new BetterJsonResult();

            foreach (var validationError in ModelState.Values.SelectMany(v => v.Errors))
            {
                result.AddError(validationError.ErrorMessage);
            }
            return result;
        }

        protected BetterJsonResult JsonError(string errorMessage)
        {
            var result = new BetterJsonResult();

            result.AddError(errorMessage);

            return result;
        }

        protected BetterJsonResult<T> JsonSuccess<T>(T data)
        {
            return new BetterJsonResult<T> { Data = data };
        }
    }
}