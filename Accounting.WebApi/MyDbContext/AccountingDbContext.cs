using Accounting.Model.EntityLibrary.Entityes.Computers;
using Accounting.Model.EntityLibrary.Entityes.Departments;
using Accounting.Model.EntityLibrary.Entityes.HardWare;
using Accounting.Model.EntityLibrary.Entityes.Licenses;
using Accounting.Model.EntityLibrary.Entityes.Printers;
using Accounting.Model.EntityLibrary.Entityes.Users;
using Microsoft.EntityFrameworkCore;

namespace Accounting.WebApi.MyDbContext
{
    public class AccountingDbContext : DbContext
    {
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Laptop> Laptops { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<HardWare> HardWares { get; set; }
        public DbSet<GraphicsCard> GraphicsCards { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<PowerSupply> PowerSupplies { get; set; }
        public DbSet<Processor> Processors { get; set; }
        public DbSet<RAM> RAMs { get; set; }
        public DbSet<StorageDevice> StorageDevices { get; set; }

        public DbSet<License> Licenses { get; set; }
        public DbSet<OS> OSs { get; set; }
        public DbSet<Soft> Softs { get; set; }

        public DbSet<MFU> MFUs { get; set; }
        public DbSet<Printer> Printers { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<ProgrammUser> ProgrammUsers { get; set; }
    }
}