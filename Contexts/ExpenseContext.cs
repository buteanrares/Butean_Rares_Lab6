
using Butean_Rares_Lab6.Models;
using Microsoft.EntityFrameworkCore;

namespace Butean_Rares_Lab6.Contexts
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options) : base(options)
        {
        }
        public DbSet<ExpenseDTO> Expense { get; set; }
        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }

    }
}
