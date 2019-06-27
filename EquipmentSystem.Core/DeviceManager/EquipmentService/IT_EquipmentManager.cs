using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace EquipmentSystem.DeviceManager.EquipmentService
{
    public interface IT_EquipmentManager:IDomainService
    {
        /// <summary>
        /// 初始化
        /// </summary>
        void InitT_Equipment();
    }
}
