using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Zadacha
{
    class Employee
    {
        private String Name { get; set; }
        private int Age { get; set; }
        private double Salary { get; set; }

        public Employee(string firstName, string lastName, int age, double salary)
        {
            this.Name = firstName + " " + lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public void IncreaseSalary(double bonus)
        {
            if (this.Age >= 30)
            {
                this.Salary += this.Salary * bonus / 100;
            }
            else
            {
                this.Salary += this.Salary * bonus / 200;
            }
        }
        public override string ToString()
        {

            return this.Name + " get " + Math.Round(this.Salary, 2).ToString("F2") + " leva.";

        }
    }    
}
/*
5
Asen Ivanov 65 2200
Boiko Borisov 57 3333
Ventsislav Ivanov 27 600
Asen Harizanoov 44 666,66
Boiko Angelov 35 559,42
 
 */
