using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EquipmentSystem.MultiTenancy.Dto;

namespace EquipmentSystem.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
