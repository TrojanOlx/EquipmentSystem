using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EquipmentSystem.Roles.Dto;
using EquipmentSystem.Users.Dto;

namespace EquipmentSystem.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}