using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Stuff> AllStuff { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ConnectionContext(DbContextOptions<ConnectionContext> options):base(options)
        {

        }
    }
}
