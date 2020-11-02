using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Data.Seed;

namespace ThunderRaeder.Data.Contexts
{
    public class ThunderRaederDbContext : IdentityDbContext<IdentityUser>
    {
        public ThunderRaederDbContext(DbContextOptions options) : base(options)
        { }


        //// //    FOR.DGML CREATION
        //   public ThunderRaederDbContext()
        //   {

        //   }
        //   protected override void OnConfiguring(DbContextOptionsBuilder builder)
        //   {
        //       if (!builder.IsConfigured)
        //       {
        //           builder.UseSqlServer("...");
        //       }
        //   }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserBook> AppUserBooks { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Comment> Comments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUserBook>().HasKey(ub => new { ub.AppUserId, ub.BookId });

            modelBuilder.Entity<AppUserBook>()
                .HasOne(ub => ub.AppUser)
                .WithMany(u => u.AppUserBooks)
                .HasForeignKey(ub => ub.AppUserId);

            modelBuilder.Entity<AppUserBook>()
                .HasOne(ub => ub.Book)
                .WithMany(b => b.AppUserBooks)
                .HasForeignKey(ub => ub.BookId);

       //     DatabaseSeeder.Run(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}
