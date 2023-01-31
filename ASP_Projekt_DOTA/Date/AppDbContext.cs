using ASP_Projekt_DOTA.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_Projekt_DOTA.Date
{
    public class AppDbContext:DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Decoration_Character>().HasKey(dc => new
            {
                dc.CharacterId,
                dc.DecorationId                
            });

            modelBuilder.Entity<Decoration_Character>().HasOne(d => d.Decoration).WithMany(dc => dc.Decorations_Characters) .HasForeignKey(d => d.DecorationId);
            modelBuilder.Entity<Decoration_Character>().HasOne(d => d.Character).WithMany(dc => dc.Decorations_Characters).HasForeignKey(d => d.CharacterId);
           
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Decoration> Decorations { get; set; }
        public DbSet<Decoration_Character> Decorations_Characters { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
    }
}
