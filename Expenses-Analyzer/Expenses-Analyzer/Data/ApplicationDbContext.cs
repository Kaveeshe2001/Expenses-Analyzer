using Expenses_Analyzer.Models;
using Microsoft.EntityFrameworkCore;

namespace Expenses_Analyzer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) :base(options)
        {

        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
