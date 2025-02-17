using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sale_laptop_online.Models;

namespace Sale_laptop_online.Data
{
    public class Sale_laptop_onlineContext : DbContext
    {
        public Sale_laptop_onlineContext (DbContextOptions<Sale_laptop_onlineContext> options)
            : base(options)
        {
        }

        public DbSet<Sale_laptop_online.Models.Laptop> Laptop { get; set; } = default!;
    }
}
