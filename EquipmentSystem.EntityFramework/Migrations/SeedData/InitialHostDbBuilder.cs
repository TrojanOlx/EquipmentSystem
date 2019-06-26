using EquipmentSystem.EntityFramework;
using EntityFramework.DynamicFilters;

namespace EquipmentSystem.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly EquipmentSystemDbContext _context;

        public InitialHostDbBuilder(EquipmentSystemDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
