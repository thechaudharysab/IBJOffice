using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBJOffice.Models
{
    public class IBJOfficeDbContext: DbContext
    {
        public IBJOfficeDbContext(DbContextOptions<IBJOfficeDbContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
