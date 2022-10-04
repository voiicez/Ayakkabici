
using System;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts
{
    public class Db:DbContext
    {
        public DbSet<Ayakkabi>? Ayakkabilar { get; set; }
        public DbSet<Marka>? Markalar { get; set; }
        public DbSet<Renk>? Renkler { get; set; }

        public Db(DbContextOptions<Db> options) : base(options)
        {
            
        }

        
    }
}

