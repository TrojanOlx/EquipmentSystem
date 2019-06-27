using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;
using EquipmentSystem.DeviceManager.Dto;
using EquipmentSystem.Dto;

namespace EquipmentSystem.DeviceManager
{
    public interface IT_EquipmentAppService : IApplicationService
    {
        ValueTask<PagedResultDto<T_EquipmentListDto>> GetPageEquipmentsAsync(GetT_EquipmentInput input);


        ValueTask<T_EquipmentListDto> GetEquipmentByIDAsync(EntityDto input);

    }
}
