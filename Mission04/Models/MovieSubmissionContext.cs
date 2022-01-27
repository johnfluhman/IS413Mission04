using System;
using Microsoft.EntityFrameworkCore;

namespace Mission04.Models
{
    public class MovieSubmissionContext : DbContext
    {
        //Constructor 
        public MovieSubmissionContext (DbContextOptions<MovieSubmissionContext> options) : base (options)
        {
            
        }

        public DbSet<MovieSubmission> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieSubmission>().HasData(

                new MovieSubmission
                {
                    MovieID = 1,
                    Category = "Drama",
                    Title = "Prisoners",
                    Year = 2013,
                    Director = "Denis Villeneuve",
                    Rating = "R",
                    Edited = false,
                    LentTo = "",
                    Notes = "An amazing film"
                },

                new MovieSubmission
                {
                    MovieID = 2,
                    Category = "Drama",
                    Title = "Sicario",
                    Year = 2015,
                    Director = "Denis Villeneuve",
                    Rating = "R",
                    Edited = false,
                    LentTo = "",
                    Notes = "Another amazing film"
                },

                new MovieSubmission
                {
                    MovieID = 3,
                    Category = "Drama",
                    Title = "Arrival",
                    Year = 2016,
                    Director = "Denis Villeneuve",
                    Rating = "R",
                    Edited = false,
                    LentTo = "",
                    Notes = "An amazing alien film"
                }
            );
        }
    }
}
