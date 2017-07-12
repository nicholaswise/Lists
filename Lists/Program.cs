using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> favNumbers = new List<int>();
            favNumbers.Add(7);
            favNumbers.Add(25);
            favNumbers.Add(30);

            //foreach (int number in favNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            //Use the Count property to get the length of the list
            Console.WriteLine(favNumbers.Count);
            List<string> books = new List<string> { "Cat in the Hat", "Toad and Frog", "Green Eggs and Ham" };
            Console.WriteLine(books[0]);
            //Inserts at the current index moving the previous element down one
            books.Insert(0, "Horton Hears a Who");
            Console.WriteLine(books[0]);*/

            //Create a list and add 5 animals using the .Add()
            //Print each animal in the list

            //List<string> animals = new List<string>();
            //animals.Add("Lion");
            //animals.Add("Tiger");
            //animals.Add("Bear");
            //animals.Add("Koala");
            //animals.Add("Giraffe");
            //foreach(string animal in animals)
            //{
            //    Console.WriteLine(animal);
            //}

            ////Create the following list: a bool list {true,false,false,true,false}
            ////loop through each value
            ////if the value is true print "better bring an umbrella"
            ////if the value is false print "no rain today enjoy the sun"

            //List<bool> boolList = new List<bool> { true, false, false, true, false };
            //foreach (bool word in boolList)
            //{
            //    if (word == true)
            //    {
            //        Console.WriteLine("Better bring an umbrella!");
            //    }
            //    if (word == false)
            //    {
            //        Console.WriteLine("No rain today enjoy the sun!");
            //    }
            //}

            //List<string> favoriteFoods = new List<string>() { "Steak", "Pizza", "BBQ", "Ramen", "Hot Sauce" };

            //if(favoriteFoods.Contains("Ramen"))
            //{
            //    Console.WriteLine("Ahh yes, Ramen is great");
            //}

            //create a list with the following numbers: 1,23,9,77,922,6,32,63,14,5
            //use the contains method with the following values: 23,77,15
            //remove these elements: 27,77,32, and 6
            //use Contains() again on these values: 23,77,15

            //List <int> numList = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            //if (numList.Contains(23))
            //{
            //    Console.WriteLine("True");
            //}
            //if(numList.Contains(23))
            //{
            //    numList.RemoveAt(1);
            //}
            //if(numList.Contains(77))
            //{
            //    Console.WriteLine("True");
            //}
            //if (numList.Contains(77))
            //{
            //    numList.RemoveAt(3);
            //}
            //if(numList.Contains(15))
            //{
            //    Console.WriteLine("False");
            //}
            //if(numList.Contains(32))
            //{
            //    numList.RemoveAt(6);
            //}
            //if(numList.Contains(6))
            //{
            //    numList.RemoveAt(5);
            //}

            //Ask the user for a movie
            //if the movie is not in the list add it
            //inform the user that the movie has been added
            //if the user enters quit the program should exit
            //The user should be abkle to add as many movies as they want

            List<string> movieNames = new List<string>() { "GUARDIANS OF THE GALAXY", "BABY DRIVER", "WONDER WOMAN", "OKJA" };
            Console.WriteLine("Please enter a movie you would like to watch: ");
            string userMovie = Console.ReadLine();
            string userMovieAny = userMovie.ToUpper();
            if (userMovieAny == movieNames[0] || userMovieAny == movieNames[1] || userMovieAny == movieNames[2] || userMovieAny == movieNames[3])
            {
                Console.WriteLine("Enjoy your Movie!");
                Environment.Exit(0);
            }
            if (userMovieAny == "QUIT")
            {
                Console.WriteLine("Sorry to see you go!");
                Environment.Exit(0);
            }
            if (userMovieAny != movieNames[0] || userMovieAny != movieNames[1] || userMovieAny != movieNames[2] || userMovieAny != movieNames[3])
            {
                Console.WriteLine("This movie is unavailable, would you like to add it to watch later? Y/N ");
                string userResponse = Console.ReadLine();
                string userResponseAny = userResponse.ToUpper();
                if (userResponseAny == "Y")
                {
                    movieNames.Add(userResponseAny);
                    Console.WriteLine("Thank you, your movie will be available in 3-5 business days.");
                    Console.WriteLine("Would you like to add another movie to your list? Y/N ");
                    string userAnother = Console.ReadLine();
                    string userAnotherAny = userAnother.ToUpper();
                    if (userAnotherAny == "N")
                    {

                    }

                }
                else if (userResponseAny == "N")
                {
                    Console.WriteLine("No worries! We're sorry your movie was unavailable!");
                    Environment.Exit(0);
                }
                else if (userResponseAny == "QUIT")
                {
                    Console.WriteLine("Sorry to see you go!");
                    Environment.Exit(0);
                }

            }





        }
    }
}
