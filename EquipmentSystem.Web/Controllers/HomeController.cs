using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace EquipmentSystem.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : EquipmentSystemControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}