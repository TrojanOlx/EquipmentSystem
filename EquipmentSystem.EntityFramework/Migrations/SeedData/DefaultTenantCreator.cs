using System.Linq;
using EquipmentSystem.EntityFramework;
using EquipmentSystem.MultiTenancy;

namespace EquipmentSystem.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly EquipmentSystemDbContext _context;

        public DefaultTenantCreator(EquipmentSystemDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
