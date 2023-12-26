using System.Web;
using System.Web.Mvc;

namespace RainbowSchoolManagement
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
