using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using EquipmentSystem.DeviceManager;

namespace EquipmentSystem.EquipmentType.Dto
{
    [AutoMap(typeof(T_EquipmentType))]
    public class T_EquipmentTypeForEditOutputDto
    {

        /// <summary>
        ///   主键Id
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
        [Required]
        [MaxLength(16)]
        public string TypeName { get; set; }
    }
}
