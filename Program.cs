using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace myShortStory
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Hello I am a short story creator, with \nthe information that" +
                "you give me I will write an amazing story about your heros journey");
            Console.WriteLine("Name");
            string name = Console.ReadLine();
            Console.WriteLine("Age");
            string age = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Gender, male or female.");
            string gender = Console.ReadLine();
            Console.WriteLine("What place have you always wanted to visit");
            string location = Console.ReadLine();

            if (gender == "male")
            {
                string Pronoun = "He";
                string pronoun = "he";
                string Possessive = "His";
                string possessive = "his";

                Console.WriteLine(storyCreator(name, age, gender, location, pronoun, possessive));

            }
            else
            {
                string Pronoun = "She";
                string pronoun = "she";
                string Possessive = "Her";
                string possessive = "her";

                Console.WriteLine(storyCreator(name, age, gender, location, pronoun, possessive));

            }






            Console.ReadLine();
        }


        static string storyCreator(string name, string age, string gender, string location, string pronoun, string possessive)
        {
            string story =(name + " was a brave young adventurer who had been tasked with " +
                    "\njourneying through the treacherous forest to deliver a sacred artifact to a " +
                    "\ndistant village. Despite being only " + age + " years old, " + pronoun +
                    "\nhad already earned a reputation as one of the most fearless heroes in the land." +
                    "\n\nArmed with nothing but a sword and a fierce determination, " + name + " marched ever " +
                    "\nonwards towards " + location + ". Along the way, " + pronoun + " battled countles\nmonsters " +
                    "and overcame countless obstacles, \nalways keeping the safety of the " +
                    "\nartifact at the forefront of " + possessive + " mind. Though " +
                    name + " faced many moments of doubt and fear, " +
                    pronoun + " never wavered, and ultimately succeeded in completing " +
                    possessive + " mission and delivering the artifact to its rightful owners.");
            return story;
        }

        

        }


}
