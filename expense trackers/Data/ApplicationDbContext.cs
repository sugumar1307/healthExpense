using expense_trackers.Models;
using Microsoft.EntityFrameworkCore;

namespace expense_trackers.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        { }   
        public DbSet<Category> categories { get; set; }
        public DbSet<Transcation> transcations { get; set; }
    }
}
