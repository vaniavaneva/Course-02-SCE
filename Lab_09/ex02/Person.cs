using System;

namespace ex02
{
    public class Person
    {
        private string fullName, id, idNum;

        public Person() {}

        public Person(string fullName, string id, string idNum)
        {
            this.fullName = fullName;
            this.id = id;
            this.idNum = idNum;
        }

        public void InputP()
        {
            Console.Write("Full name: ");
            fullName = Console.ReadLine();
            Console.Write("ID: ");
            id = Console.ReadLine();;
            Console.Write("ID number: ");
            idNum = Console.ReadLine();
        }

        public void OutputP()
        {
            Console.WriteLine($"\tFull name: {fullName}");
            Console.WriteLine($"\tID: {id}");
            Console.WriteLine($"\tID number: {idNum}");
        }
    }
}
