using System;
using System.Collections.Generic;

namespace Adv_Java_Animal
{
    class Program
    {
        private readonly static FileOutput outFile = new FileOutput("animals.txt");
        private readonly static FileInput inFile = new FileInput("animals.txt");

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            List<Talkable> zoo = new List<Talkable>();

            zoo.Add(new Dog("Bean", true));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44, "Stacy Read"));

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
