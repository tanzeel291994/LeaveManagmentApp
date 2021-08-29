namespace LeaveManagmentApp.Data
{
    using LeaveManagmentApp.Data.Models;
    using LeaveManagmentApp.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    public class LeaveManagmentDbContext : DbContext
    {
        public LeaveManagmentDbContext(DbContextOptions<LeaveManagmentDbContext> options)
            : base(options)
        {
        }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
