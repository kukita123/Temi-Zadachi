using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Да се напише програма, която позволява да се въведе размер на масив и стойностите на
неговите елементи и после го подрежда така, че стойностите на елементите да нарастват от
началото до средата на масива и след това отново да намаляват от средата до края. Елементите
от първата половина на масива не трябва да преминават във втората му половина. Полученият
масив трябва да бъде отпечатан.
Вход:
● Входните данни трябва да се прочетат от конзолата.
● На първия ред се подава цяло четно число N, съдържащо броят на числата в масива
● На втория ред се подават N цели числа, отделени едно от друго с интервал. Това са
стойностите на елементите в масива.
● Входните данни винаги ще са валидни и в описания формат. Не е необходимо да бъдат
изрично проверявани.
Изход:
● Изходните данни („уравновесеният“ масив) трябва да бъдат отпечатани на конзолата.
 */
namespace Tema6_Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ').Select(int.Parse);

            var arr1 = input.Take(n / 2);
            var arr2 = input.Skip(n / 2);
            

            var arr1New = arr1.ToArray<int>();
            var arr2New = arr2.ToArray<int>();

            Array.Sort(arr1New);
            Array.Sort(arr2New);
            Array.Reverse(arr2New);    
            
            

            Console.WriteLine(string.Join(" ", arr1New) + " " + string.Join(" ", arr2New));

            //or:
            var result = new int[input.Count()];
            for (int i = 0; i < arr1New.Count(); i++)
            {
                result[i] = arr1New[i];
            }
            for (int i = 0; i < arr2New.Count(); i++)
            {
                result[result.Count() / 2 + i] = arr2New[i];
            }
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //or:
            List<int> ListResult = new List<int>();
            foreach (var item in arr1New)
            {
                ListResult.Add(item);
            }
            foreach (var item in arr2New)
            {
                ListResult.Add(item);
            }
            var ResultArray = ListResult.ToArray();
            Console.WriteLine(String.Join(" ", ResultArray));

            Console.ReadKey();
            
        }
    }
}
/*
7
3 76 -1 33 2 22 98
  
10
4 2 6 3 8 1 7 4 2 9  
  
  
 
 */
