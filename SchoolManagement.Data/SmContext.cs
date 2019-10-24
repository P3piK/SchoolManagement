using Microsoft.EntityFrameworkCore;
using SchoolManagement.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Data
{
    public class SmContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public SmContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}
