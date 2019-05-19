using Dilers.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dilers.Data
{
    public class DilersContext : DbContext
    {
        public DbSet<Diler> Dilers { get; set; }
        public DilersContext(DbContextOptions<DilersContext> options) : base(options)
        {

        }
    }

    
}
