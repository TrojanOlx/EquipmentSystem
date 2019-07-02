using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentSystem.DeviceManager.Authorization
{
    public class EquipmentAppPermissions
    {
        public const string Equipment = "Equipment.Equipment";
        public const string Equipment_CreateEquipment= "Equipment.Equipment.CreateEquipment";
        public const string Equipment_UpdateEquipment= "Equipment.Equipment.UpdateEquipment";
        public const string Equipment_DeleteEquipment= "Equipment.Equipment.DeleteEquipment";

        public const string EquipmentType = "Equipment.EquipmentType";
        public const string EquipmentType_CreateEquipmentType = "Equipment.EquipmentType.CreateEquipmentType";
        public const string EquipmentType_UpdateEquipmentType = "Equipment.EquipmentType.UpdateEquipmentType";
        public const string EquipmentType_DeleteEquipmentType = "Equipment.EquipmentType.DeleteEquipmentType";


    }
}
