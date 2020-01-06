using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SemAjudaVideo.Models
{
    public class SemAjudaVideoContext : DbContext
    {
        public SemAjudaVideoContext (DbContextOptions<SemAjudaVideoContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Seller> Seller { get; set; }
    }
}
