using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_Java_Animal
{
    public class Dog : Pet, Talkable
    {
        private Boolean friendly;

        public Dog(string name, Boolean friendly) : base(name)
        {
            this.friendly = friendly;
        }

        public Boolean IsFriendly()
        {
            return friendly;
        }

        public String Talk()
        {
            return "Bark";
        }

        public override string ToString()
        {
            return "Dog: " + " name= " + base.name + " Friendly= " + friendly;
        }
    }
}
