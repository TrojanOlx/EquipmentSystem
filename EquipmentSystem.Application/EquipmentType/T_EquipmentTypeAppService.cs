using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using EquipmentSystem.DeviceManager;
using EquipmentSystem.DeviceManager.Authorization;
using EquipmentSystem.DeviceManager.Dto;
using EquipmentSystem.EquipmentType.Dto;

namespace EquipmentSystem.EquipmentType
{
    [AbpAuthorize(EquipmentAppPermissions.EquipmentType)]
    public class T_EquipmentTypeAppService : IT_EquipmentTypeAppService
    {
        private readonly IRepository<T_EquipmentType, int> _repository;

        public T_EquipmentTypeAppService(IRepository<T_EquipmentType, int> repository)
        {
            _repository = repository;
        }



        public async ValueTask<PagedResultDto<T_EquipmentTypeListDto>> GetPagedEquipmentTypeAsync(GetT_EquipmentTypeInput input)
        {
            var query = _repository.GetAll();

            var count = await query.CountAsync();

            var types = await query
                .OrderBy(input.Sorting)
                .PageBy(input)
                .ToListAsync();


            var typesDto = types.MapTo<List<T_EquipmentTypeListDto>>();

            return new PagedResultDto<T_EquipmentTypeListDto>(count, typesDto);
        }

        public async ValueTask<IEnumerable<T_EquipmentTypeListDto>> GetEquipmentTypeAllAsync()
        {
            var query = _repository.GetAll();
            var count = await query.CountAsync();
            var types = await query.ToListAsync();
            var typesDto = types.MapTo<List<T_EquipmentTypeListDto>>();
            return typesDto;
        }


        public async ValueTask GetEquipmentTypeForEditOutput1Async(CreateOrUpdateEquipmentTypeInput input)
        {
            var query = _repository.GetAll();
            var count = await query.CountAsync();
            var types = await query.ToListAsync();
            var typesDto = types.MapTo<List<T_EquipmentTypeListDto>>();
            
        }


        public async ValueTask<GetT_EquipmentTypeForEditOutput> GetEquipmentTypeForEditOutputAsync(NullableIdDto<int> input)
        {
            var output = new GetT_EquipmentTypeForEditOutput();
            T_EquipmentTypeForEditOutputDto quipmentTypeForEditOutputDto;

            if (input.Id.HasValue)
            {
                var entity = await _repository.GetAsync(input.Id.Value);
                quipmentTypeForEditOutputDto = entity.MapTo<T_EquipmentTypeForEditOutputDto>();
            }
            else
            {
                quipmentTypeForEditOutputDto = new T_EquipmentTypeForEditOutputDto();
            }

            output.EquipmentTypeForEditOutput = quipmentTypeForEditOutputDto;
            return output;
        }

        public async ValueTask<T_EquipmentListDto> GetEquipmentTypeByIdAsync(EntityDto input)
        {
            var entity = await _repository.GetAsync(input.Id);
            return entity.MapTo<T_EquipmentListDto>();
        }



        public async ValueTask CreateOrUpdateEquipmentTypeAsync(CreateOrUpdateEquipmentTypeInput input)
        {
            if (input.EquipmentTypeForEditOutputDto.Id.HasValue)
            {
                await UpdateEquipmentTypeAsync(input.EquipmentTypeForEditOutputDto);
            }
            else
            {
                await CreateEquipmentTypeAsync(input.EquipmentTypeForEditOutputDto);
            }
        }

        [AbpAuthorize(EquipmentAppPermissions.EquipmentType_CreateEquipmentType)]
        public async Task<T_EquipmentTypeForEditOutputDto> CreateEquipmentTypeAsync(T_EquipmentTypeForEditOutputDto input)
        {
            try
            {
                var entity = await _repository.InsertAsync(input.MapTo<T_EquipmentType>());
                return entity.MapTo<T_EquipmentTypeForEditOutputDto>();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            //var entity = await _repository.InsertAsync(input.MapTo<T_EquipmentType>());
            //return entity.MapTo<T_EquipmentTypeForEditOutputDto>();
        }

        [AbpAuthorize(EquipmentAppPermissions.EquipmentType_UpdateEquipmentType)]
        public async Task UpdateEquipmentTypeAsync(T_EquipmentTypeForEditOutputDto input)
        {
            var entity = await _repository.GetAsync(input.Id.Value);
            if (entity == null)
            {
                throw new AbandonedMutexException("不存在这个对象");
            }
            await _repository.UpdateAsync(input.MapTo<T_EquipmentType>());
        }

        [AbpAuthorize(EquipmentAppPermissions.EquipmentType_DeleteEquipmentType)]
        public async Task DeleteEquipmentTypeAsync(EntityDto input)
        {
            var entity = await _repository.GetAsync(input.Id);
            if (entity == null)
            {
                throw new AbandonedMutexException("不存在这个对象");
            }
            await _repository.DeleteAsync(input.Id);
        }

        [AbpAuthorize(EquipmentAppPermissions.EquipmentType_DeleteEquipmentType)]
        public async Task BatchDeleteEquipmentTypeAsync(IEnumerable<int> input)
        {
            await _repository.DeleteAsync(x => input.Contains(x.Id));
        }
    }
}
