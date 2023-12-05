using Kissland_AP1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Kissland_AP1.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Ingresos> Ingresos { get; set; }
    }
}