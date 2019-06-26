using System.Threading.Tasks;
using Abp.Application.Services;
using EquipmentSystem.Sessions.Dto;

namespace EquipmentSystem.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
