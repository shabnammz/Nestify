using Microsoft.EntityFrameworkCore;
using Nestify.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nestify.Persistence.Context
{
    public class AppDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<PropertyImage> PropertyImages { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}
