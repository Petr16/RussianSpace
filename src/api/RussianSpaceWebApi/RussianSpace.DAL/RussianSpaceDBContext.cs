﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RussianSpace.DAL.Entities;

namespace RussianSpace.DAL
{
    public class RussianSpaceDBContext : DbContext
    {
        public DbSet<Request> Requests { get; set; }

        public RussianSpaceDBContext(DbContextOptions<RussianSpaceDBContext> options) : base(options) 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //для теста напряму пока отсюда цепляться буду, но в будущем все будет через appsettings.json
            optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Username=postgres;Password=Rus77!;Database=RussianSpaceDB;Timeout=30;Enlist=false");
            optionsBuilder.UseSnakeCaseNamingConvention();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("RussianSpaceSchema");
        }

    }
}
