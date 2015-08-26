using System.Web;
using System.Web.Mvc;

namespace Exercice1_Projet_S_VideoStore
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}