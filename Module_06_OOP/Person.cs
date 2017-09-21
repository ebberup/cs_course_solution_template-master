using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_06_OOP
{
    internal class Person
    {
        private string name;
        private int age;
        private bool alive;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public bool Alive { get => alive; set => alive = value; }

        //ctor
        public Person():this("",0,true)
        {
        }
        public Person(string name, int age,bool alive)
        {
            if (age<0||age>110)
            {
                throw new Exception("Age must be between 0 and 110");
            }
            this.name = name;
            this.age = age;
            this.alive = alive;
        }
    }
}
