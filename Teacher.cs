using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_Java_Animal
{
    public class Teacher: Person, Talkable
    {
        private int age;

        public Teacher(int age, String name) : base(name)
        {
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public String Talk()
        {
            return "Don't forget to do the assigned reading!";
        }

        public override string ToString()
        {
            return "Teacher: " + " name= " + base.GetName() + " age= " + age;
        }
    }
}
