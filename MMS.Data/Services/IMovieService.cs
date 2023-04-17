
using System.Collections.Generic;
using MMS.Data.Models;

namespace MMS.Data.Services
{
    // This interface describes the operations that a MovieService class should implement
    public interface IMovieService 
    {
        // Initialise repository for use during development
        void Initialise();
        IList<Movie> GetAllMovies(string order=null);
        Movie GetMovieById(int id);
        bool DeleteMovie(int id);
        bool UpdateMovie(Movie m);
        Movie AddMovie(Movie m);
        Review GetReviewById(int id);
        Review AddReview(Review r);
        bool DeleteReview(int id);

    }
}