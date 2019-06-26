using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace EquipmentSystem.DeviceManager
{
    public class T_EquipmentReturn: CreationAuditedEntity
    {
        /// <summary>
        /// 设备名称
        /// </summary>
        public int T_EquipmentID { get; set; }
        /// <summary>
        /// 归还人
        /// </summary>
        public string ReturnPersonnel { get; set; }
        /// <summary>
        /// 联系方式
        /// </summary>
        public string ContactWay { get; set; }

        public T_Equipment T_Equipment { get; set; }
    }
}
