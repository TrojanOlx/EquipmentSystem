using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using EquipmentSystem.Authorization;
using EquipmentSystem.DeviceManager;
using EquipmentSystem.DeviceManager.Authorization;
using EquipmentSystem.DeviceManager.Dto;
using EquipmentSystem.EquipmentType;

namespace EquipmentSystem.Web.Controllers
{
    //[AbpMvcAuthorize(EquipmentAppPermissions.Equipment)]
    public class EquipmentController : Controller
    {
        private readonly IT_EquipmentAppService _equipmentAppService;
        private readonly IT_EquipmentTypeAppService _equipmentTypeAppService;

        public EquipmentController(IT_EquipmentAppService equipmentAppService, IT_EquipmentTypeAppService equipmentTypeAppService)
        {
            _equipmentAppService = equipmentAppService;
            _equipmentTypeAppService = equipmentTypeAppService;
        }

        public class EnumModel
        {
            public int Value { get; set; }
            public string Name { get; set; }
        }
        // GET: Equipment
        public async Task<ActionResult> Index(GetT_EquipmentInput input)
        {
            var output = await _equipmentAppService.GetPageEquipmentsAsync(input);


            //设备状态
            var equipmentStatus = Enum.GetValues(typeof(EquipmentStatus)).Cast<EquipmentStatus>().Select(item => new EnumModel()
            {
                Value = (int)item,
                Name = item.ToString()
            });


            //var equipmentStatus = Enum.GetValues(typeof(EquipmentStatus)).Cast<EquipmentStatus>()
            //    .Select(item => new Tuple<int, string>((int)item, item.ToString()));


            ViewBag.EquipmentStatusList = equipmentStatus;


            // 设备类型
            var types = await _equipmentTypeAppService.GetEquipmentTypeAllAsync();

            
            ViewBag.EquipmentTypesList = types;


            return View(output);
        }

        public ActionResult Test()
        {

            return View();
        }
    }
}