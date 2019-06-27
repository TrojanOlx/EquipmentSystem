using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Runtime.Validation;
using EquipmentSystem.Dto;

namespace EquipmentSystem.DeviceManager.Dto
{
    public class GetT_EquipmentInput: PagedAndSortedInputDto, IShouldNormalize
    {
        /// <summary>
        /// 模糊查询参数
        /// </summary>
        public string FilterText { get; set; }

        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "ID";
            }
        }
    }
}
