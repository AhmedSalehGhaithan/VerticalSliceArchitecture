using Microsoft.EntityFrameworkCore;
using VerticalSliceArchitecture.src.Domain.Entities;
namespace VerticalSliceArchitecture.src.Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products => Set<Product>();   
    public DbSet<Category> categories => Set<Category>();   

}
