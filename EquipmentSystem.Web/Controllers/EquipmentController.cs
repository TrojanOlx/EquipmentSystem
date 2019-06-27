using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using EquipmentSystem.DeviceManager;
using EquipmentSystem.DeviceManager.Dto;

namespace EquipmentSystem.Web.Controllers
{
    public class EquipmentController : Controller
    {
        private readonly IT_EquipmentAppService _equipmentAppService;

        public EquipmentController(IT_EquipmentAppService equipmentAppService)
        {
            _equipmentAppService = equipmentAppService;
        }
        // GET: Equipment
        public async Task<ActionResult> Index(GetT_EquipmentInput input)
        {
            var output = await _equipmentAppService.GetPageEquipmentsAsync(input);
            return View();
        }
    }
}