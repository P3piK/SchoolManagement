﻿using Microsoft.EntityFrameworkCore;
using SchoolManagement.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Data
{
    public class SmContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseGroup> CourseGroups { get; set; }

        public SmContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}
