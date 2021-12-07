using EFDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccess.DataAccess
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions options) : base(options) { }
        public DbSet<ItemModel> Items { get; set; }
    }
}
