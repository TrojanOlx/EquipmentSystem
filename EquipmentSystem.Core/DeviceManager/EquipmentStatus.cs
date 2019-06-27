using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentSystem.DeviceManager
{
    public enum  EquipmentStatus
    {
        /// <summary>
        /// 空闲
        /// </summary>
        Leisure,
        /// <summary>
        /// 维修
        /// </summary>
        Maintenance,
        /// <summary>
        /// 报废
        /// </summary>
        Damage,
        /// <summary>
        /// 借出
        /// </summary>
        Loan,
    }
}
