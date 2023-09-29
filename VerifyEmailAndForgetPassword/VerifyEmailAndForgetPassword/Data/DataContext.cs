using Microsoft.EntityFrameworkCore;
using VerifyEmailAndForgetPassword.Models;

namespace VerifyEmailAndForgetPassword.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-VRF2530\\MSSQL2022;Initial Catalog=verifyEmailDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
        }

        public DbSet<User> Users => Set<User>();
    }
}
