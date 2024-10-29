﻿using Microsoft.EntityFrameworkCore;

namespace twotables.Models
{
    public class TutorialDbContext:DbContext
    {
         public TutorialDbContext(DbContextOptions<TutorialDbContext> options) : base(options) { }
        public DbSet<Tutorial> Tutorials { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}
