using CarInsurance.Models;
using Microsoft.EntityFrameworkCore;

namespace CarInsurance.Data
{
    public class InsureeContext : DbContext
    {
        public InsureeContext(DbContextOptions<InsureeContext> options) : base(options)
        {
            
        }
        public DbSet<Insuree> Insuree { get; set; }

    }
}
