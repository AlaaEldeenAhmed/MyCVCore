using BusinessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {

        }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
