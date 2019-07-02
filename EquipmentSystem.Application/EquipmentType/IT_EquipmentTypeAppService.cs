using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EquipmentSystem.DeviceManager.Dto;
using EquipmentSystem.EquipmentType.Dto;

namespace EquipmentSystem.EquipmentType
{
    public interface IT_EquipmentTypeAppService:IApplicationService
    {
        /// <summary>
        /// 根据查询条件获取设备类型分页列表
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        ValueTask<PagedResultDto<T_EquipmentTypeListDto>> GetPagedEquipmentTypeAsync(GetT_EquipmentTypeInput input);

        /// <summary>
        /// 获取全部设备类型信息
        /// </summary>
        /// <returns></returns>
        ValueTask<IEnumerable<T_EquipmentTypeListDto>> GetEquipmentTypeAllAsync();

        ValueTask GetEquipmentTypeForEditOutput1Async(CreateOrUpdateEquipmentTypeInput input);

        /// <summary>
        /// 通过ID对设备类型进行进行编辑或修改 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        ValueTask<GetT_EquipmentTypeForEditOutput> GetEquipmentTypeForEditOutputAsync(NullableIdDto<int> input);

        /// <summary>
        /// 通过ID获取
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        ValueTask<T_EquipmentListDto> GetEquipmentTypeByIdAsync(EntityDto input);

        /// <summary>
        /// 新增或者编辑设备类型
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        ValueTask CreateOrUpdateEquipmentTypeAsync(CreateOrUpdateEquipmentTypeInput input);

        /// <summary>
        /// 新增设备
        /// </summary>
        Task<T_EquipmentTypeForEditOutputDto> CreateEquipmentTypeAsync(T_EquipmentTypeForEditOutputDto input);

        /// <summary>
        /// 更新设备
        /// </summary>
        Task UpdateEquipmentTypeAsync(T_EquipmentTypeForEditOutputDto input);


        /// <summary>
        /// 删除设备
        /// </summary>
        Task DeleteEquipmentTypeAsync(EntityDto input);

        /// <summary>
        /// 批量删除设备
        /// </summary>
        Task BatchDeleteEquipmentTypeAsync(IEnumerable<int> input);

    }
}
