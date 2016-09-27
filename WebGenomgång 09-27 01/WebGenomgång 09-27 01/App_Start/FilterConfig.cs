using System.Web;
using System.Web.Mvc;

namespace WebGenomgång_09_27_01
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
