using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_Java_Animal
{
    public class  Menu
    {

        private ArrayList animals;
        private ArrayList options;

        public Menu(ArrayList animals, ArrayList options)
        {
            this.animals = animals;
            this.options = options;
        }

        public ArrayList ShowMenu()
        {
            Console.WriteLine("=== Menu ===");

            foreach (var pet in options)
            {
                Console.WriteLine("-" + pet.ToString().ToUpper());
            }

            Console.WriteLine("Enter the type of animal to create and press enter:");
            string input = Console.ReadLine().ToUpper();

            while (input != null)
            {
                if (options.Contains(input))
                {
                    try
                    {
                        switch (input)
                        {
                            case "DOG":

                                string name = null;

                                do
                                {
                                    Console.WriteLine("What is the dog's name?");
                                    name = Console.ReadLine();
                                } while (name == null);

                                Console.WriteLine($"Is {name} friendly (true or false) ?");
                                string friendly = Console.ReadLine();

                                if (friendly.ToLower().Equals("t") || friendly.ToLower                  ().Equals("true"))
                                {
                                    animals.Add(new Dog(name, true));
                                } else
                                {
                                    animals.Add(new Dog(name, false));
                                }

                                return animals;
                                                                
                            case "CAT":

                                name = null;

                                do
                                {
                                    Console.WriteLine("What is the cat's name?");
                                    name = Console.ReadLine();
                                } while (name == null);

                                Console.WriteLine($"How many mice have been killed by {name} ?");
                                string mice = Console.ReadLine();

                                try
                                {
                                    int miceKilled = Int32.Parse(mice);
                                    animals.Add(new Cat(miceKilled, name));

                                } catch (FormatException)
                                {
                                    Console.WriteLine($"Unable to input mice '{mice}'");
                                }

                                return animals;

                            default:
                                Console.WriteLine($"Unable to create '{input}'");
                                return animals;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"Unable to create '{input}'");
                        return animals;
                    }

                }
                else
                {
                    Console.WriteLine("Do not know that animal.");
                    return animals;
                }
            }
            return animals;
        }
    }
}
