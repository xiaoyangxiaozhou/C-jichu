using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06继承
{
    public class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set {_name=value;}
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private char _gender;
        public char Gengder
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Gengder = gender;
            this.Age = age;
        }
    }
}
