using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace EquipmentSystem.DeviceManager
{
    public class T_EquipmentScrapping:FullAuditedEntity
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public int T_EquipmentID { get; set; }
        /// <summary>
        /// 报废时间
        /// </summary>
        public DateTime ScrappingdDateTime { get; set; }
        /// <summary>
        /// 原因
        /// </summary>
        public string Cause { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public string Image { get; set; }

        public virtual T_Equipment T_Equipment { get; set; }
    }
}
