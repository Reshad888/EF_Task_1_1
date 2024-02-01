using EF_Task_1_1.Entities;
using Microsoft.EntityFrameworkCore;
namespace EF_Task_1_1.Contexts;

internal class LibraryDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectString = "Data Source = DESKTOP-RH41O1K\\SQLEXPRESS;" +
            "Initial Catalog = LibraryDb;" +
            "Integrated Security = True;";
        optionsBuilder.UseSqlServer(connectString);
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<BookType> BookTypes { get; set; }
    public DbSet<Operation> Operations { get; set; }
}