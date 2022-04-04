using MedicalStore.Models;
using MedicalStore.Utils.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace MedicalStore.Utils
{
    public class DBContext: DbContext
    {
        private IConfig Config;
        public DBContext(IConfig config)
        {
            this.Config = config;
        }

        public DbSet<User> User { set; get; }
        public DbSet<Category> Category { set; get; }
        public DbSet<Product> Product { set; get; }
        public DbSet<Order> Order { set; get; }
        public DbSet<OrderItem> OrderItem { set; get; }
        public DbSet<ReportTicket> ReportTicket { set; get; }
        public DbSet<Role> Role { set; get; }
        public DbSet<Payment> Payment { set; get; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(this.Config.GetEnvByKey("ConnectionString"));
        }

        public static async Task<Boolean> InitDatabase(IConfig config)
        {
            var dbContext = new DBContext(config);
            bool result = await dbContext.Database.EnsureCreatedAsync();
            if (result)
            {
                Console.WriteLine("Database created");
            }

            return true;
        }
    }
}
