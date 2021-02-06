using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Concrete.EntityFramework
{
    public class ReCapContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=192.168.16.12; Database=RecapProject; User Id=sa; Password=12345678; MultipleActiveResultSets=true;"); //Trusted_Connetion=false;
        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Brand> Brands  { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}