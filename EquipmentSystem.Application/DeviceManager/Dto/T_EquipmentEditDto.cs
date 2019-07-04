using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;

namespace EquipmentSystem.DeviceManager.Dto
{
    [AutoMap(typeof(T_Equipment))]
    public class T_EquipmentEditDto
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int? ID { get; set; }
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

    }
}
