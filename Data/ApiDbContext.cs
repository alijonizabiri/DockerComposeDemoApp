using DockerComposeDemoApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerComposeDemoApp.Data;

public class ApiDbContext(DbContextOptions<ApiDbContext> options) : DbContext(options)
{
    public DbSet<Driver> Drivers { get; set; }
}
