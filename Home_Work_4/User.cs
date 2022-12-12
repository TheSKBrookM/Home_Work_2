using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_4
{
    internal class User
    {
        string login, name, surname;
        int age;
        public readonly DateTime date;

        public string Login
        {
            get
            {
                if (login == null)
                {
                    return "Login не вказано";
                }
                return login;
            }
            set
            {
                login = value;
            }
        }
        public string Name
        {
            get
            {
                if (name == null)
                {
                    return "Name не вказано";
                }
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                if (surname == null)
                {
                    return "Surname не вказано";
                }
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public int Age
        {
            get
            {
                if (age <= 0)
                {
                    return 25;
                }
                return age;
            }
            set
            {
                age = value;
            }
        }
        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            date = DateTime.Now;
        }
        public User()
        {
            date = DateTime.Now;
        }
    }
}
