﻿using System.Data.Common;
using Abp.Zero.EntityFramework;
using SimpleTaskSystem.Authorization.Roles;
using SimpleTaskSystem.MultiTenancy;
using SimpleTaskSystem.Users;

namespace SimpleTaskSystem.EntityFramework
{
    public class SimpleTaskSystemDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public SimpleTaskSystemDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in SimpleTaskSystemDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of SimpleTaskSystemDbContext since ABP automatically handles it.
         */
        public SimpleTaskSystemDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public SimpleTaskSystemDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
