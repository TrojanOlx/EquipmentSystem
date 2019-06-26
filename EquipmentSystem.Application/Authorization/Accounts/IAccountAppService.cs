using System.Threading.Tasks;
using Abp.Application.Services;
using EquipmentSystem.Authorization.Accounts.Dto;

namespace EquipmentSystem.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
