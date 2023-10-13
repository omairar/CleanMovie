using CleanMovie.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure
{
    public class CleanMovieContext: DbContext
    {
        public CleanMovieContext(DbContextOptions<CleanMovieContext> options)
            :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //one to many (member and rentals)

            modelBuilder.Entity<Member>().
                HasOne<Rental>(s => s.RentalNav).
                WithMany(r => r.Members)
                .HasForeignKey(r => r.RentalId);


            //many to many (movie and rentals)

            modelBuilder.Entity<MovieRental>().HasKey(g => new {g.RentalId, g.MovieId});

            //handle decimals

            modelBuilder.Entity<Rental>().Property(p => p.TotalCost).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Movie>().Property(p => p.RentalCost).HasColumnType("decimal(18,2)");
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MovieRental> MovieRentals { get; set; }
    }
}
