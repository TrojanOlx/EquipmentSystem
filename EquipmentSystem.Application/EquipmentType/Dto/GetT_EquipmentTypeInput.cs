using Abp.Runtime.Validation;
using EquipmentSystem.Dto;

namespace EquipmentSystem.EquipmentType.Dto
{
    public class GetT_EquipmentTypeInput : PagedAndSortedInputDto, IShouldNormalize
    {
        /// <summary>
        /// 模糊查询参数
        /// </summary>
        public string FilterText { get; set; }

        /// <summary>
        /// 用于排序的默认值
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {


                Sorting = "Id";
            }
        }
    }
}
