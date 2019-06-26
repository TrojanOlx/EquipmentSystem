using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace EquipmentSystem.EntityFramework.Repositories
{
    public abstract class EquipmentSystemRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<EquipmentSystemDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected EquipmentSystemRepositoryBase(IDbContextProvider<EquipmentSystemDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class EquipmentSystemRepositoryBase<TEntity> : EquipmentSystemRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected EquipmentSystemRepositoryBase(IDbContextProvider<EquipmentSystemDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
