﻿using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using EquipmentSystem.Authorization.Roles;
using EquipmentSystem.Authorization.Users;
using EquipmentSystem.DeviceManager;
using EquipmentSystem.MultiTenancy;

namespace EquipmentSystem.EntityFramework
{
    public class EquipmentSystemDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        public IDbSet<T_Equipment> T_Equipment { get; set; }

        public IDbSet<T_EquipmentType> T_EquipmentType { get; set; }

        public IDbSet<T_EquipmentMaintenance> T_EquipmentMaintenance { get; set; }

        public IDbSet<T_EquipmentScrapping> T_EquipmentScrapping { get; set; }

        public IDbSet<T_EquipmentLend> T_EquipmentLend { get; set; }

        public IDbSet<T_EquipmentReturn> T_EquipmentReturn { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public EquipmentSystemDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in EquipmentSystemDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of EquipmentSystemDbContext since ABP automatically handles it.
         */
        public EquipmentSystemDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public EquipmentSystemDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public EquipmentSystemDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
