using CareApp.Models;
using Microsoft.EntityFrameworkCore;


namespace CareApp.Data
{
    public class CareAppDbContext :DbContext 
    {
        public DbSet<ATask> Tasks { get; set; }
        public CareAppDbContext (DbContextOptions<CareAppDbContext> options) : base(options)
        {

        }
    }
}
