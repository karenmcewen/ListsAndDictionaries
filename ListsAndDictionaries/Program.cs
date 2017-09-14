using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //     List<string> faveFoods = new List<string>() { "pizza", "alfredo", "chicken", "sushi", "broccoli" };
            //     //Console.WriteLine(faveFoods[0]); //lists use indexes like arrays
            //     //Console.WriteLine(faveFoods[4]);

            //     //faveFoods.Add("ice cream"); //.Add - adds to the end and makes list longer
            //     //Console.WriteLine(faveFoods[5]);
            //     //faveFoods.Remove("pizza");
            //     //Console.WriteLine(faveFoods[0]);

            //     //faveFoods.Insert(0, "bread"); //.Insert - inserts at selected inded and moves everything over
            //     //Console.WriteLine(faveFoods[0]);
            //     //Console.WriteLine(faveFoods[1]);

            //     //faveFoods.RemoveAt(3);//.RemoveAt - removes at index and moves over the rest
            //     foreach (string food in faveFoods) //this loop will print each food in the list
            //     {
            //         Console.WriteLine(food);
            //     }


            //     //List<int> luckyNums = new List<int>();//if don't know elements, use .Add
            //     //luckyNums.Add(13);
            //     //luckyNums.Add(8);
            //     //luckyNums.Add(44);
            //     //luckyNums.Add(7);

            //     //List<string> faveFilms = new List<string>() { "Wall-E", "Superwoman", "Casablanca" };
            //     //faveFilms.Insert(0, "The Big Sick");
            //     //faveFilms.Insert(3, "Dumbo");
            // //lists use .Count to go through the list, while Arrays step through to .Length
            //     //for (int counter = 0; counter < faveFilms.Count; counter++) 
            //     //{
            //     //    Console.WriteLine(faveFilms[counter]);
            //     //}


            //     //foreach (string film in faveFilms)
            //     //{
            //     //    Console.WriteLine(film);
            //     //}

            //     //faveFilms.Remove("casablanca");
            //     //faveFilms.Remove("superwoman");

            //     //foreach (string movie in faveFilms)
            //     //{
            //     //    Console.WriteLine(movie);
            //     //}

            //     //List<string> animals = new List<string>();
            //     //animals.Add("monkey");
            //     //animals.Add("parrot");
            //     //animals.Add("tiger");
            //     //animals.Add("lion");
            //     //animals.Add("bear");
            //     //foreach(string killer in animals)
            //     //{
            //     //    Console.WriteLine(killer);
            //     //}

            //     //List<bool> boolList = new List<bool>() { true, false, false, true, false };
            //     //foreach (bool rain in boolList)
            //     //{
            //     //    Console.WriteLine(rain);
            //     //    if (rain == true)
            //     //    {
            //     //        Console.WriteLine("Better bring an umbrella!");
            //     //    }
            //     //   else
            //     //    {
            //     //        Console.WriteLine("No rain today, enjoy the sun!");
            //     //    }

            //     //for(int counter = 0; counter < boolList.Count; counter++)
            //     //{
            //     //    if (boolList[counter] == true)
            //     //    {
            //     //        Console.WriteLine("Bring an umbrella!!");
            //     //    }
            //     //    else
            //     //    {
            //     //        Console.WriteLine("Enjoy the sun!");
            //     //    }



            //     //numberList.Remove(77);
            //     //numberList.Remove(32);
            //     //numberList.Remove(6);
            //     //Console.WriteLine(numberList.Contains(23));
            //     //Console.WriteLine(numberList.Contains(77));
            //     //Console.WriteLine(numberList.Contains(15));

            ////DICTIONARIES- a data collection of key value pairs, all keys are same data type 
            //      //also called hashTables
            //     //and all values are the same data type. 
            //     // each key is a unique identifier. Values do not have to be unique. 
            //      //it is easier to search by key than by value

            //Tkey is an int will be number, TValue is a string will be coat type
            //dictionary is just a place to store information
            //syntax Dictionary<TKey type, TValue type> nameDictionary = new Dictionary<TKey type, TValue type>
            //Dictionary<int, string> coatCheck = new Dictionary<int, string>() //no semi-colon here, put at end of {}
            //{
            //    {23, "Yellow Jacket"},
            //    {14,"Blue Blazer" },
            //    {3,"White Trenchcoat" },
            //    {56,"Purple Poncho" },
            //    {68, "Brown Tweed" } //last item doesn't need a comma
            //};

            ////print out all values of the dictionary
            //foreach (KeyValuePair<int, string> coat in coatCheck)
            //{
            //    Console.WriteLine(coat);
            //}

            ////count the number of entries or key-value pairs - uses property .Count
            //Console.WriteLine(coatCheck.Count);

            ////just print out the keys and then the values
            //foreach (KeyValuePair<int,string> coat in coatCheck)
            //{
            //    Console.WriteLine(coat.Key);
            //    Console.WriteLine(coat.Value);
            //}

            //note- if you search by value, you will find the FIRST instance only, bec. value is not unique

            //EXAMPLE - Create a dictionary for a car valet service with 10 cars
            //the key will be the customer's last name
            //the value will be the car make
            //print all elements to the console

            //Dictionary<string, string> carValet = new Dictionary<string, string>()
            //{
            //    {"Smith","Ford" },
            //    {"Jones", "Chevy"},
            //    {"Attica", "Mazda" },
            //    {"Li", "Toyota" },
            //    {"Ng", "Mitsubishi" },
            //    {"Bruce", "Buick" },
            //    {"Brown","Ford" },
            //    {"Tesla", "Tesla" },
            //    {"Marley", "Chevy" },
            //    {"McEwen", "Honda" }

            //}; //don't forget to put the semicolon here after defining the values

            //foreach (KeyValuePair<string, string> lastName in carValet)
            //{
            //    Console.WriteLine(lastName);
            //}

            //EXAMPLE - Create a dictionary of 10 zoo animals
            //key = aniumal type
            //value = number of that type at the zoo
            //remove the zoo animal with the lowest quantity using .Remove
            //Use the .Count property to count the number of remaining entries in the dictionary. Print this to console

            Dictionary<string, int> animalsAtZoo = new Dictionary<string, int>
            {
                {"lion", 3 },
                {"tiger", 4 },
                {"bear", 2 },
                {"octopus", 1},
                {"flamingo", 30 },
                {"turtle", 8},
                {"monkey", 22},
                {"platypus",3 },
                {"tortoise", 5 },
                {"elephant", 6}

            };            

            animalsAtZoo.Remove("octopus");
            Console.WriteLine(animalsAtZoo.Count +" animal types remain at the zoo");

            //Example 3 - Create a program that allows a user to input an animal name to check to see
            //whether the dictionary contains the animal already.
            //if not, allow the user to add the animal to the dictionary

            string animal;
            Console.WriteLine("What animal do you want to search for in the dictionary?");
            animal = Console.ReadLine();
            

            foreach (KeyValuePair<string, int> animalType in animalsAtZoo)
            {
                if (animalsAtZoo.ContainsKey(animal) == true)
                {
                    Console.WriteLine("{0} already exists in the dictionary", animal);
                    break;
                }

                else
                {
                    Console.WriteLine("Would you like to add this animal?");
                    string addAnimal = Console.ReadLine();
                    int numAnimal = 0;
                    if (addAnimal.ToLower() == "yes")
                    {
                        Console.WriteLine("How many {0} are there?", animal);
                        numAnimal = int.Parse(Console.ReadLine());
                        animalsAtZoo.Add(animal, numAnimal);
                    }
                    
                }


            }
            //This is the example from Ric
            //bool IsPrime = true;
            //Console.WriteLine("Prime numbers: ");
            //for (int i = 2; i <= 1000; i++)
            //{
            //    for (int j = 2; j < 1000; j++)
            //    {
            //        if (i != j && i % j == 0)
            //        {
            //            IsPrime = false;
            //            break;
            //        }
            //    }
            //    if (IsPrime)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    IsPrime = true;




            //}
            ///////////////////////////here thar be dragons/////////////////////
        }
    }
}
