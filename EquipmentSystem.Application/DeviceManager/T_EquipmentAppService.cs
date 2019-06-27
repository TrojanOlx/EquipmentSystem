using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using EquipmentSystem.DeviceManager.Dto;
using EquipmentSystem.DeviceManager.EquipmentService;

namespace EquipmentSystem.DeviceManager
{
    public class T_EquipmentAppService: EquipmentSystemAppServiceBase, IT_EquipmentAppService
    {
        private readonly IRepository<T_Equipment, int> _repository;
        private readonly T_EquipmentManager _manager;

        public T_EquipmentAppService(IRepository<T_Equipment,int> repository, T_EquipmentManager manager)
        {
            _repository = repository;
            _manager = manager;
        }
        public async ValueTask<PagedResultDto<T_EquipmentListDto>> GetPageEquipmentsAsync(GetT_EquipmentInput input)
        {
            var query = _repository.GetAll();
            var count=await query.CountAsync();

            var equipment = await query
            .OrderBy(input.Sorting)
            .PageBy(input)
            .ToListAsync();

            var listDtos = equipment.MapTo<List<T_EquipmentListDto>>();
            return  new PagedResultDto<T_EquipmentListDto>(count,listDtos);
        }


        public async ValueTask<T_EquipmentListDto> GetEquipmentByIDAsync(EntityDto input)
        {
            var entity = await _repository.GetAsync(input.Id);
            return entity.MapTo<T_EquipmentListDto>();
        }
    }
}
