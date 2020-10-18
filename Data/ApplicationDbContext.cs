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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
          
            builder.Entity<Users>()
                    .HasOne(m => m.Membership)
                    .WithMany(u => u.Userss) 
                    .HasForeignKey(m => m.MembershipId)
                    .HasConstraintName("FK_Users_MembershipId");
            
            builder.Entity<Users>()
                    .HasOne(t => t.Trainer)
                    .WithMany(u => u.Userss)
                    .HasForeignKey(t => t.TrainerId)
                    .HasConstraintName("FK_Users_TrainerId");
                 
            builder.Entity<Schedule>()
                    .HasOne(t=> t.Users)
                    .WithMany(t=>t.Schedules)
                    .HasForeignKey(t => t.UserId)
                    .HasConstraintName("FK_Schedule_UserId");
            builder.Entity<Schedule>()
                    .HasOne(t => t.Exercises)
                    .WithMany(t => t.Schedules)
                    .HasForeignKey(t => t.ExerciseId)
                    .HasConstraintName("FK_Schedule_ExerciseId");
            
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
