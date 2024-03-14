using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Data;

public class DataContext : DbContext
{
    public DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DINKZ;Database=REBORN;User Id=sa;Password=Dev$123;Encrypt=False");
    }
}
