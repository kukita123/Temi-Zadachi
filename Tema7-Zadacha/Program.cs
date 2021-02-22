using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//????????????????????

//Условие?????????????

//????????????????????
namespace Tema7_Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            int count = 0;
            int value = int.MinValue;

            int[] notes = { 1, 5, 10, 20, 100 };
            for (int i = notes.Length -1; i >= 0 && amount>0; i--)
            {
                value = amount / notes[i];                
            }
            count += value;
            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}
