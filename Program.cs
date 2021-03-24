using System;
using System.Collections;
using System.Collections.Generic;

namespace Adv_Java_Animal
{
    class Program
    {
        private readonly static FileOutput outFile = new FileOutput("animals.txt");
        private readonly static FileInput inFile = new FileInput("animals.txt");

        public static void Main(string[] args)
        {
            ArrayList zoo = new ArrayList();

            // *** REPLACE ***
            //zoo.Add(new Dog("Bean", true));
            //zoo.Add(new Cat(9, "Charlie"));
            //zoo.Add(new Teacher(44, "Stacy Read"));

            ArrayList options = new ArrayList() { "DOG", "CAT" };
            Menu menu = new Menu(zoo, options);

            string createAnimals = null;

            do
            {
                Console.WriteLine("Create Animals (Y/N)?");
                createAnimals = Console.ReadLine().ToUpper();

                if (createAnimals == "Y" || createAnimals == "YES")
                {
                    menu.ShowMenu();
                }
                else
                {
                    break;
                }

            } while (createAnimals != null);
            

            foreach (Talkable thing in zoo)
            {
                Console.WriteLine(thing);
                //PrintOut(thing);
            }

            //outFile.FileClose();
            //inFile.FileRead();
            //inFile.FileClose();

            //FileInput inData = new FileInput("animals.txt");
            //String line;
            //while ((line = inData.FileReadLine()) != null)
            //{
            //    Console.WriteLine(line);
            //}
        }

        //public static void PrintOut(Talkable p)
        //{
        //    Console.WriteLine(p.GetName() + " says=" + p.Talk());
        //    outFile.FileWrite(p.GetName() + " | " + p.Talk());
        //}
    }
}
