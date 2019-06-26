using System.Web.Mvc;

namespace EquipmentSystem.Web.Controllers
{
    public class AboutController : EquipmentSystemControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}