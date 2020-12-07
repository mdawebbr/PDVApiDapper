using Microsoft.EntityFrameworkCore;
using PdvApiDapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PdvApiDapper.Contex
{
    public class PdvContex
    {
        public class PdvContext : DbContext
        {
            public PdvContext(DbContextOptions<PdvContext> options) : base(options)
            {

            }

            public DbSet<Pdv> Pdvs { get; set; }
        }
    }
}
