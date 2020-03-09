using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WarShip.DTOs;

namespace WarShip.DBContext
{
    public class Context: DbContext
    {
        public Context()
        {
            Database.EnsureCreated();
        }
        public DbSet<Player> Players { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NVDGPN3;Database=WarShip;Trusted_connection=true;");
        }
    }
}
