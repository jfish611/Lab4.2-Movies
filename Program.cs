using System;
using System.Collections.Generic;

namespace Lab4._2_Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool keepGoing = true;

            Movie DumbAndDumber = new Movie("Dumb and Dumber", "Comedy");
            Movie Made = new Movie("Made", "Comedy");
            Movie OhBrotherWhereArtThou = new Movie("Oh Brother Where Art Thou", "Comedy");
            Movie BlazingSaddles = new Movie("Blazing Saddles", "Comedy");
            Movie AirPlane = new Movie("Airplane", "Comedy");
            Movie RadersOfTheLostArk = new Movie("Raiders of the Lost Ark", "Action");
            Movie Apocalypto = new Movie("Apocalypto", "Action");
            Movie Predator = new Movie("Predator", "Action");
            Movie Terminator = new Movie("Terminator", "Action");
            Movie CasinoRoyal = new Movie("Casino Royal", "Action");
            Movie TheIncredibles = new Movie("The Incredibles", "Animated");
            Movie ToyStory = new Movie("Toy Story", "Animated");
            Movie TheLegoMovie = new Movie("The Lego Movie", "Animated");
            Movie HowToTrainYourDragon = new Movie("How to Train your Dragon", "Animated");
            Movie BeautyAndTheBeast = new Movie("Beauty and the Beast", "Animated");
            Movie TheJoker= new Movie("The Joker", "Drama");
            Movie ShawshankRedemption = new Movie("Shawshank Redemption", "Drama");
            Movie SchindlersList = new Movie("Schindler's List", "Drama");
            Movie ThePianist = new Movie("The Pianist", "Drama");
            Movie ForestGump = new Movie("Forest Gump", "Drama");
            Movie Psycho = new Movie("Psycho", "Horror");
            Movie NightOfTheLivingDead = new Movie("Night of the Living Dead", "Horror");
            Movie TheBlob= new Movie("The Blob", "Horror");
            Movie SilenceOfTheLambs = new Movie("The Silence of the Lambs", "Horror");
            Movie It = new Movie("It", "Horror");
            Movie StarWars = new Movie("Star Wars", "SciFi");
            Movie PlanetOfTheApes = new Movie("Planet of the Apes", "SciFi");
            Movie StarTrek = new Movie("Star Trek", "SciFi");
            Movie GuardiansOfTheGalaxy = new Movie("Guardians of the Galaxy", "SciFi");
            Movie JurassicPark = new Movie("Jurassic Park", "SciFi");

            List<Movie> movies = new List<Movie>();
            movies.Add(DumbAndDumber);
            movies.Add(Made);
            movies.Add(OhBrotherWhereArtThou);
            movies.Add(BlazingSaddles);
            movies.Add(AirPlane);
            movies.Add(RadersOfTheLostArk);
            movies.Add(Apocalypto);
            movies.Add(Predator);
            movies.Add(Terminator);
            movies.Add(CasinoRoyal);
            movies.Add(TheIncredibles);
            movies.Add(ToyStory);
            movies.Add(TheLegoMovie);
            movies.Add(HowToTrainYourDragon);
            movies.Add(BeautyAndTheBeast);
            movies.Add(TheJoker);
            movies.Add(ShawshankRedemption);
            movies.Add(SchindlersList);
            movies.Add(ThePianist);
            movies.Add(ForestGump);
            movies.Add(Psycho);
            movies.Add(NightOfTheLivingDead);
            movies.Add(TheBlob);
            movies.Add(SilenceOfTheLambs);
            movies.Add(It);
            movies.Add(StarWars);
            movies.Add(PlanetOfTheApes);
            movies.Add(StarTrek);
            movies.Add(GuardiansOfTheGalaxy);
            movies.Add(JurassicPark);
            while (keepGoing)
            {
                Console.WriteLine($"            Movie List            \nThere are currently {movies.Count} movies to select from.\nWhat category are you interested in?\n 1. Comedy\n 2. Action\n 3. Drama\n 4. Animated\n 5. Horror\n 6. Science-Fiction\n ");
                string catSelection = Console.ReadLine();
                int counter = 1;
                if (catSelection == "1")
                {
                    Console.WriteLine("Comedies:");
                    foreach (Movie m in movies)
                    {
                        if (m.Category == "Comedy")
                        {
                            Console.WriteLine($"\t{counter}. {m.Title}");
                            counter++;
                        }
                    }

                }
                else if (catSelection == "2")
                {
                    Console.WriteLine("Action Movies:");
                    foreach (Movie m in movies)
                    {
                        if (m.Category == "Action")
                        {
                            Console.WriteLine($"\t{counter}. {m.Title}");
                            counter++;
                        }
                    }

                }
                else if (catSelection == "3")
                {
                    Console.WriteLine("Drama Movies:");
                    foreach (Movie m in movies)
                    {
                        if (m.Category == "Drama")
                        {
                            Console.WriteLine($"\t{counter}. {m.Title}");
                            counter++;
                        }
                    }

                }
                else if (catSelection == "4")
                {
                    Console.WriteLine("Animated Movies:");
                    foreach (Movie m in movies)
                    {
                        if (m.Category == "Animated")
                        {
                            Console.WriteLine($"\t{counter}. {m.Title}");
                            counter++;
                        }
                    }

                }
                else if (catSelection == "5")
                {
                    //List<Movie> HorrorList = new List<Movie>();
                    Console.WriteLine("Horror Movies:");
                    foreach (Movie m in movies)
                    {
                        if (m.Category == "Horror")
                        {
                            //HorrorList.Add(m);
                            //HorrorList.Sort();
                            //foreach(Movie n in HorrorList)
                            //{ Console.WriteLine($"\t{counter}. {m.Title}");
                            //counter++;

                        Console.WriteLine($"\t{counter}. {m.Title}");
                            counter++;
                        }
                            
                        
                    }

                }
                else if (catSelection == "6")
                {
                    Console.WriteLine("Science-Fiction Movies:");
                    foreach (Movie m in movies)
                    {
                        if (m.Category == "SciFi")
                        {
                            Console.WriteLine($"\t{counter}. {m.Title}");
                            counter++;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("That is not an option. Try again.");
                }
                bool validAns = false;


                do
                {
                    Console.WriteLine("Would you like to keep going? y/n");
                    string keepGoingAnswer = Console.ReadLine();

                    if (keepGoingAnswer.ToLower() == "n")
                    {
                        keepGoing = false;
                        validAns = true;
                    }
                    else if(keepGoingAnswer.ToLower()=="y")
                    {
                        keepGoing = true;
                        validAns = true;
                    }
                    else
                    {
                        Console.WriteLine("That is not valid input. Select 'y' or 'n'.");
                    }
                }
                while (validAns != true);
              


            }


        }
    }
}
