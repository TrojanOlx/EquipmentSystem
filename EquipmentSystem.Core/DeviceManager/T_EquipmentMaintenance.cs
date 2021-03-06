﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace EquipmentSystem.DeviceManager
{
    public class T_EquipmentMaintenance : FullAuditedEntity
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public int T_EquipmentID { get; set; }
        /// <summary>
        /// 维修时间
        /// </summary>
        [Required]
        public DateTime MaintenanceDateTime { get; set; }
        /// <summary>
        /// 维修人员
        /// </summary>
        [Required]
        [MaxLength(64)]
        public string MaintenancePersonnel { get; set; }
        /// <summary>
        /// 维修状态
        /// </summary>
        [Required]
        public int MaintenanceStatus { get; set; }
        /// <summary>
        /// 维修原因
        /// </summary>
        [Required]
        public string Cause { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public string Image { get; set; }

        public virtual T_Equipment T_Equipment { get; set; }
    }
}
