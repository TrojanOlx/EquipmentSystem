using Abp.Domain.Entities.Auditing;

namespace EquipmentSystem.EquipmentType.Dto
{
    public class T_EquipmentTypeListDto: CreationAuditedEntity
    {
        public string TypeName { get; set; }
    }
}
