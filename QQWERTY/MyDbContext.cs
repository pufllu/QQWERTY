using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQWERTY
{
    class MyDbContext : DbContext
    {
        public MyDbContext() : base("DbConnect")
        {

        }
        public DbSet<Client> Client { get; set; }
        public DbSet<Device> Device { get; set; }
        public DbSet<DevicePart> DevicePart { get; set; }
        public DbSet<FirstDiagnostic> firstDiagnostic { get; set; }
        public DbSet<PartsToRepair> partsToRepair { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Repair> Repair { get; set; }
        public DbSet<Specifications> Specifications { get; set; }
        public DbSet<SpecificationsOfPart> SpecificationsOfPart { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Type> Type { get; set; }
        public DbSet<Types> Types { get; set; }
        public DbSet<Worker> Worker { get; set; }

    }
}
