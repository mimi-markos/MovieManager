using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

using MMS.Data.Models;
using MMS.Data.Repositories;

namespace MMS.Data.Services
{
    // IMovieService implementation using the provided Entityframework Repository (MovieDbContext)
    public class MovieServiceDb : IMovieService
    {
        private readonly MovieDbContext db;

        public MovieServiceDb()
        {
            db = new MovieDbContext();
        }

        public void Initialise()
        {
            db.Initialise();
        }
        
        // ----------------------- Movie Related Operations -----------------------

        // Retrieve list of movies (optionally ordered by parameter string value)
        public IList<Movie> GetAllMovies(string order=null)
        {
            // return movies in ascending order of title, if title order selected
            if (order == "title")
            {
                return db.Movies
                         .OrderBy(m => m.Title)
                         .ToList();
            }

            // return movies in ascending order of director, if director order selected
            if (order == "director")
            {
                return db.Movies
                         .OrderBy(m => m.Director)
                         .ToList();
            }

             // return movies  in ascending order of year, if year order selected
            if (order == "year")
            {
                return db.Movies
                         .OrderBy(m => m.Year)
                         .ToList();
            }
            

            // return movies if no optional order option is selected
            return db.Movies.Include(m => m.Reviews).ToList();
        }


        // Retrieve a movie by Id 
        public Movie GetMovieById(int id) 
        {
            // return a movie and associated reviews, or null if id not found
            return db.Movies
                     .Include(m => m.Reviews)
                     .FirstOrDefault(m => m.Id == id);   
        }


        // Delete a movie identified by Id
        public bool DeleteMovie(int id)
        {
            // verify that the movie exists by Id, return false if not found 
            var m = GetMovieById(id);
            if (m == null)
            {
                return false;
            }

            // if movie Id found, delete movie and write to database
            db.Movies.Remove(m); 
            db.SaveChanges();

            //return true to verify movie deletion
            return true;
        }


        // Update a movie indentified by Id
        public bool UpdateMovie(Movie m)
        {
            // verify that the movie exists by Id
            var movie = GetMovieById(m.Id);
            if (movie == null)
            {
                return false;
            }

            // if movie Id found, update the details of the movie 
            movie.Title = m.Title;
            movie.Director = m.Director;
            movie.Year = m.Year;
            movie.Duration = m.Duration;
            movie.Budget = m.Budget;
            movie.PosterUrl = m.PosterUrl;
            movie.Genre = m.Genre;
            movie.Cast = m.Cast;
            movie.Plot = m.Plot;

            // write to database 
            db.SaveChanges(); 

            //return true to verify movie details have been updated
            return true;
        }


        // Add a new movie
        public Movie AddMovie(Movie m)
        {
            // verify that the movie does not already exist by Id
            var exists = GetMovieById(m.Id);

            // if movie Id exists, a new movie cannot be created
            if (exists != null) 
            {
                return null;
            }

            // add movie and write to database  
            db.Movies.Add(m); 
            db.SaveChanges();
            
            // return newly added movie
            return m;
        }

        // ----------------------- Review Related Operations -----------------------
        
        // Get review by Id and associated movie
        public Review GetReviewById(int id)
        {
            // return a review by id, or null if movie not found
            return db.Reviews
                     .Include(r => r.Movie)
                     .FirstOrDefault(r => r.Id == id); 
        }

        // Add a new review to a movie 
        public Review AddReview(Review r)
        {
            
            // verify that the review id does not already exist 
            var movie = GetMovieById(r.MovieId);

            // if Id already exists, a new review cannot be created
            if (movie == null) 
            {
                return null;
            }
         
            //if movie does exist, add details of new review 
            var review = new Review 
            {
                Name = r.Name,
                CreatedOn = r.CreatedOn,
                Comment = r.Comment,
                Rating = r.Rating,
                MovieId = r.MovieId
            }; 

            // add review and write to database 
            db.Reviews.Add(review);
            db.SaveChanges();

            // return newly created review
            return review;
        }


        // Delete a review by id 
        public bool DeleteReview(int id)
        {
            // verify that the movie exists by Id, return false if not found 
            var r = GetReviewById(id);
            if (r == null) 
            {
                return false;
            }

            // if review Id found, delete review and write to database
            db.Reviews.Remove(r);
            db.SaveChanges();

            // verify review deletion
            return true;
        }




    }
    
}