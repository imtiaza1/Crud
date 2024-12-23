﻿using Microsoft.EntityFrameworkCore;

namespace crud_3.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options): base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
