using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using EquipmentSystem.Authorization;
using EquipmentSystem.DeviceManager;
using EquipmentSystem.DeviceManager.Authorization;
using EquipmentSystem.DeviceManager.Dto;

namespace EquipmentSystem.Web.Controllers
{
    [AbpMvcAuthorize(EquipmentAppPermissions.Equipment)]
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
            return View(output);
        }
    }
}