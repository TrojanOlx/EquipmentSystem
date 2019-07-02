using System.Threading.Tasks;
using System.Web.Mvc;
using EquipmentSystem.EquipmentType;
using EquipmentSystem.EquipmentType.Dto;

namespace EquipmentSystem.Web.Controllers
{
    public class EquipmentTypeController : Controller
    {
        private readonly IT_EquipmentTypeAppService _service;

        public EquipmentTypeController(IT_EquipmentTypeAppService service)
        {
            _service = service;
        }
        // GET: EquipmentType
        public async Task<ActionResult> Index(GetT_EquipmentTypeInput input)
        {
            var output = await _service.GetPagedEquipmentTypeAsync(input);
            return View(output);
        }
    }
}