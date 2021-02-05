using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Logistics.Data.Core;
using Logistics.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Logistics.Data.Context
{
    public class LogisticsContext: DbContext
    {
        public LogisticsContext()
        {

        }
        public LogisticsContext(DbContextOptions<LogisticsContext> options):base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // could not read from startup
            optionsBuilder.UseSqlServer("Server=localhost; Database=LogisticsDB;User ID=sa;Password=DSlo12DSlo12;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var parts = new List<PartEntity>();

            for (int x = 0;  x < 7;  x++)
            {
                for (int y = x*30+1; y <= x*30+30; y++)
                {
                    parts.Add(new PartEntity
                    {
                        Id = Guid.NewGuid(),
                        CreatedDate = DateTimeOffset.UtcNow,
                        PartNumber = y,
                        PartWeight = x+1,
                        PartCost = 50 + ((x+1) * 7)
                    });
                }
            }
          
            modelBuilder.Entity<PartEntity>().HasData(parts);


            modelBuilder.Entity<BoxEntity>().HasData(
                 new BoxEntity
                 {
                     Id = Guid.NewGuid(),
                     CreatedDate = DateTimeOffset.UtcNow,
                     BoxId = 123450,
                     Weight = 3,
                 },
                new BoxEntity
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTimeOffset.UtcNow,
                    BoxId = 123461,
                    Weight = 8,
                },
                new BoxEntity
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTimeOffset.UtcNow,
                    BoxId = 123472,
                    Weight = 11,
                },
                new BoxEntity
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTimeOffset.UtcNow,
                    BoxId = 123483,
                    Weight = 3,
                },
                new BoxEntity
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTimeOffset.UtcNow,
                    BoxId = 123494,
                    Weight = 13,
                });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<BoxEntity> Boxes { get; set; }
        public DbSet<PartEntity> Parts { get; set; }
        public DbSet<BoxItemEntity> BoxItems { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AddBaseInformation();
            return await base.SaveChangesAsync();
        }

        public override int SaveChanges()
        {
            AddBaseInformation();
            return base.SaveChanges();
        }

        private void AddBaseInformation()
        {
            foreach (var entry in this.ChangeTracker.Entries()
            .Where(e => e.Entity is IEntity && (e.State == EntityState.Added ||
                e.State == EntityState.Modified))
            )
            {
                var state = entry.State;
                var entity = entry.Entity as IEntity;
                if (state == EntityState.Added)
                {
                    entity.Id = Guid.NewGuid();
                    entity.CreatedDate = DateTimeOffset.UtcNow;
                }
                if (state == EntityState.Modified)
                    entity.ModifiedDate = DateTimeOffset.UtcNow;
            }
        }
    }
}
