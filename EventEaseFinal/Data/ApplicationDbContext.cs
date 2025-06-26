using Microsoft.EntityFrameworkCore;
using EventEaseFinal.Models;
using Microsoft.Extensions.Logging;
using System;

namespace EventEaseFinal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        public DbSet<Venue> Venues { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Venue>().ToTable("Venue");
            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<Booking>().ToTable("Booking");
            modelBuilder.Entity<EventType>().ToTable("EventType"); // NEW
        }
    }
    }
