using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Условие?????????????
//Дадени са строителни банкноти с номинал 1, 5, 10, 20, 100. Напишете програма, кяото да
//изчислява най-малкия брой банкноти нужни за изплащането на сума amount.

//????????????????????
namespace Tema7_Zadacha
{
    class Program

    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());

            int[] notes = { 1, 5, 10, 20, 100 };      
            int count = 0;

            for (int i = notes.Length - 1; i >= 0 && amount > 0; i--)
            {
                int value = amount / notes[i];
                amount = amount % notes[i];
                //amount = amount - value * notes[i];
                count += value;
            }
            
            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}
