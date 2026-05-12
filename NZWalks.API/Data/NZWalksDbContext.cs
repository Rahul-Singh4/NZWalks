using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {

        public NZWalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Difficulties
            //Easy Medium Hard

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    Name = "Easy"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    Name = "Medium"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    Name = "Hard"
                }
            };

            // Seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            //Seed data for Regions
            var regions = new List<Region>()
            {
                new Region()
                {
                    Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Auckland_skyline_from_Mt_Eden.jpg/2560px-Auckland_skyline_from_Mt_Eden.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
                    Name = "Wellington",
                    Code = "WLG",
                    RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Wellington_skyline_from_Mt_Victoria.jpg/2560px-Wellington_skyline_from_Mt_Victoria.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("66666666-6666-6666-6666-666666666666"),
                    Name = "Christchurch",
                    Code = "CHC",
                    RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Christchurch_Cathedral.jpg/2560px-Christchurch_Cathedral.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("77777777-7777-7777-7777-777777777777"),
                    Name = "Queenstown",
                    Code = "ZQN",
                    RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Queenstown_skyline_from_Bobs_Peak.jpg/2560px-Queenstown_skyline_from_Bobs_Peak.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("88888888-8888-8888-8888-888888888888"),
                    Name = "Rotorua",
                    Code = "ROT",
                    RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Rotorua_skyline_from_Mt_Eden.jpg/2560px-Rotorua_skyline_from_Mt_Eden.jpg"
                }
            };

            // Seed regions to the database
            modelBuilder.Entity<Region>().HasData(regions);

        }


    }
}
