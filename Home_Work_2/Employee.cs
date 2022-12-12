using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_2
{
    internal class Employee
    {
        readonly string name, surname;
        int expirience;
        string position;

        public Employee()
        { 
        }

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public string Name { get { return name; } }
        public string Surname { get { return surname; } }

        public string Position 
        { 
            get 
            {
                if (position == null)
                {
                    return "Невідома позиція";
                }
                return position; 
            }
            set 
            {
                if (value != null)
                {
                    position = value;
                }
            }
        }

        public int Expirience 
        { 
            get 
            { 
                return expirience; 
            }
            set 
            { 
                if(value >= 0)
                expirience = value; 
            }
        }

        public double SalaryCalculate()
        {
            double salaryPercenteg;
            switch (position.ToLower())
            {   
                case "junior": salaryPercenteg = 200;
                    break;
                case "middle": salaryPercenteg = 400;
                    break;
                case "senior": salaryPercenteg = 800;
                    break;
                case "team lead": salaryPercenteg = 900;
                    break;
                case "tech lead": salaryPercenteg = 1000;
                    break;
                default: salaryPercenteg = 100;
                    break;
            }

            switch (expirience)
            {
                case 0: salaryPercenteg *= 1.5;
                    break;
                case 1: salaryPercenteg *= 2;
                    break;
                case 2: salaryPercenteg *= 2.5;
                    break;
                default: salaryPercenteg *= 3;
                    break;
            }
            return salaryPercenteg;
                
        }

        public void Show()
        {
            Console.WriteLine($"Заробiтня плата: {SalaryCalculate()}\nПодатковий збiр: {SalaryCalculate() * 0.13}");
        }

    }
}
