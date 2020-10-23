using FernandaTron3000.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FernandaTron3000.DAL
{
    public class Context : DbContext
    {
        public Context() : base("Context"){

        }

        public DbSet<Workmanships> Workmanships { get; set; }
        public DbSet<Criteria> Criteria { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Criteria>()
                .HasMany<Criteria>(c => c.CriteriaList);
                
        }

        }
    }