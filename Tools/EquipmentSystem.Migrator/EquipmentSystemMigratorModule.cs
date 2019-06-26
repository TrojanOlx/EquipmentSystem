using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using EquipmentSystem.EntityFramework;

namespace EquipmentSystem.Migrator
{
    [DependsOn(typeof(EquipmentSystemDataModule))]
    public class EquipmentSystemMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<EquipmentSystemDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}