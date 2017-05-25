using System.Linq;
using System.Web.Mvc;
using MRF.Web.ActionResults;

namespace MRF.Web.Controllers
{
    public class BaseController : Controller
    {
        public BetterJsonResult<T> BetterJson<T>(T model)
        {
            return new BetterJsonResult<T>() { Data = model };
        }
    }
}