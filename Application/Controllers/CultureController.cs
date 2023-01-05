using System.Web;
using System.Web.Mvc;

namespace Application.Controllers
{
    public class CultureController : Controller
    {
        /// <summary>
        /// 切換語系
        /// </summary>
        /// <param name="culture"></param>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        public ActionResult SetCulture(string culture, string returnUrl)
        {
            Response.Cookies.Add(
                new HttpCookie("_culture")
                {
                    Value = Tools.CultureTool.GetImplementedCulture(culture)
                }
            );
            return Redirect(returnUrl);
        }
    }
}