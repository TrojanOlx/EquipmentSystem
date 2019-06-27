using System;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;

namespace EquipmentSystem.DeviceManager.Dto
{
    [AutoMap(typeof(T_Equipment))]
    public class T_EquipmentListDto: FullAuditedEntity
    {
        /// <summary>
        /// 设备编号
        /// </summary>
        public string EquipmentNumber { get; set; }
        /// <summary>
        /// 设备名称
        /// </summary>
        public string EquipmentName { get; set; }
        /// <summary>
        /// 生产日期
        /// </summary>
        public DateTime ProductionDateTime { get; set; }
        /// <summary>
        /// 购买日期
        /// </summary>
        public DateTime BuyDateTime { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public EquipmentStatus Status { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// 类型表
        /// </summary>
        public virtual T_EquipmentType T_EquipmentType { get; set; }
    }
}
