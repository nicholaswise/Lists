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

            List<string> favoriteFoods = new List<string>() { "Steak", "Pizza", "BBQ", "Ramen", "Hot Sauce" };

            if(favoriteFoods.Contains("Ramen"))
            {
                Console.WriteLine("Ahh yes, Ramen is great");
            }



        }
    }
}
