using Microsoft.EntityFrameworkCore;
using OurHeroApiwithcodefirstapproach.Model;
using System.Reflection.Emit;

namespace OurHeroApiwithcodefirstapproach.Entity
{
    public class OurHeroDbContext : DbContext
    {
        public OurHeroDbContext(DbContextOptions<OurHeroDbContext> options) : base(options)
        {
        }
        // Registered DB Model in OurHeroDbContext file
        public DbSet<OurHeros> OurHeros { get; set; }

        /*
OnModelCreating mainly used to configured our EF model
         And insert master data if required
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Setting a primary key in OurHero model
            modelBuilder.Entity<OurHeros>().HasKey(x => x.Id);

            // Inserting record in OurHero table
            modelBuilder.Entity<OurHeros>().HasData(
                            new OurHeros
                            {
                                Id = 1,
                                FirstName = "System",
                                LastName = "",
                                IsActive = true,
                            }
                        );


        }
    }
}
