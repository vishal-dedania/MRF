using System.Web;
using System.Web.Mvc;
using MRF.Web.Utilities;

namespace MRF.Web.Helpers
{
    public static class JsonHtmlHelpers
    {
        public static IHtmlString JsonFor<T>(this HtmlHelper helper, T obj)
        {
            return helper.Raw(obj.ToJson());
        }
    }
}