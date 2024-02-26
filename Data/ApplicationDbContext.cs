using BooksWebShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksWebShop.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
    


}
