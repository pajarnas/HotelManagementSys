using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using SysCore.Entities;
namespace SysInfrastructure.DataContext
{
    public class HotelMSDbContext: DbContext
    {
        
        public HotelMSDbContext(DbContextOptions<HotelMSDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Customer>(ConfigureCustomer);
            modelBuilder.Entity<Service>(ConfigureService);
            modelBuilder.Entity<Room>(ConfigureRoom);
            modelBuilder.Entity<RoomType>(ConfigureRoomType);
        
        }

      
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
 

        private void ConfigureCustomer(EntityTypeBuilder<Customer> modelBuilder)
        {
            //Fluent API rules.
            modelBuilder.ToTable("Customers");
            modelBuilder.HasKey(t => t.Id);
            modelBuilder.Property(t => t.CName).HasMaxLength(20);
            modelBuilder.Property(t => t.Address).HasMaxLength(100);
            modelBuilder.Property(t => t.Phone).HasMaxLength(20);
            modelBuilder.Property(t => t.Email).HasMaxLength(40);
            modelBuilder.Property(t => t.Advance).HasColumnType("money");

            modelBuilder.HasOne(c => c.Room)
                .WithMany(r => r.Customers)
                .HasForeignKey(c => c.RoomNo);
        }
        
        private void ConfigureService(EntityTypeBuilder<Service> modelBuilder)
        {
            //Fluent API rules.
            modelBuilder.ToTable("Services");
            modelBuilder.HasKey(s => s.Id);
            modelBuilder.Property(s => s.SDesc).HasMaxLength(50);
            modelBuilder.Property(t => t.Amount).HasColumnType("money");
            
            modelBuilder.HasOne(c => c.Room)
                .WithMany(r => r.Services)
                .HasForeignKey(c => c.RoomNo);
        }
   
        private void ConfigureRoom(EntityTypeBuilder<Room> modelBuilder)
        {
            //Fluent API rules.
            modelBuilder.ToTable("Rooms");
            modelBuilder.HasKey(s => s.Id);
            
            modelBuilder.HasMany(r => r.Customers)
                .WithOne(c => c.Room);
            modelBuilder.HasMany(r => r.Services)
                .WithOne(c => c.Room);
            modelBuilder.HasOne(r => r.RoomType)
                .WithMany(c => c.Rooms);
            
        }
        
        private void ConfigureRoomType(EntityTypeBuilder<RoomType> modelBuilder)
        {
            //Fluent API rules.
            modelBuilder.ToTable("RoomTypes");
            modelBuilder.HasKey(s => s.Id);
            modelBuilder.Property(s => s.RtDesc).HasMaxLength(20);
            modelBuilder.HasMany(r => r.Rooms)
                .WithOne(c => c.RoomType);
        }
    }
}


