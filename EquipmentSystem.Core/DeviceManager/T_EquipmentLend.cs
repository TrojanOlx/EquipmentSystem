using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace EquipmentSystem.DeviceManager
{
    public class T_EquipmentLend:FullAuditedEntity
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public int T_EquipmentID { get; set; }
        /// <summary>
        /// 借用人
        /// </summary>
        public string LendPersonnel { get; set; }
        /// <summary>
        /// 联系方式
        /// </summary>
        public string ContactWay { get; set; }

        public T_Equipment T_Equipment { get; set; }
    }
}
