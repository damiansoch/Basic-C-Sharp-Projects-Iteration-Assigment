using System;
using System.Collections.Generic;

namespace Iteration_Assigment
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------
            //patr 1
            string[] Texts = { "one:", "two:", "three:", "four:", "five:", "six:", "seven:" };
            Console.WriteLine("Please write some text...");
            string userInput = Console.ReadLine();

            for (int i = 0; i < Texts.Length; i++)
            {
                Texts[i] = Texts[i] + " " + userInput;
            }
            for (int i = 0; i < Texts.Length; i++)
            {
                Console.WriteLine(Texts[i] + "\n");
            }
            Console.ReadLine();


            //-----------------------------------------------
            //part 2
            //for (int i = 0; i >= 0; i++)
            //{
            //    Console.WriteLine("infinie loop");
            //    Console.ReadLine();
            //} 
            //part 2 fixed
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("infinie loop - fixed");
                Console.ReadLine();
            }


            //-----------------------------------------------
            //part 3
            for (int i = 0; i <= Texts.Length - 1; i++)
            {
                Console.WriteLine(Texts[i]);
            }
            Console.ReadLine();

            for (int i = Texts.Length - 1; i > -1; i--)
            {
                Console.WriteLine(Texts[i]);
            }
            Console.ReadLine();


            //-----------------------------------------------
            //part 4
            List<string> carBrands = new List<string> { "Honda", "Alfa Romeo", "Audi", "BMW", "Bentley", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Dodge" };
            bool found = false;
            Console.WriteLine("Please write the car brand");
            string userBrandInput = Console.ReadLine();
            int index = 0;

            foreach (string car in carBrands)
            {
                if (car.ToLower() == userBrandInput.ToLower())
                {
                    Console.WriteLine("The brand you entered is at index: " + "\"" + index + "\"");
                    found = true;
                    Console.ReadLine();
                    break;

                }
                index++;
            }
            if (!found)
            {
                Console.WriteLine("The breand you entered wasn't faund!");
            }
            Console.WriteLine("Indices checked:" + index);
            Console.ReadLine();


            //-----------------------------------------------
            //Part 5
            List<string> programmingLanguages = new List<string> { "C#", "C++", "JavaScript", "Java", "C#", "Kotlin", "Python", "PHP", "Ruby", "C#" };
            Console.WriteLine("Enter the name of programming language.");
            string userLanguageInput = Console.ReadLine();
            bool foundMatch = false;
            for (int i = 0; i < programmingLanguages.Count; i++)
            {
                if (userLanguageInput.ToLower() == programmingLanguages[i].ToLower())
                {
                    Console.WriteLine("Match fount. Maching index: " + i);
                    foundMatch = true;
                }
            }
            if (!foundMatch)
            {
                Console.WriteLine("The language you entered wasnt found!");
            }
            Console.ReadLine();


            //-----------------------------------------------
            //Part 6

            //There is a couple of ways to to it bot i will
            // create new list, if club already in the new list the message "Club already on the list" will be shown
            //if club is not in the new list, it will be added to it

            List<string> footballClubs = new List<string> { "Real Madrid", "Barcelona", "Manchester United", "Juventus", "Cheslea", "Paris-Saint-German", "Barcelona", "Cheslea", "Bayern Munich", "Barcelona" };
            List<string> newFootballClubs = new List<string> { };
            foreach (string club in footballClubs)
            {
                Console.WriteLine(club);
                bool alreadyListed = newFootballClubs.Contains(club);
                if (alreadyListed)
                {
                    Console.WriteLine("Item already appered!" + "\n");
                }
                else
                {
                    Console.WriteLine("\n");
                }
                newFootballClubs.Add(club);
            }
            Console.ReadLine();
        }
    }
}
