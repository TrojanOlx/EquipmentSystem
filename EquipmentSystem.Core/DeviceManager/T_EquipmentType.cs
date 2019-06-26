using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace EquipmentSystem.DeviceManager
{
    public class T_EquipmentType : CreationAuditedEntity
    {
        /// <summary>
        /// 类型名称
        /// </summary>
        [Required]
        [MaxLength(16)]
        public string TypeName { get; set; }

        public virtual ICollection<T_Equipment> T_Equipments { get; set; }
    }
}
