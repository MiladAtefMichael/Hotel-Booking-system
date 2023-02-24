﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HotelBookingDAL.Models
{
    public partial class HotelBookingContext : DbContext
    {
        public HotelBookingContext()
        {
        }

        public HotelBookingContext(DbContextOptions<HotelBookingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<branch> branches { get; set; }
        public virtual DbSet<resident> residents { get; set; }
        public virtual DbSet<resident_room> resident_rooms { get; set; }
        public virtual DbSet<room> rooms { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<resident>(entity =>
            {
                entity.Property(e => e.nationalID).ValueGeneratedNever();
            });

            modelBuilder.Entity<resident_room>(entity =>
            {
                entity.HasOne(d => d.resident)
                    .WithMany(p => p.resident_rooms)
                    .HasForeignKey(d => d.resident_nationalID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_resident_rooms_resident");

                entity.HasOne(d => d.room)
                    .WithMany(p => p.resident_rooms)
                    .HasForeignKey(d => d.room_id)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_resident_rooms_room");
            });

            modelBuilder.Entity<room>(entity =>
            {
                entity.HasOne(d => d.branch)
                    .WithMany(p => p.rooms)
                    .HasForeignKey(d => d.branch_id)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_room_branch");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}