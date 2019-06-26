using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using EquipmentSystem.EntityFramework;

namespace EquipmentSystem
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(EquipmentSystemCoreModule))]
    public class EquipmentSystemDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<EquipmentSystemDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
