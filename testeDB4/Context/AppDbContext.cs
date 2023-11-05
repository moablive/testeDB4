using Microsoft.EntityFrameworkCore;
using testeDB4.Models;

namespace testeDB4.Context;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        public DbSet<User>? Users {get; set; }
    }
