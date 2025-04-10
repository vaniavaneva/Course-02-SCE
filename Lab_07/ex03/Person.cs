using System;

namespace ex03
{
    class Person
    {
        private string name, lastName, number;

        public Person()
        {

        }

        public Person(string name, string lastName, string number)
        {
            this.name = name;
            this.lastName = lastName;
            this.number = number;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public void Output()
        {
            Console.WriteLine($"First name: {name}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Phone number: {number}");
        }
    }
}
