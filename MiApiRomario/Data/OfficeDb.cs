using MiApiRomario.Models;
using Microsoft.EntityFrameworkCore;

namespace MiApiRomario.Data
{
    public class OfficeDb : DbContext
    {
        public OfficeDb (DbContextOptions<OfficeDb> options) : base(options) 
        {
            
        }
        public DbSet<Employer> Employers => Set<Employer>();
        }
}