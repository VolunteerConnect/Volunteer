using Microsoft.EntityFrameworkCore;
using Volunteer.Core.Favorites;
using Volunteer.Core.Organizations;

namespace Volunteer.Data
{
    public class VolunteerDBContext : DbContext
    {
        private readonly string _connectionString;
        public VolunteerDBContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public VolunteerDBContext(DbContextOptions<VolunteerDBContext> options) : base(options)
        {
        }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Favorite> Favorites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySql(_connectionString, ServerVersion.Parse("8.2.0"));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organization>().ToTable("organizations");
            modelBuilder.Entity<Organization>().Property(o => o.BannerImage).HasColumnName("banner_image");
            modelBuilder.Entity<Organization>().Property(o => o.DescriptionLong).HasColumnName("description_long");

            modelBuilder.Entity<Favorite>().ToTable("favorites");
            modelBuilder.Entity<Favorite>().Property(o => o.UserId).HasColumnName("user_id");
            modelBuilder.Entity<Favorite>().Property(o => o.FavoriteOrganizationId).HasColumnName("favorite_organization_id");
        }
    }
}
