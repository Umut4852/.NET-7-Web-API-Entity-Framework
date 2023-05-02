﻿global using Microsoft.EntityFrameworkCore;

namespace SuperHeroApiDotNet7.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext>options): base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=UMUTCAN;Initial Catalog=SuperHeroApiDotNet7;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        public DbSet <SuperHero>SuperHeroes { get; set; }
    }
}
