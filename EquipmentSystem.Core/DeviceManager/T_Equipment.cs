using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace EquipmentSystem.DeviceManager
{
    public class T_Equipment : FullAuditedEntity
    {
        [Required]
        [MaxLength(EquipmentConsts.MaxNoLength)]
        public string EquipmentNumber { get; set; }

        [Required]
        [MaxLength(EquipmentConsts.MaxNoLength)]
        public string EquipmentName { get; set; }

        [Required]
        public DateTime ProductionDateTime { get; set; }

        [Required]
        public DateTime BuyDateTime { get; set; }

        [Required]
        public int Status { get; set; }

        public string Image { get; set; }
        /// <summary>
        /// 类型ID
        /// </summary>
        public int T_EquipmentTypeID { get; set; }
        /// <summary>
        /// 类型表
        /// </summary>
        public virtual T_EquipmentType T_EquipmentType { get; set; }

        public ICollection<T_EquipmentMaintenance> T_EquipmentMaintenances { get; set; }

        public ICollection<T_EquipmentScrapping> T_EquipmentScrappings { get; set; }

        public ICollection<T_EquipmentLend> T_EquipmentLends { get; set; }

        public ICollection<T_EquipmentReturn> T_EquipmentReturns { get; set; }

    }
}
