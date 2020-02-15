using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudEx.Models;

namespace CrudEx.Data
{
    public class CrudExContext : DbContext
    {
        public CrudExContext (DbContextOptions<CrudExContext> options)
            : base(options)
        {
        }

        public DbSet<CrudEx.Models.Customer> Customer { get; set; }
    }
}
