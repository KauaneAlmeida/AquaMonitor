using Microsoft.EntityFrameworkCore;

namespace aqua_monitor.Models;

public class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options)
{
    public DbSet<UserModel> UserModel { get; init; }
}