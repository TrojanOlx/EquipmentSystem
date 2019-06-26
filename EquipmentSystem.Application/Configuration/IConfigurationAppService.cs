using System.Threading.Tasks;
using Abp.Application.Services;
using EquipmentSystem.Configuration.Dto;

namespace EquipmentSystem.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}