﻿using System;

namespace z1
{
    abstract class Person : IAmPerson
    {
        public byte age;

        protected string sex;
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Adress { get; set; }

        protected int ID;
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person() : this("Unknown", 0, "Unknown", CreateID())
        { }

        public Person(string name) : this(name, 0, "Unknown", CreateID())
        { }

        public Person(string name, byte age) : this(name, age, "Unknown", CreateID())
        { }

        public Person(string name, byte age, string sex) : this(name, age, sex, CreateID())
        { }


        public Person(string name, byte age, string sex, int id)
        {
            Name = name;
            Age = age;
            Sex = sex;
            ID = id;
        }

        public int CompareTo(object obj)
        {
            Person m = obj as Person;
            if (m != null)
                return ID.CompareTo(m.ID);
            throw new Exception("Невозможно сравнить эти объекты!");
        }

        public string Sex
        {
            set
            {
                if (Name == "Dima" && value == "female")
                    throw new ArgumentException();
                else
                if (value == "male" || value == "female")
                    sex = value;
                else
                    sex = "Unknown";
            }

            get { return sex; }
        }

        public byte Age
        {
            set
            {
                if (value >= 1 && value <= 100)
                    age = value;
                else
                    age = 0;
            }

            get { return age; }
        }

        public virtual string Show()
        {
            return ($"Name: {Name}\nAge: {age.ToString()}\nSex: {sex}");
        }

        static Random rnd = new Random();

        public static int CreateID()
        {
            return rnd.Next(1000, 10000);
        }

        public abstract string ShowMarks();
    }
}
