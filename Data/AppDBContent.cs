using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using szhanakorgan.Data.Models;

namespace szhanakorgan.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent (DbContextOptions<AppDBContent> options) : base(options) { }
        public DbSet<Rooms> Room { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
