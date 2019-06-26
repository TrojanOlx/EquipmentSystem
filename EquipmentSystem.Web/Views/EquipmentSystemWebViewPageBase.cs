using Abp.Web.Mvc.Views;

namespace EquipmentSystem.Web.Views
{
    public abstract class EquipmentSystemWebViewPageBase : EquipmentSystemWebViewPageBase<dynamic>
    {

    }

    public abstract class EquipmentSystemWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected EquipmentSystemWebViewPageBase()
        {
            LocalizationSourceName = EquipmentSystemConsts.LocalizationSourceName;
        }
    }
}