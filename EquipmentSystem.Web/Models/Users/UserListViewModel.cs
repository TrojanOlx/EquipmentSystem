using System.Collections.Generic;
using EquipmentSystem.Roles.Dto;
using EquipmentSystem.Users.Dto;

namespace EquipmentSystem.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}