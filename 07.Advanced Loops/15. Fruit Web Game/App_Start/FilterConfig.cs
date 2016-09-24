using System.Web;
using System.Web.Mvc;

namespace _15.Fruit_Web_Game
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
