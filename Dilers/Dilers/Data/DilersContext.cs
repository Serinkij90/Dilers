using Dilers.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dilers.Data
{
    public class DilerContext : DbContext
    {
        public DbSet<Diler> Dilers { get; set; }
        public DilerContext(DbContextOptions<DilerContext> options) : base(options)
        {

        }
    }

    
}
