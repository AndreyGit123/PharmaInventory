using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PharmaInventory.Models;

namespace PharmaInventory.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PharmaItem> PharmaItem { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=InventoryDb;Trusted_Connection=True;");
        }
    }
}