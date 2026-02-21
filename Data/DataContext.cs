using appservicedemo.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace appservicedemo.Data
{
    public class DataContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions options):base(options)
        {
            
        }
    }
}
