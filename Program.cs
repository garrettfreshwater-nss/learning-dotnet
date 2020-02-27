//"using" import statenents. SYSTEM gives access to console
using System;
using System.Collections.Generic;

namespace MyApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World!";
            int numberOfTacos = 2;
            bool hasMeat = true;

            // array list
            List<string> names = new List<string>() { "Adam", "Brenda", "Rose" };

            // for loops
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            // for each
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // conditionals

            if (numberOfTacos > 5)
            {
                Console.WriteLine("Oh Boy, thasalotta tacos.");
            }
            else if (numberOfTacos < 3)
            {
                Console.WriteLine("Level up your taco game");
            }
            else
            {
                Console.WriteLine("Sounds like a good number o' tacos.");
            }


            //string concatination
            Console.WriteLine(message + " " + "I would like " + numberOfTacos + " Tacos. Meat? " + hasMeat);
            //string interpolation
            Console.WriteLine($"{message} I'd like {numberOfTacos} tacos. Meat? {hasMeat}");
        }
    }
}