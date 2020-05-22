using Login.Web.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Web.Data
{
    public class DataContext :IdentityDbContext<UserEntity>
    {

        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        public DbSet<TaxiEntity> Taxis { get; set; }
        public DbSet<TripDetailEntity> Trips {get; set; }
        public DbSet<TripEntity> TripEntities { get; set; }
        public DbSet<UserGroupEntity> UserGroups { get; set; }
    }
}
