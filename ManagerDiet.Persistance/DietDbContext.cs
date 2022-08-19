using ManagerDiet.Application.Interfaces;
using ManagerDiet.Domain.Common;
using ManagerDiet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Persistance
{
    public class DietDbContext : DbContext, IDietDbContext
    {
        private readonly IDateTime _dateTime;

        public DietDbContext(DbContextOptions<DietDbContext> options) : base(options)
        {
              
        }
        public DietDbContext(DbContextOptions<DietDbContext> options, IDateTime dateTime) : base(options)
        {
            _dateTime = dateTime;
        }

        public DbSet<CaloricDemand> CaloricDemands { get; set; }
        public DbSet<DayInDiet> DayInDiets { get; set; }
        public DbSet<Diet> Diets { get; set; }
        public DbSet<EatedMeal> EatedMeals { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<UserInformation> UserInformations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<UserInformation>().OwnsOne(p => p.UserInformationName);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = string.Empty;
                        entry.Entity.Created = _dateTime.Now;
                        entry.Entity.StatusId = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified = _dateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified = _dateTime.Now;
                        entry.Entity.InactivatedBy = string.Empty;
                        entry.Entity.Inactivated = _dateTime.Now;
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
