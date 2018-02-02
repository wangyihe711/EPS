﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EPS.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DataModelContainer : DbContext
    {
        public DataModelContainer()
            : base("name=DataModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<PatrolScheme> PatrolScheme { get; set; }
        public virtual DbSet<Dictionary> Dictionary { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<AcquisitionRecord> AcquisitionRecord { get; set; }
        public virtual DbSet<PatrolReport> PatrolReport { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<County> County { get; set; }
        public virtual DbSet<PatrolPoint> PatrolPoint { get; set; }
        public virtual DbSet<PatrolRoute> PatrolRoute { get; set; }
        public virtual DbSet<PatrolDefect> PatrolDefect { get; set; }
    }
}
