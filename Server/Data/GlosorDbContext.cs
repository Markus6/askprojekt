using Microsoft.EntityFrameworkCore;
using ASKProjekt.Shared.Models;

namespace ASKProjekt.Server.Data
{
	public class GlosorDbContext : DbContext
	{
		public GlosorDbContext(DbContextOptions<GlosorDbContext> options) : base(options)
		{
		}

		public DbSet<GlosaModel> Glosor { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<GlosaModel>().HasData(new GlosaModel()
			{
				Id = 1,
				Language1 = "Hej",
				Language2 = "Hello",
			});
            modelBuilder.Entity<GlosaModel>().HasData(new GlosaModel()
            {
                Id = 2,
                Language1 = "Hejdå",
                Language2 = "Goodbye",
            });
            modelBuilder.Entity<GlosaModel>().HasData(new GlosaModel()
            {
                Id = 3,
                Language1 = "Komma ihåg",
                Language2 = "Remember",
            });
            modelBuilder.Entity<GlosaModel>().HasData(new GlosaModel()
            {
                Id = 4,
                Language1 = "Idag",
                Language2 = "Today",
            });
            modelBuilder.Entity<GlosaModel>().HasData(new GlosaModel()
            {
                Id = 5,
                Language1 = "Imorgon",
                Language2 = "Tomorrow",
            });
            modelBuilder.Entity<GlosaModel>().HasData(new GlosaModel()
            {
                Id = 6,
                Language1 = "Igår",
                Language2 = "Yesterday",
            });
            modelBuilder.Entity<GlosaModel>().HasData(new GlosaModel()
            {
                Id = 7,
                Language1 = "Springa",
                Language2 = "Run",
            });
            modelBuilder.Entity<GlosaModel>().HasData(new GlosaModel()
            {
                Id = 8,
                Language1 = "Gå",
                Language2 = "Walk",
            });
            modelBuilder.Entity<GlosaModel>().HasData(new GlosaModel()
            {
                Id = 9,
                Language1 = "Moln",
                Language2 = "Cloud",
            });
            modelBuilder.Entity<GlosaModel>().HasData(new GlosaModel()
            {
                Id = 10,
                Language1 = "Sol",
                Language2 = "Sun",
            });
        }
	}
}
