using System;
using Microsoft.AspNetCore.Mvc;
using MMS.Data.Models;
using MMS.Data.Services;
using MMS.Web.Models;


namespace MMS.Web.Controllers
{
    public class MovieController : BaseController
    {
        private IMovieService svc;
        
        // Scoped configuration via Dependency Injection
        public MovieController(IMovieService ms)
        {
            svc = ms;
        }

        
        //GET: /movie 
        public IActionResult Index(string order = "")
        {   
            // retrieve list of movies (optionally ordered by parameter value)
            var movies = svc.GetAllMovies(order);

            // pass movies by order selected to the view
            return View(movies);
        }


        //GET: /movie/details/{id} 
        public IActionResult Details(int id)
        {
            // retrieve movie identified by id 
            var m = svc.GetMovieById(id);

            // if movie doesn't exist, display alert and redirect to index
            if (m == null)
            {
                Alert($"Sorry, movie not found.", AlertType.warning);
                return RedirectToAction(nameof(Index));
            }

            // pass the movie to the view
            return View(m);
        }

        
        // GET: movie/create 
        public IActionResult Create()
        {
            // display blank form to create a movie 
            var m = new Movie();
            return View(m);
        }


        // POST: movie/create 
        [HttpPost] 
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Title, Director, Year, Duration, Budget, PosterUrl, Genre, Cast, Plot")] Movie m)
        {
            // verify the model is valid to add movie
            if (ModelState.IsValid)
            {
                // pass movie data to service to store
                svc.AddMovie(m);
                Alert("Movie added successfully!", AlertType.success);

                return RedirectToAction(nameof(Details), new { id = m.Id });
            }

            // redisplay form for editing due to validation errors
            return View(m);
        }


        // GET: /movie/edit/{id}  
        public IActionResult Edit(int id)
        {
            // load movie by id using service
            var m = svc.GetMovieById(id);

            // if movie doesn't exist, display alert and redirect to index
            if (m == null)
            {
                Alert("Sorry, movie not found.", AlertType.warning);
                return RedirectToAction(nameof(Index));
            }
            
            // pass movie to view for editing
            return View(m);
        }


        // POST: /movie/edit/{id} 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("Title, Director, Year, Duration, Budget, PosterUrl, Genre, Cast, Plot, Id")] Movie m) 
        {
            // verify the model is valid to update movie
            if (ModelState.IsValid)
            {
                // pass movie data to service to update
                svc.UpdateMovie(m);
                
                // verify to user that update is sucessful
                Alert("Movie updated successfully!", AlertType.info);
                
                return RedirectToAction(nameof(Index));
            }

            return View(m);
        }

        
        // GET: /movie/delete/{id} 
        public IActionResult Delete (int id)
        {
            // load movie by id using service
            var m = svc.GetMovieById(id);

            // if movie doesn't exist, display alert and redirect to index
            if (m == null)
            {
                Alert("Sorry, movie not found.", AlertType.warning);
                return RedirectToAction(nameof(Index));
            }

            // pass to view to confirm deletion
            return View(m);
        }


        // POST: /movie/delete/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirm(int id)
        {
            // delete movie via service 
            var m = svc.DeleteMovie(id);

            // display alert to user to confirm deletion
            Alert($"Movie deleted successfully!", AlertType.success);

            // redirect to the movies index view
            return RedirectToAction(nameof(Index));
        }


        //GET: /movie/addreview
        public IActionResult AddReview(int id)
        {
            // retrieve movie by id using service
            var m = svc.GetMovieById(id);

            // if movie doesn't exist, display alert and redirect to index 
            if (m == null)
            {
                Alert("Sorry, movie not found.", AlertType.warning);
                return RedirectToAction(nameof(Index));
            }

            // create new review 
            var r = new Review
            {
                MovieId = id
            };

            // display blank form to create a review 
            return View("AddReview", r);
        }


        // POST: /movie/addreview 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddReview([Bind("Name, Comment, Rating, MovieId")] Review r) 
        {
            // retrieve movie associated with review 
            var movie = svc.GetMovieById(r.MovieId);

            // if movie doesn't exist, display alert and redirect to index 
            if (movie == null)
            {
                Alert($"Sorry, movie not found", AlertType.warning);   
                return RedirectToAction(nameof(Index));
            };

            // pass review data to service to store 
            svc.AddReview(r);
            Alert($"Review added successfully!", AlertType.success);  
                 
            // redirect to the movies details view
            return RedirectToAction("Details", new { Id = r.MovieId });
        }


        // GET: /movie/deletereview/{id} 
        public IActionResult DeleteReview (int id)
        {
            // get review by id using service
            var r = svc.GetReviewById(id);

            // if review doesn't exist, display alert and redirect to index
            if (r == null)
            {
                Alert("Sorry, review not found.", AlertType.warning);
                return RedirectToAction(nameof(Index));
            }

            // pass to view to confirm deletion
            return View(r);
        }


        // POST: /movie/deletereview/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteReviewConfirm(int id)
        {
            // delete movie via service 
            var r = svc.DeleteReview(id);

            // display alert to user to verify successful deletion
            Alert($"Review deleted successfully!", AlertType.success);

            // redirect to the movies details view
            return RedirectToAction(nameof(Index));
        }

    }
}