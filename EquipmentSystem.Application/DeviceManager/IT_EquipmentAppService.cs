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
        /// <summary>
        /// 根据查询条件获取设备分页列表
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        ValueTask<PagedResultDto<T_EquipmentListDto>> GetPageEquipmentsAsync(GetT_EquipmentInput input);

        /// <summary>
        /// 通过ID获取联系人的ListDto信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        ValueTask<T_EquipmentListDto> GetEquipmentByIDAsync(EntityDto input);

        /// <summary>
        /// 创建或者修改设备信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        ValueTask CreateOrUpdateEquipmentAsync(CreateOrUpdateT_EquipmenDto input);


        /// <summary>
        /// 新增设备
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        ValueTask<T_EquipmentEditDto> CreateEquipmentAsync(T_EquipmentEditDto input);

        /// <summary>
        /// 更新设备信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task UpdateEquipmentAsync(T_EquipmentEditDto input);
        /// <summary>
        /// 删除设备
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        ValueTask DeleteEquipmentAsync(EntityDto input);
        /// <summary>
        /// 批量删除设备
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task BatchDeleteEquipmentAsync(EntityDto input);

    }
}
