using System;
using System.Collections.Generic;
using System.Text;
using GeorgianGym.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GeorgianGym.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Users> Userss { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
