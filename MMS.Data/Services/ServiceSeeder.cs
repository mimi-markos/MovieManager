using System;
using MMS.Data.Models;

namespace MMS.Data.Services
{
    public static class ServiceSeeder
    {

        // use this class to seed the database with dummy test data using an IMovieService
        public static void Seed(IMovieService svc)
        {
            svc.Initialise();

            //add movies 
            var m1 = svc.AddMovie(new Movie
            {
                Title = "City of God",
                Director = "Fernando Meirelles",
                Year = 2002,
                Duration = 130,
                Budget = 3300000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/original/4YEX7qUfg6kN2tHm84CMt2CEq9n.jpg",
                Genre = Genre.Action,
                Cast = "Alexandre Rodrigues, Leandro Firmino, Phellipe Haagensen, Douglas Silva, Jonathan Haagensen",
                Plot = "Buscapé was raised in a very violent environment. Despite the feeling that all odds were against him, he finds out that life can be seen with other eyes..."
            });

            var m2 = svc.AddMovie(new Movie
            {
                Title = "Suicide Squad",
                Director = "David Ayer",
                Year = 2016,
                Duration = 123,
                Budget = 175000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/rbsm0i2q2uqlUSFgUAHq3xCUO4j.jpg",
                Genre = Genre.Action,
                Cast = "Will Smith, Margot Robbie, Jared Leto, Joel Kinnaman, Viola Davis",
                Plot = "From DC Comics comes the Suicide Squad, an antihero team of incarcerated supervillains who act as deniable assets for the United States government, undertaking high-risk black ops missions in exchange for commuted prison sentences."
            });

            var m3 = svc.AddMovie(new Movie
            {
                Title = "Coming to America",
                Director = "John Landis",
                Year = 1988,
                Duration = 117,
                Budget = 39000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/original/xF0vZYjtP6m4fW8TbBGanmnrcVu.jpg",
                Genre = Genre.Comedy,
                Cast = "Eddie Murphy, Arsenio Hall, James Earl Jones, John Amos, Shari Headley",
                Plot = "An African prince decides it’s time for him to find a princess... and his mission leads him and his most loyal friend to Queens, New York. In disguise as an impoverished immigrant, the pampered prince quickly finds himself a new job, new friends, new digs, new enemies and lots of trouble."
            });

            var m4 = svc.AddMovie(new Movie
            {
                Title = "Bridesmaids",
                Director = "Paul Feig",
                Year = 2011,
                Duration = 125,
                Budget = 32500000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/cruSkSZJEmv9pbDoHBwdHdsnvHO.jpg",
                Genre = Genre.Comedy,
                Cast = "Kristen Wiig, Maya Rudolph, Wendi McLendon-Covey, Melissa McCarthy, Chris O'Dowd",
                Plot = "Annie's life is a mess. But when she finds out her lifetime best friend is engaged, she simply must serve as Lillian's maid of honor. Though lovelorn and broke, Annie bluffs her way through the expensive and bizarre rituals. With one chance to get it perfect, she’ll show Lillian and her bridesmaids just how far you’ll go for someone you love."
            });

            var m5 = svc.AddMovie(new Movie
            {
                Title = "Step Brothers",
                Director = "Adam McKay",
                Year = 2008,
                Duration = 98,
                Budget = 65000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/jV0eDViuTRf9cmj4H0JNvbvaNbR.jpg",
                Genre = Genre.Comedy,
                Cast = "Will Ferrell, John C. Reilly, Mary Steenburgen, Richard Jenkins, Kathryn Hahn",
                Plot = "Brennan Huff and Dale Doback might be grown men. But that doesn't stop them from living at home and turning into jealous, competitive stepbrothers when their single parents marry. Brennan's constant competition with Dale strains his mom's marriage to Dale's dad, leaving everyone to wonder whether they'll ever see eye to eye."
            });

            var m6 = svc.AddMovie(new Movie
            {
                Title = "Shrek",
                Director = "Andrew Adamson",
                Year = 2001,
                Duration = 90,
                Budget = 60000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/iB64vpL3dIObOtMZgX3RqdVdQDc.jpg",
                Genre = Genre.Family,
                Cast = "Mike Myers, Eddie Murphy, Cameron Diaz, John Lithgow, Vincent Cassel",
                Plot = "It ain't easy bein' green -- especially if you're a likable (albeit smelly) ogre named Shrek. On a mission to retrieve a gorgeous princess from the clutches of a fire-breathing dragon, Shrek teams up with an unlikely compatriot -- a wisecracking donkey."
            });

            var m7 = svc.AddMovie(new Movie
            {
                Title = "The Wickerman",
                Director = "Robin Hardy",
                Year = 1973,
                Duration = 94,
                Budget = 810000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/vs9I9RFIGYaIn3XQXkuNy2BrTCt.jpg",
                Genre = Genre.Horror,
                Cast = "Edward Woodward, Christopher Lee, Britt Ekland, Ingrid Pitt, Diane Cilento",
                Plot = "Police sergeant Neil Howie is called to an island village in search of a missing girl whom the locals claim never existed. Stranger still, however, are the rituals that take place there."
            });

            var m8 = svc.AddMovie(new Movie
            {
                Title = "Get Out",
                Director = "Jordan Peele",
                Year = 2017,
                Duration = 104,
                Budget = 4500000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/tFXcEccSQMf3lfhfXKSU9iRBpa3.jpg",
                Genre = Genre.Horror,
                Cast = "Daniel Kaluuya, Allison Williams, Catherine Keener, Bradley Whitford, Lakeith Stanfield",
                Plot = "Chris and his girlfriend Rose go upstate to visit her parents for the weekend. At first, Chris reads the family's overly accommodating behavior as nervous attempts to deal with their daughter's interracial relationship, but as the weekend progresses, a series of increasingly disturbing discoveries lead him to a truth that he never could have imagined."
            });

            var m9 = svc.AddMovie(new Movie
            {
                Title = "The Silence of the Lambs",
                Director = "Jonathan Demme",
                Year = 1991,
                Duration = 119,
                Budget = 19000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/rplLJ2hPcOQmkFhTqUte0MkEaO2.jpg",
                Genre = Genre.Horror,
                Cast = "Jodie Foster, Anthony Hopkins, Scott Glenn, Ted Levine, Anthony Heald",
                Plot = "Clarice Starling is a top student at the FBI's training academy. Jack Crawford wants Clarice to interview Dr. Hannibal Lecter, a brilliant psychiatrist who is also a violent psychopath, serving life behind bars for various acts of murder and cannibalism. Crawford believes that Lecter may have insight into a case and that Starling, as an attractive young woman, may be just the bait to draw him out."
            });

            var m10 = svc.AddMovie(new Movie
            {
                Title = "The Notebook",
                Director = "Nick Cassavetes",
                Year = 2004,
                Duration = 123,
                Budget = 29000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/rNzQyW4f8B8cQeg7Dgj3n6eT5k9.jpg",
                Genre = Genre.Romance,
                Cast = "Rachel McAdams, Ryan Gosling, Gena Rowlands, James Garner, Sam Shepard",
                Plot = "An epic love story centered around an older man who reads aloud to a woman with Alzheimer's. From a faded notebook, the old man's words bring to life the story about a couple who is separated by World War II, and is then passionately reunited, seven years later, after they have taken different paths."
            });

            var m11 = svc.AddMovie(new Movie
            {
                Title = "The Curious Case of Benjamin Button",
                Director = "David Fincher",
                Year = 2008,
                Duration = 166,
                Budget = 150000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/26wEWZYt6yJkwRVkjcbwJEFh9IS.jpg",
                Genre = Genre.Romance,
                Cast = "Brad Pitt, Cate Blanchett, Taraji P. Henson, Julia Ormond, Mahershala Ali",
                Plot = "The Curious Case of Benjamin Button, adapted from the 1920s story by F. Scott Fitzgerald about a man who is born in his eighties and ages backwards: a man, like any of us, who is unable to stop time. We follow his story, set in New Orleans, from the end of World War I in 1918 into the 21st century, following his journey that is as unusual as any man's life can be."
            });

            var m12 = svc.AddMovie(new Movie
            {
                Title = "Pretty Woman",
                Director = "Garry Marshall",
                Year = 1990,
                Duration = 119,
                Budget = 14000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/original/en3W25vqCapae7CAvoqKyYYKGYF.jpg",
                Genre = Genre.Romance,
                Cast = "Richard Gere, Julia Roberts, Ralph Bellamy, Laura San Giacomo, Hector Elizondo",
                Plot = "When a millionaire wheeler-dealer enters a business contract with a Hollywood hooker Vivian Ward, he loses his heart in the bargain."
            });

            var m13 = svc.AddMovie(new Movie
            {
                Title = "Avatar",
                Director = "James Cameron",
                Year = 2009,
                Duration = 162,
                Budget = 237000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/6EiRUJpuoeQPghrs3YNktfnqOVh.jpg",
                Genre = Genre.SciFi,
                Cast = "Sam Worthington, Zoe Saldana, Sigourney Weaver, Stephen Lang, Michelle Rodriguez",
                Plot = "In the 22nd century, a paraplegic Marine is dispatched to the moon Pandora on a unique mission, but becomes torn between following orders and protecting an alien civilization."
            });
            
            var m14 = svc.AddMovie(new Movie
            {
                Title = "Eternal Sunshine of the Spotless Mind",
                Director = "Michel Gondry",
                Year = 2004,
                Duration = 108,
                Budget = 20000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/xFuIVB1aPb29vq0G0X9E5p7LuhN.jpg",
                Genre = Genre.SciFi,
                Cast = "Jim Carey, Kate Winslet, Kristen Dunst, Mark Ruffalo, Elijah Wood",
                Plot = "Joel Barish, heartbroken that his girlfriend underwent a procedure to erase him from her memory, decides to do the same. However, as he watches his memories of her fade away, he realises that he still loves her, and may be too late to correct his mistake."
            });

            var m15 = svc.AddMovie(new Movie
            {
                Title = "Ex Machina",
                Director = "Alex Garland",
                Year = 2015,
                Duration = 108,
                Budget = 15000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/9goPE2IoMIXxTLWzl7aizwuIiLh.jpg",
                Genre = Genre.SciFi,
                Cast = "Domhnall Gleeson, Alicia Vikander, Oscar Isaac, Sonoya Mizuno, Corey Johnson",
                Plot = "Caleb, a coder at the world's largest internet company, wins a competition to spend a week at a private mountain retreat belonging to Nathan, the reclusive CEO of the company. But when Caleb arrives at the remote location he finds that he will have to participate in a strange and fascinating experiment in which he must interact with the world's first true artificial intelligence, housed in the body of a beautiful robot girl."
            });

            var m16 = svc.AddMovie(new Movie
            {
                Title = "Shutter Island",
                Director = "Martin Scorsese",
                Year = 2010,
                Duration = 138,
                Budget = 80000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/kve20tXwUZpu4GUX8l6X7Z4jmL6.jpg",
                Genre = Genre.Thriller,
                Cast = "Leonardo DiCaprio, Mark Ruffalo, Ben Kingsley, Emily Mortimer, Michelle Williams",
                Plot = "World War II soldier-turned-U.S. Marshal Teddy Daniels investigates the disappearance of a patient from a hospital for the criminally insane, but his efforts are compromised by his troubling visions and also by a mysterious doctor."
            });

            var m17 = svc.AddMovie(new Movie
            {
                Title = "Zodiac",
                Director = "David Fincher",
                Year = 2007,
                Duration = 157,
                Budget = 65000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/original/1bkyxWWMPWMZFMPCfUIWsgXcNsM.jpg",
                Genre = Genre.Thriller,
                Cast = "Jake Gyllenhaal, Mark Ruffalo, Robert Downey Jr., Anthony Edwards, Brian Cox",
                Plot = "The true story of the investigation of the 'Zodiac Killer', a serial killer who terrified the San Francisco Bay Area, taunting police with his ciphers and letters. The case becomes an obsession for three men as their lives and careers are built and destroyed by the endless trail of clues."
            });

            var m18 = svc.AddMovie(new Movie
            {
                Title = "No Country for Old Men",
                Director = "Ethan Coen",
                Year = 2007,
                Duration = 122,
                Budget = 25000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/6d5XOczc226jECq0LIX0siKtgHR.jpg",
                Genre = Genre.Western,
                Cast = "Tommy Lee Jones, Javier Bardem, Josh Brolin, Woody Harrelson, Kelly Macdonald",
                Plot = "Llewelyn Moss stumbles upon dead bodies, $2 million and a hoard of heroin in a Texas desert, but methodical killer Anton Chigurh comes looking for it, with local sheriff Ed Tom Bell hot on his trail. The roles of prey and predator blur as the violent pursuit of money and justice collide."
            });

            var m19 = svc.AddMovie(new Movie
            {
                Title = "First They Killed My Father",
                Director = "Angelina Jolie",
                Year = 2017,
                Duration = 136,
                Budget = 24000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/5370jxJfZQY8TUZiiGkpNgvRwU9.jpg",
                Genre = Genre.War,
                Cast = "Sareum Srey Moch, Phoeung Kompheak, Sveng Socheata, Mun Kimhak, Heng Dara",
                Plot = "A 5-year-old girl embarks on a harrowing quest for survival amid the sudden rise and terrifying reign of the Khmer Rouge in Cambodia."
            });

            var m20 = svc.AddMovie(new Movie
            {
                Title = "Inglourious Basterds",
                Director = "Quentin Tarantino",
                Year = 2009,
                Duration = 153,
                Budget = 70000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/7sfbEnaARXDDhKm0CZ7D7uc2sbo.jpg",
                Genre = Genre.War,
                Cast = "Brad Pitt, Mélanie Laurent, Christoph Waltz, Eli Roth, Michael Fassbender",
                Plot = "In Nazi-occupied France during World War II, a group of Jewish-American soldiers known as 'The Basterds' are chosen specifically to spread fear throughout the Third Reich by scalping and brutally killing Nazis. The Basterds, lead by Lt. Aldo Raine soon cross paths with a French-Jewish teenage girl who runs a movie theater in Paris which is targeted by the soldiers."
            });


            // ------------------------------- Reviews -------------------------------

            svc.AddReview(new Review
            {
                Name = "Joshua Avery",
                CreatedOn = DateTime.Now, 
                Comment = "A masterpiece! One of the best movies I've ever seen.", 
                Rating = 10, 
                MovieId = m1.Id
            });

            svc.AddReview(new Review
            {
                Name = "Grace Young",
                CreatedOn = DateTime.Now, 
                Comment = "Incredible movie! You can watch this over and over again, and it never gets old.", 
                Rating = 10, 
                MovieId = m1.Id
            });

            svc.AddReview(new Review
            {
                Name = "Amanda Buckland",
                CreatedOn = DateTime.Now, 
                Comment = "Amazing storytelling backed by a phenomenal cast, highly recommend.", 
                Rating = 10, 
                MovieId = m1.Id
            });

            svc.AddReview(new Review
            {
                Name = "Leonard Hart",
                CreatedOn = DateTime.Now, 
                Comment = "All-star cast but the movie was far from it!", 
                Rating = 3, 
                MovieId = m2.Id
            });

            svc.AddReview(new Review
            {
                Name = "Bella Howard",
                CreatedOn = DateTime.Now, 
                Comment = "Enjoyed it. A fun storyline and the soundtrack is great!", 
                Rating = 7, 
                MovieId = m2.Id
            });

            svc.AddReview(new Review
            {
                Name = "Christian Coleman",
                CreatedOn = DateTime.Now, 
                Comment = "A true classic!", 
                Rating = 10, 
                MovieId = m3.Id
            });

            svc.AddReview(new Review
            {
                Name = "Rachel Bailey",
                CreatedOn = DateTime.Now, 
                Comment = "One of the greatest comedies of all time.", 
                Rating = 10, 
                MovieId = m3.Id
            });

            svc.AddReview(new Review
            {
                Name = "Kylie Wright",
                CreatedOn = DateTime.Now, 
                Comment = "Hilarious comedy! Had me laughing throughout.", 
                Rating = 10, 
                MovieId = m4.Id
            });

            svc.AddReview(new Review
            {
                Name = "Lucas Tucker",
                CreatedOn = DateTime.Now, 
                Comment = "Chick-flicks aren't really my thing but this movie was pretty funny.", 
                Rating = 6, 
                MovieId = m4.Id
            });

            svc.AddReview(new Review
            {
                Name = "Connor Wilson",
                CreatedOn = DateTime.Now, 
                Comment = "So so so funny, this is a comedy classic!", 
                Rating = 9, 
                MovieId = m5.Id
            });

            svc.AddReview(new Review
            {
                Name = "Leah Randall",
                CreatedOn = DateTime.Now, 
                Comment = "Really enjoyed it! If you have a silly sense of humour, this one's for you.", 
                Rating = 7, 
                MovieId = m5.Id
            });

            svc.AddReview(new Review
            {
                Name = "Angela Nash",
                CreatedOn = DateTime.Now, 
                Comment = "A great movie to watch with the family, I'd definitly recommend it.", 
                Rating = 10, 
                MovieId = m6.Id
            });

            svc.AddReview(new Review
            {
                Name = "Jack Vance",
                CreatedOn = DateTime.Now, 
                Comment = "Pretty cool animation with some laughs along the way!", 
                Rating = 7, 
                MovieId = m6.Id
            });

            svc.AddReview(new Review
            {
                Name = "Joseph Davidson",
                CreatedOn = DateTime.Now, 
                Comment = "Mysterious, unsettling and twisted, this is what you call a cult classic.", 
                Rating = 10, 
                MovieId = m7.Id
            });

            svc.AddReview(new Review
            {
                Name = "Natalie Lambert",
                CreatedOn = DateTime.Now, 
                Comment = "A bizzare and original storyline, a must watch for horror fans.", 
                Rating = 8, 
                MovieId = m7.Id
            });

             svc.AddReview(new Review
            {
                Name = "Colin Sharp",
                CreatedOn = DateTime.Now, 
                Comment = "One of the creepest movies I've ever seen with the most unexpected twist!", 
                Rating = 9, 
                MovieId = m8.Id
            });

            svc.AddReview(new Review
            {
                Name = "Julian Hunter",
                CreatedOn = DateTime.Now, 
                Comment = "Amazing movie, and a great performance from Kaluuya. A must watch!", 
                Rating = 10, 
                MovieId = m8.Id
            });

            svc.AddReview(new Review
            {
                Name = "Oliver Pullman",
                CreatedOn = DateTime.Now, 
                Comment = "A bit overrated in my opinion but a good film all the same.", 
                Rating = 7, 
                MovieId = m9.Id
            });

             svc.AddReview(new Review
            {
                Name = "Lauren piper",
                CreatedOn = DateTime.Now, 
                Comment = "Would definitely recommend this one, its a classic with great performances.", 
                Rating = 9, 
                MovieId = m9.Id
            });

             svc.AddReview(new Review
            {
                Name = "Ruth Walsh",
                CreatedOn = DateTime.Now, 
                Comment = "One of the best love stories, its a classic romance and one of my favourite!", 
                Rating = 9, 
                MovieId = m10.Id
            });

             svc.AddReview(new Review
            {
                Name = "Jake Kerr",
                CreatedOn = DateTime.Now, 
                Comment = "Pretty good storyline, I enjoyed it.", 
                Rating = 7, 
                MovieId = m10.Id
            });

            svc.AddReview(new Review
            {
                Name = "Alex Avery",
                CreatedOn = DateTime.Now, 
                Comment = "One of the best movies I've ever seen.", 
                Rating = 10, 
                MovieId = m11.Id
            });

            svc.AddReview(new Review
            {
                Name = "Grace Jones",
                CreatedOn = DateTime.Now, 
                Comment = "Incredible movie!", 
                Rating = 10, 
                MovieId = m11.Id
            });

            svc.AddReview(new Review
            {
                Name = "John Buckland",
                CreatedOn = DateTime.Now, 
                Comment = "Amazing storytelling, highly recommend.", 
                Rating = 10, 
                MovieId = m12.Id
            });

            svc.AddReview(new Review
            {
                Name = "Jane Johnson",
                CreatedOn = DateTime.Now, 
                Comment = "Great movie!", 
                Rating = 8, 
                MovieId = m12.Id
            });

            svc.AddReview(new Review
            {
                Name = "Janelle Howard",
                CreatedOn = DateTime.Now, 
                Comment = "Enjoyed it.", 
                Rating = 7, 
                MovieId = m13.Id
            });

            svc.AddReview(new Review
            {
                Name = "Gerry Coleman",
                CreatedOn = DateTime.Now, 
                Comment = "Such a cool movie!", 
                Rating = 10, 
                MovieId = m13.Id
            });

            svc.AddReview(new Review
            {
                Name = "Bailey Robinson",
                CreatedOn = DateTime.Now, 
                Comment = "Slow burner but good movie.", 
                Rating = 7, 
                MovieId = m14.Id
            });

            svc.AddReview(new Review
            {
                Name = "Kyle Simpson",
                CreatedOn = DateTime.Now, 
                Comment = "One of my faves!", 
                Rating = 8, 
                MovieId = m14.Id
            });

            svc.AddReview(new Review
            {
                Name = "Jake Tucker",
                CreatedOn = DateTime.Now, 
                Comment = "This was kinda boring, not my thing.", 
                Rating = 5, 
                MovieId = m15.Id
            });

            svc.AddReview(new Review
            {
                Name = "Wilson Jones",
                CreatedOn = DateTime.Now, 
                Comment = "Pretty good movie.", 
                Rating = 7, 
                MovieId = m15.Id
            });

            svc.AddReview(new Review
            {
                Name = "Leah Thompson",
                CreatedOn = DateTime.Now, 
                Comment = "Solid movie!", 
                Rating = 8, 
                MovieId = m16.Id
            });

            svc.AddReview(new Review
            {
                Name = "Tom Nash",
                CreatedOn = DateTime.Now, 
                Comment = "One of the best thrillers. Love it.", 
                Rating = 10, 
                MovieId = m16.Id
            });

            svc.AddReview(new Review
            {
                Name = "David Davidson",
                CreatedOn = DateTime.Now, 
                Comment = "Creepy movie, pretty good.", 
                Rating = 7, 
                MovieId = m17.Id
            });

            svc.AddReview(new Review
            {
                Name = "Nathan Lambe",
                CreatedOn = DateTime.Now, 
                Comment = "Based on a true story, a must watch for thriller fans.", 
                Rating = 9, 
                MovieId = m17.Id
            });

             svc.AddReview(new Review
            {
                Name = "Patrick Sharp",
                CreatedOn = DateTime.Now, 
                Comment = "Didn't really like this movie.", 
                Rating = 5, 
                MovieId = m18.Id
            });

            svc.AddReview(new Review
            {
                Name = "Graham Hunter",
                CreatedOn = DateTime.Now, 
                Comment = "A must watch!", 
                Rating = 10, 
                MovieId = m18.Id
            });

            svc.AddReview(new Review
            {
                Name = "Jackie Pullman",
                CreatedOn = DateTime.Now, 
                Comment = "Underrated film, really good!", 
                Rating = 9, 
                MovieId = m19.Id
            });

             svc.AddReview(new Review
            {
                Name = "Ashton piper",
                CreatedOn = DateTime.Now, 
                Comment = "Would definitely recommend this one.", 
                Rating = 7, 
                MovieId = m19.Id
            });

             svc.AddReview(new Review
            {
                Name = "Katie Walsh",
                CreatedOn = DateTime.Now, 
                Comment = "One of the best war movies!", 
                Rating = 9, 
                MovieId = m20.Id
            });

             svc.AddReview(new Review
            {
                Name = "Louise Kerr",
                CreatedOn = DateTime.Now, 
                Comment = "Pretty good storyline, would recommend.", 
                Rating = 7, 
                MovieId = m20.Id
            });


        }
    }
}