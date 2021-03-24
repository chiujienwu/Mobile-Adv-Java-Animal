using System;
using System.Collections;
using System.Collections.Generic;

namespace Adv_Java_Animal
{
    class Program
    {
        //private static FileOutput outFile = new FileOutput("animals.txt");
        //private static FileInput inFile = new FileInput("animals.txt");

        public static void Main(string[] args)
        {
            ArrayList zoo = new ArrayList();

            // *** REPLACE ***
            //zoo.Add(new Dog("Bean", true));
            //zoo.Add(new Cat(9, "Charlie"));
            //zoo.Add(new Teacher(44, "Stacy Read"));

            ArrayList options = new ArrayList() { "DOG", "CAT" };
            Menu menu = new Menu(zoo, options);

            string createAnimals;

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

            FileOutput outFile = new FileOutput("animals.txt");

            foreach (Talkable thing in zoo)
            {
                //Console.WriteLine(thing);
                outFile.FileWrite(thing.ToString());
            }

            outFile.FileClose();
            //inFile.fileRead();
            //inFile.fileClose();

            FileInput inData = new FileInput("animals.txt");
            String line;
            while ((line = inData.FileReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            inData.FileClose();
        }

        //public static void PrintOut(Talkable p)
        //{
        //    Console.WriteLine(p.GetName() + " says=" + p.Talk());
        //    outFile.FileWrite(p.GetName() + " | " + p.Talk());
        //}
    }
}
