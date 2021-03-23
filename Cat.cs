using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_Java_Animal
{
    public class Cat:Pet, Talkable
    {
        
        private int mouseKilled;

        public Cat(int mouseKilled, String name) : base(name)
        {
            this.mouseKilled = mouseKilled;
        }

        public int GetMouseKilled()
        {
            return mouseKilled;
        }

        public void AddMouse()
        {
            mouseKilled++;
        }

        public string Talk()
        {
            return "Meow";
        }

        public override string ToString()
        {
            return "Cat: " + " name= " + base.name + " MouseKilled= " + mouseKilled;
        }
    }
}
