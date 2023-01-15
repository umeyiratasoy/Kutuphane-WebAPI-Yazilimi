using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class KütüphaneWebAPIContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=KutuphaneWebApi;Trusted_Connection=true");
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Tur> Turler { get; set; }

        public DbSet<Kitap> Kitaplar { get; set; }

        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Emanet> Emanetler { get; set; }

        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
