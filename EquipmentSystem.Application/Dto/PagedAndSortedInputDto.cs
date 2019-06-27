using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace EquipmentSystem.Dto
{
    public class PagedAndSortedInputDto:IPagedResultRequest,ISortedResultRequest
    {
        public PagedAndSortedInputDto()
        {
            MaxResultCount = EquipmentSystemConsts.MaxPageSize;
        }
        public int MaxResultCount { get; set; }
        public int SkipCount { get; set; }
        public string Sorting { get; set; }
    }
}
