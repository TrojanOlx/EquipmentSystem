﻿using System;
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
        /// <summary>
        /// 设备编号
        /// </summary>
        [Required]
        [MaxLength(64)]
        public string EquipmentNumber { get; set; }
        /// <summary>
        /// 设备名称
        /// </summary>
        [Required]
        [MaxLength(64)]
        public string EquipmentName { get; set; }
        /// <summary>
        /// 生产日期
        /// </summary>
        [Required]
        public DateTime ProductionDateTime { get; set; }
        /// <summary>
        /// 购买日期
        /// </summary>
        [Required]
        public DateTime BuyDateTime { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [Required]
        public EquipmentStatus Status { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
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
