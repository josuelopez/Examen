using System.Web;
using System.Web.Mvc;

namespace Examen_Allan_sibaja___Josue_Lopez
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}