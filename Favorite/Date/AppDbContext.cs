﻿using favorite.Entitys;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace favorite.Date;
public class AppDbContext :DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    public DbSet<User>  Users { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Tasde> Tasde { get; set; }

}
