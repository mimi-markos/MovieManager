using System;
using System.Linq;
using Xunit;

using MMS.Data.Models;
using MMS.Data.Services;

namespace MMS.Test
{
    public class TestMovieService
    {
        private readonly IMovieService svc;
              
        public TestMovieService()
        {
            // general test arrangement
            svc = new MovieServiceDb();

            // ensure data source is empty before each test 
            svc.Initialise();
        }

        // -------------- Tests to fully validate that the movie service implementation works --------------

        [Fact]
        public void GetAllMovies_WhenNone_ShouldReturnNone() 
        {
            // arrange

            // act - get all movies and store count in variable count
            var movies = svc.GetAllMovies();
            var count = movies.Count;

            // assert - verify that the count is 0
            Assert.Equal(0, count);
        }

        
        [Fact]
        public void GetAllMovies_WhenOneAdded_ShouldReturnOne()
        {
            // arrange - add test movie to db
            var m = svc.AddMovie(new Movie
            {
                Title = "A Movie",
                Director = "xxx",
                Year = 2000,
                Duration = 123,
                Budget = 1000000.00, 
                PosterUrl = "https://xxx.com",
                Genre = Genre.Action,
                Cast = "Movie Cast",
                Plot = "Movie Plot"
            });

            // act - get all movies and store count in variable count
            var movies = svc.GetAllMovies();
            var count = movies.Count;

            // assert - verify that the count is 1
            Assert.Equal(1, count);
        }

        [Fact]
        public void GetAllMovies_WhenTitleSpecified_ReturnAllMoviesOrderedByTitle()
        {
            // arrange - add test movies to db 
            var m1 = svc.AddMovie(new Movie
            {
                Title = "Movie X",
                Director = "Jane Smith",
                Year = 2001,
                Duration = 162,
                Budget = 10000000.00, 
                PosterUrl = "https://xxx.com",
                Genre = Genre.SciFi,
                Cast = "Movie Cast X",
                Plot = "Movie Plot X"
            });

            var m2 = svc.AddMovie(new Movie
            {
                Title = "Movie Y",
                Director = "John Smith",
                Year = 2002,
                Duration = 127,
                Budget = 20000000.00,
                PosterUrl = "https://yyy.com",
                Genre = Genre.Romance,
                Cast = "Movie Cast Y", 
                Plot = "Movie Plot Y"
            });
            
            // act - get all movies ordered by title
            var movies = svc.GetAllMovies("Title");

            // assert - verify that movie titles are in ascending order
            Assert.Equal(movies.First().Title, m1.Title);
            Assert.Equal(movies.Last().Title, m2.Title);
        }

        [Fact]
        public void GetAllMovies_WhenDirectorSpecified_ReturnAllMoviesOrderedByDirector()
        {
            // arrange - add test movies to db 
            var m1 = svc.AddMovie(new Movie
            {
                Title = "Movie X",
                Director = "Jane Smith",
                Year = 2001,
                Duration = 162,
                Budget = 10000000.00, 
                PosterUrl = "https://xxx.com",
                Genre = Genre.SciFi,
                Cast = "Movie Cast X",
                Plot = "Movie Plot X"
            });

            var m2 = svc.AddMovie(new Movie
            {
                Title = "Movie Y",
                Director = "John Smith",
                Year = 2002,
                Duration = 127,
                Budget = 20000000.00,
                PosterUrl = "https://yyy.com",
                Genre = Genre.Romance,
                Cast = "Movie Cast Y", 
                Plot = "Movie Plot Y"
            });
            
            // act - get all movies ordered by director 
            var movies = svc.GetAllMovies("Director");

            // assert - verify movies are in ascending order by director
            Assert.Equal(movies.First().Director, m1.Director);
            Assert.Equal(movies.Last().Director, m2.Director); 
        }

        [Fact]
        public void GetAllMovies_WhenYearSpecified_ReturnAllMoviesOrderedByYear()
        {
            // arrange - add test movies to db 
            var m1 = svc.AddMovie(new Movie
            {
                Title = "Movie X",
                Director = "Jane Smith",
                Year = 2001,
                Duration = 162,
                Budget = 10000000.00, 
                PosterUrl = "https://xxx.com",
                Genre = Genre.SciFi,
                Cast = "Movie Cast X",
                Plot = "Movie Plot X"
            });

            var m2 = svc.AddMovie(new Movie
            {
                Title = "Movie Y",
                Director = "John Smith",
                Year = 2002,
                Duration = 127,
                Budget = 20000000.00,
                PosterUrl = "https://yyy.com",
                Genre = Genre.Romance,
                Cast = "Movie Cast Y", 
                Plot = "Movie Plot Y"
            });

            // act - get all movies ordered by year
            var movies = svc.GetAllMovies("Year");

            // assert - verify movies are in ascending order by year
            Assert.Equal(movies.First().Year, m1.Year);
            Assert.Equal(movies.Last().Year, m2.Year); 
        }

        [Fact]
        public void GetMovieById_WhenNone_ShouldReturnNull() 
        {
            // arrange 

            // act - get non-existent movie
            var movie = svc.GetMovieById(1);

            // assert - verify that the movie id does not exist
            Assert.Null(movie);
        }
        
        [Fact]
        public void GetMovieById_WhenMovieExists_ShouldReturnMovie()
        {
            // arrange - add test movie to db 
            var m = svc.AddMovie(new Movie
            {
                Title = "A Movie",
                Director = "xxx",
                Year = 2000,
                Duration = 123,
                Budget = 1000000.00, 
                PosterUrl = "https://xxx.com",
                Genre = Genre.Action,
                Cast = "Movie Cast",
                Plot = "Movie Plot"
            });

            // act - get movie by Id
            var movie = svc.GetMovieById(m.Id);

            // assert - verify movie identified by Id is not null
            Assert.Equal(m.Id, movie.Id);
            Assert.NotNull(movie);
        } 

        [Fact]
        public void DeleteMovie_ThatExists_ShouldReturnTrue()
        {
            // arrange - add test movie to db
            var m = svc.AddMovie(new Movie
            {
                Title = "A Movie",
                Director = "xxx",
                Year = 2000,
                Duration = 123,
                Budget = 1000000.00, 
                PosterUrl = "https://xxx.com",
                Genre = Genre.Action,
                Cast = "Movie Cast",
                Plot = "Movie Plot"
            });

            // act - delete newly created movie, then retrive deleted movie
            var deleted = svc.DeleteMovie(m.Id);
            var m1 = svc.GetMovieById(m.Id);

            // assert 
            // verify no such movie id exists
            Assert.Null(m1);
            // verify the movie identified by id has been deleted
            Assert.True(deleted);
        }

        [Fact]
        public void DeleteMovie_ThatExists_ShouldReduceMovieCountByOne()
        {
            // arrange - add test movie to db
            var m = svc.AddMovie(new Movie
            {
                Title = "A Movie",
                Director = "xxx",
                Year = 2000,
                Duration = 123,
                Budget = 1000000.00, 
                PosterUrl = "https://xxx.com",
                Genre = Genre.Action,
                Cast = "Movie Cast",
                Plot = "Movie Plot"
            });

            // act - delete newly created movie, then retrive all movies
            var deleted = svc.DeleteMovie(m.Id);
            var movies = svc.GetAllMovies();

            // assert - verify that there are no movies in the db
            Assert.Equal(0, movies.Count);
        }

        [Fact]
        public void DeleteMovie_ThatDoesntExist_ShouldReturnFalse()
        {
            // arrange


            // act - delete non-existent movie 
            var deleted = svc.DeleteMovie(1);

            // assert - verify the movie does not exist and has not been deleted 
            Assert.False(deleted);            
        }

        [Fact]
        public void DeleteMovie_ThatDoesntExist_ShouldNotChangeMovieCount()
        {
            // arrange - add test movie to db 
            var m1 = svc.AddMovie(new Movie
            {
                Title = "A Movie",
                Director = "xxx",
                Year = 2000,
                Duration = 123,
                Budget = 1000000.00, 
                PosterUrl = "https://xxx.com",
                Genre = Genre.Action,
                Cast = "Movie Cast",
                Plot = "Movie Plot"
            });

            //act - delete a movie that doesn't exist, then get all movies 
            svc.DeleteMovie(2);
            var movies = svc.GetAllMovies();

            // assert - verify that the movie count is 1
            Assert.Equal(1, movies.Count); 
        }

        [Fact]
        public void UpdateMovie_WhenExists_ShouldSetAllProperties()
        {

            // arrange - add test movie to db 
            var m = svc.AddMovie(new Movie
            {
                Title = "Movie X",
                Director = "Jane Smith",
                Year = 2001,
                Duration = 162,
                Budget = 10000000.00, 
                PosterUrl = "https://xxx.com",
                Genre = Genre.SciFi,
                Cast = "Movie Cast X",
                Plot = "Movie Plot X"
            });
            
            // act - update test movie 
            m.Title = "Movie Y";
            m.Director = "John Smith";
            m.Year = 2002;
            m.Duration = 127;
            m.Budget = 20000000.00;
            m.PosterUrl = "https://yyy.com";
            m.Genre = Genre.Romance;
            m.Cast = "Movie Cast Y"; 
            m.Plot = "Movie Plot Y";

            svc.UpdateMovie(m); 

            // assert - verify the updated properties have been set 
            Assert.NotNull(m);
            Assert.Equal("Movie Y", m.Title);
            Assert.Equal("John Smith", m.Director);
            Assert.Equal(2002, m.Year);
            Assert.Equal(127, m.Duration);
            Assert.Equal(20000000.00, m.Budget);
            Assert.Equal("https://yyy.com", m.PosterUrl);
            Assert.Equal(Genre.Romance, m.Genre);
            Assert.Equal("Movie Cast Y", m.Cast);
            Assert.Equal("Movie Plot Y", m.Plot);
        }

        [Fact]
        public void AddMovie_WhenUnique_ShouldSetAllProperties()
        {
            // arrange 

            // act - add new test movie
            var movie = svc.AddMovie(new Movie
            {
                Title = "A Movie",
                Director = "xxx",
                Year = 2000,
                Duration = 123,
                Budget = 1000000.00, 
                PosterUrl = "https://xxx.com",
                Genre = Genre.Romance,
                Cast = "Movie Cast",
                Plot = "Movie Plot"
            });
            
            // retrieve newly saved movie
            var m = svc.GetMovieById(movie.Id);
            

            // assert - verify properties are set and movie not null
            Assert.NotNull(m);
            Assert.Equal(m.Id, m.Id);
            Assert.Equal("A Movie", m.Title);
            Assert.Equal("xxx", m.Director);
            Assert.Equal(2000, m.Year);
            Assert.Equal(123, m.Duration);
            Assert.Equal(1000000.00, m.Budget);
            Assert.Equal("https://xxx.com", m.PosterUrl);
            Assert.Equal(Genre.Romance, m.Genre);
            Assert.Equal("Movie Cast", m.Cast);
            Assert.Equal("Movie Plot", m.Plot);
        }

        [Fact]
        public void GetReviewById_WhenExists_ShouldReturnReview()
        {
            // arrange - add test movie to db 
            var m = svc.AddMovie(new Movie
            {
                Title = "A Movie",
                Director = "xxx",
                Year = 2000,
                Duration = 123,
                Budget = 1000000.00, 
                PosterUrl = "https://xxx.com",
                Genre = Genre.Action,
                Cast = "Movie Cast",
                Plot = "Movie Plot"
            });
            
            // add review to newly created movie
            var r = svc.AddReview(new Review
            {
                Name = "Dummy Name",
                CreatedOn = new DateTime (2021,1,1),
                Comment = "Dummy Comment",
                Rating = 10,
                MovieId = m.Id
            });

            // act - get review by Id
            var nr = svc.GetReviewById(r.Id);

            // assert - verify review exists and associated with movie
            Assert.Equal(r.Id, nr.Id);
            Assert.Equal(m.Id, nr.Id); 
            Assert.NotNull(nr);
        }

        [Fact]
        public void GetReviewById_WhenNone_ShouldReturnNull() 
        {
            // arrange

            // act - retrieve non-existent review
            var review = svc.GetReviewById(3);

            // assert - verify that the review does not exist
            Assert.Null(review);
        }

        [Fact]
        public void AddReview_WhenUniqueId_ShouldSetAllProperties()
        {
            // arrange - add test movie to db
            var m = svc.AddMovie(new Movie
            {
                Title = "A Movie",
                Director = "xxx",
                Year = 2000,
                Duration = 123,
                Budget = 1000000.00, 
                PosterUrl = "https://xxx.com",
                Genre = Genre.Comedy,
                Cast = "Movie Cast",
                Plot = "Movie Plot"
            });

            // act - add new review to newly created movie
            var review = svc.AddReview(new Review
            {
                Name = "Dummy Name",
                Comment = "Dummy Comment",
                Rating = 10,
                MovieId = m.Id
            });

            // retrive newly saved review
            var r = svc.GetReviewById(review.Id);            

            // assert - verify properties set and review not null
            Assert.NotNull(r);
            Assert.Equal(r.Id,r.Id);
            Assert.Equal("Dummy Name", r.Name); 
            Assert.Equal(10, r.Rating);
            Assert.Equal(m.Id, r.Id);
        }

        [Fact]
        public void DeleteReview_ThatExists_ShouldReturnTrue()
        {
            // arrange - add test movie to db 
            var m = svc.AddMovie(new Movie
            {
                Title = "A Movie",
                Director = "xxx",
                Year = 2000,
                Duration = 123,
                Budget = 1000000.00, 
                PosterUrl = "https://xxx.com",
                Genre = Genre.Action,
                Cast = "Movie Cast",
                Plot = "Movie Plot"
            });
            
            // add review to newly created movie
            var r = svc.AddReview(new Review
            {
                Name = "Dummy Name",
                CreatedOn = new DateTime (2021,1,1),
                Comment = "Dummy Comment",
                Rating = 10,
                MovieId = m.Id
            });

            // act - delete newly created review, then retrive deleted review 
            var deleted = svc.DeleteReview(r.Id);
            var review = svc.GetReviewById(r.Id);

            // assert 
            // verify no such review id exists  
            Assert.Null(review);
            // verify the review identified by id has been deleted
            Assert.True(deleted);
        }

        [Fact]
        public void DeleteReview_ThatDoesntExist_ShouldReturnFalse() 
        {
            // arrange - create and add review
             

            // act - delete non-existent review
            var deleted = svc.DeleteReview(1);

            // assert - verify movie doesn't exists and therefore not deleted
            Assert.False(deleted);
        }

    }
}
