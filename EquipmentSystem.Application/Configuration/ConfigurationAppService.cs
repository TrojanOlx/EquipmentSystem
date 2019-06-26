using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using EquipmentSystem.Configuration.Dto;

namespace EquipmentSystem.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : EquipmentSystemAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
