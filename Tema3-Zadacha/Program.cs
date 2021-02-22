using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var employee = new Employee(cmdArgs[0],
                                            cmdArgs[1],
                                            int.Parse(cmdArgs[2]),
                                            double.Parse(cmdArgs[3])
                                            );
                employees.Add(employee);
            }
            var bonus = double.Parse(Console.ReadLine());

            //foreach (var item in employees)
            //{
            //    item.IncreaseSalary(bonus);
            //}

            //or: 

            employees.ForEach(item => item.IncreaseSalary(bonus));

            employees.ForEach(item => Console.WriteLine(item.ToString()));
          

            Console.ReadKey();
        }
    }
}
/*
5
Asen Ivanov 65 2200
Boiko Borisov 57 3333
Ventsislav Ivanov 27 600
Asen Harizanoov 44 666,66
Boiko Angelov 35 559,420
20
 */
