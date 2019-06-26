using Abp.Authorization;
using EquipmentSystem.Authorization.Roles;
using EquipmentSystem.Authorization.Users;

namespace EquipmentSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
