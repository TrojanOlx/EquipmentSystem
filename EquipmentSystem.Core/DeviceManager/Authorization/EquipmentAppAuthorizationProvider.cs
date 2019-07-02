using Abp.Authorization;
using EquipmentSystem.Authorization;
using Abp.Localization;

namespace EquipmentSystem.DeviceManager.Authorization
{
    public class EquipmentAppAuthorizationProvider:AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            var pages = context.GetPermissionOrNull(PermissionNames.Pages) ??
                        context.CreatePermission(PermissionNames.Pages, L("Pages"));

            var equipment = pages.CreateChildPermission(EquipmentAppPermissions.Equipment, L("Equipment"));
            equipment.CreateChildPermission(EquipmentAppPermissions.Equipment_CreateEquipment, L("CreateEquipment"));
            equipment.CreateChildPermission(EquipmentAppPermissions.Equipment_UpdateEquipment, L("UpdateEquipment"));
            equipment.CreateChildPermission(EquipmentAppPermissions.Equipment_DeleteEquipment, L("DeleteEquipment"));


            var equipmentType = pages.CreateChildPermission(EquipmentAppPermissions.EquipmentType, L("EquipmentType"));
            equipmentType.CreateChildPermission(EquipmentAppPermissions.EquipmentType_CreateEquipmentType, L("CreateEquipmentType"));
            equipmentType.CreateChildPermission(EquipmentAppPermissions.EquipmentType_UpdateEquipmentType, L("UpdateEquipmentType"));
            equipmentType.CreateChildPermission(EquipmentAppPermissions.EquipmentType_DeleteEquipmentType, L("DeleteEquipmentType"));


        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, EquipmentSystemConsts.LocalizationSourceName);
        }
    }
}
