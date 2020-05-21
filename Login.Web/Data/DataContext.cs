using Login.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Web.Data
{
    public class DataContext :DbContext
    {

        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        public DbSet<TaxiEntity> Taxis { get; set; }
    }
}
