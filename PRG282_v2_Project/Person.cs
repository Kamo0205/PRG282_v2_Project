using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_v2_Project
{
    /*
    enum Ranks
    {
        Soldier = 1,
        Luitenant,
        Captain,
        PettyOfficer,
        Comodore,
        Commander,
        Admiral
    }
    */
    class Person
    {
        private string id;
        private string name;
        private string surname;
        private int age;
        private string rank;
        private string username;
        private string password;

        public Person(string id, string name, string surname, int age, string rank, string password)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.rank = rank;
            this.username = this.name.Substring(0, 2) + this.surname.Substring(this.surname.Length - 3, 2);
            this.password = password;
        }

        public string Id { get => id; }
        public string Name { get => name; }
        public string Surname { get => surname; }
        public int Age { get => age; }
        public string Rank { get => rank; }
        public string Username { get => username; }
        public string Password { get => password; }

        public override string ToString()
        {
            return string.Format("");
        }
    }
}
