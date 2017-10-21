using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCodeFirst
{
    class SchoolDbContext : DbContext
    {
        public SchoolDbContext() : base()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolDbContext, SimpleCodeFirst.Migrations.Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("MRSIMPLE");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Standards { get; set; }

    }
}
