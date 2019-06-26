using Abp.AutoMapper;
using EquipmentSystem.Sessions.Dto;

namespace EquipmentSystem.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}