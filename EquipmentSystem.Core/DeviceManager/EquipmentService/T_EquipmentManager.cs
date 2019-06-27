using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;

namespace EquipmentSystem.DeviceManager.EquipmentService
{
    public class T_EquipmentManager:IT_EquipmentManager
    {
        private readonly IRepository<T_Equipment, int> _repository;

        public T_EquipmentManager(IRepository<T_Equipment,int> repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            throw new NotImplementedException();
        }
    }
}
