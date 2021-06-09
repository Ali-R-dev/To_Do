using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using To_Do.Models;

namespace To_Do.Data
{
    public class To_DoContext : DbContext
    {
        public To_DoContext (DbContextOptions<To_DoContext> options)
            : base(options)
        {
        }

        public DbSet<To_Do.Models.Tasks> Tasks { get; set; }
    }
}
