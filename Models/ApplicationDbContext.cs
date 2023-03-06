using Microsoft.EntityFrameworkCore;

namespace budget_monitor_app.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {}

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Transaction> Transactions { get; set; }


    }
}
