using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;

namespace Model
{
    public class TBOGContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Score> Scores{ get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<MonthylyReport> MonthylyReports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=blogging.db");
    }
   
   

    public class MonthylyReport
    {
        public int Id { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int AccessCount { get; set; }
        public int NewUserCount { get; set; }
    }
}